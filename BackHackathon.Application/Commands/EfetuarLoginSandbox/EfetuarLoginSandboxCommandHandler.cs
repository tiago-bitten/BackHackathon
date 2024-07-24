using System.Text.Json;
using BackHackathon.Application.Constants;
using MediatR;

namespace BackHackathon.Application.Commands.EfetuarLoginSandbox;

public class EfetuarLoginSandboxCommandHandler : IRequestHandler<EfetuarLoginSandboxCommand, EfetuarLoginSandboxResponse>
{
    public async Task<EfetuarLoginSandboxResponse> Handle(EfetuarLoginSandboxCommand requestCommand, CancellationToken cancellationToken)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, SandboxApiConfig.Endpoints.Token);
        
        var collection = new List<KeyValuePair<string, string>>
        {
            new("username", requestCommand.Usuario),
            new("password", requestCommand.Senha),
            new("grant_type", "password")
        };

        request.Content = new FormUrlEncodedContent(collection);
        var response = await client.SendAsync(request);
        
        response.EnsureSuccessStatusCode();
        var responseContent = await response.Content.ReadAsStringAsync();
        
        return JsonSerializer.Deserialize<EfetuarLoginSandboxResponse>(responseContent);
    }
}