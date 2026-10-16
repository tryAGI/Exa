
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchMonitorOutputSchemaVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Object,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchMonitorOutputSchemaVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorOutputSchemaVariant1DiscriminatorType value)
        {
            return value switch
            {
                SearchMonitorOutputSchemaVariant1DiscriminatorType.Object => "object",
                SearchMonitorOutputSchemaVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorOutputSchemaVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "object" => SearchMonitorOutputSchemaVariant1DiscriminatorType.Object,
                "text" => SearchMonitorOutputSchemaVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}