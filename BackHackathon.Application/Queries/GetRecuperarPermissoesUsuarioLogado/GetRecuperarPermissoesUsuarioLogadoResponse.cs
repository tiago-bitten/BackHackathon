using BackHackathon.Application.DTOs;

namespace BackHackathon.Application.Queries.GetRecuperarPermissoesUsuarioLogado;

public class GetRecuperarPermissoesUsuarioLogadoResponse : ApiBaseResponse<List<PermissaoDTO>> 
{
    public GetRecuperarPermissoesUsuarioLogadoResponse(ApiBaseResponse<List<PermissaoDTO>> apiBaseResponse)
    {
        Content = apiBaseResponse.Content;
        Message = apiBaseResponse.Message;
        Success = apiBaseResponse.Success;
    }
}