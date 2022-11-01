using Domain.ExtensionMethod;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public class Cobranca
    {
        [BsonElement("emailAlternativo")]
        public string EmailAlternativo { get; set; }

        [BsonElement("cobrancaAutomatica")]
        public bool CobrancaAutomatica { get; set; }

        [BsonElement("emitirCobranca")]
        public bool EmitirCobranca { get; set; }

        [BsonElement("faturarMesFechado")]
        public bool FaturarMesFechado { get; set; }

        [BsonElement("diaInicial")]
        public int? DiaInicial { get; set; }

        [BsonElement("diaFinal")]
        public int? DiaFinal { get; set; }
    }
}
