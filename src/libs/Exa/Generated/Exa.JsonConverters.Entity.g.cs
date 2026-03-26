#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class EntityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.Entity>
    {
        /// <inheritdoc />
        public override global::Exa.Entity Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.EntityDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.EntityDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.EntityDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.CompanyEntity? company = default;
            if (discriminator?.Type == global::Exa.EntityDiscriminatorType.Company)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.CompanyEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.CompanyEntity> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.CompanyEntity)}");
                company = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.PersonEntity? person = default;
            if (discriminator?.Type == global::Exa.EntityDiscriminatorType.Person)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.PersonEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.PersonEntity> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.PersonEntity)}");
                person = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.Entity(
                discriminator?.Type,
                company,

                person
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.Entity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompany)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.CompanyEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.CompanyEntity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.CompanyEntity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Company, typeInfo);
            }
            else if (value.IsPerson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.PersonEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.PersonEntity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.PersonEntity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Person, typeInfo);
            }
        }
    }
}