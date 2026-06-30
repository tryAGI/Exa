
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        LinkedinPerson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationProfileVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileVariant3Type value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileVariant3Type.LinkedinPerson => "linkedin_person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "linkedin_person" => ResearchDtoClassCompletedCitationProfileVariant3Type.LinkedinPerson,
                _ => null,
            };
        }
    }
}