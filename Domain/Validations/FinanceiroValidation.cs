using Domain.Entities;
using FluentValidation;

namespace Domain.Validations
{
    public class FinanceiroValidation : AbstractValidator<EmpresaFinanceiro>
    {
        public FinanceiroValidation()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                    .WithMessage("O Email financeiro principal deverá ser informado")
                .NotNull()
                    .WithMessage("O Email financeiro principal não pode ser null")
                .Must(GenericValidation.ShouldBeLengthValidEmail)
                    .WithMessage("O Email financeiro principal deverá conter entre 6 e 50 caracteres")
                .Must(GenericValidation.ShouldBeEmailValid)
                    .WithMessage("Por favor, informar um Email financeiro principal válido");

            RuleFor(c => c.PrazoPagamento)
                .GreaterThan(-1)
                .WithMessage("Prazo de pagamento não pode ser negativo")
                .LessThan(1000)
                .WithMessage("Prazo de pagamento não pode exceder 3 dígitos");

            RuleFor(c => c.FormaPagamento)
                .NotNull()
                    .WithMessage("A forma de pagamento não pode ser nulo")
                .NotEmpty()
                    .WithMessage("Por favor, informar a forma de pagamento")
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 3, 20))
                    .WithMessage("O Nome do contato financeiro deverá ter entre 3 e 20 caracteres");

            RuleFor(c => c.DiaPagamento)
                .GreaterThan(0)
                .WithMessage("Dia de pagamento deve ser entre 1 à 28")
                .LessThan(29)
                .WithMessage("Dia de pagamento deve ser entre 1 à 28");

            RuleFor(c => c.Contato)
                .Must(c => GenericValidation.ShouldBeValidName(c, false))
                    .WithMessage("O Nome do contato financeiro deverá ter entre 3 e 80 caracteres");

            RuleFor(c => c.Telefone)
                .NotEmpty()
                    .WithMessage("Por favor, informar o Telefone financeiro")
                .NotNull()
                    .WithMessage("O Telefone financeiro não pode ser nulo")
                .Must(GenericValidation.ShouldBePhoneValid)
                    .WithMessage("Por favor, informar um número de Telefone do financeiro válido");

        }
    }
}
