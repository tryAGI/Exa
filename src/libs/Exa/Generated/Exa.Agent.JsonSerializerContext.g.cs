
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentEffort), TypeInfoPropertyName = "AgentEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentDataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentBudget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSourceProvider), TypeInfoPropertyName = "AgentDataSourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunStatus), TypeInfoPropertyName = "AgentRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentStopReason), TypeInfoPropertyName = "AgentStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentCostDollars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentDataSourceOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSourceOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentBudgetOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentGrounding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentGrounding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentGroundingConfidence), TypeInfoPropertyName = "AgentGroundingConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorType), TypeInfoPropertyName = "AgentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorCode), TypeInfoPropertyName = "AgentErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.DeleteAgentRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunEventList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.AgentRunEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunEventEvent), TypeInfoPropertyName = "AgentRunEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunAccept), TypeInfoPropertyName = "CreateAgentRunAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListAgentRunEventsAccept), TypeInfoPropertyName = "ListAgentRunEventsAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.JsonValue?), TypeInfoPropertyName = "NullableJsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentEffort?), TypeInfoPropertyName = "NullableAgentEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentDataSourceProvider?), TypeInfoPropertyName = "NullableAgentDataSourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunStatus?), TypeInfoPropertyName = "NullableAgentRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentStopReason?), TypeInfoPropertyName = "NullableAgentStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentGroundingConfidence?), TypeInfoPropertyName = "NullableAgentGroundingConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorType?), TypeInfoPropertyName = "NullableAgentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentErrorCode?), TypeInfoPropertyName = "NullableAgentErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.AgentRunEventEvent?), TypeInfoPropertyName = "NullableAgentRunEventEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateAgentRunAccept?), TypeInfoPropertyName = "NullableCreateAgentRunAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListAgentRunEventsAccept?), TypeInfoPropertyName = "NullableListAgentRunEventsAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.JsonValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentDataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentDataSourceOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentGrounding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.AgentRunEvent>))]
    internal sealed partial class AgentSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Exa.AgentEffort)

                    || typeToConvert == typeof(global::Exa.AgentEffort?)

                    || typeToConvert == typeof(global::Exa.AgentDataSourceProvider)

                    || typeToConvert == typeof(global::Exa.AgentDataSourceProvider?)

                    || typeToConvert == typeof(global::Exa.AgentRunStatus)

                    || typeToConvert == typeof(global::Exa.AgentRunStatus?)

                    || typeToConvert == typeof(global::Exa.AgentStopReason)

                    || typeToConvert == typeof(global::Exa.AgentStopReason?)

                    || typeToConvert == typeof(global::Exa.AgentGroundingConfidence)

                    || typeToConvert == typeof(global::Exa.AgentGroundingConfidence?)

                    || typeToConvert == typeof(global::Exa.AgentErrorType)

                    || typeToConvert == typeof(global::Exa.AgentErrorType?)

                    || typeToConvert == typeof(global::Exa.AgentErrorCode)

                    || typeToConvert == typeof(global::Exa.AgentErrorCode?)

                    || typeToConvert == typeof(global::Exa.AgentRunEventEvent)

                    || typeToConvert == typeof(global::Exa.AgentRunEventEvent?)

                    || typeToConvert == typeof(global::Exa.CreateAgentRunAccept)

                    || typeToConvert == typeof(global::Exa.CreateAgentRunAccept?)

                    || typeToConvert == typeof(global::Exa.ListAgentRunEventsAccept)

                    || typeToConvert == typeof(global::Exa.ListAgentRunEventsAccept?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Exa.AgentEffort))
                {
                    return new global::Exa.JsonConverters.AgentEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentEffort?))
                {
                    return new global::Exa.JsonConverters.AgentEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentDataSourceProvider))
                {
                    return new global::Exa.JsonConverters.AgentDataSourceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentDataSourceProvider?))
                {
                    return new global::Exa.JsonConverters.AgentDataSourceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentRunStatus))
                {
                    return new global::Exa.JsonConverters.AgentRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentRunStatus?))
                {
                    return new global::Exa.JsonConverters.AgentRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentStopReason))
                {
                    return new global::Exa.JsonConverters.AgentStopReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentStopReason?))
                {
                    return new global::Exa.JsonConverters.AgentStopReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentGroundingConfidence))
                {
                    return new global::Exa.JsonConverters.AgentGroundingConfidenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentGroundingConfidence?))
                {
                    return new global::Exa.JsonConverters.AgentGroundingConfidenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentErrorType))
                {
                    return new global::Exa.JsonConverters.AgentErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentErrorType?))
                {
                    return new global::Exa.JsonConverters.AgentErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentErrorCode))
                {
                    return new global::Exa.JsonConverters.AgentErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentErrorCode?))
                {
                    return new global::Exa.JsonConverters.AgentErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentRunEventEvent))
                {
                    return new global::Exa.JsonConverters.AgentRunEventEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.AgentRunEventEvent?))
                {
                    return new global::Exa.JsonConverters.AgentRunEventEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateAgentRunAccept))
                {
                    return new global::Exa.JsonConverters.CreateAgentRunAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateAgentRunAccept?))
                {
                    return new global::Exa.JsonConverters.CreateAgentRunAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ListAgentRunEventsAccept))
                {
                    return new global::Exa.JsonConverters.ListAgentRunEventsAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ListAgentRunEventsAccept?))
                {
                    return new global::Exa.JsonConverters.ListAgentRunEventsAcceptNullableJsonConverter();
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
                    0 => new AgentSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}