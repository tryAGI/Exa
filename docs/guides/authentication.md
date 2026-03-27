# Authentication

The Exa SDK uses Bearer token authentication. You can obtain an API key from your [Exa dashboard](https://dashboard.exa.ai/).

## Basic Usage

```csharp
using Exa;

var client = new ExaClient(apiKey: Environment.GetEnvironmentVariable("EXA_API_KEY")!);
```

## Environment Variable

| Variable | Description |
|----------|-------------|
| `EXA_API_KEY` | Your Exa API key |
