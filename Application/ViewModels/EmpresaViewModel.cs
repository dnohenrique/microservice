using Domain.Enums;
using System.Collections.Generic;

namespace Application.ViewModels
{
    public abstract class EmpresaViewModel
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Alias { get; set; }
        public string Segmento { get; set; }
        public string Site { get; set; }
        public string Tipo { get; set; }
        public string EmpresaProprietariaId { get; set; }
        public string CentroCusto { get; set; }
        public string[] GruposOrganizacionais { get; set; }
        public List<EmpresaDocumentoViewModel> Documentos { get; set; }
        public EmpresaResponsavelViewModel Responsavel { get; set; }
        public EmpresaEnderecoViewModel Endereco { get; set; }
        public EmpresaFinanceiroViewModel Financeiro { get; set; }
        public EmpresaComercialViewModel Comercial { get; set; }
        public EmpresaCobrancaViewModel Cobranca { get; set; }
        public List<EmpresaPlanoViewModel> Planos { get; set; }
        public EmpresaCarteiraViewModel Carteira { get; set; }
        public bool Ativo { get; set; }
        public string StatusFinanceiro { get; set; }
        public TipoOfertaEnum TipoOferta { get; set; }
    }
}
