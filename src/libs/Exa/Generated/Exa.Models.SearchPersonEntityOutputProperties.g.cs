
#nullable enable

namespace Exa
{
    /// <summary>
    /// Person-specific entity fields.
    /// </summary>
    public sealed partial class SearchPersonEntityOutputProperties
    {
        /// <summary>
        /// Person name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Person first name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Person last name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Person location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Known professional roles for this person.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workHistory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem> WorkHistory { get; set; }

        /// <summary>
        /// Known education history for this person.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("educationHistory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem> EducationHistory { get; set; }

        /// <summary>
        /// Person research information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("research")]
        public global::Exa.SearchPersonEntityOutputPropertiesResearch? Research { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPersonEntityOutputProperties" /> class.
        /// </summary>
        /// <param name="workHistory">
        /// Known professional roles for this person.
        /// </param>
        /// <param name="educationHistory">
        /// Known education history for this person.
        /// </param>
        /// <param name="name">
        /// Person name.
        /// </param>
        /// <param name="firstName">
        /// Person first name.
        /// </param>
        /// <param name="lastName">
        /// Person last name.
        /// </param>
        /// <param name="location">
        /// Person location.
        /// </param>
        /// <param name="research">
        /// Person research information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPersonEntityOutputProperties(
            global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItem> workHistory,
            global::System.Collections.Generic.IList<global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItem> educationHistory,
            string? name,
            string? firstName,
            string? lastName,
            string? location,
            global::Exa.SearchPersonEntityOutputPropertiesResearch? research)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Location = location;
            this.WorkHistory = workHistory ?? throw new global::System.ArgumentNullException(nameof(workHistory));
            this.EducationHistory = educationHistory ?? throw new global::System.ArgumentNullException(nameof(educationHistory));
            this.Research = research;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPersonEntityOutputProperties" /> class.
        /// </summary>
        public SearchPersonEntityOutputProperties()
        {
        }

    }
}