
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>), TypeInfoPropertyName = "WebsetItemCustomProperties_976e7369ebb8440c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>?), TypeInfoPropertyName = "WebsetItemCustomProperties_2a7882e053a7bb38")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetParametersSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemArticleProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemResearchPaperProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCustomProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPerson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonCompany))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemDates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemCompany))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemDates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompany))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyHeadquarters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyFinancials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCompanyPropertiesCompanyWebTraffic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemArticlePropertiesArticle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemResearchPaperPropertiesResearchPaper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemCustomPropertiesCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>), TypeInfoPropertyName = "OneOfCompanyEntityPersonEntityArticleEntityResearchPaperEntityCustomEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseSearchCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseSearchCriteriaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat), TypeInfoPropertyName = "PreviewWebsetResponseEnrichmentFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichmentOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichmentOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.WebsetItemPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.WebsetItemPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.Entity?), TypeInfoPropertyName = "NullableEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>?), TypeInfoPropertyName = "NullableOneOfCompanyEntityPersonEntityArticleEntityResearchPaperEntityCustomEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat?), TypeInfoPropertyName = "NullablePreviewWebsetResponseEnrichmentFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseSearchCriteriaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseEnrichment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.PreviewWebsetResponseEnrichmentOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.WebsetItemPreview>))]
    internal sealed partial class WebsetsPreviewSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebsetsPreviewSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WebsetsPreviewSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WebsetsPreviewSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>());
            options.Converters.Add(new global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>());
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
                    typeToConvert == typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat)

                    || typeToConvert == typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat))
                {
                    return new global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Exa.PreviewWebsetResponseEnrichmentFormat?))
                {
                    return new global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatNullableJsonConverter();
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
                    0 => new WebsetsPreviewSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}