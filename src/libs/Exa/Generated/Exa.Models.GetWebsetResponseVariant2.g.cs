
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWebsetResponseVariant2
    {
        /// <summary>
        /// When expand query parameter contains `items`, this will contain the items in the webset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Exa.WebsetItem>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebsetResponseVariant2" /> class.
        /// </summary>
        /// <param name="items">
        /// When expand query parameter contains `items`, this will contain the items in the webset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWebsetResponseVariant2(
            global::System.Collections.Generic.IList<global::Exa.WebsetItem>? items)
        {
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebsetResponseVariant2" /> class.
        /// </summary>
        public GetWebsetResponseVariant2()
        {
        }

    }
}