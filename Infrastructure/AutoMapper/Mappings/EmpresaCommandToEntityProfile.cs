using AutoMapper;
using Domain.Command;
using Domain.Entities;
using System;

namespace Infrastructure.AutoMapper.Mappings
{
    public class EmpresaCommandToEntityProfile : Profile
    {
        public EmpresaCommandToEntityProfile()
        {
            CreateMap<CriarEmpresaCommand, Empresa>()
                .ConstructUsing(e => new Empresa(
                                e.NomeFantasia,
                                e.RazaoSocial,
                                e.Segmento,
                                e.Site,
                                e.Tipo,
                                e.EmpresaProprietariaId,
                                e.CentroCusto,
                                e.GrupoOrganizacionais,
                                e.Documentos,
                                e.Endereco,
                                e.Responsavel,
                                e.Planos,
                                e.Ativo,
                                DateTime.UtcNow,
                                e.Financeiro,
                                e.Comercial,
                                e.Alias,
                                null,
                                e.StatusFinanceiro,
                                e.TipoOferta
                    ));

            CreateMap<Empresa, CriarEmpresaCommand>()
                .ConstructUsing(e => new CriarEmpresaCommand(
                                e.NomeFantasia,
                                e.RazaoSocial,
                                e.Segmento,
                                e.Site,
                                e.Tipo,
                                e.EmpresaProprietariaId,
                                e.CentroCusto,
                                e.GruposOrganizacionais,
                                e.Ativo,
                                e.Alias,
                                e.StatusFinanceiro
                    ))
                .ForMember(dest => dest.Planos, opt => opt.MapFrom(src => src.Planos.ConvertAll(x => new Plano(
                        x.Id,
                        x.Titulo,
                        x.TipoPlano,
                        x.ValorPlano,
                        x.Diarias,
                        x.ValorDiariaMinima,
                        x.ValorDiariaMaxima,
                        new Billing(
                            x.Billing.FormaPagamento,
                            x.Billing.ValorTotalAtual,
                            x.Billing.TotalAssinantes,
                            x.Billing.TotalColaboradores,
                            x.Billing.Coparticipacao),
                        x.Vigencia,
                        true
                    ))))
                .ForMember(dest => dest.Documentos, opt => opt.MapFrom(src => src.Documentos.ConvertAll(x => new Documento(
                        x.Tipo,
                        x.Numero
                    ))));

        }
    }
}
