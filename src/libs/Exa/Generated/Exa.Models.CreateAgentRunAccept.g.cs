
#nullable enable

namespace Exa
{
    /// <summary>
    /// Set to `text/event-stream` to receive server-sent events.
    /// </summary>
    public enum CreateAgentRunAccept
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationJson,
        /// <summary>
        /// 
        /// </summary>
        TextEventStream,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgentRunAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentRunAccept value)
        {
            return value switch
            {
                CreateAgentRunAccept.ApplicationJson => "application/json",
                CreateAgentRunAccept.TextEventStream => "text/event-stream",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentRunAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => CreateAgentRunAccept.ApplicationJson,
                "text/event-stream" => CreateAgentRunAccept.TextEventStream,
                _ => null,
            };
        }
    }
}