using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task IncluirAsync(TEntity obj);
        Task<List<TEntity>> ObterTodosAsync(int limit = 0, int offset = 0);
        Task<bool> AtualizarAsync(TEntity obj);
        Task<TEntity> ObterPorIdAsync(string id);
        Task<bool> DeletarAsync(string id);

        Task<TEntity> ObterPorCNPJAsync(string CNPJ);      


    }
}