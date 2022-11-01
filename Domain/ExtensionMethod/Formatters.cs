using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Domain.ExtensionMethod
{
    public static class Formatters
    {
        public static string RemoveSpecialCharacters(this string stringNormal)
        {
            if (stringNormal == null)
            {
                return null;
            }
            var stringFormatted = Regex.Replace(stringNormal, @"[^0-9a-zA-Z:,]+", "");

            return stringFormatted;
        }
        public static string FormatRemoveMask(this string value)
        {
            return value == null ? value : Regex.Replace(value, "[^0-9A-Za-z ]", "").Trim();
        }

        public static string FormatRemoveMaskAndDdi(this string value)
        {
            if (value == null)
            {
                return null;
            }
            var onlyDigit = value.FormatRemoveMask();
            var er = "^55(\\d{10,11})";
            return Regex.IsMatch(onlyDigit, er) ? Regex.Replace(onlyDigit, er, "$1") : onlyDigit;
        }

        public static string NormalizeSpecialCharsToDomain(this string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Trim().Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }

        public static string NormalizeSpecialCharsToAlias(this string text)
        {
            var domain = Regex.Replace(text.NormalizeSpecialCharsToDomain(), "[ ._]", "-");
            return Regex.Replace(domain, "[^0-9A-Za-z-]", "");
        }

        public static DateTime ToDateTime(this string value)
        {
            DateTime outDate;
            var parsed = DateTime.TryParse(value, CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat,
                DateTimeStyles.None, out outDate);
            if (!parsed)
            {
                throw new ArgumentException("Inválido argumento para converter Datetime");
            }
            return outDate;
        }

        public static string ToStingDateTime(this string value)
        {
            DateTime dataHora = Convert.ToDateTime(value);
            return dataHora.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
