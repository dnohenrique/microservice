using System;
using System.ComponentModel;
using System.Reflection;
using System.Text.Json.Serialization;
using Domain.Enums;

namespace Domain.Dto
{
    public class PublicarEmpresaNoSnsDto
    {
        [JsonPropertyName("identificadorFiscal")]
        public string IdentificadorFiscal { get; set; }
        [JsonIgnore]
        public AcaoHttp AcaoHttp { get; set; }
        [JsonPropertyName("acaoHttp")]
        public string AcaoDescription => AcaoHttp.GetEnumDescription();
        public PublicarEmpresaNoSnsDto(string identificadorFiscal, AcaoHttp acaoHttp)
        {
            IdentificadorFiscal = identificadorFiscal;
            AcaoHttp = acaoHttp;
        }
    }

    public static class Enums
    {
        public static string GetEnumDescription(this Enum value)
        {
            // Get the Description attribute value for the enum value
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}