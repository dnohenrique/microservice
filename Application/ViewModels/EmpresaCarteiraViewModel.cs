using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels
{
    public class EmpresaCarteiraViewModel
    {
        public decimal Saldo { get; set; }
        public decimal SaldoConsolidado { get; set; }       
        public DateTime DataUltimaAtualizacao { get; set; }     
        public List<EmpresaCreditoViewModel> Creditos { get; set; }

        public EmpresaCarteiraViewModel() {
            Creditos = new List<EmpresaCreditoViewModel>();
        }
    }
}
