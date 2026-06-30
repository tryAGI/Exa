
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchMonitorWebhookEvent
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
    public static class SearchMonitorWebhookEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorWebhookEvent value)
        {
            return value switch
            {
                SearchMonitorWebhookEvent.MonitorCreated => "monitor.created",
                SearchMonitorWebhookEvent.MonitorDeleted => "monitor.deleted",
                SearchMonitorWebhookEvent.MonitorRunCompleted => "monitor.run.completed",
                SearchMonitorWebhookEvent.MonitorRunCreated => "monitor.run.created",
                SearchMonitorWebhookEvent.MonitorUpdated => "monitor.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorWebhookEvent? ToEnum(string value)
        {
            return value switch
            {
                "monitor.created" => SearchMonitorWebhookEvent.MonitorCreated,
                "monitor.deleted" => SearchMonitorWebhookEvent.MonitorDeleted,
                "monitor.run.completed" => SearchMonitorWebhookEvent.MonitorRunCompleted,
                "monitor.run.created" => SearchMonitorWebhookEvent.MonitorRunCreated,
                "monitor.updated" => SearchMonitorWebhookEvent.MonitorUpdated,
                _ => null,
            };
        }
    }
}