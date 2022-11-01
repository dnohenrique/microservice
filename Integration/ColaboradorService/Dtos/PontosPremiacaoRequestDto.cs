using System;
using System.Collections.Generic;
using System.Text;

namespace ColaboradorService.Dtos
{
   public class PontosPremiacaoRequestDto
    {
        public DateTime DataRegistro { get; set; }
        public DateTime DataPrevisaoEfetivacao { get; set; }
        public string EmpresaProprietariaId { get; set; }
        public List<string> Equipes { get; set; }
        public decimal QuantidadeInicial { get; set; }
        public decimal ValorPremio { get; set; }
        public string Origem { get; set; }
        public string Descricao { get; set; }
        public string CodigoReferenciaOrigem { get; set; }       
        public decimal ValorDinheiro { get; set; }    
        public DateTime? DataVencimento { get; set; }
    }
}
