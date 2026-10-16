
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptions? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequestCategory? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<string, global::Exa.SearchRequestUserLocationVariant1Variant2, global::Exa.SearchRequestUserLocationVariant1Variant3>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequestUserLocationVariant1Variant2? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequestUserLocationVariant1Variant3? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequestCompliance? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequestOutputSchema? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OutputSchemaText? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OutputSchemaObject? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequestOutputSchemaDiscriminator? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequestOutputSchemaDiscriminatorType? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchRequestContextVariant1>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequestContextVariant1? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.JsonValue? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.JsonValue?>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.ContentsOptionsTextVariant1>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsTextVariant1? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsTextVariant1Verbosity? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.ContentsOptionsHighlightsVariant1>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsHighlightsVariant1? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsHighlightsVariant1Verbosity? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsSummary? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsExtras? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.ContentsOptionsContextVariant1>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsContextVariant1? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsLivecrawl? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequest? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestCompliance? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.ContentsRequestTextVariant1>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestTextVariant1? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestTextVariant1Verbosity? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.ContentsRequestHighlightsVariant1>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestHighlightsVariant1? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestHighlightsVariant1Verbosity? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestSummary? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestExtras? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.ContentsRequestContextVariant1>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestContextVariant1? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestLivecrawl? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerRequest? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerRequestModel? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<string, global::Exa.AnswerRequestUserLocationVariant1Variant2, global::Exa.AnswerRequestUserLocationVariant1Variant3>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerRequestUserLocationVariant1Variant2? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerRequestUserLocationVariant1Variant3? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerRequestOutputSchema? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarRequest? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarRequestCategory? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateSearchMonitorParameters? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorSearch? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorTrigger? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaVariant1? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorWebhook? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContents? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsText>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsText? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsTextVerbosity? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsHighlights>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsHighlights? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsHighlightsVerbosity? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptions>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SummaryWithMaxTokensOptions? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsExtras? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<global::Exa.SearchMonitorContentsLivecrawl?, string>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsLivecrawl? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsContext>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsContext? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaVariant1Discriminator? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaVariant1DiscriminatorType? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookEvent>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorWebhookEvent? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchMonitorsRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchMonitorsRequestAction? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchMonitorsRequestFilter? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchMonitorsRequestFilterStatus? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateSearchMonitorParameters? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateSearchMonitorParametersStatus? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateSearchMonitorParametersSearch? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateSearchMonitorParametersTrigger? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateSearchMonitorParametersWebhook? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.UpdateSearchMonitorParametersWebhookEvent>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateSearchMonitorParametersWebhookEvent? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateAgentRunRequest? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentEffort? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateAgentRunRequestInput? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentDataSource>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentDataSource? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentBudget? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentDataSourceProvider? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateBatchRequest? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.BatchRequestItem>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchRequestItem? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchRequestItemUrl? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamTextDeltaChunk? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AnswerStreamTextDeltaChunkChoice>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamTextDeltaChunkChoice? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamTextDeltaChunkChoiceDelta? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResponse? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisResponse? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultsResponse? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutput>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutput? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsOutput? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchWarningOutput>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchWarningOutput? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchNoticeOutput>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchNoticeOutput? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisOutputOutput? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ErrorResponse? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.X402PaymentChallenge? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.X402PaymentChallengeResource? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsResponse? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.ContentsResponseStatuse>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsResponseStatuse? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsResponseStatuseStatus? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsResponseStatuseSource? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsResponseStatuseError? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerResponse? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AnswerResponseCitation>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerResponseCitation? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResult>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResult? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultSubpage>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultSubpage? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultEntitie>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultEntitie? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutput? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutput? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutput? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultEntitieDiscriminator? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultEntitieDiscriminatorType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtras? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichImageLink>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtrasRichImageLink? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichLink>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtrasRichLink? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasCodeBlock>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtrasCodeBlock? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateSearchMonitorResponse? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateSearchMonitorResponseStatus? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorSearchOutput? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorTriggerOutput? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaOutputVariant1? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorWebhookOutput? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListSearchMonitorsResponse? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitor>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitor? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorStatus? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchMonitorsResponse? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchMonitorsResponseAction? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TriggerSearchMonitorResponse? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListSearchMonitorRunsResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorRun>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRun? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunStatus? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutput? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunFailReason? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutputGroundingVariant1Item? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRun? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunStatus? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentStopReason? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunRequest? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunOutput? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentUsage? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentCostDollars? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunRequestInput? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentDataSourceOutput>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentDataSourceOutput? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentBudgetOutput? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentGrounding>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentGrounding? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentCitation>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentCitation? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentGroundingConfidence? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentErrorResponse? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentError? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentErrorType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentErrorCode? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunList? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentRun>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.DeleteAgentRunResponse? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunEventList? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentRunEvent>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunEvent? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Batch? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchStatus? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchRequestCounts? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchList? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Batch>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.DeletedBatch? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetsTeamInfo? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetsTeamInfoConcurrency? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetsTeamInfoLimits? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamChunk? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamCitationsChunkOutput? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamCostChunkOutput? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamErrorChunkOutput? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamChunk? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutput? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutput? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamResultsChunkOutput? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamResetChunkOutput? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutput? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamErrorChunkOutput? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamChunkDiscriminator? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamChunkDiscriminatorType? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunEventEvent? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputSubpage>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputSubpage? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitie>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputEntitie? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputEntitieDiscriminator? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputEntitieDiscriminatorType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtras? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasRichImageLink>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtrasRichImageLink? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasRichLink>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtrasRichLink? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasCodeBlock>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtrasCodeBlock? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputProperties? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesWorkforce? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesHeadquarters? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesFinancials? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesFinancialsFundingLatestRound? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesWebTraffic? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesWebTrafficHistoryItem>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesWebTrafficHistoryItem? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearch? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWork>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWork? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcher>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcher? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcherPerson? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputProperties? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemDates? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemCompany? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemDates? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemInstitution? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesResearch? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWork>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWork? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWorkType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutputProperties? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutputPropertiesType? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPublicationEntityOutputPropertiesAuthor>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutputPropertiesAuthor? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsOutputSearch? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsOutputContents? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItem>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisOutputOutputGroundingItem? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItemCitation>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisOutputOutputGroundingItemCitation? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamTextDeltaChunkOutputChoice>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutputChoice? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutputChoiceDelta? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamTextDeltaChunkOutputChoiceDeltaCitation>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutputChoiceDeltaCitation? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputGroundingItem>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputGroundingItem? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputGroundingItemCitation>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputGroundingItemCitation? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputGroundingItemConfidence? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputCitation>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputCitation? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoice>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputChoice? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputChoiceDelta? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamDoneChunkOutputChoice>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutputChoice? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutputChoiceDelta? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamDoneChunkOutputChoiceDeltaCitation>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutputChoiceDeltaCitation? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamErrorChunkOutputError? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AnswerStreamCitationsChunkOutputCitation>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamCitationsChunkOutputCitation? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamErrorChunkOutputPayload? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamErrorChunkOutputPayloadError? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutput? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputText>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputText? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputTextVerbosity? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputHighlights>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputHighlights? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputHighlightsVerbosity? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptionsOutput>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SummaryWithMaxTokensOptionsOutput? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputExtras? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputLivecrawl? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputContext>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputContext? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OutputSchemaTextOutput? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaOutputVariant1Discriminator? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookOutputEvent>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorWebhookOutputEvent? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParameters? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearch? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Entity? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateCriterionParameters>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateCriterionParameters? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchExcludeItem>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchExcludeItem? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchExcludeItemSource? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchScopeItem>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchScopeItem? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchScopeItemSource? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchScopeItemRelationship? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersImportItem>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersImportItem? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersImportItemSource? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParameters>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateEnrichmentParameters? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersExcludeItem>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersExcludeItem? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersExcludeItemSource? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CompanyEntity? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PersonEntity? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ArticleEntity? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResearchPaperEntity? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CustomEntity? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichmentFormat? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParametersOption>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateEnrichmentParametersOption? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateWebsetRequest? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParameters? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersExcludeItem>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersExcludeItem? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersExcludeItemSource? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersScopeItem>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersScopeItem? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersScopeItemSource? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersScopeItemRelationship? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchBehavior? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateEnrichmentParameters? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.UpdateEnrichmentParametersOption>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateEnrichmentParametersOption? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetParameters? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetParametersSearch? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateMonitorParameters? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorCadence? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorBehavior? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorBehaviorConfig? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.MonitorBehaviorConfigCriteriaItem>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorBehaviorConfigCriteriaItem? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateMonitor? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateMonitorStatus? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParameters? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersVariant1? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersVariant1Format? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersVariant1Csv? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersDiscriminator? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersDiscriminatorFormat? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateImport? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebhookParameters? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EventType>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventType? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateWebhookParameters? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Webset? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetStatus? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearch>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearch? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Import>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Import? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetEnrichment>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichment? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Monitor>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Monitor? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetExclude>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetExclude? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetExcludeSource? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchStatus? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearchCriteriaItem>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchCriteriaItem? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearchExcludeItem>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchExcludeItem? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchExcludeItemSource? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearchScopeItem>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchScopeItem? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchScopeItemSource? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchScopeItemRelationship? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchProgress? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecall? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecallExpected? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecallExpectedConfidence? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecallExpectedBounds? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchCanceledReason? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportObject? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportStatus? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportFormat? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportFailedReason? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichmentStatus? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetEnrichmentOption>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichmentOption? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorObject? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorStatus? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRun? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRunObject? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRunStatus? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRunType? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebsetsResponse? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Webset>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetWebsetResponse? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetWebsetResponseVariant2? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItem>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItem? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemSource? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonProperties? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyProperties? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemArticleProperties? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemResearchPaperProperties? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCustomProperties? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluation>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemEvaluation? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EnrichmentResult>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EnrichmentResult? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPerson? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonCompany? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemDates? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemCompany? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemDates? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompany? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyHeadquarters? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyFinancials? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyWebTraffic? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemArticlePropertiesArticle? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemResearchPaperPropertiesResearchPaper? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCustomPropertiesCustom? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemEvaluationSatisfied? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluationReference>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemEvaluationReference? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EnrichmentResultStatus? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EnrichmentResultReference>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EnrichmentResultReference? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebsetItemResponse? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponse? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseSearch? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseSearchCriteriaItem>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseSearchCriteriaItem? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichment>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseEnrichment? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseEnrichmentFormat? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichmentOption>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseEnrichmentOption? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemPreview>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPreview? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListMonitorsResponse? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListMonitorRunsResponse? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.MonitorRun>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponse? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseObject? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseStatus? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseFormat? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseFailedReason? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListImportsResponse? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Webhook? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebhookStatus? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebhooksResponse? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Webhook>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebhookAttemptsResponse? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebhookAttempt>? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebhookAttempt? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListEventsResponse? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Event>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Event? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetCreatedEvent? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetDeletedEvent? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetIdleEvent? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetPausedEvent? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetItemCreatedEvent? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetItemEnrichedEvent? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchCreatedEvent? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchUpdatedEvent? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchCanceledEvent? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchCompletedEvent? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventImportCreatedEvent? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventImportCompletedEvent? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorCreatedEvent? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorUpdatedEvent? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorDeletedEvent? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorRunCreatedEvent? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorRunCompletedEvent? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventDiscriminator? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventDiscriminatorType? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListMonitorsStatus? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateAgentRunAccept? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListAgentRunEventsAccept? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateBatchExaBeta? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListBatchesExaBeta? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetBatchExaBeta? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.DeleteBatchExaBeta? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CancelBatchExaBeta? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetsGetExpandItem>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetsGetExpandItem? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EventsListType>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventsListType? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<global::Exa.ErrorResponse, global::Exa.X402PaymentChallenge>? Type550 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.JsonValue?>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<string, global::System.Collections.Generic.List<string>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorWebhookEvent>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.UpdateSearchMonitorParametersWebhookEvent>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AgentDataSource>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.BatchRequestItem>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AnswerStreamTextDeltaChunkChoice>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResultOutput>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchWarningOutput>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchNoticeOutput>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.ContentsResponseStatuse>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AnswerResponseCitation>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.FindSimilarResult>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.FindSimilarResultSubpage>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.FindSimilarResultEntitie>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.FindSimilarResultExtrasRichImageLink>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.FindSimilarResultExtrasRichLink>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.FindSimilarResultExtrasCodeBlock>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitor>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorRun>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AgentDataSourceOutput>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AgentGrounding>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AgentCitation>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AgentRun>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AgentRunEvent>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Batch>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResultOutputSubpage>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResultOutputEntitie>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResultOutputExtrasRichImageLink>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResultOutputExtrasRichLink>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResultOutputExtrasCodeBlock>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchCompanyEntityOutputPropertiesWebTrafficHistoryItem>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWork>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcher>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWork>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchPublicationEntityOutputPropertiesAuthor>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchSynthesisOutputOutputGroundingItem>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchSynthesisOutputOutputGroundingItemCitation>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamTextDeltaChunkOutputChoice>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamTextDeltaChunkOutputChoiceDeltaCitation>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputGroundingItem>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputGroundingItemCitation>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputCitation>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputChoice>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamDoneChunkOutputChoice>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamDoneChunkOutputChoiceDeltaCitation>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AnswerStreamCitationsChunkOutputCitation>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorWebhookOutputEvent>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateCriterionParameters>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersSearchExcludeItem>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersSearchScopeItem>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersImportItem>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateEnrichmentParameters>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersExcludeItem>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateEnrichmentParametersOption>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetSearchParametersExcludeItem>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetSearchParametersScopeItem>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.UpdateEnrichmentParametersOption>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.MonitorBehaviorConfigCriteriaItem>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.EventType>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetSearch>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Import>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetEnrichment>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Monitor>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetExclude>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetSearchCriteriaItem>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetSearchExcludeItem>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetSearchScopeItem>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetEnrichmentOption>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Webset>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItem>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItemEvaluation>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.EnrichmentResult>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItemEvaluationReference>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.EnrichmentResultReference>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseSearchCriteriaItem>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseEnrichment>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseEnrichmentOption>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItemPreview>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.MonitorRun>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Webhook>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebhookAttempt>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Event>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetsGetExpandItem>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.EventsListType>? ListType103 { get; set; }
    }
}