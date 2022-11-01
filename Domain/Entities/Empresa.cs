using Domain.Enums;
using Domain.ExtensionMethod;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    [BsonIgnoreExtraElements]
    public class Empresa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }

        [BsonElement("id")]
        public string Id { get; private set; }

        [BsonElement("nomeFantasia")]
        public string NomeFantasia { get; private set; }

        [BsonElement("razaoSocial")]
        public string RazaoSocial { get; private set; }

        [BsonElement("segmento")]
        public string Segmento { get; private set; }

        [BsonElement("site")]
        public string Site { get; private set; }

        [BsonElement("tipo")]
        public string Tipo { get; private set; }

        [BsonElement("empresaProprietariaId")]
        public string EmpresaProprietariaId { get; private set; }

        [BsonElement("centroCusto")]
        public string CentroCusto { get; private set; }

        [BsonElement("gruposOrganizacionais")]
        public string[] GruposOrganizacionais { get; private set; }

        [BsonElement("documentos")]
        public List<Documento> Documentos { get; private set; }

        [BsonElement("responsavel")]
        public Responsavel Responsavel { get; private set; }

        [BsonElement("endereco")]
        public Endereco Endereco { get; private set; }

        [BsonElement("cobranca")]
        public Cobranca Cobranca { get; set; }

        [BsonElement("financeiro")]
        public EmpresaFinanceiro Financeiro { get; set; }

        [BsonElement("comercial")]
        public EmpresaComercial Comercial { get; set; }

        [BsonElement("planos")]
        public List<Plano> Planos { get; private set; }

        [BsonElement("ativo")]
        public bool Ativo { get; private set; }

        [BsonElement("dataCriacao")]
        public DateTime DataCriacao { get; private set; }

        [BsonElement("dataAtualizacao")]
        public DateTime? DataAtualizacao { get; set; }

        [BsonElement("dataDelecao")]
        public DateTime? DataDelecao { get; set; }

        [BsonElement("alias")]
        public string Alias { get; private set; }

        [BsonElement("statusFinanceiro")]
        public string StatusFinanceiro { get; private set; }

        [BsonElement("tipoOferta")]
        public TipoOfertaEnum TipoOferta { get; set; }
        public Empresa
        (
            string nomeFantasia,
            string razaoSocial,
            string segmento,
            string site,
            string tipo,
            string empresaProprietariaId,
            string centroCusto,
            string[] gruposOrganizacionais,
            List<Documento> documentos,
            Endereco endereco,
            Responsavel responsavel,
            List<Plano> planos,
            bool ativo,
            DateTime dataCriacao,
            EmpresaFinanceiro financeiro,
            EmpresaComercial comercial,
            string alias = null,
            Cobranca cobranca = null,
            string statusFinanceiro = null,
            TipoOfertaEnum tipoOferta = TipoOfertaEnum.ContasEPlanos
        )
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Segmento = segmento;
            Site = site;
            Tipo = tipo;
            EmpresaProprietariaId = empresaProprietariaId;
            CentroCusto = centroCusto;
            GruposOrganizacionais = gruposOrganizacionais;
            Documentos = documentos;
            Endereco = endereco;
            Responsavel = responsavel;
            Planos = planos;
            Ativo = ativo;
            DataCriacao = dataCriacao;
            Financeiro = financeiro;
            Comercial = comercial;
            Alias = alias;
            Id = GenerateId(Documentos);
            Cobranca = cobranca;
            StatusFinanceiro = statusFinanceiro;
            TipoOferta = tipoOferta;
        }

        public Empresa(
            string id,
            string nomeFantasia,
            string razaoSocial,
            string segmento,
            string site,
            string tipo,
            string empresaProprietariaId,
            string centroCusto,
            string[] gruposOrganizacionais,
            List<Documento> documentos,
            Endereco endereco,
            //List<Responsavel> responsavel,
            Responsavel responsavel,
            List<Plano> planos,
            bool ativo,
            DateTime dataAtualizacao,
            EmpresaFinanceiro financeiro,
            EmpresaComercial comercial,
            string alias = null,
            string statusFinanceiro = null,
            TipoOfertaEnum tipoOferta = TipoOfertaEnum.ContasEPlanos
            )
        {
            Id = id;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Segmento = segmento;
            Site = site;
            Tipo = tipo;
            EmpresaProprietariaId = empresaProprietariaId;
            CentroCusto = centroCusto;
            GruposOrganizacionais = gruposOrganizacionais;
            Documentos = documentos;
            Endereco = endereco;
            Responsavel = responsavel;
            Planos = planos;
            Ativo = ativo;
            DataAtualizacao = dataAtualizacao;
            Financeiro = financeiro;
            Comercial = comercial;
            Alias = alias;
            StatusFinanceiro = statusFinanceiro;
            TipoOferta = tipoOferta;
        }

        public static string GetAlias(string nome, string alias = null)
        {
            if (string.IsNullOrEmpty(alias))
            {
                alias = nome?.Split(' ')[0];
            }
            return alias?.ToLower().NormalizeSpecialCharsToAlias();
        }

        private string GenerateId(List<Documento> documentos)
        {
            Id = documentos.Any() ? documentos.Find(x => x.Tipo == "CNPJ").Numero : Id;

            return Id;
        }

        #region B2B/B2C
        [BsonElement("carteira")]
        public Carteira Carteira { get; set; }
        #endregion


        #region Acessors/Modifiers
        public virtual List<Credito> CreditosValidos
        {
            get
            {
                var dataAtual = DateTime.UtcNow;
                return Carteira.Creditos.Where(x =>
                                                   x.ValidadeEfetiva.Date >= dataAtual.Date &&
                                                   x.QuantidadeRestante > 0)
                                                    .OrderBy(d => d.ValidadeEfetiva).ToList();
            }
        }

        public void AtualizarSaldoCarteira(decimal valor)
        {
            Carteira.Saldo -= valor;
            Carteira.DataUltimaAtualizacao = DateTime.UtcNow;
        }

        public void AtualizarQuantidadeRestanteCredito(Credito atualizado)
        {
            Carteira.Creditos.Where(x => x.Id == atualizado.Id).First().QuantidadeRestante = atualizado.QuantidadeRestante;
        }

        public void AdicionarTransacaoHistorico(Transacao transacao)
        {
            Carteira.Historico.Add(transacao);
        }
        #endregion


    }
}
