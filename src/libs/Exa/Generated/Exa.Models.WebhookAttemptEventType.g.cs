
#nullable enable

namespace Exa
{
    /// <summary>
    /// The type of event
    /// </summary>
    public enum WebhookAttemptEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ImportCompleted,
        /// <summary>
        /// 
        /// </summary>
        ImportCreated,
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
        /// <summary>
        /// 
        /// </summary>
        WebsetCreated,
        /// <summary>
        /// 
        /// </summary>
        WebsetDeleted,
        /// <summary>
        /// 
        /// </summary>
        WebsetExportCompleted,
        /// <summary>
        /// 
        /// </summary>
        WebsetExportCreated,
        /// <summary>
        /// 
        /// </summary>
        WebsetIdle,
        /// <summary>
        /// 
        /// </summary>
        WebsetItemCreated,
        /// <summary>
        /// 
        /// </summary>
        WebsetItemEnriched,
        /// <summary>
        /// 
        /// </summary>
        WebsetPaused,
        /// <summary>
        /// 
        /// </summary>
        WebsetSearchCanceled,
        /// <summary>
        /// 
        /// </summary>
        WebsetSearchCompleted,
        /// <summary>
        /// 
        /// </summary>
        WebsetSearchCreated,
        /// <summary>
        /// 
        /// </summary>
        WebsetSearchUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAttemptEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAttemptEventType value)
        {
            return value switch
            {
                WebhookAttemptEventType.ImportCompleted => "import.completed",
                WebhookAttemptEventType.ImportCreated => "import.created",
                WebhookAttemptEventType.MonitorCreated => "monitor.created",
                WebhookAttemptEventType.MonitorDeleted => "monitor.deleted",
                WebhookAttemptEventType.MonitorRunCompleted => "monitor.run.completed",
                WebhookAttemptEventType.MonitorRunCreated => "monitor.run.created",
                WebhookAttemptEventType.MonitorUpdated => "monitor.updated",
                WebhookAttemptEventType.WebsetCreated => "webset.created",
                WebhookAttemptEventType.WebsetDeleted => "webset.deleted",
                WebhookAttemptEventType.WebsetExportCompleted => "webset.export.completed",
                WebhookAttemptEventType.WebsetExportCreated => "webset.export.created",
                WebhookAttemptEventType.WebsetIdle => "webset.idle",
                WebhookAttemptEventType.WebsetItemCreated => "webset.item.created",
                WebhookAttemptEventType.WebsetItemEnriched => "webset.item.enriched",
                WebhookAttemptEventType.WebsetPaused => "webset.paused",
                WebhookAttemptEventType.WebsetSearchCanceled => "webset.search.canceled",
                WebhookAttemptEventType.WebsetSearchCompleted => "webset.search.completed",
                WebhookAttemptEventType.WebsetSearchCreated => "webset.search.created",
                WebhookAttemptEventType.WebsetSearchUpdated => "webset.search.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAttemptEventType? ToEnum(string value)
        {
            return value switch
            {
                "import.completed" => WebhookAttemptEventType.ImportCompleted,
                "import.created" => WebhookAttemptEventType.ImportCreated,
                "monitor.created" => WebhookAttemptEventType.MonitorCreated,
                "monitor.deleted" => WebhookAttemptEventType.MonitorDeleted,
                "monitor.run.completed" => WebhookAttemptEventType.MonitorRunCompleted,
                "monitor.run.created" => WebhookAttemptEventType.MonitorRunCreated,
                "monitor.updated" => WebhookAttemptEventType.MonitorUpdated,
                "webset.created" => WebhookAttemptEventType.WebsetCreated,
                "webset.deleted" => WebhookAttemptEventType.WebsetDeleted,
                "webset.export.completed" => WebhookAttemptEventType.WebsetExportCompleted,
                "webset.export.created" => WebhookAttemptEventType.WebsetExportCreated,
                "webset.idle" => WebhookAttemptEventType.WebsetIdle,
                "webset.item.created" => WebhookAttemptEventType.WebsetItemCreated,
                "webset.item.enriched" => WebhookAttemptEventType.WebsetItemEnriched,
                "webset.paused" => WebhookAttemptEventType.WebsetPaused,
                "webset.search.canceled" => WebhookAttemptEventType.WebsetSearchCanceled,
                "webset.search.completed" => WebhookAttemptEventType.WebsetSearchCompleted,
                "webset.search.created" => WebhookAttemptEventType.WebsetSearchCreated,
                "webset.search.updated" => WebhookAttemptEventType.WebsetSearchUpdated,
                _ => null,
            };
        }
    }
}