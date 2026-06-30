
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchStreamChunkVariant1
    {
        /// <summary>
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </summary>
        /// <example>b5947044c4b78efa9552a7c89b306d95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"text-delta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text-delta";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant1Choice>? Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamChunkVariant1" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="requestId">
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </param>
        /// <param name="choices"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchStreamChunkVariant1(
            string delta,
            string? requestId,
            global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant1Choice>? choices,
            string type = "text-delta")
        {
            this.RequestId = requestId;
            this.Type = type;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Choices = choices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamChunkVariant1" /> class.
        /// </summary>
        public SearchStreamChunkVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SearchStreamChunkVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SearchStreamChunkVariant1 FromDelta(string delta)
        {
            return new SearchStreamChunkVariant1
            {
                Delta = delta,
            };
        }

    }
}