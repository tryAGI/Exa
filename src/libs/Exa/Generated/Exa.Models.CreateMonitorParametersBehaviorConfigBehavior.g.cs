
#nullable enable

namespace Exa
{
    /// <summary>
    /// The behaviour of the Search when it is added to a Webset.<br/>
    /// Default Value: append
    /// </summary>
    public enum CreateMonitorParametersBehaviorConfigBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        Append,
        /// <summary>
        /// 
        /// </summary>
        Override,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMonitorParametersBehaviorConfigBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMonitorParametersBehaviorConfigBehavior value)
        {
            return value switch
            {
                CreateMonitorParametersBehaviorConfigBehavior.Append => "append",
                CreateMonitorParametersBehaviorConfigBehavior.Override => "override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMonitorParametersBehaviorConfigBehavior? ToEnum(string value)
        {
            return value switch
            {
                "append" => CreateMonitorParametersBehaviorConfigBehavior.Append,
                "override" => CreateMonitorParametersBehaviorConfigBehavior.Override,
                _ => null,
            };
        }
    }
}