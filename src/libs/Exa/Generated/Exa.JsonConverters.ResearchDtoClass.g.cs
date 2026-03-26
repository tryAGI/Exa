#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public class ResearchDtoClassJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ResearchDtoClass>
    {
        /// <inheritdoc />
        public override global::Exa.ResearchDtoClass Read(
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
            if (__jsonProps.Contains("instructions")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("researchId")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("createdAt")) __score1++;
            if (__jsonProps.Contains("events")) __score1++;
            if (__jsonProps.Contains("instructions")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("researchId")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("costDollars")) __score2++;
            if (__jsonProps.Contains("createdAt")) __score2++;
            if (__jsonProps.Contains("events")) __score2++;
            if (__jsonProps.Contains("instructions")) __score2++;
            if (__jsonProps.Contains("model")) __score2++;
            if (__jsonProps.Contains("output")) __score2++;
            if (__jsonProps.Contains("researchId")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("createdAt")) __score3++;
            if (__jsonProps.Contains("events")) __score3++;
            if (__jsonProps.Contains("instructions")) __score3++;
            if (__jsonProps.Contains("model")) __score3++;
            if (__jsonProps.Contains("researchId")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("createdAt")) __score4++;
            if (__jsonProps.Contains("error")) __score4++;
            if (__jsonProps.Contains("events")) __score4++;
            if (__jsonProps.Contains("instructions")) __score4++;
            if (__jsonProps.Contains("model")) __score4++;
            if (__jsonProps.Contains("researchId")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Exa.ResearchDtoClassVariant1? pending = default;
            global::Exa.ResearchDtoClassVariant2? running = default;
            global::Exa.ResearchDtoClassVariant3? completed = default;
            global::Exa.ResearchDtoClassVariant4? canceled = default;
            global::Exa.ResearchDtoClassVariant5? failed = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant1).Name}");
                        pending = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant2).Name}");
                        running = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant3).Name}");
                        completed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant4).Name}");
                        canceled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant5).Name}");
                        failed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pending == null && running == null && completed == null && canceled == null && failed == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant1).Name}");
                    pending = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant2).Name}");
                    running = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant3).Name}");
                    completed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant4).Name}");
                    canceled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant5).Name}");
                    failed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Exa.ResearchDtoClass(
                pending,

                running,

                completed,

                canceled,

                failed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ResearchDtoClass value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pending, typeInfo);
            }
            else if (value.IsRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Running, typeInfo);
            }
            else if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completed, typeInfo);
            }
            else if (value.IsCanceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Canceled, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Exa.ResearchDtoClassVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Exa.ResearchDtoClassVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Exa.ResearchDtoClassVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed, typeInfo);
            }
        }
    }
}