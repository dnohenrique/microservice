using Domain.ExtensionMethod;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    public class Responsavel
    {
        [BsonElement("nome")]
        public string Nome { get; private set; }

        [BsonElement("email")]
        public string Email { get; private set; }

        [BsonElement("telefone")]
        public string Telefone { get; private set; }

        [BsonElement("celular")]
        public string Celular { get; private set; }


        public Responsavel
        (
            string nome,
            string email,
            string telefone,
            string celular
        )
        {
            Nome = nome;
            Email = email;
            Telefone = telefone.FormatRemoveMaskAndDdi();
            Celular = celular.FormatRemoveMaskAndDdi();
        }
    }
}
