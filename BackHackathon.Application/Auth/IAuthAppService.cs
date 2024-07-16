using BackHackathon.Application.Auth.Dtos;

namespace BackHackathon.Application.Auth;

public interface IAuthAppService
{
    Task<LoginResponseDto?> EfetuarLogin(LoginRequestDto requestDto);
}