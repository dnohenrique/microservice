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
    public class AtualizarEmpresaCobrancaEventHandler : EventHandlerBase, INotificationHandler<AtualizarEmpresaCobrancaEvent>
    {
        private readonly IEmpresaRepository<Empresa> _empresaRepository;
        private readonly IPlanoRepository<PlanoExternal> _planoRepository;
        private readonly IMediatorHandler _bus;
        protected readonly IPublicarEmpresaNoSns _publicarEmpresaNoSns;

        public AtualizarEmpresaCobrancaEventHandler
            (
                IEmpresaRepository<Empresa> empresaRepository,
                IPlanoRepository<PlanoExternal> planoRepository,
                IMediatorHandler bus,
                IPublicarEmpresaNoSns publicarEmpresaNoSns
            ) : base(bus)

        {
            _empresaRepository = empresaRepository;
            _planoRepository = planoRepository;
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
           
            //var aliasExistente = await _empresaRepository.ObterEmpresaPorAliasAsync(evt.Alias);
            //if (null != aliasExistente && aliasExistente.Id != evt.Id)
            //{
            //    await _bus.PublishEvent(new DomainNotification("Alias",
            //        $"Já existe outra empresa cadastrada com o Alias '{evt.Alias}'."));
            //    return;
            //}

            var plano = await _planoRepository.ObterTodosAsync();
            var valorMaximo = plano.Max(c => c.ValorPlano);

            if (evt.Coparticipacao > valorMaximo)
            {
                await _bus.PublishEvent(new DomainNotification(evt.MessageType, $"A Coparticipação não pode ser maior que o valor total do maior plano"));
                return;
            }

            foreach (var item in empresaExistente.Planos)
            {
                item.Billing.Coparticipacao = evt.Coparticipacao;
            }

            #endregion


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
                evt.Responsavel,
                empresaExistente.Planos,
                evt.Ativo,
                DateTime.UtcNow,
                financeiro: evt.Financeiro,
                comercial: evt.Comercial,
                evt.Alias,
                evt.StatusFinanceiro
            );

            var isOk = await _empresaRepository.AtualizarAsync(entidade);

            if (!isOk)
            {
                await _bus.PublishEvent(new DomainNotification(evt.MessageType, $"Não foi possível atualizar a Empresa {evt.Id}."));
            }
        }

        public async Task Handle(AtualizarEmpresaCobrancaEvent evt, CancellationToken cancellationToken)
        {
            if (!evt.IsValid())
            {
                NotifyValidationErrors(evt);
                return;
            }

            var cobranca = new Cobranca
            {
                CobrancaAutomatica = evt.CobrancaAutomatica,
                EmitirCobranca = evt.EmitirCobranca,
                DiaFinal = evt.DiaFinal,
                DiaInicial = evt.DiaInicial,
                EmailAlternativo = evt.EmailAlternativo,
                FaturarMesFechado = evt.FaturarMesFechado
            };

            var atualizado = await _empresaRepository.AtualizarCobranca(cobranca, evt.CNPJ);

            if (atualizado)
                await _publicarEmpresaNoSns.EnviarEmpresaIdAsync(evt.CNPJ);
            else
                await _bus.PublishEvent(new DomainNotification("validation-error", $"Não foi possível atualizar os dados de cobrança da Empresa {evt.CNPJ}."));

        }
    }
}
