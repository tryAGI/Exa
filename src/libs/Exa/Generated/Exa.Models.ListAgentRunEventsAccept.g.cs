
#nullable enable

namespace Exa
{
    /// <summary>
    /// Set to `text/event-stream` to receive server-sent events.
    /// </summary>
    public enum ListAgentRunEventsAccept
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
    public static class ListAgentRunEventsAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentRunEventsAccept value)
        {
            return value switch
            {
                ListAgentRunEventsAccept.ApplicationJson => "application/json",
                ListAgentRunEventsAccept.TextEventStream => "text/event-stream",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentRunEventsAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => ListAgentRunEventsAccept.ApplicationJson,
                "text/event-stream" => ListAgentRunEventsAccept.TextEventStream,
                _ => null,
            };
        }
    }
}