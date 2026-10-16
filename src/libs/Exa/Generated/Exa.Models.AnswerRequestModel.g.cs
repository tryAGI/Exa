
#nullable enable

namespace Exa
{
    /// <summary>
    /// The model used to generate the answer.<br/>
    /// Default Value: exa
    /// </summary>
    public enum AnswerRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        Exa,
        /// <summary>
        ///
        /// </summary>
        ExaFast,
        /// <summary>
        ///
        /// </summary>
        ExaPro,
        /// <summary>
        ///
        /// </summary>
        ExaResearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnswerRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnswerRequestModel value)
        {
            return value switch
            {
                AnswerRequestModel.Exa => "exa",
                AnswerRequestModel.ExaFast => "exa-fast",
                AnswerRequestModel.ExaPro => "exa-pro",
                AnswerRequestModel.ExaResearch => "exa-research",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnswerRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "exa" => AnswerRequestModel.Exa,
                "exa-fast" => AnswerRequestModel.ExaFast,
                "exa-pro" => AnswerRequestModel.ExaPro,
                "exa-research" => AnswerRequestModel.ExaResearch,
                _ => null,
            };
        }
    }
}