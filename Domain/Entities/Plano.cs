using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Domain.Entities
{
    [BsonIgnoreExtraElements]
    public class Plano
    {
        [BsonElement("id")]
        public Guid Id { get; private set; }

        [BsonElement("titulo")]
        public string Titulo { get; private set; }

        [BsonElement("tipoPlano")]
        public string TipoPlano { get; private set; }

        [BsonElement("valorPlano")]
        public decimal ValorPlano { get; private set; }

        [BsonElement("diarias")]
        public int Diarias { get; private set; }

        [BsonElement("valorDiariaMinima")]
        public decimal ValorDiariaMinima { get; private set; }

        [BsonElement("valorDiariaMaxima")]
        public decimal ValorDiariaMaxima { get; private set; }

        [BsonElement("billing")]
        public Billing Billing { get; set; }

        [BsonElement("vigencia")]
        public DateTime? Vigencia { get; set; }

        [BsonElement("ativo")]
        public bool Ativo { get; private set; }

        public Plano
        (
            Guid id,
            string titulo,
            string tipoPlano,
            decimal valorPlano,
            int diarias,
            decimal valorDiariaMinima,
            decimal valorDiariaMaxima,
            Billing billing,
            DateTime? vigencia,
            bool ativo
        )
        {
            Id = id;
            Titulo = titulo;
            TipoPlano = tipoPlano;
            ValorPlano = valorPlano;
            Diarias = diarias;
            ValorDiariaMinima = valorDiariaMinima;
            ValorDiariaMaxima = valorDiariaMaxima;
            Billing = billing;
            Vigencia = vigencia;
            Ativo = ativo;
        }
    }
}
