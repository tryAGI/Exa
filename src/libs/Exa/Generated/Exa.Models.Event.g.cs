#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Event : global::System.IEquatable<Event>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventWebsetCreatedEvent? WebsetCreated { get; init; }
#else
        public global::Exa.EventWebsetCreatedEvent? WebsetCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebsetCreated))]
#endif
        public bool IsWebsetCreated => WebsetCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebsetCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventWebsetCreatedEvent? value)
        {
            value = WebsetCreated;
            return IsWebsetCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventWebsetCreatedEvent PickWebsetCreated() => IsWebsetCreated
            ? WebsetCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebsetCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventWebsetDeletedEvent? WebsetDeleted { get; init; }
#else
        public global::Exa.EventWebsetDeletedEvent? WebsetDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebsetDeleted))]
#endif
        public bool IsWebsetDeleted => WebsetDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebsetDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventWebsetDeletedEvent? value)
        {
            value = WebsetDeleted;
            return IsWebsetDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventWebsetDeletedEvent PickWebsetDeleted() => IsWebsetDeleted
            ? WebsetDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebsetDeleted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventWebsetIdleEvent? WebsetIdle { get; init; }
#else
        public global::Exa.EventWebsetIdleEvent? WebsetIdle { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebsetIdle))]
#endif
        public bool IsWebsetIdle => WebsetIdle != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebsetIdle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventWebsetIdleEvent? value)
        {
            value = WebsetIdle;
            return IsWebsetIdle;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventWebsetIdleEvent PickWebsetIdle() => IsWebsetIdle
            ? WebsetIdle!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebsetIdle' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventWebsetPausedEvent? WebsetPaused { get; init; }
#else
        public global::Exa.EventWebsetPausedEvent? WebsetPaused { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebsetPaused))]
#endif
        public bool IsWebsetPaused => WebsetPaused != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebsetPaused(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventWebsetPausedEvent? value)
        {
            value = WebsetPaused;
            return IsWebsetPaused;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventWebsetPausedEvent PickWebsetPaused() => IsWebsetPaused
            ? WebsetPaused!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebsetPaused' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventWebsetItemCreatedEvent? WebsetItemCreated { get; init; }
#else
        public global::Exa.EventWebsetItemCreatedEvent? WebsetItemCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebsetItemCreated))]
#endif
        public bool IsWebsetItemCreated => WebsetItemCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebsetItemCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventWebsetItemCreatedEvent? value)
        {
            value = WebsetItemCreated;
            return IsWebsetItemCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventWebsetItemCreatedEvent PickWebsetItemCreated() => IsWebsetItemCreated
            ? WebsetItemCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebsetItemCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventWebsetItemEnrichedEvent? WebsetItemEnriched { get; init; }
#else
        public global::Exa.EventWebsetItemEnrichedEvent? WebsetItemEnriched { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebsetItemEnriched))]
#endif
        public bool IsWebsetItemEnriched => WebsetItemEnriched != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebsetItemEnriched(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventWebsetItemEnrichedEvent? value)
        {
            value = WebsetItemEnriched;
            return IsWebsetItemEnriched;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventWebsetItemEnrichedEvent PickWebsetItemEnriched() => IsWebsetItemEnriched
            ? WebsetItemEnriched!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebsetItemEnriched' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventWebsetSearchCreatedEvent? WebsetSearchCreated { get; init; }
#else
        public global::Exa.EventWebsetSearchCreatedEvent? WebsetSearchCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebsetSearchCreated))]
#endif
        public bool IsWebsetSearchCreated => WebsetSearchCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebsetSearchCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventWebsetSearchCreatedEvent? value)
        {
            value = WebsetSearchCreated;
            return IsWebsetSearchCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventWebsetSearchCreatedEvent PickWebsetSearchCreated() => IsWebsetSearchCreated
            ? WebsetSearchCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebsetSearchCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventWebsetSearchUpdatedEvent? WebsetSearchUpdated { get; init; }
#else
        public global::Exa.EventWebsetSearchUpdatedEvent? WebsetSearchUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebsetSearchUpdated))]
