﻿using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using BackHackathon.Application.Constants;
using BackHackathon.Domain.Entities;
using BackHackathon.Domain.Intefaces;

namespace BackHackathon.Application.Services;

public class ConfigAvaliacaoFisicaService : IConfigAvaliacaoFisicaService
{
    private readonly ILoginSandboxService _loginSandboxService;

    public ConfigAvaliacaoFisicaService(ILoginSandboxService loginSandboxService)
    {
        _loginSandboxService = loginSandboxService;
    }
    
    public async Task<ConfigAvaliacaoFisica> Configurar(ConfigAvaliacaoFisica config)
    {
        var token = await _loginSandboxService.Login();

        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, SandboxApiConfig.Endpoints.ConfigAvaliacaoFisica);

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
        
        var jsonBody = JsonSerializer.Serialize(config);
        
        request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        var response = await client.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        
        var responseJson = JsonSerializer.Deserialize<ApiBaseResponse<Modalidade>>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        
        config.Id = responseJson.Content.Id;

        return config;
    }
}