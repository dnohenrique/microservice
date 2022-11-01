using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    public class EmpresaFinanceiro
    {
        [BsonElement("email")]
        public string Email { get; set; }//EmailFinanceiro__c
        [BsonElement("prazoPagamento")]
        public int PrazoPagamento { get; set; }//PrazoPagamento__c
        [BsonElement("formaPagamento")]
        public string FormaPagamento { get; set; }//FormadePagamento__c
        [BsonElement("diaPagamento")]
        public int DiaPagamento { get; set; }//Billingday__c
        [BsonElement("contato")]
        public string Contato { get; set; }//Billingnamecontact__c
        [BsonElement("telefone")]
        public string Telefone { get; set; }//TelFinanceiro__c
    }
}
