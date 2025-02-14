﻿namespace Octokit.Webhooks.Models;

[PublicAPI]
public sealed record SimplePullRequestBase
{
    [JsonPropertyName("label")]
    public string Label { get; init; } = null!;

    [JsonPropertyName("ref")]
    public string Ref { get; init; } = null!;

    [JsonPropertyName("sha")]
    public string Sha { get; init; } = null!;

    [JsonPropertyName("user")]
    public User User { get; init; } = null!;

    [JsonPropertyName("repo")]
    public Repository Repo { get; init; } = null!;
}
