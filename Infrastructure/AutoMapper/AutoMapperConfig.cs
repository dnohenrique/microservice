using AutoMapper;
using Infrastructure.AutoMapper.Mappings;

namespace Infrastructure.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EmpresaViewModelToEmpresaDomainMappingProfile());
                cfg.AddProfile(new EmpresaDomainToViewModelMappingProfile());
                cfg.AddProfile(new EmpresaCommandToEntityProfile());
            });
        }
    }
}
