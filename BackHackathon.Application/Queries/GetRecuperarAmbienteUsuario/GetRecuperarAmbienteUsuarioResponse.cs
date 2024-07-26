using BackHackathon.Domain.Dtos;

namespace BackHackathon.Application.Queries.GetRecuperarAmbienteUsuario;

public class GetRecuperarAmbienteUsuarioResponse : ApiBaseResponse<RecuperarAmbienteUsuarioDTO>
{
    public GetRecuperarAmbienteUsuarioResponse(ApiBaseResponse<RecuperarAmbienteUsuarioDTO> apiBaseResponse)
    {
        Content = apiBaseResponse.Content;
        Success = apiBaseResponse.Success;
        Message = apiBaseResponse.Message;
    }
}