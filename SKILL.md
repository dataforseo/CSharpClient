---
name: dataforseo-csharp-client
description: Use the DataForSEO C# client (NuGet package DataForSeo.Client) to call DataForSEO API v3 (SERP, Keywords Data, DataForSEO Labs, Backlinks, OnPage, AI Optimization, etc.). Read this before exploring the code; it explains the layout, naming rules and how to find an endpoint without reading the huge generated files.
---

# DataForSEO C# client

Generated, strongly typed .NET client for DataForSEO API v3.
Every API endpoint is one async method; every request/response body is one DTO class.

- Package: `dotnet add package DataForSeo.Client`
- Targets: `netstandard2.0`, `netstandard2.1`; JSON: `Newtonsoft.Json`
- Root namespace: `DataForSeo.Client`
- Base URL: `https://api.dataforseo.com` (sandbox with free dummy data: `https://sandbox.dataforseo.com`)
- Auth: HTTP Basic with the DataForSEO API login and password (not the dashboard password)

## Do not read generated code in full

The client is generated from an OpenAPI spec and is very large (thousands of DTO classes, `Api/*.cs` files of several hundred KB). Never open files whole. Derive names with the rules below and use targeted search (grep) only to confirm them.

## Layout

Source code (git repository):

```
DataForSeoClient.cs                 entry point: DataForSeoClient + DataForSeoClientConfiguration
Api/<Section>Api.cs                 one class per API section, one method per endpoint
Models/                             shared/nested DTOs, polymorphic items, ApiException
Models/Requests/*RequestInfo.cs     request bodies
Models/Responses/*ResponseInfo.cs   top-level responses
```

NuGet package (`~/.nuget/packages/dataforseo.client/<version>/`): `README.md`, `SKILL.md`, `lib/<tfm>/DataForSeo.Client.dll` and `lib/<tfm>/DataForSeo.Client.xml`. The package has no source code; the XML documentation file contains the description of every DTO property.

Sections (properties of `DataForSeoClient`, the `Api/` folder is the source of truth): `SerpApi`, `KeywordsDataApi`, `DataforseoLabsApi`, `DomainAnalyticsApi`, `BacklinksApi`, `OnPageApi`, `ContentAnalysisApi`, `AiOptimizationApi`, `MerchantApi`, `AppDataApi`, `BusinessDataApi`, `AppendixApi`.

## Naming rules (derive names instead of searching)

Endpoint path `/v3/<section>/<rest>` maps to:

| What | Rule | Example for `/v3/serp/google/organic/live/advanced` |
|---|---|---|
| API class | `<Section>Api` | `SerpApi` (`dfsClient.SerpApi`) |
| Method | PascalCase of `<rest>` + `Async` (usually) | `GoogleOrganicLiveAdvancedAsync` |
| Request DTO | `<Section><Rest>RequestInfo` | `SerpGoogleOrganicLiveAdvancedRequestInfo` |
| Response DTO | `<Section><Rest>ResponseInfo` | `SerpGoogleOrganicLiveAdvancedResponseInfo` |
| Task item | `<Section><Rest>TaskInfo` | `SerpGoogleOrganicLiveAdvancedTaskInfo` |
| Result item | `<Section><Rest>ResultInfo` | `SerpGoogleOrganicLiveAdvancedResultInfo` |

DTO names follow the rule strictly. Method names sometimes keep the section prefix (e.g. `DataforseoLabsIdListAsync`), so confirm the method by its response DTO (source code), or rely on IDE completion / the compiler when only the package is available:

```bash
grep -n "Task<SerpGoogleOrganicLiveAdvancedResponseInfo>" Api/SerpApi.cs   # -> method signature
```

DTO fields and their descriptions (required/optional, allowed values, limits) are XML doc comments on the properties. In the source read only the needed properties of `Models/**/<ClassName>.cs`; with the package search the XML documentation file:

```bash
grep -n -A 2 "P:DataForSeo.Client.Models.Requests.SerpGoogleOrganicLiveAdvancedRequestInfo\." DataForSeo.Client.xml
```

## Method shapes

- `POST` endpoints: `Task<XResponseInfo> XAsync(IEnumerable<XRequestInfo> payload)`, the body is always an array of tasks.
- `GET` endpoints: `Task<XResponseInfo> XAsync()` or `XAsync(string id)` (task id for `TaskGet*`, `country` for locations etc.).

