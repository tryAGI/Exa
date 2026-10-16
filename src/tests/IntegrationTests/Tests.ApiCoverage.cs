using System.Net;
using System.Text;
using System.Text.Json;
using Exa.TeamManagement;

namespace Exa.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [DataRow("agent", "/agent/runs")]
    [DataRow("batches", "/batches")]
    [DataRow("monitors", "/monitors")]
    [DataRow("monitor-runs", "/monitors/test-monitor/runs")]
    [DataRow("monitor-run", "/monitors/test-monitor/runs/test-run")]
    [DataRow("websets", "/websets/v0/websets")]
    [DataRow("webset-monitors", "/websets/v0/monitors")]
    [DataRow("imports", "/websets/v0/imports")]
    [DataRow("webhooks", "/websets/v0/webhooks")]
    [DataRow("events", "/websets/v0/events")]
    [DataRow("team", "/v0/teams/me")]
    public async Task PublicApiRouting(string family, string path)
    {
        using var handler = new StubHandler((request, _) =>
        {
            request.RequestUri!.GetLeftPart(UriPartial.Path).Should().Be("https://api.exa.ai" + path);
            request.Method.Should().Be(HttpMethod.Get);
            if (family == "batches")
            {
                request.Headers.GetValues("exa-beta").Should().Contain("batches-2026-06-06");
            }
            request.Headers.Authorization!.ToString().Should().Be("Bearer test-key");
            return new HttpResponseMessage(HttpStatusCode.Unauthorized)
            {
                Content = new StringContent("{}", Encoding.UTF8, "application/json"),
            };
        });
        using var http = new HttpClient(handler);
        using var client = new ExaClient("test-key", httpClient: http);
        Func<Task> call = family switch
        {
            "agent" => async () => { await client.Agent.ListAgentRunsAsync(); },
            "batches" => async () => { await client.Batches.ListBatchesAsync(ListBatchesExaBeta.Batches20260606); },
            "monitors" => async () => { await client.Monitors.ListMonitorsAsync(); },
            "monitor-runs" => async () => { await client.Runs.ListRunsAsync("test-monitor"); },
            "monitor-run" => async () => { await client.Runs.GetRunAsync("test-monitor", "test-run"); },
            "websets" => async () => { await client.Websets.WebsetsListAsync(); },
            "webset-monitors" => async () => { await client.Monitors.MonitorsListAsync(); },
            "imports" => async () => { await client.Imports.ImportsListAsync(); },
            "webhooks" => async () => { await client.Webhooks.WebhooksListAsync(); },
            "events" => async () => { await client.Events.EventsListAsync(); },
            "team" => async () => { await client.Teams.TeamsMeGetAsync(); },
            _ => throw new ArgumentOutOfRangeException(nameof(family)),
        };
        await call.Should().ThrowAsync<ApiException>();
        handler.Calls.Should().Be(1);
    }

    [TestMethod]
    public async Task TeamManagementUsesServiceKeyAndAdminHost()
    {
        using var handler = new StubHandler((request, _) =>
        {
            request.RequestUri!.AbsoluteUri.Should().Be("https://admin-api.exa.ai/team-management/api-keys");
            request.Headers.GetValues("x-api-key").Should().ContainSingle().Which.Should().Be("service-key");
            request.Headers.Authorization.Should().BeNull();
            return new HttpResponseMessage(HttpStatusCode.Unauthorized)
            {
                Content = new StringContent("{}", Encoding.UTF8, "application/json"),
            };
        });
        using var http = new HttpClient(handler);
        using var client = new ExaTeamManagementClient("service-key", httpClient: http);
        Func<Task> call = async () => { await client.ListApiKeysAsync(); };
        await call.Should().ThrowAsync<Exa.TeamManagement.ApiException>();
        handler.Calls.Should().Be(1);
    }

    [TestMethod]
    public async Task SearchToolSerializesCurrentRequestAndReadsResults()
    {
        using var handler = new StubHandler((request, body) =>
        {
            request.RequestUri!.AbsoluteUri.Should().Be("https://api.exa.ai/search");
            using var json = JsonDocument.Parse(body!);
            json.RootElement.GetProperty("query").GetString().Should().Be(".NET SDK");
            json.RootElement.GetProperty("type").GetString().Should().Be("auto");
            json.RootElement.GetProperty("numResults").GetInt32().Should().Be(3);
            json.RootElement.GetProperty("contents").GetProperty("text").GetBoolean().Should().BeTrue();
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("""{"results":[{"title":"Exa","url":"https://exa.ai","text":"Search content"}]}""", Encoding.UTF8, "application/json"),
            };
        });
        using var http = new HttpClient(handler);
        using var client = new ExaClient("test-key", httpClient: http);
        var result = await client.AsSearchTool(3).InvokeAsync(new Microsoft.Extensions.AI.AIFunctionArguments
        {
            ["query"] = ".NET SDK",
        });
        result!.ToString().Should().Contain("[Exa](https://exa.ai)").And.Contain("Search content");
        handler.Calls.Should().Be(1);
    }

    [TestMethod]
    [DataRow("contents")]
    [DataRow("answer")]
    public async Task ContentAndAnswerToolsReadCurrentResponses(string tool)
    {
        using var handler = new StubHandler((request, body) =>
        {
            using var json = JsonDocument.Parse(body!);
            request.RequestUri!.AbsolutePath.Should().Be("/" + (tool == "contents" ? "contents" : "answer"));
            json.RootElement.GetProperty("text").GetBoolean().Should().BeTrue();
            if (tool == "contents")
            {
                json.RootElement.GetProperty("urls")[0].GetString().Should().Be("https://exa.ai");
            }
            else
            {
                json.RootElement.GetProperty("query").GetString().Should().Be("What is Exa?");
            }
            var response = tool == "contents"
                ? """{"results":[{"title":"Exa","url":"https://exa.ai","text":"Search content"}]}"""
                : """{"answer":"Search content","citations":[{"title":"Exa","url":"https://exa.ai"}]}""";
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(response, Encoding.UTF8, "application/json"),
            };
        });
        using var http = new HttpClient(handler);
        using var client = new ExaClient("test-key", httpClient: http);
        var function = tool == "contents" ? client.AsGetContentsTool() : client.AsAnswerTool();
        var arguments = new Microsoft.Extensions.AI.AIFunctionArguments();
        arguments[tool == "contents" ? "url" : "query"] = tool == "contents" ? "https://exa.ai" : "What is Exa?";
        var result = await function.InvokeAsync(arguments);
        result!.ToString().Should().Contain("Search content").And.Contain("https://exa.ai");
        handler.Calls.Should().Be(1);
    }

    [TestMethod]
    public async Task AgentAndWebsetsCanShareHttpClientWithoutChangingItsBaseAddress()
    {
        var paths = new Queue<string>(["/agent/runs", "/websets/v0/websets", "/batches"]);
        using var handler = new StubHandler((request, _) =>
        {
            request.RequestUri!.AbsoluteUri.Should().Be("https://api.exa.ai" + paths.Dequeue());
            return new HttpResponseMessage(HttpStatusCode.Unauthorized)
            {
                Content = new StringContent("{}", Encoding.UTF8, "application/json"),
            };
        });
        using var http = new HttpClient(handler);
        using var client = new ExaClient("test-key", httpClient: http);
        Func<Task> agent = async () => { await client.Agent.ListAgentRunsAsync(); };
        Func<Task> websets = async () => { await client.Websets.WebsetsListAsync(); };
        Func<Task> batches = async () => { await client.Batches.ListBatchesAsync(ListBatchesExaBeta.Batches20260606); };
        await agent.Should().ThrowAsync<ApiException>();
        await websets.Should().ThrowAsync<ApiException>();
        await batches.Should().ThrowAsync<ApiException>();
        http.BaseAddress.Should().BeNull();
        paths.Should().BeEmpty();
    }

    [TestMethod]
    public async Task AgentHonorsExplicitBaseUrl()
    {
        using var handler = new StubHandler((request, _) =>
        {
            request.RequestUri!.AbsoluteUri.Should().Be("https://proxy.example/exa/agent/runs");
            return new HttpResponseMessage(HttpStatusCode.Unauthorized)
            {
                Content = new StringContent("{}", Encoding.UTF8, "application/json"),
            };
        });
        using var http = new HttpClient(handler);
        using var client = new ExaClient("test-key", httpClient: http, baseUri: new Uri("https://proxy.example/exa/"));
        Func<Task> call = async () => { await client.Agent.ListAgentRunsAsync(); };
        await call.Should().ThrowAsync<ApiException>();
        handler.Calls.Should().Be(1);
    }

    private sealed class StubHandler(Func<HttpRequestMessage, string?, HttpResponseMessage> respond) : HttpMessageHandler
    {
        public int Calls { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Calls++;
            var body = request.Content is null ? null : await request.Content.ReadAsStringAsync(cancellationToken);
            return respond(request, body);
        }
    }
}
