using BackHackathon.Application.Exemplo.Dtos;

namespace BackHackathon.Application.Exemplo;

public interface IExemploAppService
{
    Task<AmbienteUsuarioResponseDto?> RecuperarAmbienteUsuario(AmbienteUsuarioRequestDto requestDtoDto);
    Task<EnumsResponseDto?> RecuperarEnums(EnumsRequestDto requestDto);
}