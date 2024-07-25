using System.Text.Json.Serialization;

namespace BackHackathon.Domain.Dtos;

public class ConfigCampoObrigatorioDTO
{
    [JsonPropertyName("Origem")]
    public int Origem { get; set; }

    [JsonPropertyName("NomeDaPropriedade")]
    public string NomeDaPropriedade { get; set; }
}