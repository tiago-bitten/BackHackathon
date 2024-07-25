using BackHackathon.Application.DTOs;

namespace BackHackathon.Application.Queries.GetRecuperarPermissoesUsuarioLogado;

public class GetRecuperarPermissoesUsuarioLogadoResponse<T> : ApiBaseResponse<List<T>> where T : PermissaoDTO
{
    public GetRecuperarPermissoesUsuarioLogadoResponse(ApiBaseResponse<List<PermissaoDTO>> apiBaseResponse)
    {
        Content = apiBaseResponse.Content as List<T>;
        Message = apiBaseResponse.Message;
        Success = apiBaseResponse.Success;
    }
}