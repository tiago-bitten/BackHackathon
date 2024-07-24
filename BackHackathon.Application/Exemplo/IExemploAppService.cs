using BackHackathon.Application.Exemplo.Dtos;
using BackHackathon.Domain;

namespace BackHackathon.Application.Exemplo;

public interface IExemploAppService
{
    Task<ApiBaseResponse<AmbienteUsuarioContent>?> RecuperarAmbienteUsuario(AmbienteUsuarioRequestDto requestDtoDto);
    Task<ApiBaseResponse<EnumsContent>?> RecuperarEnums(EnumsRequestDto requestDto);
}