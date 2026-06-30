#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class ResearchEventDtoClassVariant3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ResearchEventDtoClassVariant3>
    {
        /// <inheritdoc />
        public override global::Exa.ResearchEventDtoClassVariant3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant3Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.ResearchEventDtoClassVariant3TaskDefinition? taskDefinition = default;
            if (discriminator?.EventType == global::Exa.ResearchEventDtoClassVariant3DiscriminatorEventType.TaskDefinition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskDefinition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskDefinition> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant3TaskDefinition)}");
                taskDefinition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchEventDtoClassVariant3TaskOperation? taskOperation = default;
            if (discriminator?.EventType == global::Exa.ResearchEventDtoClassVariant3DiscriminatorEventType.TaskOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskOperation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant3TaskOperation)}");
                taskOperation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchEventDtoClassVariant3TaskOutput? taskOutput = default;
            if (discriminator?.EventType == global::Exa.ResearchEventDtoClassVariant3DiscriminatorEventType.TaskOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant3TaskOutput)}");
                taskOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.ResearchEventDtoClassVariant3(
                discriminator?.EventType,
                taskDefinition,

                taskOperation,

                taskOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ResearchEventDtoClassVariant3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTaskDefinition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskDefinition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskDefinition?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant3TaskDefinition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TaskDefinition!, typeInfo);
            }
            else if (value.IsTaskOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TaskOperation!, typeInfo);
            }
            else if (value.IsTaskOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant3TaskOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TaskOutput!, typeInfo);
            }
        }
    }
}