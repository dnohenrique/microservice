using Domain.Command;
using System;

namespace Domain.Validations
{
    public class CriarEmpresaCommandValidation : EmpresaCommandValidation<EmpresaCommand<string>>
    {
        public CriarEmpresaCommandValidation()
        {
            ValidarEmpresa();

            ValidarDocumentos();

            //ValidarResponsavel();

            ValidarEndereco();

            ValidarPlanos();

            //ValidarComercial();

            //ValidarFinanceiro();

            //ValidarFinanceiro();
        }
    }
}