## Setup

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;

var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration
{
    Username = "API_LOGIN",
    Password = "API_PASSWORD",
    // CustomHeaders = new Dictionary<string, string> { ["X-Header"] = "value" },
});

// optional: use sandbox for a specific section
// dfsClient.SerpApi.BaseUrl = "https://sandbox.dataforseo.com";
```

`DataForSeoClient` owns one `HttpClient` (gzip, 1 min timeout). Create it once and reuse it.

## Live request (result in the same call)

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models.Requests;

var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",    
});
var result = await dfsClient.SerpApi.GoogleOrganicLiveAdvancedAsync(new List<SerpGoogleOrganicLiveAdvancedRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "albert einstein",
        CalculateRectangles = true,
    }
});
```

## Task-based request (post -> wait -> get)

```csharp
using System.Diagnostics;
using DataForSeo.Client;
using DataForSeo.Client.Models.Requests;

var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",    
});
var result = await dfsClient.SerpApi.GoogleOrganicTaskPostAsync(new List<SerpGoogleOrganicTaskPostRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "albert einstein",
        Priority = 2,
    }
});

var sw = Stopwatch.StartNew();

var id = result.Tasks.First().Id;
while (!await GoogleOrganicTaskReady(id) && sw.Elapsed < TimeSpan.FromMinutes(1))
    await Task.Delay(1_000);

var taskGetResult = await dfsClient.SerpApi.GoogleOrganicTaskGetAdvancedAsync(id);

async Task<bool> GoogleOrganicTaskReady(string id)
{
    var result = await  dfsClient.SerpApi.GoogleOrganicTasksReadyAsync();
    return result.Tasks?.Any(x => x.Result?.Any(xx => xx.Id == id) ?? false) ?? false;
}
```

Instead of polling you can set `PostbackUrl` / `PingbackUrl` in the task request.

## Response envelope (same for every endpoint)

```
XResponseInfo : BaseResponseInfo
  Version, StatusCode, StatusMessage, Time, Cost, TasksCount, TasksError
  Tasks: IEnumerable<XTaskInfo>
    XTaskInfo : BaseResponseTaskInfo
      Id, StatusCode, StatusMessage, Time, Cost, ResultCount, Path, Data (echo of the request)
      Result: IEnumerable<XResultInfo>   // endpoint specific payload, often with Items
```

- `StatusCode == 20000` means OK (both top-level and per task); `20100` = task created; `4xxxx`/`5xxxx` = errors. Always check the per-task `StatusCode`: the HTTP status is usually 200 even when a task failed.
- Unknown JSON fields go to `AdditionalProperties` on every DTO.
- All properties are nullable; null-check collections (`Tasks`, `Result`, `Items`).

## Polymorphic items

Lists like `Items` are typed as a base class (e.g. `BaseSerpApiElementItem`) and deserialized into concrete subclasses by the JSON `type` field (`organic` -> `OrganicSerpElementItem`, `paid` -> `PaidSerpElementItem`, `featured_snippet` -> `FeaturedSnippetSerpElementItem`, ...). Use `OfType<T>()` / `is T`. The mapping is declared with `[JsonInheritance("<type>", typeof(...))]` attributes at the top of the base class file; grep there instead of reading it.

## Errors

Non-200 HTTP responses and deserialization failures throw `DataForSeo.Client.Models.ApiException` with `StatusCode`, `Response` (raw body) and `Headers`.

## Useful facts

- Location / language codes: `LocationCode = 2840` (United States), `LanguageCode = "en"`. Full lists come from endpoints like `SerpApi.GoogleLocationsAsync()` / `GoogleLanguagesAsync()` (and similar per section).
- Most Live endpoints accept one task per request; Task POST endpoints accept many tasks (up to 100) in one call.
- `TaskGet*` has several variants (`Regular`, `Advanced`, `Html`); use the one matching the data you need.
- Field semantics, allowed values and limits: XML doc comments of the request DTO properties (they come from the official API docs).

## External documentation (last resort)

Use https://dataforseo.com/llms.txt only when this file or the generated code do not answer the question (for example pricing, account limits or endpoint behaviour that is not described locally). Everything needed to write client code is already in this library.

`llms.txt` is a large (~200 KB) index of links to per-endpoint Markdown pages (`https://docs.dataforseo.com/v3/...md`). Do not read it whole: search it for the endpoint path or name and fetch only the linked page.
