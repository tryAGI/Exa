
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeletedBatch
    {
        /// <summary>
        /// ID of the deleted batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, always `batch.deleted`.
        /// </summary>
        /// <default>"batch.deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "batch.deleted";

        /// <summary>
        /// Always `true` for a successful delete.
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool Deleted { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedBatch" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deleted batch.
        /// </param>
        /// <param name="object">
        /// The object type, always `batch.deleted`.
        /// </param>
        /// <param name="deleted">
        /// Always `true` for a successful delete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedBatch(
            string id,
            string @object = "batch.deleted",
            bool deleted = true)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedBatch" /> class.
        /// </summary>
        public DeletedBatch()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DeletedBatch"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DeletedBatch FromId(string id)
        {
            return new DeletedBatch
            {
                Id = id,
            };
        }

    }
}