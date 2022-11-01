using System;

namespace Application.ViewModels
{
    public class EmpresaPlanoViewModel
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string TipoPlano { get; set; }
        public decimal ValorPlano { get; set; }
        public int Diarias { get; set; }
        public decimal ValorDiariaMinima { get; set; }
        public decimal ValorDiariaMaxima { get; set; }
        public EmpresaPlanoBillingViewModel Billing { get; set; }
        public DateTime? Vigencia { get; set; }
        public bool Ativo { get; set; }
    }
}
