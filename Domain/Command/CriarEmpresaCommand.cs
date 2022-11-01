using Domain.Validations;

namespace Domain.Command
{
    public class CriarEmpresaCommand : EmpresaCommand<string>
    {
        public CriarEmpresaCommand( string nomeFantasia,
                                    string razaoSocial,
                                    string segmento,
                                    string site,
                                    string tipo,
                                    string empresaProprietariaId,
                                    string centroCusto, 
                                    string[] grupoOrganizacionais,
                                    bool ativo,
                                    string alias,
                                    string statusFinanceiro)
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Segmento = segmento;
            Site = site;
            Tipo = tipo;
            EmpresaProprietariaId = empresaProprietariaId;
            CentroCusto = centroCusto;
            GrupoOrganizacionais = grupoOrganizacionais;
            Ativo = ativo;
            Alias = alias;
            StatusFinanceiro = statusFinanceiro;
        }

        public override bool IsValid()
        {
            ValidationResult = new CriarEmpresaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
