#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class SearchMonitorOutputSchemaVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.SearchMonitorOutputSchemaVariant1>
    {
        /// <inheritdoc />
        public override global::Exa.SearchMonitorOutputSchemaVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchMonitorOutputSchemaVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchMonitorOutputSchemaVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.SearchMonitorOutputSchemaVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.OutputSchemaText? text = default;
            if (discriminator?.Type == global::Exa.SearchMonitorOutputSchemaVariant1DiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.OutputSchemaText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.OutputSchemaText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.OutputSchemaText)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.OutputSchemaObject? objectValue = default;
            if (discriminator?.Type == global::Exa.SearchMonitorOutputSchemaVariant1DiscriminatorType.Object)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.OutputSchemaObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.OutputSchemaObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.OutputSchemaObject)}");
                objectValue = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.SearchMonitorOutputSchemaVariant1(
                discriminator?.Type,
                text,

                objectValue
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.SearchMonitorOutputSchemaVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.OutputSchemaText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.OutputSchemaText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.OutputSchemaText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
            else if (value.IsObjectValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.OutputSchemaObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.OutputSchemaObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.OutputSchemaObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickObjectValue(), typeInfo);
            }
        }
    }
}