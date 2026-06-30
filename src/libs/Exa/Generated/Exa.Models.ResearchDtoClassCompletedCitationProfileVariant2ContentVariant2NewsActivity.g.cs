
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivity
    {
        /// <summary>
        /// 
        /// </summary>
        Null,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivity value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivity.Null => "null",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivity? ToEnum(string value)
        {
            return value switch
            {
                "null" => ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivity.Null,
                _ => null,
            };
        }
    }
}