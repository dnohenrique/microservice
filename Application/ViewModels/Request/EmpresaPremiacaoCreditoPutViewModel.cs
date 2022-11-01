using System;
using System.Collections.Generic;

namespace Application.ViewModels
{
    public class EmpresaPremiacaoCreditoPutViewModel
    {
        /// <summary>
        /// CPF/CNPJ do responsavel
        /// </summary>
        public string Responsavel { get; set; }

        /// <summary>
        /// Valor monetario da premiacao
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// CPFs dos premiados
        /// </summary>
        public List<EmpresaPremiacaoTransacaoViewModel> Transacoes { get; set; }

        public EmpresaPremiacaoCreditoPutViewModel() { Transacoes = new List<EmpresaPremiacaoTransacaoViewModel>(); }


    }
}
