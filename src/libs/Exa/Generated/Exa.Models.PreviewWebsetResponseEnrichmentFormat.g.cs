
#nullable enable

namespace Exa
{
    /// <summary>
    /// Format of the enrichment.
    /// </summary>
    public enum PreviewWebsetResponseEnrichmentFormat
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
    public static class PreviewWebsetResponseEnrichmentFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreviewWebsetResponseEnrichmentFormat value)
        {
            return value switch
            {
                PreviewWebsetResponseEnrichmentFormat.Date => "date",
                PreviewWebsetResponseEnrichmentFormat.Email => "email",
                PreviewWebsetResponseEnrichmentFormat.Number => "number",
                PreviewWebsetResponseEnrichmentFormat.Options => "options",
                PreviewWebsetResponseEnrichmentFormat.Phone => "phone",
                PreviewWebsetResponseEnrichmentFormat.Text => "text",
                PreviewWebsetResponseEnrichmentFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreviewWebsetResponseEnrichmentFormat? ToEnum(string value)
        {
            return value switch
            {
                "date" => PreviewWebsetResponseEnrichmentFormat.Date,
                "email" => PreviewWebsetResponseEnrichmentFormat.Email,
                "number" => PreviewWebsetResponseEnrichmentFormat.Number,
                "options" => PreviewWebsetResponseEnrichmentFormat.Options,
                "phone" => PreviewWebsetResponseEnrichmentFormat.Phone,
                "text" => PreviewWebsetResponseEnrichmentFormat.Text,
                "url" => PreviewWebsetResponseEnrichmentFormat.Url,
                _ => null,
            };
        }
    }
}