using Application;
using Application.ViewModels;
using Application.ViewModels.Response;
using Domain.Interfaces.Bus;
using Domain.Notifications;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ApiBaseController
    {
        private readonly IEmpresaApplicationServices _empresaApplicationServices;
        public EmpresaController(
             IEmpresaApplicationServices empresaApplicationService,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator
            ) : base(notifications, mediator)
        {
            _empresaApplicationServices = empresaApplicationService;
        }

        /// <summary>
        /// Cria uma Empresa
        /// </summary>
        /// <remarks> 
        /// POST /empresa/ 
        /// Request Exemplo:
        /// {
        ///     "nomeFantasia": "Zeca Urubu's Bar",
        ///     "razaoSocial": "Jose Urubu Lanchonete LTDA",
        ///     "segmento": "Castas",
        ///     "alias": "zeca urubu",
        ///     "site": "www.zecaurububar.com.br",
        ///     "tipo": "Cliente",
        ///     "empresaProprietariaId": "91086621000195",
        ///     "centroCusto": "",
        ///     "gruposOrganizacionais": [
        ///         "Vila dos Sapos"
        ///     ],
        ///     "documentos": [
        ///         {
        ///             "tipo": "CNPJ",
        ///             "numero": "22.665.831/0001-15"
        ///         },
        ///         {
        ///             "tipo": "IE",
        ///             "numero": "85438826000190"
        ///         }
        ///     ],
        /// 	"responsavel": {
        /// 		"nome": "José Carlos da Silva",
        /// 		"email": "zecaurubu@zipmail.com.br",
        /// 		"telefone": "+551433426289",
        /// 		"celular": "+5514998196768"
        /// 	},
        ///     "endereco": {
        ///         "logradouro": "Rua dos Bodes",
        ///         "numero": "51",
        ///         "complemento": "",
        ///         "bairro": "Jardim das Cabritas",
        ///         "cidade": "Chavantes",
        ///         "estado":"SP",
        ///         "cep": "18970000",
        ///         "pais": "BR"
        ///     },
        ///     "planos": [
        ///         {
        ///             "id": "e7da9da9-a645-486c-b6aa-2a5e79fc5930",
        ///             "titulo": "Hotéis de 3 e 4 estrelas",
        ///             "tipoPlano": "Padrão",
        ///             "valorPlano": 40,
        ///             "diarias": 4,
        ///             "valorDiariaMinima": 0.01,
        ///             "valorDiariaMaxima": 199.99,
        ///             "vigencia": "2020-07-31 23:59:59",
        ///             "ativo": true,
        /// 			"billing": {
        /// 				"formaPagamento": "boleto",
        /// 				"valorTotalAtual": 480,
        /// 				"totalAssinantes": 20,
        /// 				"totalColaboradores": 100,
        /// 				"coparticipacao": 60
        /// 			}
        ///         }
        ///     ],
        ///     "ativo": true
        /// }
        ///
        /// Response Exemplo
        /// 
        ///     {
        ///         "metadata": {
        ///                 "resultset": {
        ///                 "type": "object"
        ///                 }
        ///             },
        ///             "result": {
        ///                 "id": "d127b728-f84b-4dc1-926a-924cd402e49e"
        ///         }
        ///     }
        /// 
        /// </remarks>
        /// <param name="empresaPostViewModel">Dados necessários para criar uma Empresa</param>
        /// <response code="200">Se for possível criar o Empresa com sucesso</response>
        /// <response code="400">Se acontecer algum problema de regra de negócio</response>          
        /// <response code="500">Se acontecer algum problema inesperado</response>         
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(EmpresaPostResponseViewModel<object>))]
        [ProducesResponseType(400, Type = typeof(EmpresaPostResponseViewModel<object>))]
        [ProducesResponseType(500, Type = typeof(EmpresaPostResponseViewModel<object>))]
        public async Task<IActionResult> Post([FromBody] EmpresaPostViewModel empresaPostViewModel)
        {
            Console.WriteLine("\n".PadRight(70, '-'));
            Console.WriteLine($"*** CRIAÇÃO DE CONTA ***");
            Console.WriteLine("".PadRight(70, '-'));

            string jsonDump = JsonConvert.SerializeObject(empresaPostViewModel);
            Console.WriteLine(jsonDump);
            Console.WriteLine("\n".PadRight(70, '-'));

            var empresaResponse = await _empresaApplicationServices.IncluirAsync(empresaPostViewModel);
            return Response(empresaResponse);
        }

        /// <summary>
        /// Atualiza uma Empresa específica
        /// </summary>
        /// <remarks> 
        /// PUT /empresa/{cnpj}
        /// Request Exemplo:
        /// {
        ///     "nomeFantasia": "Zeca Urubu's Bar",
        ///     "razaoSocial": "Jose Urubu Lanchonete LTDA",
        ///     "alias": "zeca urubu",
        ///     "segmento": "Castas",
        ///     "site": "www.zecaurububar.com.br",
        ///     "tipo": "Cliente",
        ///     "empresaProprietariaId": "91086621000195",
        ///     "centroCusto": "",
        ///     "gruposOrganizacionais": [
        ///         "Vila dos Sapos"
        ///     ],
        ///     "documentos": [
        ///         {
        ///             "tipo": "CNPJ",
        ///             "numero": "22.665.831/0001-15"
        ///         },
        ///         {
        ///             "tipo": "IE",
        ///             "numero": "85438826000190"
        ///         }
        ///     ],
        /// 	"responsavel": {
        /// 		"nome": "José Carlos da Silva",
        /// 		"email": "zecaurubu@zipmail.com.br",
        /// 		"telefone": "+551433426289",
        /// 		"celular": "+5514998196768"
        /// 	},
        ///     "endereco": {
        ///         "logradouro": "Rua dos Bodes",
        ///         "numero": "51",
        ///         "complemento": "",
        ///         "bairro": "Jardim das Cabritas",
        ///         "cidade": "Chavantes",
        ///         "estado":"SP",
        ///         "cep": "18970000",
        ///         "pais": "BR"
        ///     },
        ///     "planos": [
        ///         {
        ///             "id": "e7da9da9-a645-486c-b6aa-2a5e79fc5930",
        ///             "titulo": "Hotéis de 3 e 4 estrelas",
        ///             "tipoPlano": "Padrão",
        ///             "valorPlano": 40,
        ///             "diarias": 4,
        ///             "valorDiariaMinima": 0.01,
        ///             "valorDiariaMaxima": 199.99,
        ///             "vigencia": "2020-07-31 23:59:59",
        ///             "ativo": true,
        /// 			"billing": {
        /// 				"formaPagamento": "boleto",
        /// 				"valorTotalAtual": 480,
        /// 				"totalAssinantes": 20,
        /// 				"totalColaboradores": 100,
        /// 				"coparticipacao": 60
        /// 			}
        ///         }
        ///     ],
        ///     "ativo": true
        /// }
        ///
        /// Response Exemplo:
        /// (corpo vazio, se sucesso)
        /// 
        
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="empresaPutViewModel"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(EmpresaPutResponseViewModel<object>))]
        [ProducesResponseType(400, Type = typeof(EmpresaPutResponseViewModel<object>))]
        [ProducesResponseType(500, Type = typeof(EmpresaPutResponseViewModel<object>))]
        public async Task<IActionResult> Put([FromRoute] string id, [FromBody] EmpresaPutViewModel empresaPutViewModel)
        {
            Console.WriteLine("\n".PadRight(70, '-'));
            Console.WriteLine($"*** ATUALIZAÇÃO DE CONTA - [Id: {id}] ***");
            Console.WriteLine("".PadRight(70, '-'));

            string jsonDump = JsonConvert.SerializeObject(empresaPutViewModel);
            Console.WriteLine(jsonDump);
            Console.WriteLine("\n".PadRight(70, '-'));

            empresaPutViewModel.Id = id;
            _ = await _empresaApplicationServices.AtualizarAsync(empresaPutViewModel);
            return Response();
        }

        /// <summary>
        /// Consulta de Empresa por CNPJ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(400, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(500, Type = typeof(EmpresaGetResponseViewModel<object>))]
        public async Task<IActionResult> Get([FromRoute] string id)
        {
            var result = await _empresaApplicationServices.ObterEmpresaPorIdAsync(id);
            return Response(result);
        }

        /// <summary>
        /// Pesquisa de Empresas
        /// </summary>
        /// <param name="parameters">Parametros de Consulta</param>       
        /// <returns></returns>
        /// <response code="200">Pesquisa realizada com Sucesso</response>
        /// <response code="400">Se acontecer algum problema de regra de negócio</response>          
        /// <response code="500">Se acontecer algum problema inesperado</response>    
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(400, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(500, Type = typeof(EmpresaGetResponseViewModel<object>))]
        public async Task<IActionResult> Get([FromQuery] EmpresaParametersViewModel parameters)
        {
            var result = await _empresaApplicationServices.ObterPorParametrosAsync(parameters);
            return Response(result);
        }

        /// <summary>
        /// Buscar o CNPJ da Empresa pelo alias
        /// </summary>
        /// <param name="alias"></param>
        /// <returns></returns>
        [HttpGet("alias/{alias}")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(400, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(500, Type = typeof(EmpresaGetResponseViewModel<object>))]
        public async Task<IActionResult> GetEmpresaByAlias([FromRoute] string alias)
        {
            var result = await _empresaApplicationServices.ObterEmpresaPorAliasAsync(alias);
            return Response(result);
        }


        [HttpGet("alias/{alias}/{cnpj}")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(400, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(500, Type = typeof(EmpresaGetResponseViewModel<object>))]
        public async Task<IActionResult> GetEmpresaByAliasCnpj([FromRoute] string alias, [FromRoute] string cnpj)
        {
            var result = await _empresaApplicationServices.ObterEmpresaPorAliasCnpjAsync(alias, cnpj);
            return Response(result);
        }

        /// <summary>
        /// Verifica se é válido o relacionamento entre a Matriz e a Filial
        /// </summary>
        /// <param name="cnpjMatriz"></param>
        /// <param name="cnpjFilial"></param>
        /// <returns></returns>
        [HttpGet("verifica-relacionamento/{cnpjMatriz}/{cnpjFilial}")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(400, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(500, Type = typeof(EmpresaGetResponseViewModel<object>))]
        public async Task<IActionResult> CheckRelacionamentoMatrizComFilial([FromRoute] string cnpjMatriz, [FromRoute] string cnpjFilial)
        {
            var result = await _empresaApplicationServices.VerificaRelacionamentoMatrizComFilial(cnpjMatriz, cnpjFilial);
            return Response(result);
        }

        ///// <summary>
        ///// Verifica se é válido o relacionamento entre a Matriz e a Filial
        ///// </summary>
        ///// <param name="cnpjMatriz"></param>
        ///// <param name="cnpjFilial"></param>
        ///// <returns></returns>
        [HttpPatch("{cnpj}/cobranca")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(400, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(500, Type = typeof(EmpresaGetResponseViewModel<object>))]
        public async Task<IActionResult> AtualizarDadosCobranca([FromRoute] string cnpj, [FromBody] EmpresaCobrancaPutViewModel dadosCobranca)
        {
            Console.WriteLine("\n".PadRight(70, '-'));
            Console.WriteLine($"*** ATUALIZAÇÃO DE DADOS DE COBRANÇA - [CNPJ: {cnpj}] ***");
            Console.WriteLine("".PadRight(70, '-'));

            string jsonDump = JsonConvert.SerializeObject(dadosCobranca);
            Console.WriteLine(jsonDump);
            Console.WriteLine("\n".PadRight(70, '-'));

            var result = await _empresaApplicationServices.AtualizarDadosCobranca(cnpj, dadosCobranca);
            return Response(result);
        }

        /// <summary>
        /// Atualiza Status Financeiro Empresa específica
        /// </summary>
        /// <remarks> 
        /// PUT /empresa/{cnpj}
        /// Request Exemplo:
        /// {
        ///     "statusFinanceiro": "Adimplente"
        /// }
        ///
        /// 
        /// </remarks>
        /// <param name="cnpj"></param>
        /// <param name="empresaStatusFinanceiro"></param>
        /// <returns></returns>
        [HttpPatch("{cnpj}/StatusFinanceiro")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(EmpresaPutResponseViewModel<object>))]
        [ProducesResponseType(400, Type = typeof(EmpresaPutResponseViewModel<object>))]
        [ProducesResponseType(500, Type = typeof(EmpresaPutResponseViewModel<object>))]
        public async Task<IActionResult> PutStatusFinanceiro([FromRoute] string cnpj, [FromBody] EmpresaStatusFinanceiroPutViewModel empresaStatusFinanceiro)
        {
            Console.WriteLine("\n".PadRight(70, '-'));
            Console.WriteLine($"*** ATUALIZAÇÃO DE STATUAS FINANCEIRO - [CNPJ: {cnpj}] ***");
            Console.WriteLine("".PadRight(70, '-'));
            
            empresaStatusFinanceiro.CNPJ = cnpj;

            string jsonDump = JsonConvert.SerializeObject(empresaStatusFinanceiro);
            Console.WriteLine(jsonDump);
            Console.WriteLine("\n".PadRight(70, '-'));

            var result = await _empresaApplicationServices.AtualizarStatusFinanceiro(cnpj, empresaStatusFinanceiro);
            return Response(result);
        }

        /// <summary>
        /// Consulta de Planos da Empresa por CNPJ e Codigo do Plano 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="planoId"></param>
        /// <returns></returns>
        [HttpGet("planos/{id}/{planoId}")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(400, Type = typeof(EmpresaGetResponseViewModel<object>))]
        [ProducesResponseType(500, Type = typeof(EmpresaGetResponseViewModel<object>))]
        public async Task<IActionResult> GetPlanosByEmpresa([FromRoute] string id, [FromRoute] string planoId)
        {
            var result = await _empresaApplicationServices.ObterPlanosEmpresaAsync(id, planoId);
            return Response(result);
        }

        /// <summary>
        /// Lanca as premiações no extrato de Creditos da empresa
        /// </summary>
        /// <param name="cnpj">CNPJ da empresa</param>
        /// <param name="model">Model de credito</param>
        /// <returns></returns>
        [HttpPut("{cnpj}/creditos/lancamento")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(EmpresaCarteiraPutResponseViewModel<object>))]
        [ProducesResponseType(400, Type = typeof(EmpresaCarteiraPutResponseViewModel<object>))]
        [ProducesResponseType(500, Type = typeof(EmpresaCarteiraPutResponseViewModel<object>))]
        public async Task<EmpresaCarteiraPutResponseViewModel<object>> PutUsoDeCreditosPremiacao([FromRoute] string cnpj, [FromBody] EmpresaPremiacaoCreditoPutViewModel model)
        {
            return await _empresaApplicationServices.AtualizarCredito(cnpj, model);
        }

    }
}