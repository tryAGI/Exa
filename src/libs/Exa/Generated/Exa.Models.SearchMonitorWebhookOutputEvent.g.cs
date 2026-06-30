
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchMonitorWebhookOutputEvent
    {
        /// <summary>
        /// 
        /// </summary>
        MonitorCreated,
        /// <summary>
        /// 
        /// </summary>
        MonitorDeleted,
        /// <summary>
        /// 
        /// </summary>
        MonitorRunCompleted,
        /// <summary>
        /// 
        /// </summary>
        MonitorRunCreated,
        /// <summary>
        /// 
        /// </summary>
        MonitorUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchMonitorWebhookOutputEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorWebhookOutputEvent value)
        {
            return value switch
            {
                SearchMonitorWebhookOutputEvent.MonitorCreated => "monitor.created",
                SearchMonitorWebhookOutputEvent.MonitorDeleted => "monitor.deleted",
                SearchMonitorWebhookOutputEvent.MonitorRunCompleted => "monitor.run.completed",
                SearchMonitorWebhookOutputEvent.MonitorRunCreated => "monitor.run.created",
                SearchMonitorWebhookOutputEvent.MonitorUpdated => "monitor.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorWebhookOutputEvent? ToEnum(string value)
        {
            return value switch
            {
                "monitor.created" => SearchMonitorWebhookOutputEvent.MonitorCreated,
                "monitor.deleted" => SearchMonitorWebhookOutputEvent.MonitorDeleted,
                "monitor.run.completed" => SearchMonitorWebhookOutputEvent.MonitorRunCompleted,
                "monitor.run.created" => SearchMonitorWebhookOutputEvent.MonitorRunCreated,
                "monitor.updated" => SearchMonitorWebhookOutputEvent.MonitorUpdated,
                _ => null,
            };
        }
    }
}