namespace Octokit.Webhooks.Models.DeploymentEvent;

[PublicAPI]
public enum DeploymentCheckRunStatus
{
    [EnumMember(Value = "requested")]
    Requested,
    [EnumMember(Value = "in_progress")]
    InProgress,
    [EnumMember(Value = "completed")]
    Completed,
    [EnumMember(Value = "queued")]
    Queued,
    [EnumMember(Value = "waiting")]
    Waiting,
}
