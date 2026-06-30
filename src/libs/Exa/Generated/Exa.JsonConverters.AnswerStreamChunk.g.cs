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
            if (__jsonProps.Contains("costDollars.search")) __score2++;
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

            global::Exa.AnswerStreamChunkVariant1? answerStreamChunkVariant1 = default;
            global::Exa.AnswerStreamChunkVariant2? answerStreamChunkVariant2 = default;
            global::Exa.AnswerStreamChunkVariant3? answerStreamChunkVariant3 = default;
            global::Exa.AnswerStreamChunkVariant4? answerStreamChunkVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant1).Name}");
                        answerStreamChunkVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant2).Name}");
                        answerStreamChunkVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant3).Name}");
                        answerStreamChunkVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant4).Name}");
                        answerStreamChunkVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (answerStreamChunkVariant1 == null && answerStreamChunkVariant2 == null && answerStreamChunkVariant3 == null && answerStreamChunkVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant1).Name}");
                    answerStreamChunkVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (answerStreamChunkVariant1 == null && answerStreamChunkVariant2 == null && answerStreamChunkVariant3 == null && answerStreamChunkVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant2).Name}");
                    answerStreamChunkVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (answerStreamChunkVariant1 == null && answerStreamChunkVariant2 == null && answerStreamChunkVariant3 == null && answerStreamChunkVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant3).Name}");
                    answerStreamChunkVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (answerStreamChunkVariant1 == null && answerStreamChunkVariant2 == null && answerStreamChunkVariant3 == null && answerStreamChunkVariant4 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant4).Name}");
                    answerStreamChunkVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Exa.AnswerStreamChunk(
                answerStreamChunkVariant1,

                answerStreamChunkVariant2,

                answerStreamChunkVariant3,

                answerStreamChunkVariant4
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

            if (value.IsAnswerStreamChunkVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnswerStreamChunkVariant1!, typeInfo);
            }
            else if (value.IsAnswerStreamChunkVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnswerStreamChunkVariant2!, typeInfo);
            }
            else if (value.IsAnswerStreamChunkVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnswerStreamChunkVariant3!, typeInfo);
            }
            else if (value.IsAnswerStreamChunkVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.AnswerStreamChunkVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.AnswerStreamChunkVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.AnswerStreamChunkVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnswerStreamChunkVariant4!, typeInfo);
            }
        }
    }
}