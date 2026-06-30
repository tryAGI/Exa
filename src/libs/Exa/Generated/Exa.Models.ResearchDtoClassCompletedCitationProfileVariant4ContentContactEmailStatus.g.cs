
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus
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
    public static class ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus.GuessedCommonPattern => "guessed_common_pattern",
                ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus.MatchedEmail => "matched_email",
                ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus.MatchedPattern => "matched_pattern",
                ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus? ToEnum(string value)
        {
            return value switch
            {
                "guessed_common_pattern" => ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus.GuessedCommonPattern,
                "matched_email" => ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus.MatchedEmail,
                "matched_pattern" => ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus.MatchedPattern,
                "verified" => ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus.Verified,
                _ => null,
            };
        }
    }
}