using System;
using System.Globalization;

namespace Domain.Validations.GenericValidations
{
    public static class DateTimeValidator
    {
        public static bool IsDateTime(string data)
        {
            return GetDateTime(data) != null;
        }

        public static bool ShouldBeGreaterThan18(string dataNascimento)
        {
            var tempDate = GetDateTime(dataNascimento);
            if (!tempDate.HasValue)
            {
                return false;
            }
            return (tempDate.Value.AddYears(18).Date < DateTime.UtcNow.Date);
        }

        private static DateTime? GetDateTime(string data)
        {
            DateTime tempDate;
            if (!DateTime.TryParse(data,
                                   CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat,
                                   DateTimeStyles.None,
                                   out tempDate)
               )
            {
                return null;
            }
            return tempDate;
        }

    }
}
