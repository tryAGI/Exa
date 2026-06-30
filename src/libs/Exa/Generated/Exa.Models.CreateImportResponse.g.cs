
#nullable enable

namespace Exa
{
    /// <summary>
    /// The response to a successful import. Includes the upload URL and the upload valid until date.
    /// </summary>
    public sealed partial class CreateImportResponse
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.CreateImportResponseObjectJsonConverter))]
        public global::Exa.CreateImportResponseObject Object { get; set; }

        /// <summary>
        /// The status of the Import
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.CreateImportResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.CreateImportResponseStatus Status { get; set; }

        /// <summary>
        /// The format of the import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.CreateImportResponseFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.CreateImportResponseFormat Format { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.CreateImportResponseFailedReasonJsonConverter))]
        public global::Exa.CreateImportResponseFailedReason? FailedReason { get; set; }

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
        /// The URL to upload the file to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// The date and time until the upload URL is valid. The upload URL will be valid for 1 hour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadValidUntil")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadValidUntil { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImportResponse" /> class.
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
        /// <param name="uploadUrl">
        /// The URL to upload the file to
        /// </param>
        /// <param name="uploadValidUntil">
        /// The date and time until the upload URL is valid. The upload URL will be valid for 1 hour.
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
        public CreateImportResponse(
            string id,
            global::Exa.CreateImportResponseStatus status,
            global::Exa.CreateImportResponseFormat format,
            global::Exa.Entity entity,
            string title,
            double count,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string uploadUrl,
            string uploadValidUntil,
            global::Exa.CreateImportResponseObject @object,
            global::Exa.CreateImportResponseFailedReason? failedReason,
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
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.UploadValidUntil = uploadValidUntil ?? throw new global::System.ArgumentNullException(nameof(uploadValidUntil));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImportResponse" /> class.
        /// </summary>
        public CreateImportResponse()
        {
        }

    }
}