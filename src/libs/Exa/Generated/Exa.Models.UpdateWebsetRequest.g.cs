
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWebsetRequest
    {
        /// <summary>
        /// Set of key-value pairs you want to associate with this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Optional name that appears anywhere the Webset is displayed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebsetRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
        /// <param name="title">
        /// Optional name that appears anywhere the Webset is displayed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWebsetRequest(
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? title)
        {
            this.Metadata = metadata;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebsetRequest" /> class.
        /// </summary>
        public UpdateWebsetRequest()
        {
        }

    }
}