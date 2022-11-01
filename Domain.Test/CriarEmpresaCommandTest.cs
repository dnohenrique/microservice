using Domain.Command;
using Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Domain.Test
{
    public class CriarEmpresaCommandTest
    {
        private Empresa _empresaEntity { get; set; }
        public CriarEmpresaCommandTest()
        {
            var documentos = new List<Documento>()
            {
                new Documento("CNPJ", "52506736000130"),
                new Documento("IE", "123456"),
            };
            var endereco = new Endereco("Rua dos corvos", "11", "", "Vila dos Gansos", "Chavantes", "SP", "18610261", "BR");
            var responsavel = new Responsavel("Corvito", "corvito@corvo.com", "1433423030", "14991308080");
            var id = new Guid("d127b728-f84b-4dc1-926a-924cd402e49e");
            var billing = new Billing("boleto", 1080, 20, 100, 60);
            var dtVigencia = Convert.ToDateTime("2020-07-31 23:59:59");
            var plano = new Plano(id, "Padrão 4 Diárias", "Padrão", 90, 4, 0.01m, 270, null, dtVigencia, true)
            {
                Billing = billing
            };
            var planos = new List<Plano>() { plano };
            var comercial = new EmpresaComercial()
            {
                Email = "contato@graficadozezinho.com",
                Contato = "Corvito Blackjack",
                Telefone = "1433423030"
            };
            var financeiro = new EmpresaFinanceiro()
            {
                Email = "contato@graficadozezinho.com",
                Contato = "Corvito Blackjack",
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
                responsavel: null,
                planos: planos,
                ativo: true,
                dataCriacao: DateTime.UtcNow,
                financeiro: financeiro,
                comercial: comercial,
                alias: "zezinho",
                cobranca: null,
                statusFinanceiro: "Adimplente"
            );
        }

        [Fact(DisplayName = "Validação de uma nova empresa deve retornar true")]
        [Trait("Incluir", "Positivo")]
        public void Empresa_Validacao_Positivo()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeTrue();
        }

        [Fact(DisplayName = "Validação de uma nova empresa deve retornar true quando dados do financeiro não for informado")]
        [Trait("Incluir", "Positivo")]
        public void Empresa_Validacao_Positivo_Quando_Dados_Financeiro_Nao_Informado()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Financeiro = null;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeTrue();
        }

        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando Responsavel não informado")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Validacao_Negativo_Quando_Dados_Responsavel_Nulo()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Responsavel = null;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Dados do Responsavel não informado");
        }

        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando Endereco não informado")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Validacao_Negativo_Quando_Dados_Endereco_Nulo()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Endereco = null;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Dados do Endereco não informado");
        }

        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando Endereco não informado")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Validacao_Negativo_Quando_Dados_Comercial_Nulo()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Comercial = null;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Dados do Comercial não informado");
        }

        //[Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando Endereco não informado")]
        //[Trait("Incluir", "Negativo")]
        //public void Empresa_Validacao_Negativo_Quando_Dados_Financeiro_Nulo()
        //{
        //    //Arrange
        //    var command = new CriarEmpresaCommand(
        //        _empresaEntity.NomeFantasia,
        //        _empresaEntity.RazaoSocial,
        //        _empresaEntity.Segmento,
        //        _empresaEntity.Site,
        //        _empresaEntity.Tipo,
        //        _empresaEntity.EmpresaProprietariaId,
        //        _empresaEntity.CentroCusto,
        //        _empresaEntity.GruposOrganizacionais,
        //        _empresaEntity.Ativo,
        //        _empresaEntity.Alias,
        //        _empresaEntity.StatusFinanceiro
//    );
//    command = CompletaDadosCommand(command);
//    command.Financeiro = null;
//    //Act
//    var result = command.IsValid();
//    //Assert
//    result.Should().BeFalse();
//    command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Dados do Financeiro não informado");
//}

[Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando Billing não informado")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Validacao_Negativo_Quando_Dados_Billing_Nulo()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            var plano = new Plano(new Guid(), "Padrão 4 Diárias", "Padrão", 90, 4, 0.01m, 270, null, DateTime.UtcNow.AddYears(2), true);
            command.Planos = new List<Plano>() { plano };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Dados do Billing não informado");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando nome fantasia é inválida")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("oi")]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        [InlineData("       ")]
        public void Empresa_Validacao_Negativo_NomeFantasia_Invalida(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
                valor,
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
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Nome Fantasia da empresa deverá conter entre 3 e 100 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando razao social é inválida")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("oi")]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        [InlineData("       ")]
        public void Empresa_Validacao_Negativo_RazaoSocial_Invalida(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                valor,
                _empresaEntity.Segmento,
                _empresaEntity.Site,
                _empresaEntity.Tipo,
                _empresaEntity.EmpresaProprietariaId,
                _empresaEntity.CentroCusto,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "A Razão Social da empresa deverá conter entre 3 e 100 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar true quando segmento não for informado")]
        [Trait("Incluir", "Positivo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void Empresa_Validacao_Positivo_Segmento_NaoInformado(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                _empresaEntity.RazaoSocial,
                valor,
                _empresaEntity.Site,
                _empresaEntity.Tipo,
                _empresaEntity.EmpresaProprietariaId,
                _empresaEntity.CentroCusto,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeTrue();
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando segmento é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData("oi")]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public void Empresa_Validacao_Negativo_Segmento_Invalido(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                _empresaEntity.RazaoSocial,
                valor,
                _empresaEntity.Site,
                _empresaEntity.Tipo,
                _empresaEntity.EmpresaProprietariaId,
                _empresaEntity.CentroCusto,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Segmento da empresa deverá conter entre 3 e 40 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando empresa proprietaria id não for informado")]
        [Trait("Incluir", "Positivo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void Empresa_Validacao_Negativo_EmpresaProprietariaId_NaoInformado(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                _empresaEntity.RazaoSocial,
                _empresaEntity.Segmento,
                _empresaEntity.Site,
                _empresaEntity.Tipo,
                valor,
                _empresaEntity.CentroCusto,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando empresa proprietaria id é inválida")]
        [Trait("Incluir", "Negativo")]
        [InlineData("oi")]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public void Empresa_Validacao_Negativo_EmpresaProprietariaId_Invalido(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                _empresaEntity.RazaoSocial,
                _empresaEntity.Segmento,
                _empresaEntity.Site,
                _empresaEntity.Tipo,
                valor,
                _empresaEntity.CentroCusto,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "A Empresa Proprietária desta empresa deverá conter entre 3 e 100 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar true quando site não for informado")]
        [Trait("Incluir", "Positivo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void Empresa_Validacao_Positivo_Site_NaoInformado(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                _empresaEntity.RazaoSocial,
                _empresaEntity.Segmento,
                valor,
                _empresaEntity.Tipo,
                _empresaEntity.EmpresaProprietariaId,
                _empresaEntity.CentroCusto,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeTrue();
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando site é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData("oi")]
        public void Empresa_Validacao_Negativo_Site_Invalido(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                _empresaEntity.RazaoSocial,
                _empresaEntity.Segmento,
                valor,
                _empresaEntity.Tipo,
                _empresaEntity.EmpresaProprietariaId,
                _empresaEntity.CentroCusto,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Site da empresa deverá conter pelo menos 3 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando tipo é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void Empresa_Validacao_Negativo_Tipo_Invalida(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                _empresaEntity.RazaoSocial,
                _empresaEntity.Segmento,
                _empresaEntity.Site,
                valor,
                _empresaEntity.EmpresaProprietariaId,
                _empresaEntity.CentroCusto,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, insira o Tipo da empresa");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar true quando centro de custo não for informado")]
        [Trait("Incluir", "Positivo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void Empresa_Validacao_Positivo_CentroCusto_NaoInformado(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                _empresaEntity.RazaoSocial,
                _empresaEntity.Segmento,
                _empresaEntity.Site,
                _empresaEntity.Tipo,
                _empresaEntity.EmpresaProprietariaId,
                valor,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeTrue();
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando centro de custo é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData("oi")]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public void Empresa_Validacao_Negativo_CentroCusto_Invalido(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
                _empresaEntity.NomeFantasia,
                _empresaEntity.RazaoSocial,
                _empresaEntity.Segmento,
                _empresaEntity.Site,
                _empresaEntity.Tipo,
                _empresaEntity.EmpresaProprietariaId,
                valor,
                _empresaEntity.GruposOrganizacionais,
                _empresaEntity.Ativo,
                _empresaEntity.Alias,
                _empresaEntity.StatusFinanceiro
            );
            command = CompletaDadosCommand(command);
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Centro de Custo da empresa deverá conter entre 3 e 80 caracteres");
        }

        #region Responsavel
        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando email do responsavel não atende range de caracteres")]
        [Trait("Incluir", "Negativo")]
        [InlineData("a@b.c")]
        [InlineData("another.brick.in.the.wall.partii@pinkfloydfullconcert.com.br")]
        public void Empresa_Responsavel_Validacao_Negativo_Email_Viola_Comprimento(string valor)
        {
            //@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$"
            var responsavel = new Responsavel("Corvito", valor, "1433423030", "14991308080");
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Responsavel = null;

            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Email deverá conter entre 6 e 50 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando email do responsavel é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("@teste.com")]
        [InlineData("+oi@teste.com")]
        [InlineData("oi@teste")]
        [InlineData("oi@.teste.com")]
        [InlineData("oi@te&ste.com")]
        [InlineData("oi@teste.c")]
        [InlineData("oi@teste.c$o")]
        [InlineData("oi@teste.com.")]
        [InlineData("oi@teste.com.b")]
        [InlineData("       ")]
        public void Empresa_Responsavel_Validacao_Negativo_Email_Invalido(string valor)
        {
            //@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$"
            var responsavel = new Responsavel("Corvito", valor, "1433423030", "14991308080");
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Responsavel =null;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, informar um Email válido");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando telefone do responsavel não atende range de caracteres")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("    ")]
        [InlineData("143342123")]
        [InlineData("14334212345")]
        [InlineData("abc")]
        public void Empresa_Responsavel_Validacao_Negativo_Telefone_Viola_Comprimento(string valor)
        {
            //@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$"
            var responsavel = new Responsavel("Corvito", "corvito@milho.com", valor, "14991308080");
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Responsavel = null;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, informar um número de telefone fixo válido");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar true quando celular do responsável não for informado")]
        [Trait("Incluir", "Positivo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void Empresa_Responsavel_Validacao_Positivo_Celular_NaoInformado(string valor)
        {
            //@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$"
            var responsavel = new Responsavel("Corvito", "corvito@milho.com", "1433421234", valor);
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Responsavel = null;

            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeTrue();
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando telefone do responsavel não atende range de caracteres")]
        [Trait("Incluir", "Negativo")]
        [InlineData("1498765432")]
        [InlineData("149876543210")]
        [InlineData("abc")]
        public void Empresa_Responsavel_Validacao_Negativo_Celular_Viola_Comprimento(string valor)
        {
            //@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$"
            var responsavel = new Responsavel("Corvito", "corvito@milho.com", "1433421234", valor);
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Responsavel = null;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, informar um número de Celular válido");
        }
        #endregion

        #region endereco
        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando logradouro é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("oi")]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        [InlineData("       ")]
        public void Empresa_Endereco_Validacao_Negativo_Logradouro_Invalido(string valor)
        {
            var endereco = new Endereco(valor, "11", "", "Vila dos Gansos", "Chavantes", "SP", "18610261", "Brazil");
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Endereco = endereco;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Logradouro deverá conter entre 3 e 100 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando número do endereço é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("123456789012")]
        [InlineData("       ")]
        public void Empresa_Endereco_Validacao_Negativo_Numero_Endereco_Invalido(string valor)
        {
            var endereco = new Endereco("Rua dos Corvitos", valor, "", "Vila dos Gansos", "Chavantes", "SP", "18610261", "Brazil");
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Endereco = endereco;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Número do endereço deverá conter até 10 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar true quando complemento de endereço não for informado")]
        [Trait("Incluir", "Positivo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        [InlineData("Ap. 123")]
        [InlineData("Bl. 2, Conj. 1234")]
        [InlineData("C2")]
        public void Empresa_Endereco_Validacao_Positivo_Complemento_NaoInformado(string valor)
        {
            var endereco = new Endereco("Rua dos Corvitos", "51", valor, "Vila dos Gansos", "Chavantes", "SP", "18610261", "BR");
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Endereco = endereco;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeTrue();
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando complemento é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public void Empresa_Endereco_Validacao_Negativo_Complemento_Invalido(string valor)
        {
            var endereco = new Endereco("Rua dos Corvitos", "51", valor, "Vila dos Gansos", "Chavantes", "SP", "18610261", "BR");
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Endereco = endereco;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Complemento do endereço deverá conter até 40 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando logradouro é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("oi")]
        [InlineData("ABCDEJFGHIJ1234567890ABCDEJFGHIJ12345678901")]
        [InlineData("       ")]
        public void Empresa_Endereco_Validacao_Negativo_Bairro_Invalido(string valor)
        {
            var endereco = new Endereco("Rua das Cabritas", "11", "", valor, "Chavantes", "SP", "18610261", "BR");
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Endereco = endereco;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Bairro deverá conter entre 3 e 40 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando cidade é inválida")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("oi")]
        [InlineData("ABCDEJFGHIJ1234567890ABCDEJFGHIJ1234567890ABCDEJFGHIJ1")]
        [InlineData("       ")]
        public void Empresa_Endereco_Validacao_Negativo_Cidade_Invalida(string valor)
        {
            var endereco = new Endereco("Rua das Cabritas", "11", "", "Vila dos Gansos", valor, "SP", "18610261", "BR");
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Endereco = endereco;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "A Cidade deverá conter entre 3 e 50 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando o estado é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("A")]
        [InlineData("Rio Grande do Nordeste")]
        [InlineData("       ")]
        public void Empresa_Endereco_Validacao_Negativo_Estado_Invalido(string valor)
        {
            var endereco = new Endereco("Rua das Cabritas", "11", "", "Vila dos Gansos", "Chavantes", valor, "18610261", "BR");
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Endereco = endereco;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Estado deverá conter entre 2 e 20 caracteres");
        }


        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando o cep é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("ABCDEFGH")]
        [InlineData("1234567")]
        [InlineData("123456789")]
        [InlineData("       ")]
        public void Empresa_Endereco_Validacao_Negativo_Cep_Invalido(string valor)
        {
            var endereco = new Endereco("Rua das Cabritas", "11", "", "Vila dos Gansos", "Chavantes", "SP", valor, "BR");
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Endereco = endereco;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, informar um CEP válido");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando o país é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("Brazil")]
        [InlineData("       ")]
        public void Empresa_Endereco_Validacao_Negativo_Pais_Invalido(string valor)
        {
            var endereco = new Endereco("Rua das Cabritas", "11", "", "Vila dos Gansos", "Chavantes", "SP", "01415060", valor);
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Endereco = endereco;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, informar a sigla do País");
        }
        #endregion

        #region Documentos
        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando possui coleção de documento nula")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Documentos_Validacao_Negativo_Quando_Possui_Colecao_Nula()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Documentos = null;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Empresa deve possuir pelo menos um Documento");
        }

        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando não possui documento")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Documentos_Validacao_Negativo_Quando_Possui_Colecao_Vazia()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Documentos = new List<Documento>();
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Empresa deve possuir pelo menos um Documento");
        }

        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando não possui CNPJ")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Documentos_Validacao_Negativo_Nao_Possui_Documento_CNPJ()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Documentos = new List<Documento>()
            {
                new Documento("IE", "123456"),
            };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Empresa deve possuir um documento do tipo CNPJ");
        }

        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando documento Tipo for invalido")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Documentos_Validacao_Negativo_Nao_Documento_Tipo_For_Invalido()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Documentos = new List<Documento>()
            {
                new Documento("CNPJ", "52506736000130"),
                new Documento("IM", "1234")
            };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Os únicos tipos de documentos utilizados no cadastro de Empresa são CNPJ e IE");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando documento não for valido CNPJ")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("52506736000139")]
        [InlineData("99999999999999")]
        [InlineData("525067360001399")]
        [InlineData("A25067360001399")]
        [InlineData("       ")]
        public void Empresa_Documentos_Validacao_Negativo_Nao_For_Valido_CNPJ(string value)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Documentos = new List<Documento>()
            {
                new Documento("CNPJ", value)
            };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Documento do tipo CNPJ deve ser válido");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar true quando complemento de endereço não for informado")]
        [Trait("Incluir", "Positivo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        [InlineData("123")]
        [InlineData("12345678901234567890123456789012345678901234567890")]
        [InlineData("192.168.211.156")]
        public void Empresa_Documento_Validacao_Negativo_Nao_For_Valido_IE(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Documentos = new List<Documento>()
            {
                new Documento("CNPJ", "52506736000130"),
                new Documento("IE", valor),
            };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeTrue();
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando documento IE é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData("123456789012345678901234567890123456789012345678901")]
        [InlineData("12")]
        public void Empresa_Documento_Validacao_Negativo_IE_Invalido(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Documentos = new List<Documento>()
            {
                new Documento("CNPJ", "52506736000130"),
                new Documento("IE", valor),
            };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Documento do tipo IE deve ser válido");
        }
        #endregion

        #region Comercial
        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando email do comercial não atende range de caracteres")]
        [Trait("Incluir", "Negativo")]
        [InlineData("a@b.c")]
        [InlineData("another.brick.in.the.wall.partii@pinkfloydfullconcert.com.br")]
        public void Empresa_Comercial_Validacao_Negativo_Email_Viola_Comprimento(string valor)
        {
            //@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$"
            var comercial = new EmpresaComercial()
            {
                Email = valor,
                Contato = "Corvito",
                Telefone = "1433423030"
            };
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Comercial = comercial;

            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Email comercial deve conter entre 6 e 50 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando email do responsavel é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("@teste.com")]
        [InlineData("+oi@teste.com")]
        [InlineData("oi@teste")]
        [InlineData("oi@.teste.com")]
        [InlineData("oi@te&ste.com")]
        [InlineData("oi@teste.c")]
        [InlineData("oi@teste.c$o")]
        [InlineData("oi@teste.com.")]
        [InlineData("oi@teste.com.b")]
        [InlineData("       ")]
        public void Empresa_Comercial_Validacao_Negativo_Email_Invalido(string valor)
        {
            //@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$"
            var comercial = new EmpresaComercial()
            {
                Email = valor,
                Contato = "Corvito",
                Telefone = "1433423030"
            };
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Comercial = comercial;

            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, informar um Email comercial válido");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando telefone do responsavel não atende range de caracteres")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("    ")]
        [InlineData("143342123")]
        [InlineData("143342123456")]
        [InlineData("abc")]
        public void Empresa_Comercial_Validacao_Negativo_Telefone_Viola_Comprimento(string valor)
        {
            var comercial = new EmpresaComercial()
            {
                Email = "corvito@milho.com",
                Contato = "Corvito",
                Telefone = valor
            };

            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Comercial = comercial;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, informar um número de Telefone comercial válido");
        }
        #endregion

        #region Planos
        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando possui coleção de planos nula")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Planos_Validacao_Negativo_Possui_Colecao_Nula()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = null;
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Empresa deve possuir pelo menos um Plano");
        }

        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando possui coleção de planos vazia")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Planos_Validacao_Negativo_Possui_Colecao_Vazia()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>();
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Empresa deve possuir pelo menos um Plano");
        }

        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando o id de plano é inválido")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Plano_Validacao_Negativo_Id_Invalido()
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            var dtVigencia = Convert.ToDateTime("2020-07-31 23:59:59");
            var id = new Guid("00000000-0000-0000-0000-000000000000");
            var plano = new Plano(id, "Padrão 4 Diárias", "Padrão", 90, 4, 1, 270, null, dtVigencia, true)
            {
                Billing = _empresaEntity.Planos[0].Billing
            };
            var planos = new List<Plano>() { plano };
            command.Planos = new List<Plano>() { plano };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, insira um Id do plano no formato Guid");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando o titulo do plano é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void Empresa_Plano_Validacao_Negativo_Titulo_Invalido(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>() { CriaPlano(valor) };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, insira o Título do plano");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando o nome do plano é inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void Empresa_Plano_Validacao_Negativo_Nome_Invalido(string valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>() { CriaPlano("Padrão 4 Diárias", valor) };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, insira o Nome do plano");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false o valor do plano é menor ou igual a zero")]
        [Trait("Incluir", "Negativo")]
        [InlineData(0)]
        [InlineData(-1)]
        public void Empresa_Plano_Validacao_Negativo_Quando_Valor_MenorIgual_A_Zero(decimal valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>() { CriaPlano("Padrão 4 Diárias", "Padrao", valor) };

            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Valor do Plano 'Padrão 4 Diárias' deve ser maior que zero");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando o número de diárias é menor ou igual a zero")]
        [Trait("Incluir", "Negativo")]
        [InlineData(0)]
        [InlineData(-1)]
        public void Empresa_Plano_Validacao_Negativo_Quando_Diarias_MenorIgual_A_Zero(int valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>() { CriaPlano("Padrão 4 Diárias", "Padrao", 90, valor) };

            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Número de Diárias do Plano 'Padrão 4 Diárias' deve ser maior que zero");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false o valor do diária mínima é menor ou igual a zero")]
        [Trait("Incluir", "Negativo")]
        [InlineData(0)]
        [InlineData(-1)]
        public void Empresa_Plano_Validacao_Negativo_Quando_Valor_Diaria_Minima_MenorIgual_A_Zero(decimal valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>() { CriaPlano("Padrão 4 Diárias", "Padrao", 90, 4, valor) };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Valor de Diária Mínimo do Plano 'Padrão 4 Diárias' deve ser maior que zero");
        }

        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false o valor do diária máximo é menor ou igual a zero")]
        [Trait("Incluir", "Negativo")]
        [InlineData(0)]
        [InlineData(-1)]
        public void Empresa_Plano_Validacao_Negativo_Quando_Valor_Diaria_Maximo_MenorIgual_A_Zero(decimal valor)
        {
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>() { CriaPlano("Padrão 4 Diárias", "Padrao", 90, 4, 0.01m, valor) };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Valor de Diária Máximo do Plano 'Padrão 4 Diárias' deve ser maior que zero");
        }
        #endregion

        #region Billing
        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando o nome do forma de pagamento é inválida")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        public void Empresa_Billing_Validacao_Negativo_FormaPagamento_Invalida(string valor)
        {
            var billing = new Billing(valor, 1080, 20, 100, 60);
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>() { CriaPlano("Padrão 4 Diárias", "Padrao", 90, 4, 0.01m, 199, billing) };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, insira a Forma de Pagamento");
        }

        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando o valor total atual é menor que zero")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Billing_Validacao_Negativo_TotalAtual_Menor_Que_Zero()
        {
            var billing = new Billing("boleto", -1, 20, 100, 60);
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>() { CriaPlano("Padrão 4 Diárias", "Padrao", 90, 4, 0.01m, 199, billing) };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Valor Total Atual do Billing deve ser maior ou igual que zero");
        }


        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando o total de assinantes é menor que zero")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Billing_Validacao_Negativo_TotalAssinantes_Menor_Que_Zero()
        {
            var billing = new Billing("boleto", 1080.99m, -9, 100, 60);
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>() { CriaPlano("Padrão 4 Diárias", "Padrao", 90, 4, 0.01m, 199, billing) };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Total de Assinantes do Billing deve ser maior ou igual que zero");
        }


        [Theory(DisplayName = "Validação de uma nova empresa deve retornar false quando o total de assinantes é menor ou igual que zero")]
        [Trait("Incluir", "Negativo")]
        [InlineData(-1)]
        [InlineData(0)]
        public void Empresa_Billing_Validacao_Negativo_TotalColaboradores_MenorIgual_A_Zero(int valor)
        {
            var billing = new Billing("boleto", -1, 20, valor, 60);
            //Arrange
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>() { CriaPlano("Padrão 4 Diárias", "Padrao", 90, 4, 0.01m, 199, billing) };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "O Total de Colabores do Billing deve ser maior ou igual que zero");
        }


        [Fact(DisplayName = "Validação de uma nova empresa deve retornar false quando a coparticipação for menor que zero")]
        [Trait("Incluir", "Negativo")]
        public void Empresa_Billing_Validacao_Negativo_Coparticipacao_Menor_Que_Zero()
        {
            //Arrange
            var billing = new Billing("boleto", 1890, 20, 100, -10);
            var command = new CriarEmpresaCommand(
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
            );
            command = CompletaDadosCommand(command);
            command.Planos = new List<Plano>() { CriaPlano("Padrão 4 Diárias", "Padrao", 90, 4, 0.01m, 199, billing) };
            //Act
            var result = command.IsValid();
            //Assert
            result.Should().BeFalse();
            command.ValidationResult.Errors.Should().Contain(v => v.ErrorMessage == "A Coparticipação do Billing deve ser maior ou igual que zero");
        }
        #endregion

        private Plano CriaPlano(
            string titulo = "Padrão 4 Diárias",
            string nome = "Padrão",
            decimal valorPlano = 90,
            int diarias = 4,
            decimal valorDiariaMinima = 0.01m,
            decimal valorDiariaMaxima = 270,
            Billing billing = null,
            DateTime? dtVigencia = null,
            bool ativo = true,
            Guid? nid = null
            )
        {
            var id = new Guid("d127b728-f84b-4dc1-926a-924cd402e49e");
            if (nid.HasValue)
                id = nid.Value;
            if (dtVigencia == null)
                dtVigencia = Convert.ToDateTime("2020-07-31 23:59:59");
            if (billing == null)
                billing = _empresaEntity.Planos[0].Billing;
            Plano plano = new Plano(id, titulo, nome, valorPlano, diarias, valorDiariaMinima, valorDiariaMaxima, null, dtVigencia, ativo)
            {
                Billing = billing
            };
            return plano;
        }

        private CriarEmpresaCommand CompletaDadosCommand(CriarEmpresaCommand command)
        {
            command.Comercial = _empresaEntity.Comercial;
            command.Financeiro = _empresaEntity.Financeiro;
            command.Responsavel = _empresaEntity.Responsavel;
            command.Endereco = _empresaEntity.Endereco;
            command.Documentos = _empresaEntity.Documentos;
            command.Planos = _empresaEntity.Planos;
            return command;
        }

    }
}
