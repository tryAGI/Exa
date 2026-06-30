
#nullable enable

namespace Exa
{
    /// <summary>
    /// The model used for this research request<br/>
    /// Default Value: exa-research
    /// </summary>
    public enum ResearchDtoClassRunningModel
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
    public static class ResearchDtoClassRunningModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassRunningModel value)
        {
            return value switch
            {
                ResearchDtoClassRunningModel.ExaResearch => "exa-research",
                ResearchDtoClassRunningModel.ExaResearchFast => "exa-research-fast",
                ResearchDtoClassRunningModel.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassRunningModel? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchDtoClassRunningModel.ExaResearch,
                "exa-research-fast" => ResearchDtoClassRunningModel.ExaResearchFast,
                "exa-research-pro" => ResearchDtoClassRunningModel.ExaResearchPro,
                _ => null,
            };
        }
    }
}