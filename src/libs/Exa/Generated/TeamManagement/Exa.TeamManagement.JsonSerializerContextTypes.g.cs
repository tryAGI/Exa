
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.CreateApiKeyRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.UpdateApiKeyRequest? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RotateApiKeyRequest? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyUsageGroupBy? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.CreateApiKeyResponse? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.CreateApiKeyResponseApiKey? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.CreateApiKeyResponse2? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.CreateApiKeyResponse3? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.OneOf<global::Exa.TeamManagement.ListApiKeysResponseVariant1, global::Exa.TeamManagement.ListApiKeysResponseVariant2>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.ListApiKeysResponseVariant1? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.TeamManagement.ListApiKeysResponseVariant1ApiKey>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.ListApiKeysResponseVariant1ApiKey? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.ListApiKeysResponseVariant2? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.ListApiKeysResponseVariant2ApiKey? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.ListApiKeysResponse2? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.ListApiKeysResponse3? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.ListApiKeysResponse4? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.ListApiKeysResponse5? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyResponse? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyResponseApiKey? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyResponse2? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyResponse3? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyResponse4? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.UpdateApiKeyResponse? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.UpdateApiKeyResponseApiKey? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.UpdateApiKeyResponse2? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.UpdateApiKeyResponse3? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.UpdateApiKeyResponse4? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.UpdateApiKeyResponse5? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.DeleteApiKeyResponse? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.DeleteApiKeyResponse2? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.DeleteApiKeyResponse3? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.DeleteApiKeyResponse4? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.DeleteApiKeyResponse5? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RotateApiKeyResponse? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RotateApiKeyResponseApiKey? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RotateApiKeyResponse2? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RotateApiKeyResponse3? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RotateApiKeyResponse4? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RotateApiKeyResponse5? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RotateApiKeyResponse6? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RotateApiKeyResponseCode? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RevokePreviousApiKeySecretResponse? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RevokePreviousApiKeySecretResponseApiKey? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RevokePreviousApiKeySecretResponse2? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RevokePreviousApiKeySecretResponse3? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.RevokePreviousApiKeySecretResponse4? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyUsageResponse? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyUsageResponsePeriod? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.TeamManagement.GetApiKeyUsageResponseCostBreakdownItem>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyUsageResponseCostBreakdownItem? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyUsageResponseMetadata? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyUsageResponse2? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyUsageResponse3? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyUsageResponse4? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetApiKeyUsageResponse5? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetTeamCreditsResponse? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Exa.TeamManagement.GetTeamCreditsResponseExpiringCredit>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetTeamCreditsResponseExpiringCredit? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetTeamCreditsResponseMetadata? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetTeamCreditsResponse2? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetTeamCreditsResponse3? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetTeamCreditsResponse4? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Exa.TeamManagement.GetTeamCreditsResponse5? Type70 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.TeamManagement.ListApiKeysResponseVariant1ApiKey>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.TeamManagement.GetApiKeyUsageResponseCostBreakdownItem>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Exa.TeamManagement.GetTeamCreditsResponseExpiringCredit>? ListType2 { get; set; }
    }
}