
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImportParametersVariant1
    {
        /// <summary>
        /// The size of the file in bytes. Maximum size is 50 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// The number of records to import
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// The title of the import
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// When the import is in CSV format, we expect a column containing the key identifier for the entity - for now URL. If not provided, import will fail to be processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.CreateImportParametersVariant1FormatJsonConverter))]
        public global::Exa.CreateImportParametersVariant1Format Format { get; set; }

        /// <summary>
        /// Set of key-value pairs you want to associate with this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// What type of entity the import contains (e.g. People, Companies, etc.), and thus should be attempted to be resolved as.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity> Entity { get; set; }

        /// <summary>
        /// When format is `csv`, these are the specific import parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("csv")]
        public global::Exa.CreateImportParametersVariant1Csv? Csv { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImportParametersVariant1" /> class.
        /// </summary>
        /// <param name="size">
        /// The size of the file in bytes. Maximum size is 50 MB.
        /// </param>
        /// <param name="count">
        /// The number of records to import
        /// </param>
        /// <param name="entity">
        /// What type of entity the import contains (e.g. People, Companies, etc.), and thus should be attempted to be resolved as.
        /// </param>
        /// <param name="title">
        /// The title of the import
        /// </param>
        /// <param name="format">
        /// When the import is in CSV format, we expect a column containing the key identifier for the entity - for now URL. If not provided, import will fail to be processed.
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
        /// <param name="csv">
        /// When format is `csv`, these are the specific import parameters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImportParametersVariant1(
            double size,
            double count,
            global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity> entity,
            string? title,
            global::Exa.CreateImportParametersVariant1Format format,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::Exa.CreateImportParametersVariant1Csv? csv)
        {
            this.Size = size;
            this.Count = count;
            this.Title = title;
            this.Format = format;
            this.Metadata = metadata;
            this.Entity = entity;
            this.Csv = csv;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImportParametersVariant1" /> class.
        /// </summary>
        public CreateImportParametersVariant1()
        {
        }

    }
}