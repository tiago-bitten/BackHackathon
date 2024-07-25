using System.Text.Json.Serialization;
using BackHackathon.Application.Exemplo.Dtos;

namespace BackHackathon.Application.Dtos;

public class EnumDTO
{
    [JsonPropertyName("Nome")]
    public string Nome { get; set; }

    [JsonPropertyName("Itens")]
    public List<ItemDTO> Itens { get; set; }
}