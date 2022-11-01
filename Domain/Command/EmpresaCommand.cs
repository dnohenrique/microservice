using Domain.Entities;
using Domain.Enums;
using System.Collections.Generic;

namespace Domain.Command
{
    public abstract class EmpresaCommand<T> : CommandBase<T>
    {
        public string NomeFantasia { get; protected set; }
        public string RazaoSocial { get; set; }
        public string Segmento { get; set; }
        public string Site { get; set; }
        public string Tipo { get; set; }
        public string EmpresaProprietariaId { get; set; }
        public string CentroCusto { get; set; }
        public string[] GrupoOrganizacionais { get; set; }
        public List<Documento> Documentos { get; set; }
        public Responsavel Responsavel { get; set; }
        public Endereco Endereco { get; set; }
        public EmpresaFinanceiro Financeiro { get; set; }
        public EmpresaComercial Comercial { get; set; }
        public List<Plano> Planos { get; set; }
        public bool Ativo { get; set; }
        public string Alias { get; set; }
        public string StatusFinanceiro { get; set; }
        public TipoOfertaEnum TipoOferta { get; set; }
    }
}
