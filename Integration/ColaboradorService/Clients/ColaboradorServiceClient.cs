using ColaboradorService.Configurations;
using ColaboradorService.Dtos;
using ColaboradorService.Extensions;
using ColaboradorService.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ColaboradorService.Clients
{
    public class ColaboradorServiceClient : IColaboradorServiceClient
    {
        private readonly ILogger<ColaboradorServiceClient> _logger;
        private ColaboradorServiceConfiguration _configuration;
        private readonly IHttpClientFactory _clientFactory;

        public ColaboradorServiceClient(IOptions<ColaboradorServiceConfiguration> options, ILogger<ColaboradorServiceClient> logger, IHttpClientFactory clientFactory)
        {
            _configuration = options?.Value ?? throw new ArgumentNullException(nameof(options));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            _clientFactory = clientFactory;
        }

        public async Task<PontosPremiacaoResponseDto> AtualizarPontosPremiacao(PontosPremiacaoRequestDto dto)
        {
            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"Bearer {_configuration.Token}");

            PontosPremiacaoResponseDto result = new PontosPremiacaoResponseDto();
            try
            {
                result = await client.PostAsJsonAsync<PontosPremiacaoResponseDto, PontosPremiacaoRequestDto>(_configuration.AtualizarPontosPremiacaoUrl, dto);
            }
            catch (Exception ex)
            {
                var obj = JsonConvert.SerializeObject(dto);

                _logger.LogError(obj, ex);
            }
            return result;
        }
    }
}
