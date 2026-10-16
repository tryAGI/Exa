
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchResultOutputEntitieDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Company,
        /// <summary>
        ///
        /// </summary>
        Person,
        /// <summary>
        ///
        /// </summary>
        Publication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResultOutputEntitieDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResultOutputEntitieDiscriminatorType value)
        {
            return value switch
            {
                SearchResultOutputEntitieDiscriminatorType.Company => "company",
                SearchResultOutputEntitieDiscriminatorType.Person => "person",
                SearchResultOutputEntitieDiscriminatorType.Publication => "publication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResultOutputEntitieDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "company" => SearchResultOutputEntitieDiscriminatorType.Company,
                "person" => SearchResultOutputEntitieDiscriminatorType.Person,
                "publication" => SearchResultOutputEntitieDiscriminatorType.Publication,
                _ => null,
            };
        }
    }
}