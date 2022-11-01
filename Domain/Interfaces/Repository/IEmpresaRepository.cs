using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IEmpresaRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //outras acoes, pois as padroes ja estao mapeadas na IRepository
        Task<Tuple<List<TEntity>, long>> ObterPorParametrosAsync(
                    int limit,
                    int offset,
                    string nomeFantasia = null,
                    string razaoSocial = null,
                    string segmento = null,
                    string site = null,
                    string tipo = null,
                    string empresaProprietariaId = null,
                    string centroCusto = null,
                    string cnpj = null,
                    IEnumerable<string> cnpjsIn = null,
                    IEnumerable<string> cnpjsOut = null,
                    int? diaCobrancaInicial = null,
                    int? diaCobrancaFinal = null,
                    bool? cobrancaAutomatica = null
                );
        Task<List<TEntity>> ObterEmpresaPorAliasAsync(string dominio);
        Task<bool> AtualizarCobranca(Cobranca cobranca, string cnpj);
        Task<bool> AtualizarStatusFinanceiro(string statusFinanceiro, string cnpj);
        Task<bool> AtualizarCarteira(Empresa empresa);
    }
}
