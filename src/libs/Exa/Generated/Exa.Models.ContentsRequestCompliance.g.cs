
#nullable enable

namespace Exa
{
    /// <summary>
    /// Enterprise-only compliance mode. Set to `hipaa` for HIPAA mode. Requires cache-only retrieval with supported parameters. See the HIPAA docs for details.
    /// </summary>
    public enum ContentsRequestCompliance
    {
        /// <summary>
        ///
        /// </summary>
        Hipaa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentsRequestComplianceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestCompliance value)
        {
            return value switch
            {
                ContentsRequestCompliance.Hipaa => "hipaa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestCompliance? ToEnum(string value)
        {
            return value switch
            {
                "hipaa" => ContentsRequestCompliance.Hipaa,
                _ => null,
            };
        }
    }
}