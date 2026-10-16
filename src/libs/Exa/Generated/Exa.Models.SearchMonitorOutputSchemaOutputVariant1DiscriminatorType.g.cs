
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchMonitorOutputSchemaOutputVariant1DiscriminatorType
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
    public static class SearchMonitorOutputSchemaOutputVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorOutputSchemaOutputVariant1DiscriminatorType value)
        {
            return value switch
            {
                SearchMonitorOutputSchemaOutputVariant1DiscriminatorType.Object => "object",
                SearchMonitorOutputSchemaOutputVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorOutputSchemaOutputVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "object" => SearchMonitorOutputSchemaOutputVariant1DiscriminatorType.Object,
                "text" => SearchMonitorOutputSchemaOutputVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}