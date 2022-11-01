using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Application.ViewModels
{
    public class EmpresaParametersViewModel : PaginacaoViewModel
    {
        [FromQuery(Name = "cnpj")]
        public string Cnpj { get; set; }

        [FromQuery(Name = "nomeFantasia")]
        public string NomeFantasia { get; set; }

        [FromQuery(Name = "razaoSocial")]
        public string RazaoSocial { get; set; }

        [FromQuery(Name = "segmento")]
        public string Segmento { get; set; }

        [FromQuery(Name = "site")]
        public string Site { get; set; }

        [FromQuery(Name = "tipo")]
        public string Tipo { get; set; }

        [FromQuery(Name = "empresaProprietariaId")]
        public string EmpresaProprietariaId { get; set; }

        [FromQuery(Name = "centroCusto")]
        public string CentroCusto { get; set; }

        [FromQuery(Name = "diaCobrancaInicio")]
        public int? DiaCobrancaInicio { get; set; }

        [FromQuery(Name = "diaCobrancaFim")]
        public int? DiaCobrancaFim { get; set; }

        [FromQuery(Name = "cobrancaAutomatica")]
        public bool? CobrancaAutomatica { get; set; }

        [FromQuery(Name = "cnpjsIn")]
        public string CnpjsIn { get; set; }

        [FromQuery(Name = "cnpjsOut")]
        public string CnpjsOut { get; set; }

        internal List<string> ValidarParametros()
        {
            var msgErros = new List<string>();

            if (!ValidarDiaCobranca())
                msgErros.Add("Intervalo de dias de cobrança inválido.");

            return msgErros;
        }
        private bool ValidarDiaCobranca()
        {
            if (!DiaCobrancaInicio.HasValue && !DiaCobrancaFim.HasValue)
                return true;

            if (!DiaCobrancaInicio.HasValue || !DiaCobrancaFim.HasValue)
                return false;

            if (DiaCobrancaFim.Value < DiaCobrancaInicio.Value)
                return false;

            if (DiaCobrancaInicio.Value < 1 || DiaCobrancaFim.Value < 1)
                return false;

            if (DiaCobrancaInicio.Value > 31 || DiaCobrancaFim.Value > 31)
                return false;

                return true;
        }
    }
}
