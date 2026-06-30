
#nullable enable

namespace Exa
{
    /// <summary>
    /// The model used for this research request<br/>
    /// Default Value: exa-research
    /// </summary>
    public enum ResearchDtoClassCompletedModel
    {
        /// <summary>
        /// 
        /// </summary>
        ExaResearch,
        /// <summary>
        /// 
        /// </summary>
        ExaResearchFast,
        /// <summary>
        /// 
        /// </summary>
        ExaResearchPro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedModel value)
        {
            return value switch
            {
                ResearchDtoClassCompletedModel.ExaResearch => "exa-research",
                ResearchDtoClassCompletedModel.ExaResearchFast => "exa-research-fast",
                ResearchDtoClassCompletedModel.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedModel? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchDtoClassCompletedModel.ExaResearch,
                "exa-research-fast" => ResearchDtoClassCompletedModel.ExaResearchFast,
                "exa-research-pro" => ResearchDtoClassCompletedModel.ExaResearchPro,
                _ => null,
            };
        }
    }
}