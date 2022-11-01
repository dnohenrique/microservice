using Domain.ExternalEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IPlanoRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> ObterPorParametrosAsync(Dictionary<string, object> parameters);
        Task<long> ObterTotalPorParametrosAsync(PlanoExternal parameters = null);
    }
}
