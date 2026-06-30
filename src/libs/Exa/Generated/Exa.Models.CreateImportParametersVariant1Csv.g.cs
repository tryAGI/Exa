
#nullable enable

namespace Exa
{
    /// <summary>
    /// When format is `csv`, these are the specific import parameters.
    /// </summary>
    public sealed partial class CreateImportParametersVariant1Csv
    {
        /// <summary>
        /// Column containing the key identifier for the entity (e.g. URL, Name, etc.). If not provided, we will try to infer it from the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public int? Identifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImportParametersVariant1Csv" /> class.
        /// </summary>
        /// <param name="identifier">
        /// Column containing the key identifier for the entity (e.g. URL, Name, etc.). If not provided, we will try to infer it from the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImportParametersVariant1Csv(
            int? identifier)
        {
            this.Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImportParametersVariant1Csv" /> class.
        /// </summary>
        public CreateImportParametersVariant1Csv()
        {
        }

    }
}