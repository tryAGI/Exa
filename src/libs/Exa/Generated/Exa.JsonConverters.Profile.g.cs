#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class ProfileJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.Profile>
    {
        /// <inheritdoc />
        public override global::Exa.Profile Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Exa.ResearchDtoClassCompletedCitationProfileVariant1? linkedinCompany = default;
            if (discriminator?.Type == global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminatorType.LinkedinCompany)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1)}");
                linkedinCompany = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2? company = default;
            if (discriminator?.Type == global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminatorType.Company)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2)}");
                company = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant3? linkedinPerson = default;
            if (discriminator?.Type == global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminatorType.LinkedinPerson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3)}");
                linkedinPerson = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4? person = default;
            if (discriminator?.Type == global::Exa.ResearchDtoClassCompletedCitationProfileDiscriminatorType.Person)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4)}");
                person = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Exa.Profile(
                discriminator?.Type,
                linkedinCompany,

                company,

                linkedinPerson,

                person
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.Profile value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLinkedinCompany)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LinkedinCompany!, typeInfo);
            }
            else if (value.IsCompany)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Company!, typeInfo);
            }
            else if (value.IsLinkedinPerson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LinkedinPerson!, typeInfo);
            }
            else if (value.IsPerson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Person!, typeInfo);
            }
        }
    }
}