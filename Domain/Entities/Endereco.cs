using Domain.ExtensionMethod;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    public class Endereco
    {
        [BsonElement("logradouro")]
        public string Logradouro { get; private set; }

        [BsonElement("numero")]
        public string Numero { get; private set; }

        [BsonElement("complemento")]
        public string Complemento { get; private set; }

        [BsonElement("bairro")]
        public string Bairro { get; private set; }

        [BsonElement("cidade")]
        public string Cidade { get; private set; }

        [BsonElement("estado")]
        public string Estado { get; private set; }

        [BsonElement("cep")]
        public string Cep { get; private set; }

        [BsonElement("pais")]
        public string Pais { get; private set; }


        public Endereco
        (
            string logradouro,
            string numero,
            string complemento,
            string bairro,
            string cidade,
            string estado,
            string cep,
            string pais

        )
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep.FormatRemoveMask();
            Pais = pais;
        }
    }
}
