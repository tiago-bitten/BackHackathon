using System.Text.Json;
using BackHackathon.Application.Constants;
using BackHackathon.Application.DTOs;
using MediatR;

namespace BackHackathon.Application.Queries.GetRecuperarPermissoesUsuarioLogado;

public class GetRecuperarPermissoesUsuarioLogadoQueryHandler : IRequestHandler<GetRecuperarPermissoesUsuarioLogadoQuery, GetRecuperarPermissoesUsuarioLogadoResponse>
{
    public async Task<GetRecuperarPermissoesUsuarioLogadoResponse> Handle(GetRecuperarPermissoesUsuarioLogadoQuery requestCommand, CancellationToken cancellationToken)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, SandboxApiConfig.Endpoints.PerfilAcessoRecuperarPermissoesUsuarioLogado);

        var response = await client.SendAsync(request);

        var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);

        var responseDto = JsonSerializer.Deserialize<ApiBaseResponse<List<PermissaoDTO>>>(responseContent);

        return new GetRecuperarPermissoesUsuarioLogadoResponse(responseDto);
    }
}