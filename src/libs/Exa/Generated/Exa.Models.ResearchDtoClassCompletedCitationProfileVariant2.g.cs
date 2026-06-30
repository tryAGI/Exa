
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2TypeJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.OneOf<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2(
            global::Exa.OneOf<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1, global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2> content,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2Type type)
        {
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2()
        {
        }

    }
}