
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus
    {
        /// <summary>
        /// 
        /// </summary>
        GuessedCommonPattern,
        /// <summary>
        /// 
        /// </summary>
        MatchedEmail,
        /// <summary>
        /// 
        /// </summary>
        MatchedPattern,
        /// <summary>
        /// 
        /// </summary>
        Verified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus.GuessedCommonPattern => "guessed_common_pattern",
                ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus.MatchedEmail => "matched_email",
                ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus.MatchedPattern => "matched_pattern",
                ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus? ToEnum(string value)
        {
            return value switch
            {
                "guessed_common_pattern" => ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus.GuessedCommonPattern,
                "matched_email" => ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus.MatchedEmail,
                "matched_pattern" => ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus.MatchedPattern,
                "verified" => ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus.Verified,
                _ => null,
            };
        }
    }
}