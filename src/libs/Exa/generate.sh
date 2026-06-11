#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/exa-labs/openapi-spec/refs/heads/master/exa-openapi-spec.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/exa-labs/openapi-spec/refs/heads/master/exa-openapi-spec.yaml

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace Exa \
  --clientClassName ExaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
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
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
