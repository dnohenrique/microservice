using MongoDB.Driver;

namespace Domain.Interfaces.DataContext
{
    public interface IMongoContext : IContext
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
