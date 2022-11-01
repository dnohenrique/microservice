using Domain.Enums;
using Domain.Event;
using Domain.ExtensionMethod;
using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Domain.Validations
{
    public abstract class EmpresaStatusFinanceiroEventValidation<T> : AbstractValidator<T> where T : EmpresaStatusFinanceiroEvent
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
        protected void ValidarStatusFinanceiro()
        {
            var validList = EnumExtension.GetEnumDescriptions<StatusFinanceiroEnum>();

            RuleFor(c => c)
                .Must(c => ShouldBeStatusFinanceiroValid(c.StatusFinanceiro, validList))
                .WithMessage($"O Status Financeiro deve ser {string.Join(", ", validList)}");
        }

        private static bool ShouldBeStatusFinanceiroValid(string statusFinanceiro, IEnumerable<string> validList)
        {
            if (string.IsNullOrWhiteSpace(statusFinanceiro))
            {
                return true;
            }

            return validList.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(statusFinanceiro.ToLower()));
        }
        #endregion
    }
}
