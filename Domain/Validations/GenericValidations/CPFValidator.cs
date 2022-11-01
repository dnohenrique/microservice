using FluentValidation;
using System.Text.RegularExpressions;

namespace Domain.Validations.GenericValidations
{
    public class CPFValidator : AbstractValidator<string>
    {
        public CPFValidator()
        {
            //ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(c => c)
                .NotEmpty()
                    .WithMessage("Favor informar o cpf do colaborador")
                .NotNull()
                    .WithMessage("O CPF não pode ser nulo")
                .Must(IsCpf)
                    .WithMessage("Documento do tipo CPF deve ser válido");
        }


        private static bool IsCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                return false;
            }
            else
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;

                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");

                if (cpf.Length != 11)

                    return false;

                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

                resto = soma % 11;

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;

                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

                resto = soma % 11;

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();

                var patternCpfInvalid = new Regex("(0{11}|1{11}|2{11}|3{11}|4{11}|5{11}|6{11}|7{11}|8{11}|9{11})");

                if (patternCpfInvalid.IsMatch(cpf))
                    return false;

                return cpf.EndsWith(digito);
            }
        }
    }
}
