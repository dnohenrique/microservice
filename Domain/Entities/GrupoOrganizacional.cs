using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class GrupoOrganizacional
    {

        [BsonElement("unidade")]
        public string Unidade { get; private set; }

        public GrupoOrganizacional(string unidade)
        {
            this.Unidade = unidade;
        }
    }
}
