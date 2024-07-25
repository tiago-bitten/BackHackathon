using System.Text.Json.Serialization;

namespace BackHackathon.Application;

public class ApiBaseResponse<T>
{
    [JsonPropertyName("Content")]
    public T Content { get; set; }

    [JsonPropertyName("Message")]
    public string Message { get; set; }

    [JsonPropertyName("Success")]
    public bool Success { get; set; }
}