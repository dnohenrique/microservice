using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    public class EmpresaComercial
    {
        [BsonElement("email")]
        public string Email { get; set; }//EmailComercial__c
        [BsonElement("contato")]
        public string Contato { get; set; }//ContatoComercial__c
        [BsonElement("telefone")]
        public string Telefone { get; set; }//TelComercial__c
    }
}
