using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validations
{
    public class BillingValidation : AbstractValidator<Billing>
    {
        public BillingValidation()
        {
            RuleFor(c => c.FormaPagamento)
                .NotNull().WithMessage("A Forma de Pagamento não pode ser nula")
                .NotEmpty().WithMessage("Por favor, insira a Forma de Pagamento");

            RuleFor(c => c.ValorTotalAtual)
                .GreaterThanOrEqualTo(0)
                .WithMessage("O Valor Total Atual do Billing deve ser maior ou igual que zero");

            RuleFor(c => c.TotalAssinantes)
                .GreaterThanOrEqualTo(0)
                .WithMessage("O Total de Assinantes do Billing deve ser maior ou igual que zero");

            RuleFor(c => c.TotalColaboradores)
                .GreaterThan(0)
                .WithMessage("O Total de Colabores do Billing deve ser maior ou igual que zero");

            RuleFor(c => c.Coparticipacao)
                .GreaterThanOrEqualTo(0)
                .WithMessage("A Coparticipação do Billing deve ser maior ou igual que zero");
        }
    }
}
