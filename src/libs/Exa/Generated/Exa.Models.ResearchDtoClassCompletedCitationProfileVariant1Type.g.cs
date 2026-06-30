
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        LinkedinCompany,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationProfileVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileVariant1Type value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileVariant1Type.LinkedinCompany => "linkedin_company",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "linkedin_company" => ResearchDtoClassCompletedCitationProfileVariant1Type.LinkedinCompany,
                _ => null,
            };
        }
    }
}