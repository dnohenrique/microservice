using Domain.Interfaces.DataContext;
using Infrastructure.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace Infrastructure.DataContext
{
    public class MongoContext : IMongoContext
    {
        private IMongoDatabase _database { get; }
        private IOptions<MongoDbConfiguration> _mongoConfig { get; set; }

        public MongoContext(IOptions<MongoDbConfiguration> mongoConfig)
        {
            _mongoConfig = mongoConfig;

            try
            {
                BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;

                var mongoClient = new MongoClient(_mongoConfig.Value.ConnectionString);

                _database = mongoClient.GetDatabase(_mongoConfig.Value.DatabaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar com o servidor.", ex);
            }
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

