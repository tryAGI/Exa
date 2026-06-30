#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class Data2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.Data2>
    {
        /// <inheritdoc />
        public override global::Exa.Data2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink? think = default;
            if (discriminator?.Type == global::Exa.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType.Think)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink)}");
                think = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch? search = default;
            if (discriminator?.Type == global::Exa.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType.Search)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch)}");
                search = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl? crawl = default;
            if (discriminator?.Type == global::Exa.ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType.Crawl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl)}");
                crawl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.Data2(
                discriminator?.Type,
                think,

                search,

                crawl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.Data2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsThink)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThink).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Think!, typeInfo);
            }
            else if (value.IsSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearch).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Search!, typeInfo);
            }
            else if (value.IsCrawl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawl).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Crawl!, typeInfo);
            }
        }
    }
}