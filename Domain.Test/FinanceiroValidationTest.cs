using Domain.Entities;
using Domain.Validations;
using FluentAssertions;
using FluentValidation.Results;
using Xunit;

namespace Domain.Test
{
    public class FinanceiroValidationTest
    {
        private EmpresaFinanceiro _validator = new EmpresaFinanceiro()
        {
            Email = "contato@graficadozezinho.com",
            Contato = "João de O A Silva",
            Telefone = "1433423030",
            PrazoPagamento = 1,
            FormaPagamento = "Boleto",
            DiaPagamento = 1
        };

        [Fact(DisplayName = "Validação de uma nova email principal de financeiro deve retornar true")]
        [Trait("Incluir", "Positivo")]
        public void Test_Positivo_Quando_Email_Financeiro_Principal_Valido()
        {
            //Arrange
            FinanceiroValidation validator = new FinanceiroValidation();
            //Act
            ValidationResult result = validator.Validate(_validator);
            //Assert
            result.IsValid.Should().BeTrue();
        }

        [Theory(DisplayName = "Validação de uma nova email principal de financeiro deve retornar false quando o comprimento invalido")]
        [Trait("Incluir", "Negativo")]
        [InlineData("a@b.c")]
        [InlineData("another.brick.in.the.wall.partii@pinkfloydfullconcert.com.br")]
        public void Test_Negativo_Quando_Email_Financeiro_Principal_Tem_Comprimento_Invalido(string valor)
        {
            //Arrange
            _validator.Email = valor;
            FinanceiroValidation validator = new FinanceiroValidation();
            //Act
            ValidationResult result = validator.Validate(_validator);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(v => v.ErrorMessage == "O Email financeiro principal deverá conter entre 6 e 50 caracteres");
        }

        [Theory(DisplayName = "Validação de uma nova email principal de financeiro  deve retornar false quando email do responsavel é inválido")]
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
        public void Test_Negativo_Quando_Email_Financeiro_Principal_Invalido(string valor)
        {
            //Arrange
            _validator.Email = valor;
            FinanceiroValidation validator = new FinanceiroValidation();
            //Act
            ValidationResult result = validator.Validate(_validator);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, informar um Email financeiro principal válido");
        }

        [Fact(DisplayName = "Validação do prazo de pagamento inválido quando prazo de pagamento for negativo")]
        [Trait("Incluir", "Negativo")]
        public void Test_Positivo_Quando_PrazoPagamento_Menor_Que_Zero()
        {
            //Arrange
            _validator.PrazoPagamento = -1;
            FinanceiroValidation validator = new FinanceiroValidation();
            //Act
            ValidationResult result = validator.Validate(_validator);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(v => v.ErrorMessage == "Prazo de pagamento não pode ser negativo");
        }

        [Fact(DisplayName = "Validação do prazo de pagamento inválido quando prazo de pagamento exceder 4 dígitos")]
        [Trait("Incluir", "Negativo")]
        public void Test_Positivo_Quando_PrazoPagamento_Excede_Tres_Digitos()
        {
            //Arrange
            _validator.PrazoPagamento = 1000;
            FinanceiroValidation validator = new FinanceiroValidation();
            //Act
            ValidationResult result = validator.Validate(_validator);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(v => v.ErrorMessage == "Prazo de pagamento não pode exceder 3 dígitos");
        }

        [Theory(DisplayName = "Validação do prazo de pagamento inválido quando prazo de pagamento for negativo")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("oi")]
        [InlineData("cartão de crédito + picpay + mercado pago + paypal + boleto + dinheiro em espécie")]
        public void Test_Positivo_Quando_FormaPagamento_Fora_Do_Intervalo(string valor)
        {
            //Arrange
            _validator.FormaPagamento = valor;
            FinanceiroValidation validator = new FinanceiroValidation();
            //Act
            ValidationResult result = validator.Validate(_validator);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(v => v.ErrorMessage == "O Nome do contato financeiro deverá ter entre 3 e 20 caracteres");
        }

        [Theory(DisplayName = "Validação do prazo de pagamento inválido quando prazo de pagamento for negativo")]
        [Trait("Incluir", "Negativo")]
        [InlineData(0)]
        [InlineData(29)]
        [InlineData(30)]
        [InlineData(31)]
        [InlineData(32)]
        public void Test_Negativo_Quando_DiaPagamento_Fora_Do_Intervalo(int valor)
        {
            //Arrange
            _validator.DiaPagamento = valor;
            FinanceiroValidation validator = new FinanceiroValidation();
            //Act
            ValidationResult result = validator.Validate(_validator);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(v => v.ErrorMessage == "Dia de pagamento deve ser entre 1 à 28");
        }

        [Theory(DisplayName = "Validação do prazo de pagamento inválido quando nome do contato for negativo")]
        [Trait("Incluir", "Negativo")]
        [InlineData("oi")]
        [InlineData("Pedro de Alcântara Francisco Antônio João Carlos Xavier de Paula Miguel Rafael Joaquim José Gonzaga Pascoal Cipriano Serafim de Bragança e Bourbon")]
        [InlineData("Dom Pedro 1")]
        [InlineData("Juliane")]
        [InlineData("Alexandre de O. A. Cintra")]
        [InlineData("alexandre@ferias.co")]
        public void Test_Negativo_Quando_Contato_Invalido(string valor)
        {
            //Arrange
            _validator.Contato = valor;
            FinanceiroValidation validator = new FinanceiroValidation();
            //Act
            ValidationResult result = validator.Validate(_validator);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(v => v.ErrorMessage == "O Nome do contato financeiro deverá ter entre 3 e 80 caracteres");
        }

        [Theory(DisplayName = "Validação do prazo de pagamento válido quando nome do contato não preenchido")]
        [Trait("Incluir", "Positivo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("  ")]
        public void Test_Positivo_Quando_Nao_Preenchido(string valor)
        {
            //Arrange
            _validator.Contato = valor;
            FinanceiroValidation validator = new FinanceiroValidation();
            //Act
            ValidationResult result = validator.Validate(_validator);
            //Assert
            result.IsValid.Should().BeTrue();
        }

        [Theory(DisplayName = "Validação do telefone do financeiro inválido")]
        [Trait("Incluir", "Negativo")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("    ")]
        [InlineData("143342123")]
        [InlineData("143342123456")]
        [InlineData("abc")]
        public void Test_Negativo_Quando_Telefone_Invalido(string valor)
        {
            //Arrange
            _validator.Telefone = valor;
            FinanceiroValidation validator = new FinanceiroValidation();
            //Act
            ValidationResult result = validator.Validate(_validator);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(v => v.ErrorMessage == "Por favor, informar um número de Telefone do financeiro válido");
        }
    }
}
