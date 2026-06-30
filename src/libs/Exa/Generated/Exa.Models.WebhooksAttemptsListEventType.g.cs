
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksAttemptsListEventType
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
    public static class WebhooksAttemptsListEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksAttemptsListEventType value)
        {
            return value switch
            {
                WebhooksAttemptsListEventType.ImportCompleted => "import.completed",
                WebhooksAttemptsListEventType.ImportCreated => "import.created",
                WebhooksAttemptsListEventType.MonitorCreated => "monitor.created",
                WebhooksAttemptsListEventType.MonitorDeleted => "monitor.deleted",
                WebhooksAttemptsListEventType.MonitorRunCompleted => "monitor.run.completed",
                WebhooksAttemptsListEventType.MonitorRunCreated => "monitor.run.created",
                WebhooksAttemptsListEventType.MonitorUpdated => "monitor.updated",
                WebhooksAttemptsListEventType.WebsetCreated => "webset.created",
                WebhooksAttemptsListEventType.WebsetDeleted => "webset.deleted",
                WebhooksAttemptsListEventType.WebsetExportCompleted => "webset.export.completed",
                WebhooksAttemptsListEventType.WebsetExportCreated => "webset.export.created",
                WebhooksAttemptsListEventType.WebsetIdle => "webset.idle",
                WebhooksAttemptsListEventType.WebsetItemCreated => "webset.item.created",
                WebhooksAttemptsListEventType.WebsetItemEnriched => "webset.item.enriched",
                WebhooksAttemptsListEventType.WebsetPaused => "webset.paused",
                WebhooksAttemptsListEventType.WebsetSearchCanceled => "webset.search.canceled",
                WebhooksAttemptsListEventType.WebsetSearchCompleted => "webset.search.completed",
                WebhooksAttemptsListEventType.WebsetSearchCreated => "webset.search.created",
                WebhooksAttemptsListEventType.WebsetSearchUpdated => "webset.search.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksAttemptsListEventType? ToEnum(string value)
        {
            return value switch
            {
                "import.completed" => WebhooksAttemptsListEventType.ImportCompleted,
                "import.created" => WebhooksAttemptsListEventType.ImportCreated,
                "monitor.created" => WebhooksAttemptsListEventType.MonitorCreated,
                "monitor.deleted" => WebhooksAttemptsListEventType.MonitorDeleted,
                "monitor.run.completed" => WebhooksAttemptsListEventType.MonitorRunCompleted,
                "monitor.run.created" => WebhooksAttemptsListEventType.MonitorRunCreated,
                "monitor.updated" => WebhooksAttemptsListEventType.MonitorUpdated,
                "webset.created" => WebhooksAttemptsListEventType.WebsetCreated,
                "webset.deleted" => WebhooksAttemptsListEventType.WebsetDeleted,
                "webset.export.completed" => WebhooksAttemptsListEventType.WebsetExportCompleted,
                "webset.export.created" => WebhooksAttemptsListEventType.WebsetExportCreated,
                "webset.idle" => WebhooksAttemptsListEventType.WebsetIdle,
                "webset.item.created" => WebhooksAttemptsListEventType.WebsetItemCreated,
                "webset.item.enriched" => WebhooksAttemptsListEventType.WebsetItemEnriched,
                "webset.paused" => WebhooksAttemptsListEventType.WebsetPaused,
                "webset.search.canceled" => WebhooksAttemptsListEventType.WebsetSearchCanceled,
                "webset.search.completed" => WebhooksAttemptsListEventType.WebsetSearchCompleted,
                "webset.search.created" => WebhooksAttemptsListEventType.WebsetSearchCreated,
                "webset.search.updated" => WebhooksAttemptsListEventType.WebsetSearchUpdated,
                _ => null,
            };
        }
    }
}