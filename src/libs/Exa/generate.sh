#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# Official specs: https://exa.ai/docs/admin/openapi-spec
if [[ "${EXA_SKIP_TOOL_UPDATE:-0}" != "1" ]]; then
  install_autosdk_cli
fi
fetch_spec --fail --silent --show-error -L -o openapi.yaml \
  https://exa.ai/docs/exa-spec.yaml
fetch_spec -o team-management-openapi.yaml \
  https://exa.ai/docs/team-management-spec.yaml

# Download both specs successfully before replacing generated output.
rm -rf Generated

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace Exa \
  --clientClassName ExaClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer

# Team management uses a separate host and service key, so expose a separate client.
autosdk generate team-management-openapi.yaml \
  --namespace Exa.TeamManagement \
  --clientClassName ExaTeamManagementClient \
  --targetFramework net10.0 \
  --output Generated/TeamManagement \
  --security-scheme ApiKey:Header:x-api-key

rm -rf ../../cli/Exa.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Exa.CLI \
  --sdk-project ../../libs/Exa/Exa.csproj \
  --targetFramework net10.0 \
  --namespace Exa \
  --clientClassName ExaClient \
  --package-id Exa.CLI \
  --tool-command-name exa \
  --user-secrets-id Exa.CLI \
  --api-key-env-var EXA_API_KEY \
  --base-url-env-var EXA_BASE_URL \
  --cli-credential-file \
  --security-scheme Http:Header:Bearer
