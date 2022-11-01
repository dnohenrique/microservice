using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Domain.Entities
{
    [BsonIgnoreExtraElements]
    public abstract class EntityMongoDbBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string _Id { get; set; }

        [BsonElement("id")]
        public Guid Id { get; set; }
    }
}
