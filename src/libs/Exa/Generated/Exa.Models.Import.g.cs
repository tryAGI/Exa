
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Import
    {
        /// <summary>
        /// The unique identifier for the Import
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ImportObjectJsonConverter))]
        public global::Exa.ImportObject Object { get; set; }

        /// <summary>
        /// The status of the Import
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ImportStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ImportStatus Status { get; set; }

        /// <summary>
        /// The format of the import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ImportFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ImportFormat Format { get; set; }

        /// <summary>
        /// The type of entity the import contains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.EntityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.Entity Entity { get; set; }

        /// <summary>
        /// The title of the import
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The number of entities in the import
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Set of key-value pairs you want to associate with this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The reason the import failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ImportFailedReasonJsonConverter))]
        public global::Exa.ImportFailedReason? FailedReason { get; set; }

        /// <summary>
        /// When the import failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedAt")]
        public global::System.DateTime? FailedAt { get; set; }

        /// <summary>
        /// A human readable message of the import failure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedMessage")]
        public string? FailedMessage { get; set; }

        /// <summary>
        /// When the import was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the import was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Import" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the Import
        /// </param>
        /// <param name="status">
        /// The status of the Import
        /// </param>
        /// <param name="format">
        /// The format of the import.
        /// </param>
        /// <param name="entity">
        /// The type of entity the import contains.
        /// </param>
        /// <param name="title">
        /// The title of the import
        /// </param>
        /// <param name="count">
        /// The number of entities in the import
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
        /// <param name="createdAt">
        /// When the import was created
        /// </param>
        /// <param name="updatedAt">
        /// When the import was last updated
        /// </param>
        /// <param name="object">
        /// The type of object
        /// </param>
        /// <param name="failedReason">
        /// The reason the import failed
        /// </param>
        /// <param name="failedAt">
        /// When the import failed
        /// </param>
        /// <param name="failedMessage">
        /// A human readable message of the import failure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Import(
            string id,
            global::Exa.ImportStatus status,
            global::Exa.ImportFormat format,
            global::Exa.Entity entity,
            string title,
            double count,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Exa.ImportObject @object,
            global::Exa.ImportFailedReason? failedReason,
            global::System.DateTime? failedAt,
            string? failedMessage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Status = status;
            this.Format = format;
            this.Entity = entity;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Count = count;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.FailedReason = failedReason;
            this.FailedAt = failedAt;
            this.FailedMessage = failedMessage;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Import" /> class.
        /// </summary>
        public Import()
        {
        }

    }
}