
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType.Completed => "completed",
                ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType.Completed,
                "failed" => ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType.Failed,
                _ => null,
            };
        }
    }
}