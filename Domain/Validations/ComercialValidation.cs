using Domain.Entities;
using FluentValidation;

namespace Domain.Validations
{
    public class ComercialValidation : AbstractValidator<EmpresaComercial>
    {
        public ComercialValidation()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                    .WithMessage("O Email comercial deverá ser informado")
                .NotNull()
                    .WithMessage("O Email comercial não pode ser null")
                .Must(GenericValidation.ShouldBeLengthValidEmail)
                    .WithMessage("O Email comercial deve conter entre 6 e 50 caracteres")
                .Must(GenericValidation.ShouldBeEmailValid)
                    .WithMessage("Por favor, informar um Email comercial válido");

            RuleFor(c => c.Contato)
                .Must(c => GenericValidation.ShouldBeValidName(c, false))
                    .WithMessage("O Nome do contato comercial deve ter pelo menos um sobrenome, contendo somente letras deverá ter entre 3 e 80 caracteres");

            RuleFor(c => c.Telefone)
                .NotEmpty()
                    .WithMessage("Por favor, informar o Telefone comercial")
                .NotNull()
                    .WithMessage("O Telefone comercial não pode ser nulo")
                .Must(GenericValidation.ShouldBePhoneValid)
                    .WithMessage("Por favor, informar um número de Telefone comercial válido");
        }
    }
}
