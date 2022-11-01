using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Domain.Entities
{
    /// <summary>
    /// Credito POCO
    /// </summary>
    [BsonIgnoreExtraElements]
    public class Credito
    {
        [BsonElement("id")]
        public Guid Id { get; private set; }

        [BsonElement("origem")]
        public string Origem { get; set; }

        [BsonElement("descricao")]
        public string Descricao { get; set; }

        [BsonElement("valor")]
        public decimal Valor { get; set; }

        [BsonElement("quantidadeRestante")]
        public decimal QuantidadeRestante { get; set; }

        [BsonElement("validadeEfetiva")]
        public DateTime ValidadeEfetiva { get; set; }

        [BsonElement("dataRecebimento")]
        public DateTime DataRecebimento { get; set; }

    }
}
