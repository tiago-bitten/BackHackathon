using System.Text.Json.Serialization;

namespace BackHackathon.Application.Exemplo.Dtos;

public class UnidadesPermitidaDTO
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("Fantasia")]
    public string Fantasia { get; set; }   
}