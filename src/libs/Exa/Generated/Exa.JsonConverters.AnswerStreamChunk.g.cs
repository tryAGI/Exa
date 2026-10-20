#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class AnswerStreamChunkJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.AnswerStreamChunk>
    {
        /// <inheritdoc />
        public override global::Exa.AnswerStreamChunk Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("citations")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("costDollars")) __score2++;
            if (__jsonProps.Contains("costDollars.contents")) __score2++;
            if (__jsonProps.Contains("costDollars.search")) __score2++;
            if (__jsonProps.Contains("costDollars.summary")) __score2++;
            if (__jsonProps.Contains("costDollars.total")) __score2++;
            if (__jsonProps.Contains("requestId")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("payload")) __score3++;
            if (__jsonProps.Contains("payload.error")) __score3++;
            if (__jsonProps.Contains("payload.requestId")) __score3++;
            if (__jsonProps.Contains("tag")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Exa.AnswerStreamTextDeltaChunk? textDelta = default;
            global::Exa.AnswerStreamCitationsChunkOutput? citationsOutput = default;
            global::Exa.AnswerStreamCostChunkOutput? costOutput = default;
            global::Exa.AnswerStreamErrorChunkOutput? errorOutput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamTextDeltaChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamTextDeltaChunk> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamTextDeltaChunk).Name}");
                        textDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamCitationsChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamCitationsChunkOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamCitationsChunkOutput).Name}");
                        citationsOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamCostChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamCostChunkOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamCostChunkOutput).Name}");
                        costOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamErrorChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamErrorChunkOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamErrorChunkOutput).Name}");
                        errorOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (textDelta == null && citationsOutput == null && costOutput == null && errorOutput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamTextDeltaChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamTextDeltaChunk> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamTextDeltaChunk).Name}");
                    textDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (textDelta == null && citationsOutput == null && costOutput == null && errorOutput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamCitationsChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamCitationsChunkOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamCitationsChunkOutput).Name}");
                    citationsOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (textDelta == null && citationsOutput == null && costOutput == null && errorOutput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamCostChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamCostChunkOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamCostChunkOutput).Name}");
                    costOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (textDelta == null && citationsOutput == null && costOutput == null && errorOutput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamErrorChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamErrorChunkOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamErrorChunkOutput).Name}");
                    errorOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Exa.AnswerStreamChunk(
                textDelta,

                citationsOutput,

                costOutput,

                errorOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.AnswerStreamChunk value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamTextDeltaChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamTextDeltaChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamTextDeltaChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextDelta(), typeInfo);
            }
            else if (value.IsCitationsOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamCitationsChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamCitationsChunkOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamCitationsChunkOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCitationsOutput(), typeInfo);
            }
            else if (value.IsCostOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamCostChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamCostChunkOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamCostChunkOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCostOutput(), typeInfo);
            }
            else if (value.IsErrorOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamErrorChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamErrorChunkOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamErrorChunkOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickErrorOutput(), typeInfo);
            }
        }
    }
}