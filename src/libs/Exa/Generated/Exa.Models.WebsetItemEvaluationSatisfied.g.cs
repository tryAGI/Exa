
#nullable enable

namespace Exa
{
    /// <summary>
    /// The satisfaction of the criterion
    /// </summary>
    public enum WebsetItemEvaluationSatisfied
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        Unclear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebsetItemEvaluationSatisfiedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetItemEvaluationSatisfied value)
        {
            return value switch
            {
                WebsetItemEvaluationSatisfied.False => "false",
                WebsetItemEvaluationSatisfied.True => "true",
                WebsetItemEvaluationSatisfied.Unclear => "unclear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetItemEvaluationSatisfied? ToEnum(string value)
        {
            return value switch
            {
                "false" => WebsetItemEvaluationSatisfied.False,
                "true" => WebsetItemEvaluationSatisfied.True,
                "unclear" => WebsetItemEvaluationSatisfied.Unclear,
                _ => null,
            };
        }
    }
}