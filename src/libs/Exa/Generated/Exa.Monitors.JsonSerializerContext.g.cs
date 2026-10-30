
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestOutputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OutputSchemaText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OutputSchemaObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.JsonValue), TypeInfoPropertyName = "JsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.JsonValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateSearchMonitorParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsText>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextVerbosity), TypeInfoPropertyName = "SearchMonitorContentsTextVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item), TypeInfoPropertyName = "SearchMonitorContentsTextIncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item), TypeInfoPropertyName = "SearchMonitorContentsTextExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsHighlights>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsHighlights2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsHighlights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsHighlightsVerbosity), TypeInfoPropertyName = "SearchMonitorContentsHighlightsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptions>), TypeInfoPropertyName = "OneOfBooleanSummaryWithMaxTokensOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SummaryWithMaxTokensOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsExtras))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsContext>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsContext2")]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsContext))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsLivecrawl?, string>), TypeInfoPropertyName = "OneOfSearchMonitorContentsLivecrawlString2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsLivecrawl), TypeInfoPropertyName = "SearchMonitorContentsLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaVariant1DiscriminatorType), TypeInfoPropertyName = "SearchMonitorOutputSchemaVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookEvent), TypeInfoPropertyName = "SearchMonitorWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestAction), TypeInfoPropertyName = "BatchMonitorsRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestFilterStatus), TypeInfoPropertyName = "BatchMonitorsRequestFilterStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersStatus), TypeInfoPropertyName = "UpdateSearchMonitorParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.UpdateSearchMonitorParametersWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersWebhookEvent), TypeInfoPropertyName = "UpdateSearchMonitorParametersWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateSearchMonitorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateSearchMonitorResponseStatus), TypeInfoPropertyName = "CreateSearchMonitorResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorSearchOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorTriggerOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListSearchMonitorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorStatus), TypeInfoPropertyName = "SearchMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsResponseAction), TypeInfoPropertyName = "BatchMonitorsResponseAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TriggerSearchMonitorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputText>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsOutputText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextVerbosity), TypeInfoPropertyName = "SearchMonitorContentsOutputTextVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item), TypeInfoPropertyName = "SearchMonitorContentsOutputTextIncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item), TypeInfoPropertyName = "SearchMonitorContentsOutputTextExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputHighlights>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsOutputHighlights2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputHighlights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputHighlightsVerbosity), TypeInfoPropertyName = "SearchMonitorContentsOutputHighlightsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptionsOutput>), TypeInfoPropertyName = "OneOfBooleanSummaryWithMaxTokensOptionsOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SummaryWithMaxTokensOptionsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputExtras))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputContext>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsOutputContext2")]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputContext))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>), TypeInfoPropertyName = "OneOfSearchMonitorContentsOutputLivecrawlString2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputLivecrawl), TypeInfoPropertyName = "SearchMonitorContentsOutputLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OutputSchemaTextOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType), TypeInfoPropertyName = "SearchMonitorOutputSchemaOutputVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookOutputEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookOutputEvent), TypeInfoPropertyName = "SearchMonitorWebhookOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Entity), TypeInfoPropertyName = "Entity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CompanyEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PersonEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ArticleEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchPaperEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CustomEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchBehavior), TypeInfoPropertyName = "WebsetSearchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateMonitorParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorCadence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehavior))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.MonitorBehaviorConfigCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfigCriteriaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateMonitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateMonitorStatus), TypeInfoPropertyName = "UpdateMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Monitor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Monitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorObject), TypeInfoPropertyName = "MonitorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorStatus), TypeInfoPropertyName = "MonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunObject), TypeInfoPropertyName = "MonitorRunObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunStatus), TypeInfoPropertyName = "MonitorRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunType), TypeInfoPropertyName = "MonitorRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListMonitorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListMonitorsStatus), TypeInfoPropertyName = "ListMonitorsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.JsonValue?), TypeInfoPropertyName = "NullableJsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsText>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextVerbosity?), TypeInfoPropertyName = "NullableSearchMonitorContentsTextVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsTextIncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsTextExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsHighlights>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsHighlights2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsHighlightsVerbosity?), TypeInfoPropertyName = "NullableSearchMonitorContentsHighlightsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptions>?), TypeInfoPropertyName = "NullableOneOfBooleanSummaryWithMaxTokensOptions2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsContext>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsContext2")]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsLivecrawl?, string>?), TypeInfoPropertyName = "NullableOneOfSearchMonitorContentsLivecrawlString2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsLivecrawl?), TypeInfoPropertyName = "NullableSearchMonitorContentsLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableSearchMonitorOutputSchemaVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookEvent?), TypeInfoPropertyName = "NullableSearchMonitorWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestAction?), TypeInfoPropertyName = "NullableBatchMonitorsRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestFilterStatus?), TypeInfoPropertyName = "NullableBatchMonitorsRequestFilterStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersStatus?), TypeInfoPropertyName = "NullableUpdateSearchMonitorParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersWebhookEvent?), TypeInfoPropertyName = "NullableUpdateSearchMonitorParametersWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateSearchMonitorResponseStatus?), TypeInfoPropertyName = "NullableCreateSearchMonitorResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorStatus?), TypeInfoPropertyName = "NullableSearchMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsResponseAction?), TypeInfoPropertyName = "NullableBatchMonitorsResponseAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputText>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsOutputText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextVerbosity?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputTextVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputTextIncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputTextExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputHighlights>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsOutputHighlights2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputHighlightsVerbosity?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputHighlightsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptionsOutput>?), TypeInfoPropertyName = "NullableOneOfBooleanSummaryWithMaxTokensOptionsOutput2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputContext>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsOutputContext2")]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>?), TypeInfoPropertyName = "NullableOneOfSearchMonitorContentsOutputLivecrawlString2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputLivecrawl?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableSearchMonitorOutputSchemaOutputVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookOutputEvent?), TypeInfoPropertyName = "NullableSearchMonitorWebhookOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Entity?), TypeInfoPropertyName = "NullableEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchBehavior?), TypeInfoPropertyName = "NullableWebsetSearchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateMonitorStatus?), TypeInfoPropertyName = "NullableUpdateMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorObject?), TypeInfoPropertyName = "NullableMonitorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorStatus?), TypeInfoPropertyName = "NullableMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunObject?), TypeInfoPropertyName = "NullableMonitorRunObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunStatus?), TypeInfoPropertyName = "NullableMonitorRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunType?), TypeInfoPropertyName = "NullableMonitorRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListMonitorsStatus?), TypeInfoPropertyName = "NullableListMonitorsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.JsonValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.UpdateSearchMonitorParametersWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorWebhookOutputEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.MonitorBehaviorConfigCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Monitor>))]
    internal sealed partial class MonitorsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MonitorsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MonitorsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MonitorsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Exa.JsonConverters.SearchRequestOutputSchemaJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.JsonValueJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorOutputSchemaVariant1JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorOutputSchemaOutputVariant1JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EntityJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsText>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsHighlights>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SummaryWithMaxTokensOptions>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsContext>());
            #pragma warning restore CS0618
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsLivecrawl?, string>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputText>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputHighlights>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SummaryWithMaxTokensOptionsOutput>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputContext>());
            #pragma warning restore CS0618
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>());
            options.Converters.Add(new global::Exa.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Exa.SearchMonitorContentsTextVerbosity)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsTextVerbosity?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsHighlightsVerbosity)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsHighlightsVerbosity?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsLivecrawl)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsLivecrawl?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorOutputSchemaVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Exa.SearchMonitorOutputSchemaVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorWebhookEvent)

                    || typeToConvert == typeof(global::Exa.SearchMonitorWebhookEvent?)

                    || typeToConvert == typeof(global::Exa.BatchMonitorsRequestAction)

                    || typeToConvert == typeof(global::Exa.BatchMonitorsRequestAction?)

                    || typeToConvert == typeof(global::Exa.BatchMonitorsRequestFilterStatus)

                    || typeToConvert == typeof(global::Exa.BatchMonitorsRequestFilterStatus?)

                    || typeToConvert == typeof(global::Exa.UpdateSearchMonitorParametersStatus)

                    || typeToConvert == typeof(global::Exa.UpdateSearchMonitorParametersStatus?)

                    || typeToConvert == typeof(global::Exa.UpdateSearchMonitorParametersWebhookEvent)

                    || typeToConvert == typeof(global::Exa.UpdateSearchMonitorParametersWebhookEvent?)

                    || typeToConvert == typeof(global::Exa.CreateSearchMonitorResponseStatus)

                    || typeToConvert == typeof(global::Exa.CreateSearchMonitorResponseStatus?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorStatus)

                    || typeToConvert == typeof(global::Exa.SearchMonitorStatus?)

                    || typeToConvert == typeof(global::Exa.BatchMonitorsResponseAction)

                    || typeToConvert == typeof(global::Exa.BatchMonitorsResponseAction?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextVerbosity)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextVerbosity?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputHighlightsVerbosity)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputHighlightsVerbosity?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputLivecrawl)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputLivecrawl?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorWebhookOutputEvent)

                    || typeToConvert == typeof(global::Exa.SearchMonitorWebhookOutputEvent?)

                    || typeToConvert == typeof(global::Exa.WebsetSearchBehavior)

                    || typeToConvert == typeof(global::Exa.WebsetSearchBehavior?)

                    || typeToConvert == typeof(global::Exa.UpdateMonitorStatus)

                    || typeToConvert == typeof(global::Exa.UpdateMonitorStatus?)

                    || typeToConvert == typeof(global::Exa.MonitorObject)

                    || typeToConvert == typeof(global::Exa.MonitorObject?)

                    || typeToConvert == typeof(global::Exa.MonitorStatus)

                    || typeToConvert == typeof(global::Exa.MonitorStatus?)

                    || typeToConvert == typeof(global::Exa.MonitorRunObject)

                    || typeToConvert == typeof(global::Exa.MonitorRunObject?)

                    || typeToConvert == typeof(global::Exa.MonitorRunStatus)

                    || typeToConvert == typeof(global::Exa.MonitorRunStatus?)

                    || typeToConvert == typeof(global::Exa.MonitorRunType)

                    || typeToConvert == typeof(global::Exa.MonitorRunType?)

                    || typeToConvert == typeof(global::Exa.ListMonitorsStatus)

                    || typeToConvert == typeof(global::Exa.ListMonitorsStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsTextVerbosity))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsTextVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsTextVerbosity?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsTextVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsTextIncludeSectionsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsTextIncludeSectionsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsTextExcludeSectionsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsTextExcludeSectionsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsHighlightsVerbosity))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsHighlightsVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsHighlightsVerbosity?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsHighlightsVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsLivecrawl))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsLivecrawlJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsLivecrawl?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsLivecrawlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorOutputSchemaVariant1DiscriminatorType))
                {
                    return new global::Exa.JsonConverters.SearchMonitorOutputSchemaVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorOutputSchemaVariant1DiscriminatorType?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorOutputSchemaVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorWebhookEvent))
                {
                    return new global::Exa.JsonConverters.SearchMonitorWebhookEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorWebhookEvent?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorWebhookEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.BatchMonitorsRequestAction))
                {
                    return new global::Exa.JsonConverters.BatchMonitorsRequestActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.BatchMonitorsRequestAction?))
                {
                    return new global::Exa.JsonConverters.BatchMonitorsRequestActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.BatchMonitorsRequestFilterStatus))
                {
                    return new global::Exa.JsonConverters.BatchMonitorsRequestFilterStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.BatchMonitorsRequestFilterStatus?))
                {
                    return new global::Exa.JsonConverters.BatchMonitorsRequestFilterStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.UpdateSearchMonitorParametersStatus))
                {
                    return new global::Exa.JsonConverters.UpdateSearchMonitorParametersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.UpdateSearchMonitorParametersStatus?))
                {
                    return new global::Exa.JsonConverters.UpdateSearchMonitorParametersStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.UpdateSearchMonitorParametersWebhookEvent))
                {
                    return new global::Exa.JsonConverters.UpdateSearchMonitorParametersWebhookEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.UpdateSearchMonitorParametersWebhookEvent?))
                {
                    return new global::Exa.JsonConverters.UpdateSearchMonitorParametersWebhookEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateSearchMonitorResponseStatus))
                {
                    return new global::Exa.JsonConverters.CreateSearchMonitorResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateSearchMonitorResponseStatus?))
                {
                    return new global::Exa.JsonConverters.CreateSearchMonitorResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorStatus))
                {
                    return new global::Exa.JsonConverters.SearchMonitorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorStatus?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.BatchMonitorsResponseAction))
                {
                    return new global::Exa.JsonConverters.BatchMonitorsResponseActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.BatchMonitorsResponseAction?))
                {
                    return new global::Exa.JsonConverters.BatchMonitorsResponseActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextVerbosity))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsOutputTextVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextVerbosity?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsOutputTextVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsOutputTextIncludeSectionsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsOutputTextIncludeSectionsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsOutputTextExcludeSectionsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsOutputTextExcludeSectionsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputHighlightsVerbosity))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsOutputHighlightsVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputHighlightsVerbosity?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsOutputHighlightsVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputLivecrawl))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsOutputLivecrawlJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorContentsOutputLivecrawl?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorContentsOutputLivecrawlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType))
                {
                    return new global::Exa.JsonConverters.SearchMonitorOutputSchemaOutputVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorOutputSchemaOutputVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorWebhookOutputEvent))
                {
                    return new global::Exa.JsonConverters.SearchMonitorWebhookOutputEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorWebhookOutputEvent?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorWebhookOutputEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchBehavior))
                {
                    return new global::Exa.JsonConverters.WebsetSearchBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchBehavior?))
                {
                    return new global::Exa.JsonConverters.WebsetSearchBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.UpdateMonitorStatus))
                {
                    return new global::Exa.JsonConverters.UpdateMonitorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.UpdateMonitorStatus?))
                {
                    return new global::Exa.JsonConverters.UpdateMonitorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.MonitorObject))
                {
                    return new global::Exa.JsonConverters.MonitorObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.MonitorObject?))
                {
                    return new global::Exa.JsonConverters.MonitorObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.MonitorStatus))
                {
                    return new global::Exa.JsonConverters.MonitorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.MonitorStatus?))
                {
                    return new global::Exa.JsonConverters.MonitorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.MonitorRunObject))
                {
                    return new global::Exa.JsonConverters.MonitorRunObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.MonitorRunObject?))
                {
                    return new global::Exa.JsonConverters.MonitorRunObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.MonitorRunStatus))
                {
                    return new global::Exa.JsonConverters.MonitorRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.MonitorRunStatus?))
                {
                    return new global::Exa.JsonConverters.MonitorRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.MonitorRunType))
                {
                    return new global::Exa.JsonConverters.MonitorRunTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.MonitorRunType?))
                {
                    return new global::Exa.JsonConverters.MonitorRunTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ListMonitorsStatus))
                {
                    return new global::Exa.JsonConverters.ListMonitorsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ListMonitorsStatus?))
                {
                    return new global::Exa.JsonConverters.ListMonitorsStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new MonitorsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}