using System.Text.Json.Serialization;

namespace BackHackathon.Application.Dtos;

public class TermosUsoSistemaWeb
{
    [JsonPropertyName("SincronizarTermosUso")]
    public bool SincronizarTermosUso { get; set; }

    [JsonPropertyName("Obrigatorio")]
    public bool Obrigatorio { get; set; }

    [JsonPropertyName("CodigoTermosUso")]
    public int CodigoTermosUso { get; set; }   
}