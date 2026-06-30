
#nullable enable

namespace Exa
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IExaClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }


        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::Exa.AutoSDKServer> AvailableServers { get; }

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::Exa.AutoSDKServer? SelectedServer { get; set; }

        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId);

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer();

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Exa.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AgentClient Agent { get; }

        /// <summary>
        /// 
        /// </summary>
        public EnrichmentsClient Enrichments { get; }

        /// <summary>
        /// 
        /// </summary>
        public EventsClient Events { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImportsClient Imports { get; }

        /// <summary>
        /// 
        /// </summary>
        public ItemsClient Items { get; }

        /// <summary>
        /// 
        /// </summary>
        public MonitorsClient Monitors { get; }

        /// <summary>
        /// 
        /// </summary>
        public MonitorsRunsClient MonitorsRuns { get; }

        /// <summary>
        /// 
        /// </summary>
        public ResearchClient Research { get; }

        /// <summary>
        /// 
        /// </summary>
        public RunsClient Runs { get; }

        /// <summary>
        /// 
        /// </summary>
        public SearchesClient Searches { get; }

        /// <summary>
        /// 
        /// </summary>
        public TeamsClient Teams { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhooksAttemptsClient WebhooksAttempts { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebsetsClient Websets { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebsetsPreviewClient WebsetsPreview { get; }

    }
}