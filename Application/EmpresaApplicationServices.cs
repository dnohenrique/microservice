using Application.ViewModels;
using Application.ViewModels.Response;
using AutoMapper;
using Domain.Command;
using Domain.Entities;
using Domain.Event;
using Domain.Interfaces.Bus;
using Domain.Interfaces.Repository;
using Domain.Notifications;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class EmpresaApplicationServices : IEmpresaApplicationServices
    {
        private readonly IMapper _mapper;
        private readonly IEmpresaRepository<Empresa> _empresaRepository;
        private readonly IMediatorHandler _bus;
        public EmpresaApplicationServices(IMapper mapper,
            IEmpresaRepository<Empresa> empresaRepository,
            IMediatorHandler bus)
        {
            _mapper = mapper;
            _empresaRepository = empresaRepository;
            _bus = bus;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


        public async Task<EmpresaPutResponseViewModel<object>> AtualizarAsync(EmpresaPutViewModel empresaPutViewModel)
        {

            var registerEvent = _mapper.Map<AtualizarEmpresaEvent>(empresaPutViewModel);
            await _bus.PublishEvent(registerEvent);

            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.String.ToString())
            };


            var resultadoResponse = new EmpresaPutResponseViewModel<object>
            {
                Result = metadata.ResultSet,
                MetaDataViewModel = metadata
            };

            return resultadoResponse;

        }

        public async Task<EmpresaPutResponseViewModel<object>> AtualizarDadosCobranca(string cnpjMatriz, EmpresaCobrancaPutViewModel dadosCobranca)
        {
            dadosCobranca.CNPJ = cnpjMatriz;
            var registerEvent = _mapper.Map<AtualizarEmpresaCobrancaEvent>(dadosCobranca);
            await _bus.PublishEvent(registerEvent);

            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.Bool.ToString())
            };


            var resultadoResponse = new EmpresaPutResponseViewModel<object>
            {
                Result = metadata.ResultSet,
                MetaDataViewModel = metadata
            };

            return resultadoResponse;
        }

        public async Task<EmpresaPutResponseViewModel<object>> AtualizarStatusFinanceiro(string cnpjMatriz, EmpresaStatusFinanceiroPutViewModel empresaStatusFinanceiro)
        {
            empresaStatusFinanceiro.CNPJ = cnpjMatriz;
            var registerEvent = _mapper.Map<AtualizarEmpresaStatusFinanceiroEvent>(empresaStatusFinanceiro);
            await _bus.PublishEvent(registerEvent);

            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.Bool.ToString())
            };

            var resultadoResponse = new EmpresaPutResponseViewModel<object>
            {
                Result = new { success = true },
                MetaDataViewModel = metadata
            };

            return resultadoResponse;
        }

        public async Task<EmpresaGetResponseViewModel<object>> DeletarAsync(string id)
        {
            var registerEvent = _mapper.Map<DeletarEmpresaEvent>(id);
            await _bus.PublishEvent(registerEvent);

            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.Object.ToString())
            };

            var resultadoResponse = new EmpresaGetResponseViewModel<object>
            {
                Result = new { id },
                MetaDataViewModel = metadata
            };

            return resultadoResponse;

        }

        public async Task<EmpresaPostResponseViewModel<object>> IncluirAsync(EmpresaPostViewModel empresaViewModel)
        {
            var registerCommand = _mapper.Map<CriarEmpresaCommand>(empresaViewModel);
            var id = await _bus.SendCommand(registerCommand);

            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.Object.ToString())
            };

            var resultadoResponse = new EmpresaPostResponseViewModel<object>
            {
                Result = new { id },
                MetaDataViewModel = metadata
            };

            return resultadoResponse;
        }

        public async Task<EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>> ObterEmpresaPorIdAsync(string id)
        {
            var empresa = await _empresaRepository.ObterPorIdAsync(id);
            var empresaGetViewModel = _mapper.Map<EmpresaGetViewModel>(empresa);

            if (empresaGetViewModel != null && empresaGetViewModel.Planos != null)
                empresaGetViewModel.Planos = empresaGetViewModel.Planos.OrderBy(_ => _.Diarias).ToList();

            ExibirCreditosNaValidade(empresaGetViewModel);

            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.Object.ToString())
            };

            var result = new EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>
            {
                Result = new List<EmpresaGetViewModel>
            {
                empresaGetViewModel
            }
            };

            var resultadoResponse = new EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>
            {
                Result = result.Result,
                MetaDataViewModel = metadata
            };

            return resultadoResponse;
        }

        public async Task<EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>> ObterEmpresaPorCNPJAsync(string CNPJ)
        {
            var empresa = await _empresaRepository.ObterPorCNPJAsync(CNPJ);
            var t = _mapper.Map<EmpresaGetViewModel>(empresa);
            ExibirCreditosNaValidade(t);

            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.Object.ToString())
            };

            var result = new EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>
            {
                Result = new List<EmpresaGetViewModel>
            {
                t
            }
            };

            var resultadoResponse = new EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>
            {
                Result = result.Result,
                MetaDataViewModel = metadata
            };

            return resultadoResponse;
        }

        private static void ExibirCreditosNaValidade(EmpresaGetViewModel t)
        {
            if (t != null && t.Carteira != null && t.Carteira.Creditos != null)
            {
                var dataAtual = DateTime.UtcNow;
                var creditosVencidos = t.Carteira.Creditos.Where(x => x.ValidadeEfetiva.Date < dataAtual.Date);

                if (creditosVencidos.Count() > 0)
                {
                    t.Carteira.Creditos.RemoveAll(x => x.ValidadeEfetiva.Date < dataAtual.Date);
                    t.Carteira.SaldoConsolidado -= creditosVencidos.Select(x => x.QuantidadeRestante).Sum();
                }
            }
        }

        public async Task<EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>> ObterPorParametrosAsync(EmpresaParametersViewModel parameters)
        {
            List<string> msgsErro = parameters.ValidarParametros();

            if (msgsErro.Count > 0)
            {
                await _bus.PublishEvent(new DomainNotification("parametros_invalidos", string.Join('\n', msgsErro)));

                return new EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>()
                {
                    Result = new List<EmpresaGetViewModel>(),
                    MetaDataViewModel = new MetaDataViewModel { ResultSet = new ResultsetPaginationViewModel(ReturnType.List.ToString()) }
                };
            }

            var resultado = await _empresaRepository.ObterPorParametrosAsync
                (
                    nomeFantasia: parameters.NomeFantasia,
                    razaoSocial: parameters.RazaoSocial,
                    segmento: parameters.Segmento,
                    site: parameters.Site,
                    tipo: parameters.Tipo,
                    empresaProprietariaId: parameters.EmpresaProprietariaId,
                    centroCusto: parameters.CentroCusto,
                    diaCobrancaInicial: parameters.DiaCobrancaInicio,
                    diaCobrancaFinal: parameters.DiaCobrancaFim,
                    cobrancaAutomatica: parameters.CobrancaAutomatica,
                    limit: parameters.limit,
                    offset: parameters.offset,
                    cnpj: parameters.Cnpj,
                    cnpjsIn: (!String.IsNullOrEmpty(parameters.CnpjsIn)) ? parameters.CnpjsIn.Split("_") : null,
                    cnpjsOut: (!String.IsNullOrEmpty(parameters.CnpjsOut)) ? parameters.CnpjsOut.Split("_") : null
                );

            var empresas = _mapper.Map<List<Empresa>, List<EmpresaGetViewModel>>(resultado.Item1);

            ResultsetPaginationViewModel resultsetPaginationViewModel = new ResultsetPaginationViewModel(ReturnType.List.ToString(), parameters.offset, parameters.limit, resultado.Item2);

            return new EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>()
            {
                Result = empresas,
                MetaDataViewModel = new MetaDataViewModel { ResultSet = resultsetPaginationViewModel }
            };
        }

        public async Task<EmpresaGetResponseViewModel<string>> ObterEmpresaPorAliasAsync(string alias)
        {
            var resultado = await _empresaRepository.ObterEmpresaPorAliasAsync(alias);

            Empresa empresa;
            if (resultado.Count > 1)
            {
                empresa = resultado.Where(c => c.EmpresaProprietariaId == c.Id).FirstOrDefault();
            }
            else
            {
                if (resultado.Count == 1)
                {
                    empresa = resultado.FirstOrDefault();
                }
                else
                {
                    empresa = null;
                }
            }

            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.String.ToString())
            };

            var resultadoResponse = new EmpresaGetResponseViewModel<string>
            {
                Result = ObterToken(empresa),
                MetaDataViewModel = metadata
            };

            return resultadoResponse;
        }

        public async Task<EmpresaGetResponseViewModel<string>> ObterEmpresaPorAliasCnpjAsync(string alias, string cnpj)
        {
            var resultado = await _empresaRepository.ObterEmpresaPorAliasAsync(alias);

            Empresa empresa;
            if (resultado.Count > 1)
            {
                empresa = resultado.Where(c => c.Documentos[0].Tipo == "CNPJ" && c.Documentos[0].Numero.Equals(cnpj)).FirstOrDefault();
            }
            else
            {
                if (resultado.Count == 1)
                {
                    empresa = resultado.FirstOrDefault();
                }
                else
                {
                    empresa = null;
                }
            }

            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.String.ToString())
            };

            var resultadoResponse = new EmpresaGetResponseViewModel<string>
            {
                Result = ObterToken(empresa),
                MetaDataViewModel = metadata
            };

            return resultadoResponse;
        }



        public async Task<EmpresaGetResponseViewModel<Boolean>> VerificaRelacionamentoMatrizComFilial(string cnpjMatriz, string cnpjFilial)
        {
            var empresaFilial = await ObterEmpresaPorIdAsync(cnpjFilial);

            Boolean filialValida = false;

            empresaFilial.Result.ForEach((empresa) =>
            {
                if (empresa != null && empresa.EmpresaProprietariaId == cnpjMatriz)
                {
                    filialValida = true;
                }
            });

            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.Bool.ToString())
            };

            var resultadoResponse = new EmpresaGetResponseViewModel<Boolean>
            {
                Result = filialValida,
                MetaDataViewModel = metadata
            };

            return resultadoResponse;
        }

        public async Task<EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>> ObterPlanosEmpresaAsync(string id, string planoId)
        {
            var empresa = await _empresaRepository.ObterPorIdAsync(id);
            var empresaGetViewModel = _mapper.Map<EmpresaGetViewModel>(empresa);

            if (empresaGetViewModel != null && empresaGetViewModel.Planos != null)
            {
                empresaGetViewModel.Planos = empresaGetViewModel.Planos.OrderBy(_ => _.ValorDiariaMaxima).ToList();

                var planoAtual = empresaGetViewModel.Planos.FirstOrDefault(p => p.Id == Guid.Parse(planoId));

                if (planoAtual != null)
                {
                    List<EmpresaPlanoViewModel> planos = new List<EmpresaPlanoViewModel>();

                    foreach (EmpresaPlanoViewModel item in empresaGetViewModel.Planos)
                    {
                        if (item.ValorPlano > planoAtual.ValorPlano)
                        {
                            planos.Add(item);
                        }
                    }

                    empresaGetViewModel.Planos = planos;
                }
            }


            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.Object.ToString())
            };

            var result = new EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>
            {
                Result = new List<EmpresaGetViewModel>
            {
                empresaGetViewModel
            }
            };

            var resultadoResponse = new EmpresaGetResponseViewModel<List<EmpresaGetViewModel>>
            {
                Result = result.Result,
                MetaDataViewModel = metadata
            };

            return resultadoResponse;
        }

        private string ObterToken(Empresa empresa)
        {
            if (empresa == null)
            {
                return null;
            }
            //new Claim(JwtRegisteredClaimNames.Email, usuario.Email, ClaimValueTypes.String),
            //Guid id
            string signingKey = "kzfSPDKwdx5KnyxtBTlwNW_IoqrpbaGRwaFNdqxQyv-WVIqeLKOGJVLmh4lRd4wUPmolq6CM7Bs4r1NRbAoZQZQui80YbqMGuymdw5NSlnMvoMHNdF2niiydKV5X2esajAZk6t1pu1Jf05TNIxQBO1aI8xnk4ttVIPXRDG47wKlTPwnvqpVX3lh5nwrG_A4fUj7KOslfysPbusORDePIQlnnCqkzURl3qanQzjku02kWxujqpujl3I1VpJ0zKc2ReeyVNoeKNG3WYi2eO8sYsDw8XtbkcY5mJW7dHeXSMYvzrFIWDbbxorb5LP0FtFbsgOfh8IYT4qzSL4BmUV17ag";
            var direitos = new[]
                {
                    new Claim("Id", empresa.Id),
                    new Claim("EmpresaProprietariaId", empresa.EmpresaProprietariaId),
                    new Claim(ClaimTypes.Role, "Empresa"),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey));
            var credenciais = new SigningCredentials(chave, SecurityAlgorithms.HmacSha512);

            var token = new JwtSecurityToken(
                issuer: "EmpresaService", //Emissor do Token
                audience: "Postman",
                claims: direitos,
                signingCredentials: credenciais,
                expires: DateTime.UtcNow.AddMinutes(1)
                );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenString;
        }

        public async Task<EmpresaCarteiraPutResponseViewModel<object>> AtualizarCredito(string cnpj, EmpresaPremiacaoCreditoPutViewModel lancamento)
        {
            StringBuilder msg = new StringBuilder();

            if (lancamento.Transacoes.Any(x => string.IsNullOrEmpty(x.Documento)))
                throw new InvalidOperationException("CPF para premiação está vazio ou nulo. Favor validar.");

            if (lancamento.Valor <= 0)
                throw new InvalidOperationException("Alguns lançamentos não possuem valor especificado. Favor validar.");

            if (string.IsNullOrEmpty(lancamento.Responsavel))
                throw new InvalidOperationException("O login do responsável pela(s) premiação(ões) não foi informado. Favor validar.");

            var empresa = await _empresaRepository.ObterPorCNPJAsync(cnpj);

            if (empresa == null)
                throw new InvalidOperationException($"A empresa com CNPJ {cnpj} não foi localizada na base de dados. Favor validar.");

            if (empresa.Carteira == null)
                throw new InvalidOperationException("Empresa não tem uma carteira de créditos elegível para realizar premiações. Favor validar.");

            if (empresa.Carteira.Saldo < lancamento.Valor)
                throw new InvalidOperationException("Empresa não possui saldo suficiente para efetuar a premiação. Favor validar a validade dos créditos no registro da empresa.");

            if (empresa.CreditosValidos == null || empresa.CreditosValidos.Count() == 0)
                throw new InvalidOperationException("Empresa não possui créditos dentro do prazo de validade para atender a esta premiação. Favor validar.");

            // Atualizar carteira de creditos para empresa
            empresa.AtualizarSaldoCarteira(lancamento.Valor);
            var total = lancamento.Valor;

            foreach (var credito in empresa.CreditosValidos)
            {
                credito.QuantidadeRestante -= total;
                if (credito.QuantidadeRestante < 0)
                {
                    total = credito.QuantidadeRestante * -1;
                    credito.QuantidadeRestante = 0;
                    empresa.AtualizarQuantidadeRestanteCredito(credito);
                }
                else
                {
                    total = 0;
                    empresa.AtualizarQuantidadeRestanteCredito(credito);
                    break;
                }
            }

            // Converter em pontos, salvar e atualizar as carteiras
            var mediaValor = lancamento.Valor / lancamento.Transacoes.Count();

            foreach (var transacaoDetalhe in lancamento.Transacoes)
            {
                decimal valorPorColaborador = mediaValor;

                empresa.AdicionarTransacaoHistorico(
                    new Transacao
                    (
                       null,
                       transacaoDetalhe.Documento,
                       mediaValor,
                       (decimal)0.06,
                       "Premiação B2B através do Portal RH",
                       lancamento.Responsavel
                    ));
            }

            await _empresaRepository.AtualizarCarteira(empresa);

            var metadata = new MetaDataViewModel()
            {
                ResultSet = new ResultsetPaginationViewModel(ReturnType.Object.ToString())
            };

            bool result = true;
            string idCampanha = empresa.CreditosValidos.FirstOrDefault().Origem;

            var resultadoResponse = new EmpresaCarteiraPutResponseViewModel<object>
            {
                Result = new { result, idCampanha },
                MetaDataViewModel = metadata
            };

            return resultadoResponse;
        }
    }
}
