
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
            typeof(global::Exa.JsonConverters.ContentsRequestLivecrawlJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestLivecrawlNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CompanyEntityTypeJsonConverter),

            typeof(global::Exa.JsonConverters.CompanyEntityTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.PersonEntityTypeJsonConverter),

            typeof(global::Exa.JsonConverters.PersonEntityTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EntityDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.EntityDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchCreateRequestDtoClassModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchCreateRequestDtoClassModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant1ModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant1ModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant1StatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant1StatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant2ModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant2ModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant2StatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant2StatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant3ModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant3ModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant3StatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant3StatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant4ModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant4ModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant4StatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant4StatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant5ModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant5ModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant5StatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassVariant5StatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchOperationDtoClassVariant1TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchOperationDtoClassVariant1TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchOperationDtoClassVariant2TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchOperationDtoClassVariant2TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchOperationDtoClassVariant2SearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchOperationDtoClassVariant2SearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchOperationDtoClassVariant3TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchOperationDtoClassVariant3TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1Variant1EventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1Variant1EventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1Variant2EventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1Variant2EventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1Variant2OutputVariant1OutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1Variant2OutputVariant1OutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1Variant2OutputVariant2OutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1Variant2OutputVariant2OutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2Variant1EventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2Variant1EventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2Variant2EventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2Variant2EventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2Variant3EventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2Variant3EventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputVariant1OutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputVariant1OutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputVariant2OutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputVariant2OutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3Variant1EventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3Variant1EventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3Variant2EventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3Variant2EventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3Variant3EventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3Variant3EventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3Variant3OutputOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3Variant3OutputOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestTypeJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCategoryJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCategoryNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResponseSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResponseSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.GetContentsResponseStatuseStatusJsonConverter),

            typeof(global::Exa.JsonConverters.GetContentsResponseStatuseStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.GetContentsResponseStatuseErrorTagJsonConverter),

            typeof(global::Exa.JsonConverters.GetContentsResponseStatuseErrorTagNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EntityJsonConverter),

            typeof(global::Exa.JsonConverters.ResultWithContentJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchOperationDtoClassJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1JsonConverter),

            typeof(global::Exa.JsonConverters.OutputJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2JsonConverter),

            typeof(global::Exa.JsonConverters.Output2JsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3JsonConverter),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestText>),

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

            typeof(global::Exa.JsonConverters.AllOfJsonConverter<global::Exa.AnswerResult, global::Exa.AnswerResponse2>),

            typeof(global::Exa.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AnswerCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsRequestText>), TypeInfoPropertyName = "OneOfBooleanContentsRequestText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestHighlights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListResearchResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClass), TypeInfoPropertyName = "ResearchDtoClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchCreateRequestDtoClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchCreateRequestDtoClassModel), TypeInfoPropertyName = "ResearchCreateRequestDtoClassModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant1Model), TypeInfoPropertyName = "ResearchDtoClassVariant1Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant1Status), TypeInfoPropertyName = "ResearchDtoClassVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant2Model), TypeInfoPropertyName = "ResearchDtoClassVariant2Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant2Status), TypeInfoPropertyName = "ResearchDtoClassVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchEventDtoClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClass), TypeInfoPropertyName = "ResearchEventDtoClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant3Model), TypeInfoPropertyName = "ResearchDtoClassVariant3Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant3Status), TypeInfoPropertyName = "ResearchDtoClassVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant3Output))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant3CostDollars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant4Model), TypeInfoPropertyName = "ResearchDtoClassVariant4Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant4Status), TypeInfoPropertyName = "ResearchDtoClassVariant4Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant5Model), TypeInfoPropertyName = "ResearchDtoClassVariant5Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassVariant5Status), TypeInfoPropertyName = "ResearchDtoClassVariant5Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchOperationDtoClass), TypeInfoPropertyName = "ResearchOperationDtoClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchOperationDtoClassVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchOperationDtoClassVariant1Type), TypeInfoPropertyName = "ResearchOperationDtoClassVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchOperationDtoClassVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchOperationDtoClassVariant2Type), TypeInfoPropertyName = "ResearchOperationDtoClassVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchOperationDtoClassVariant2SearchType), TypeInfoPropertyName = "ResearchOperationDtoClassVariant2SearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchOperationDtoClassVariant2Result>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchOperationDtoClassVariant2Result))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchOperationDtoClassVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchOperationDtoClassVariant3Type), TypeInfoPropertyName = "ResearchOperationDtoClassVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchOperationDtoClassVariant3Result))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchOperationDtoClassDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1), TypeInfoPropertyName = "ResearchEventDtoClassVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Variant1EventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant1Variant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Variant2EventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant1Variant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Output), TypeInfoPropertyName = "Output2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Variant2OutputVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Variant2OutputVariant1OutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant1Variant2OutputVariant1OutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Variant2OutputVariant1CostDollars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Variant2OutputVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Variant2OutputVariant2OutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant1Variant2OutputVariant2OutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Variant2OutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2), TypeInfoPropertyName = "ResearchEventDtoClassVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Variant1EventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2Variant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Variant2EventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2Variant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Variant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Variant3EventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2Variant3EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Output2), TypeInfoPropertyName = "Output22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Variant3OutputVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Variant3OutputVariant1OutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2Variant3OutputVariant1OutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Variant3OutputVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Variant3OutputVariant2OutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2Variant3OutputVariant2OutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Variant3OutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3), TypeInfoPropertyName = "ResearchEventDtoClassVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3Variant1EventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3Variant1EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3Variant2EventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3Variant2EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3Variant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3Variant3EventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3Variant3EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3Variant3Output))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3Variant3OutputOutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3Variant3OutputOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AllOf<global::Exa.SearchRequest2, global::Exa.CommonRequest>), TypeInfoPropertyName = "AllOfSearchRequest2CommonRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestType), TypeInfoPropertyName = "SearchRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestCategory), TypeInfoPropertyName = "SearchRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AllOf<global::Exa.FindSimilarRequest2, global::Exa.CommonRequest>), TypeInfoPropertyName = "AllOfFindSimilarRequest2CommonRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AllOf<global::Exa.GetContentsRequest2, global::Exa.ContentsRequest>), TypeInfoPropertyName = "AllOfGetContentsRequest2ContentsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetContentsRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponseSearchType), TypeInfoPropertyName = "SearchResponseSearchType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AnswerCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.EntityPersonPropertiesWorkHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResultWithContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CostDollarsBreakDownItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchEventDtoClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchOperationDtoClassVariant2Result>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.GetContentsResponseStatuse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}