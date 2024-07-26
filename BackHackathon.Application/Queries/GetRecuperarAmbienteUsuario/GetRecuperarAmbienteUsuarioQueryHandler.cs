using System.Text.Json;
using BackHackathon.Application.Constants;
using BackHackathon.Domain.Dtos;
using MediatR;

namespace BackHackathon.Application.Queries.GetRecuperarAmbienteUsuario;

public class GetRecuperarAmbienteUsuarioQueryHandler : IRequestHandler<GetRecuperarAmbienteUsuarioQuery, GetRecuperarAmbienteUsuarioResponse>
{
    public async Task<GetRecuperarAmbienteUsuarioResponse> Handle(GetRecuperarAmbienteUsuarioQuery requestCommand, CancellationToken cancellationToken)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, SandboxApiConfig.Endpoints.UsuarioRecuperarAmbienteUsuario);
        
        request.Headers.Add("Authorization", requestCommand.Authorization);
        request.Headers.Add(SandboxApiConfig.Headers.CodigoUsuario, requestCommand.CodigoUsuario.ToString());
        request.Headers.Add(SandboxApiConfig.Headers.CodigoUnidade, requestCommand.CodigoUnidade.ToString());
        
        var response = await client.SendAsync(request, cancellationToken);

        var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);

        var responseDto = JsonSerializer.Deserialize<ApiBaseResponse<RecuperarAmbienteUsuarioDTO>>(responseContent);

        return new GetRecuperarAmbienteUsuarioResponse(responseDto);
    }
}