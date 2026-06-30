
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Company,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationProfileVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileVariant2Type value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileVariant2Type.Company => "company",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "company" => ResearchDtoClassCompletedCitationProfileVariant2Type.Company,
                _ => null,
            };
        }
    }
}