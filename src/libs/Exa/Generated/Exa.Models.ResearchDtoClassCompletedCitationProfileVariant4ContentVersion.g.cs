
#nullable enable

namespace Exa
{
    /// <summary>
    /// Default Value: 1
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileVariant4ContentVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationProfileVariant4ContentVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileVariant4ContentVersion value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileVariant4ContentVersion.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileVariant4ContentVersion? ToEnum(string value)
        {
            return value switch
            {
                "1" => ResearchDtoClassCompletedCitationProfileVariant4ContentVersion.x1,
                _ => null,
            };
        }
    }
}