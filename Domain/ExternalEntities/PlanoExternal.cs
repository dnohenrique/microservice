using Domain.Entities;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Domain.ExternalEntities
{
    [BsonIgnoreExtraElements]
    public class PlanoExternal : EntityMongoDbBase
    {
        [BsonElement("titulo")]
        public string Titulo { get; set; }

        [BsonElement("tipoPlano")]
        public string TipoPlano { get; set; }

        [BsonElement("valorPlano")]
        public decimal ValorPlano { get; set; }

        [BsonElement("diarias")]
        public int Diarias { get; set; }

        [BsonElement("valorDiariaMinima")]
        public decimal ValorDiariaMinima { get; set; }

        [BsonElement("valorDiariaMaxima")]
        public decimal ValorDiariaMaxima { get; set; }

        [BsonElement("vigencia")]
        public DateTime? Vigencia { get; set; }

        [BsonElement("ativo")]
        public bool Ativo { get; set; }

        [BsonElement("dataCriacao")]
        public DateTime DataCriacao { get; private set; }

        [BsonElement("dataAtualizacao")]
        public DateTime? DataAtualizacao { get; set; }

        [BsonElement("dataDelecao")]
        public DateTime? DataDelecao { get; set; }

        [BsonElement("billing")]
        public BillingExternal Billing { get; set; }

        public PlanoExternal
        (
            Guid id,
            string titulo,
            string tipoPlano,
            decimal valorPlano,
            int diarias,
            decimal valorDiariaMinima,
            decimal valorDiariaMaxima,
            DateTime? vigencia,
            bool ativo,
            DateTime dataCriacao,
            DateTime? dataAtualizacao,
            DateTime? dataDelecao,
            BillingExternal billing
        )
        {
            Id = id;
            Titulo = titulo;
            TipoPlano = tipoPlano;
            ValorPlano = valorPlano;
            Diarias = diarias;
            ValorDiariaMinima = valorDiariaMinima;
            ValorDiariaMaxima = valorDiariaMaxima;
            Vigencia = vigencia;
            Ativo = ativo;
            DataCriacao = dataCriacao;
            DataAtualizacao = dataAtualizacao;
            DataDelecao = dataDelecao;
            Billing = billing;
        }
    }
}