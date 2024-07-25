using BackHackathon.Application.Dtos;

namespace BackHackathon.Application.Queries.GetRecuperarEnums;

public class GetRecuperarEnumsResponse<T> : ApiBaseResponse<T> where T : EnumsDTO
{
    public GetRecuperarEnumsResponse(ApiBaseResponse<EnumsDTO> apiBaseResponse)
    {
        Success = apiBaseResponse.Success;
        Message = apiBaseResponse.Message;
        Content = apiBaseResponse.Content as T;
    }
}