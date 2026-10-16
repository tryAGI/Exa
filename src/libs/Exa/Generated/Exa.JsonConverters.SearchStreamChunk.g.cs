#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class SearchStreamChunkJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.SearchStreamChunk>
    {
        /// <inheritdoc />
        public override global::Exa.SearchStreamChunk Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.SearchStreamChunkDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.SearchStreamTextDeltaChunkOutput? textDelta = default;
            if (discriminator?.Type == global::Exa.SearchStreamChunkDiscriminatorType.TextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamTextDeltaChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamTextDeltaChunkOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.SearchStreamTextDeltaChunkOutput)}");
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.SearchStreamGroundingChunkOutput? grounding = default;
            if (discriminator?.Type == global::Exa.SearchStreamChunkDiscriminatorType.Grounding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamGroundingChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamGroundingChunkOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.SearchStreamGroundingChunkOutput)}");
                grounding = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.SearchStreamResultsChunkOutput? results = default;
            if (discriminator?.Type == global::Exa.SearchStreamChunkDiscriminatorType.Results)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamResultsChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamResultsChunkOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.SearchStreamResultsChunkOutput)}");
                results = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.SearchStreamResetChunkOutput? streamReset = default;
            if (discriminator?.Type == global::Exa.SearchStreamChunkDiscriminatorType.StreamReset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamResetChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamResetChunkOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.SearchStreamResetChunkOutput)}");
                streamReset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.SearchStreamDoneChunkOutput? done = default;
            if (discriminator?.Type == global::Exa.SearchStreamChunkDiscriminatorType.Done)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamDoneChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamDoneChunkOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.SearchStreamDoneChunkOutput)}");
                done = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.SearchStreamErrorChunkOutput? error = default;
            if (discriminator?.Type == global::Exa.SearchStreamChunkDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamErrorChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamErrorChunkOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.SearchStreamErrorChunkOutput)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.SearchStreamChunk(
                discriminator?.Type,
                textDelta,

                grounding,

                results,

                streamReset,

                done,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.SearchStreamChunk value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamTextDeltaChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamTextDeltaChunkOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamTextDeltaChunkOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextDelta(), typeInfo);
            }
            else if (value.IsGrounding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamGroundingChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamGroundingChunkOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamGroundingChunkOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGrounding(), typeInfo);
            }
            else if (value.IsResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamResultsChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamResultsChunkOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamResultsChunkOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResults(), typeInfo);
            }
            else if (value.IsStreamReset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamResetChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamResetChunkOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamResetChunkOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickStreamReset(), typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamDoneChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamDoneChunkOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamDoneChunkOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDone(), typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamErrorChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamErrorChunkOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamErrorChunkOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickError(), typeInfo);
            }
        }
    }
}