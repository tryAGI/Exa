
#nullable enable

namespace Exa
{
    /// <summary>
    /// Format of the enrichment response.<br/>
    /// We automatically select the best format based on the description. If you want to explicitly specify the format, you can do so here.
    /// </summary>
    public enum CreateEnrichmentParametersFormat
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
    public static class CreateEnrichmentParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnrichmentParametersFormat value)
        {
            return value switch
            {
                CreateEnrichmentParametersFormat.Date => "date",
                CreateEnrichmentParametersFormat.Email => "email",
                CreateEnrichmentParametersFormat.Number => "number",
                CreateEnrichmentParametersFormat.Options => "options",
                CreateEnrichmentParametersFormat.Phone => "phone",
                CreateEnrichmentParametersFormat.Text => "text",
                CreateEnrichmentParametersFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEnrichmentParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "date" => CreateEnrichmentParametersFormat.Date,
                "email" => CreateEnrichmentParametersFormat.Email,
                "number" => CreateEnrichmentParametersFormat.Number,
                "options" => CreateEnrichmentParametersFormat.Options,
                "phone" => CreateEnrichmentParametersFormat.Phone,
                "text" => CreateEnrichmentParametersFormat.Text,
                "url" => CreateEnrichmentParametersFormat.Url,
                _ => null,
            };
        }
    }
}