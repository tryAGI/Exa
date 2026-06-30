#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class GetWebsetResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.GetWebsetResponse>
    {
        /// <inheritdoc />
        public override global::Exa.GetWebsetResponse Read(
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
            if (__jsonProps.Contains("createdAt")) __score0++;
            if (__jsonProps.Contains("dashboardUrl")) __score0++;
            if (__jsonProps.Contains("enrichments")) __score0++;
            if (__jsonProps.Contains("excludes")) __score0++;
            if (__jsonProps.Contains("externalId")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("imports")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("monitors")) __score0++;
            if (__jsonProps.Contains("object")) __score0++;
            if (__jsonProps.Contains("searches")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("title")) __score0++;
            if (__jsonProps.Contains("updatedAt")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("items")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Exa.Webset? webset = default;
            global::Exa.GetWebsetResponseVariant2? getWebsetResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.Webset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.Webset> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.Webset).Name}");
                        webset = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.GetWebsetResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.GetWebsetResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.GetWebsetResponseVariant2).Name}");
                        getWebsetResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (webset == null && getWebsetResponseVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.Webset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.Webset> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.Webset).Name}");
                    webset = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (webset == null && getWebsetResponseVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.GetWebsetResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.GetWebsetResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.GetWebsetResponseVariant2).Name}");
                    getWebsetResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Exa.GetWebsetResponse(
                webset,

                getWebsetResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.GetWebsetResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.Webset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.Webset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.Webset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webset!, typeInfo);
            }
            else if (value.IsGetWebsetResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.GetWebsetResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.GetWebsetResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.GetWebsetResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetWebsetResponseVariant2!, typeInfo);
            }
        }
    }
}