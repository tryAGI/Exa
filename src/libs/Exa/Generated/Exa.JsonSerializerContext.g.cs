
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>), TypeInfoPropertyName = "WebsetItemCustomProperties_976e7369ebb8440c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>?), TypeInfoPropertyName = "WebsetItemCustomProperties_2a7882e053a7bb38")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestCategory), TypeInfoPropertyName = "SearchRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::Exa.SearchRequestUserLocationVariant1Variant2, global::Exa.SearchRequestUserLocationVariant1Variant3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestUserLocationVariant1Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestUserLocationVariant1Variant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestCompliance), TypeInfoPropertyName = "SearchRequestCompliance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestOutputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OutputSchemaText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OutputSchemaObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestOutputSchemaDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestOutputSchemaDiscriminatorType), TypeInfoPropertyName = "SearchRequestOutputSchemaDiscriminatorType2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchRequestContextVariant1>))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestContextVariant1))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.JsonValue), TypeInfoPropertyName = "JsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.JsonValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsOptionsTextVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1Verbosity), TypeInfoPropertyName = "ContentsOptionsTextVariant1Verbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item), TypeInfoPropertyName = "ContentsOptionsTextVariant1IncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item), TypeInfoPropertyName = "ContentsOptionsTextVariant1ExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsOptionsHighlightsVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsHighlightsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsHighlightsVariant1Verbosity), TypeInfoPropertyName = "ContentsOptionsHighlightsVariant1Verbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsExtras))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsOptionsContextVariant1>))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsContextVariant1))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsLivecrawl), TypeInfoPropertyName = "ContentsOptionsLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestCompliance), TypeInfoPropertyName = "ContentsRequestCompliance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsRequestTextVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1Verbosity), TypeInfoPropertyName = "ContentsRequestTextVariant1Verbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item), TypeInfoPropertyName = "ContentsRequestTextVariant1IncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item), TypeInfoPropertyName = "ContentsRequestTextVariant1ExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsRequestHighlightsVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestHighlightsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestHighlightsVariant1Verbosity), TypeInfoPropertyName = "ContentsRequestHighlightsVariant1Verbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestExtras))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsRequestContextVariant1>))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestContextVariant1))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestLivecrawl), TypeInfoPropertyName = "ContentsRequestLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerRequestModel), TypeInfoPropertyName = "AnswerRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::Exa.AnswerRequestUserLocationVariant1Variant2, global::Exa.AnswerRequestUserLocationVariant1Variant3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerRequestUserLocationVariant1Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerRequestUserLocationVariant1Variant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerRequestOutputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarRequestCategory), TypeInfoPropertyName = "FindSimilarRequestCategory2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsLivecrawl?, string>), TypeInfoPropertyName = "OneOfSearchMonitorContentsLivecrawlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsLivecrawl), TypeInfoPropertyName = "SearchMonitorContentsLivecrawl2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsContext>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsContext2")]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsContext))]
    #pragma warning restore CS0618
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentEffort), TypeInfoPropertyName = "AgentEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentDataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentBudget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSourceProvider), TypeInfoPropertyName = "AgentDataSourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.BatchRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchRequestItemUrl), TypeInfoPropertyName = "BatchRequestItemUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamTextDeltaChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AnswerStreamTextDeltaChunkChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamTextDeltaChunkChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamTextDeltaChunkChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponse), TypeInfoPropertyName = "SearchResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchSynthesisResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CostDollarsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchWarningOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchWarningOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchNoticeOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchNoticeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchSynthesisOutputOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.X402PaymentChallenge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.X402PaymentChallengeResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsResponseStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuseStatus), TypeInfoPropertyName = "ContentsResponseStatuseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuseSource), TypeInfoPropertyName = "ContentsResponseStatuseSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>), TypeInfoPropertyName = "OneOfStringDictionaryStringJsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AnswerResponseCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerResponseCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.FindSimilarResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.FindSimilarResultSubpage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResultSubpage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.FindSimilarResultEntitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResultEntitie), TypeInfoPropertyName = "FindSimilarResultEntitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPublicationEntityOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResultEntitieDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResultEntitieDiscriminatorType), TypeInfoPropertyName = "FindSimilarResultEntitieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResultExtras))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichImageLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResultExtrasRichImageLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResultExtrasRichLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasCodeBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResultExtrasCodeBlock))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListSearchMonitorRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunStatus), TypeInfoPropertyName = "SearchMonitorRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunFailReason), TypeInfoPropertyName = "SearchMonitorRunFailReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence), TypeInfoPropertyName = "SearchMonitorRunOutputGroundingVariant1ItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunStatus), TypeInfoPropertyName = "AgentRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentStopReason), TypeInfoPropertyName = "AgentStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentCostDollars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentDataSourceOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSourceOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentBudgetOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentGrounding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentGrounding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentGroundingConfidence), TypeInfoPropertyName = "AgentGroundingConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorType), TypeInfoPropertyName = "AgentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorCode), TypeInfoPropertyName = "AgentErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.DeleteAgentRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunEventList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentRunEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Batch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchStatus), TypeInfoPropertyName = "BatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchRequestCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.DeletedBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetsTeamInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetsTeamInfoConcurrency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetsTeamInfoLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunk), TypeInfoPropertyName = "AnswerStreamChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamCitationsChunkOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamCostChunkOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamErrorChunkOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunk), TypeInfoPropertyName = "SearchStreamChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamTextDeltaChunkOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamGroundingChunkOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamResultsChunkOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamResetChunkOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamDoneChunkOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamErrorChunkOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkDiscriminatorType), TypeInfoPropertyName = "SearchStreamChunkDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunEventEvent), TypeInfoPropertyName = "AgentRunEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutputSubpage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputSubpage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitie), TypeInfoPropertyName = "SearchResultOutputEntitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieDiscriminatorType), TypeInfoPropertyName = "SearchResultOutputEntitieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputExtras))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasRichImageLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputExtrasRichImageLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasRichLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputExtrasRichLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasCodeBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputExtrasCodeBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesWorkforce))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesHeadquarters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesFinancials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesFinancialsFundingLatestRound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesWebTraffic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesWebTrafficHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesWebTrafficHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesResearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWork>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWork))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType), TypeInfoPropertyName = "SearchCompanyEntityOutputPropertiesResearchNotableWorkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcher>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcher))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcherPerson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutputProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemDates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemCompany))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemDates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemInstitution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutputPropertiesResearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWork>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWork))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWorkType), TypeInfoPropertyName = "SearchPersonEntityOutputPropertiesResearchNotableWorkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPublicationEntityOutputProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPublicationEntityOutputPropertiesType), TypeInfoPropertyName = "SearchPublicationEntityOutputPropertiesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchPublicationEntityOutputPropertiesAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPublicationEntityOutputPropertiesAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CostDollarsOutputSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CostDollarsOutputContents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchSynthesisOutputOutputGroundingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchSynthesisOutputOutputGroundingItemCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence), TypeInfoPropertyName = "SearchSynthesisOutputOutputGroundingItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamTextDeltaChunkOutputChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamTextDeltaChunkOutputChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamTextDeltaChunkOutputChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamTextDeltaChunkOutputChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamTextDeltaChunkOutputChoiceDeltaCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputGroundingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamGroundingChunkOutputGroundingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputGroundingItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamGroundingChunkOutputGroundingItemCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamGroundingChunkOutputGroundingItemConfidence), TypeInfoPropertyName = "SearchStreamGroundingChunkOutputGroundingItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamGroundingChunkOutputCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamGroundingChunkOutputChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamGroundingChunkOutputChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamDoneChunkOutputChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamDoneChunkOutputChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamDoneChunkOutputChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamDoneChunkOutputChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamDoneChunkOutputChoiceDeltaCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamErrorChunkOutputError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AnswerStreamCitationsChunkOutputCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamCitationsChunkOutputCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamErrorChunkOutputPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamErrorChunkOutputPayloadError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>), TypeInfoPropertyName = "OneOfSearchMonitorContentsOutputLivecrawlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputLivecrawl), TypeInfoPropertyName = "SearchMonitorContentsOutputLivecrawl2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputContext>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsOutputContext2")]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputContext))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OutputSchemaTextOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType), TypeInfoPropertyName = "SearchMonitorOutputSchemaOutputVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookOutputEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookOutputEvent), TypeInfoPropertyName = "SearchMonitorWebhookOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Entity), TypeInfoPropertyName = "Entity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateCriterionParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateCriterionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersSearchExcludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersSearchExcludeItemSource), TypeInfoPropertyName = "CreateWebsetParametersSearchExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchScopeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersSearchScopeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersSearchScopeItemSource), TypeInfoPropertyName = "CreateWebsetParametersSearchScopeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersSearchScopeItemRelationship))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersImportItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersImportItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersImportItemSource), TypeInfoPropertyName = "CreateWebsetParametersImportItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateEnrichmentParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersExcludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersExcludeItemSource), TypeInfoPropertyName = "CreateWebsetParametersExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CompanyEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PersonEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ArticleEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchPaperEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CustomEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichmentFormat), TypeInfoPropertyName = "WebsetEnrichmentFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParametersOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateEnrichmentParametersOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateWebsetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersExcludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersExcludeItemSource), TypeInfoPropertyName = "CreateWebsetSearchParametersExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersScopeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersScopeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersScopeItemSource), TypeInfoPropertyName = "CreateWebsetSearchParametersScopeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersScopeItemRelationship))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchBehavior), TypeInfoPropertyName = "WebsetSearchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateEnrichmentParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.UpdateEnrichmentParametersOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateEnrichmentParametersOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetParametersSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateMonitorParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorCadence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehavior))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.MonitorBehaviorConfigCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfigCriteriaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateMonitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateMonitorStatus), TypeInfoPropertyName = "UpdateMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParameters), TypeInfoPropertyName = "CreateImportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1Format), TypeInfoPropertyName = "CreateImportParametersVariant1Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1Csv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersDiscriminatorFormat), TypeInfoPropertyName = "CreateImportParametersDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebhookParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.EventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventType), TypeInfoPropertyName = "EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateWebhookParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Webset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetStatus), TypeInfoPropertyName = "WebsetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetSearch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Import>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Import))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetEnrichment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Monitor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Monitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetExclude>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetExclude))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetExcludeSource), TypeInfoPropertyName = "WebsetExcludeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchStatus), TypeInfoPropertyName = "WebsetSearchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetSearchCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchCriteriaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetSearchExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchExcludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchExcludeItemSource), TypeInfoPropertyName = "WebsetSearchExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetSearchScopeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchScopeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchScopeItemSource), TypeInfoPropertyName = "WebsetSearchScopeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchScopeItemRelationship))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchRecall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchRecallExpected))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchRecallExpectedConfidence), TypeInfoPropertyName = "WebsetSearchRecallExpectedConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchRecallExpectedBounds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchCanceledReason), TypeInfoPropertyName = "WebsetSearchCanceledReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportObject), TypeInfoPropertyName = "ImportObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportStatus), TypeInfoPropertyName = "ImportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFormat), TypeInfoPropertyName = "ImportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFailedReason), TypeInfoPropertyName = "ImportFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichmentStatus), TypeInfoPropertyName = "WebsetEnrichmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetEnrichmentOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichmentOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorObject), TypeInfoPropertyName = "MonitorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorStatus), TypeInfoPropertyName = "MonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunObject), TypeInfoPropertyName = "MonitorRunObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunStatus), TypeInfoPropertyName = "MonitorRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunType), TypeInfoPropertyName = "MonitorRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListWebsetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Webset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetWebsetResponse), TypeInfoPropertyName = "GetWebsetResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetWebsetResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemSource), TypeInfoPropertyName = "WebsetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemArticleProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemResearchPaperProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCustomProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.EnrichmentResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EnrichmentResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPerson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonCompany))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemDates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemCompany))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemDates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompany))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyHeadquarters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyFinancials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyWebTraffic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemArticlePropertiesArticle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemResearchPaperPropertiesResearchPaper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCustomPropertiesCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemEvaluationSatisfied), TypeInfoPropertyName = "WebsetItemEvaluationSatisfied2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluationReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemEvaluationReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EnrichmentResultStatus), TypeInfoPropertyName = "EnrichmentResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.EnrichmentResultReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EnrichmentResultReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListWebsetItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>), TypeInfoPropertyName = "OneOfCompanyEntityPersonEntityArticleEntityResearchPaperEntityCustomEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseSearchCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseSearchCriteriaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichment))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>), TypeInfoPropertyName = "WebsetItemCustomProperties_976e7369ebb8440c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>?), TypeInfoPropertyName = "WebsetItemCustomProperties_2a7882e053a7bb38")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat), TypeInfoPropertyName = "PreviewWebsetResponseEnrichmentFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichmentOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichmentOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItemPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListMonitorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListMonitorRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.MonitorRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseObject), TypeInfoPropertyName = "CreateImportResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseStatus), TypeInfoPropertyName = "CreateImportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFormat), TypeInfoPropertyName = "CreateImportResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFailedReason), TypeInfoPropertyName = "CreateImportResponseFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListImportsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Webhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebhookStatus), TypeInfoPropertyName = "WebhookStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListWebhooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListWebhookAttemptsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebhookAttempt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebhookAttempt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Event), TypeInfoPropertyName = "Event2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventWebsetCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventWebsetDeletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventWebsetIdleEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventWebsetPausedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventWebsetItemCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventWebsetItemEnrichedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventWebsetSearchCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventWebsetSearchUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventWebsetSearchCanceledEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventWebsetSearchCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventImportCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventImportCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventMonitorCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventMonitorUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventMonitorDeletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventMonitorRunCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventMonitorRunCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventDiscriminatorType), TypeInfoPropertyName = "EventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListMonitorsStatus), TypeInfoPropertyName = "ListMonitorsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunAccept), TypeInfoPropertyName = "CreateAgentRunAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListAgentRunEventsAccept), TypeInfoPropertyName = "ListAgentRunEventsAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateBatchExaBeta), TypeInfoPropertyName = "CreateBatchExaBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListBatchesExaBeta), TypeInfoPropertyName = "ListBatchesExaBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetBatchExaBeta), TypeInfoPropertyName = "GetBatchExaBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.DeleteBatchExaBeta), TypeInfoPropertyName = "DeleteBatchExaBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CancelBatchExaBeta), TypeInfoPropertyName = "CancelBatchExaBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetsGetExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetsGetExpandItem), TypeInfoPropertyName = "WebsetsGetExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.EventsListType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventsListType), TypeInfoPropertyName = "EventsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.ErrorResponse, global::Exa.X402PaymentChallenge>), TypeInfoPropertyName = "OneOfErrorResponseX402PaymentChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestCategory?), TypeInfoPropertyName = "NullableSearchRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestCompliance?), TypeInfoPropertyName = "NullableSearchRequestCompliance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestOutputSchemaDiscriminatorType?), TypeInfoPropertyName = "NullableSearchRequestOutputSchemaDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.JsonValue?), TypeInfoPropertyName = "NullableJsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1Verbosity?), TypeInfoPropertyName = "NullableContentsOptionsTextVariant1Verbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableContentsOptionsTextVariant1IncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableContentsOptionsTextVariant1ExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsHighlightsVariant1Verbosity?), TypeInfoPropertyName = "NullableContentsOptionsHighlightsVariant1Verbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsLivecrawl?), TypeInfoPropertyName = "NullableContentsOptionsLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestCompliance?), TypeInfoPropertyName = "NullableContentsRequestCompliance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1Verbosity?), TypeInfoPropertyName = "NullableContentsRequestTextVariant1Verbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableContentsRequestTextVariant1IncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableContentsRequestTextVariant1ExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestHighlightsVariant1Verbosity?), TypeInfoPropertyName = "NullableContentsRequestHighlightsVariant1Verbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestLivecrawl?), TypeInfoPropertyName = "NullableContentsRequestLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerRequestModel?), TypeInfoPropertyName = "NullableAnswerRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarRequestCategory?), TypeInfoPropertyName = "NullableFindSimilarRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsText>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextVerbosity?), TypeInfoPropertyName = "NullableSearchMonitorContentsTextVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsTextIncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsTextExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsHighlights>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsHighlights2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsHighlightsVerbosity?), TypeInfoPropertyName = "NullableSearchMonitorContentsHighlightsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptions>?), TypeInfoPropertyName = "NullableOneOfBooleanSummaryWithMaxTokensOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsLivecrawl?, string>?), TypeInfoPropertyName = "NullableOneOfSearchMonitorContentsLivecrawlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsLivecrawl?), TypeInfoPropertyName = "NullableSearchMonitorContentsLivecrawl2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsContext>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsContext2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableSearchMonitorOutputSchemaVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookEvent?), TypeInfoPropertyName = "NullableSearchMonitorWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestAction?), TypeInfoPropertyName = "NullableBatchMonitorsRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestFilterStatus?), TypeInfoPropertyName = "NullableBatchMonitorsRequestFilterStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersStatus?), TypeInfoPropertyName = "NullableUpdateSearchMonitorParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersWebhookEvent?), TypeInfoPropertyName = "NullableUpdateSearchMonitorParametersWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentEffort?), TypeInfoPropertyName = "NullableAgentEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSourceProvider?), TypeInfoPropertyName = "NullableAgentDataSourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchRequestItemUrl?), TypeInfoPropertyName = "NullableBatchRequestItemUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponse?), TypeInfoPropertyName = "NullableSearchResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuseStatus?), TypeInfoPropertyName = "NullableContentsResponseStatuseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuseSource?), TypeInfoPropertyName = "NullableContentsResponseStatuseSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>?), TypeInfoPropertyName = "NullableOneOfStringDictionaryStringJsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResultEntitie?), TypeInfoPropertyName = "NullableFindSimilarResultEntitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResultEntitieDiscriminatorType?), TypeInfoPropertyName = "NullableFindSimilarResultEntitieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateSearchMonitorResponseStatus?), TypeInfoPropertyName = "NullableCreateSearchMonitorResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorStatus?), TypeInfoPropertyName = "NullableSearchMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsResponseAction?), TypeInfoPropertyName = "NullableBatchMonitorsResponseAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunStatus?), TypeInfoPropertyName = "NullableSearchMonitorRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunFailReason?), TypeInfoPropertyName = "NullableSearchMonitorRunFailReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence?), TypeInfoPropertyName = "NullableSearchMonitorRunOutputGroundingVariant1ItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunStatus?), TypeInfoPropertyName = "NullableAgentRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentStopReason?), TypeInfoPropertyName = "NullableAgentStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentGroundingConfidence?), TypeInfoPropertyName = "NullableAgentGroundingConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorType?), TypeInfoPropertyName = "NullableAgentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorCode?), TypeInfoPropertyName = "NullableAgentErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchStatus?), TypeInfoPropertyName = "NullableBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunk?), TypeInfoPropertyName = "NullableAnswerStreamChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunk?), TypeInfoPropertyName = "NullableSearchStreamChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkDiscriminatorType?), TypeInfoPropertyName = "NullableSearchStreamChunkDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunEventEvent?), TypeInfoPropertyName = "NullableAgentRunEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitie?), TypeInfoPropertyName = "NullableSearchResultOutputEntitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieDiscriminatorType?), TypeInfoPropertyName = "NullableSearchResultOutputEntitieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType?), TypeInfoPropertyName = "NullableSearchCompanyEntityOutputPropertiesResearchNotableWorkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWorkType?), TypeInfoPropertyName = "NullableSearchPersonEntityOutputPropertiesResearchNotableWorkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchPublicationEntityOutputPropertiesType?), TypeInfoPropertyName = "NullableSearchPublicationEntityOutputPropertiesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence?), TypeInfoPropertyName = "NullableSearchSynthesisOutputOutputGroundingItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamGroundingChunkOutputGroundingItemConfidence?), TypeInfoPropertyName = "NullableSearchStreamGroundingChunkOutputGroundingItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputText>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsOutputText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextVerbosity?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputTextVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputTextIncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputTextExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputHighlights>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsOutputHighlights2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputHighlightsVerbosity?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputHighlightsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptionsOutput>?), TypeInfoPropertyName = "NullableOneOfBooleanSummaryWithMaxTokensOptionsOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>?), TypeInfoPropertyName = "NullableOneOfSearchMonitorContentsOutputLivecrawlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputLivecrawl?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputLivecrawl2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputContext>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsOutputContext2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableSearchMonitorOutputSchemaOutputVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookOutputEvent?), TypeInfoPropertyName = "NullableSearchMonitorWebhookOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Entity?), TypeInfoPropertyName = "NullableEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersSearchExcludeItemSource?), TypeInfoPropertyName = "NullableCreateWebsetParametersSearchExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersSearchScopeItemSource?), TypeInfoPropertyName = "NullableCreateWebsetParametersSearchScopeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersImportItemSource?), TypeInfoPropertyName = "NullableCreateWebsetParametersImportItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersExcludeItemSource?), TypeInfoPropertyName = "NullableCreateWebsetParametersExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichmentFormat?), TypeInfoPropertyName = "NullableWebsetEnrichmentFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersExcludeItemSource?), TypeInfoPropertyName = "NullableCreateWebsetSearchParametersExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersScopeItemSource?), TypeInfoPropertyName = "NullableCreateWebsetSearchParametersScopeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchBehavior?), TypeInfoPropertyName = "NullableWebsetSearchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateMonitorStatus?), TypeInfoPropertyName = "NullableUpdateMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParameters?), TypeInfoPropertyName = "NullableCreateImportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1Format?), TypeInfoPropertyName = "NullableCreateImportParametersVariant1Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersDiscriminatorFormat?), TypeInfoPropertyName = "NullableCreateImportParametersDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventType?), TypeInfoPropertyName = "NullableEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetStatus?), TypeInfoPropertyName = "NullableWebsetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetExcludeSource?), TypeInfoPropertyName = "NullableWebsetExcludeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchStatus?), TypeInfoPropertyName = "NullableWebsetSearchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchExcludeItemSource?), TypeInfoPropertyName = "NullableWebsetSearchExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchScopeItemSource?), TypeInfoPropertyName = "NullableWebsetSearchScopeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchRecallExpectedConfidence?), TypeInfoPropertyName = "NullableWebsetSearchRecallExpectedConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchCanceledReason?), TypeInfoPropertyName = "NullableWebsetSearchCanceledReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportObject?), TypeInfoPropertyName = "NullableImportObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportStatus?), TypeInfoPropertyName = "NullableImportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFormat?), TypeInfoPropertyName = "NullableImportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFailedReason?), TypeInfoPropertyName = "NullableImportFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichmentStatus?), TypeInfoPropertyName = "NullableWebsetEnrichmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorObject?), TypeInfoPropertyName = "NullableMonitorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorStatus?), TypeInfoPropertyName = "NullableMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunObject?), TypeInfoPropertyName = "NullableMonitorRunObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunStatus?), TypeInfoPropertyName = "NullableMonitorRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunType?), TypeInfoPropertyName = "NullableMonitorRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetWebsetResponse?), TypeInfoPropertyName = "NullableGetWebsetResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemSource?), TypeInfoPropertyName = "NullableWebsetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemEvaluationSatisfied?), TypeInfoPropertyName = "NullableWebsetItemEvaluationSatisfied2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EnrichmentResultStatus?), TypeInfoPropertyName = "NullableEnrichmentResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>?), TypeInfoPropertyName = "NullableOneOfCompanyEntityPersonEntityArticleEntityResearchPaperEntityCustomEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat?), TypeInfoPropertyName = "NullablePreviewWebsetResponseEnrichmentFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseObject?), TypeInfoPropertyName = "NullableCreateImportResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseStatus?), TypeInfoPropertyName = "NullableCreateImportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFormat?), TypeInfoPropertyName = "NullableCreateImportResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFailedReason?), TypeInfoPropertyName = "NullableCreateImportResponseFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebhookStatus?), TypeInfoPropertyName = "NullableWebhookStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Event?), TypeInfoPropertyName = "NullableEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventDiscriminatorType?), TypeInfoPropertyName = "NullableEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListMonitorsStatus?), TypeInfoPropertyName = "NullableListMonitorsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunAccept?), TypeInfoPropertyName = "NullableCreateAgentRunAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListAgentRunEventsAccept?), TypeInfoPropertyName = "NullableListAgentRunEventsAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateBatchExaBeta?), TypeInfoPropertyName = "NullableCreateBatchExaBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListBatchesExaBeta?), TypeInfoPropertyName = "NullableListBatchesExaBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetBatchExaBeta?), TypeInfoPropertyName = "NullableGetBatchExaBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.DeleteBatchExaBeta?), TypeInfoPropertyName = "NullableDeleteBatchExaBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CancelBatchExaBeta?), TypeInfoPropertyName = "NullableCancelBatchExaBeta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetsGetExpandItem?), TypeInfoPropertyName = "NullableWebsetsGetExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventsListType?), TypeInfoPropertyName = "NullableEventsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.ErrorResponse, global::Exa.X402PaymentChallenge>?), TypeInfoPropertyName = "NullableOneOfErrorResponseX402PaymentChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.JsonValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.UpdateSearchMonitorParametersWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentDataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.BatchRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AnswerStreamTextDeltaChunkChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchWarningOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchNoticeOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsResponseStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AnswerResponseCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.FindSimilarResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.FindSimilarResultSubpage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.FindSimilarResultEntitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.FindSimilarResultExtrasRichImageLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.FindSimilarResultExtrasRichLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.FindSimilarResultExtrasCodeBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentDataSourceOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentGrounding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentRunEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutputSubpage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutputEntitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutputExtrasRichImageLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutputExtrasRichLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutputExtrasCodeBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchCompanyEntityOutputPropertiesWebTrafficHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWork>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcher>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWork>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchPublicationEntityOutputPropertiesAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchSynthesisOutputOutputGroundingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchSynthesisOutputOutputGroundingItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamTextDeltaChunkOutputChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamTextDeltaChunkOutputChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputGroundingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputGroundingItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamDoneChunkOutputChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamDoneChunkOutputChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AnswerStreamCitationsChunkOutputCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorWebhookOutputEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateCriterionParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersSearchExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersSearchScopeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersImportItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateEnrichmentParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateEnrichmentParametersOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetSearchParametersExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetSearchParametersScopeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.UpdateEnrichmentParametersOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.MonitorBehaviorConfigCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.EventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetSearch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Import>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetEnrichment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Monitor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetExclude>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetSearchCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetSearchExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetSearchScopeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetEnrichmentOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Webset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.EnrichmentResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemEvaluationReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.EnrichmentResultReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseSearchCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseEnrichment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseEnrichmentOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.MonitorRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebhookAttempt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetsGetExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.EventsListType>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                internal static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Exa.JsonConverters.SearchRequestOutputSchemaJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.JsonValueJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorOutputSchemaVariant1JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchResponseJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.FindSimilarResultEntitieJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AnswerStreamChunkJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchStreamChunkJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchResultOutputEntitieJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorOutputSchemaOutputVariant1JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EntityJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportParametersJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.GetWebsetResponseJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EventJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::Exa.SearchRequestUserLocationVariant1Variant2, global::Exa.SearchRequestUserLocationVariant1Variant3>());
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchRequestContextVariant1>());
            #pragma warning restore CS0618
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsTextVariant1>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsHighlightsVariant1>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsContextVariant1>());
            #pragma warning restore CS0618
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestTextVariant1>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestHighlightsVariant1>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestContextVariant1>());
            #pragma warning restore CS0618
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::Exa.AnswerRequestUserLocationVariant1Variant2, global::Exa.AnswerRequestUserLocationVariant1Variant3>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsText>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsHighlights>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SummaryWithMaxTokensOptions>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsLivecrawl?, string>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsContext>());
            #pragma warning restore CS0618
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputText>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputHighlights>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SummaryWithMaxTokensOptionsOutput>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputContext>());
            #pragma warning restore CS0618
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.ErrorResponse, global::Exa.X402PaymentChallenge>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.ErrorResponse, global::Exa.X402PaymentChallenge>());
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
                    typeToConvert == typeof(global::Exa.SearchRequestCategory)

                    || typeToConvert == typeof(global::Exa.SearchRequestCategory?)

                    || typeToConvert == typeof(global::Exa.SearchRequestCompliance)

                    || typeToConvert == typeof(global::Exa.SearchRequestCompliance?)

                    || typeToConvert == typeof(global::Exa.SearchRequestOutputSchemaDiscriminatorType)

                    || typeToConvert == typeof(global::Exa.SearchRequestOutputSchemaDiscriminatorType?)

                    || typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1Verbosity)

                    || typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1Verbosity?)

                    || typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item)

                    || typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item?)

                    || typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item)

                    || typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item?)

                    || typeToConvert == typeof(global::Exa.ContentsOptionsHighlightsVariant1Verbosity)

                    || typeToConvert == typeof(global::Exa.ContentsOptionsHighlightsVariant1Verbosity?)

                    || typeToConvert == typeof(global::Exa.ContentsOptionsLivecrawl)

                    || typeToConvert == typeof(global::Exa.ContentsOptionsLivecrawl?)

                    || typeToConvert == typeof(global::Exa.ContentsRequestCompliance)

                    || typeToConvert == typeof(global::Exa.ContentsRequestCompliance?)

                    || typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1Verbosity)

                    || typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1Verbosity?)

                    || typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item)

                    || typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item?)

                    || typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item)

                    || typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item?)

                    || typeToConvert == typeof(global::Exa.ContentsRequestHighlightsVariant1Verbosity)

                    || typeToConvert == typeof(global::Exa.ContentsRequestHighlightsVariant1Verbosity?)

                    || typeToConvert == typeof(global::Exa.ContentsRequestLivecrawl)

                    || typeToConvert == typeof(global::Exa.ContentsRequestLivecrawl?)

                    || typeToConvert == typeof(global::Exa.AnswerRequestModel)

                    || typeToConvert == typeof(global::Exa.AnswerRequestModel?)

                    || typeToConvert == typeof(global::Exa.FindSimilarRequestCategory)

                    || typeToConvert == typeof(global::Exa.FindSimilarRequestCategory?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorContentsTextVerbosity)

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

                    || typeToConvert == typeof(global::Exa.AgentEffort)

                    || typeToConvert == typeof(global::Exa.AgentEffort?)

                    || typeToConvert == typeof(global::Exa.AgentDataSourceProvider)

                    || typeToConvert == typeof(global::Exa.AgentDataSourceProvider?)

                    || typeToConvert == typeof(global::Exa.BatchRequestItemUrl)

                    || typeToConvert == typeof(global::Exa.BatchRequestItemUrl?)

                    || typeToConvert == typeof(global::Exa.ContentsResponseStatuseStatus)

                    || typeToConvert == typeof(global::Exa.ContentsResponseStatuseStatus?)

                    || typeToConvert == typeof(global::Exa.ContentsResponseStatuseSource)

                    || typeToConvert == typeof(global::Exa.ContentsResponseStatuseSource?)

                    || typeToConvert == typeof(global::Exa.FindSimilarResultEntitieDiscriminatorType)

                    || typeToConvert == typeof(global::Exa.FindSimilarResultEntitieDiscriminatorType?)

                    || typeToConvert == typeof(global::Exa.CreateSearchMonitorResponseStatus)

                    || typeToConvert == typeof(global::Exa.CreateSearchMonitorResponseStatus?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorStatus)

                    || typeToConvert == typeof(global::Exa.SearchMonitorStatus?)

                    || typeToConvert == typeof(global::Exa.BatchMonitorsResponseAction)

                    || typeToConvert == typeof(global::Exa.BatchMonitorsResponseAction?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorRunStatus)

                    || typeToConvert == typeof(global::Exa.SearchMonitorRunStatus?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorRunFailReason)

                    || typeToConvert == typeof(global::Exa.SearchMonitorRunFailReason?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence)

                    || typeToConvert == typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence?)

                    || typeToConvert == typeof(global::Exa.AgentRunStatus)

                    || typeToConvert == typeof(global::Exa.AgentRunStatus?)

                    || typeToConvert == typeof(global::Exa.AgentStopReason)

                    || typeToConvert == typeof(global::Exa.AgentStopReason?)

                    || typeToConvert == typeof(global::Exa.AgentGroundingConfidence)

                    || typeToConvert == typeof(global::Exa.AgentGroundingConfidence?)

                    || typeToConvert == typeof(global::Exa.AgentErrorType)

                    || typeToConvert == typeof(global::Exa.AgentErrorType?)

                    || typeToConvert == typeof(global::Exa.AgentErrorCode)

                    || typeToConvert == typeof(global::Exa.AgentErrorCode?)

                    || typeToConvert == typeof(global::Exa.BatchStatus)

                    || typeToConvert == typeof(global::Exa.BatchStatus?)

                    || typeToConvert == typeof(global::Exa.SearchStreamChunkDiscriminatorType)

                    || typeToConvert == typeof(global::Exa.SearchStreamChunkDiscriminatorType?)

                    || typeToConvert == typeof(global::Exa.AgentRunEventEvent)

                    || typeToConvert == typeof(global::Exa.AgentRunEventEvent?)

                    || typeToConvert == typeof(global::Exa.SearchResultOutputEntitieDiscriminatorType)

                    || typeToConvert == typeof(global::Exa.SearchResultOutputEntitieDiscriminatorType?)

                    || typeToConvert == typeof(global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType)

                    || typeToConvert == typeof(global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType?)

                    || typeToConvert == typeof(global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWorkType)

                    || typeToConvert == typeof(global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWorkType?)

                    || typeToConvert == typeof(global::Exa.SearchPublicationEntityOutputPropertiesType)

                    || typeToConvert == typeof(global::Exa.SearchPublicationEntityOutputPropertiesType?)

                    || typeToConvert == typeof(global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence)

                    || typeToConvert == typeof(global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence?)

                    || typeToConvert == typeof(global::Exa.SearchStreamGroundingChunkOutputGroundingItemConfidence)

                    || typeToConvert == typeof(global::Exa.SearchStreamGroundingChunkOutputGroundingItemConfidence?)

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

                    || typeToConvert == typeof(global::Exa.CreateWebsetParametersSearchExcludeItemSource)

                    || typeToConvert == typeof(global::Exa.CreateWebsetParametersSearchExcludeItemSource?)

                    || typeToConvert == typeof(global::Exa.CreateWebsetParametersSearchScopeItemSource)

                    || typeToConvert == typeof(global::Exa.CreateWebsetParametersSearchScopeItemSource?)

                    || typeToConvert == typeof(global::Exa.CreateWebsetParametersImportItemSource)

                    || typeToConvert == typeof(global::Exa.CreateWebsetParametersImportItemSource?)

                    || typeToConvert == typeof(global::Exa.CreateWebsetParametersExcludeItemSource)

                    || typeToConvert == typeof(global::Exa.CreateWebsetParametersExcludeItemSource?)

                    || typeToConvert == typeof(global::Exa.WebsetEnrichmentFormat)

                    || typeToConvert == typeof(global::Exa.WebsetEnrichmentFormat?)

                    || typeToConvert == typeof(global::Exa.CreateWebsetSearchParametersExcludeItemSource)

                    || typeToConvert == typeof(global::Exa.CreateWebsetSearchParametersExcludeItemSource?)

                    || typeToConvert == typeof(global::Exa.CreateWebsetSearchParametersScopeItemSource)

                    || typeToConvert == typeof(global::Exa.CreateWebsetSearchParametersScopeItemSource?)

                    || typeToConvert == typeof(global::Exa.WebsetSearchBehavior)

                    || typeToConvert == typeof(global::Exa.WebsetSearchBehavior?)

                    || typeToConvert == typeof(global::Exa.UpdateMonitorStatus)

                    || typeToConvert == typeof(global::Exa.UpdateMonitorStatus?)

                    || typeToConvert == typeof(global::Exa.CreateImportParametersVariant1Format)

                    || typeToConvert == typeof(global::Exa.CreateImportParametersVariant1Format?)

                    || typeToConvert == typeof(global::Exa.CreateImportParametersDiscriminatorFormat)

                    || typeToConvert == typeof(global::Exa.CreateImportParametersDiscriminatorFormat?)

                    || typeToConvert == typeof(global::Exa.EventType)

                    || typeToConvert == typeof(global::Exa.EventType?)

                    || typeToConvert == typeof(global::Exa.WebsetStatus)

                    || typeToConvert == typeof(global::Exa.WebsetStatus?)

                    || typeToConvert == typeof(global::Exa.WebsetExcludeSource)

                    || typeToConvert == typeof(global::Exa.WebsetExcludeSource?)

                    || typeToConvert == typeof(global::Exa.WebsetSearchStatus)

                    || typeToConvert == typeof(global::Exa.WebsetSearchStatus?)

                    || typeToConvert == typeof(global::Exa.WebsetSearchExcludeItemSource)

                    || typeToConvert == typeof(global::Exa.WebsetSearchExcludeItemSource?)

                    || typeToConvert == typeof(global::Exa.WebsetSearchScopeItemSource)

                    || typeToConvert == typeof(global::Exa.WebsetSearchScopeItemSource?)

                    || typeToConvert == typeof(global::Exa.WebsetSearchRecallExpectedConfidence)

                    || typeToConvert == typeof(global::Exa.WebsetSearchRecallExpectedConfidence?)

                    || typeToConvert == typeof(global::Exa.WebsetSearchCanceledReason)

                    || typeToConvert == typeof(global::Exa.WebsetSearchCanceledReason?)

                    || typeToConvert == typeof(global::Exa.ImportObject)

                    || typeToConvert == typeof(global::Exa.ImportObject?)

                    || typeToConvert == typeof(global::Exa.ImportStatus)

                    || typeToConvert == typeof(global::Exa.ImportStatus?)

                    || typeToConvert == typeof(global::Exa.ImportFormat)

                    || typeToConvert == typeof(global::Exa.ImportFormat?)

                    || typeToConvert == typeof(global::Exa.ImportFailedReason)

                    || typeToConvert == typeof(global::Exa.ImportFailedReason?)

                    || typeToConvert == typeof(global::Exa.WebsetEnrichmentStatus)

                    || typeToConvert == typeof(global::Exa.WebsetEnrichmentStatus?)

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

                    || typeToConvert == typeof(global::Exa.WebsetItemSource)

                    || typeToConvert == typeof(global::Exa.WebsetItemSource?)

                    || typeToConvert == typeof(global::Exa.WebsetItemEvaluationSatisfied)

                    || typeToConvert == typeof(global::Exa.WebsetItemEvaluationSatisfied?)

                    || typeToConvert == typeof(global::Exa.EnrichmentResultStatus)

                    || typeToConvert == typeof(global::Exa.EnrichmentResultStatus?)

                    || typeToConvert == typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat)

                    || typeToConvert == typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat?)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseObject)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseObject?)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseStatus)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseStatus?)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseFormat)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseFormat?)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseFailedReason)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseFailedReason?)

                    || typeToConvert == typeof(global::Exa.WebhookStatus)

                    || typeToConvert == typeof(global::Exa.WebhookStatus?)

                    || typeToConvert == typeof(global::Exa.EventDiscriminatorType)

                    || typeToConvert == typeof(global::Exa.EventDiscriminatorType?)

                    || typeToConvert == typeof(global::Exa.ListMonitorsStatus)

                    || typeToConvert == typeof(global::Exa.ListMonitorsStatus?)

                    || typeToConvert == typeof(global::Exa.CreateAgentRunAccept)

                    || typeToConvert == typeof(global::Exa.CreateAgentRunAccept?)

                    || typeToConvert == typeof(global::Exa.ListAgentRunEventsAccept)

                    || typeToConvert == typeof(global::Exa.ListAgentRunEventsAccept?)

                    || typeToConvert == typeof(global::Exa.CreateBatchExaBeta)

                    || typeToConvert == typeof(global::Exa.CreateBatchExaBeta?)

                    || typeToConvert == typeof(global::Exa.ListBatchesExaBeta)

                    || typeToConvert == typeof(global::Exa.ListBatchesExaBeta?)

                    || typeToConvert == typeof(global::Exa.GetBatchExaBeta)

                    || typeToConvert == typeof(global::Exa.GetBatchExaBeta?)

                    || typeToConvert == typeof(global::Exa.DeleteBatchExaBeta)

                    || typeToConvert == typeof(global::Exa.DeleteBatchExaBeta?)

                    || typeToConvert == typeof(global::Exa.CancelBatchExaBeta)

                    || typeToConvert == typeof(global::Exa.CancelBatchExaBeta?)

                    || typeToConvert == typeof(global::Exa.WebsetsGetExpandItem)

                    || typeToConvert == typeof(global::Exa.WebsetsGetExpandItem?)

                    || typeToConvert == typeof(global::Exa.EventsListType)

                    || typeToConvert == typeof(global::Exa.EventsListType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Exa.SearchRequestCategory))
                {
                    return new global::Exa.JsonConverters.SearchRequestCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchRequestCategory?))
                {
                    return new global::Exa.JsonConverters.SearchRequestCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchRequestCompliance))
                {
                    return new global::Exa.JsonConverters.SearchRequestComplianceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchRequestCompliance?))
                {
                    return new global::Exa.JsonConverters.SearchRequestComplianceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchRequestOutputSchemaDiscriminatorType))
                {
                    return new global::Exa.JsonConverters.SearchRequestOutputSchemaDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchRequestOutputSchemaDiscriminatorType?))
                {
                    return new global::Exa.JsonConverters.SearchRequestOutputSchemaDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1Verbosity))
                {
                    return new global::Exa.JsonConverters.ContentsOptionsTextVariant1VerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1Verbosity?))
                {
                    return new global::Exa.JsonConverters.ContentsOptionsTextVariant1VerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item))
                {
                    return new global::Exa.JsonConverters.ContentsOptionsTextVariant1IncludeSectionsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item?))
                {
                    return new global::Exa.JsonConverters.ContentsOptionsTextVariant1IncludeSectionsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item))
                {
                    return new global::Exa.JsonConverters.ContentsOptionsTextVariant1ExcludeSectionsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item?))
                {
                    return new global::Exa.JsonConverters.ContentsOptionsTextVariant1ExcludeSectionsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsOptionsHighlightsVariant1Verbosity))
                {
                    return new global::Exa.JsonConverters.ContentsOptionsHighlightsVariant1VerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsOptionsHighlightsVariant1Verbosity?))
                {
                    return new global::Exa.JsonConverters.ContentsOptionsHighlightsVariant1VerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsOptionsLivecrawl))
                {
                    return new global::Exa.JsonConverters.ContentsOptionsLivecrawlJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsOptionsLivecrawl?))
                {
                    return new global::Exa.JsonConverters.ContentsOptionsLivecrawlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestCompliance))
                {
                    return new global::Exa.JsonConverters.ContentsRequestComplianceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestCompliance?))
                {
                    return new global::Exa.JsonConverters.ContentsRequestComplianceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1Verbosity))
                {
                    return new global::Exa.JsonConverters.ContentsRequestTextVariant1VerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1Verbosity?))
                {
                    return new global::Exa.JsonConverters.ContentsRequestTextVariant1VerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item))
                {
                    return new global::Exa.JsonConverters.ContentsRequestTextVariant1IncludeSectionsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item?))
                {
                    return new global::Exa.JsonConverters.ContentsRequestTextVariant1IncludeSectionsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item))
                {
                    return new global::Exa.JsonConverters.ContentsRequestTextVariant1ExcludeSectionsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item?))
                {
                    return new global::Exa.JsonConverters.ContentsRequestTextVariant1ExcludeSectionsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestHighlightsVariant1Verbosity))
                {
                    return new global::Exa.JsonConverters.ContentsRequestHighlightsVariant1VerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestHighlightsVariant1Verbosity?))
                {
                    return new global::Exa.JsonConverters.ContentsRequestHighlightsVariant1VerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestLivecrawl))
                {
                    return new global::Exa.JsonConverters.ContentsRequestLivecrawlJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsRequestLivecrawl?))
                {
                    return new global::Exa.JsonConverters.ContentsRequestLivecrawlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AnswerRequestModel))
                {
                    return new global::Exa.JsonConverters.AnswerRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AnswerRequestModel?))
                {
                    return new global::Exa.JsonConverters.AnswerRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.FindSimilarRequestCategory))
                {
                    return new global::Exa.JsonConverters.FindSimilarRequestCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.FindSimilarRequestCategory?))
                {
                    return new global::Exa.JsonConverters.FindSimilarRequestCategoryNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Exa.AgentEffort))
                {
                    return new global::Exa.JsonConverters.AgentEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentEffort?))
                {
                    return new global::Exa.JsonConverters.AgentEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentDataSourceProvider))
                {
                    return new global::Exa.JsonConverters.AgentDataSourceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentDataSourceProvider?))
                {
                    return new global::Exa.JsonConverters.AgentDataSourceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.BatchRequestItemUrl))
                {
                    return new global::Exa.JsonConverters.BatchRequestItemUrlJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.BatchRequestItemUrl?))
                {
                    return new global::Exa.JsonConverters.BatchRequestItemUrlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsResponseStatuseStatus))
                {
                    return new global::Exa.JsonConverters.ContentsResponseStatuseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsResponseStatuseStatus?))
                {
                    return new global::Exa.JsonConverters.ContentsResponseStatuseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsResponseStatuseSource))
                {
                    return new global::Exa.JsonConverters.ContentsResponseStatuseSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ContentsResponseStatuseSource?))
                {
                    return new global::Exa.JsonConverters.ContentsResponseStatuseSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.FindSimilarResultEntitieDiscriminatorType))
                {
                    return new global::Exa.JsonConverters.FindSimilarResultEntitieDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.FindSimilarResultEntitieDiscriminatorType?))
                {
                    return new global::Exa.JsonConverters.FindSimilarResultEntitieDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Exa.SearchMonitorRunStatus))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorRunStatus?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorRunFailReason))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunFailReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorRunFailReason?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunFailReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentRunStatus))
                {
                    return new global::Exa.JsonConverters.AgentRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentRunStatus?))
                {
                    return new global::Exa.JsonConverters.AgentRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentStopReason))
                {
                    return new global::Exa.JsonConverters.AgentStopReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentStopReason?))
                {
                    return new global::Exa.JsonConverters.AgentStopReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentGroundingConfidence))
                {
                    return new global::Exa.JsonConverters.AgentGroundingConfidenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentGroundingConfidence?))
                {
                    return new global::Exa.JsonConverters.AgentGroundingConfidenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentErrorType))
                {
                    return new global::Exa.JsonConverters.AgentErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentErrorType?))
                {
                    return new global::Exa.JsonConverters.AgentErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentErrorCode))
                {
                    return new global::Exa.JsonConverters.AgentErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentErrorCode?))
                {
                    return new global::Exa.JsonConverters.AgentErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.BatchStatus))
                {
                    return new global::Exa.JsonConverters.BatchStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.BatchStatus?))
                {
                    return new global::Exa.JsonConverters.BatchStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchStreamChunkDiscriminatorType))
                {
                    return new global::Exa.JsonConverters.SearchStreamChunkDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchStreamChunkDiscriminatorType?))
                {
                    return new global::Exa.JsonConverters.SearchStreamChunkDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentRunEventEvent))
                {
                    return new global::Exa.JsonConverters.AgentRunEventEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentRunEventEvent?))
                {
                    return new global::Exa.JsonConverters.AgentRunEventEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchResultOutputEntitieDiscriminatorType))
                {
                    return new global::Exa.JsonConverters.SearchResultOutputEntitieDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchResultOutputEntitieDiscriminatorType?))
                {
                    return new global::Exa.JsonConverters.SearchResultOutputEntitieDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType))
                {
                    return new global::Exa.JsonConverters.SearchCompanyEntityOutputPropertiesResearchNotableWorkTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType?))
                {
                    return new global::Exa.JsonConverters.SearchCompanyEntityOutputPropertiesResearchNotableWorkTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWorkType))
                {
                    return new global::Exa.JsonConverters.SearchPersonEntityOutputPropertiesResearchNotableWorkTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWorkType?))
                {
                    return new global::Exa.JsonConverters.SearchPersonEntityOutputPropertiesResearchNotableWorkTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchPublicationEntityOutputPropertiesType))
                {
                    return new global::Exa.JsonConverters.SearchPublicationEntityOutputPropertiesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchPublicationEntityOutputPropertiesType?))
                {
                    return new global::Exa.JsonConverters.SearchPublicationEntityOutputPropertiesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence))
                {
                    return new global::Exa.JsonConverters.SearchSynthesisOutputOutputGroundingItemConfidenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence?))
                {
                    return new global::Exa.JsonConverters.SearchSynthesisOutputOutputGroundingItemConfidenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchStreamGroundingChunkOutputGroundingItemConfidence))
                {
                    return new global::Exa.JsonConverters.SearchStreamGroundingChunkOutputGroundingItemConfidenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchStreamGroundingChunkOutputGroundingItemConfidence?))
                {
                    return new global::Exa.JsonConverters.SearchStreamGroundingChunkOutputGroundingItemConfidenceNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Exa.CreateWebsetParametersSearchExcludeItemSource))
                {
                    return new global::Exa.JsonConverters.CreateWebsetParametersSearchExcludeItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateWebsetParametersSearchExcludeItemSource?))
                {
                    return new global::Exa.JsonConverters.CreateWebsetParametersSearchExcludeItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateWebsetParametersSearchScopeItemSource))
                {
                    return new global::Exa.JsonConverters.CreateWebsetParametersSearchScopeItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateWebsetParametersSearchScopeItemSource?))
                {
                    return new global::Exa.JsonConverters.CreateWebsetParametersSearchScopeItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateWebsetParametersImportItemSource))
                {
                    return new global::Exa.JsonConverters.CreateWebsetParametersImportItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateWebsetParametersImportItemSource?))
                {
                    return new global::Exa.JsonConverters.CreateWebsetParametersImportItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateWebsetParametersExcludeItemSource))
                {
                    return new global::Exa.JsonConverters.CreateWebsetParametersExcludeItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateWebsetParametersExcludeItemSource?))
                {
                    return new global::Exa.JsonConverters.CreateWebsetParametersExcludeItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetEnrichmentFormat))
                {
                    return new global::Exa.JsonConverters.WebsetEnrichmentFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetEnrichmentFormat?))
                {
                    return new global::Exa.JsonConverters.WebsetEnrichmentFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateWebsetSearchParametersExcludeItemSource))
                {
                    return new global::Exa.JsonConverters.CreateWebsetSearchParametersExcludeItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateWebsetSearchParametersExcludeItemSource?))
                {
                    return new global::Exa.JsonConverters.CreateWebsetSearchParametersExcludeItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateWebsetSearchParametersScopeItemSource))
                {
                    return new global::Exa.JsonConverters.CreateWebsetSearchParametersScopeItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateWebsetSearchParametersScopeItemSource?))
                {
                    return new global::Exa.JsonConverters.CreateWebsetSearchParametersScopeItemSourceNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Exa.CreateImportParametersVariant1Format))
                {
                    return new global::Exa.JsonConverters.CreateImportParametersVariant1FormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportParametersVariant1Format?))
                {
                    return new global::Exa.JsonConverters.CreateImportParametersVariant1FormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportParametersDiscriminatorFormat))
                {
                    return new global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportParametersDiscriminatorFormat?))
                {
                    return new global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.EventType))
                {
                    return new global::Exa.JsonConverters.EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.EventType?))
                {
                    return new global::Exa.JsonConverters.EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetStatus))
                {
                    return new global::Exa.JsonConverters.WebsetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetStatus?))
                {
                    return new global::Exa.JsonConverters.WebsetStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetExcludeSource))
                {
                    return new global::Exa.JsonConverters.WebsetExcludeSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetExcludeSource?))
                {
                    return new global::Exa.JsonConverters.WebsetExcludeSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchStatus))
                {
                    return new global::Exa.JsonConverters.WebsetSearchStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchStatus?))
                {
                    return new global::Exa.JsonConverters.WebsetSearchStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchExcludeItemSource))
                {
                    return new global::Exa.JsonConverters.WebsetSearchExcludeItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchExcludeItemSource?))
                {
                    return new global::Exa.JsonConverters.WebsetSearchExcludeItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchScopeItemSource))
                {
                    return new global::Exa.JsonConverters.WebsetSearchScopeItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchScopeItemSource?))
                {
                    return new global::Exa.JsonConverters.WebsetSearchScopeItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchRecallExpectedConfidence))
                {
                    return new global::Exa.JsonConverters.WebsetSearchRecallExpectedConfidenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchRecallExpectedConfidence?))
                {
                    return new global::Exa.JsonConverters.WebsetSearchRecallExpectedConfidenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchCanceledReason))
                {
                    return new global::Exa.JsonConverters.WebsetSearchCanceledReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetSearchCanceledReason?))
                {
                    return new global::Exa.JsonConverters.WebsetSearchCanceledReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportObject))
                {
                    return new global::Exa.JsonConverters.ImportObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportObject?))
                {
                    return new global::Exa.JsonConverters.ImportObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportStatus))
                {
                    return new global::Exa.JsonConverters.ImportStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportStatus?))
                {
                    return new global::Exa.JsonConverters.ImportStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportFormat))
                {
                    return new global::Exa.JsonConverters.ImportFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportFormat?))
                {
                    return new global::Exa.JsonConverters.ImportFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportFailedReason))
                {
                    return new global::Exa.JsonConverters.ImportFailedReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportFailedReason?))
                {
                    return new global::Exa.JsonConverters.ImportFailedReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetEnrichmentStatus))
                {
                    return new global::Exa.JsonConverters.WebsetEnrichmentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetEnrichmentStatus?))
                {
                    return new global::Exa.JsonConverters.WebsetEnrichmentStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Exa.WebsetItemSource))
                {
                    return new global::Exa.JsonConverters.WebsetItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetItemSource?))
                {
                    return new global::Exa.JsonConverters.WebsetItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetItemEvaluationSatisfied))
                {
                    return new global::Exa.JsonConverters.WebsetItemEvaluationSatisfiedJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetItemEvaluationSatisfied?))
                {
                    return new global::Exa.JsonConverters.WebsetItemEvaluationSatisfiedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.EnrichmentResultStatus))
                {
                    return new global::Exa.JsonConverters.EnrichmentResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.EnrichmentResultStatus?))
                {
                    return new global::Exa.JsonConverters.EnrichmentResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat))
                {
                    return new global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat?))
                {
                    return new global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseObject))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseObject?))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseStatus))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseStatus?))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseFormat))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseFormat?))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseFailedReason))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseFailedReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseFailedReason?))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseFailedReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebhookStatus))
                {
                    return new global::Exa.JsonConverters.WebhookStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebhookStatus?))
                {
                    return new global::Exa.JsonConverters.WebhookStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.EventDiscriminatorType))
                {
                    return new global::Exa.JsonConverters.EventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.EventDiscriminatorType?))
                {
                    return new global::Exa.JsonConverters.EventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ListMonitorsStatus))
                {
                    return new global::Exa.JsonConverters.ListMonitorsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ListMonitorsStatus?))
                {
                    return new global::Exa.JsonConverters.ListMonitorsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateAgentRunAccept))
                {
                    return new global::Exa.JsonConverters.CreateAgentRunAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateAgentRunAccept?))
                {
                    return new global::Exa.JsonConverters.CreateAgentRunAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ListAgentRunEventsAccept))
                {
                    return new global::Exa.JsonConverters.ListAgentRunEventsAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ListAgentRunEventsAccept?))
                {
                    return new global::Exa.JsonConverters.ListAgentRunEventsAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateBatchExaBeta))
                {
                    return new global::Exa.JsonConverters.CreateBatchExaBetaJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateBatchExaBeta?))
                {
                    return new global::Exa.JsonConverters.CreateBatchExaBetaNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ListBatchesExaBeta))
                {
                    return new global::Exa.JsonConverters.ListBatchesExaBetaJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ListBatchesExaBeta?))
                {
                    return new global::Exa.JsonConverters.ListBatchesExaBetaNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.GetBatchExaBeta))
                {
                    return new global::Exa.JsonConverters.GetBatchExaBetaJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.GetBatchExaBeta?))
                {
                    return new global::Exa.JsonConverters.GetBatchExaBetaNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.DeleteBatchExaBeta))
                {
                    return new global::Exa.JsonConverters.DeleteBatchExaBetaJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.DeleteBatchExaBeta?))
                {
                    return new global::Exa.JsonConverters.DeleteBatchExaBetaNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CancelBatchExaBeta))
                {
                    return new global::Exa.JsonConverters.CancelBatchExaBetaJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CancelBatchExaBeta?))
                {
                    return new global::Exa.JsonConverters.CancelBatchExaBetaNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetsGetExpandItem))
                {
                    return new global::Exa.JsonConverters.WebsetsGetExpandItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.WebsetsGetExpandItem?))
                {
                    return new global::Exa.JsonConverters.WebsetsGetExpandItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.EventsListType))
                {
                    return new global::Exa.JsonConverters.EventsListTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.EventsListType?))
                {
                    return new global::Exa.JsonConverters.EventsListTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}