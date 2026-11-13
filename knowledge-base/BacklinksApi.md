# BacklinksApi

Knowledge base for `dfsClient.BacklinksApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

Backlink data for any domain, subdomain or web page from DataForSEO's continuously updated link index: inbound links, referring domains, pages and networks, anchor texts, link-based authority (rank) and spam score, how the link profile changes over time, and how it compares with other sites.

Data is returned immediately from the index and can be filtered, sorted and paged. Many metrics are also available in bulk for large lists of targets.

## Use it when you need

- An overview of a site's link profile and authority.
- Detailed lists of backlinks, referring domains or anchors of a target, filtered by attributes such as dofollow, first seen date or authority.
- New and lost links over time, or the history of a link profile.
- Link building and competitive research: sites with similar link profiles, or domains that link to competitors but not to you.
- Quick authority or spam checks for many domains or URLs at once.

## Use another API when

- You need search rankings, keywords or traffic of a site: `DataforseoLabsApi` or `SerpApi`.
- You need a technical audit of a site, including its internal and outgoing links: `OnPageApi`.
- You need mentions of a brand without a link: `ContentAnalysisApi` (web) or `AiOptimizationApi` (AI answers).

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### BacklinksLiveAsync

`POST /v3/backlinks/backlinks/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BacklinksLiveAsync(new List<BacklinksBacklinksLiveRequestInfo>()
{
    new()
    {
        Target = "forbes.com",
        Mode = "as_is",
        Filters = new List<object>()
        {
            "dofollow",
            "=",
            true,
        },
        Limit = 5,
    }
});
```

### SummaryLiveAsync

`POST /v3/backlinks/summary/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.SummaryLiveAsync(new List<BacklinksSummaryLiveRequestInfo>()
{
    new()
    {
        Target = "explodingtopics.com",
        InternalListLimit = 10,
        IncludeSubdomains = true,
        BacklinksFilters = new List<object>()
        {
            "dofollow",
            "=",
            true,
        },
        BacklinksStatusType = "all",
    }
});
```

### ReferringDomainsLiveAsync

`POST /v3/backlinks/referring_domains/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.ReferringDomainsLiveAsync(new List<BacklinksReferringDomainsLiveRequestInfo>()
{
    new()
    {
        Target = "backlinko.com",
        Limit = 5,
        OrderBy = new List<string>()
        {
            "rank,desc",
        },
        ExcludeInternalBacklinks = true,
        BacklinksFilters = new List<object>()
        {
            "dofollow",
            "=",
            true,
        },
        Filters = new List<object>()
        {
            "backlinks",
            ">",
            100,
        },
    }
});
```

### BulkRanksLiveAsync

`POST /v3/backlinks/bulk_ranks/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BulkRanksLiveAsync(new List<BacklinksBulkRanksLiveRequestInfo>()
{
    new()
    {
        Targets = new List<string>()
        {
            "forbes.com",
            "cnn.com",
            "bbc.com",
            "yelp.com",
            "https://www.apple.com/iphone/",
            "https://ahrefs.com/blog/",
            "ibm.com",
            "https://variety.com/",
            "https://stackoverflow.com/",
            "www.trustpilot.com",
        },
    }
});
```

### AnchorsLiveAsync

`POST /v3/backlinks/anchors/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.AnchorsLiveAsync(new List<BacklinksAnchorsLiveRequestInfo>()
{
    new()
    {
        Target = "forbes.com",
        Limit = 4,
        OrderBy = new List<string>()
        {
            "backlinks,desc",
        },
        Filters = new List<object>()
        {
            "anchor",
            "like",
            "%news%",
        },
    }
});
```

### BulkReferringDomainsLiveAsync

`POST /v3/backlinks/bulk_referring_domains/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BulkReferringDomainsLiveAsync(new List<BacklinksBulkReferringDomainsLiveRequestInfo>()
{
    new()
    {
        Targets = new List<string>()
        {
            "forbes.com",
            "cnn.com",
            "bbc.com",
            "yelp.com",
            "https://www.apple.com/iphone/",
            "https://ahrefs.com/blog/",
            "ibm.com",
            "https://variety.com/",
            "https://stackoverflow.com/",
            "www.trustpilot.com",
        },
    }
});
```

### BulkPagesSummaryLiveAsync

`POST /v3/backlinks/bulk_pages_summary/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BulkPagesSummaryLiveAsync(new List<BacklinksBulkPagesSummaryLiveRequestInfo>()
{
    new()
    {
        Targets = new List<string>()
        {
            "https://dataforseo.com/solutions",
            "https://dataforseo.com/about-us",
        },
    }
});
```

### HistoryLiveAsync

`POST /v3/backlinks/history/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.HistoryLiveAsync(new List<BacklinksHistoryLiveRequestInfo>()
{
    new()
    {
        Target = "cnn.com",
    }
});
```

### BulkBacklinksLiveAsync

`POST /v3/backlinks/bulk_backlinks/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BulkBacklinksLiveAsync(new List<BacklinksBulkBacklinksLiveRequestInfo>()
{
    new()
    {
        Targets = new List<string>()
        {
            "forbes.com",
            "cnn.com",
            "bbc.com",
            "yelp.com",
            "https://www.apple.com/iphone/",
            "https://ahrefs.com/blog/",
            "ibm.com",
            "https://variety.com/",
            "https://stackoverflow.com/",
            "www.trustpilot.com",
        },
    }
});
```

## Endpoints

All methods of `BacklinksApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `BacklinksIdListAsync` | POST | `/v3/backlinks/id_list` |
| `BacklinksErrorsAsync` | POST | `/v3/backlinks/errors` |
| `BacklinksAvailableFiltersAsync` | GET | `/v3/backlinks/available_filters` |
| `IndexAsync` | GET | `/v3/backlinks/index` |
| `SummaryLiveAsync` | POST | `/v3/backlinks/summary/live` |
| `HistoryLiveAsync` | POST | `/v3/backlinks/history/live` |
| `BacklinksLiveAsync` | POST | `/v3/backlinks/backlinks/live` |
| `AnchorsLiveAsync` | POST | `/v3/backlinks/anchors/live` |
| `DomainPagesLiveAsync` | POST | `/v3/backlinks/domain_pages/live` |
| `DomainPagesSummaryLiveAsync` | POST | `/v3/backlinks/domain_pages_summary/live` |
| `ReferringDomainsLiveAsync` | POST | `/v3/backlinks/referring_domains/live` |
| `ReferringNetworksLiveAsync` | POST | `/v3/backlinks/referring_networks/live` |
| `CompetitorsLiveAsync` | POST | `/v3/backlinks/competitors/live` |
| `DomainIntersectionLiveAsync` | POST | `/v3/backlinks/domain_intersection/live` |
| `PageIntersectionLiveAsync` | POST | `/v3/backlinks/page_intersection/live` |
| `TimeseriesSummaryLiveAsync` | POST | `/v3/backlinks/timeseries_summary/live` |
| `TimeseriesNewLostSummaryLiveAsync` | POST | `/v3/backlinks/timeseries_new_lost_summary/live` |
| `BulkRanksLiveAsync` | POST | `/v3/backlinks/bulk_ranks/live` |
| `BulkBacklinksLiveAsync` | POST | `/v3/backlinks/bulk_backlinks/live` |
| `BulkSpamScoreLiveAsync` | POST | `/v3/backlinks/bulk_spam_score/live` |
| `BulkReferringDomainsLiveAsync` | POST | `/v3/backlinks/bulk_referring_domains/live` |
| `BulkNewLostBacklinksLiveAsync` | POST | `/v3/backlinks/bulk_new_lost_backlinks/live` |
| `BulkNewLostReferringDomainsLiveAsync` | POST | `/v3/backlinks/bulk_new_lost_referring_domains/live` |
| `BulkPagesSummaryLiveAsync` | POST | `/v3/backlinks/bulk_pages_summary/live` |