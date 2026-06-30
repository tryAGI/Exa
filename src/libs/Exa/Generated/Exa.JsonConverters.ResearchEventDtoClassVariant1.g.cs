#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class ResearchEventDtoClassVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ResearchEventDtoClassVariant1>
    {
        /// <inheritdoc />
        public override global::Exa.ResearchEventDtoClassVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.ResearchEventDtoClassVariant1ResearchDefinition? researchDefinition = default;
            if (discriminator?.EventType == global::Exa.ResearchEventDtoClassVariant1DiscriminatorEventType.ResearchDefinition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchDefinition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant1ResearchDefinition> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant1ResearchDefinition)}");
                researchDefinition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchEventDtoClassVariant1ResearchOutput? researchOutput = default;
            if (discriminator?.EventType == global::Exa.ResearchEventDtoClassVariant1DiscriminatorEventType.ResearchOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant1ResearchOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant1ResearchOutput)}");
                researchOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.ResearchEventDtoClassVariant1(
                discriminator?.EventType,
                researchDefinition,

                researchOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ResearchEventDtoClassVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResearchDefinition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchDefinition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant1ResearchDefinition?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant1ResearchDefinition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResearchDefinition!, typeInfo);
            }
            else if (value.IsResearchOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant1ResearchOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant1ResearchOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResearchOutput!, typeInfo);
            }
        }
    }
}