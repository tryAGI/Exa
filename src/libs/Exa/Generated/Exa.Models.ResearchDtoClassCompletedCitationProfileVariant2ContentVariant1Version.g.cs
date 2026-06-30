
#nullable enable

namespace Exa
{
    /// <summary>
    /// Default Value: 1-complete
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Version
    {
        /// <summary>
        /// 
        /// </summary>
        x1Complete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Version value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Version.x1Complete => "1-complete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Version? ToEnum(string value)
        {
            return value switch
            {
                "1-complete" => ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Version.x1Complete,
                _ => null,
            };
        }
    }
}