
#nullable enable

namespace Exa
{
    /// <summary>
    /// Enterprise-only compliance mode. Set to `hipaa` to require HIPAA-safe processing. Requests fail closed or restrict features when the requested behavior requires non-HIPAA-safe processors.<br/>
    /// Example: hipaa
    /// </summary>
    public enum ContentsRequestCompliance2
    {
        /// <summary>
        /// 
        /// </summary>
        Hipaa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentsRequestCompliance2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestCompliance2 value)
        {
            return value switch
            {
                ContentsRequestCompliance2.Hipaa => "hipaa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestCompliance2? ToEnum(string value)
        {
            return value switch
            {
                "hipaa" => ContentsRequestCompliance2.Hipaa,
                _ => null,
            };
        }
    }
}