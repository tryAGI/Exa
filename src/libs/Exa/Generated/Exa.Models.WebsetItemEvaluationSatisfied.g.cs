
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
        No,
        /// <summary>
        /// 
        /// </summary>
        Unclear,
        /// <summary>
        /// 
        /// </summary>
        Yes,
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
                WebsetItemEvaluationSatisfied.No => "no",
                WebsetItemEvaluationSatisfied.Unclear => "unclear",
                WebsetItemEvaluationSatisfied.Yes => "yes",
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
                "no" => WebsetItemEvaluationSatisfied.No,
                "unclear" => WebsetItemEvaluationSatisfied.Unclear,
                "yes" => WebsetItemEvaluationSatisfied.Yes,
                _ => null,
            };
        }
    }
}