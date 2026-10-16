
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.JsonValue), TypeInfoPropertyName = "JsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.JsonValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListSearchMonitorRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunStatus), TypeInfoPropertyName = "SearchMonitorRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunFailReason), TypeInfoPropertyName = "SearchMonitorRunFailReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence), TypeInfoPropertyName = "SearchMonitorRunOutputGroundingVariant1ItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.JsonValue?), TypeInfoPropertyName = "NullableJsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunStatus?), TypeInfoPropertyName = "NullableSearchMonitorRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunFailReason?), TypeInfoPropertyName = "NullableSearchMonitorRunFailReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence?), TypeInfoPropertyName = "NullableSearchMonitorRunOutputGroundingVariant1ItemConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.JsonValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation>))]
    internal sealed partial class RunsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RunsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RunsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Exa.JsonConverters.JsonValueJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Exa.SearchMonitorRunStatus)

                    || typeToConvert == typeof(global::Exa.SearchMonitorRunStatus?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorRunFailReason)

                    || typeToConvert == typeof(global::Exa.SearchMonitorRunFailReason?)

                    || typeToConvert == typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence)

                    || typeToConvert == typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Exa.SearchMonitorRunStatus))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorRunStatus?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorRunFailReason))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunFailReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorRunFailReason?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunFailReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence?))
                {
                    return new global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new RunsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}