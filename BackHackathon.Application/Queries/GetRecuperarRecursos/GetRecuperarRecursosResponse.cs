using BackHackathon.Application.DTOs;

namespace BackHackathon.Application.Queries.GetRecuperarRecursos;

public class GetRecuperarRecursosResponse: ApiBaseResponse<List<RecursoDTO>>
{
    public GetRecuperarRecursosResponse(ApiBaseResponse<List<RecursoDTO>> apiBaseResponse)
    {
        Content = apiBaseResponse.Content;
        Message = apiBaseResponse.Message;
        Success = apiBaseResponse.Success;
    }
}