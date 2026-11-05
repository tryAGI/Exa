
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Exa.TeamManagement.JsonConverters.GetApiKeyUsageGroupByJsonConverter),

            typeof(global::Exa.TeamManagement.JsonConverters.GetApiKeyUsageGroupByNullableJsonConverter),

            typeof(global::Exa.TeamManagement.JsonConverters.RotateApiKeyResponseCodeJsonConverter),

            typeof(global::Exa.TeamManagement.JsonConverters.RotateApiKeyResponseCodeNullableJsonConverter),

            typeof(global::Exa.TeamManagement.JsonConverters.OneOfJsonConverter<global::Exa.TeamManagement.ListApiKeysResponseVariant1, global::Exa.TeamManagement.ListApiKeysResponseVariant2>),

            typeof(global::Exa.TeamManagement.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.CreateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.UpdateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RotateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyUsageGroupBy), TypeInfoPropertyName = "GetApiKeyUsageGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.CreateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.CreateApiKeyResponseApiKey))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.CreateApiKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.CreateApiKeyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.OneOf<global::Exa.TeamManagement.ListApiKeysResponseVariant1, global::Exa.TeamManagement.ListApiKeysResponseVariant2>), TypeInfoPropertyName = "OneOfListApiKeysResponseVariant1ListApiKeysResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.ListApiKeysResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.TeamManagement.ListApiKeysResponseVariant1ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.ListApiKeysResponseVariant1ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.ListApiKeysResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.ListApiKeysResponseVariant2ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.ListApiKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.ListApiKeysResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.ListApiKeysResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.ListApiKeysResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyResponseApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.UpdateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.UpdateApiKeyResponseApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.UpdateApiKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.UpdateApiKeyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.UpdateApiKeyResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.UpdateApiKeyResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.DeleteApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.DeleteApiKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.DeleteApiKeyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.DeleteApiKeyResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.DeleteApiKeyResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RotateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RotateApiKeyResponseApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RotateApiKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RotateApiKeyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RotateApiKeyResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RotateApiKeyResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RotateApiKeyResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RotateApiKeyResponseCode), TypeInfoPropertyName = "RotateApiKeyResponseCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RevokePreviousApiKeySecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RevokePreviousApiKeySecretResponseApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RevokePreviousApiKeySecretResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RevokePreviousApiKeySecretResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.RevokePreviousApiKeySecretResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyUsageResponsePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.TeamManagement.GetApiKeyUsageResponseCostBreakdownItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyUsageResponseCostBreakdownItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyUsageResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyUsageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyUsageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyUsageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetApiKeyUsageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetTeamCreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Exa.TeamManagement.GetTeamCreditsResponseExpiringCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetTeamCreditsResponseExpiringCredit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetTeamCreditsResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetTeamCreditsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetTeamCreditsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetTeamCreditsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Exa.TeamManagement.GetTeamCreditsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.TeamManagement.ListApiKeysResponseVariant1ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.TeamManagement.GetApiKeyUsageResponseCostBreakdownItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Exa.TeamManagement.GetTeamCreditsResponseExpiringCredit>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}