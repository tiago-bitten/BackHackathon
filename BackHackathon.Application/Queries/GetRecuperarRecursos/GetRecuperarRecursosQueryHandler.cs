using System.Text.Json;
using BackHackathon.Application.Constants;
using BackHackathon.Application.DTOs;
using MediatR;

namespace BackHackathon.Application.Queries.GetRecuperarRecursos;

public class GetRecuperarRecursosQueryHandler : IRequestHandler<GetRecuperarRecursosQuery, GetRecuperarRecursosResponse>
{
    public async Task<GetRecuperarRecursosResponse> Handle(GetRecuperarRecursosQuery requestCommand, CancellationToken cancellationToken)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, SandboxApiConfig.Endpoints.RecuperarRecursos);

        request.Headers.Add("Authorization", requestCommand.Authorization);
        request.Headers.Add(SandboxApiConfig.Headers.CodigoUnidade, requestCommand.CodigoUnidade.ToString());

        var response = await client.SendAsync(request, cancellationToken);
        var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);

        var responseDto = JsonSerializer.Deserialize<ApiBaseResponse<List<RecursoDTO>>>(responseContent);

        return new GetRecuperarRecursosResponse(responseDto);
    }
}