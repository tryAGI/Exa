#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class EventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.Event>
    {
        /// <inheritdoc />
        public override global::Exa.Event Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.EventWebsetCreatedEvent? websetCreated = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.WebsetCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventWebsetCreatedEvent)}");
                websetCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventWebsetDeletedEvent? websetDeleted = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.WebsetDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetDeletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetDeletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventWebsetDeletedEvent)}");
                websetDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventWebsetIdleEvent? websetIdle = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.WebsetIdle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetIdleEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetIdleEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventWebsetIdleEvent)}");
                websetIdle = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventWebsetPausedEvent? websetPaused = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.WebsetPaused)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetPausedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetPausedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventWebsetPausedEvent)}");
                websetPaused = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventWebsetItemCreatedEvent? websetItemCreated = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.WebsetItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetItemCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetItemCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventWebsetItemCreatedEvent)}");
                websetItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventWebsetItemEnrichedEvent? websetItemEnriched = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.WebsetItemEnriched)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetItemEnrichedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetItemEnrichedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventWebsetItemEnrichedEvent)}");
                websetItemEnriched = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventWebsetSearchCreatedEvent? websetSearchCreated = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.WebsetSearchCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetSearchCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetSearchCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventWebsetSearchCreatedEvent)}");
                websetSearchCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventWebsetSearchUpdatedEvent? websetSearchUpdated = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.WebsetSearchUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetSearchUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetSearchUpdatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventWebsetSearchUpdatedEvent)}");
                websetSearchUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventWebsetSearchCanceledEvent? websetSearchCanceled = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.WebsetSearchCanceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetSearchCanceledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetSearchCanceledEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventWebsetSearchCanceledEvent)}");
                websetSearchCanceled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventWebsetSearchCompletedEvent? websetSearchCompleted = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.WebsetSearchCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetSearchCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetSearchCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventWebsetSearchCompletedEvent)}");
                websetSearchCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventImportCreatedEvent? importCreated = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.ImportCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventImportCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventImportCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventImportCreatedEvent)}");
                importCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventImportCompletedEvent? importCompleted = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.ImportCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventImportCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventImportCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventImportCompletedEvent)}");
                importCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventMonitorCreatedEvent? monitorCreated = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.MonitorCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventMonitorCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventMonitorCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventMonitorCreatedEvent)}");
                monitorCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventMonitorUpdatedEvent? monitorUpdated = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.MonitorUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventMonitorUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventMonitorUpdatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventMonitorUpdatedEvent)}");
                monitorUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventMonitorDeletedEvent? monitorDeleted = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.MonitorDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventMonitorDeletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventMonitorDeletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventMonitorDeletedEvent)}");
                monitorDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventMonitorRunCreatedEvent? monitorRunCreated = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.MonitorRunCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventMonitorRunCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventMonitorRunCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventMonitorRunCreatedEvent)}");
                monitorRunCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.EventMonitorRunCompletedEvent? monitorRunCompleted = default;
            if (discriminator?.Type == global::Exa.EventDiscriminatorType.MonitorRunCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventMonitorRunCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventMonitorRunCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EventMonitorRunCompletedEvent)}");
                monitorRunCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.Event(
                discriminator?.Type,
                websetCreated,

                websetDeleted,

                websetIdle,

                websetPaused,

                websetItemCreated,

                websetItemEnriched,

                websetSearchCreated,

                websetSearchUpdated,

                websetSearchCanceled,

                websetSearchCompleted,

                importCreated,

                importCompleted,

                monitorCreated,

                monitorUpdated,

                monitorDeleted,

                monitorRunCreated,

                monitorRunCompleted
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.Event value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebsetCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventWebsetCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebsetCreated!, typeInfo);
            }
            else if (value.IsWebsetDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetDeletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetDeletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventWebsetDeletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebsetDeleted!, typeInfo);
            }
            else if (value.IsWebsetIdle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetIdleEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetIdleEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventWebsetIdleEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebsetIdle!, typeInfo);
            }
            else if (value.IsWebsetPaused)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetPausedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetPausedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventWebsetPausedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebsetPaused!, typeInfo);
            }
            else if (value.IsWebsetItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetItemCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetItemCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventWebsetItemCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebsetItemCreated!, typeInfo);
            }
            else if (value.IsWebsetItemEnriched)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetItemEnrichedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetItemEnrichedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventWebsetItemEnrichedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebsetItemEnriched!, typeInfo);
            }
            else if (value.IsWebsetSearchCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetSearchCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetSearchCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventWebsetSearchCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebsetSearchCreated!, typeInfo);
            }
            else if (value.IsWebsetSearchUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetSearchUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetSearchUpdatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventWebsetSearchUpdatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebsetSearchUpdated!, typeInfo);
            }
            else if (value.IsWebsetSearchCanceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetSearchCanceledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetSearchCanceledEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventWebsetSearchCanceledEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebsetSearchCanceled!, typeInfo);
            }
            else if (value.IsWebsetSearchCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventWebsetSearchCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventWebsetSearchCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventWebsetSearchCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebsetSearchCompleted!, typeInfo);
            }
            else if (value.IsImportCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventImportCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventImportCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventImportCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImportCreated!, typeInfo);
            }
            else if (value.IsImportCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventImportCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventImportCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventImportCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImportCompleted!, typeInfo);
            }
            else if (value.IsMonitorCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventMonitorCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventMonitorCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventMonitorCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MonitorCreated!, typeInfo);
            }
            else if (value.IsMonitorUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventMonitorUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventMonitorUpdatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventMonitorUpdatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MonitorUpdated!, typeInfo);
            }
            else if (value.IsMonitorDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventMonitorDeletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventMonitorDeletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventMonitorDeletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MonitorDeleted!, typeInfo);
            }
            else if (value.IsMonitorRunCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventMonitorRunCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventMonitorRunCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventMonitorRunCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MonitorRunCreated!, typeInfo);
            }
            else if (value.IsMonitorRunCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EventMonitorRunCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EventMonitorRunCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.EventMonitorRunCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MonitorRunCompleted!, typeInfo);
            }
        }
    }
}