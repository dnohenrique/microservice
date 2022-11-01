namespace Domain.Event
{
    public abstract class EmpresaStatusFinanceiroEvent : EventBase
    {
        public string CNPJ { get; set; }
        public string StatusFinanceiro { get; set; }
    }
}
