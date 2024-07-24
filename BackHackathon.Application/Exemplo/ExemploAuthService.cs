using System.Text.Json;
using BackHackathon.Application.Constants;
using BackHackathon.Application.Exemplo.Dtos;
using BackHackathon.Domain;

namespace BackHackathon.Application.Exemplo;

public class ExemploAuthService : IExemploAppService
{
    
    public async Task<ApiBaseResponse<AmbienteUsuarioContent>?> RecuperarAmbienteUsuario(AmbienteUsuarioRequestDto requestDtoDto)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, SandboxApiConfig.Endpoints.UsuarioRecuperarAmbienteUsuario);
        
        request.Headers.Add("Authorization", requestDtoDto.Authorization);
        request.Headers.Add(SandboxApiConfig.Headers.CodigoUsuario, requestDtoDto.CodigoUsuario.ToString());
        request.Headers.Add(SandboxApiConfig.Headers.CodigoUnidade, requestDtoDto.CodigoUnidade.ToString());
        
        var response = await client.SendAsync(request);

        var responseContent = await response.Content.ReadAsStringAsync();

        var responseDto = JsonSerializer.Deserialize<ApiBaseResponse<AmbienteUsuarioContent>>(responseContent);
         
        return responseDto;
    }
    
    public async Task<ApiBaseResponse<EnumsContent>?> RecuperarEnums(EnumsRequestDto requestDto)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, SandboxApiConfig.Endpoints.EnumRecuperarTodos);
        
        request.Headers.Add("Authorization", requestDto.Authorization);
        request.Headers.Add("Accept", "application/json");
        
        var response = await client.SendAsync(request);
        
        var responseContent = await response.Content.ReadAsStringAsync();

        var responseDto = JsonSerializer.Deserialize<ApiBaseResponse<EnumsContent>>(responseContent);
        
        return responseDto;
    }
}