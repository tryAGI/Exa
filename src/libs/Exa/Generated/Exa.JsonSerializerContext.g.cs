
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
            typeof(global::Exa.JsonConverters.SearchRequestType2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestType2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCategory2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCategory2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCompliance2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCompliance2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1Verbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1Verbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1IncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1IncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1ExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1ExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsLivecrawl2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsLivecrawl2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestCompliance2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestCompliance2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1Verbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1Verbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1IncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1IncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1ExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1ExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestLivecrawl2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestLivecrawl2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.FindSimilarRequestCategory2JsonConverter),

            typeof(global::Exa.JsonConverters.FindSimilarRequestCategory2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextVerbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextVerbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextIncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextIncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsLivecrawlJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsLivecrawlNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookEventJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestActionJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestActionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestFilterStatusJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestFilterStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersStatusJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersWebhookEventJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersWebhookEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentEffortJsonConverter),

            typeof(global::Exa.JsonConverters.AgentEffortNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentDataSourceProviderJsonConverter),

            typeof(global::Exa.JsonConverters.AgentDataSourceProviderNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseSourceJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateSearchMonitorResponseStatusJsonConverter),

            typeof(global::Exa.JsonConverters.CreateSearchMonitorResponseStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsResponseActionJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsResponseActionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunStatusJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunFailReason2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunFailReason2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunStatusJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentStopReasonJsonConverter),

            typeof(global::Exa.JsonConverters.AgentStopReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentGroundingConfidence2JsonConverter),

            typeof(global::Exa.JsonConverters.AgentGroundingConfidence2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorCodeJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorCodeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchStreamChunkVariant2GroundingItemConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.SearchStreamChunkVariant2GroundingItemConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunEventEventJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunEventEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResultOutputEntitieVariant3PropertiesType2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchResultOutputEntitieVariant3PropertiesType2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchSynthesisOutputOutputGroundingItemConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.SearchSynthesisOutputOutputGroundingItemConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextVerbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextVerbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextIncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextIncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputLivecrawlJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputLivecrawlNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookOutputEventJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookOutputEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchCreateRequestDtoClassModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchCreateRequestDtoClassModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant1TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant1TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1VersionJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1VersionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2VersionJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2VersionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitionsJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitionsNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDateJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDateNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivityJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivityNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant3TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant3TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentVersionJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentVersionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationCategoryJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationCategoryNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationSourceJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassDiscriminatorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassDiscriminatorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchDefinitionEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchDefinitionEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1DiscriminatorEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1DiscriminatorEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanDefinitionEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanDefinitionEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataThinkTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataThinkTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataCrawlTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataCrawlTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2DiscriminatorEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2DiscriminatorEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskDefinitionEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskDefinitionEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataThinkTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataThinkTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputOutputOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputOutputOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3DiscriminatorEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3DiscriminatorEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateEnrichmentParametersFormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateEnrichmentParametersFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchScopeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchScopeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersImportItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersImportItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchScopeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchScopeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchRecallExpectedConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchRecallExpectedConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportObjectJsonConverter),

            typeof(global::Exa.JsonConverters.ImportObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ImportStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFormatJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFailedReasonJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFailedReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunObjectJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunStatusJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunTypeJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorObjectJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehaviorJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehaviorNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetExcludeSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetExcludeSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemEvaluationSatisfiedJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemEvaluationSatisfiedNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EnrichmentResultStatusJsonConverter),

            typeof(global::Exa.JsonConverters.EnrichmentResultStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatJsonConverter),

            typeof(global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateEnrichmentParametersFormatJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateEnrichmentParametersFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookAttemptEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookAttemptEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EventDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.EventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersScopeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersScopeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateMonitorParametersBehaviorConfigBehaviorJsonConverter),

            typeof(global::Exa.JsonConverters.CreateMonitorParametersBehaviorConfigBehaviorNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehavior2JsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehavior2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateMonitorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateMonitorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersVariant1FormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersVariant1FormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseObjectJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseStatusJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFailedReasonJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFailedReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentFormatJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.EventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchBehaviorJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchBehaviorNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchCanceledReasonJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchCanceledReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ListMonitorsStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ListMonitorsStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateAgentRunAcceptJsonConverter),

            typeof(global::Exa.JsonConverters.CreateAgentRunAcceptNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ListAgentRunEventsAcceptJsonConverter),

            typeof(global::Exa.JsonConverters.ListAgentRunEventsAcceptNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetsGetExpandItemJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetsGetExpandItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebhooksAttemptsListEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.WebhooksAttemptsListEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EventsListTypeJsonConverter),

            typeof(global::Exa.JsonConverters.EventsListTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.JsonValueJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResponseJsonConverter),

            typeof(global::Exa.JsonConverters.AnswerStreamChunkJsonConverter),

            typeof(global::Exa.JsonConverters.SearchStreamChunkJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassJsonConverter),

            typeof(global::Exa.JsonConverters.ProfileJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1JsonConverter),

            typeof(global::Exa.JsonConverters.OutputJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2JsonConverter),

            typeof(global::Exa.JsonConverters.DataJsonConverter),

            typeof(global::Exa.JsonConverters.Output2JsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3JsonConverter),

            typeof(global::Exa.JsonConverters.Data2JsonConverter),

            typeof(global::Exa.JsonConverters.EntityJsonConverter),

            typeof(global::Exa.JsonConverters.GetWebsetResponseJsonConverter),

            typeof(global::Exa.JsonConverters.EventJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersJsonConverter),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchRequestContextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchRequestOutputSchemaVariant1, global::Exa.SearchRequestOutputSchemaVariant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsTextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsHighlightsVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsContextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestTextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestHighlightsVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestContextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsText>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsHighlights>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsSummary>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsContext>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsLivecrawl?, string>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorOutputSchemaVariant1Variant1, global::Exa.SearchMonitorOutputSchemaVariant1Variant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.JsonValue?, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchResultOutputEntitieVariant1, global::Exa.SearchResultOutputEntitieVariant2, global::Exa.SearchResultOutputEntitieVariant3>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputText>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputHighlights>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputSummary>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputContext>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant1, global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>),

            typeof(global::Exa.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2>), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2_b38b04325112cfda")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>), TypeInfoPropertyName = "WebsetItemCustomProperties_976e7369ebb8440c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2>?), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2_49282bf6215dfc2e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>?), TypeInfoPropertyName = "WebsetItemCustomProperties_2a7882e053a7bb38")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchRequestContextVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestContextVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestCategory2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestCompliance2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchRequestOutputSchemaVariant1, global::Exa.SearchRequestOutputSchemaVariant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestOutputSchemaVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchRequestOutputSchemaVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.JsonValue), TypeInfoPropertyName = "JsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.JsonValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsOptionsTextVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1Verbosity2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item), TypeInfoPropertyName = "ContentsOptionsTextVariant1IncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item), TypeInfoPropertyName = "ContentsOptionsTextVariant1ExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsOptionsHighlightsVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsHighlightsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsSummary2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsExtras2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsOptionsContextVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsContextVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsLivecrawl2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestCompliance2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsRequestTextVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1Verbosity2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item), TypeInfoPropertyName = "ContentsRequestTextVariant1IncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item), TypeInfoPropertyName = "ContentsRequestTextVariant1ExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsRequestHighlightsVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestHighlightsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestSummary2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestExtras2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.ContentsRequestContextVariant1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestContextVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestLivecrawl2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerRequestOutputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarRequestCategory2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateSearchMonitorParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorOutputSchemaVariant1Variant1, global::Exa.SearchMonitorOutputSchemaVariant1Variant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsText>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextVerbosity2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item), TypeInfoPropertyName = "SearchMonitorContentsTextIncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item), TypeInfoPropertyName = "SearchMonitorContentsTextExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsHighlights>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsHighlights2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsHighlights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsSummary>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsExtras))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsContext>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsLivecrawl?, string>), TypeInfoPropertyName = "OneOfSearchMonitorContentsLivecrawlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsLivecrawl), TypeInfoPropertyName = "SearchMonitorContentsLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaVariant1Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaVariant1Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookEvent), TypeInfoPropertyName = "SearchMonitorWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestAction), TypeInfoPropertyName = "BatchMonitorsRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestFilterStatus), TypeInfoPropertyName = "BatchMonitorsRequestFilterStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersStatus), TypeInfoPropertyName = "UpdateSearchMonitorParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersTrigger2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.UpdateSearchMonitorParametersWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersWebhookEvent), TypeInfoPropertyName = "UpdateSearchMonitorParametersWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentEffort), TypeInfoPropertyName = "AgentEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentDataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunRequestBudget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSourceProvider), TypeInfoPropertyName = "AgentDataSourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponse), TypeInfoPropertyName = "SearchResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CostDollarsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchSynthesisOutputOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ContentsResponseStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuseStatus), TypeInfoPropertyName = "ContentsResponseStatuseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuseSource), TypeInfoPropertyName = "ContentsResponseStatuseSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AnswerResponseCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerResponseCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.FindSimilarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateSearchMonitorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateSearchMonitorResponseStatus), TypeInfoPropertyName = "CreateSearchMonitorResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorSearchOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorTriggerOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant1, global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant2>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutput2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunFailReason2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.JsonValue?, object>), TypeInfoPropertyName = "OneOfJsonValueObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence), TypeInfoPropertyName = "SearchMonitorRunOutputGroundingVariant1ItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunStatus), TypeInfoPropertyName = "AgentRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentStopReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentCostDollars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentDataSourceOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSourceOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentGrounding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentGrounding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentGroundingConfidence2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetsTeamInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetsTeamInfoConcurrency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetsTeamInfoLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunk), TypeInfoPropertyName = "AnswerStreamChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunkVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AnswerStreamChunkVariant1Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunkVariant1Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunkVariant1ChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunkVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AnswerStreamChunkVariant2Citation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunkVariant2Citation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunkVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunkVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunkVariant4Payload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunkVariant4PayloadError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunk), TypeInfoPropertyName = "SearchStreamChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant1Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant1Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant1ChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant1ChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant1ChoiceDeltaCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant2GroundingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant2GroundingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant2GroundingItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant2GroundingItemCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant2GroundingItemConfidence), TypeInfoPropertyName = "SearchStreamChunkVariant2GroundingItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant2Citation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant2Citation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant2Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant2Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant2ChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant2ChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant2ChoiceDeltaCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant5Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant5Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant5ChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant5ChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant5ChoiceDeltaCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant6Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunEventEvent), TypeInfoPropertyName = "AgentRunEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutputSubpage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputSubpage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.OneOf<global::Exa.SearchResultOutputEntitieVariant1, global::Exa.SearchResultOutputEntitieVariant2, global::Exa.SearchResultOutputEntitieVariant3>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchResultOutputEntitieVariant1, global::Exa.SearchResultOutputEntitieVariant2, global::Exa.SearchResultOutputEntitieVariant3>), TypeInfoPropertyName = "OneOfSearchResultOutputEntitieVariant1SearchResultOutputEntitieVariant2SearchResultOutputEntitieVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant1Properties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant1PropertiesWorkforce2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant1PropertiesHeadquarters2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant1PropertiesFinancials2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant1PropertiesFinancialsFundingLatestRound2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant1PropertiesWebTraffic2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant1PropertiesWebTrafficHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant1PropertiesWebTrafficHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant2Properties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant2PropertiesWorkHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant2PropertiesWorkHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemDates2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemCompany2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant2PropertiesEducationHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant2PropertiesEducationHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant2PropertiesEducationHistoryItemDates2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant2PropertiesEducationHistoryItemInstitution2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant3Properties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant3PropertiesType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant3PropertiesAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputEntitieVariant3PropertiesAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResultOutputExtras))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CostDollarsOutputSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchSynthesisOutputOutputGroundingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchSynthesisOutputOutputGroundingItemCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence), TypeInfoPropertyName = "SearchSynthesisOutputOutputGroundingItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputText>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsOutputText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextVerbosity2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item), TypeInfoPropertyName = "SearchMonitorContentsOutputTextIncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item), TypeInfoPropertyName = "SearchMonitorContentsOutputTextExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputHighlights>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsOutputHighlights2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputHighlights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputSummary>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsOutputSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputExtras))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputContext>), TypeInfoPropertyName = "OneOfBooleanSearchMonitorContentsOutputContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>), TypeInfoPropertyName = "OneOfSearchMonitorContentsOutputLivecrawlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputLivecrawl), TypeInfoPropertyName = "SearchMonitorContentsOutputLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookOutputEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookOutputEvent), TypeInfoPropertyName = "SearchMonitorWebhookOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListResearchResponseDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClass), TypeInfoPropertyName = "ResearchDtoClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchCreateRequestDtoClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchCreateRequestDtoClassModel), TypeInfoPropertyName = "ResearchCreateRequestDtoClassModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassPending))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassPendingModel), TypeInfoPropertyName = "ResearchDtoClassPendingModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassPendingStatus), TypeInfoPropertyName = "ResearchDtoClassPendingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassRunning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassRunningModel), TypeInfoPropertyName = "ResearchDtoClassRunningModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassRunningStatus), TypeInfoPropertyName = "ResearchDtoClassRunningStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchEventDtoClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClass), TypeInfoPropertyName = "ResearchEventDtoClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedModel), TypeInfoPropertyName = "ResearchDtoClassCompletedModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedStatus), TypeInfoPropertyName = "ResearchDtoClassCompletedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationSubpage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationSubpage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Profile), TypeInfoPropertyName = "Profile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1Type), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1Content))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentFunding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentAffiliatedCompanie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentAffiliatedCompanie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentLocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentMetaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2Type), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Version), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Identity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1IdentityIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1IdentityTicker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1IdentityTicker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Classification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Locations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1LocationsHeadquarters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1LocationsOffice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1LocationsOffice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Profiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesSocialItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesSocialItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesContact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Provenance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Basics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Workforce))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceBySeniorityMonthlyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceBySeniorityMonthlyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByDepartmentMonthlyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByDepartmentMonthlyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByRegionMonthlyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByRegionMonthlyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByCountryMonthlyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByCountryMonthlyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceExecutive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceExecutive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceRecentHire>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceRecentHire))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceRecentDeparture>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceRecentDeparture))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceTopPreviousCompanie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceTopPreviousCompanie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceTopNextCompanie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceTopNextCompanie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPosting>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPosting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPostingsHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPostingsHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPostingsGrowth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceSalaryRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceSalaryRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceGrowth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Financials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsRevenueAnnual))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsRevenueRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsRevenueGrowth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsIncomeStatement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsIncomeStatement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsMarketCap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsStockPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsStockHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsStockHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsTotalFunding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsFundingRound>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsFundingRound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsFundingRoundAmount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsFundingRoundValuation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsLastRound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsLastRoundAmount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsLastRoundValuation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquiredBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquiredByAmount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisitionAmount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsInvestment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsInvestment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsInvestmentAmount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsTotalInvested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Market))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1MarketCompetitor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1MarketCompetitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1MarketCompetitorRevenue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Products))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsProductPricingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsProductPricingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsTechnologie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsTechnologie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Customers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersProductReviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersProductReviewsDistribution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersProductReviewsTrend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewsDistribution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewsTrend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTraffic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficAgeDistribution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficGenderDistribution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficGrowth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1NewsActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1NewsActivityNew>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1NewsActivityNew))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1NewsActivityPressRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1NewsActivityPressRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Xverum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Version), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Identity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Classification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Basics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Locations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2LocationsHeadquarters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Profiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2ProfilesSocialItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2ProfilesSocialItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Workforce))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2WorkforceGrowth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Financials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueAnnual))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueGrowth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsTotalFunding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRoundAmount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRoundValuation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsMarketCap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitions), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDate), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRound>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRoundAmount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRoundValuation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2WebTraffic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivity), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3Type), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3Content))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentWebsite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentWebsite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentExperienceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentExperienceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentEducationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentEducationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentCertification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentCertification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPatent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPatent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPatentContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPatentContributor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentVolunteeringItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentVolunteeringItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPublication>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPublication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentSocialActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentSocialActivitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentSocialGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentSocialGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentMetaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4Type), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4Content))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCsMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperience))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceActive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByDepartmentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByDepartmentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByManagementLevelItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByManagementLevelItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItem))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Exa.JsonConverters.SearchRequestType2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestType2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCategory2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCategory2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCompliance2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCompliance2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1Verbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1Verbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1IncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1IncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1ExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1ExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsLivecrawl2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsLivecrawl2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestCompliance2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestCompliance2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1Verbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1Verbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1IncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1IncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1ExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1ExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestLivecrawl2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestLivecrawl2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.FindSimilarRequestCategory2JsonConverter),

            typeof(global::Exa.JsonConverters.FindSimilarRequestCategory2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextVerbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextVerbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextIncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextIncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsLivecrawlJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsLivecrawlNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookEventJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestActionJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestActionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestFilterStatusJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestFilterStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersStatusJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersWebhookEventJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersWebhookEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentEffortJsonConverter),

            typeof(global::Exa.JsonConverters.AgentEffortNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentDataSourceProviderJsonConverter),

            typeof(global::Exa.JsonConverters.AgentDataSourceProviderNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseSourceJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateSearchMonitorResponseStatusJsonConverter),

            typeof(global::Exa.JsonConverters.CreateSearchMonitorResponseStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsResponseActionJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsResponseActionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunStatusJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunFailReason2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunFailReason2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunStatusJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentStopReasonJsonConverter),

            typeof(global::Exa.JsonConverters.AgentStopReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentGroundingConfidence2JsonConverter),

            typeof(global::Exa.JsonConverters.AgentGroundingConfidence2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorCodeJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorCodeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchStreamChunkVariant2GroundingItemConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.SearchStreamChunkVariant2GroundingItemConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunEventEventJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunEventEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResultOutputEntitieVariant3PropertiesType2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchResultOutputEntitieVariant3PropertiesType2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchSynthesisOutputOutputGroundingItemConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.SearchSynthesisOutputOutputGroundingItemConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextVerbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextVerbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextIncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextIncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputLivecrawlJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputLivecrawlNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookOutputEventJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookOutputEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchCreateRequestDtoClassModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchCreateRequestDtoClassModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant1TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant1TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1VersionJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1VersionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2VersionJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2VersionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitionsJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitionsNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDateJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDateNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivityJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivityNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant3TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant3TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentVersionJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentVersionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationCategoryJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationCategoryNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationSourceJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassDiscriminatorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassDiscriminatorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchDefinitionEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchDefinitionEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1DiscriminatorEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1DiscriminatorEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanDefinitionEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanDefinitionEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataThinkTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataThinkTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataCrawlTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataCrawlTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2DiscriminatorEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2DiscriminatorEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskDefinitionEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskDefinitionEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataThinkTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataThinkTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputOutputOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputOutputOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3DiscriminatorEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3DiscriminatorEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateEnrichmentParametersFormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateEnrichmentParametersFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchScopeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchScopeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersImportItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersImportItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchScopeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchScopeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchRecallExpectedConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchRecallExpectedConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportObjectJsonConverter),

            typeof(global::Exa.JsonConverters.ImportObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ImportStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFormatJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFailedReasonJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFailedReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunObjectJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunStatusJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunTypeJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorObjectJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehaviorJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehaviorNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetExcludeSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetExcludeSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemEvaluationSatisfiedJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemEvaluationSatisfiedNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EnrichmentResultStatusJsonConverter),

            typeof(global::Exa.JsonConverters.EnrichmentResultStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatJsonConverter),

            typeof(global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateEnrichmentParametersFormatJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateEnrichmentParametersFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookAttemptEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookAttemptEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EventDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.EventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersScopeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersScopeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateMonitorParametersBehaviorConfigBehaviorJsonConverter),

            typeof(global::Exa.JsonConverters.CreateMonitorParametersBehaviorConfigBehaviorNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehavior2JsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehavior2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateMonitorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateMonitorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersVariant1FormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersVariant1FormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseObjectJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseStatusJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFailedReasonJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFailedReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentFormatJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.EventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchBehaviorJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchBehaviorNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchCanceledReasonJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchCanceledReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ListMonitorsStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ListMonitorsStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateAgentRunAcceptJsonConverter),

            typeof(global::Exa.JsonConverters.CreateAgentRunAcceptNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ListAgentRunEventsAcceptJsonConverter),

            typeof(global::Exa.JsonConverters.ListAgentRunEventsAcceptNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetsGetExpandItemJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetsGetExpandItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebhooksAttemptsListEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.WebhooksAttemptsListEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EventsListTypeJsonConverter),

            typeof(global::Exa.JsonConverters.EventsListTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.JsonValueJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResponseJsonConverter),

            typeof(global::Exa.JsonConverters.AnswerStreamChunkJsonConverter),

            typeof(global::Exa.JsonConverters.SearchStreamChunkJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassJsonConverter),

            typeof(global::Exa.JsonConverters.ProfileJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1JsonConverter),

            typeof(global::Exa.JsonConverters.OutputJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2JsonConverter),

            typeof(global::Exa.JsonConverters.DataJsonConverter),

            typeof(global::Exa.JsonConverters.Output2JsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3JsonConverter),

            typeof(global::Exa.JsonConverters.Data2JsonConverter),

            typeof(global::Exa.JsonConverters.EntityJsonConverter),

            typeof(global::Exa.JsonConverters.GetWebsetResponseJsonConverter),

            typeof(global::Exa.JsonConverters.EventJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersJsonConverter),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchRequestContextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchRequestOutputSchemaVariant1, global::Exa.SearchRequestOutputSchemaVariant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsTextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsHighlightsVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsContextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestTextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestHighlightsVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestContextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsText>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsHighlights>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsSummary>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsContext>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsLivecrawl?, string>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorOutputSchemaVariant1Variant1, global::Exa.SearchMonitorOutputSchemaVariant1Variant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.JsonValue?, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchResultOutputEntitieVariant1, global::Exa.SearchResultOutputEntitieVariant2, global::Exa.SearchResultOutputEntitieVariant3>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputText>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputHighlights>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputSummary>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputContext>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant1, global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>),

            typeof(global::Exa.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2>), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2_b38b04325112cfda")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>), TypeInfoPropertyName = "WebsetItemCustomProperties_976e7369ebb8440c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2>?), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2_49282bf6215dfc2e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>?), TypeInfoPropertyName = "WebsetItemCustomProperties_2a7882e053a7bb38")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompany))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyRevenueSource1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyRevenueSource5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyLastFunding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyHeadquarters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyStockTicker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyStockTicker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditional))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditionalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditionalItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryTotal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentEducation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItemInstitutionLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentRecommendation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentRecommendation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentActivityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentActivityItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentAward>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentAward))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCourse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCourse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCertification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCertification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentPatent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentPatent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentPublication>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentPublication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentOrganization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentGithub))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentGithubReposSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentGithubReposSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProfileRootFieldChangesSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProfileRootFieldChangesSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProfileCollectionFieldChangesSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProfileCollectionFieldChangesSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyStartedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyStartedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyClosedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyClosedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentVersion), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant4ContentVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminatorType), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationCategory), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationSource), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCostDollars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCanceled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCanceledModel), TypeInfoPropertyName = "ResearchDtoClassCanceledModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCanceledStatus), TypeInfoPropertyName = "ResearchDtoClassCanceledStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassFailedModel), TypeInfoPropertyName = "ResearchDtoClassFailedModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassFailedStatus), TypeInfoPropertyName = "ResearchDtoClassFailedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassDiscriminatorStatus), TypeInfoPropertyName = "ResearchDtoClassDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1), TypeInfoPropertyName = "ResearchEventDtoClassVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchDefinitionEventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant1ResearchDefinitionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputEventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant1ResearchOutputEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Output), TypeInfoPropertyName = "Output2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedCostDollars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1DiscriminatorEventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant1DiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2), TypeInfoPropertyName = "ResearchEventDtoClassVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanDefinitionEventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2PlanDefinitionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationEventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2PlanOperationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Data), TypeInfoPropertyName = "Data2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThinkType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2PlanOperationDataThinkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearchType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2PlanOperationDataSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawlType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2PlanOperationDataCrawlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawlResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputEventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2PlanOutputEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Output2), TypeInfoPropertyName = "Output22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2PlanOutputOutputStopOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2DiscriminatorEventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant2DiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3), TypeInfoPropertyName = "ResearchEventDtoClassVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskDefinitionEventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3TaskDefinitionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationEventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3TaskOperationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Data2), TypeInfoPropertyName = "Data22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThinkType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3TaskOperationDataThinkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3TaskOperationDataSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawlType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3TaskOperationDataCrawlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawlResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOutputEventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3TaskOutputEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOutputOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOutputOutputOutputType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3TaskOutputOutputOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3DiscriminatorEventType), TypeInfoPropertyName = "ResearchEventDtoClassVariant3DiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CompanyEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PersonEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ArticleEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchPaperEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CustomEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Entity), TypeInfoPropertyName = "Entity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateCriterionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateEnrichmentParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateEnrichmentParametersFormat), TypeInfoPropertyName = "CreateEnrichmentParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParametersOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateEnrichmentParametersOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateCriterionParameters>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersExcludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersExcludeItemSource), TypeInfoPropertyName = "CreateWebsetParametersExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchStatus), TypeInfoPropertyName = "WebsetSearchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetSearchCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchCriteriaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchBehavior), TypeInfoPropertyName = "WebsetSearchBehavior2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Import))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportObject), TypeInfoPropertyName = "ImportObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportStatus), TypeInfoPropertyName = "ImportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFormat), TypeInfoPropertyName = "ImportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFailedReason), TypeInfoPropertyName = "ImportFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichmentStatus), TypeInfoPropertyName = "WebsetEnrichmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichmentFormat), TypeInfoPropertyName = "WebsetEnrichmentFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetEnrichmentOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichmentOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunObject), TypeInfoPropertyName = "MonitorRunObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunStatus), TypeInfoPropertyName = "MonitorRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunType), TypeInfoPropertyName = "MonitorRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Monitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorObject), TypeInfoPropertyName = "MonitorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorStatus), TypeInfoPropertyName = "MonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorCadence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehavior))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.MonitorBehaviorConfigCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfigCriteriaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfigBehavior), TypeInfoPropertyName = "MonitorBehaviorConfigBehavior2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Webset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetStatus), TypeInfoPropertyName = "WebsetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetSearch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Import>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetEnrichment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Monitor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetExclude>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetExclude))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetExcludeSource), TypeInfoPropertyName = "WebsetExcludeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonProperties))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompany))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyHeadquarters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyFinancials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyWebTraffic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemArticleProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemArticlePropertiesArticle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemResearchPaperProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemResearchPaperPropertiesResearchPaper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCustomProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCustomPropertiesCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemEvaluationSatisfied), TypeInfoPropertyName = "WebsetItemEvaluationSatisfied2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluationReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemEvaluationReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EnrichmentResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EnrichmentResultStatus), TypeInfoPropertyName = "EnrichmentResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.EnrichmentResultReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EnrichmentResultReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemSource), TypeInfoPropertyName = "WebsetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.EnrichmentResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetWebsetResponse), TypeInfoPropertyName = "GetWebsetResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetWebsetResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateWebsetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListWebsetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Webset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetParametersSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>), TypeInfoPropertyName = "OneOfCompanyEntityPersonEntityArticleEntityResearchPaperEntityCustomEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseSearchCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseSearchCriteriaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat), TypeInfoPropertyName = "PreviewWebsetResponseEnrichmentFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichmentOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichmentOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItemPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListWebsetItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateEnrichmentParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateEnrichmentParametersFormat), TypeInfoPropertyName = "UpdateEnrichmentParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.UpdateEnrichmentParametersOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateEnrichmentParametersOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebhookParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.EventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventType), TypeInfoPropertyName = "EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Webhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebhookStatus), TypeInfoPropertyName = "WebhookStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateWebhookParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListWebhooksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebhookAttempt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebhookAttemptEventType), TypeInfoPropertyName = "WebhookAttemptEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListWebhookAttemptsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebhookAttempt>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersExcludeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersExcludeItemSource), TypeInfoPropertyName = "CreateWebsetSearchParametersExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersScopeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersScopeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersScopeItemSource), TypeInfoPropertyName = "CreateWebsetSearchParametersScopeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersScopeItemRelationship))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateMonitorParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateMonitorParametersCadence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateMonitorParametersBehavior))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateMonitorParametersBehaviorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.CreateMonitorParametersBehaviorConfigCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateMonitorParametersBehaviorConfigCriteriaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateMonitorParametersBehaviorConfigBehavior), TypeInfoPropertyName = "CreateMonitorParametersBehaviorConfigBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListMonitorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorCadence2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehavior2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.MonitorBehaviorConfigCriteriaItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfigCriteriaItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfigBehavior2), TypeInfoPropertyName = "MonitorBehaviorConfigBehavior22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateMonitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateMonitorStatus), TypeInfoPropertyName = "UpdateMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListMonitorRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.MonitorRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParameters), TypeInfoPropertyName = "CreateImportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1Format), TypeInfoPropertyName = "CreateImportParametersVariant1Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1Csv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersDiscriminatorFormat), TypeInfoPropertyName = "CreateImportParametersDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseObject), TypeInfoPropertyName = "CreateImportResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseStatus), TypeInfoPropertyName = "CreateImportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFormat), TypeInfoPropertyName = "CreateImportResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFailedReason), TypeInfoPropertyName = "CreateImportResponseFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListImportsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListMonitorsStatus), TypeInfoPropertyName = "ListMonitorsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunAccept), TypeInfoPropertyName = "CreateAgentRunAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListAgentRunEventsAccept), TypeInfoPropertyName = "ListAgentRunEventsAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetsGetExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetsGetExpandItem), TypeInfoPropertyName = "WebsetsGetExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebhooksAttemptsListEventType), TypeInfoPropertyName = "WebhooksAttemptsListEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.EventsListType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventsListType), TypeInfoPropertyName = "EventsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.JsonValue?), TypeInfoPropertyName = "NullableJsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableContentsOptionsTextVariant1IncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableContentsOptionsTextVariant1ExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableContentsRequestTextVariant1IncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableContentsRequestTextVariant1ExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsText>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsTextIncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsTextExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsHighlights>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsHighlights2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsSummary>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsContext>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsLivecrawl?, string>?), TypeInfoPropertyName = "NullableOneOfSearchMonitorContentsLivecrawlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsLivecrawl?), TypeInfoPropertyName = "NullableSearchMonitorContentsLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookEvent?), TypeInfoPropertyName = "NullableSearchMonitorWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestAction?), TypeInfoPropertyName = "NullableBatchMonitorsRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsRequestFilterStatus?), TypeInfoPropertyName = "NullableBatchMonitorsRequestFilterStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersStatus?), TypeInfoPropertyName = "NullableUpdateSearchMonitorParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateSearchMonitorParametersWebhookEvent?), TypeInfoPropertyName = "NullableUpdateSearchMonitorParametersWebhookEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentEffort?), TypeInfoPropertyName = "NullableAgentEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSourceProvider?), TypeInfoPropertyName = "NullableAgentDataSourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchResponse?), TypeInfoPropertyName = "NullableSearchResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuseStatus?), TypeInfoPropertyName = "NullableContentsResponseStatuseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ContentsResponseStatuseSource?), TypeInfoPropertyName = "NullableContentsResponseStatuseSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, object>?), TypeInfoPropertyName = "NullableOneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateSearchMonitorResponseStatus?), TypeInfoPropertyName = "NullableCreateSearchMonitorResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorStatus?), TypeInfoPropertyName = "NullableSearchMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.BatchMonitorsResponseAction?), TypeInfoPropertyName = "NullableBatchMonitorsResponseAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunStatus?), TypeInfoPropertyName = "NullableSearchMonitorRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.JsonValue?, object>?), TypeInfoPropertyName = "NullableOneOfJsonValueObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence?), TypeInfoPropertyName = "NullableSearchMonitorRunOutputGroundingVariant1ItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunStatus?), TypeInfoPropertyName = "NullableAgentRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorType?), TypeInfoPropertyName = "NullableAgentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorCode?), TypeInfoPropertyName = "NullableAgentErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AnswerStreamChunk?), TypeInfoPropertyName = "NullableAnswerStreamChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunk?), TypeInfoPropertyName = "NullableSearchStreamChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchStreamChunkVariant2GroundingItemConfidence?), TypeInfoPropertyName = "NullableSearchStreamChunkVariant2GroundingItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunEventEvent?), TypeInfoPropertyName = "NullableAgentRunEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchResultOutputEntitieVariant1, global::Exa.SearchResultOutputEntitieVariant2, global::Exa.SearchResultOutputEntitieVariant3>?), TypeInfoPropertyName = "NullableOneOfSearchResultOutputEntitieVariant1SearchResultOutputEntitieVariant2SearchResultOutputEntitieVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence?), TypeInfoPropertyName = "NullableSearchSynthesisOutputOutputGroundingItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputText>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsOutputText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputTextIncludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputTextExcludeSectionsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputHighlights>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsOutputHighlights2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputSummary>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsOutputSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputContext>?), TypeInfoPropertyName = "NullableOneOfBooleanSearchMonitorContentsOutputContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>?), TypeInfoPropertyName = "NullableOneOfSearchMonitorContentsOutputLivecrawlString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorContentsOutputLivecrawl?), TypeInfoPropertyName = "NullableSearchMonitorContentsOutputLivecrawl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorWebhookOutputEvent?), TypeInfoPropertyName = "NullableSearchMonitorWebhookOutputEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClass?), TypeInfoPropertyName = "NullableResearchDtoClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchCreateRequestDtoClassModel?), TypeInfoPropertyName = "NullableResearchCreateRequestDtoClassModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassPendingModel?), TypeInfoPropertyName = "NullableResearchDtoClassPendingModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassPendingStatus?), TypeInfoPropertyName = "NullableResearchDtoClassPendingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassRunningModel?), TypeInfoPropertyName = "NullableResearchDtoClassRunningModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassRunningStatus?), TypeInfoPropertyName = "NullableResearchDtoClassRunningStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClass?), TypeInfoPropertyName = "NullableResearchEventDtoClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedModel?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedStatus?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Profile?), TypeInfoPropertyName = "NullableProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1Type?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2Type?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Version?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Version?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitions?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDate?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivity?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3Type?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4Type?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentVersion?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileVariant4ContentVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminatorType?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationProfileDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationCategory?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCompletedCitationSource?), TypeInfoPropertyName = "NullableResearchDtoClassCompletedCitationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCanceledModel?), TypeInfoPropertyName = "NullableResearchDtoClassCanceledModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassCanceledStatus?), TypeInfoPropertyName = "NullableResearchDtoClassCanceledStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassFailedModel?), TypeInfoPropertyName = "NullableResearchDtoClassFailedModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassFailedStatus?), TypeInfoPropertyName = "NullableResearchDtoClassFailedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchDtoClassDiscriminatorStatus?), TypeInfoPropertyName = "NullableResearchDtoClassDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchDefinitionEventType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant1ResearchDefinitionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputEventType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant1ResearchOutputEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Output?), TypeInfoPropertyName = "NullableOutput2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant1DiscriminatorEventType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant1DiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanDefinitionEventType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2PlanDefinitionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationEventType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2PlanOperationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Data?), TypeInfoPropertyName = "NullableData2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThinkType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2PlanOperationDataThinkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearchType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2PlanOperationDataSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2PlanOperationDataSearchSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawlType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2PlanOperationDataCrawlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputEventType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2PlanOutputEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Output2?), TypeInfoPropertyName = "NullableOutput22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2PlanOutputOutputTasksOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2PlanOutputOutputStopOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant2DiscriminatorEventType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant2DiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskDefinitionEventType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant3TaskDefinitionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationEventType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant3TaskOperationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Data2?), TypeInfoPropertyName = "NullableData22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThinkType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant3TaskOperationDataThinkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant3TaskOperationDataSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant3TaskOperationDataSearchSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawlType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant3TaskOperationDataCrawlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOutputEventType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant3TaskOutputEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOutputOutputOutputType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant3TaskOutputOutputOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchEventDtoClassVariant3DiscriminatorEventType?), TypeInfoPropertyName = "NullableResearchEventDtoClassVariant3DiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Entity?), TypeInfoPropertyName = "NullableEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateEnrichmentParametersFormat?), TypeInfoPropertyName = "NullableCreateEnrichmentParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersSearchExcludeItemSource?), TypeInfoPropertyName = "NullableCreateWebsetParametersSearchExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersSearchScopeItemSource?), TypeInfoPropertyName = "NullableCreateWebsetParametersSearchScopeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersImportItemSource?), TypeInfoPropertyName = "NullableCreateWebsetParametersImportItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetParametersExcludeItemSource?), TypeInfoPropertyName = "NullableCreateWebsetParametersExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchStatus?), TypeInfoPropertyName = "NullableWebsetSearchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchBehavior?), TypeInfoPropertyName = "NullableWebsetSearchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchExcludeItemSource?), TypeInfoPropertyName = "NullableWebsetSearchExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchScopeItemSource?), TypeInfoPropertyName = "NullableWebsetSearchScopeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchRecallExpectedConfidence?), TypeInfoPropertyName = "NullableWebsetSearchRecallExpectedConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetSearchCanceledReason?), TypeInfoPropertyName = "NullableWebsetSearchCanceledReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportObject?), TypeInfoPropertyName = "NullableImportObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportStatus?), TypeInfoPropertyName = "NullableImportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFormat?), TypeInfoPropertyName = "NullableImportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFailedReason?), TypeInfoPropertyName = "NullableImportFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichmentStatus?), TypeInfoPropertyName = "NullableWebsetEnrichmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetEnrichmentFormat?), TypeInfoPropertyName = "NullableWebsetEnrichmentFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunObject?), TypeInfoPropertyName = "NullableMonitorRunObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunStatus?), TypeInfoPropertyName = "NullableMonitorRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorRunType?), TypeInfoPropertyName = "NullableMonitorRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorObject?), TypeInfoPropertyName = "NullableMonitorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorStatus?), TypeInfoPropertyName = "NullableMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfigBehavior?), TypeInfoPropertyName = "NullableMonitorBehaviorConfigBehavior2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetStatus?), TypeInfoPropertyName = "NullableWebsetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetExcludeSource?), TypeInfoPropertyName = "NullableWebsetExcludeSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemEvaluationSatisfied?), TypeInfoPropertyName = "NullableWebsetItemEvaluationSatisfied2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EnrichmentResultStatus?), TypeInfoPropertyName = "NullableEnrichmentResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemSource?), TypeInfoPropertyName = "NullableWebsetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.GetWebsetResponse?), TypeInfoPropertyName = "NullableGetWebsetResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>?), TypeInfoPropertyName = "NullableOneOfCompanyEntityPersonEntityArticleEntityResearchPaperEntityCustomEntity2")]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Exa.JsonConverters.SearchRequestType2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestType2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCategory2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCategory2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCompliance2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchRequestCompliance2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1Verbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1Verbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1IncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1IncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1ExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsTextVariant1ExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsLivecrawl2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsOptionsLivecrawl2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestCompliance2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestCompliance2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1Verbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1Verbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1IncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1IncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1ExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestTextVariant1ExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestLivecrawl2JsonConverter),

            typeof(global::Exa.JsonConverters.ContentsRequestLivecrawl2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.FindSimilarRequestCategory2JsonConverter),

            typeof(global::Exa.JsonConverters.FindSimilarRequestCategory2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextVerbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextVerbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextIncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextIncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsTextExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsLivecrawlJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsLivecrawlNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookEventJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestActionJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestActionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestFilterStatusJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsRequestFilterStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersStatusJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersWebhookEventJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersWebhookEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentEffortJsonConverter),

            typeof(global::Exa.JsonConverters.AgentEffortNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentDataSourceProviderJsonConverter),

            typeof(global::Exa.JsonConverters.AgentDataSourceProviderNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseSourceJsonConverter),

            typeof(global::Exa.JsonConverters.ContentsResponseStatuseSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateSearchMonitorResponseStatusJsonConverter),

            typeof(global::Exa.JsonConverters.CreateSearchMonitorResponseStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsResponseActionJsonConverter),

            typeof(global::Exa.JsonConverters.BatchMonitorsResponseActionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunStatusJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunFailReason2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunFailReason2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunStatusJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentStopReasonJsonConverter),

            typeof(global::Exa.JsonConverters.AgentStopReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentGroundingConfidence2JsonConverter),

            typeof(global::Exa.JsonConverters.AgentGroundingConfidence2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorCodeJsonConverter),

            typeof(global::Exa.JsonConverters.AgentErrorCodeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchStreamChunkVariant2GroundingItemConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.SearchStreamChunkVariant2GroundingItemConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunEventEventJsonConverter),

            typeof(global::Exa.JsonConverters.AgentRunEventEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResultOutputEntitieVariant3PropertiesType2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchResultOutputEntitieVariant3PropertiesType2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchSynthesisOutputOutputGroundingItemConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.SearchSynthesisOutputOutputGroundingItemConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextVerbosity2JsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextVerbosity2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextIncludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextIncludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextExcludeSectionsVariant1ItemJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputTextExcludeSectionsVariant1ItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputLivecrawlJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorContentsOutputLivecrawlNullableJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookOutputEventJsonConverter),

            typeof(global::Exa.JsonConverters.SearchMonitorWebhookOutputEventNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchCreateRequestDtoClassModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchCreateRequestDtoClassModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassPendingStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassRunningStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant1TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant1TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1VersionJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1VersionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2VersionJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2VersionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitionsJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitionsNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDateJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDateNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivityJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivityNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant3TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant3TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4TypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4TypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentVersionJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentVersionNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationCategoryJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationCategoryNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationSourceJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassCanceledStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedModelJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedModelNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassFailedStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassDiscriminatorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassDiscriminatorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchDefinitionEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchDefinitionEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1DiscriminatorEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1DiscriminatorEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanDefinitionEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanDefinitionEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataThinkTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataThinkTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataCrawlTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataCrawlTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2DiscriminatorEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2DiscriminatorEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskDefinitionEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskDefinitionEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataThinkTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataThinkTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputOutputOutputTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputOutputOutputTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3DiscriminatorEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3DiscriminatorEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateEnrichmentParametersFormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateEnrichmentParametersFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchScopeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersSearchScopeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersImportItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersImportItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetParametersExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchScopeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchScopeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchRecallExpectedConfidenceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchRecallExpectedConfidenceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportObjectJsonConverter),

            typeof(global::Exa.JsonConverters.ImportObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ImportStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFormatJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFailedReasonJsonConverter),

            typeof(global::Exa.JsonConverters.ImportFailedReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunObjectJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunStatusJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunTypeJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorRunTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorObjectJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehaviorJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehaviorNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetExcludeSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetExcludeSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemEvaluationSatisfiedJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemEvaluationSatisfiedNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EnrichmentResultStatusJsonConverter),

            typeof(global::Exa.JsonConverters.EnrichmentResultStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatJsonConverter),

            typeof(global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateEnrichmentParametersFormatJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateEnrichmentParametersFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookStatusJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookAttemptEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.WebhookAttemptEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EventDiscriminatorTypeJsonConverter),

            typeof(global::Exa.JsonConverters.EventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersExcludeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersExcludeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersScopeItemSourceJsonConverter),

            typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersScopeItemSourceNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateMonitorParametersBehaviorConfigBehaviorJsonConverter),

            typeof(global::Exa.JsonConverters.CreateMonitorParametersBehaviorConfigBehaviorNullableJsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehavior2JsonConverter),

            typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehavior2NullableJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateMonitorStatusJsonConverter),

            typeof(global::Exa.JsonConverters.UpdateMonitorStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersVariant1FormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersVariant1FormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseObjectJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseObjectNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseStatusJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFormatJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFailedReasonJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportResponseFailedReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentFormatJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetEnrichmentFormatNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.EventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchBehaviorJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchBehaviorNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchCanceledReasonJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetSearchCanceledReasonNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ListMonitorsStatusJsonConverter),

            typeof(global::Exa.JsonConverters.ListMonitorsStatusNullableJsonConverter),

            typeof(global::Exa.JsonConverters.CreateAgentRunAcceptJsonConverter),

            typeof(global::Exa.JsonConverters.CreateAgentRunAcceptNullableJsonConverter),

            typeof(global::Exa.JsonConverters.ListAgentRunEventsAcceptJsonConverter),

            typeof(global::Exa.JsonConverters.ListAgentRunEventsAcceptNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetsGetExpandItemJsonConverter),

            typeof(global::Exa.JsonConverters.WebsetsGetExpandItemNullableJsonConverter),

            typeof(global::Exa.JsonConverters.WebhooksAttemptsListEventTypeJsonConverter),

            typeof(global::Exa.JsonConverters.WebhooksAttemptsListEventTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.EventsListTypeJsonConverter),

            typeof(global::Exa.JsonConverters.EventsListTypeNullableJsonConverter),

            typeof(global::Exa.JsonConverters.JsonValueJsonConverter),

            typeof(global::Exa.JsonConverters.SearchResponseJsonConverter),

            typeof(global::Exa.JsonConverters.AnswerStreamChunkJsonConverter),

            typeof(global::Exa.JsonConverters.SearchStreamChunkJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchDtoClassJsonConverter),

            typeof(global::Exa.JsonConverters.ProfileJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1JsonConverter),

            typeof(global::Exa.JsonConverters.OutputJsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2JsonConverter),

            typeof(global::Exa.JsonConverters.DataJsonConverter),

            typeof(global::Exa.JsonConverters.Output2JsonConverter),

            typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3JsonConverter),

            typeof(global::Exa.JsonConverters.Data2JsonConverter),

            typeof(global::Exa.JsonConverters.EntityJsonConverter),

            typeof(global::Exa.JsonConverters.GetWebsetResponseJsonConverter),

            typeof(global::Exa.JsonConverters.EventJsonConverter),

            typeof(global::Exa.JsonConverters.CreateImportParametersJsonConverter),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchRequestContextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchRequestOutputSchemaVariant1, global::Exa.SearchRequestOutputSchemaVariant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsTextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsHighlightsVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsContextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestTextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestHighlightsVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestContextVariant1>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsText>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsHighlights>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsSummary>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsContext>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsLivecrawl?, string>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorOutputSchemaVariant1Variant1, global::Exa.SearchMonitorOutputSchemaVariant1Variant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.JsonValue?, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchResultOutputEntitieVariant1, global::Exa.SearchResultOutputEntitieVariant2, global::Exa.SearchResultOutputEntitieVariant3>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputText>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputHighlights>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputSummary>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputContext>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant1, global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>),

            typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>),

            typeof(global::Exa.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2>), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2_b38b04325112cfda")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>), TypeInfoPropertyName = "WebsetItemCustomProperties_976e7369ebb8440c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2>?), TypeInfoPropertyName = "ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2_49282bf6215dfc2e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>?), TypeInfoPropertyName = "WebsetItemCustomProperties_2a7882e053a7bb38")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat?), TypeInfoPropertyName = "NullablePreviewWebsetResponseEnrichmentFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateEnrichmentParametersFormat?), TypeInfoPropertyName = "NullableUpdateEnrichmentParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventType?), TypeInfoPropertyName = "NullableEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebhookStatus?), TypeInfoPropertyName = "NullableWebhookStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebhookAttemptEventType?), TypeInfoPropertyName = "NullableWebhookAttemptEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Event?), TypeInfoPropertyName = "NullableEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventDiscriminatorType?), TypeInfoPropertyName = "NullableEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersExcludeItemSource?), TypeInfoPropertyName = "NullableCreateWebsetSearchParametersExcludeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateWebsetSearchParametersScopeItemSource?), TypeInfoPropertyName = "NullableCreateWebsetSearchParametersScopeItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateMonitorParametersBehaviorConfigBehavior?), TypeInfoPropertyName = "NullableCreateMonitorParametersBehaviorConfigBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.MonitorBehaviorConfigBehavior2?), TypeInfoPropertyName = "NullableMonitorBehaviorConfigBehavior22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateMonitorStatus?), TypeInfoPropertyName = "NullableUpdateMonitorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParameters?), TypeInfoPropertyName = "NullableCreateImportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1Format?), TypeInfoPropertyName = "NullableCreateImportParametersVariant1Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersDiscriminatorFormat?), TypeInfoPropertyName = "NullableCreateImportParametersDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseObject?), TypeInfoPropertyName = "NullableCreateImportResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseStatus?), TypeInfoPropertyName = "NullableCreateImportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFormat?), TypeInfoPropertyName = "NullableCreateImportResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFailedReason?), TypeInfoPropertyName = "NullableCreateImportResponseFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListMonitorsStatus?), TypeInfoPropertyName = "NullableListMonitorsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunAccept?), TypeInfoPropertyName = "NullableCreateAgentRunAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListAgentRunEventsAccept?), TypeInfoPropertyName = "NullableListAgentRunEventsAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetsGetExpandItem?), TypeInfoPropertyName = "NullableWebsetsGetExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebhooksAttemptsListEventType?), TypeInfoPropertyName = "NullableWebhooksAttemptsListEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.EventsListType?), TypeInfoPropertyName = "NullableEventsListType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.JsonValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsOptionsTextVariant1IncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsOptionsTextVariant1ExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.UpdateSearchMonitorParametersWebhookEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentDataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ContentsResponseStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AnswerResponseCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentDataSourceOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentGrounding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentRunEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AnswerStreamChunkVariant1Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AnswerStreamChunkVariant2Citation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamChunkVariant1Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamChunkVariant1ChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamChunkVariant2GroundingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamChunkVariant2GroundingItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamChunkVariant2Citation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamChunkVariant2Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamChunkVariant2ChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamChunkVariant5Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchStreamChunkVariant5ChoiceDeltaCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutputSubpage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.OneOf<global::Exa.SearchResultOutputEntitieVariant1, global::Exa.SearchResultOutputEntitieVariant2, global::Exa.SearchResultOutputEntitieVariant3>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutputEntitieVariant1PropertiesWebTrafficHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutputEntitieVariant2PropertiesWorkHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutputEntitieVariant2PropertiesEducationHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchResultOutputEntitieVariant3PropertiesAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchSynthesisOutputOutputGroundingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchSynthesisOutputOutputGroundingItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsOutputTextIncludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorContentsOutputTextExcludeSectionsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorWebhookOutputEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchEventDtoClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationSubpage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentAffiliatedCompanie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentLocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1IdentityTicker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1LocationsOffice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesSocialItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceBySeniorityMonthlyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByDepartmentMonthlyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByRegionMonthlyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByCountryMonthlyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceExecutive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceRecentHire>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceRecentDeparture>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceTopPreviousCompanie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceTopNextCompanie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPosting>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPostingsHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceSalaryRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsIncomeStatement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsStockHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsFundingRound>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsInvestment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1MarketCompetitor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsProductPricingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsTechnologie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1NewsActivityNew>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1NewsActivityPressRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2ProfilesSocialItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRound>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentWebsite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentExperienceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentEducationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentCertification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPatent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPatentContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentVolunteeringItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPublication>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentSocialActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentSocialGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByDepartmentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByManagementLevelItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyStockTicker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditionalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentRecommendation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentActivityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentAward>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCourse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCertification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentPatent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentPublication>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentOrganization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentGithubReposSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProfileRootFieldChangesSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProfileCollectionFieldChangesSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyStartedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyClosedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchEventDtoClassVariant2PlanOperationDataSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateEnrichmentParametersOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateCriterionParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersSearchExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersSearchScopeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersImportItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateEnrichmentParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetParametersExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetSearchCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetSearchExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetSearchScopeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetEnrichmentOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.MonitorBehaviorConfigCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetSearch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Import>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetEnrichment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Monitor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetExclude>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemEvaluationReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.EnrichmentResultReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.EnrichmentResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Webset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseSearchCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseEnrichment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseEnrichmentOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.UpdateEnrichmentParametersOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.EventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebhookAttempt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetSearchParametersExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateWebsetSearchParametersScopeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.CreateMonitorParametersBehaviorConfigCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.MonitorBehaviorConfigCriteriaItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.MonitorRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetsGetExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.EventsListType>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default,

            SourceGenerationContextChunk2.Default
            );

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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Exa.JsonConverters.SearchRequestType2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchRequestType2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchRequestCategory2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchRequestCategory2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchRequestCompliance2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchRequestCompliance2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsOptionsTextVariant1Verbosity2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsOptionsTextVariant1Verbosity2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsOptionsTextVariant1IncludeSectionsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsOptionsTextVariant1IncludeSectionsVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsOptionsTextVariant1ExcludeSectionsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsOptionsTextVariant1ExcludeSectionsVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsOptionsLivecrawl2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsOptionsLivecrawl2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsRequestCompliance2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsRequestCompliance2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsRequestTextVariant1Verbosity2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsRequestTextVariant1Verbosity2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsRequestTextVariant1IncludeSectionsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsRequestTextVariant1IncludeSectionsVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsRequestTextVariant1ExcludeSectionsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsRequestTextVariant1ExcludeSectionsVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsRequestLivecrawl2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsRequestLivecrawl2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.FindSimilarRequestCategory2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.FindSimilarRequestCategory2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsTextVerbosity2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsTextVerbosity2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsTextIncludeSectionsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsTextIncludeSectionsVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsTextExcludeSectionsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsTextExcludeSectionsVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsLivecrawlJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsLivecrawlNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorWebhookEventJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorWebhookEventNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.BatchMonitorsRequestActionJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.BatchMonitorsRequestActionNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.BatchMonitorsRequestFilterStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.BatchMonitorsRequestFilterStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.UpdateSearchMonitorParametersStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.UpdateSearchMonitorParametersStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.UpdateSearchMonitorParametersWebhookEventJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.UpdateSearchMonitorParametersWebhookEventNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentEffortJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentEffortNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentDataSourceProviderJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentDataSourceProviderNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsResponseStatuseStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsResponseStatuseStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsResponseStatuseSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ContentsResponseStatuseSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateSearchMonitorResponseStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateSearchMonitorResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.BatchMonitorsResponseActionJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.BatchMonitorsResponseActionNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorRunStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorRunStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorRunFailReason2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorRunFailReason2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentRunStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentRunStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentStopReasonJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentStopReasonNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentGroundingConfidence2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentGroundingConfidence2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentErrorTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentErrorCodeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentErrorCodeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchStreamChunkVariant2GroundingItemConfidenceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchStreamChunkVariant2GroundingItemConfidenceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentRunEventEventJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AgentRunEventEventNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchResultOutputEntitieVariant3PropertiesType2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchResultOutputEntitieVariant3PropertiesType2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchSynthesisOutputOutputGroundingItemConfidenceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchSynthesisOutputOutputGroundingItemConfidenceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsOutputTextVerbosity2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsOutputTextVerbosity2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsOutputTextIncludeSectionsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsOutputTextIncludeSectionsVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsOutputTextExcludeSectionsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsOutputTextExcludeSectionsVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsOutputLivecrawlJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorContentsOutputLivecrawlNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorWebhookOutputEventJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchMonitorWebhookOutputEventNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchCreateRequestDtoClassModelJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchCreateRequestDtoClassModelNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassPendingModelJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassPendingModelNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassPendingStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassPendingStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassRunningModelJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassRunningModelNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassRunningStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassRunningStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedModelJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedModelNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant1TypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2TypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1VersionJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1VersionNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2VersionJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2VersionNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitionsJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitionsNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDateJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDateNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivityJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivityNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant3TypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4TypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4TypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentVersionJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentVersionNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationCategoryJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationCategoryNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCompletedCitationSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCanceledModelJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCanceledModelNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCanceledStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassCanceledStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassFailedModelJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassFailedModelNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassFailedStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassFailedStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassDiscriminatorStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassDiscriminatorStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchDefinitionEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchDefinitionEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1DiscriminatorEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1DiscriminatorEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanDefinitionEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanDefinitionEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataThinkTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataThinkTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchSearchTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataSearchSearchTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataCrawlTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataCrawlTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2DiscriminatorEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2DiscriminatorEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskDefinitionEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskDefinitionEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataThinkTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataThinkTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputOutputOutputTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOutputOutputOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3DiscriminatorEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3DiscriminatorEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateEnrichmentParametersFormatJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateEnrichmentParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetParametersSearchExcludeItemSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetParametersSearchExcludeItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetParametersSearchScopeItemSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetParametersSearchScopeItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetParametersImportItemSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetParametersImportItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetParametersExcludeItemSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetParametersExcludeItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchExcludeItemSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchExcludeItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchScopeItemSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchScopeItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchRecallExpectedConfidenceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchRecallExpectedConfidenceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ImportObjectJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ImportObjectNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ImportStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ImportStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ImportFormatJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ImportFormatNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ImportFailedReasonJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ImportFailedReasonNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetEnrichmentStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetEnrichmentStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorRunObjectJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorRunObjectNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorRunStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorRunStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorRunTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorRunTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorObjectJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorObjectNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorBehaviorConfigBehaviorJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorBehaviorConfigBehaviorNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetExcludeSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetExcludeSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetItemEvaluationSatisfiedJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetItemEvaluationSatisfiedNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EnrichmentResultStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EnrichmentResultStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetItemSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.UpdateEnrichmentParametersFormatJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.UpdateEnrichmentParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebhookStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebhookStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebhookAttemptEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebhookAttemptEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EventDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EventDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetSearchParametersExcludeItemSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetSearchParametersExcludeItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetSearchParametersScopeItemSourceJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateWebsetSearchParametersScopeItemSourceNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateMonitorParametersBehaviorConfigBehaviorJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateMonitorParametersBehaviorConfigBehaviorNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorBehaviorConfigBehavior2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.MonitorBehaviorConfigBehavior2NullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.UpdateMonitorStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.UpdateMonitorStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportParametersVariant1FormatJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportParametersVariant1FormatNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportResponseObjectJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportResponseObjectNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportResponseStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportResponseFormatJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportResponseFormatNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportResponseFailedReasonJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportResponseFailedReasonNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetEnrichmentFormatJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetEnrichmentFormatNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchBehaviorJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchBehaviorNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchCanceledReasonJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetSearchCanceledReasonNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ListMonitorsStatusJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ListMonitorsStatusNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateAgentRunAcceptJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateAgentRunAcceptNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ListAgentRunEventsAcceptJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ListAgentRunEventsAcceptNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetsGetExpandItemJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebsetsGetExpandItemNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebhooksAttemptsListEventTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.WebhooksAttemptsListEventTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EventsListTypeJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EventsListTypeNullableJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.JsonValueJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchResponseJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.AnswerStreamChunkJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.SearchStreamChunkJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchDtoClassJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ProfileJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant1JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.OutputJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.DataJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.Output2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.ResearchEventDtoClassVariant3JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.Data2JsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EntityJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.GetWebsetResponseJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.EventJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportParametersJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchRequestContextVariant1>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchRequestOutputSchemaVariant1, global::Exa.SearchRequestOutputSchemaVariant2>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsTextVariant1>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsHighlightsVariant1>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsOptionsContextVariant1>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestTextVariant1>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestHighlightsVariant1>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.ContentsRequestContextVariant1>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsText>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsHighlights>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsSummary>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsContext>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsLivecrawl?, string>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorOutputSchemaVariant1Variant1, global::Exa.SearchMonitorOutputSchemaVariant1Variant2>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.JsonValue?, object>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchResultOutputEntitieVariant1, global::Exa.SearchResultOutputEntitieVariant2, global::Exa.SearchResultOutputEntitieVariant3>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputText>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputHighlights>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputSummary>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputContext>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant1, global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant2>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>());
            options.Converters.Add(new global::Exa.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}