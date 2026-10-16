# CLAUDE.md — Exa SDK

## Overview

Auto-generated C# SDK for [Exa](https://exa.ai/) — Search, Contents, Answer, Agent, Monitors, Batch, Websets, and Team Management APIs.
OpenAPI specs from the official [Exa documentation deployment](https://exa.ai/docs/admin/openapi-spec).

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

- `src/libs/Exa/openapi.yaml` — current Public API v2 spec (downloaded from exa.ai/docs/exa-spec.yaml)
- `src/libs/Exa/generate.sh` — downloads both official specs; generates public clients with `--security-scheme Http:Header:Bearer`
- `src/libs/Exa/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

- `src/libs/Exa/team-management-openapi.yaml` — Team Management spec; generated separately under `Exa.TeamManagement` using service-key `x-api-key` auth and the admin host.
- `src/tests/IntegrationTests/Tests.ApiCoverage.cs` — no-cost HTTP contract tests for API routing, authentication, and search tool serialization.
