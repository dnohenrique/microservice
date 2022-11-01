using Domain.Event;

namespace Domain.Validations
{
    public class AtualizarEmpresaCobrancaValidation : EmpresaCobrancaEventValidation<AtualizarEmpresaCobrancaEvent>
    {
        public AtualizarEmpresaCobrancaValidation()
        {
            ValidarEmail();

            ValidarPeriodoPagamento();
        }
    }
}
