
#nullable enable

namespace Exa
{
    /// <summary>
    /// Deprecated: Use highlights or text instead. Returns page contents as a combined context string.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class CommonRequestContext
    {
        /// <summary>
        /// Deprecated. Maximum character limit for the context string.<br/>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCharacters")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxCharacters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRequestContext" /> class.
        /// </summary>
        /// <param name="maxCharacters">
        /// Deprecated. Maximum character limit for the context string.<br/>
        /// Example: 10000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommonRequestContext(
            int? maxCharacters)
        {
            this.MaxCharacters = maxCharacters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonRequestContext" /> class.
        /// </summary>
        public CommonRequestContext()
        {
        }
    }
}