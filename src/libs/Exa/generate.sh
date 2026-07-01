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

normalize_spec() {
  ruby -ryaml -rdate -e '
    path = "openapi.yaml"
    spec =
      begin
        YAML.load_file(path, permitted_classes: [Time, Date])
      rescue ArgumentError
        YAML.load_file(path)
      end
    schemas = spec.fetch("components").fetch("schemas")

    # ContentsRequest is an allOf composition of URL/ID selectors and ContentsOptions.
    # Flatten it before generation so the generated request model matches the wire JSON
    # object directly and avoids a converter variable-name collision on "options".
    contents_request = schemas.fetch("ContentsRequest")
    contents_options = schemas.fetch("ContentsOptions")
    selector = contents_request.fetch("allOf").first
    contents_request.delete("allOf")
    contents_request["type"] = "object"
    contents_request["description"] = selector["description"]
    contents_request["properties"] = selector.fetch("properties").merge(contents_options.fetch("properties"))
    contents_request["oneOf"] = selector["oneOf"]

    File.write(path, YAML.dump(spec))
  '
}

# OpenAPI spec: https://exa.ai/docs/exa-spec.yaml
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.yaml https://exa.ai/docs/exa-spec.yaml
normalize_spec

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
