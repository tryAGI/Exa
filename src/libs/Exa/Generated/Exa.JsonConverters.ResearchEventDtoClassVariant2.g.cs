#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class ResearchEventDtoClassVariant2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ResearchEventDtoClassVariant2>
    {
        /// <inheritdoc />
        public override global::Exa.ResearchEventDtoClassVariant2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant2Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.ResearchEventDtoClassVariant2PlanDefinition? planDefinition = default;
            if (discriminator?.EventType == global::Exa.ResearchEventDtoClassVariant2DiscriminatorEventType.PlanDefinition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2PlanDefinition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2PlanDefinition> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant2PlanDefinition)}");
                planDefinition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchEventDtoClassVariant2PlanOperation? planOperation = default;
            if (discriminator?.EventType == global::Exa.ResearchEventDtoClassVariant2DiscriminatorEventType.PlanOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2PlanOperation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant2PlanOperation)}");
                planOperation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchEventDtoClassVariant2PlanOutput? planOutput = default;
            if (discriminator?.EventType == global::Exa.ResearchEventDtoClassVariant2DiscriminatorEventType.PlanOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2PlanOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant2PlanOutput)}");
                planOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.ResearchEventDtoClassVariant2(
                discriminator?.EventType,
                planDefinition,

                planOperation,

                planOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ResearchEventDtoClassVariant2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPlanDefinition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2PlanDefinition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2PlanDefinition?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant2PlanDefinition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlanDefinition!, typeInfo);
            }
            else if (value.IsPlanOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2PlanOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant2PlanOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlanOperation!, typeInfo);
            }
            else if (value.IsPlanOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2PlanOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlanOutput!, typeInfo);
            }
        }
    }
}