
#nullable enable

namespace Exa
{
    /// <summary>
    /// The model used for this research request<br/>
    /// Default Value: exa-research
    /// </summary>
    public enum ResearchDtoClassFailedModel
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
    public static class ResearchDtoClassFailedModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassFailedModel value)
        {
            return value switch
            {
                ResearchDtoClassFailedModel.ExaResearch => "exa-research",
                ResearchDtoClassFailedModel.ExaResearchFast => "exa-research-fast",
                ResearchDtoClassFailedModel.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassFailedModel? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchDtoClassFailedModel.ExaResearch,
                "exa-research-fast" => ResearchDtoClassFailedModel.ExaResearchFast,
                "exa-research-pro" => ResearchDtoClassFailedModel.ExaResearchPro,
                _ => null,
            };
        }
    }
}