#endif
        public bool IsWebsetSearchUpdated => WebsetSearchUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebsetSearchUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventWebsetSearchUpdatedEvent? value)
        {
            value = WebsetSearchUpdated;
            return IsWebsetSearchUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventWebsetSearchUpdatedEvent PickWebsetSearchUpdated() => IsWebsetSearchUpdated
            ? WebsetSearchUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebsetSearchUpdated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventWebsetSearchCanceledEvent? WebsetSearchCanceled { get; init; }
#else
        public global::Exa.EventWebsetSearchCanceledEvent? WebsetSearchCanceled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebsetSearchCanceled))]
#endif
        public bool IsWebsetSearchCanceled => WebsetSearchCanceled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebsetSearchCanceled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventWebsetSearchCanceledEvent? value)
        {
            value = WebsetSearchCanceled;
            return IsWebsetSearchCanceled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventWebsetSearchCanceledEvent PickWebsetSearchCanceled() => IsWebsetSearchCanceled
            ? WebsetSearchCanceled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebsetSearchCanceled' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventWebsetSearchCompletedEvent? WebsetSearchCompleted { get; init; }
#else
        public global::Exa.EventWebsetSearchCompletedEvent? WebsetSearchCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebsetSearchCompleted))]
#endif
        public bool IsWebsetSearchCompleted => WebsetSearchCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebsetSearchCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventWebsetSearchCompletedEvent? value)
        {
            value = WebsetSearchCompleted;
            return IsWebsetSearchCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventWebsetSearchCompletedEvent PickWebsetSearchCompleted() => IsWebsetSearchCompleted
            ? WebsetSearchCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebsetSearchCompleted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventImportCreatedEvent? ImportCreated { get; init; }
#else
        public global::Exa.EventImportCreatedEvent? ImportCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImportCreated))]
#endif
        public bool IsImportCreated => ImportCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImportCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventImportCreatedEvent? value)
        {
            value = ImportCreated;
            return IsImportCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventImportCreatedEvent PickImportCreated() => IsImportCreated
            ? ImportCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImportCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventImportCompletedEvent? ImportCompleted { get; init; }
#else
        public global::Exa.EventImportCompletedEvent? ImportCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImportCompleted))]
#endif
        public bool IsImportCompleted => ImportCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImportCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventImportCompletedEvent? value)
        {
            value = ImportCompleted;
            return IsImportCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventImportCompletedEvent PickImportCompleted() => IsImportCompleted
            ? ImportCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImportCompleted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventMonitorCreatedEvent? MonitorCreated { get; init; }
#else
        public global::Exa.EventMonitorCreatedEvent? MonitorCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MonitorCreated))]
#endif
        public bool IsMonitorCreated => MonitorCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMonitorCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventMonitorCreatedEvent? value)
        {
            value = MonitorCreated;
            return IsMonitorCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventMonitorCreatedEvent PickMonitorCreated() => IsMonitorCreated
            ? MonitorCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MonitorCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventMonitorUpdatedEvent? MonitorUpdated { get; init; }
#else
        public global::Exa.EventMonitorUpdatedEvent? MonitorUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MonitorUpdated))]
#endif
        public bool IsMonitorUpdated => MonitorUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMonitorUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventMonitorUpdatedEvent? value)
        {
            value = MonitorUpdated;
            return IsMonitorUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventMonitorUpdatedEvent PickMonitorUpdated() => IsMonitorUpdated
            ? MonitorUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MonitorUpdated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventMonitorDeletedEvent? MonitorDeleted { get; init; }
#else
        public global::Exa.EventMonitorDeletedEvent? MonitorDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MonitorDeleted))]
#endif
        public bool IsMonitorDeleted => MonitorDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMonitorDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventMonitorDeletedEvent? value)
        {
            value = MonitorDeleted;
            return IsMonitorDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventMonitorDeletedEvent PickMonitorDeleted() => IsMonitorDeleted
            ? MonitorDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MonitorDeleted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventMonitorRunCreatedEvent? MonitorRunCreated { get; init; }
#else
        public global::Exa.EventMonitorRunCreatedEvent? MonitorRunCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MonitorRunCreated))]
