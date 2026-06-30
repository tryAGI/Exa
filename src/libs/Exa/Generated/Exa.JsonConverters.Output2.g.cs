#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class Output2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.Output2>
    {
        /// <inheritdoc />
        public override global::Exa.Output2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks? tasks = default;
            if (discriminator?.OutputType == global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType.Tasks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks)}");
                tasks = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop? stop = default;
            if (discriminator?.OutputType == global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType.Stop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop)}");
                stop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.Output2(
                discriminator?.OutputType,
                tasks,

                stop
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.Output2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTasks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasks).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tasks!, typeInfo);
            }
            else if (value.IsStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStop).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stop!, typeInfo);
            }
        }
    }
}