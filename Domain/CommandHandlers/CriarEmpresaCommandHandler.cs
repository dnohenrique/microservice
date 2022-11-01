using Domain.Command;
using Domain.Entities;
using Domain.ExtensionMethod;
using Domain.Interfaces.Aws;
using Domain.Interfaces.Bus;
using Domain.Interfaces.Repository;
using Domain.Notifications;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.CommandHandlers
{
    public class CriarEmpresaCommandHandler : CommandHandlerBase,
        IRequestHandler<CriarEmpresaCommand, string>
    {
        private readonly IEmpresaRepository<Empresa> _empresaRepository;
        private readonly IMediatorHandler _bus;
        protected readonly IPublicarEmpresaNoSns _publicarEmpresaNoSns;

        public CriarEmpresaCommandHandler
            (
                IEmpresaRepository<Empresa> empresaRepository,
                IMediatorHandler bus,
                IPublicarEmpresaNoSns publicarEmpresaNoSns
            ) : base(bus)
        {
            _bus = bus;

            _empresaRepository = empresaRepository;
            _publicarEmpresaNoSns = publicarEmpresaNoSns;
        }

        public async Task<string> Handle(CriarEmpresaCommand cmd, CancellationToken cancellationToken)
        {
            cmd.Alias = Empresa.GetAlias(cmd.NomeFantasia, cmd.Alias);
            if (!cmd.IsValid())
            {
                NotifyValidationErrors(cmd);
                return string.Empty;
            }

            #region Outras validacoes
            var cnpj = cmd.Documentos.Find(x => x.Tipo == "CNPJ").Numero;
            var empresaExistente = await _empresaRepository.ObterPorIdAsync(cnpj);
            if (null != empresaExistente)
            {
                await _bus.PublishEvent(new DomainNotification("Documento.CNPJ",
                    $"Já existe uma empresa cadastrada com o CNPJ '{cnpj}'."));

                return "";
            }

            var empresasMesmoAliasExistente = await _empresaRepository.ObterEmpresaPorAliasAsync(cmd.Alias);
            if (empresasMesmoAliasExistente != null && empresasMesmoAliasExistente.Count > 0)
            {
                var temOutraEmpresaMatrizComMesmoAlias = empresasMesmoAliasExistente.FirstOrDefault(a => a.EmpresaProprietariaId != cmd.EmpresaProprietariaId);
                if (temOutraEmpresaMatrizComMesmoAlias != null)
                {
                    await _bus.PublishEvent(new DomainNotification("Alias",
                    $"Já existe uma empresa cadastrada com o Alias '{cmd.Alias}'." + " No CNPJ Matriz :  " + temOutraEmpresaMatrizComMesmoAlias.EmpresaProprietariaId));

                    return string.Empty;
                }
            }

            var vigencia = DateTime.UtcNow.AddYears(1);

            foreach (var item in cmd.Planos)
            {
                item.Vigencia = vigencia;
            }

            #endregion

            var objCobranca = new Cobranca
            {
                CobrancaAutomatica = false,
                EmailAlternativo = string.Empty,
                EmitirCobranca = true,
                FaturarMesFechado = true,
                DiaFinal = null,
                DiaInicial = null
            };

            var entidade = new Empresa
                (
                   nomeFantasia: cmd.NomeFantasia,
                   razaoSocial: cmd.RazaoSocial,
                   segmento: cmd.Segmento,
                   site: cmd.Site,
                   tipo: cmd.Tipo,
                   empresaProprietariaId: cmd.EmpresaProprietariaId.RemoveSpecialCharacters(),
                   centroCusto: cmd.CentroCusto,
                   gruposOrganizacionais: cmd.GrupoOrganizacionais,
                   documentos: cmd.Documentos,
                   endereco: cmd.Endereco,
                   responsavel: cmd.Responsavel,
                   planos: cmd.Planos,
                   ativo: true,
                   dataCriacao: DateTime.UtcNow,
                   financeiro: cmd.Financeiro,
                   comercial: cmd.Comercial,
                   alias: cmd.Alias,
                   cobranca: objCobranca,
                   statusFinanceiro: cmd.StatusFinanceiro
                );

            await _empresaRepository.IncluirAsync(entidade);

            await _publicarEmpresaNoSns.EnviarEmpresaIdAsync(entidade.Id);

            return await Task.FromResult(entidade.Id);
         
        }
    }
}
