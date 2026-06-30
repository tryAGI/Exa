
#nullable enable

namespace Exa
{
    /// <summary>
    /// The reason the run failed. Null unless status is `failed`. `source_not_available` means the search requested a domain Exa cannot return (remove it from the search), and `forbidden` means the request was otherwise not permitted.
    /// </summary>
    public sealed partial class SearchMonitorRunFailReason
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}