using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Domain.Entities
{
    public class Equipe
    {
        [BsonElement("id")]
        public Guid Id { get; set; }

        [BsonElement("titulo")]
        public string Titulo { get; set; }

        [BsonElement("ativo")]
        public bool Ativo { get; set; }

        [BsonElement("dataRegistro")]
        public DateTime DataRegistro { get; set; }

        [BsonElement("dataAtualizacao")]
        public DateTime? DataAtualizacao { get; set; }

        public Equipe
        (
            Guid id,
            string titulo,
            DateTime dataRegistro
        )
        {
            Id = id;
            Titulo = titulo;
            Ativo = true;
            DataRegistro = dataRegistro;
        }
    }
}
