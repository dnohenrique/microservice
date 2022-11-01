using Application.ViewModels;
using Application.ViewModels.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface IEmpresaApplicationServices : IDisposable
    {
        Task<EmpresaPostResponseViewModel<object>> IncluirAsync(EmpresaPostViewModel empresaViewModel);

        Task<EmpresaPutResponseViewModel<object>> AtualizarAsync(EmpresaPutViewModel empresaPutViewModel);

        Task<EmpresaGetResponseViewModel<object>> DeletarAsync(string id);

        Task<EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>> ObterPorParametrosAsync(EmpresaParametersViewModel parameters);
        Task<EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>> ObterEmpresaPorIdAsync(string id);
        Task<EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>> ObterEmpresaPorCNPJAsync(string CNPJ);

        Task<EmpresaGetResponseViewModel<string>> ObterEmpresaPorAliasAsync(string dominio);
        Task<EmpresaGetResponseViewModel<string>> ObterEmpresaPorAliasCnpjAsync(string dominio, string CNPJ);
        Task<EmpresaGetResponseViewModel<bool>> VerificaRelacionamentoMatrizComFilial(string cnpjMatriz, string cnpjFilial);
        Task<EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>> ObterPlanosEmpresaAsync(string id, string planoId);

        Task<EmpresaPutResponseViewModel<object>> AtualizarDadosCobranca(string cnpjMatriz, EmpresaCobrancaPutViewModel dadosCobranca);
        Task<EmpresaPutResponseViewModel<object>> AtualizarStatusFinanceiro(string cnpjMatriz, EmpresaStatusFinanceiroPutViewModel statusFinanceiro);

        Task<EmpresaCarteiraPutResponseViewModel<object>> AtualizarCredito(string cnpj, EmpresaPremiacaoCreditoPutViewModel lancamento);
    }
}
