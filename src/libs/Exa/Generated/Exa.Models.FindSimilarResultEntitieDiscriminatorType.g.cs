
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public enum FindSimilarResultEntitieDiscriminatorType
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
    public static class FindSimilarResultEntitieDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindSimilarResultEntitieDiscriminatorType value)
        {
            return value switch
            {
                FindSimilarResultEntitieDiscriminatorType.Company => "company",
                FindSimilarResultEntitieDiscriminatorType.Person => "person",
                FindSimilarResultEntitieDiscriminatorType.Publication => "publication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindSimilarResultEntitieDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "company" => FindSimilarResultEntitieDiscriminatorType.Company,
                "person" => FindSimilarResultEntitieDiscriminatorType.Person,
                "publication" => FindSimilarResultEntitieDiscriminatorType.Publication,
                _ => null,
            };
        }
    }
}