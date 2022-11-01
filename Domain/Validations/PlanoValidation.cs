using Domain.Entities;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validations
{
    public class PlanoValidation : AbstractValidator<Plano>
    {
        protected override bool PreValidate(ValidationContext<Plano> context, ValidationResult result)
        {
            if (context.InstanceToValidate.Billing == null)
            {
                result.Errors.Add(new ValidationFailure("Billing", "Dados do Billing não informado"));
                return false;
            }
            return true;
        }

        public PlanoValidation()
        {
            RuleFor(c => c.Id)
                .Must(c => c.ToString() != "00000000-0000-0000-0000-000000000000")
                .WithMessage("Por favor, insira um Id do plano no formato Guid");

            RuleFor(c => c.Titulo)
                .NotNull().WithMessage("O Título do plano não pode ser nulo")
                .NotEmpty().WithMessage("Por favor, insira o Título do plano");

            RuleFor(c => c.TipoPlano)
                .NotNull().WithMessage("O Nome do plano não pode ser nulo")
                .NotEmpty().WithMessage("Por favor, insira o Nome do plano");

            RuleFor(c => c.ValorPlano)
                .GreaterThan(0)
                .WithMessage(c => $"O Valor do Plano '{c.Titulo}' deve ser maior que zero");

            RuleFor(c => c.Diarias)
                .GreaterThan(0)
                .WithMessage(c => $"O Número de Diárias do Plano '{c.Titulo}' deve ser maior que zero");

            RuleFor(c => c.ValorDiariaMinima)
                .GreaterThan(0)
                .WithMessage(c => $"O Valor de Diária Mínimo do Plano '{c.Titulo}' deve ser maior que zero");

            RuleFor(c => c.ValorDiariaMaxima)
                .GreaterThan(0)
                .WithMessage(c => $"O Valor de Diária Máximo do Plano '{c.Titulo}' deve ser maior que zero");

            ValidarBilling();
        }

        protected void ValidarBilling()
        {
            RuleFor(c => c.Billing)
                .SetValidator(new BillingValidation());
        }

        private bool ShouldBeBetweenRange(string value, int min, int max, bool required = true)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return !required;
            }
            return value.Length >= min && value.Length <= max;
        }

    }
}
