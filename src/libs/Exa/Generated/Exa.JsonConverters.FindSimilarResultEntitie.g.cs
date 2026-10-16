#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class FindSimilarResultEntitieJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.FindSimilarResultEntitie>
    {
        /// <inheritdoc />
        public override global::Exa.FindSimilarResultEntitie Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.FindSimilarResultEntitieDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.FindSimilarResultEntitieDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.FindSimilarResultEntitieDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.SearchCompanyEntityOutput? company = default;
            if (discriminator?.Type == global::Exa.FindSimilarResultEntitieDiscriminatorType.Company)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchCompanyEntityOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchCompanyEntityOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.SearchCompanyEntityOutput)}");
                company = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.SearchPersonEntityOutput? person = default;
            if (discriminator?.Type == global::Exa.FindSimilarResultEntitieDiscriminatorType.Person)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchPersonEntityOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchPersonEntityOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.SearchPersonEntityOutput)}");
                person = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.SearchPublicationEntityOutput? publication = default;
            if (discriminator?.Type == global::Exa.FindSimilarResultEntitieDiscriminatorType.Publication)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchPublicationEntityOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchPublicationEntityOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.SearchPublicationEntityOutput)}");
                publication = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.FindSimilarResultEntitie(
                discriminator?.Type,
                company,

                person,

                publication
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.FindSimilarResultEntitie value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompany)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchCompanyEntityOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchCompanyEntityOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchCompanyEntityOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCompany(), typeInfo);
            }
            else if (value.IsPerson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchPersonEntityOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchPersonEntityOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchPersonEntityOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPerson(), typeInfo);
            }
            else if (value.IsPublication)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchPublicationEntityOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchPublicationEntityOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchPublicationEntityOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPublication(), typeInfo);
            }
        }
    }
}