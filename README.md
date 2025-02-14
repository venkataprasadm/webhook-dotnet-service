
## Usage

### ASP.NET Core

1. `dotnet add package Octokit.Webhooks.AspNetCore`
2. Create a class that derives from `WebhookEventProcessor` and override any of the virtual methods to handle webhooks from GitHub. For example, to handle Pull Request webhooks:

    ```C#
    public sealed class MyWebhookEventProcessor : WebhookEventProcessor
    {
        protected override Task ProcessPullRequestWebhookAsync(WebhookHeaders headers, PullRequestEvent pullRequestEvent, PullRequestAction action) 
        {
            ...
        }
    }
    ```

3. Register your implementation of `WebhookEventProcessor`:

    ```C#
    builder.Services.AddSingleton<WebhookEventProcessor, MyWebhookEventProcessor>();
    ```

4. Map the webhook endpoint:

    ```C#
    app.UseEndpoints(endpoints =>
    {
        ...
        endpoints.MapGitHubWebhooks();
        ...
    });
    ```

`MapGitHubWebhooks()` takes two optional parameters:

* `path`. Defaults to `/api/github/webhooks`, the URL of the endpoint to use for GitHub.
* `secret`. The secret you have configured in GitHub, if you have set this up.

### Azure Functions

**NOTE**: Support is only provided for [isolated process Azure Functions](https://learn.microsoft.com/en-us/azure/azure-functions/dotnet-isolated-process-guide).

1. `dotnet add package Octokit.Webhooks.AzureFunctions`
2. Create a class that derives from `WebhookEventProcessor` and override any of the virtual methods to handle webhooks from GitHub. For example, to handle Pull Request webhooks:

    ```C#
    public sealed class MyWebhookEventProcessor : WebhookEventProcessor
    {
        protected override Task ProcessPullRequestWebhookAsync(WebhookHeaders headers, PullRequestEvent pullRequestEvent, PullRequestAction action) 
        {
            ...
        }
    }
    ```

3. Register your implementation of `WebhookEventProcessor`:

    ```C#
    .ConfigureServices(collection =>
    {
        ...
        collection.AddSingleton<WebhookEventProcessor, MyWebhookEventProcessor>();
        ...
    })
    ```

4. Configure the webhook function:

    ```C#
    new HostBuilder()
    ...
    .ConfigureGitHubWebhooks()
    ...
    .Build();
    ```

`ConfigureGitHubWebhooks()` either takes an optional parameter:

* `secret`. The secret you have configured in GitHub, if you have set this up.

or:

* `configure`. A function that takes an IConfiguration instance and expects the secret you have configured in GitHub in return.

The function is available on the `/api/github/webhooks` endpoint.

## License

All packages in this repository are licensed under [the MIT license](https://opensource.org/licenses/MIT).
