using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Domain.Dto;
using Domain.Enums;
using Domain.Interfaces.Aws;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Domain.Aws
{
    public class PublicarEmpresaNoSns : IPublicarEmpresaNoSns
    {
        private readonly IAmazonSimpleNotificationService _amazonSimpleNotificationService;
        private readonly ISnsConfiguration _snsConfiguration;
        public PublicarEmpresaNoSns(IAmazonSimpleNotificationService amazonSimpleNotificationService,
                                     ISnsConfiguration snsConfiguration)
        {
            _amazonSimpleNotificationService = amazonSimpleNotificationService;
            _snsConfiguration = snsConfiguration;
        }

        public async Task EnviarEmpresaIdAsync(string identificadorFiscal)
        {
            await EnviarAsync(new PublicarEmpresaNoSnsDto(identificadorFiscal: identificadorFiscal, acaoHttp: AcaoHttp.POST));
        }

        public async Task AtualizarEmpresaIdAsync(string identificadorFiscal)
        {
            await EnviarAsync(new PublicarEmpresaNoSnsDto(identificadorFiscal: identificadorFiscal, acaoHttp: AcaoHttp.PUT));
        }

        private async Task EnviarAsync(PublicarEmpresaNoSnsDto publicarEmpresaNoSnsDto)
        {
            try
            {
                //TODO: Verificar se tem como informar verbo http na mesangem do SNS
                var jsonEnvioSns = JsonSerializer.Serialize(publicarEmpresaNoSnsDto);
                PublishRequest publishRequest = new PublishRequest(_snsConfiguration.GetArnTopico(), jsonEnvioSns);

                PublishResponse publishResponse = await _amazonSimpleNotificationService.PublishAsync(publishRequest);

                Console.WriteLine($"Envio SNS - SUCESSO INICIO ==== Acao: {publicarEmpresaNoSnsDto.AcaoHttp} empresaId {publicarEmpresaNoSnsDto.IdentificadorFiscal}");
                Console.WriteLine($"SUCESSO empresaId {publicarEmpresaNoSnsDto.IdentificadorFiscal} - MessageId: {publishResponse.MessageId}");
                Console.WriteLine($"Envio SNS - SUCESSO FIM ==== Acao: {publicarEmpresaNoSnsDto.AcaoHttp} empresaId {publicarEmpresaNoSnsDto.IdentificadorFiscal}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Envio SNS - ERRO INICIO ==== Acao: {publicarEmpresaNoSnsDto.AcaoHttp} empresaId {publicarEmpresaNoSnsDto.IdentificadorFiscal}");
                Console.WriteLine($"ERRO empresaId {publicarEmpresaNoSnsDto.IdentificadorFiscal} - ArnTopic: {_snsConfiguration.GetArnTopico()} ");
                Console.WriteLine($"ERRO empresaId {publicarEmpresaNoSnsDto.IdentificadorFiscal} - Excecao message: {ex.Message}");
                Console.WriteLine($"Envio SNS - ERRO FIM ==== Acao: {publicarEmpresaNoSnsDto.AcaoHttp} empresaId {publicarEmpresaNoSnsDto.IdentificadorFiscal}");
            }
        }
    }
}