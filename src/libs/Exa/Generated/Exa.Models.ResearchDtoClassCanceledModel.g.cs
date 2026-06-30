
#nullable enable

namespace Exa
{
    /// <summary>
    /// The model used for this research request<br/>
    /// Default Value: exa-research
    /// </summary>
    public enum ResearchDtoClassCanceledModel
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
    public static class ResearchDtoClassCanceledModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCanceledModel value)
        {
            return value switch
            {
                ResearchDtoClassCanceledModel.ExaResearch => "exa-research",
                ResearchDtoClassCanceledModel.ExaResearchFast => "exa-research-fast",
                ResearchDtoClassCanceledModel.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCanceledModel? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchDtoClassCanceledModel.ExaResearch,
                "exa-research-fast" => ResearchDtoClassCanceledModel.ExaResearchFast,
                "exa-research-pro" => ResearchDtoClassCanceledModel.ExaResearchPro,
                _ => null,
            };
        }
    }
}