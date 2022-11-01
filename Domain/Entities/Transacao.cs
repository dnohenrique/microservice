using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Domain.Entities
{
    [BsonIgnoreExtraElements]
    public class Transacao
    {
        [BsonElement("id")]
        public Guid Id { get; private set; }

        [BsonElement("documento")]
        public string Documento { get; private set; }

        [BsonElement("valor")]
        public decimal Valor { get; private set; }

        [BsonElement("pontos")]
        public decimal Pontos { get; private set; }

        [BsonElement("descricao")]
        public string Descricao { get; private set; }

        [BsonElement("data")]
        public DateTime Data { get; private set; }

        [BsonElement("responsavel")]
        public string Responsavel { get; private set; }

        public Transacao(Guid? id, string documento, decimal valor, decimal pontos, string descricao, string responsavel)
        {
            Id = (id.HasValue && id.Value != Guid.Empty) ? id.Value : Guid.NewGuid();
            Data = DateTime.UtcNow;
            Documento = documento;
            Valor = valor;
            Pontos = pontos;
            Descricao = descricao;
            Responsavel = responsavel;
        }

    }
}
