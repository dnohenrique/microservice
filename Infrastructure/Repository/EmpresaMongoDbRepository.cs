using Domain.Entities;
using Domain.Interfaces.DataContext;
using Domain.Interfaces.Repository;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class EmpresaMongoDbRepository : IEmpresaRepository<Empresa>
    {
        protected readonly IMongoContext _context;
        protected readonly IMongoCollection<Empresa> _dbSet;

        public EmpresaMongoDbRepository(IMongoContext context)
        {
            _context = context;
            _dbSet = _context.GetCollection<Empresa>("empresas");
        }

        public async Task<bool> AtualizarAsync(Empresa obj)
        {
            var filter = Builders<Empresa>.Filter.Eq("id", obj.Id);

            var update = Builders<Empresa>.Update
                .Set(u => u.NomeFantasia, obj.NomeFantasia)
                .Set(u => u.RazaoSocial, obj.RazaoSocial)
                .Set(u => u.Alias, obj.Alias)
                .Set(u => u.Segmento, obj.Segmento)
                .Set(u => u.Site, obj.Site)
                .Set(u => u.Tipo, obj.Tipo)
                .Set(u => u.EmpresaProprietariaId, obj.EmpresaProprietariaId)
                .Set(u => u.CentroCusto, obj.CentroCusto)
                .Set(u => u.GruposOrganizacionais, obj.GruposOrganizacionais)
                .Set(u => u.Documentos, obj.Documentos)
                .Set(u => u.Endereco, obj.Endereco)
                .Set(u => u.Responsavel, obj.Responsavel)
                .Set(u => u.Planos, obj.Planos)
                .Set(u => u.Comercial, obj.Comercial)
                .Set(u => u.Financeiro, obj.Financeiro)
                .Set(u => u.Ativo, obj.Ativo)
                .Set(u => u.DataAtualizacao, obj.DataAtualizacao);

            var result = await _dbSet.UpdateOneAsync(filter, update);

            return result.ModifiedCount == 1;
        }

        public async Task<bool> AtualizarCobranca(Cobranca cobranca, string cnpj)
        {
            FilterDefinition<Empresa> filterAlias = Builders<Empresa>.Filter.Eq(e => e.Id, cnpj);

            var filter = Builders<Empresa>.Filter.And(filterAlias);

            var update = Builders<Empresa>.Update
                .Set(u => u.Cobranca, cobranca);

            var result = await _dbSet.UpdateOneAsync(filter, update);

            return result.ModifiedCount == 1;
        }

        public async Task<bool> AtualizarStatusFinanceiro(string statusFinanceiro, string cnpj)
        {
            FilterDefinition<Empresa> filterAlias = Builders<Empresa>.Filter.Eq(e => e.Id, cnpj);

            var filter = Builders<Empresa>.Filter.And(filterAlias);

            var update = Builders<Empresa>.Update
                .Set(u => u.StatusFinanceiro, statusFinanceiro);

            var result = await _dbSet.UpdateOneAsync(filter, update);

            return result.ModifiedCount == 1;
        }

        public async Task<bool> DeletarAsync(string id)
        {
            var filter = Builders<Empresa>.Filter.Eq("id", id);

            var update = Builders<Empresa>.Update
                .Set(o => o.Ativo, false)
                .Set(o => o.DataDelecao, DateTime.UtcNow);

            var result = await _dbSet.UpdateOneAsync(filter, update);

            return result.ModifiedCount == 1;
        }

        public Task IncluirAsync(Empresa obj)
        {
            var criado = _dbSet.InsertOneAsync(obj);

            return criado;
        }

        public async Task<Empresa> ObterPorIdAsync(string id)
        {
            FilterDefinition<Empresa> filterId = Builders<Empresa>.Filter.Eq("id", id);

            var filters = Builders<Empresa>.Filter.And(filterId);

            var data = await _dbSet.FindAsync(filters);
            var resultado = await data.FirstOrDefaultAsync();
            return resultado;
        }

        public async Task<Empresa> ObterPorCNPJAsync(string numeroCNPJ)
        {
            FilterDefinition<Empresa> filterAtivo = Builders<Empresa>.Filter.Eq("ativo", true);

            FilterDefinition<Empresa> filterNumero = Builders<Empresa>.Filter.Eq("documentos.numero", numeroCNPJ)
                | Builders<Empresa>.Filter.Eq("empresaProprietariaId", numeroCNPJ);

            var filters = Builders<Empresa>.Filter.And(filterNumero, filterAtivo);

            var data = await _dbSet.FindAsync(filters);
            var resultado = await data.FirstOrDefaultAsync();

            if (resultado != null)
            {
                var resultadoAux = resultado.Documentos.Where(c => c.Tipo.Equals("CNPJ") && c.Numero.Equals(numeroCNPJ)).ToList();
                if (resultadoAux.Count == 0)
                {

                    return null;
                }

            }
            return resultado;
        }

        public async Task<List<Empresa>> ObterTodosAsync(int limit = 0, int offset = 0)
        {
            var result = await ObterPorParametrosAsync(limit: 0, offset: 0);
            return result.Item1;
        }

        public async Task<Tuple<List<Empresa>, long>> ObterPorParametrosAsync(int limit, int offset, string nomeFantasia = null, string razaoSocial = null, string segmento = null, string site = null,
                                                string tipo = null, string empresaProprietariaId = null, string centroCusto = null, string cnpj = null, IEnumerable<string> cnpjsIn = null, IEnumerable<string> cnpjsOut = null, int? diaCobrancaInicial = null,
                                                int? diaCobrancaFinal = null, bool? cobrancaAutomatica = null)
        {
            var builder = Builders<Empresa>.Filter;
            FilterDefinition<Empresa> filter = builder.Where(_ => _.Ativo && !_.DataDelecao.HasValue);
            var pathValue = ".*{0}.*";

            if (!string.IsNullOrWhiteSpace(nomeFantasia))
                filter = builder.And(filter, builder.Regex(_ => _.NomeFantasia, new BsonRegularExpression($"{string.Format(pathValue, nomeFantasia)}", "i")));

            if (!string.IsNullOrWhiteSpace(razaoSocial))
                filter = builder.And(filter, builder.Regex(_ => _.RazaoSocial, new BsonRegularExpression($"{string.Format(pathValue, razaoSocial)}", "i")));

            if (!string.IsNullOrWhiteSpace(segmento))
                filter = builder.And(filter, builder.Where(_ => _.Segmento.Equals(segmento)));

            if (!string.IsNullOrWhiteSpace(site))
                filter = builder.And(filter, builder.Where(_ => _.Site.Equals(site)));

            if (!string.IsNullOrWhiteSpace(tipo))
                filter = builder.And(filter, builder.Where(_ => _.Tipo.Equals(tipo)));

            if (!string.IsNullOrWhiteSpace(empresaProprietariaId))
                filter = builder.And(filter, builder.Where(_ => _.EmpresaProprietariaId.Equals(empresaProprietariaId)));

            if (!string.IsNullOrWhiteSpace(centroCusto))
                filter = builder.And(filter, builder.Where(_ => _.CentroCusto.Equals(centroCusto)));

            if (!string.IsNullOrWhiteSpace(cnpj))
                filter = builder.And(filter, builder.Where(_ => _.Id.Equals(cnpj)));

            if (cnpjsIn != null && cnpjsIn.Count() > 0)
                filter = builder.And(filter, builder.AnyIn("id", cnpjsIn));

            if (cnpjsOut != null && cnpjsOut.Count() > 0)
                filter = builder.And(filter, builder.AnyNin("id", cnpjsOut));

            if (diaCobrancaInicial.HasValue && diaCobrancaFinal.HasValue)
                filter = builder.And(filter, builder.Where(_ => _.Financeiro.DiaPagamento >= diaCobrancaInicial.Value && _.Financeiro.DiaPagamento <= diaCobrancaFinal.Value));

            if (cobrancaAutomatica.HasValue)
                filter = builder.And(filter, builder.Where(_ => _.Cobranca.CobrancaAutomatica == cobrancaAutomatica));

            var all = _dbSet.Find(filter)
                            .SortBy(_ => _.RazaoSocial)
                            .Skip(offset)
                            .Limit(limit)
                            .ToListAsync();

            var total = _dbSet.CountDocumentsAsync(filter);

            Task.WaitAll(all, total);

            return new Tuple<List<Empresa>, long>(all.Result, total.Result);
        }

        public async Task<List<Empresa>> ObterEmpresaPorAliasAsync(string alias)
        {
            FilterDefinition<Empresa> filter = Builders<Empresa>.Filter.Where(_ => _.Alias.Equals(alias) && !_.DataDelecao.HasValue);

            var data = await _dbSet.FindAsync(filter);

            //var resultado = await data.FirstOrDefaultAsync();
            var resultado = await data.ToListAsync();
            return resultado;

        }

        public async Task<bool> AtualizarCarteira(Empresa empresa)
        {
            FilterDefinition<Empresa> filterAlias = Builders<Empresa>.Filter.Eq(e => e.Id, empresa.Id);

            var filter = Builders<Empresa>.Filter.And(filterAlias);

            var update = Builders<Empresa>.Update
                .Set(u => u.Carteira.DataUltimaAtualizacao, empresa.Carteira.DataUltimaAtualizacao)
                .Set(u => u.Carteira.Saldo, empresa.Carteira.Saldo)
                .Set(u => u.Carteira.Creditos, empresa.Carteira.Creditos)
                .Set(u => u.Carteira.Historico, empresa.Carteira.Historico);

            var result = await _dbSet.UpdateOneAsync(filter, update);

            return result.ModifiedCount == 1;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
