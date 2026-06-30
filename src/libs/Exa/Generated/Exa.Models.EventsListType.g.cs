
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum EventsListType
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
    public static class EventsListTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsListType value)
        {
            return value switch
            {
                EventsListType.ImportCompleted => "import.completed",
                EventsListType.ImportCreated => "import.created",
                EventsListType.MonitorCreated => "monitor.created",
                EventsListType.MonitorDeleted => "monitor.deleted",
                EventsListType.MonitorRunCompleted => "monitor.run.completed",
                EventsListType.MonitorRunCreated => "monitor.run.created",
                EventsListType.MonitorUpdated => "monitor.updated",
                EventsListType.WebsetCreated => "webset.created",
                EventsListType.WebsetDeleted => "webset.deleted",
                EventsListType.WebsetExportCompleted => "webset.export.completed",
                EventsListType.WebsetExportCreated => "webset.export.created",
                EventsListType.WebsetIdle => "webset.idle",
                EventsListType.WebsetItemCreated => "webset.item.created",
                EventsListType.WebsetItemEnriched => "webset.item.enriched",
                EventsListType.WebsetPaused => "webset.paused",
                EventsListType.WebsetSearchCanceled => "webset.search.canceled",
                EventsListType.WebsetSearchCompleted => "webset.search.completed",
                EventsListType.WebsetSearchCreated => "webset.search.created",
                EventsListType.WebsetSearchUpdated => "webset.search.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsListType? ToEnum(string value)
        {
            return value switch
            {
                "import.completed" => EventsListType.ImportCompleted,
                "import.created" => EventsListType.ImportCreated,
                "monitor.created" => EventsListType.MonitorCreated,
                "monitor.deleted" => EventsListType.MonitorDeleted,
                "monitor.run.completed" => EventsListType.MonitorRunCompleted,
                "monitor.run.created" => EventsListType.MonitorRunCreated,
                "monitor.updated" => EventsListType.MonitorUpdated,
                "webset.created" => EventsListType.WebsetCreated,
                "webset.deleted" => EventsListType.WebsetDeleted,
                "webset.export.completed" => EventsListType.WebsetExportCompleted,
                "webset.export.created" => EventsListType.WebsetExportCreated,
                "webset.idle" => EventsListType.WebsetIdle,
                "webset.item.created" => EventsListType.WebsetItemCreated,
                "webset.item.enriched" => EventsListType.WebsetItemEnriched,
                "webset.paused" => EventsListType.WebsetPaused,
                "webset.search.canceled" => EventsListType.WebsetSearchCanceled,
                "webset.search.completed" => EventsListType.WebsetSearchCompleted,
                "webset.search.created" => EventsListType.WebsetSearchCreated,
                "webset.search.updated" => EventsListType.WebsetSearchUpdated,
                _ => null,
            };
        }
    }
}