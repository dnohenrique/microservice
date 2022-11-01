using Domain.Interfaces.Aws;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Configuration
{
    public class SnsConfiguration : ISnsConfiguration
    {
        public IConfiguration Configuration;
        public SnsConfiguration(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public string GetArnTopico()
        {
            return Configuration.GetSection("SnsConfiguration:ArnTopico").Value;
        }
    }
}