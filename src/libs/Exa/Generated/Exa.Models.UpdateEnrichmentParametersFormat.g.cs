
#nullable enable

namespace Exa
{
    /// <summary>
    /// Format of the enrichment response.<br/>
    /// We automatically select the best format based on the description. If you want to explicitly specify the format, you can do so here.
    /// </summary>
    public enum UpdateEnrichmentParametersFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Options,
        /// <summary>
        /// 
        /// </summary>
        Phone,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateEnrichmentParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateEnrichmentParametersFormat value)
        {
            return value switch
            {
                UpdateEnrichmentParametersFormat.Date => "date",
                UpdateEnrichmentParametersFormat.Email => "email",
                UpdateEnrichmentParametersFormat.Number => "number",
                UpdateEnrichmentParametersFormat.Options => "options",
                UpdateEnrichmentParametersFormat.Phone => "phone",
                UpdateEnrichmentParametersFormat.Text => "text",
                UpdateEnrichmentParametersFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateEnrichmentParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "date" => UpdateEnrichmentParametersFormat.Date,
                "email" => UpdateEnrichmentParametersFormat.Email,
                "number" => UpdateEnrichmentParametersFormat.Number,
                "options" => UpdateEnrichmentParametersFormat.Options,
                "phone" => UpdateEnrichmentParametersFormat.Phone,
                "text" => UpdateEnrichmentParametersFormat.Text,
                "url" => UpdateEnrichmentParametersFormat.Url,
                _ => null,
            };
        }
    }
}