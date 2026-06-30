
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnswerStreamChunkVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"ERROR"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string Tag { get; set; } = "ERROR";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.AnswerStreamChunkVariant4Payload Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamChunkVariant4" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="tag"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerStreamChunkVariant4(
            global::Exa.AnswerStreamChunkVariant4Payload payload,
            string tag = "ERROR")
        {
            this.Tag = tag;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamChunkVariant4" /> class.
        /// </summary>
        public AnswerStreamChunkVariant4()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AnswerStreamChunkVariant4"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AnswerStreamChunkVariant4 FromPayload(global::Exa.AnswerStreamChunkVariant4Payload payload)
        {
            return new AnswerStreamChunkVariant4
            {
                Payload = payload,
            };
        }

    }
}