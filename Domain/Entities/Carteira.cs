using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    /// <summary>
    /// Carteira 
    /// </summary>
    public class Carteira
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }

        [BsonElement("saldo")]
        public decimal Saldo { get; set; }

        /// <summary>
        /// Data atualizacao
        /// </summary>
        [BsonElement("dataUltimaAtualizacao")]
        public DateTime DataUltimaAtualizacao { get; set; }

        [BsonElement("creditos")]
        public List<Credito> Creditos { get; set; }
        /// <summary>
        /// Histórico de transações
        /// </summary>
        [BsonElement("extrato")]
        public List<Transacao> Historico { get; set; }


        public virtual decimal SaldoConsolidado
        {
            get
            {
                var dataAtual = DateTime.UtcNow;
                return Creditos.Where(cred =>
                                      cred.ValidadeEfetiva.Date >= dataAtual.Date &&
                                      cred.QuantidadeRestante > 0)
                                      .OrderBy(valid => valid.ValidadeEfetiva).Select(qtd => qtd.QuantidadeRestante).Sum();
            }
        }


        public Carteira()
        {
            Creditos = new List<Credito>();
            Historico = new List<Transacao>();
        }
    }
}