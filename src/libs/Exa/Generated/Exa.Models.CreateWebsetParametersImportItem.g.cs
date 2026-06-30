
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebsetParametersImportItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.CreateWebsetParametersImportItemSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.CreateWebsetParametersImportItemSource Source { get; set; }

        /// <summary>
        /// The ID of the source to search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsetParametersImportItem" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="id">
        /// The ID of the source to search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebsetParametersImportItem(
            global::Exa.CreateWebsetParametersImportItemSource source,
            string id)
        {
            this.Source = source;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsetParametersImportItem" /> class.
        /// </summary>
        public CreateWebsetParametersImportItem()
        {
        }

    }
}