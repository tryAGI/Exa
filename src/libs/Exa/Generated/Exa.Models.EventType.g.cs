
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum EventType
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
    public static class EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventType value)
        {
            return value switch
            {
                EventType.ImportCompleted => "import.completed",
                EventType.ImportCreated => "import.created",
                EventType.MonitorCreated => "monitor.created",
                EventType.MonitorDeleted => "monitor.deleted",
                EventType.MonitorRunCompleted => "monitor.run.completed",
                EventType.MonitorRunCreated => "monitor.run.created",
                EventType.MonitorUpdated => "monitor.updated",
                EventType.WebsetCreated => "webset.created",
                EventType.WebsetDeleted => "webset.deleted",
                EventType.WebsetExportCompleted => "webset.export.completed",
                EventType.WebsetExportCreated => "webset.export.created",
                EventType.WebsetIdle => "webset.idle",
                EventType.WebsetItemCreated => "webset.item.created",
                EventType.WebsetItemEnriched => "webset.item.enriched",
                EventType.WebsetPaused => "webset.paused",
                EventType.WebsetSearchCanceled => "webset.search.canceled",
                EventType.WebsetSearchCompleted => "webset.search.completed",
                EventType.WebsetSearchCreated => "webset.search.created",
                EventType.WebsetSearchUpdated => "webset.search.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventType? ToEnum(string value)
        {
            return value switch
            {
                "import.completed" => EventType.ImportCompleted,
                "import.created" => EventType.ImportCreated,
                "monitor.created" => EventType.MonitorCreated,
                "monitor.deleted" => EventType.MonitorDeleted,
                "monitor.run.completed" => EventType.MonitorRunCompleted,
                "monitor.run.created" => EventType.MonitorRunCreated,
                "monitor.updated" => EventType.MonitorUpdated,
                "webset.created" => EventType.WebsetCreated,
                "webset.deleted" => EventType.WebsetDeleted,
                "webset.export.completed" => EventType.WebsetExportCompleted,
                "webset.export.created" => EventType.WebsetExportCreated,
                "webset.idle" => EventType.WebsetIdle,
                "webset.item.created" => EventType.WebsetItemCreated,
                "webset.item.enriched" => EventType.WebsetItemEnriched,
                "webset.paused" => EventType.WebsetPaused,
                "webset.search.canceled" => EventType.WebsetSearchCanceled,
                "webset.search.completed" => EventType.WebsetSearchCompleted,
                "webset.search.created" => EventType.WebsetSearchCreated,
                "webset.search.updated" => EventType.WebsetSearchUpdated,
                _ => null,
            };
        }
    }
}