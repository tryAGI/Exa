
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Exa.JsonConverters.ContentsRequestTextVerbosityJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVerbosityNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextIncludeSectionJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextIncludeSectionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextExcludeSectionJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextExcludeSectionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestLivecrawlJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestLivecrawlNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CompanyEntityTypeJsonConverter),

            typeof(global::Exa.JsonConverters.CompanyEntityTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.PersonEntityTypeJsonConverter),

            typeof(global::Exa.JsonConverters.PersonEntityTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EntityDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.EntityDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchTaskDtoStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchTaskDtoStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestTypeJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCategoryJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCategoryNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchTasksCreateRequestModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchTasksCreateRequestModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResponseSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResponseSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResponseOutputGroundingItemConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResponseOutputGroundingItemConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.GetContentsResponseStatuseStatusJsonConverter),

            typeof(global::Exa.JsonConverters.GetContentsResponseStatuseStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.GetContentsResponseStatuseErrorTagJsonConverter),

            typeof(global::Exa.JsonConverters.GetContentsResponseStatuseErrorTagNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EntityJsonConverter),

            typeof(global::Exa.JsonConverters.ResultWithContentJsonConverter),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestText>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestHighlights>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestContext>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.CommonRequestContext>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.EntityCompanyPropertiesFundingRound, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.EntityCompanyPropertiesWorkforce, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.EntityCompanyPropertiesHeadquarters, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.EntityCompanyPropertiesFinancials, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.EntityCompanyPropertiesWebTraffic, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.EntityDateRange, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.EntityPersonPropertiesCompanyRef, object>),

            typeof(global::Exa.JsonConverters.AllOfJsonConverter<global::Exa.SearchRequest2, global::Exa.CommonRequest>),

            typeof(global::Exa.JsonConverters.AllOfJsonConverter<global::Exa.FindSimilarRequest2, global::Exa.CommonRequest>),

            typeof(global::Exa.JsonConverters.AllOfJsonConverter<global::Exa.GetContentsRequest2, global::Exa.ContentsRequest>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.AllOfJsonConverter<global::Exa.AnswerResult, global::Exa.AnswerResponse2>),

            typeof(global::Exa.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AnswerCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsRequestText>), TypeInfoPropertyName = "OneOfBooleanContentsRequestText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVerbosity), TypeInfoPropertyName = "ContentsRequestTextVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextIncludeSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextIncludeSection), TypeInfoPropertyName = "ContentsRequestTextIncludeSection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextExcludeSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextExcludeSection), TypeInfoPropertyName = "ContentsRequestTextExcludeSection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsRequestHighlights>), TypeInfoPropertyName = "OneOfBooleanContentsRequestHighlights2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestHighlights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestLivecrawl), TypeInfoPropertyName = "ContentsRequestLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestExtras))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsRequestContext>), TypeInfoPropertyName = "OneOfBooleanContentsRequestContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CommonRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.CommonRequestContext>), TypeInfoPropertyName = "OneOfBooleanCommonRequestContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CommonRequestContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityCompanyPropertiesWorkforce))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityCompanyPropertiesHeadquarters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityCompanyPropertiesFundingRound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityCompanyPropertiesFinancials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.EntityCompanyPropertiesFundingRound, object>), TypeInfoPropertyName = "OneOfEntityCompanyPropertiesFundingRoundObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityCompanyPropertiesWebTraffic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityCompanyProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.EntityCompanyPropertiesWorkforce, object>), TypeInfoPropertyName = "OneOfEntityCompanyPropertiesWorkforceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.EntityCompanyPropertiesHeadquarters, object>), TypeInfoPropertyName = "OneOfEntityCompanyPropertiesHeadquartersObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.EntityCompanyPropertiesFinancials, object>), TypeInfoPropertyName = "OneOfEntityCompanyPropertiesFinancialsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.EntityCompanyPropertiesWebTraffic, object>), TypeInfoPropertyName = "OneOfEntityCompanyPropertiesWebTrafficObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityDateRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityPersonPropertiesCompanyRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityPersonPropertiesWorkHistoryEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.EntityDateRange, object>), TypeInfoPropertyName = "OneOfEntityDateRangeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.EntityPersonPropertiesCompanyRef, object>), TypeInfoPropertyName = "OneOfEntityPersonPropertiesCompanyRefObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityPersonProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.EntityPersonPropertiesWorkHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CompanyEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CompanyEntityType), TypeInfoPropertyName = "CompanyEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PersonEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PersonEntityType), TypeInfoPropertyName = "PersonEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Entity), TypeInfoPropertyName = "Entity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EntityDiscriminatorType), TypeInfoPropertyName = "EntityDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Result))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResultWithContent), TypeInfoPropertyName = "ResultWithContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResultWithContentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResultWithContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResultWithContentVariant2Extras))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CostDollars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CostDollarsBreakDownItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CostDollarsBreakDownItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CostDollarsBreakDownItemBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CostDollarsPerRequestPrices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CostDollarsPerPagePrices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchTaskDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchTaskDtoStatus), TypeInfoPropertyName = "ResearchTaskDtoStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Exa.ResearchTaskDtoCitation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchTaskDtoCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchTaskDtoCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AllOf<global::Exa.SearchRequest2, global::Exa.CommonRequest>), TypeInfoPropertyName = "AllOfSearchRequest2CommonRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestType), TypeInfoPropertyName = "SearchRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestCategory), TypeInfoPropertyName = "SearchRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AllOf<global::Exa.FindSimilarRequest2, global::Exa.CommonRequest>), TypeInfoPropertyName = "AllOfFindSimilarRequest2CommonRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AllOf<global::Exa.GetContentsRequest2, global::Exa.ContentsRequest>), TypeInfoPropertyName = "AllOfGetContentsRequest2ContentsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetContentsRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerRequestOutputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchTasksCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchTasksCreateRequestModel), TypeInfoPropertyName = "ResearchTasksCreateRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchTasksCreateRequestOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponseSearchType), TypeInfoPropertyName = "SearchResponseSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResponseOutputGroundingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponseOutputGroundingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResponseOutputGroundingItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponseOutputGroundingItemCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponseOutputGroundingItemConfidence), TypeInfoPropertyName = "SearchResponseOutputGroundingItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetContentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.GetContentsResponseStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetContentsResponseStatuse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetContentsResponseStatuseStatus), TypeInfoPropertyName = "GetContentsResponseStatuseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetContentsResponseStatuseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetContentsResponseStatuseErrorTag), TypeInfoPropertyName = "GetContentsResponseStatuseErrorTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AllOf<global::Exa.AnswerResult, global::Exa.AnswerResponse2>), TypeInfoPropertyName = "AllOfAnswerResultAnswerResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchTasksCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchTasksListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchTaskDto>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AnswerCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsRequestTextIncludeSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsRequestTextExcludeSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.EntityPersonPropertiesWorkHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResultWithContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CostDollarsBreakDownItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Exa.ResearchTaskDtoCitation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchTaskDtoCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResponseOutputGroundingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResponseOutputGroundingItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.GetContentsResponseStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchTaskDto>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}