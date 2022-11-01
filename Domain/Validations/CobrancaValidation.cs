using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validations
{
    public class CobrancaValidation : AbstractValidator<Cobranca>
    {
        public CobrancaValidation()
        {
            RuleFor(c => c.EmailAlternativo)
                .Must(c => GenericValidation.ShouldBeLengthValidEmail(c, false))
                    .WithMessage("O Email comercial deve conter entre 6 e 50 caracteres")
                .Must(c => GenericValidation.ShouldBeEmailValid(c, false))
                    .WithMessage("Por favor, informar um Email comercial válido");

            RuleFor(c => c)
                .Must(ShouldBeValidInitialDay)
                .WithMessage("O Dia inicial é obrigatório quando ter fatura do mês fechado desabilitado, e o valor ser entre 1 à 28");

            RuleFor(c => c)
                .Must(ShouldBeValidFinalDay)
                .WithMessage("O Dia final é obrigatório quando ter fatura do mês fechado desabilitado, e o valor ser entre 1 à 28");
        }

        public static bool ShouldBeValidInitialDay(Cobranca c)
        {
            if (c.FaturarMesFechado)
            {
                return true;
            }
            return c.DiaInicial.HasValue && c.DiaInicial.Value > 1 && c.DiaInicial.Value < 29;
        }


        public static bool ShouldBeValidFinalDay(Cobranca c)
        {
            if (c.FaturarMesFechado)
            {
                return true;
            }
            return c.DiaInicial.HasValue && c.DiaFinal.Value == c.DiaInicial.Value - 1;
        }
    }
}
