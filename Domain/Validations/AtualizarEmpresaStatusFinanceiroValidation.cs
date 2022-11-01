using Domain.Event;

namespace Domain.Validations
{
    public class AtualizarEmpresaStatusFinanceiroValidation : EmpresaStatusFinanceiroEventValidation<AtualizarEmpresaStatusFinanceiroEvent>
    {
        public AtualizarEmpresaStatusFinanceiroValidation()
        {
            ValidarStatusFinanceiro();
        }
    }
}
