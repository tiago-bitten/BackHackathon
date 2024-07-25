using System.Text.Json.Serialization;

namespace BackHackathon.Application.Dtos;

public class EnumsDTO
{
    [JsonPropertyName("Version")]
    public int Version { get; set; }

    [JsonPropertyName("Enums")]
    public List<EnumDTO> Enums { get; set; }
}