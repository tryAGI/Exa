
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitions
    {
        /// <summary>
        /// 
        /// </summary>
        Null,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitions value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitions.Null => "null",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitions? ToEnum(string value)
        {
            return value switch
            {
                "null" => ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitions.Null,
                _ => null,
            };
        }
    }
}