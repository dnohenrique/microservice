using Domain.ExtensionMethod;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;


namespace Domain.Entities
{
    public class Documento
    {
        [BsonElement("tipo")]
        public string Tipo { get; private set; }

        [BsonElement("numero")]
        public string Numero { get; private set; }

        public Documento
        (

            string tipo,
            string numero
        )
        {
            Tipo = tipo;
            Numero = numero.FormatRemoveMask();
        }
    }
}
