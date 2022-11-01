using Domain.Entities;
using FluentValidation;

namespace Domain.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            RuleFor(c => c.Logradouro)
                .NotEmpty()
                    .WithMessage("Por favor, informar o Logradouro")
                .NotNull()
                    .WithMessage("O logradouro não pode ser nulo")
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 3, 100))
                    .WithMessage("O Logradouro deverá conter entre 3 e 100 caracteres");

            RuleFor(c => c.Numero)
                .NotEmpty()
                    .WithMessage("Por favor, informar o Número do endereço")
                .NotNull()
                    .WithMessage("O Número do endereço não pode ser nulo")
                .Must(c => GenericValidation.ShouldBeLessThan(c, 10))
                    .WithMessage("O Número do endereço deverá conter até 10 caracteres");

            RuleFor(c => c.Complemento)
                .Must(c => GenericValidation.ShouldBeLessThan(c, 40, false))
                    .WithMessage("O Complemento do endereço deverá conter até 40 caracteres");

            RuleFor(c => c.Bairro)
                .NotEmpty()
                    .WithMessage("Por favor, informar o Bairro")
                .NotNull()
                    .WithMessage("O Bairro não pode ser nulo")
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 3, 100))
                    .WithMessage("O Bairro deverá conter entre 3 e 100 caracteres");

            RuleFor(c => c.Cidade)
                .NotEmpty()
                    .WithMessage("Por favor, informar a Cidade")
                .NotNull()
                    .WithMessage("A Cidade não pode ser nulo")
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 3, 60))
                    .WithMessage("A Cidade deverá conter entre 3 e 60 caracteres");

            RuleFor(c => c.Estado)
                .NotEmpty()
                    .WithMessage("Por favor, informar o Estado")
                .NotNull()
                    .WithMessage("O Estado não pode ser nulo")
                .Must(c => GenericValidation.ShouldBeBetweenRange(c, 2, 20))
                    .WithMessage("O Estado deverá conter entre 2 e 20 caracteres");

            RuleFor(c => c.Cep)
                .NotEmpty()
                    .WithMessage("Por favor, informar o CEP")
                .NotNull()
                    .WithMessage("O CEP não pode ser nulo")
                .Must(GenericValidation.ShouldBeCepValid)
                    .WithMessage("Por favor, informar um CEP válido");

            RuleFor(c => c.Pais)
                .Must(GenericValidation.ShouldHaveValidCountry)
                    .WithMessage("Por favor, informar a sigla do País");
        }
    }
}
