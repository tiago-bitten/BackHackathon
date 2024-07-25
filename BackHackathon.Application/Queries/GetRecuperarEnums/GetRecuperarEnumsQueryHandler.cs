using System.Text.Json;
using BackHackathon.Application.Constants;
using BackHackathon.Application.Dtos;
using BackHackathon.Domain;
using MediatR;

namespace BackHackathon.Application.Queries.GetRecuperarEnums;

public class GetRecuperarEnumsQueryHandler : IRequestHandler<GetRecuperarEnumsQuery, GetRecuperarEnumsResponse<EnumsDTO>>
{
    public async Task<GetRecuperarEnumsResponse<EnumsDTO>> Handle(GetRecuperarEnumsQuery requestCommand, CancellationToken cancellationToken)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, SandboxApiConfig.Endpoints.EnumRecuperarTodos);
        
        request.Headers.Add("Authorization", requestCommand.Authorization);

        var response = await client.SendAsync(request, cancellationToken);

        var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);

        var responseDto = JsonSerializer.Deserialize<ApiBaseResponse<EnumsDTO>>(responseContent);

        return new GetRecuperarEnumsResponse<EnumsDTO>(responseDto);
    }
}