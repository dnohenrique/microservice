using Domain.Command;
using Domain.CommandHandlers;
using Domain.Entities;
using Domain.Interfaces.Aws;
using Domain.Interfaces.Bus;
using Domain.Interfaces.Repository;
using Domain.Notifications;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Domain.Test
{
    public class CriarEmpresaCommandHandlerTest
    {
        private Mock<IMediatorHandler> _mediatorMock { get; set; }
        private CancellationToken _cancellationToken { get; set; }
        private Empresa _empresaEntity { get; set; }
        private CriarEmpresaCommand _criarEmpresaCommand { get; set; }
        private Mock<IEmpresaRepository<Empresa>> _empresaRepositoryMock { get; set; }
        private readonly Mock<IPublicarEmpresaNoSns> _publicarEmpresaNoSns;

        public CriarEmpresaCommandHandlerTest()
        {
            _mediatorMock = new Mock<IMediatorHandler>();
            _cancellationToken = new CancellationToken();

            var documentos = new List<Documento>()
            {
                new Documento("CNPJ", "29665462000100"),
                new Documento("IE", "123456"),
            };
            Endereco endereco = new Endereco("Rua dos corvos", "11", "", "Vila dos Gansos", "Chavantes", "SP", "18610261", "BR");
            Responsavel responsavel = new Responsavel("Corvito", "corvito@corvo.com", "1433423030", "14991308080");
            Guid id = new Guid("d127b728-f84b-4dc1-926a-924cd402e49e");
            DateTime dtVigencia = Convert.ToDateTime("2020-07-31 23:59:59");
            Billing billing = new Billing("boleto", 1080, 20, 100, 60);
            Plano plano = new Plano(id, "Padrão 4 Diárias", "Padrão", 90, 4, 0.01m, 270, null, dtVigencia, true)
            {
                Billing = billing
            };
            List<Plano> planos = new List<Plano>() { plano };
            EmpresaComercial comercial = new EmpresaComercial()
            {
                Email = "contato@graficadozezinho.com",
                Contato = "Corvito do Agreste",
                Telefone = "1433423030"
            };
            EmpresaFinanceiro financeiro = new EmpresaFinanceiro()
            {
                Email = "contato@graficadozezinho.com",
                Contato = "Corvito do Agreste",
                Telefone = "1433423030",
                DiaPagamento = 1,
                FormaPagamento = "boleto"
            };
            _empresaEntity = new Empresa(
                nomeFantasia: "Grafica do Zezinho",
                razaoSocial: "Jose Impressoes LTDA",
                segmento: "Grafica",
                site: "www.graficadozezinho.com",
                tipo: "O+",
                empresaProprietariaId: "91086621000195",
                centroCusto: "Matriz",
                gruposOrganizacionais: new string[1] { "" },
                documentos: documentos,
                endereco: endereco,
                null,
                planos: planos,
                ativo: true,
                dataCriacao: DateTime.UtcNow,
                financeiro: financeiro,
                comercial: comercial,
                alias: "zezinho",
                cobranca: null,
                statusFinanceiro: "Adimplente"
            );
            _empresaRepositoryMock = new Mock<IEmpresaRepository<Empresa>>();
            _publicarEmpresaNoSns = new Mock<IPublicarEmpresaNoSns>();
        }

        [Fact(DisplayName = "Criação de uma nova empresa deve retornar Documento do Tipo CNPJ quando for cadastrado com sucesso")]
        [Trait("Incluir", "Positvo")]
        public void Empresa_Criacao_Positivo_Deve_Retornar_Documento_CNPJ_Quando_Cadastrado_Com_Sucesso()
        {
            //Arrange
            _criarEmpresaCommand = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                _empresaEntity.RazaoSocial,
                _empresaEntity.Segmento,
                _empresaEntity.Site,
                _empresaEntity.Tipo,
                _empresaEntity.EmpresaProprietariaId,
                _empresaEntity.CentroCusto,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            )
            {
                Comercial = _empresaEntity.Comercial,
                Financeiro = _empresaEntity.Financeiro,
                Responsavel = _empresaEntity.Responsavel,
                Endereco = _empresaEntity.Endereco,
                Documentos = _empresaEntity.Documentos,
                Planos = _empresaEntity.Planos
            };
            var criarEmpresaCommandHandler = new CriarEmpresaCommandHandler(_empresaRepositoryMock.Object, _mediatorMock.Object, _publicarEmpresaNoSns.Object);


            _empresaRepositoryMock.Setup(a => a.ObterPorIdAsync(_empresaEntity.Documentos[0].Numero))
                    .Returns(Task.FromResult((Empresa)null));

            _publicarEmpresaNoSns.Setup(a => a.EnviarEmpresaIdAsync(_empresaEntity.Documentos[0].Numero))
                .Returns(Task.CompletedTask);

            //Act
            var criarEmpresaResult = criarEmpresaCommandHandler.Handle(_criarEmpresaCommand, _cancellationToken);

            //Assert
            var foundError = FoundErrorMessage(_mediatorMock.Invocations, $"xxxx");
            //_mediatorMock.Invocations.Count.Should().Be(0);
            criarEmpresaResult.Result.Should().Be(_empresaEntity.Documentos[0].Numero);

        }

        [Fact(DisplayName = "Criação de uma nova empresa deve retornar mensagem que deve ser informado o nome fantasia entre 3 a 100 caracteres")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Criacao_Negativo_NomeFantasia_Deve_Estar_Entre_3_A_100_Caracteres()
        {
            //Arrange
            _criarEmpresaCommand = new CriarEmpresaCommand(
                "OI",
                _empresaEntity.RazaoSocial,
                _empresaEntity.Segmento,
                _empresaEntity.Site,
                _empresaEntity.Tipo,
                _empresaEntity.EmpresaProprietariaId,
                _empresaEntity.CentroCusto,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            )
            {
                Comercial = _empresaEntity.Comercial,
                Financeiro = _empresaEntity.Financeiro,
                Responsavel = _empresaEntity.Responsavel,
                Endereco = _empresaEntity.Endereco,
                Documentos = _empresaEntity.Documentos,
                Planos = _empresaEntity.Planos
            };
            var criarEmpresaCommandHandler = new CriarEmpresaCommandHandler(_empresaRepositoryMock.Object, _mediatorMock.Object, _publicarEmpresaNoSns.Object);



            //Act
            var criarEmpresaResult = criarEmpresaCommandHandler.Handle(_criarEmpresaCommand, _cancellationToken);

            //Assert
            criarEmpresaResult.Result.Should().BeEmpty();
            _mediatorMock.Invocations.Count.Should().BeGreaterThan(0);
            var foundError = FoundErrorMessage(_mediatorMock.Invocations, $"O Nome Fantasia da empresa deverá conter entre 3 e 100 caracteres");

            foundError.Should().BeTrue();

        }

        [Fact(DisplayName = "Criação de uma nova empresa deve retornar mensagem que CNPJ já está cadastrado")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Criacao_Negativo_Quando_CNPJ_Ja_Cadastrado()
        {
            //Arrange
            _criarEmpresaCommand = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                _empresaEntity.RazaoSocial,
                _empresaEntity.Segmento,
                _empresaEntity.Site,
                _empresaEntity.Tipo,
                _empresaEntity.EmpresaProprietariaId,
                _empresaEntity.CentroCusto,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            )
            {
                Comercial = _empresaEntity.Comercial,
                Financeiro = _empresaEntity.Financeiro,
                Responsavel = _empresaEntity.Responsavel,
                Endereco = _empresaEntity.Endereco,
                Documentos = _empresaEntity.Documentos,
                Planos = _empresaEntity.Planos
            };
            var criarEmpresaCommandHandler = new CriarEmpresaCommandHandler(_empresaRepositoryMock.Object, _mediatorMock.Object, _publicarEmpresaNoSns.Object);

            _empresaRepositoryMock.Setup(a => a.ObterPorIdAsync(_empresaEntity.Documentos[0].Numero))
                    .Returns(Task.FromResult(_empresaEntity));

            //Act
            var criarEmpresaResult = criarEmpresaCommandHandler.Handle(_criarEmpresaCommand, _cancellationToken);

            //Assert
            criarEmpresaResult.Result.Should().BeEmpty();
            _mediatorMock.Invocations.Count.Should().BeGreaterThan(0);
            FoundErrorMessage(_mediatorMock.Invocations, $"Já existe uma empresa cadastrada com o CNPJ '{_empresaEntity.Documentos[0].Numero}'.").Should().BeTrue();
        }

        private bool FoundErrorMessage(IInvocationList invocations, string messageFind)
        {
            var arguments = (from x
                             in invocations
                             select x.Arguments).ToList();

            var foundMessage = false;

            foreach (var item in arguments)
            {
                foundMessage = item.FirstOrDefault().As<DomainNotification>().Value.Equals(messageFind);

                if (foundMessage)
                    break;
            }

            return foundMessage;
        }
    }
}
