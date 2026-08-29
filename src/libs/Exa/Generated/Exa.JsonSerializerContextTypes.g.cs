
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
        public global::Exa.AnswerCitation? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerResult? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<string, object>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.AnswerCitation>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequest? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.ContentsRequestText>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestText? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestTextVerbosity? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextIncludeSection>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestTextIncludeSection? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextExcludeSection>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestTextExcludeSection? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.ContentsRequestHighlights>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestHighlights? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestSummary? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestLivecrawl? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestExtras? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.ContentsRequestContext>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ContentsRequestContext? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CommonRequest? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<bool?, global::Exa.CommonRequestContext>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CommonRequestContext? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityCompanyPropertiesWorkforce? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityCompanyPropertiesHeadquarters? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityCompanyPropertiesFundingRound? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityCompanyPropertiesFinancials? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityCompanyPropertiesWebTraffic? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityCompanyProperties? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityDateRange? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityPersonPropertiesCompanyRef? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityPersonPropertiesWorkHistoryEntry? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityPersonProperties? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.EntityPersonPropertiesWorkHistoryEntry>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CompanyEntity? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CompanyEntityType? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PersonEntity? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.PersonEntityType? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Entity? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityDiscriminator? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.EntityDiscriminatorType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.Result? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResultWithContent? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResultWithContentVariant2? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.ResultWithContent>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResultWithContentVariant2Extras? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.Entity>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollars? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.CostDollarsBreakDownItem>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsBreakDownItem? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsBreakDownItemBreakdown? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsPerRequestPrices? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.CostDollarsPerPagePrices? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResearchTaskDto? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResearchTaskDtoStatus? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Exa.ResearchTaskDtoCitation>>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.ResearchTaskDtoCitation>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResearchTaskDtoCitation? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AllOf<global::Exa.SearchRequest2, global::Exa.CommonRequest>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequest2? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequestType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchRequestCategory? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AllOf<global::Exa.FindSimilarRequest2, global::Exa.CommonRequest>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarRequest2? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AllOf<global::Exa.GetContentsRequest2, global::Exa.ContentsRequest>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetContentsRequest2? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerRequest? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerRequestOutputSchema? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResearchTasksCreateRequest? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResearchTasksCreateRequestModel? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResearchTasksCreateRequestOutput? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResponseSearchType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResponseOutput? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResponseOutputGroundingItem>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResponseOutputGroundingItem? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.SearchResponseOutputGroundingItemCitation>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResponseOutputGroundingItemCitation? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.SearchResponseOutputGroundingItemConfidence? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.FindSimilarResponse? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetContentsResponse? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.GetContentsResponseStatuse>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetContentsResponseStatuse? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetContentsResponseStatuseStatus? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetContentsResponseStatuseError? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.GetContentsResponseStatuseErrorTag? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AllOf<global::Exa.AnswerResult, global::Exa.AnswerResponse2>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerResponse2? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.AnswerResponse3? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResearchTasksCreateResponse? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.ResearchTasksListResponse? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.ResearchTaskDto>? Type100 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.AnswerCitation>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.ContentsRequestTextIncludeSection>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.ContentsRequestTextExcludeSection>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.OneOf<string, global::System.Collections.Generic.List<string>>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.EntityPersonPropertiesWorkHistoryEntry>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.ResultWithContent>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.Entity>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.CostDollarsBreakDownItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Exa.ResearchTaskDtoCitation>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.ResearchTaskDtoCitation>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResponseOutputGroundingItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.SearchResponseOutputGroundingItemCitation>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.GetContentsResponseStatuse>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.ResearchTaskDto>? ListType15 { get; set; }
    }
}