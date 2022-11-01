using Application.ViewModels;
using AutoMapper;
using Domain.Entities;

namespace Infrastructure.AutoMapper.Mappings
{
    public class EmpresaDomainToViewModelMappingProfile : Profile
    {
        public EmpresaDomainToViewModelMappingProfile()
        {
            CreateMap<Empresa, EmpresaGetViewModel>()
                .ForMember(f => f.Cobranca, opt => opt.MapFrom(src => src.Cobranca));
        }
    }
}
