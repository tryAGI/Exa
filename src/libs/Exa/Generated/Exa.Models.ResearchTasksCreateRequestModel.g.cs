
#nullable enable

namespace Exa
{
    /// <summary>
    /// Default Value: exa-research
    /// </summary>
    public enum ResearchTasksCreateRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        ExaResearch,
        /// <summary>
        /// 
        /// </summary>
        ExaResearchPro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchTasksCreateRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchTasksCreateRequestModel value)
        {
            return value switch
            {
                ResearchTasksCreateRequestModel.ExaResearch => "exa-research",
                ResearchTasksCreateRequestModel.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchTasksCreateRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchTasksCreateRequestModel.ExaResearch,
                "exa-research-pro" => ResearchTasksCreateRequestModel.ExaResearchPro,
                _ => null,
            };
        }
    }
}