
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RotateApiKeyRequest
    {
        /// <summary>
        /// How long the old secret keeps working, in seconds (at most 90 days). 0 revokes it immediately.<br/>
        /// Example: 86400
        /// </summary>
        /// <example>86400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gracePeriodSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GracePeriodSeconds { get; set; }

        /// <summary>
        /// Rotate even if the secret replaced by an earlier rotation is still in its grace period. That secret stops working immediately.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="gracePeriodSeconds">
        /// How long the old secret keeps working, in seconds (at most 90 days). 0 revokes it immediately.<br/>
        /// Example: 86400
        /// </param>
        /// <param name="force">
        /// Rotate even if the secret replaced by an earlier rotation is still in its grace period. That secret stops working immediately.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateApiKeyRequest(
            int gracePeriodSeconds,
            bool? force)
        {
            this.GracePeriodSeconds = gracePeriodSeconds;
            this.Force = force;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyRequest" /> class.
        /// </summary>
        public RotateApiKeyRequest()
        {
        }

    }
}