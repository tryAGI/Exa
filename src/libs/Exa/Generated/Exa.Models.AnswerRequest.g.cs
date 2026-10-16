
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnswerRequest
    {
        /// <summary>
        /// Natural-language question or instructions for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// If true, the response is returned as a server-sent events (SSE) stream.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// If true, returns full page text with default settings. If false, disables text return.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public bool? Text { get; set; }

        /// <summary>
        /// The model used to generate the answer.<br/>
        /// Default Value: exa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.AnswerRequestModelJsonConverter))]
        public global::Exa.AnswerRequestModel? Model { get; set; }

        /// <summary>
        /// Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userLocation")]
        public global::Exa.OneOf<string, global::Exa.AnswerRequestUserLocationVariant1Variant2, global::Exa.AnswerRequestUserLocationVariant1Variant3>? UserLocation { get; set; }

        /// <summary>
        /// A [JSON Schema Draft 7](https://json-schema.org/draft-07) specification for the desired answer structure. When provided, the answer is returned as a structured object matching the schema instead of a plain string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public global::Exa.AnswerRequestOutputSchema? OutputSchema { get; set; }

        /// <summary>
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </summary>
        /// <example>7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIdentifier")]
        public string? UserIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Natural-language question or instructions for the request.
        /// </param>
        /// <param name="stream">
        /// If true, the response is returned as a server-sent events (SSE) stream.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="text">
        /// If true, returns full page text with default settings. If false, disables text return.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="model">
        /// The model used to generate the answer.<br/>
        /// Default Value: exa
        /// </param>
        /// <param name="systemPrompt">
        /// Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.
        /// </param>
        /// <param name="userLocation"></param>
        /// <param name="outputSchema">
        /// A [JSON Schema Draft 7](https://json-schema.org/draft-07) specification for the desired answer structure. When provided, the answer is returned as a structured object matching the schema instead of a plain string.
        /// </param>
        /// <param name="userIdentifier">
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerRequest(
            string query,
            bool? stream,
            bool? text,
            global::Exa.AnswerRequestModel? model,
            string? systemPrompt,
            global::Exa.OneOf<string, global::Exa.AnswerRequestUserLocationVariant1Variant2, global::Exa.AnswerRequestUserLocationVariant1Variant3>? userLocation,
            global::Exa.AnswerRequestOutputSchema? outputSchema,
            string? userIdentifier)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Stream = stream;
            this.Text = text;
            this.Model = model;
            this.SystemPrompt = systemPrompt;
            this.UserLocation = userLocation;
            this.OutputSchema = outputSchema;
            this.UserIdentifier = userIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerRequest" /> class.
        /// </summary>
        public AnswerRequest()
        {
        }

    }
}