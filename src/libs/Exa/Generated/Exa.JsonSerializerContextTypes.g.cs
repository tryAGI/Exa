
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::Exa.OneOf<bool?, global::Exa.ContentsOptionsContextVariant1>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsContextVariant1? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsOptionsLivecrawl? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? Type39 { get; set; }
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
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsContext>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsContext? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<global::Exa.SearchMonitorContentsLivecrawl?, string>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsLivecrawl? Type88 { get; set; }
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
        public global::Exa.CreateBatchRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.BatchRequestItem>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchRequestItem? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchRequestItemUrl? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamTextDeltaChunk? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AnswerStreamTextDeltaChunkChoice>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamTextDeltaChunkChoice? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamTextDeltaChunkChoiceDelta? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResponse? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisResponse? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultsResponse? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutput>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutput? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsOutput? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchWarningOutput>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchWarningOutput? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchNoticeOutput>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchNoticeOutput? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisOutputOutput? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ErrorResponse? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.X402PaymentChallenge? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.X402PaymentChallengeResource? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsResponse? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.ContentsResponseStatuse>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsResponseStatuse? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsResponseStatuseStatus? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsResponseStatuseSource? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsResponseStatuseError? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerResponse? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AnswerResponseCitation>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerResponseCitation? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResponse? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResult>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResult? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultSubpage>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultSubpage? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultEntitie>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultEntitie? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutput? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutput? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutput? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultEntitieDiscriminator? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultEntitieDiscriminatorType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtras? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichImageLink>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtrasRichImageLink? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichLink>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtrasRichLink? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasCodeBlock>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtrasCodeBlock? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateSearchMonitorResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateSearchMonitorResponseStatus? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorSearchOutput? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorTriggerOutput? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaOutputVariant1? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorWebhookOutput? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListSearchMonitorsResponse? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitor>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitor? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorStatus? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchMonitorsResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchMonitorsResponseAction? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TriggerSearchMonitorResponse? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListSearchMonitorRunsResponse? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorRun>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRun? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunStatus? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutput? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunFailReason? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutputGroundingVariant1Item? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRun? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunStatus? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentStopReason? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunRequest? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentError? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunOutput? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentUsage? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentCostDollars? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunRequestInput? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentDataSourceOutput>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentDataSourceOutput? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentBudgetOutput? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentErrorType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentErrorCode? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentGrounding>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentGrounding? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentCitation>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentCitation? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentGroundingConfidence? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunEvent? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunEventEvent? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentErrorResponse? Type211 { get; set; }
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
        public global::Exa.Batch? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchStatus? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchRequestCounts? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchList? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Batch>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.DeletedBatch? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetsTeamInfo? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetsTeamInfoConcurrency? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetsTeamInfoLimits? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamChunk? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamCitationsChunkOutput? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamCostChunkOutput? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamErrorChunkOutput? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamChunk? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutput? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutput? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamResultsChunkOutput? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamResetChunkOutput? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutput? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamErrorChunkOutput? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamChunkDiscriminator? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamChunkDiscriminatorType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputSubpage>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputSubpage? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitie>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputEntitie? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputEntitieDiscriminator? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputEntitieDiscriminatorType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtras? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasRichImageLink>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtrasRichImageLink? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasRichLink>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtrasRichLink? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasCodeBlock>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtrasCodeBlock? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputProperties? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesWorkforce? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesHeadquarters? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesFinancials? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesFinancialsFundingLatestRound? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesWebTraffic? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesWebTrafficHistoryItem>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesWebTrafficHistoryItem? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearch? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWork>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWork? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcher>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcher? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcherPerson? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputProperties? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemDates? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemCompany? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemDates? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemInstitution? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesResearch? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWork>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWork? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWorkType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutputProperties? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutputPropertiesType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPublicationEntityOutputPropertiesAuthor>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutputPropertiesAuthor? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsOutputSearch? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsOutputContents? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItem>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisOutputOutputGroundingItem? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItemCitation>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisOutputOutputGroundingItemCitation? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamTextDeltaChunkOutputChoice>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutputChoice? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutputChoiceDelta? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamTextDeltaChunkOutputChoiceDeltaCitation>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutputChoiceDeltaCitation? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputGroundingItem>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputGroundingItem? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputGroundingItemCitation>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputGroundingItemCitation? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputGroundingItemConfidence? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputCitation>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputCitation? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoice>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputChoice? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputChoiceDelta? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamDoneChunkOutputChoice>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutputChoice? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutputChoiceDelta? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamDoneChunkOutputChoiceDeltaCitation>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutputChoiceDeltaCitation? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamErrorChunkOutputError? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AnswerStreamCitationsChunkOutputCitation>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamCitationsChunkOutputCitation? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamErrorChunkOutputPayload? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamErrorChunkOutputPayloadError? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutput? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputText>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputText? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputTextVerbosity? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputHighlights>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputHighlights? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputHighlightsVerbosity? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptionsOutput>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SummaryWithMaxTokensOptionsOutput? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputExtras? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputContext>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputContext? Type333 { get; set; }
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
        public global::Exa.OutputSchemaTextOutput? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaOutputVariant1Discriminator? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookOutputEvent>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorWebhookOutputEvent? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParameters? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearch? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Entity? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateCriterionParameters>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateCriterionParameters? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchExcludeItem>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchExcludeItem? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchExcludeItemSource? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchScopeItem>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchScopeItem? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchScopeItemSource? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchScopeItemRelationship? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersImportItem>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersImportItem? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersImportItemSource? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParameters>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateEnrichmentParameters? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersExcludeItem>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersExcludeItem? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersExcludeItemSource? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CompanyEntity? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PersonEntity? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ArticleEntity? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResearchPaperEntity? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CustomEntity? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichmentFormat? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParametersOption>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateEnrichmentParametersOption? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateWebsetRequest? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParameters? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersExcludeItem>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersExcludeItem? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersExcludeItemSource? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersScopeItem>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersScopeItem? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersScopeItemSource? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersScopeItemRelationship? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchBehavior? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateEnrichmentParameters? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.UpdateEnrichmentParametersOption>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateEnrichmentParametersOption? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetParameters? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetParametersSearch? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateMonitorParameters? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorCadence? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorBehavior? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorBehaviorConfig? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.MonitorBehaviorConfigCriteriaItem>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorBehaviorConfigCriteriaItem? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateMonitor? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateMonitorStatus? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParameters? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersVariant1? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersVariant1Format? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersVariant1Csv? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersDiscriminator? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersDiscriminatorFormat? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateImport? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebhookParameters? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EventType>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventType? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateWebhookParameters? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Webset? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetStatus? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearch>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearch? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Import>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Import? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetEnrichment>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichment? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Monitor>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Monitor? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetExclude>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetExclude? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetExcludeSource? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchStatus? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearchCriteriaItem>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchCriteriaItem? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearchExcludeItem>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchExcludeItem? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchExcludeItemSource? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearchScopeItem>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchScopeItem? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchScopeItemSource? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchScopeItemRelationship? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchProgress? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecall? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecallExpected? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecallExpectedConfidence? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecallExpectedBounds? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchCanceledReason? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportObject? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportStatus? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportFormat? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportFailedReason? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichmentStatus? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetEnrichmentOption>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichmentOption? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorObject? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorStatus? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRun? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRunObject? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRunStatus? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRunType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebsetsResponse? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Webset>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetWebsetResponse? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetWebsetResponseVariant2? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItem>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItem? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemSource? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonProperties? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyProperties? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemArticleProperties? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemResearchPaperProperties? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCustomProperties? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluation>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemEvaluation? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EnrichmentResult>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EnrichmentResult? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPerson? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonCompany? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemDates? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemCompany? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemDates? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompany? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyHeadquarters? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyFinancials? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyWebTraffic? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemArticlePropertiesArticle? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemResearchPaperPropertiesResearchPaper? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCustomPropertiesCustom? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemEvaluationSatisfied? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluationReference>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemEvaluationReference? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EnrichmentResultStatus? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EnrichmentResultReference>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EnrichmentResultReference? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebsetItemResponse? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponse? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseSearch? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseSearchCriteriaItem>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseSearchCriteriaItem? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichment>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseEnrichment? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseEnrichmentFormat? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichmentOption>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseEnrichmentOption? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemPreview>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPreview? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListMonitorsResponse? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListMonitorRunsResponse? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.MonitorRun>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponse? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseObject? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseStatus? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseFormat? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseFailedReason? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListImportsResponse? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Webhook? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebhookStatus? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebhooksResponse? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Webhook>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebhookAttemptsResponse? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebhookAttempt>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebhookAttempt? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListEventsResponse? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Event>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Event? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetCreatedEvent? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetDeletedEvent? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetIdleEvent? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetPausedEvent? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetItemCreatedEvent? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetItemEnrichedEvent? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchCreatedEvent? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchUpdatedEvent? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchCanceledEvent? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchCompletedEvent? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventImportCreatedEvent? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventImportCompletedEvent? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorCreatedEvent? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorUpdatedEvent? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorDeletedEvent? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorRunCreatedEvent? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorRunCompletedEvent? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventDiscriminator? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventDiscriminatorType? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListMonitorsStatus? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateAgentRunAccept? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListAgentRunEventsAccept? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateBatchExaBeta? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListBatchesExaBeta? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetBatchExaBeta? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.DeleteBatchExaBeta? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CancelBatchExaBeta? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetsGetExpandItem>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetsGetExpandItem? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EventsListType>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventsListType? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<global::Exa.ErrorResponse, global::Exa.X402PaymentChallenge>? Type548 { get; set; }

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
        public global::System.Collections.Generic.List<global::Exa.FindSimilarResultSubpage>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.FindSimilarResultEntitie>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.FindSimilarResultExtrasRichImageLink>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.FindSimilarResultExtrasRichLink>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.FindSimilarResultExtrasCodeBlock>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitor>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorRun>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AgentDataSourceOutput>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AgentGrounding>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AgentCitation>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AgentRun>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AgentRunEvent>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Batch>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResultOutputSubpage>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResultOutputEntitie>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResultOutputExtrasRichImageLink>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResultOutputExtrasRichLink>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResultOutputExtrasCodeBlock>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchCompanyEntityOutputPropertiesWebTrafficHistoryItem>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWork>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcher>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWork>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchPublicationEntityOutputPropertiesAuthor>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchSynthesisOutputOutputGroundingItem>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchSynthesisOutputOutputGroundingItemCitation>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamTextDeltaChunkOutputChoice>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamTextDeltaChunkOutputChoiceDeltaCitation>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputGroundingItem>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputGroundingItemCitation>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputCitation>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputChoice>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamDoneChunkOutputChoice>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchStreamDoneChunkOutputChoiceDeltaCitation>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AnswerStreamCitationsChunkOutputCitation>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchMonitorWebhookOutputEvent>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateCriterionParameters>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersSearchExcludeItem>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersSearchScopeItem>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersImportItem>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateEnrichmentParameters>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersExcludeItem>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateEnrichmentParametersOption>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetSearchParametersExcludeItem>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CreateWebsetSearchParametersScopeItem>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.UpdateEnrichmentParametersOption>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.MonitorBehaviorConfigCriteriaItem>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.EventType>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetSearch>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Import>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetEnrichment>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Monitor>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetExclude>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetSearchCriteriaItem>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetSearchExcludeItem>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetSearchScopeItem>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetEnrichmentOption>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Webset>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItem>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItemEvaluation>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.EnrichmentResult>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItemEvaluationReference>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.EnrichmentResultReference>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseSearchCriteriaItem>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseEnrichment>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseEnrichmentOption>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetItemPreview>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.MonitorRun>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Webhook>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebhookAttempt>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Event>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.WebsetsGetExpandItem>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.EventsListType>? ListType102 { get; set; }
    }
}