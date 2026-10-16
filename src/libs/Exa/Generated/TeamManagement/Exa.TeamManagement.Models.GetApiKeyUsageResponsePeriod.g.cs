
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetApiKeyUsageResponsePeriod
    {
        /// <summary>
        /// Start of the usage period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public global::System.DateTime? Start { get; set; }

        /// <summary>
        /// End of the usage period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyUsageResponsePeriod" /> class.
        /// </summary>
        /// <param name="start">
        /// Start of the usage period
        /// </param>
        /// <param name="end">
        /// End of the usage period
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiKeyUsageResponsePeriod(
            global::System.DateTime? start,
            global::System.DateTime? end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyUsageResponsePeriod" /> class.
        /// </summary>
        public GetApiKeyUsageResponsePeriod()
        {
        }

    }
}