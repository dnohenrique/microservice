using Domain.ExternalEntities;
using Domain.Interfaces.DataContext;
using Domain.Interfaces.Repository;
using Infrastructure.ExtensionMethod;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PlanoMongoDbRepository : IPlanoRepository<PlanoExternal>
    {
        protected readonly IMongoContextPlano _context;
        protected readonly IMongoCollection<PlanoExternal> _dbSet;

        public PlanoMongoDbRepository(IMongoContextPlano context)
        {
            _context = context;
            _dbSet = _context.GetCollection<PlanoExternal>("planos");
        }
        public async Task<PlanoExternal> ObterPorIdAsync(Guid id)
        {
            FilterDefinition<PlanoExternal> filterId = Builders<PlanoExternal>.Filter.Eq("id", id);
            FilterDefinition<PlanoExternal> filterDeletado = Builders<PlanoExternal>.Filter.Eq("dataDelecao", BsonNull.Value);

            var filters = Builders<PlanoExternal>.Filter.And(filterId, filterDeletado);

            var data = await _dbSet.FindAsync(filters);
            var resultado = await data.FirstOrDefaultAsync();
            return resultado;
        }

        public Task<List<PlanoExternal>> ObterTodosAsync(int limit = 0, int offset = 0)
        {
            var filterAll = Builders<PlanoExternal>.Filter.Empty;
            var filterAtivo = Builders<PlanoExternal>.Filter.Eq("ativo", true);

            var all = _dbSet.Find(Builders<PlanoExternal>.Filter
                             .And(filterAll, filterAtivo))
                             .Skip(offset).Limit(limit)
                             .Sort(new BsonDocument("titulo", 1))
                             .ToListAsync();

            return Task.FromResult(all.Result);
        }

        public async Task<List<PlanoExternal>> ObterPorParametrosAsync(Dictionary<string, object> parameters)
        {
            var filters = new List<FilterDefinition<PlanoExternal>>();

            for (int index = 0, totalParams = parameters.Count; index < totalParams; index++)
            {
                var filter = parameters.ElementAt(index);
                filters.Add(Builders<PlanoExternal>.Filter.Eq(filter.Key, filter.Value));
            }
            var all = await _dbSet.FindAsync(Builders<PlanoExternal>.Filter.And(filters));

            return await all.ToListAsync();
        }

        public Task<long> ObterTotalPorParametrosAsync(PlanoExternal parameters)
        {
            var filters = Filtros(parameters);

            var data = _dbSet.Find(filters).CountDocumentsAsync();
            var resultado = data;

            return resultado;

        }

        private FilterDefinition<PlanoExternal> Filtros(PlanoExternal parameters)
        {
            FilterDefinition<PlanoExternal> filterId = Builders<PlanoExternal>.Filter.Empty;
            FilterDefinition<PlanoExternal> filterTitulo = Builders<PlanoExternal>.Filter.Empty;
            FilterDefinition<PlanoExternal> filterTipoPlano = Builders<PlanoExternal>.Filter.Empty;
            FilterDefinition<PlanoExternal> filterValorPlano = Builders<PlanoExternal>.Filter.Empty;
            FilterDefinition<PlanoExternal> filterDiarias = Builders<PlanoExternal>.Filter.Empty;
            FilterDefinition<PlanoExternal> filterValorDiariaMinima = Builders<PlanoExternal>.Filter.Empty;
            FilterDefinition<PlanoExternal> filterValorDiariaMaxima = Builders<PlanoExternal>.Filter.Empty;
            FilterDefinition<PlanoExternal> filterVigencia = Builders<PlanoExternal>.Filter.Empty;
            FilterDefinition<PlanoExternal> filterAtivo = Builders<PlanoExternal>.Filter.Eq("ativo", true);

            if (parameters != null)
            {
                if (!string.IsNullOrEmpty(parameters.Titulo))
                {
                    filterTitulo = Builders<PlanoExternal>.Filter.Eq("titulo", parameters.Titulo.ConvertToCaseInsensitive());
                }

                if (!string.IsNullOrEmpty(parameters.TipoPlano))
                {
                    filterTipoPlano = Builders<PlanoExternal>.Filter.Eq("tipoPlano", parameters.TipoPlano.ConvertToCaseInsensitive());
                }

                if (!string.IsNullOrEmpty(parameters.ValorPlano.ToString()))
                {
                    filterValorPlano = Builders<PlanoExternal>.Filter.Eq("valorPlano", parameters.ValorPlano.ToString().ConvertToCaseInsensitive());
                }

                if (!string.IsNullOrEmpty(parameters.Diarias.ToString()))
                {
                    filterDiarias = Builders<PlanoExternal>.Filter.Eq("diarias", parameters.Diarias.ToString().ConvertToCaseInsensitive());
                }

                if (!string.IsNullOrEmpty(parameters.ValorDiariaMinima.ToString()))
                {
                    filterValorDiariaMinima = Builders<PlanoExternal>.Filter.Eq("valorDiariaMinima", parameters.ValorDiariaMinima.ToString().ConvertToCaseInsensitive());
                }

                if (!string.IsNullOrEmpty(parameters.ValorDiariaMaxima.ToString()))
                {
                    filterValorDiariaMaxima = Builders<PlanoExternal>.Filter.Eq("valorDiariaMaxima", parameters.ValorDiariaMaxima.ToString().ConvertToCaseInsensitive());
                }

                if (!string.IsNullOrEmpty(parameters.Vigencia.ToString()))
                {
                    filterVigencia = Builders<PlanoExternal>.Filter.Eq("vigencia", parameters.Vigencia.ToString().ConvertToCaseInsensitive());
                }
            }

            var filters = Builders<PlanoExternal>.Filter.And(filterId, filterTitulo, filterTipoPlano, filterValorPlano, filterDiarias, filterValorDiariaMinima, filterValorDiariaMaxima, filterVigencia, filterAtivo);
            return filters;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task IncluirAsync(PlanoExternal obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AtualizarAsync(PlanoExternal obj)
        {
            throw new NotImplementedException();
        }

        public Task<PlanoExternal> ObterPorIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PlanoExternal> ObterPorCNPJAsync(string CNPJ)
        {
            throw new NotImplementedException();
        }
    }
}
