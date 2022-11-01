using Domain.Event;

namespace Domain.Validations
{
    public class AtualizarEmpresaValidation : EmpresaEventValidation<AtualizarEmpresaEvent>
    {
        public AtualizarEmpresaValidation()
        {
            ValidarEmpresa();

            //ValidarDocumentos();

            //ValidarResponsavel();

            ValidarEndereco();

            //ValidarComercial();

            //ValidarFinanceiro();

            //ValidarPlanos();
        }
    }
}
