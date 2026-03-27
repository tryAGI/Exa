#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/exa-labs/openapi-spec/refs/heads/master/exa-openapi-spec.yaml

# Fix auth: convert apiKey → http/bearer for AutoSDK constructor generation
yq -i '
  del(.components.securitySchemes) |
  .components.securitySchemes.BearerAuth = {"type": "http", "scheme": "bearer"} |
  del(.security) |
  .security = [{"BearerAuth": []}]
' openapi.yaml

autosdk generate openapi.yaml \
  --namespace Exa \
  --clientClassName ExaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
