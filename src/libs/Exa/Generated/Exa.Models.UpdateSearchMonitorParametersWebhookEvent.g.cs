
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateSearchMonitorParametersWebhookEvent
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
    public static class UpdateSearchMonitorParametersWebhookEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSearchMonitorParametersWebhookEvent value)
        {
            return value switch
            {
                UpdateSearchMonitorParametersWebhookEvent.MonitorCreated => "monitor.created",
                UpdateSearchMonitorParametersWebhookEvent.MonitorDeleted => "monitor.deleted",
                UpdateSearchMonitorParametersWebhookEvent.MonitorRunCompleted => "monitor.run.completed",
                UpdateSearchMonitorParametersWebhookEvent.MonitorRunCreated => "monitor.run.created",
                UpdateSearchMonitorParametersWebhookEvent.MonitorUpdated => "monitor.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSearchMonitorParametersWebhookEvent? ToEnum(string value)
        {
            return value switch
            {
                "monitor.created" => UpdateSearchMonitorParametersWebhookEvent.MonitorCreated,
                "monitor.deleted" => UpdateSearchMonitorParametersWebhookEvent.MonitorDeleted,
                "monitor.run.completed" => UpdateSearchMonitorParametersWebhookEvent.MonitorRunCompleted,
                "monitor.run.created" => UpdateSearchMonitorParametersWebhookEvent.MonitorRunCreated,
                "monitor.updated" => UpdateSearchMonitorParametersWebhookEvent.MonitorUpdated,
                _ => null,
            };
        }
    }
}