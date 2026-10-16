
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchRequestOutputSchemaDiscriminatorType
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
    public static class SearchRequestOutputSchemaDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestOutputSchemaDiscriminatorType value)
        {
            return value switch
            {
                SearchRequestOutputSchemaDiscriminatorType.Object => "object",
                SearchRequestOutputSchemaDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestOutputSchemaDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "object" => SearchRequestOutputSchemaDiscriminatorType.Object,
                "text" => SearchRequestOutputSchemaDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}