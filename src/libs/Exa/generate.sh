#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o openapi.yaml https://raw.githubusercontent.com/exa-labs/openapi-spec/refs/heads/master/exa-openapi-spec.yaml

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace Exa \
  --clientClassName ExaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
