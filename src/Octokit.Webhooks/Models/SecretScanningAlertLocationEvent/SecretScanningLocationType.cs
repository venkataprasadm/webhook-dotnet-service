namespace Octokit.Webhooks.Models.SecretScanningAlertLocationEvent;

[PublicAPI]
public enum SecretScanningLocationType
{
    [EnumMember(Value = "commit")]
    Commit,
    [EnumMember(Value = "issue_title")]
    IssueTitle,
    [EnumMember(Value = "issue_body")]
    IssueBody,
    [EnumMember(Value = "issue_comment")]
    IssueComment,
}
