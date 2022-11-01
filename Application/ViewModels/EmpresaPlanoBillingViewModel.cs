namespace Application.ViewModels
{
    public class EmpresaPlanoBillingViewModel
    {
        public string FormaPagamento { get; set; }
        public decimal ValorTotalAtual { get; set; }
        public int TotalAssinantes { get; set; }
        public int TotalColaboradores { get; set; }
        public decimal Coparticipacao { get; set; }
    }
}
