using Domain.Entities;
using Domain.Event;
using Domain.EventHandlers;
using Domain.ExtensionMethod;
using Domain.ExternalEntities;
using Domain.Interfaces.Aws;
using Domain.Interfaces.Bus;
using Domain.Interfaces.Repository;
using Domain.Notifications;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.EventHandler
{
    public class AtualizarEmpresaEventHandler : EventHandlerBase, INotificationHandler<AtualizarEmpresaEvent>
    {
        private readonly IEmpresaRepository<Empresa> _empresaRepository;
        private readonly IMediatorHandler _bus;
        protected readonly IPublicarEmpresaNoSns _publicarEmpresaNoSns;

        public AtualizarEmpresaEventHandler(
            IEmpresaRepository<Empresa> empresaRepository,
            IMediatorHandler bus,
            IPublicarEmpresaNoSns publicarEmpresaNoSns) : base(bus)
        {
            _empresaRepository = empresaRepository;
            _bus = bus;
            _publicarEmpresaNoSns = publicarEmpresaNoSns;
        }

        public async Task Handle(AtualizarEmpresaEvent evt, CancellationToken cancellationToken)
        {

            evt.Alias = Empresa.GetAlias(evt.NomeFantasia, evt.Alias);
            if (!evt.IsValid())
            {
                NotifyValidationErrors(evt);
                return;
            }

            #region Outras Validações 
            var empresaExistente = await _empresaRepository.ObterPorIdAsync(evt.Id);

            if (empresaExistente == null)
            {
                await _bus.PublishEvent(new DomainNotification(evt.MessageType, $"Empresa {evt.Id} não encontrado."));
                return;
            }

            var empresasMesmoAliasExistente = await _empresaRepository.ObterEmpresaPorAliasAsync(evt.Alias);
            if (empresasMesmoAliasExistente != null && empresasMesmoAliasExistente.Count > 0)
            {
                var temOutraEmpresaMatrizComMesmoAlias = empresasMesmoAliasExistente.FirstOrDefault(a => a.EmpresaProprietariaId != evt.EmpresaProprietariaId);
                if (temOutraEmpresaMatrizComMesmoAlias != null)
                {
                    await _bus.PublishEvent(new DomainNotification("Alias",
                    $"Já existe uma empresa cadastrada com o Alias '{evt.Alias}'." + " No CNPJ Matriz :  " + temOutraEmpresaMatrizComMesmoAlias.EmpresaProprietariaId));

                    return;
                }
            }

            if (evt.Coparticipacao > evt.ValorMaximoPlano)
            {
                await _bus.PublishEvent(new DomainNotification(evt.MessageType, $"A Coparticipação não pode ser maior que o valor total do maior plano"));
                return;
            }

            Console.WriteLine("------------- 6- Executando AtualizarEmpresaEvent Handle  ");

            if (evt.Responsavel == null)
            {
                evt.Responsavel = empresaExistente.Responsavel;
            }

            var objUpdateResponsavel = new Responsavel(
                evt.Responsavel?.Nome,
                evt.Responsavel?.Email ?? empresaExistente.Responsavel.Email,
                evt.Responsavel?.Telefone,
                evt.Responsavel?.Celular
                );

            var vigencia = DateTime.UtcNow.AddYears(1);

            foreach (var item in evt.Planos)
            {
                item.Vigencia = vigencia;
            }

            if (evt.TipoOferta == Enums.TipoOfertaEnum.Premiacao && !evt.Planos.Any(p => p.TipoPlano == "ContaGratuita"))
            {
                await _bus.PublishEvent(new DomainNotification(evt.MessageType, $"Para habilitação do fluxo conta gratuita para empresa CNPJ: {evt.Documentos[0].Numero}, somente o plano tipo ContaGratuita deve estar associado a mesma."));
                return;
            }

            #endregion

            Console.WriteLine("------------- 7- Executando AtualizarEmpresaEvent Handle  ");

            var entidade = new Empresa
            (
                evt.Id,
                evt.NomeFantasia,
                evt.RazaoSocial,
                evt.Segmento,
                evt.Site,
                evt.Tipo,
                evt.EmpresaProprietariaId.RemoveSpecialCharacters(),
                evt.CentroCusto,
                evt.GrupoOrganizacionais,
                empresaExistente.Documentos,
                evt.Endereco,
                objUpdateResponsavel,
                evt.Planos,
                evt.Ativo,
                DateTime.UtcNow,
                evt.Financeiro,
                evt.Comercial,
                evt.Alias,
                evt.StatusFinanceiro,
                evt.TipoOferta
            );

            Console.WriteLine("------------- 8- Executando AtualizarEmpresaEvent Handle  ");
            var isOk = await _empresaRepository.AtualizarAsync(entidade);

            if (!isOk)
            {
                await _bus.PublishEvent(new DomainNotification(evt.MessageType, $"Não foi possível atualizar a Empresa {evt.Id}."));
            }
            else
            {
                await _publicarEmpresaNoSns.AtualizarEmpresaIdAsync(entidade.Id);
            }
        }
    }
}
