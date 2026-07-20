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

# OpenAPI spec: https://github.com/exa-labs/openapi-spec
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.yaml \
  https://raw.githubusercontent.com/exa-labs/openapi-spec/master/exa-openapi-spec.yaml

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace Exa \
  --clientClassName ExaClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer

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
