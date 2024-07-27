using System.Text.Json.Serialization;

namespace BackHackathon.Application.Dtos;

public class ItemDTO
{
    [JsonPropertyName("Valor")]
    public int Valor { get; set; }

    [JsonPropertyName("Identificador")]
    public string Identificador { get; set; }

    [JsonPropertyName("Texto")]
    public string Texto { get; set; }
}