#endif
        public bool IsMonitorRunCreated => MonitorRunCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMonitorRunCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventMonitorRunCreatedEvent? value)
        {
            value = MonitorRunCreated;
            return IsMonitorRunCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventMonitorRunCreatedEvent PickMonitorRunCreated() => IsMonitorRunCreated
            ? MonitorRunCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MonitorRunCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Exa.EventMonitorRunCompletedEvent? MonitorRunCompleted { get; init; }
#else
        public global::Exa.EventMonitorRunCompletedEvent? MonitorRunCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MonitorRunCompleted))]
#endif
        public bool IsMonitorRunCompleted => MonitorRunCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMonitorRunCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Exa.EventMonitorRunCompletedEvent? value)
        {
            value = MonitorRunCompleted;
            return IsMonitorRunCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Exa.EventMonitorRunCompletedEvent PickMonitorRunCompleted() => IsMonitorRunCompleted
            ? MonitorRunCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MonitorRunCompleted' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventWebsetCreatedEvent value) => new Event((global::Exa.EventWebsetCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventWebsetCreatedEvent?(Event @this) => @this.WebsetCreated;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventWebsetCreatedEvent? value)
        {
            WebsetCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromWebsetCreated(global::Exa.EventWebsetCreatedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventWebsetDeletedEvent value) => new Event((global::Exa.EventWebsetDeletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventWebsetDeletedEvent?(Event @this) => @this.WebsetDeleted;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventWebsetDeletedEvent? value)
        {
            WebsetDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromWebsetDeleted(global::Exa.EventWebsetDeletedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventWebsetIdleEvent value) => new Event((global::Exa.EventWebsetIdleEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventWebsetIdleEvent?(Event @this) => @this.WebsetIdle;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventWebsetIdleEvent? value)
        {
            WebsetIdle = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromWebsetIdle(global::Exa.EventWebsetIdleEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventWebsetPausedEvent value) => new Event((global::Exa.EventWebsetPausedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventWebsetPausedEvent?(Event @this) => @this.WebsetPaused;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventWebsetPausedEvent? value)
        {
            WebsetPaused = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromWebsetPaused(global::Exa.EventWebsetPausedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventWebsetItemCreatedEvent value) => new Event((global::Exa.EventWebsetItemCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventWebsetItemCreatedEvent?(Event @this) => @this.WebsetItemCreated;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventWebsetItemCreatedEvent? value)
        {
            WebsetItemCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromWebsetItemCreated(global::Exa.EventWebsetItemCreatedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventWebsetItemEnrichedEvent value) => new Event((global::Exa.EventWebsetItemEnrichedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventWebsetItemEnrichedEvent?(Event @this) => @this.WebsetItemEnriched;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventWebsetItemEnrichedEvent? value)
        {
            WebsetItemEnriched = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromWebsetItemEnriched(global::Exa.EventWebsetItemEnrichedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventWebsetSearchCreatedEvent value) => new Event((global::Exa.EventWebsetSearchCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventWebsetSearchCreatedEvent?(Event @this) => @this.WebsetSearchCreated;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventWebsetSearchCreatedEvent? value)
        {
            WebsetSearchCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromWebsetSearchCreated(global::Exa.EventWebsetSearchCreatedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventWebsetSearchUpdatedEvent value) => new Event((global::Exa.EventWebsetSearchUpdatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventWebsetSearchUpdatedEvent?(Event @this) => @this.WebsetSearchUpdated;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventWebsetSearchUpdatedEvent? value)
        {
            WebsetSearchUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromWebsetSearchUpdated(global::Exa.EventWebsetSearchUpdatedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventWebsetSearchCanceledEvent value) => new Event((global::Exa.EventWebsetSearchCanceledEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventWebsetSearchCanceledEvent?(Event @this) => @this.WebsetSearchCanceled;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventWebsetSearchCanceledEvent? value)
        {
            WebsetSearchCanceled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromWebsetSearchCanceled(global::Exa.EventWebsetSearchCanceledEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventWebsetSearchCompletedEvent value) => new Event((global::Exa.EventWebsetSearchCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventWebsetSearchCompletedEvent?(Event @this) => @this.WebsetSearchCompleted;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventWebsetSearchCompletedEvent? value)
        {
            WebsetSearchCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromWebsetSearchCompleted(global::Exa.EventWebsetSearchCompletedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventImportCreatedEvent value) => new Event((global::Exa.EventImportCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventImportCreatedEvent?(Event @this) => @this.ImportCreated;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventImportCreatedEvent? value)
        {
            ImportCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromImportCreated(global::Exa.EventImportCreatedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventImportCompletedEvent value) => new Event((global::Exa.EventImportCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventImportCompletedEvent?(Event @this) => @this.ImportCompleted;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventImportCompletedEvent? value)
        {
            ImportCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromImportCompleted(global::Exa.EventImportCompletedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventMonitorCreatedEvent value) => new Event((global::Exa.EventMonitorCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventMonitorCreatedEvent?(Event @this) => @this.MonitorCreated;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventMonitorCreatedEvent? value)
        {
            MonitorCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromMonitorCreated(global::Exa.EventMonitorCreatedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventMonitorUpdatedEvent value) => new Event((global::Exa.EventMonitorUpdatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventMonitorUpdatedEvent?(Event @this) => @this.MonitorUpdated;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventMonitorUpdatedEvent? value)
        {
            MonitorUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromMonitorUpdated(global::Exa.EventMonitorUpdatedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventMonitorDeletedEvent value) => new Event((global::Exa.EventMonitorDeletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventMonitorDeletedEvent?(Event @this) => @this.MonitorDeleted;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventMonitorDeletedEvent? value)
        {
            MonitorDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromMonitorDeleted(global::Exa.EventMonitorDeletedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventMonitorRunCreatedEvent value) => new Event((global::Exa.EventMonitorRunCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventMonitorRunCreatedEvent?(Event @this) => @this.MonitorRunCreated;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventMonitorRunCreatedEvent? value)
        {
            MonitorRunCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromMonitorRunCreated(global::Exa.EventMonitorRunCreatedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Event(global::Exa.EventMonitorRunCompletedEvent value) => new Event((global::Exa.EventMonitorRunCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Exa.EventMonitorRunCompletedEvent?(Event @this) => @this.MonitorRunCompleted;

        /// <summary>
        /// 
        /// </summary>
        public Event(global::Exa.EventMonitorRunCompletedEvent? value)
        {
            MonitorRunCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Event FromMonitorRunCompleted(global::Exa.EventMonitorRunCompletedEvent? value) => new Event(value);

        /// <summary>
        /// 
        /// </summary>
        public Event(
            global::Exa.EventDiscriminatorType? type,
            global::Exa.EventWebsetCreatedEvent? websetCreated,
            global::Exa.EventWebsetDeletedEvent? websetDeleted,
            global::Exa.EventWebsetIdleEvent? websetIdle,
            global::Exa.EventWebsetPausedEvent? websetPaused,
            global::Exa.EventWebsetItemCreatedEvent? websetItemCreated,
            global::Exa.EventWebsetItemEnrichedEvent? websetItemEnriched,
            global::Exa.EventWebsetSearchCreatedEvent? websetSearchCreated,
            global::Exa.EventWebsetSearchUpdatedEvent? websetSearchUpdated,
            global::Exa.EventWebsetSearchCanceledEvent? websetSearchCanceled,
            global::Exa.EventWebsetSearchCompletedEvent? websetSearchCompleted,
            global::Exa.EventImportCreatedEvent? importCreated,
            global::Exa.EventImportCompletedEvent? importCompleted,
            global::Exa.EventMonitorCreatedEvent? monitorCreated,
            global::Exa.EventMonitorUpdatedEvent? monitorUpdated,
            global::Exa.EventMonitorDeletedEvent? monitorDeleted,
            global::Exa.EventMonitorRunCreatedEvent? monitorRunCreated,
            global::Exa.EventMonitorRunCompletedEvent? monitorRunCompleted
            )
        {
            Type = type;

            WebsetCreated = websetCreated;
            WebsetDeleted = websetDeleted;
            WebsetIdle = websetIdle;
            WebsetPaused = websetPaused;
            WebsetItemCreated = websetItemCreated;
            WebsetItemEnriched = websetItemEnriched;
            WebsetSearchCreated = websetSearchCreated;
            WebsetSearchUpdated = websetSearchUpdated;
            WebsetSearchCanceled = websetSearchCanceled;
            WebsetSearchCompleted = websetSearchCompleted;
            ImportCreated = importCreated;
            ImportCompleted = importCompleted;
            MonitorCreated = monitorCreated;
            MonitorUpdated = monitorUpdated;
            MonitorDeleted = monitorDeleted;
            MonitorRunCreated = monitorRunCreated;
            MonitorRunCompleted = monitorRunCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MonitorRunCompleted as object ??
            MonitorRunCreated as object ??
            MonitorDeleted as object ??
            MonitorUpdated as object ??
            MonitorCreated as object ??
            ImportCompleted as object ??
            ImportCreated as object ??
            WebsetSearchCompleted as object ??
            WebsetSearchCanceled as object ??
            WebsetSearchUpdated as object ??
            WebsetSearchCreated as object ??
            WebsetItemEnriched as object ??
            WebsetItemCreated as object ??
            WebsetPaused as object ??
            WebsetIdle as object ??
            WebsetDeleted as object ??
            WebsetCreated as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WebsetCreated?.ToString() ??
            WebsetDeleted?.ToString() ??
            WebsetIdle?.ToString() ??
            WebsetPaused?.ToString() ??
            WebsetItemCreated?.ToString() ??
            WebsetItemEnriched?.ToString() ??
            WebsetSearchCreated?.ToString() ??
            WebsetSearchUpdated?.ToString() ??
            WebsetSearchCanceled?.ToString() ??
            WebsetSearchCompleted?.ToString() ??
            ImportCreated?.ToString() ??
            ImportCompleted?.ToString() ??
            MonitorCreated?.ToString() ??
            MonitorUpdated?.ToString() ??
            MonitorDeleted?.ToString() ??
            MonitorRunCreated?.ToString() ??
            MonitorRunCompleted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && IsMonitorDeleted && !IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && IsMonitorRunCreated && !IsMonitorRunCompleted || !IsWebsetCreated && !IsWebsetDeleted && !IsWebsetIdle && !IsWebsetPaused && !IsWebsetItemCreated && !IsWebsetItemEnriched && !IsWebsetSearchCreated && !IsWebsetSearchUpdated && !IsWebsetSearchCanceled && !IsWebsetSearchCompleted && !IsImportCreated && !IsImportCompleted && !IsMonitorCreated && !IsMonitorUpdated && !IsMonitorDeleted && !IsMonitorRunCreated && IsMonitorRunCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Exa.EventWebsetCreatedEvent, TResult>? websetCreated = null,
            global::System.Func<global::Exa.EventWebsetDeletedEvent, TResult>? websetDeleted = null,
            global::System.Func<global::Exa.EventWebsetIdleEvent, TResult>? websetIdle = null,
            global::System.Func<global::Exa.EventWebsetPausedEvent, TResult>? websetPaused = null,
            global::System.Func<global::Exa.EventWebsetItemCreatedEvent, TResult>? websetItemCreated = null,
            global::System.Func<global::Exa.EventWebsetItemEnrichedEvent, TResult>? websetItemEnriched = null,
            global::System.Func<global::Exa.EventWebsetSearchCreatedEvent, TResult>? websetSearchCreated = null,
            global::System.Func<global::Exa.EventWebsetSearchUpdatedEvent, TResult>? websetSearchUpdated = null,
            global::System.Func<global::Exa.EventWebsetSearchCanceledEvent, TResult>? websetSearchCanceled = null,
            global::System.Func<global::Exa.EventWebsetSearchCompletedEvent, TResult>? websetSearchCompleted = null,
            global::System.Func<global::Exa.EventImportCreatedEvent, TResult>? importCreated = null,
            global::System.Func<global::Exa.EventImportCompletedEvent, TResult>? importCompleted = null,
            global::System.Func<global::Exa.EventMonitorCreatedEvent, TResult>? monitorCreated = null,
            global::System.Func<global::Exa.EventMonitorUpdatedEvent, TResult>? monitorUpdated = null,
            global::System.Func<global::Exa.EventMonitorDeletedEvent, TResult>? monitorDeleted = null,
            global::System.Func<global::Exa.EventMonitorRunCreatedEvent, TResult>? monitorRunCreated = null,
            global::System.Func<global::Exa.EventMonitorRunCompletedEvent, TResult>? monitorRunCompleted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebsetCreated && websetCreated != null)
            {
                return websetCreated(WebsetCreated!);
            }
            else if (IsWebsetDeleted && websetDeleted != null)
            {
                return websetDeleted(WebsetDeleted!);
            }
            else if (IsWebsetIdle && websetIdle != null)
            {
                return websetIdle(WebsetIdle!);
            }
            else if (IsWebsetPaused && websetPaused != null)
            {
                return websetPaused(WebsetPaused!);
            }
            else if (IsWebsetItemCreated && websetItemCreated != null)
            {
                return websetItemCreated(WebsetItemCreated!);
            }
            else if (IsWebsetItemEnriched && websetItemEnriched != null)
            {
                return websetItemEnriched(WebsetItemEnriched!);
            }
            else if (IsWebsetSearchCreated && websetSearchCreated != null)
            {
                return websetSearchCreated(WebsetSearchCreated!);
            }
            else if (IsWebsetSearchUpdated && websetSearchUpdated != null)
            {
                return websetSearchUpdated(WebsetSearchUpdated!);
            }
            else if (IsWebsetSearchCanceled && websetSearchCanceled != null)
            {
                return websetSearchCanceled(WebsetSearchCanceled!);
            }
            else if (IsWebsetSearchCompleted && websetSearchCompleted != null)
            {
                return websetSearchCompleted(WebsetSearchCompleted!);
            }
            else if (IsImportCreated && importCreated != null)
            {
                return importCreated(ImportCreated!);
            }
            else if (IsImportCompleted && importCompleted != null)
            {
                return importCompleted(ImportCompleted!);
            }
            else if (IsMonitorCreated && monitorCreated != null)
            {
                return monitorCreated(MonitorCreated!);
            }
            else if (IsMonitorUpdated && monitorUpdated != null)
            {
                return monitorUpdated(MonitorUpdated!);
            }
            else if (IsMonitorDeleted && monitorDeleted != null)
            {
                return monitorDeleted(MonitorDeleted!);
            }
            else if (IsMonitorRunCreated && monitorRunCreated != null)
            {
                return monitorRunCreated(MonitorRunCreated!);
            }
            else if (IsMonitorRunCompleted && monitorRunCompleted != null)
            {
                return monitorRunCompleted(MonitorRunCompleted!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Exa.EventWebsetCreatedEvent>? websetCreated = null,

            global::System.Action<global::Exa.EventWebsetDeletedEvent>? websetDeleted = null,

            global::System.Action<global::Exa.EventWebsetIdleEvent>? websetIdle = null,

            global::System.Action<global::Exa.EventWebsetPausedEvent>? websetPaused = null,

            global::System.Action<global::Exa.EventWebsetItemCreatedEvent>? websetItemCreated = null,

            global::System.Action<global::Exa.EventWebsetItemEnrichedEvent>? websetItemEnriched = null,

            global::System.Action<global::Exa.EventWebsetSearchCreatedEvent>? websetSearchCreated = null,

            global::System.Action<global::Exa.EventWebsetSearchUpdatedEvent>? websetSearchUpdated = null,

            global::System.Action<global::Exa.EventWebsetSearchCanceledEvent>? websetSearchCanceled = null,

            global::System.Action<global::Exa.EventWebsetSearchCompletedEvent>? websetSearchCompleted = null,

            global::System.Action<global::Exa.EventImportCreatedEvent>? importCreated = null,

            global::System.Action<global::Exa.EventImportCompletedEvent>? importCompleted = null,

            global::System.Action<global::Exa.EventMonitorCreatedEvent>? monitorCreated = null,

            global::System.Action<global::Exa.EventMonitorUpdatedEvent>? monitorUpdated = null,

            global::System.Action<global::Exa.EventMonitorDeletedEvent>? monitorDeleted = null,

            global::System.Action<global::Exa.EventMonitorRunCreatedEvent>? monitorRunCreated = null,

            global::System.Action<global::Exa.EventMonitorRunCompletedEvent>? monitorRunCompleted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebsetCreated)
            {
                websetCreated?.Invoke(WebsetCreated!);
            }
            else if (IsWebsetDeleted)
            {
                websetDeleted?.Invoke(WebsetDeleted!);
            }
            else if (IsWebsetIdle)
            {
                websetIdle?.Invoke(WebsetIdle!);
            }
            else if (IsWebsetPaused)
            {
                websetPaused?.Invoke(WebsetPaused!);
            }
            else if (IsWebsetItemCreated)
            {
                websetItemCreated?.Invoke(WebsetItemCreated!);
            }
            else if (IsWebsetItemEnriched)
            {
                websetItemEnriched?.Invoke(WebsetItemEnriched!);
            }
            else if (IsWebsetSearchCreated)
            {
                websetSearchCreated?.Invoke(WebsetSearchCreated!);
            }
            else if (IsWebsetSearchUpdated)
            {
                websetSearchUpdated?.Invoke(WebsetSearchUpdated!);
            }
            else if (IsWebsetSearchCanceled)
            {
                websetSearchCanceled?.Invoke(WebsetSearchCanceled!);
            }
            else if (IsWebsetSearchCompleted)
            {
                websetSearchCompleted?.Invoke(WebsetSearchCompleted!);
            }
            else if (IsImportCreated)
            {
                importCreated?.Invoke(ImportCreated!);
            }
            else if (IsImportCompleted)
            {
                importCompleted?.Invoke(ImportCompleted!);
            }
            else if (IsMonitorCreated)
            {
                monitorCreated?.Invoke(MonitorCreated!);
            }
            else if (IsMonitorUpdated)
            {
                monitorUpdated?.Invoke(MonitorUpdated!);
            }
            else if (IsMonitorDeleted)
            {
                monitorDeleted?.Invoke(MonitorDeleted!);
            }
            else if (IsMonitorRunCreated)
            {
                monitorRunCreated?.Invoke(MonitorRunCreated!);
            }
            else if (IsMonitorRunCompleted)
            {
                monitorRunCompleted?.Invoke(MonitorRunCompleted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Exa.EventWebsetCreatedEvent>? websetCreated = null,
            global::System.Action<global::Exa.EventWebsetDeletedEvent>? websetDeleted = null,
            global::System.Action<global::Exa.EventWebsetIdleEvent>? websetIdle = null,
            global::System.Action<global::Exa.EventWebsetPausedEvent>? websetPaused = null,
            global::System.Action<global::Exa.EventWebsetItemCreatedEvent>? websetItemCreated = null,
            global::System.Action<global::Exa.EventWebsetItemEnrichedEvent>? websetItemEnriched = null,
            global::System.Action<global::Exa.EventWebsetSearchCreatedEvent>? websetSearchCreated = null,
            global::System.Action<global::Exa.EventWebsetSearchUpdatedEvent>? websetSearchUpdated = null,
            global::System.Action<global::Exa.EventWebsetSearchCanceledEvent>? websetSearchCanceled = null,
            global::System.Action<global::Exa.EventWebsetSearchCompletedEvent>? websetSearchCompleted = null,
            global::System.Action<global::Exa.EventImportCreatedEvent>? importCreated = null,
            global::System.Action<global::Exa.EventImportCompletedEvent>? importCompleted = null,
            global::System.Action<global::Exa.EventMonitorCreatedEvent>? monitorCreated = null,
            global::System.Action<global::Exa.EventMonitorUpdatedEvent>? monitorUpdated = null,
            global::System.Action<global::Exa.EventMonitorDeletedEvent>? monitorDeleted = null,
            global::System.Action<global::Exa.EventMonitorRunCreatedEvent>? monitorRunCreated = null,
            global::System.Action<global::Exa.EventMonitorRunCompletedEvent>? monitorRunCompleted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebsetCreated)
            {
                websetCreated?.Invoke(WebsetCreated!);
            }
            else if (IsWebsetDeleted)
            {
                websetDeleted?.Invoke(WebsetDeleted!);
            }
            else if (IsWebsetIdle)
            {
                websetIdle?.Invoke(WebsetIdle!);
            }
            else if (IsWebsetPaused)
            {
                websetPaused?.Invoke(WebsetPaused!);
            }
            else if (IsWebsetItemCreated)
            {
                websetItemCreated?.Invoke(WebsetItemCreated!);
            }
            else if (IsWebsetItemEnriched)
            {
                websetItemEnriched?.Invoke(WebsetItemEnriched!);
            }
            else if (IsWebsetSearchCreated)
            {
                websetSearchCreated?.Invoke(WebsetSearchCreated!);
            }
            else if (IsWebsetSearchUpdated)
            {
                websetSearchUpdated?.Invoke(WebsetSearchUpdated!);
            }
            else if (IsWebsetSearchCanceled)
            {
                websetSearchCanceled?.Invoke(WebsetSearchCanceled!);
            }
            else if (IsWebsetSearchCompleted)
            {
                websetSearchCompleted?.Invoke(WebsetSearchCompleted!);
            }
            else if (IsImportCreated)
            {
                importCreated?.Invoke(ImportCreated!);
            }
            else if (IsImportCompleted)
            {
                importCompleted?.Invoke(ImportCompleted!);
            }
            else if (IsMonitorCreated)
            {
                monitorCreated?.Invoke(MonitorCreated!);
            }
            else if (IsMonitorUpdated)
            {
                monitorUpdated?.Invoke(MonitorUpdated!);
            }
            else if (IsMonitorDeleted)
            {
                monitorDeleted?.Invoke(MonitorDeleted!);
            }
            else if (IsMonitorRunCreated)
            {
                monitorRunCreated?.Invoke(MonitorRunCreated!);
            }
            else if (IsMonitorRunCompleted)
            {
                monitorRunCompleted?.Invoke(MonitorRunCompleted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebsetCreated,
                typeof(global::Exa.EventWebsetCreatedEvent),
                WebsetDeleted,
                typeof(global::Exa.EventWebsetDeletedEvent),
                WebsetIdle,
                typeof(global::Exa.EventWebsetIdleEvent),
                WebsetPaused,
                typeof(global::Exa.EventWebsetPausedEvent),
                WebsetItemCreated,
                typeof(global::Exa.EventWebsetItemCreatedEvent),
                WebsetItemEnriched,
                typeof(global::Exa.EventWebsetItemEnrichedEvent),
                WebsetSearchCreated,
                typeof(global::Exa.EventWebsetSearchCreatedEvent),
                WebsetSearchUpdated,
                typeof(global::Exa.EventWebsetSearchUpdatedEvent),
                WebsetSearchCanceled,
                typeof(global::Exa.EventWebsetSearchCanceledEvent),
                WebsetSearchCompleted,
                typeof(global::Exa.EventWebsetSearchCompletedEvent),
                ImportCreated,
                typeof(global::Exa.EventImportCreatedEvent),
                ImportCompleted,
                typeof(global::Exa.EventImportCompletedEvent),
                MonitorCreated,
                typeof(global::Exa.EventMonitorCreatedEvent),
                MonitorUpdated,
                typeof(global::Exa.EventMonitorUpdatedEvent),
                MonitorDeleted,
                typeof(global::Exa.EventMonitorDeletedEvent),
                MonitorRunCreated,
                typeof(global::Exa.EventMonitorRunCreatedEvent),
                MonitorRunCompleted,
                typeof(global::Exa.EventMonitorRunCompletedEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Event other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventWebsetCreatedEvent?>.Default.Equals(WebsetCreated, other.WebsetCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventWebsetDeletedEvent?>.Default.Equals(WebsetDeleted, other.WebsetDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventWebsetIdleEvent?>.Default.Equals(WebsetIdle, other.WebsetIdle) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventWebsetPausedEvent?>.Default.Equals(WebsetPaused, other.WebsetPaused) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventWebsetItemCreatedEvent?>.Default.Equals(WebsetItemCreated, other.WebsetItemCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventWebsetItemEnrichedEvent?>.Default.Equals(WebsetItemEnriched, other.WebsetItemEnriched) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventWebsetSearchCreatedEvent?>.Default.Equals(WebsetSearchCreated, other.WebsetSearchCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventWebsetSearchUpdatedEvent?>.Default.Equals(WebsetSearchUpdated, other.WebsetSearchUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventWebsetSearchCanceledEvent?>.Default.Equals(WebsetSearchCanceled, other.WebsetSearchCanceled) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventWebsetSearchCompletedEvent?>.Default.Equals(WebsetSearchCompleted, other.WebsetSearchCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventImportCreatedEvent?>.Default.Equals(ImportCreated, other.ImportCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventImportCompletedEvent?>.Default.Equals(ImportCompleted, other.ImportCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventMonitorCreatedEvent?>.Default.Equals(MonitorCreated, other.MonitorCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventMonitorUpdatedEvent?>.Default.Equals(MonitorUpdated, other.MonitorUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventMonitorDeletedEvent?>.Default.Equals(MonitorDeleted, other.MonitorDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventMonitorRunCreatedEvent?>.Default.Equals(MonitorRunCreated, other.MonitorRunCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Exa.EventMonitorRunCompletedEvent?>.Default.Equals(MonitorRunCompleted, other.MonitorRunCompleted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Event obj1, Event obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Event>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Event obj1, Event obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Event o && Equals(o);
        }
    }
}
