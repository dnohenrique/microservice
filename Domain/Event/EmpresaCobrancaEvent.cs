namespace Domain.Event
{
    public abstract class EmpresaCobrancaEvent : EventBase
    {
        public string CNPJ { get; set; }
        public string EmailAlternativo { get; set; }
        public bool CobrancaAutomatica { get; set; }
        public bool EmitirCobranca { get; set; }
        public bool FaturarMesFechado { get; set; }
        public int? DiaInicial { get; set; }
        public int? DiaFinal { get; set; }
    }
}
