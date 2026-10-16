
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListApiKeysResponseVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeys")]
        public global::System.Collections.Generic.IList<global::Exa.TeamManagement.ListApiKeysResponseVariant1ApiKey>? ApiKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApiKeysResponseVariant1" /> class.
        /// </summary>
        /// <param name="apiKeys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListApiKeysResponseVariant1(
            global::System.Collections.Generic.IList<global::Exa.TeamManagement.ListApiKeysResponseVariant1ApiKey>? apiKeys)
        {
            this.ApiKeys = apiKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApiKeysResponseVariant1" /> class.
        /// </summary>
        public ListApiKeysResponseVariant1()
        {
        }

    }
}