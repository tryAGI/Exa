
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
        public global::System.Collections.Generic.IList<float>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultSubpage>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultSubpage? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultEntitie>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultEntitie? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutput? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutput? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutput? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultEntitieDiscriminator? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultEntitieDiscriminatorType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtras? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichImageLink>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtrasRichImageLink? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichLink>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtrasRichLink? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasCodeBlock>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResultExtrasCodeBlock? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateSearchMonitorResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateSearchMonitorResponseStatus? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorSearchOutput? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorTriggerOutput? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaOutputVariant1? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorWebhookOutput? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListSearchMonitorsResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitor>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitor? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorStatus? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchMonitorsResponse? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.BatchMonitorsResponseAction? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TriggerSearchMonitorResponse? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListSearchMonitorRunsResponse? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorRun>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRun? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunStatus? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutput? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunFailReason? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutputGroundingVariant1Item? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRun? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunStatus? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentStopReason? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunRequest? Type192 { get; set; }
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
        public global::System.Collections.Generic.IList<global::Exa.AgentGrounding>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentGrounding? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentCitation>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentCitation? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentGroundingConfidence? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentErrorResponse? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentError? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentErrorType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentErrorCode? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunList? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentRun>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.DeleteAgentRunResponse? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunEventList? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AgentRunEvent>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AgentRunEvent? Type216 { get; set; }
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
        public global::Exa.AgentRunEventEvent? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputSubpage>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputSubpage? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitie>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputEntitie? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputEntitieDiscriminator? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputEntitieDiscriminatorType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtras? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasRichImageLink>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtrasRichImageLink? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasRichLink>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtrasRichLink? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputExtrasCodeBlock>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResultOutputExtrasCodeBlock? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputProperties? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesWorkforce? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesHeadquarters? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesFinancials? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesFinancialsFundingLatestRound? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesWebTraffic? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesWebTrafficHistoryItem>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesWebTrafficHistoryItem? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearch? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWork>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWork? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcher>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcher? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchCompanyEntityOutputPropertiesResearchTopResearcherPerson? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputProperties? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemDates? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemCompany? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemDates? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemInstitution? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesResearch? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWork>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWork? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPersonEntityOutputPropertiesResearchNotableWorkType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutputProperties? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutputPropertiesType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchPublicationEntityOutputPropertiesAuthor>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchPublicationEntityOutputPropertiesAuthor? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsOutputSearch? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsOutputContents? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItem>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisOutputOutputGroundingItem? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItemCitation>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisOutputOutputGroundingItemCitation? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamTextDeltaChunkOutputChoice>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutputChoice? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutputChoiceDelta? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamTextDeltaChunkOutputChoiceDeltaCitation>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamTextDeltaChunkOutputChoiceDeltaCitation? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputGroundingItem>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputGroundingItem? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputGroundingItemCitation>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputGroundingItemCitation? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputGroundingItemConfidence? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputCitation>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputCitation? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoice>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputChoice? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputChoiceDelta? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamDoneChunkOutputChoice>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutputChoice? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutputChoiceDelta? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamDoneChunkOutputChoiceDeltaCitation>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamDoneChunkOutputChoiceDeltaCitation? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchStreamErrorChunkOutputError? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AnswerStreamCitationsChunkOutputCitation>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamCitationsChunkOutputCitation? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamErrorChunkOutputPayload? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerStreamErrorChunkOutputPayloadError? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutput? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputText>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputText? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputTextVerbosity? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputHighlights>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputHighlights? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputHighlightsVerbosity? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptionsOutput>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SummaryWithMaxTokensOptionsOutput? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputExtras? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputLivecrawl? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputContext>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorContentsOutputContext? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OutputSchemaTextOutput? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaOutputVariant1Discriminator? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorOutputSchemaOutputVariant1DiscriminatorType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookOutputEvent>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchMonitorWebhookOutputEvent? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParameters? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearch? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Entity? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateCriterionParameters>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateCriterionParameters? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchExcludeItem>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchExcludeItem? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchExcludeItemSource? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchScopeItem>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchScopeItem? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchScopeItemSource? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersSearchScopeItemRelationship? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersImportItem>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersImportItem? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersImportItemSource? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParameters>? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateEnrichmentParameters? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersExcludeItem>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersExcludeItem? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetParametersExcludeItemSource? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CompanyEntity? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PersonEntity? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ArticleEntity? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResearchPaperEntity? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CustomEntity? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichmentFormat? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParametersOption>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateEnrichmentParametersOption? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateWebsetRequest? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParameters? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersExcludeItem>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersExcludeItem? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersExcludeItemSource? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersScopeItem>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersScopeItem? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersScopeItemSource? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebsetSearchParametersScopeItemRelationship? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchBehavior? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateEnrichmentParameters? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.UpdateEnrichmentParametersOption>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateEnrichmentParametersOption? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetParameters? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetParametersSearch? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateMonitorParameters? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorCadence? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorBehavior? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorBehaviorConfig? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.MonitorBehaviorConfigCriteriaItem>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorBehaviorConfigCriteriaItem? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateMonitor? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateMonitorStatus? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParameters? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersVariant1? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersVariant1Format? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersVariant1Csv? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersDiscriminator? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportParametersDiscriminatorFormat? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateImport? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateWebhookParameters? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EventType>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventType? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.UpdateWebhookParameters? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Webset? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetStatus? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearch>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearch? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Import>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Import? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetEnrichment>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichment? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Monitor>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Monitor? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetExclude>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetExclude? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetExcludeSource? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchStatus? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearchCriteriaItem>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchCriteriaItem? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearchExcludeItem>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchExcludeItem? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchExcludeItemSource? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetSearchScopeItem>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchScopeItem? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchScopeItemSource? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchScopeItemRelationship? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchProgress? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecall? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecallExpected? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecallExpectedConfidence? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchRecallExpectedBounds? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetSearchCanceledReason? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportObject? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportStatus? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportFormat? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ImportFailedReason? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichmentStatus? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetEnrichmentOption>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetEnrichmentOption? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorObject? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorStatus? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRun? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRunObject? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRunStatus? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.MonitorRunType? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebsetsResponse? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Webset>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetWebsetResponse? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetWebsetResponseVariant2? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItem>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItem? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemSource? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonProperties? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyProperties? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemArticleProperties? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemResearchPaperProperties? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCustomProperties? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluation>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemEvaluation? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EnrichmentResult>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EnrichmentResult? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPerson? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonCompany? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemDates? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemCompany? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemDates? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompany? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyHeadquarters? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyFinancials? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCompanyPropertiesCompanyWebTraffic? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemArticlePropertiesArticle? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemResearchPaperPropertiesResearchPaper? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemCustomPropertiesCustom? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemEvaluationSatisfied? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluationReference>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemEvaluationReference? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EnrichmentResultStatus? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EnrichmentResultReference>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EnrichmentResultReference? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebsetItemResponse? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponse? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseSearch? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseSearchCriteriaItem>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseSearchCriteriaItem? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichment>? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseEnrichment? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseEnrichmentFormat? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichmentOption>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PreviewWebsetResponseEnrichmentOption? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemPreview>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetItemPreview? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListMonitorsResponse? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListMonitorRunsResponse? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.MonitorRun>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponse? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseObject? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseStatus? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseFormat? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateImportResponseFailedReason? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListImportsResponse? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Webhook? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebhookStatus? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebhooksResponse? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Webhook>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListWebhookAttemptsResponse? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebhookAttempt>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebhookAttempt? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListEventsResponse? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Event>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Event? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetCreatedEvent? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetDeletedEvent? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetIdleEvent? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetPausedEvent? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetItemCreatedEvent? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetItemEnrichedEvent? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchCreatedEvent? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchUpdatedEvent? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchCanceledEvent? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventWebsetSearchCompletedEvent? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventImportCreatedEvent? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventImportCompletedEvent? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorCreatedEvent? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorUpdatedEvent? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorDeletedEvent? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorRunCreatedEvent? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventMonitorRunCompletedEvent? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventDiscriminator? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventDiscriminatorType? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListMonitorsStatus? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateAgentRunAccept? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListAgentRunEventsAccept? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CreateBatchExaBeta? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ListBatchesExaBeta? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetBatchExaBeta? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.DeleteBatchExaBeta? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CancelBatchExaBeta? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.WebsetsGetExpandItem>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.WebsetsGetExpandItem? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EventsListType>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EventsListType? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<global::Exa.ErrorResponse, global::Exa.X402PaymentChallenge>? Type549 { get; set; }

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