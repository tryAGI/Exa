# CLAUDE.md — Exa SDK

## Overview

Auto-generated C# SDK for [Exa](https://exa.ai/) — AI-powered web search, contents retrieval, find-similar, answer, and research endpoints.
OpenAPI spec from the official [exa-labs/openapi-spec](https://github.com/exa-labs/openapi-spec) repo.

## Build & Test

```bash
dotnet build Exa.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new ExaClient(apiKey); // EXA_API_KEY env var
```

## Key Files

- `src/libs/Exa/openapi.yaml` — OpenAPI spec (downloaded from exa-labs/openapi-spec)
- `src/libs/Exa/generate.sh` — Downloads spec, runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/Exa/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)
