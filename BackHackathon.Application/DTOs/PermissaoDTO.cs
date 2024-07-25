using System.Text.Json.Serialization;

namespace BackHackathon.Application.DTOs;

public class PermissaoDTO
{
    [JsonPropertyName("Permissao")]
    public int Permissao { get; set; }
    
    [JsonPropertyName("Permitido")]
    public bool Permitido { get; set; }
}