using Domain.Enums;
using Domain.ExtensionMethod;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Domain.Validations
{
    public abstract class GenericValidation
    {
        public static bool IsNumericWithExactlyLength(string value, int length, bool required = true)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return !required;
            }
            var phone_match = "^[0-9]{" + length + "}$";
            Match match = Regex.Match(value, phone_match, RegexOptions.IgnoreCase);
            return match.Success;
        }

        public static bool ShouldLengthBeGreaterThan(string value, int min, bool required = true)
        {
            return ShouldBeBetweenRange(value, min, int.MaxValue, required);
        }

        public static bool ShouldBeLessThan(string value, int max, bool required = true)
        {
            return ShouldBeBetweenRange(value, 0, max, required);
        }

        public static bool ShouldBeBetweenRange(string value, int min, int max, bool required = true)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return !required;
            }
            return value.Length >= min && value.Length <= max;
        }

        public static bool ShouldBeValidName(string value, bool required = true)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return !required;
            }
            if (!ShouldBeBetweenRange(value, 3, 80, required))
            {
                return false;
            }
            return Regex.IsMatch(value, @"^[A-ZÀ-Ÿ][A-zÀ-ÿ']+\s([A-zÀ-ÿ']\s?)*[A-zÀ-ÿ']+$");
        }

        public static bool ShouldBeLengthValidEmail(string email)
        {
            return ShouldBeLengthValidEmail(email, false);
        }

        public static bool ShouldBeLengthValidEmail(string email, bool required = false)
        {
            if (string.IsNullOrEmpty(email))
            {
                return !required;
            }

            return email.Length >= 6 && email.Length <= 50;
        }

        public static bool ShouldBePhoneValid(string phone)
        {
            return ShouldHaveValidNumberRange(phone, 10, 11);
        }

        public static bool ShouldBeLandlinePhoneValid(string phone)
        {
            return ShouldHaveValidNumberLength(phone, 10);
        }

        public static bool ShouldBeCelPhoneValid(string phone)
        {
            return ShouldHaveValidNumberLength(phone, 11, false);
        }

        public static bool ShouldBeCepValid(string cep)
        {
            return ShouldHaveValidNumberLength(cep, 8);
        }

        public static bool ShouldHaveValidNumberRange(string value, int minLength, int maxLength, bool required = true)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return !required;
            }
            var phone_match = "^[0-9]{" + minLength + "," + maxLength + "}$";
            Match match = Regex.Match(value, phone_match, RegexOptions.IgnoreCase);
            return match.Success;
        }

        public static bool ShouldHaveValidNumberLength(string value, int length, bool required = true)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return !required;
            }
            var phone_match = "^[0-9]{" + length + "}$";
            Match match = Regex.Match(value, phone_match, RegexOptions.IgnoreCase);
            return match.Success;
        }

        public static bool ShouldBeEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$");
        }

        public static bool ShouldBeEmailValid(string email, bool required = false)
        {
            if (string.IsNullOrEmpty(email))
            {
                return !required;
            }

            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$");
        }

        public static bool ShouldHaveValidCountry(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }
            var phone_match = "^[A-Z]{2}$";
            Match match = Regex.Match(value, phone_match, RegexOptions.IgnoreCase);
            return match.Success;
        }

        public static bool ShouldHaveValidEmpresaProprietariaId(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj))
            {
                return true;
            }

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        public static bool ShouldHaveValidCnpj(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj))
            {
                return false;
            }

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        public static bool ShouldBeAliasValid(string alias)
        {
            if (string.IsNullOrWhiteSpace(alias))
            {
                return true;
            }
            var blacklist = new string[] { "api", "service" };
            return !blacklist.Contains(alias);
        }
    }
}
