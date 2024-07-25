using BackHackathon.Application.DTOs;

namespace BackHackathon.Application.Queries.GetRecuperarRecursos;

public class GetRecuperarRecursosResponse<T> : ApiBaseResponse<List<T>> where T : RecursoDTO
{
    public GetRecuperarRecursosResponse(ApiBaseResponse<List<RecursoDTO>> apiBaseResponse)
    {
        Content = apiBaseResponse.Content as List<T>;
        Message = apiBaseResponse.Message;
        Success = apiBaseResponse.Success;
    }
}