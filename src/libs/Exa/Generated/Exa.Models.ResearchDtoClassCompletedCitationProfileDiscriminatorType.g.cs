
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Company,
        /// <summary>
        /// 
        /// </summary>
        LinkedinCompany,
        /// <summary>
        /// 
        /// </summary>
        LinkedinPerson,
        /// <summary>
        /// 
        /// </summary>
        Person,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationProfileDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileDiscriminatorType value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileDiscriminatorType.Company => "company",
                ResearchDtoClassCompletedCitationProfileDiscriminatorType.LinkedinCompany => "linkedin_company",
                ResearchDtoClassCompletedCitationProfileDiscriminatorType.LinkedinPerson => "linkedin_person",
                ResearchDtoClassCompletedCitationProfileDiscriminatorType.Person => "person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "company" => ResearchDtoClassCompletedCitationProfileDiscriminatorType.Company,
                "linkedin_company" => ResearchDtoClassCompletedCitationProfileDiscriminatorType.LinkedinCompany,
                "linkedin_person" => ResearchDtoClassCompletedCitationProfileDiscriminatorType.LinkedinPerson,
                "person" => ResearchDtoClassCompletedCitationProfileDiscriminatorType.Person,
                _ => null,
            };
        }
    }
}