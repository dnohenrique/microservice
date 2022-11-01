using MongoDB.Driver;

namespace Domain.Interfaces.DataContext
{
    public interface IMongoContextPlano : IContext
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
