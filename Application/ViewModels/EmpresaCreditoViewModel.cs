using System;

namespace Application.ViewModels
{
    public class EmpresaCreditoViewModel
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal QuantidadeRestante { get; set; }
        public DateTime ValidadeEfetiva { get; set; }
    }
}