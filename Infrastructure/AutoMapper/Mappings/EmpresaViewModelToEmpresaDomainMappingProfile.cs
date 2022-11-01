using Application.ViewModels;
using AutoMapper;
using Domain.Command;
using Domain.Entities;
using Domain.Event;

namespace Infrastructure.AutoMapper.Mappings
{
    public class EmpresaViewModelToEmpresaDomainMappingProfile : Profile
    {
        public EmpresaViewModelToEmpresaDomainMappingProfile()
        {
            CreateMap<EmpresaPostViewModel, CriarEmpresaCommand>()
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
                    )
                {
                    Billing = new Billing(
                            x.Billing.FormaPagamento,
                            x.Billing.ValorTotalAtual,
                            x.Billing.TotalAssinantes,
                            x.Billing.TotalColaboradores,
                            x.Billing.Coparticipacao
                            )
                }
                )))
                .ForMember(dest => dest.Documentos, opt => opt.MapFrom(src => src.Documentos.ConvertAll(x => new Documento(
                        x.Tipo,
                        x.Numero
                    ))))
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco))
                .ForMember(dest => dest.Responsavel, opt => opt.MapFrom(src => src.Responsavel))
                .ForMember(dest => dest.Financeiro, opt => opt.MapFrom(src => src.Financeiro))
                .ForMember(dest => dest.Comercial, opt => opt.MapFrom(src => src.Comercial));

            CreateMap<EmpresaResponsavelViewModel, Responsavel>().ReverseMap();
            CreateMap<EmpresaEnderecoViewModel, Endereco>().ReverseMap();
            CreateMap<EmpresaFinanceiroViewModel, EmpresaFinanceiro>().ReverseMap();
            CreateMap<EmpresaComercialViewModel, EmpresaComercial>().ReverseMap();
            CreateMap<EmpresaCobrancaViewModel, Cobranca>().ReverseMap();
            CreateMap<EmpresaCobrancaPutViewModel, AtualizarEmpresaCobrancaEvent>();
            CreateMap<EmpresaStatusFinanceiroPutViewModel, AtualizarEmpresaStatusFinanceiroEvent>();
            CreateMap<EmpresaPlanoViewModel, Plano>().ReverseMap();
            CreateMap<EmpresaPlanoBillingViewModel, Billing>().ReverseMap();
            CreateMap<EmpresaDocumentoViewModel, Documento>().ReverseMap();
            // Creditos
            CreateMap<EmpresaCarteiraViewModel, Carteira>().ReverseMap();
            CreateMap<EmpresaCreditoViewModel, Credito>().ReverseMap();

            CreateMap<EmpresaPutViewModel, AtualizarEmpresaEvent>()
                .ConstructUsing(e => new AtualizarEmpresaEvent(
                                e.Id,
                                e.NomeFantasia,
                                e.RazaoSocial,
                                e.Segmento,
                                e.Site,
                                e.Tipo,
                                e.EmpresaProprietariaId,
                                e.CentroCusto,
                                e.Coparticipacao,
                                e.GruposOrganizacionais,
                                e.Ativo,
                                e.ValorMaximoPlano,
                                e.Alias,
                                e.StatusFinanceiro,
                                e.TipoOferta
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
