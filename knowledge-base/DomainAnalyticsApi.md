# DomainAnalyticsApi

Knowledge base for `dfsClient.DomainAnalyticsApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

Information about websites as such: the technologies a site is built with (CMS, analytics, frameworks, advertising and other tools), which sites use a given technology, statistics of technology usage, and domain registration (Whois) data enriched with search and backlink metrics.

## Use it when you need

- The technology profile of a website.
- Lists of websites that use a technology or contain certain terms in their HTML, for lead generation or market research, filtered by country, language or popularity.
- Market share and adoption trends of technologies.
- Domain registration details (registrar, creation, update and expiration dates), for example to find expiring domains, together with traffic and backlink indicators.

## Use another API when

- You need the content, technical SEO health or performance of a website's pages: `OnPageApi`.
- You need a website's backlinks: `BacklinksApi`; its keywords, rankings or traffic estimates: `DataforseoLabsApi`.

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### TechnologiesDomainTechnologiesLiveAsync

`POST /v3/domain_analytics/technologies/domain_technologies/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesDomainTechnologiesLiveAsync(new List<DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
    }
});
```

### WhoisOverviewLiveAsync

`POST /v3/domain_analytics/whois/overview/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.WhoisOverviewLiveAsync(new List<DomainAnalyticsWhoisOverviewLiveRequestInfo>()
{
    new()
    {
        Limit = 2,
        Filters = new List<object>()
        {
            new List<object>()
            {
                "epp_status_codes",
                "in",
                new List<object>()
                {
                    "client_transfer_prohibited",
                    "client_update_prohibited",
                },
            },
        },
    }
});
```

### TechnologiesDomainsByTechnologyLiveAsync

`POST /v3/domain_analytics/technologies/domains_by_technology/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesDomainsByTechnologyLiveAsync(new List<DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo>()
{
    new()
    {
        Technologies = new List<string>()
        {
            "Nginx",
        },
        Filters = new List<object>()
        {
            new List<object>()
            {
                "country_iso_code",
                "=",
                "US",
            },
            "and",
            new List<object>()
            {
                "domain_rank",
                ">",
                800,
            },
        },
        OrderBy = new List<string>()
        {
            "last_visited,desc",
        },
        Limit = 10,
    }
});
```

### DomainAnalyticsIdListAsync

`POST /v3/domain_analytics/id_list`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.DomainAnalyticsIdListAsync(new List<DomainAnalyticsIdListRequestInfo>()
{
    new()
    {
        Limit = 10,
        IncludeMetadata = true,
    }
});
```

### TechnologiesDomainsByHtmlTermsLiveAsync

`POST /v3/domain_analytics/technologies/domains_by_html_terms/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesDomainsByHtmlTermsLiveAsync(new List<DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo>()
{
    new()
    {
        SearchTerms = new List<string>()
        {
            "data-attrid",
        },
        OrderBy = new List<string>()
        {
            "last_visited,desc",
        },
        Limit = 10,
        Offset = 0,
    }
});
```

### TechnologiesTechnologiesAsync

`GET /v3/domain_analytics/technologies/technologies`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesTechnologiesAsync();
```

### TechnologiesAggregationTechnologiesLiveAsync

`POST /v3/domain_analytics/technologies/aggregation_technologies/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesAggregationTechnologiesLiveAsync(new List<DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo>()
{
    new()
    {
        Mode = "entry",
        Technology = "Nginx",
        Keyword = "WordPress",
        Filters = new List<object>()
        {
            new List<object>()
            {
                "country_iso_code",
                "=",
                "US",
            },
            "and",
            new List<object>()
            {
                "domain_rank",
                ">",
                800,
            },
        },
        OrderBy = new List<string>()
        {
            "groups_count,desc",
        },
        Limit = 10,
    }
});
```

### TechnologiesTechnologiesSummaryLiveAsync

`POST /v3/domain_analytics/technologies/technologies_summary/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesTechnologiesSummaryLiveAsync(new List<DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo>()
{
    new()
    {
        Mode = "entry",
        Technologies = new List<string>()
        {
            "Ngi",
        },
        Keywords = new List<string>()
        {
            "WordPress",
        },
        Filters = new List<object>()
        {
            new List<object>()
            {
                "country_iso_code",
                "=",
                "US",
            },
            "and",
            new List<object>()
            {
                "domain_rank",
                ">",
                800,
            },
        },
    }
});
```

### TechnologiesLocationsAsync

`GET /v3/domain_analytics/technologies/locations`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesLocationsAsync();
```

### TechnologiesTechnologyStatsLiveAsync

`POST /v3/domain_analytics/technologies/technology_stats/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesTechnologyStatsLiveAsync(new List<DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo>()
{
    new()
    {
        Technology = "jQuery",
    }
});
```

## Endpoints

All methods of `DomainAnalyticsApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `DomainAnalyticsIdListAsync` | POST | `/v3/domain_analytics/id_list` |
| `DomainAnalyticsErrorsAsync` | POST | `/v3/domain_analytics/errors` |
| `TechnologiesAvailableFiltersAsync` | GET | `/v3/domain_analytics/technologies/available_filters` |
| `TechnologiesLocationsAsync` | GET | `/v3/domain_analytics/technologies/locations` |
| `TechnologiesLanguagesAsync` | GET | `/v3/domain_analytics/technologies/languages` |
| `TechnologiesTechnologiesAsync` | GET | `/v3/domain_analytics/technologies/technologies` |
| `TechnologiesAggregationTechnologiesLiveAsync` | POST | `/v3/domain_analytics/technologies/aggregation_technologies/live` |
| `TechnologiesTechnologiesSummaryLiveAsync` | POST | `/v3/domain_analytics/technologies/technologies_summary/live` |
| `TechnologiesTechnologyStatsLiveAsync` | POST | `/v3/domain_analytics/technologies/technology_stats/live` |
| `TechnologiesDomainsByTechnologyLiveAsync` | POST | `/v3/domain_analytics/technologies/domains_by_technology/live` |
| `TechnologiesDomainsByHtmlTermsLiveAsync` | POST | `/v3/domain_analytics/technologies/domains_by_html_terms/live` |
| `TechnologiesDomainTechnologiesLiveAsync` | POST | `/v3/domain_analytics/technologies/domain_technologies/live` |
| `WhoisAvailableFiltersAsync` | GET | `/v3/domain_analytics/whois/available_filters` |
| `WhoisOverviewLiveAsync` | POST | `/v3/domain_analytics/whois/overview/live` |