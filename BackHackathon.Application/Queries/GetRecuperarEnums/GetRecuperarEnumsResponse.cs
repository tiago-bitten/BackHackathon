using BackHackathon.Application.Dtos;

namespace BackHackathon.Application.Queries.GetRecuperarEnums;

public class GetRecuperarEnumsResponse : ApiBaseResponse<EnumsDTO>
{
    public GetRecuperarEnumsResponse(ApiBaseResponse<EnumsDTO> apiBaseResponse)
    {
        Content = apiBaseResponse.Content;
        Success = apiBaseResponse.Success;
        Message = apiBaseResponse.Message;
    }
}