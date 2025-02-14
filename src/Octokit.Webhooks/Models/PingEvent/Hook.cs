namespace Octokit.Webhooks.Models.PingEvent;

[PublicAPI]
public sealed record Hook
{
    [JsonPropertyName("type")]
    [JsonConverter(typeof(StringEnumConverter<HookType>))]
    public StringEnum<HookType> Type { get; init; } = null!;

    [JsonPropertyName("id")]
    public long Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;

    [JsonPropertyName("active")]
    public bool Active { get; init; }

    [JsonPropertyName("app_id")]
    public int? AppId { get; init; }

    [JsonPropertyName("events")]
    [JsonConverter(typeof(StringEnumEnumerableConverter<AppEvent>))]
    public IEnumerable<StringEnum<AppEvent>> Events { get; init; } = null!;

    [JsonPropertyName("config")]
    public HookConfig Config { get; init; } = null!;

    [JsonPropertyName("updated_at")]
    [JsonConverter(typeof(DateTimeOffsetConverter))]
    public DateTimeOffset UpdatedAt { get; init; }

    [JsonPropertyName("created_at")]
    [JsonConverter(typeof(DateTimeOffsetConverter))]
    public DateTimeOffset CreatedAt { get; init; }

    [JsonPropertyName("url")]
    public string Url { get; init; } = null!;

    [JsonPropertyName("test_url")]
    public string? TestUrl { get; init; }

    [JsonPropertyName("ping_url")]
    public string PingUrl { get; init; } = null!;

    [JsonPropertyName("deliveries_url")]
    public string DeliveriesUrl { get; init; } = null!;

    [JsonPropertyName("last_response")]
    public HookLastResponse LastResponse { get; init; } = null!;
}
