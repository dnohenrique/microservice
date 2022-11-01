using ColaboradorService.Dtos;
using System.Threading.Tasks;

namespace ColaboradorService.Interfaces
{
    public interface IColaboradorServiceClient
    {
       public Task<PontosPremiacaoResponseDto> AtualizarPontosPremiacao(PontosPremiacaoRequestDto dto);
    }
}
