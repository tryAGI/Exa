
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebsetSearchParametersExcludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.CreateWebsetSearchParametersExcludeItemSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.CreateWebsetSearchParametersExcludeItemSource Source { get; set; }

        /// <summary>
        /// The ID of the source to exclude.
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
        /// Initializes a new instance of the <see cref="CreateWebsetSearchParametersExcludeItem" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="id">
        /// The ID of the source to exclude.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebsetSearchParametersExcludeItem(
            global::Exa.CreateWebsetSearchParametersExcludeItemSource source,
            string id)
        {
            this.Source = source;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsetSearchParametersExcludeItem" /> class.
        /// </summary>
        public CreateWebsetSearchParametersExcludeItem()
        {
        }

    }
}