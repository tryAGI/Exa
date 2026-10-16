
#nullable enable

namespace Exa.TeamManagement
{
    public sealed partial class ExaTeamManagementClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "x-api-key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Exa.TeamManagement.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyXApiKey",
                Location = "Header",
                Name = "x-api-key",
                Value = apiKey,
            });
        }
    }
}