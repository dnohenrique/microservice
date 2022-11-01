using Domain.Validations;

namespace Domain.Event
{
    public class AtualizarEmpresaStatusFinanceiroEvent : EmpresaStatusFinanceiroEvent
    {
        public AtualizarEmpresaStatusFinanceiroEvent(
            string cnpj,
            string statusFinanceiro
        )
        {
            CNPJ = cnpj;
            StatusFinanceiro = statusFinanceiro;
        }

        public override bool IsValid()
        {
            ValidationResult = new AtualizarEmpresaStatusFinanceiroValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
