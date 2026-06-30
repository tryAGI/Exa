
#nullable enable

namespace Exa
{
    /// <summary>
    /// Research model to use. exa-research is faster and cheaper, while exa-research-pro provides more thorough analysis and stronger reasoning.<br/>
    /// Default Value: exa-research
    /// </summary>
    public enum ResearchCreateRequestDtoClassModel
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
    public static class ResearchCreateRequestDtoClassModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchCreateRequestDtoClassModel value)
        {
            return value switch
            {
                ResearchCreateRequestDtoClassModel.ExaResearch => "exa-research",
                ResearchCreateRequestDtoClassModel.ExaResearchFast => "exa-research-fast",
                ResearchCreateRequestDtoClassModel.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchCreateRequestDtoClassModel? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchCreateRequestDtoClassModel.ExaResearch,
                "exa-research-fast" => ResearchCreateRequestDtoClassModel.ExaResearchFast,
                "exa-research-pro" => ResearchCreateRequestDtoClassModel.ExaResearchPro,
                _ => null,
            };
        }
    }
}