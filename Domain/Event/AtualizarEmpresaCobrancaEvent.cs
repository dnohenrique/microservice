using Domain.Validations;

namespace Domain.Event
{
    public class AtualizarEmpresaCobrancaEvent : EmpresaCobrancaEvent
    {
        public AtualizarEmpresaCobrancaEvent
        (
            string cnpj,
            string emailAlternativo,
            bool cobrancaAutomatica,
            bool emitirCobranca,
            bool faturarMesFechado,
            int? diaInicial,
            int? diaFinal
        )
        {
            CNPJ = cnpj;
            EmailAlternativo = emailAlternativo;
            CobrancaAutomatica = cobrancaAutomatica;
            EmitirCobranca = emitirCobranca;
            FaturarMesFechado = faturarMesFechado;
            DiaInicial = diaInicial;
            DiaFinal = diaFinal;
        }

        public override bool IsValid()
        {
            ValidationResult = new AtualizarEmpresaCobrancaValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
