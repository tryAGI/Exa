
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebsetEnrichmentFormat
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
    public static class WebsetEnrichmentFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetEnrichmentFormat value)
        {
            return value switch
            {
                WebsetEnrichmentFormat.Date => "date",
                WebsetEnrichmentFormat.Email => "email",
                WebsetEnrichmentFormat.Number => "number",
                WebsetEnrichmentFormat.Options => "options",
                WebsetEnrichmentFormat.Phone => "phone",
                WebsetEnrichmentFormat.Text => "text",
                WebsetEnrichmentFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetEnrichmentFormat? ToEnum(string value)
        {
            return value switch
            {
                "date" => WebsetEnrichmentFormat.Date,
                "email" => WebsetEnrichmentFormat.Email,
                "number" => WebsetEnrichmentFormat.Number,
                "options" => WebsetEnrichmentFormat.Options,
                "phone" => WebsetEnrichmentFormat.Phone,
                "text" => WebsetEnrichmentFormat.Text,
                "url" => WebsetEnrichmentFormat.Url,
                _ => null,
            };
        }
    }
}