using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    public class Billing
    {
        [BsonElement("formaPagamento")]
        public string FormaPagamento { get; private set; }

        [BsonElement("valorTotalAtual")]
        public decimal ValorTotalAtual { get; private set; }

        [BsonElement("totalAssinantes")]
        public int TotalAssinantes { get; private set; }

        [BsonElement("totalColaboradores")]
        public int TotalColaboradores { get; private set; }

        [BsonElement("coparticipacao")]
        public decimal Coparticipacao { get; set; }

        public Billing
        (
            string formaPagamento,
            decimal valorTotalAtual,
            int totalAssinantes,
            int totalColaboradores,
            decimal coparticipacao
        )
        {

            FormaPagamento = formaPagamento;
            ValorTotalAtual = valorTotalAtual;
            TotalAssinantes = totalAssinantes;
            TotalColaboradores = totalColaboradores;
            Coparticipacao = coparticipacao;
        }
    }
}
