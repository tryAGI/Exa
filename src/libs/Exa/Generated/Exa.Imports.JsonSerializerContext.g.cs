
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Entity), TypeInfoPropertyName = "Entity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CompanyEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PersonEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ArticleEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ResearchPaperEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CustomEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParameters), TypeInfoPropertyName = "CreateImportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1Format), TypeInfoPropertyName = "CreateImportParametersVariant1Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1Csv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersDiscriminatorFormat), TypeInfoPropertyName = "CreateImportParametersDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.UpdateImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.Import>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Import))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportObject), TypeInfoPropertyName = "ImportObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportStatus), TypeInfoPropertyName = "ImportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFormat), TypeInfoPropertyName = "ImportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFailedReason), TypeInfoPropertyName = "ImportFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseObject), TypeInfoPropertyName = "CreateImportResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseStatus), TypeInfoPropertyName = "CreateImportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFormat), TypeInfoPropertyName = "CreateImportResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFailedReason), TypeInfoPropertyName = "CreateImportResponseFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ListImportsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Entity?), TypeInfoPropertyName = "NullableEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParameters?), TypeInfoPropertyName = "NullableCreateImportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersVariant1Format?), TypeInfoPropertyName = "NullableCreateImportParametersVariant1Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportParametersDiscriminatorFormat?), TypeInfoPropertyName = "NullableCreateImportParametersDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportObject?), TypeInfoPropertyName = "NullableImportObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportStatus?), TypeInfoPropertyName = "NullableImportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFormat?), TypeInfoPropertyName = "NullableImportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.ImportFailedReason?), TypeInfoPropertyName = "NullableImportFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseObject?), TypeInfoPropertyName = "NullableCreateImportResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseStatus?), TypeInfoPropertyName = "NullableCreateImportResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFormat?), TypeInfoPropertyName = "NullableCreateImportResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.CreateImportResponseFailedReason?), TypeInfoPropertyName = "NullableCreateImportResponseFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.Import>))]
    internal sealed partial class ImportsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImportsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImportsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImportsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Exa.JsonConverters.EntityJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.CreateImportParametersJsonConverter());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>());
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
                    typeToConvert == typeof(global::Exa.CreateImportParametersVariant1Format)

                    || typeToConvert == typeof(global::Exa.CreateImportParametersVariant1Format?)

                    || typeToConvert == typeof(global::Exa.CreateImportParametersDiscriminatorFormat)

                    || typeToConvert == typeof(global::Exa.CreateImportParametersDiscriminatorFormat?)

                    || typeToConvert == typeof(global::Exa.ImportObject)

                    || typeToConvert == typeof(global::Exa.ImportObject?)

                    || typeToConvert == typeof(global::Exa.ImportStatus)

                    || typeToConvert == typeof(global::Exa.ImportStatus?)

                    || typeToConvert == typeof(global::Exa.ImportFormat)

                    || typeToConvert == typeof(global::Exa.ImportFormat?)

                    || typeToConvert == typeof(global::Exa.ImportFailedReason)

                    || typeToConvert == typeof(global::Exa.ImportFailedReason?)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseObject)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseObject?)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseStatus)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseStatus?)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseFormat)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseFormat?)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseFailedReason)

                    || typeToConvert == typeof(global::Exa.CreateImportResponseFailedReason?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Exa.CreateImportParametersVariant1Format))
                {
                    return new global::Exa.JsonConverters.CreateImportParametersVariant1FormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportParametersVariant1Format?))
                {
                    return new global::Exa.JsonConverters.CreateImportParametersVariant1FormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportParametersDiscriminatorFormat))
                {
                    return new global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportParametersDiscriminatorFormat?))
                {
                    return new global::Exa.JsonConverters.CreateImportParametersDiscriminatorFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportObject))
                {
                    return new global::Exa.JsonConverters.ImportObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportObject?))
                {
                    return new global::Exa.JsonConverters.ImportObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportStatus))
                {
                    return new global::Exa.JsonConverters.ImportStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportStatus?))
                {
                    return new global::Exa.JsonConverters.ImportStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportFormat))
                {
                    return new global::Exa.JsonConverters.ImportFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportFormat?))
                {
                    return new global::Exa.JsonConverters.ImportFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportFailedReason))
                {
                    return new global::Exa.JsonConverters.ImportFailedReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.ImportFailedReason?))
                {
                    return new global::Exa.JsonConverters.ImportFailedReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseObject))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseObject?))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseStatus))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseStatus?))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseFormat))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseFormat?))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseFailedReason))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseFailedReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.CreateImportResponseFailedReason?))
                {
                    return new global::Exa.JsonConverters.CreateImportResponseFailedReasonNullableJsonConverter();
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
                    0 => new ImportsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}