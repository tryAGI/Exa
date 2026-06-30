
#nullable enable

namespace Exa
{
    /// <summary>
    /// Default Value: 1-reduced
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Version
    {
        /// <summary>
        /// 
        /// </summary>
        x1Reduced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Version value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Version.x1Reduced => "1-reduced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Version? ToEnum(string value)
        {
            return value switch
            {
                "1-reduced" => ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Version.x1Reduced,
                _ => null,
            };
        }
    }
}