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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("description")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Exa.CompanyEntity? company = default;
            global::Exa.PersonEntity? person = default;
            global::Exa.ArticleEntity? article = default;
            global::Exa.ResearchPaperEntity? researchPaper = default;
            global::Exa.CustomEntity? custom = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.CompanyEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.CompanyEntity> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.CompanyEntity).Name}");
                        company = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.PersonEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.PersonEntity> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.PersonEntity).Name}");
                        person = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ArticleEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ArticleEntity> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ArticleEntity).Name}");
                        article = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchPaperEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchPaperEntity> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchPaperEntity).Name}");
                        researchPaper = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.CustomEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.CustomEntity> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.CustomEntity).Name}");
                        custom = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (company == null && person == null && article == null && researchPaper == null && custom == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.CompanyEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.CompanyEntity> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.CompanyEntity).Name}");
                    company = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (company == null && person == null && article == null && researchPaper == null && custom == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.PersonEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.PersonEntity> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.PersonEntity).Name}");
                    person = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (company == null && person == null && article == null && researchPaper == null && custom == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ArticleEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ArticleEntity> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ArticleEntity).Name}");
                    article = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (company == null && person == null && article == null && researchPaper == null && custom == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchPaperEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchPaperEntity> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchPaperEntity).Name}");
                    researchPaper = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (company == null && person == null && article == null && researchPaper == null && custom == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.CustomEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.CustomEntity> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.CustomEntity).Name}");
                    custom = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Exa.Entity(
                company,

                person,

                article,

                researchPaper,

                custom
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Company!, typeInfo);
            }
            else if (value.IsPerson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.PersonEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.PersonEntity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.PersonEntity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Person!, typeInfo);
            }
            else if (value.IsArticle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ArticleEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ArticleEntity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ArticleEntity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Article!, typeInfo);
            }
            else if (value.IsResearchPaper)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchPaperEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchPaperEntity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchPaperEntity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResearchPaper!, typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.CustomEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.CustomEntity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.CustomEntity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom!, typeInfo);
            }
        }
    }
}