using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Aws
{
    public interface IPublicarEmpresaNoSns
    {
         Task EnviarEmpresaIdAsync(string identificadorFiscal);
         Task AtualizarEmpresaIdAsync(string identificadorFiscal);
    }
}