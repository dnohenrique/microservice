using Domain.Event;
using FluentValidation;
using FluentValidation.Results;

namespace Domain.Validations
{
    public abstract class EmpresaCobrancaEventValidation<T> : AbstractValidator<T> where T : EmpresaCobrancaEvent
    {
        protected override bool PreValidate(ValidationContext<T> context, ValidationResult result)
        {
            if (string.IsNullOrWhiteSpace(context.InstanceToValidate.CNPJ))
            {
                result.Errors.Add(new ValidationFailure("CNPJ", "Dados do CNPJ não informado"));
                return false;
            }

            return true;
        }

        #region Fluent Validations
        protected void ValidarEmail()
        {
            RuleFor(c => c)
                .Must(c => GenericValidation.ShouldBeLengthValidEmail(c.EmailAlternativo))
                .When(c => c != null && !string.IsNullOrWhiteSpace(c.EmailAlternativo))
                .WithMessage("O Email alternativo deve conter entre 6 e 50 caracteres");

            RuleFor(c => c)
                .Must(c => GenericValidation.ShouldBeEmailValid(c.EmailAlternativo))
                .When(c => c != null && !string.IsNullOrWhiteSpace(c.EmailAlternativo))
                .WithMessage("Por favor, informar um Email alternativo válido");
        }

        public void ValidarPeriodoPagamento()
        {
            RuleFor(c => c)
                .Must(ShouldBeValidInitialDay)
                .WithMessage("O Dia inicial é obrigatório quando ter fatura do mês fechado desabilitado, e o valor ser entre 1 à 28");

            RuleFor(c => c)
                .Must(ShouldBeValidFinalDay)
                .WithMessage("O Dia final é obrigatório quando ter fatura do mês fechado desabilitado, e o valor ser a data final -1");
        }

        public bool ShouldBeValidInitialDay(T c)
        {
            if (c.FaturarMesFechado)
            {
                return true;
            }
            return c.DiaInicial.HasValue && c.DiaInicial.Value > 1 && c.DiaInicial.Value < 29;
        }


        public bool ShouldBeValidFinalDay(T c)
        {
            if (c.FaturarMesFechado)
            {
                return true;
            }
            return c.DiaInicial.HasValue && c.DiaFinal.Value == c.DiaInicial.Value - 1;
        }

        #endregion
    }
}
