namespace Application.ViewModels
{
    public class EmpresaFinanceiroViewModel
    {
        public string Email { get; set; }//EmailFinanceiro__c
        public int  PrazoPagamento { get; set; }//PrazoPagamento__c
        public string FormaPagamento { get; set; }//FormadePagamento__c
        public int DiaPagamento { get; set; }//Billingday__c
        public string Contato { get; set; }//Billingnamecontact__c
        public string Telefone { get; set; }//TelFinanceiro__c
    }
}
