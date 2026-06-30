#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class CreateImportParametersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.CreateImportParameters>
    {
        /// <inheritdoc />
        public override global::Exa.CreateImportParameters Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.CreateImportParametersDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.CreateImportParametersDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.CreateImportParametersDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.CreateImportParametersVariant1? csv = default;
            if (discriminator?.Format == global::Exa.CreateImportParametersDiscriminatorFormat.Csv)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.CreateImportParametersVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.CreateImportParametersVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.CreateImportParametersVariant1)}");
                csv = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.CreateImportParameters(
                discriminator?.Format,
                csv
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.CreateImportParameters value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCsv)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.CreateImportParametersVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.CreateImportParametersVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.CreateImportParametersVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Csv!, typeInfo);
            }
        }
    }
}