
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Person,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationProfileVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileVariant4Type value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileVariant4Type.Person => "person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "person" => ResearchDtoClassCompletedCitationProfileVariant4Type.Person,
                _ => null,
            };
        }
    }
}