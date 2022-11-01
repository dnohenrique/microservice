using Domain.Enums;
using Domain.Validations;

namespace Domain.Event
{
    public class AtualizarEmpresaEvent : EmpresaEvent
    {
        public AtualizarEmpresaEvent
        (
            string id,
            string nomeFantasia,
            string razaoSocial,
            string segmento,
            string site,
            string tipo,
            string empresaProprietariaId,
            string centroCusto,
            decimal coparticipacao,
            string[] grupoOrganizacionais,
            bool ativo,
            decimal valorMaximoPlano,
            string alias = null,
            string statusFinanceiro = null,
            TipoOfertaEnum tipoOferta = TipoOfertaEnum.ContasEPlanos
        )
        {
            Id = id;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Segmento = segmento;
            Site = site;
            Tipo = tipo;
            EmpresaProprietariaId = empresaProprietariaId;
            CentroCusto = centroCusto;
            Coparticipacao = coparticipacao;
            GrupoOrganizacionais = grupoOrganizacionais;
            Ativo = ativo;
            Alias = alias;
            ValorMaximoPlano = valorMaximoPlano;
            StatusFinanceiro = statusFinanceiro;
            TipoOferta = tipoOferta;
        }

        public override bool IsValid()
        {
            ValidationResult = new AtualizarEmpresaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
