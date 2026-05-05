namespace Chaos.Api.Models.Response;

public class StatusResponse
{
    public string ServiceName { get; set; } = string.Empty;
    public string Environment { get; set; } = string.Empty;
    public string Version { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public DateTime UpdatedAt { get; set; }
}