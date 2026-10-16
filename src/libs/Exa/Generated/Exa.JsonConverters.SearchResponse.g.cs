#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class SearchResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.SearchResponse>
    {
        /// <inheritdoc />
        public override global::Exa.SearchResponse Read(
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
            if (__jsonProps.Contains("context")) __score0++;
            if (__jsonProps.Contains("costDollars")) __score0++;
            if (__jsonProps.Contains("costDollars.contents")) __score0++;
            if (__jsonProps.Contains("costDollars.search")) __score0++;
            if (__jsonProps.Contains("costDollars.summary")) __score0++;
            if (__jsonProps.Contains("costDollars.total")) __score0++;
            if (__jsonProps.Contains("notices")) __score0++;
            if (__jsonProps.Contains("output")) __score0++;
            if (__jsonProps.Contains("output.content")) __score0++;
            if (__jsonProps.Contains("output.grounding")) __score0++;
            if (__jsonProps.Contains("requestId")) __score0++;
            if (__jsonProps.Contains("resolvedSearchType")) __score0++;
            if (__jsonProps.Contains("results")) __score0++;
            if (__jsonProps.Contains("searchTime")) __score0++;
            if (__jsonProps.Contains("warnings")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("context")) __score1++;
            if (__jsonProps.Contains("costDollars")) __score1++;
            if (__jsonProps.Contains("costDollars.contents")) __score1++;
            if (__jsonProps.Contains("costDollars.search")) __score1++;
            if (__jsonProps.Contains("costDollars.summary")) __score1++;
            if (__jsonProps.Contains("costDollars.total")) __score1++;
            if (__jsonProps.Contains("notices")) __score1++;
            if (__jsonProps.Contains("requestId")) __score1++;
            if (__jsonProps.Contains("resolvedSearchType")) __score1++;
            if (__jsonProps.Contains("results")) __score1++;
            if (__jsonProps.Contains("searchTime")) __score1++;
            if (__jsonProps.Contains("warnings")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Exa.SearchSynthesisResponse? synthesis = default;
            global::Exa.SearchResultsResponse? results = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchSynthesisResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchSynthesisResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchSynthesisResponse).Name}");
                        synthesis = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchResultsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchResultsResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchResultsResponse).Name}");
                        results = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (synthesis == null && results == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchSynthesisResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchSynthesisResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchSynthesisResponse).Name}");
                    synthesis = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (synthesis == null && results == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchResultsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchResultsResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchResultsResponse).Name}");
                    results = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Exa.SearchResponse(
                synthesis,

                results
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.SearchResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSynthesis)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchSynthesisResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchSynthesisResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchSynthesisResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSynthesis(), typeInfo);
            }
            else if (value.IsResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.SearchResultsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.SearchResultsResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.SearchResultsResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResults(), typeInfo);
            }
        }
    }
}