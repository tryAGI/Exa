
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemEvaluation
    {
        /// <summary>
        /// The description of the criterion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criterion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Criterion { get; set; }

        /// <summary>
        /// The reasoning for the result of the evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reasoning { get; set; }

        /// <summary>
        /// The satisfaction of the criterion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("satisfied")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebsetItemEvaluationSatisfiedJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetItemEvaluationSatisfied Satisfied { get; set; }

        /// <summary>
        /// The references used to generate the result.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluationReference>? References { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemEvaluation" /> class.
        /// </summary>
        /// <param name="criterion">
        /// The description of the criterion
        /// </param>
        /// <param name="reasoning">
        /// The reasoning for the result of the evaluation
        /// </param>
        /// <param name="satisfied">
        /// The satisfaction of the criterion
        /// </param>
        /// <param name="references">
        /// The references used to generate the result.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemEvaluation(
            string criterion,
            string reasoning,
            global::Exa.WebsetItemEvaluationSatisfied satisfied,
            global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluationReference>? references)
        {
            this.Criterion = criterion ?? throw new global::System.ArgumentNullException(nameof(criterion));
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.Satisfied = satisfied;
            this.References = references;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemEvaluation" /> class.
        /// </summary>
        public WebsetItemEvaluation()
        {
        }

    }
}