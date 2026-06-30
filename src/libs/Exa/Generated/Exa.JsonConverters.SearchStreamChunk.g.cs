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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("choices")) __score0++;
            if (__jsonProps.Contains("delta")) __score0++;
            if (__jsonProps.Contains("requestId")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("choices")) __score1++;
            if (__jsonProps.Contains("citations")) __score1++;
            if (__jsonProps.Contains("grounding")) __score1++;
            if (__jsonProps.Contains("requestId")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("requestId")) __score2++;
            if (__jsonProps.Contains("results")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("requestId")) __score3++;
            if (__jsonProps.Contains("streamReset")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("choices")) __score4++;
            if (__jsonProps.Contains("costDollars")) __score4++;
            if (__jsonProps.Contains("costDollars.search")) __score4++;
            if (__jsonProps.Contains("costDollars.total")) __score4++;
            if (__jsonProps.Contains("output")) __score4++;
            if (__jsonProps.Contains("requestId")) __score4++;
            if (__jsonProps.Contains("searchTime")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("error")) __score5++;
            if (__jsonProps.Contains("error.message")) __score5++;
            if (__jsonProps.Contains("requestId")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::Exa.SearchStreamChunkVariant1? searchStreamChunkVariant1 = default;
            global::Exa.SearchStreamChunkVariant2? searchStreamChunkVariant2 = default;
            global::Exa.SearchStreamChunkVariant3? searchStreamChunkVariant3 = default;
            global::Exa.SearchStreamChunkVariant4? searchStreamChunkVariant4 = default;
            global::Exa.SearchStreamChunkVariant5? searchStreamChunkVariant5 = default;
            global::Exa.SearchStreamChunkVariant6? searchStreamChunkVariant6 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant1).Name}");
                        searchStreamChunkVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant2).Name}");
                        searchStreamChunkVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant3).Name}");
                        searchStreamChunkVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant4).Name}");
                        searchStreamChunkVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant5).Name}");
                        searchStreamChunkVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant6).Name}");
                        searchStreamChunkVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (searchStreamChunkVariant1 == null && searchStreamChunkVariant2 == null && searchStreamChunkVariant3 == null && searchStreamChunkVariant4 == null && searchStreamChunkVariant5 == null && searchStreamChunkVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant1).Name}");
                    searchStreamChunkVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (searchStreamChunkVariant1 == null && searchStreamChunkVariant2 == null && searchStreamChunkVariant3 == null && searchStreamChunkVariant4 == null && searchStreamChunkVariant5 == null && searchStreamChunkVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant2).Name}");
                    searchStreamChunkVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (searchStreamChunkVariant1 == null && searchStreamChunkVariant2 == null && searchStreamChunkVariant3 == null && searchStreamChunkVariant4 == null && searchStreamChunkVariant5 == null && searchStreamChunkVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant3).Name}");
                    searchStreamChunkVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (searchStreamChunkVariant1 == null && searchStreamChunkVariant2 == null && searchStreamChunkVariant3 == null && searchStreamChunkVariant4 == null && searchStreamChunkVariant5 == null && searchStreamChunkVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant4).Name}");
                    searchStreamChunkVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (searchStreamChunkVariant1 == null && searchStreamChunkVariant2 == null && searchStreamChunkVariant3 == null && searchStreamChunkVariant4 == null && searchStreamChunkVariant5 == null && searchStreamChunkVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant5).Name}");
                    searchStreamChunkVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (searchStreamChunkVariant1 == null && searchStreamChunkVariant2 == null && searchStreamChunkVariant3 == null && searchStreamChunkVariant4 == null && searchStreamChunkVariant5 == null && searchStreamChunkVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant6).Name}");
                    searchStreamChunkVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Exa.SearchStreamChunk(
                searchStreamChunkVariant1,

                searchStreamChunkVariant2,

                searchStreamChunkVariant3,

                searchStreamChunkVariant4,

                searchStreamChunkVariant5,

                searchStreamChunkVariant6
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

            if (value.IsSearchStreamChunkVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchStreamChunkVariant1!, typeInfo);
            }
            else if (value.IsSearchStreamChunkVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchStreamChunkVariant2!, typeInfo);
            }
            else if (value.IsSearchStreamChunkVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchStreamChunkVariant3!, typeInfo);
            }
            else if (value.IsSearchStreamChunkVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchStreamChunkVariant4!, typeInfo);
            }
            else if (value.IsSearchStreamChunkVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchStreamChunkVariant5!, typeInfo);
            }
            else if (value.IsSearchStreamChunkVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchStreamChunkVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchStreamChunkVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchStreamChunkVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchStreamChunkVariant6!, typeInfo);
            }
        }
    }
}