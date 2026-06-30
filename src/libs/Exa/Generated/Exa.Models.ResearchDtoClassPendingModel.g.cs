
#nullable enable

namespace Exa
{
    /// <summary>
    /// The model used for this research request<br/>
    /// Default Value: exa-research
    /// </summary>
    public enum ResearchDtoClassPendingModel
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
    public static class ResearchDtoClassPendingModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassPendingModel value)
        {
            return value switch
            {
                ResearchDtoClassPendingModel.ExaResearch => "exa-research",
                ResearchDtoClassPendingModel.ExaResearchFast => "exa-research-fast",
                ResearchDtoClassPendingModel.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassPendingModel? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchDtoClassPendingModel.ExaResearch,
                "exa-research-fast" => ResearchDtoClassPendingModel.ExaResearchFast,
                "exa-research-pro" => ResearchDtoClassPendingModel.ExaResearchPro,
                _ => null,
            };
        }
    }
}