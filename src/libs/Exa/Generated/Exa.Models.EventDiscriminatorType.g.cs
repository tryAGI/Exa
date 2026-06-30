
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum EventDiscriminatorType
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
    public static class EventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventDiscriminatorType value)
        {
            return value switch
            {
                EventDiscriminatorType.ImportCompleted => "import.completed",
                EventDiscriminatorType.ImportCreated => "import.created",
                EventDiscriminatorType.MonitorCreated => "monitor.created",
                EventDiscriminatorType.MonitorDeleted => "monitor.deleted",
                EventDiscriminatorType.MonitorRunCompleted => "monitor.run.completed",
                EventDiscriminatorType.MonitorRunCreated => "monitor.run.created",
                EventDiscriminatorType.MonitorUpdated => "monitor.updated",
                EventDiscriminatorType.WebsetCreated => "webset.created",
                EventDiscriminatorType.WebsetDeleted => "webset.deleted",
                EventDiscriminatorType.WebsetIdle => "webset.idle",
                EventDiscriminatorType.WebsetItemCreated => "webset.item.created",
                EventDiscriminatorType.WebsetItemEnriched => "webset.item.enriched",
                EventDiscriminatorType.WebsetPaused => "webset.paused",
                EventDiscriminatorType.WebsetSearchCanceled => "webset.search.canceled",
                EventDiscriminatorType.WebsetSearchCompleted => "webset.search.completed",
                EventDiscriminatorType.WebsetSearchCreated => "webset.search.created",
                EventDiscriminatorType.WebsetSearchUpdated => "webset.search.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "import.completed" => EventDiscriminatorType.ImportCompleted,
                "import.created" => EventDiscriminatorType.ImportCreated,
                "monitor.created" => EventDiscriminatorType.MonitorCreated,
                "monitor.deleted" => EventDiscriminatorType.MonitorDeleted,
                "monitor.run.completed" => EventDiscriminatorType.MonitorRunCompleted,
                "monitor.run.created" => EventDiscriminatorType.MonitorRunCreated,
                "monitor.updated" => EventDiscriminatorType.MonitorUpdated,
                "webset.created" => EventDiscriminatorType.WebsetCreated,
                "webset.deleted" => EventDiscriminatorType.WebsetDeleted,
                "webset.idle" => EventDiscriminatorType.WebsetIdle,
                "webset.item.created" => EventDiscriminatorType.WebsetItemCreated,
                "webset.item.enriched" => EventDiscriminatorType.WebsetItemEnriched,
                "webset.paused" => EventDiscriminatorType.WebsetPaused,
                "webset.search.canceled" => EventDiscriminatorType.WebsetSearchCanceled,
                "webset.search.completed" => EventDiscriminatorType.WebsetSearchCompleted,
                "webset.search.created" => EventDiscriminatorType.WebsetSearchCreated,
                "webset.search.updated" => EventDiscriminatorType.WebsetSearchUpdated,
                _ => null,
            };
        }
    }
}