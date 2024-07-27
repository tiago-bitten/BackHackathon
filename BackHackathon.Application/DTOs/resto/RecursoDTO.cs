using System.Text.Json.Serialization;

namespace BackHackathon.Application.DTOs;

public class RecursoDTO
{
    [JsonPropertyName("Recurso")]
    public int Recurso { get; set; }
    
    [JsonPropertyName("Habilitado")]
    public bool Habilitado { get; set; }
}