
#nullable enable

namespace Exa
{
    /// <summary>
    /// An object where each key is a property name and each value is a JSON Schema describing that property (with `type`, `description`, etc).
    /// </summary>
    public sealed partial class AnswerRequestOutputSchemaProperties
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}