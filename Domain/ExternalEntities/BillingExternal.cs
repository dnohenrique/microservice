using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Domain.ExternalEntities
{
    public class BillingExternal
    {
        [BsonElement("parcelas")]
        public int Parcelas { get; set; }

        [BsonElement("valorTotalAnual")]
        public decimal ValorTotalAnual { get; set; }

        [BsonElement("receitaPorDiaria")]
        public decimal ReceitaPorDiaria { get; set; }

        [BsonElement("custoPorcentual")]
        public decimal CustoPorcentual { get; set; }

        [BsonElement("reajustePorcentual")]
        public decimal ReajustePorcentual { get; set; }

        public BillingExternal
            (
                int parcelas,
                decimal valorTotalAnual,
                decimal receitaPorDiaria,
                decimal custoPorcentual,
                decimal reajustePorcentual
            )
        {
            Parcelas = parcelas;
            ValorTotalAnual = valorTotalAnual;
            ReceitaPorDiaria = receitaPorDiaria;
            CustoPorcentual = custoPorcentual;
            ReajustePorcentual = reajustePorcentual;
        }
    }
}