using BackHackathon.Domain.Dtos;

namespace BackHackathon.Application.Queries.GetRecuperarAmbienteUsuario;

public class GetRecuperarAmbienteUsuarioResponse<T> : ApiBaseResponse<T> where T : RecuperarAmbienteUsuarioDTO
{
    public GetRecuperarAmbienteUsuarioResponse(ApiBaseResponse<RecuperarAmbienteUsuarioDTO> apiBaseResponse)
    {
        Success = apiBaseResponse.Success;
        Content = apiBaseResponse.Content as T;
        Message = apiBaseResponse.Message;
    }
}