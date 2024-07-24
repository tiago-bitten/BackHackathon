using System.Text.Json.Serialization;

namespace BackHackathon.Application.Exemplo.Dtos;

public class EnumsContent
{
    [JsonPropertyName("Version")]
    public int Version { get; set; }

    [JsonPropertyName("Enums")]
    public List<Enum> Enums { get; set; }
}

public class Enum
{
    [JsonPropertyName("Nome")]
    public string Nome { get; set; }

    [JsonPropertyName("Itens")]
    public List<Item> Itens { get; set; }
}

public class Item
{
    [JsonPropertyName("Valor")]
    public int Valor { get; set; }

    [JsonPropertyName("Identificador")]
    public string Identificador { get; set; }

    [JsonPropertyName("Texto")]
    public string Texto { get; set; }
}

    