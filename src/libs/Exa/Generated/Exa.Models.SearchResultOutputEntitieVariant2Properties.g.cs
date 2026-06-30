
#nullable enable

namespace Exa
{
    /// <summary>
    /// Person-specific entity fields.
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant2Properties
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
        public required global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant2PropertiesWorkHistoryItem> WorkHistory { get; set; }

        /// <summary>
        /// Known education history for this person.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("educationHistory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant2PropertiesEducationHistoryItem> EducationHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant2Properties" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant2Properties(
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant2PropertiesWorkHistoryItem> workHistory,
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant2PropertiesEducationHistoryItem> educationHistory,
            string? name,
            string? firstName,
            string? lastName,
            string? location)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Location = location;
            this.WorkHistory = workHistory ?? throw new global::System.ArgumentNullException(nameof(workHistory));
            this.EducationHistory = educationHistory ?? throw new global::System.ArgumentNullException(nameof(educationHistory));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant2Properties" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant2Properties()
        {
        }

    }
}