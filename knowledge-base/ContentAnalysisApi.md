# ContentAnalysisApi

Knowledge base for `dfsClient.ContentAnalysisApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

Brand monitoring and sentiment analysis across the web: pages that mention (cite) a keyword or brand, with the sentiment polarity and emotional connotations of each mention, content ratings and categories, and aggregated trends of mentions over time.

## Use it when you need

- Where and how a brand, product, person or topic is mentioned on the web: news, blogs, forums, reviews and other pages.
- Whether mentions are positive, negative or neutral, and which emotions they carry.
- An aggregated picture of mentions: top sources, countries, languages, page types and content categories.
- How the volume and sentiment of mentions change over time for a keyword or a content category.

## Use another API when

- You need links pointing to a site rather than text mentions: `BacklinksApi`.
- You need mentions in AI assistant answers: `AiOptimizationApi`.
- You need reviews of a specific business on review platforms: `BusinessDataApi`.

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### SearchLiveAsync

`POST /v3/content_analysis/search/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.SearchLiveAsync(new List<ContentAnalysisSearchLiveRequestInfo>()
{
    new()
    {
        KeywordFields = new Dictionary<string, string>()
        {
            ["snippet"] = "logitech",
        },
        Keyword = "logitech",
        PageType = new List<string>()
        {
            "ecommerce",
            "news",
            "blogs",
            "message-boards",
            "organization",
        },
        SearchMode = "as_is",
        Filters = new List<object>()
        {
            "main_domain",
            "=",
            "reviewfinder.ca",
        },
        OrderBy = new List<string>()
        {
            "content_info.sentiment_connotations.anger,desc",
        },
        Limit = 10,
    }
});
```

### ContentAnalysisSummaryLiveAsync

`POST /v3/content_analysis/summary/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.ContentAnalysisSummaryLiveAsync(new List<ContentAnalysisSummaryLiveRequestInfo>()
{
    new()
    {
        Keyword = "logitech",
        PageType = new List<string>()
        {
            "ecommerce",
            "news",
            "blogs",
            "message-boards",
            "organization",
        },
        InternalListLimit = 8,
        PositiveConnotationThreshold = 0.5,
    }
});
```

### PhraseTrendsLiveAsync

`POST /v3/content_analysis/phrase_trends/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.PhraseTrendsLiveAsync(new List<ContentAnalysisPhraseTrendsLiveRequestInfo>()
{
    new()
    {
        Keyword = "logitech",
        SearchMode = "as_is",
        DateGroup = "month",
    }
});
```

### ContentAnalysisIdListAsync

`POST /v3/content_analysis/id_list`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.ContentAnalysisIdListAsync(new List<ContentAnalysisIdListRequestInfo>()
{
    new()
    {
        Limit = 10,
        IncludeMetadata = true,
    }
});
```

### SentimentAnalysisLiveAsync

`POST /v3/content_analysis/sentiment_analysis/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.SentimentAnalysisLiveAsync(new List<ContentAnalysisSentimentAnalysisLiveRequestInfo>()
{
    new()
    {
        Keyword = "logitech",
        InternalListLimit = 1,
    }
});
```

### RatingDistributionLiveAsync

`POST /v3/content_analysis/rating_distribution/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.RatingDistributionLiveAsync(new List<ContentAnalysisRatingDistributionLiveRequestInfo>()
{
    new()
    {
        Keyword = "logitech",
        SearchMode = "as_is",
        InternalListLimit = 10,
    }
});
```

### LanguagesAsync

`GET /v3/content_analysis/languages`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.LanguagesAsync();
```

### ContentAnalysisCategoriesAsync

`GET /v3/content_analysis/categories`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.ContentAnalysisCategoriesAsync();
```

### LocationsAsync

`GET /v3/content_analysis/locations`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.LocationsAsync();
```

### CategoryTrendsLiveAsync

`POST /v3/content_analysis/category_trends/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.CategoryTrendsLiveAsync(new List<ContentAnalysisCategoryTrendsLiveRequestInfo>()
{
    new()
    {
        CategoryCode = 10994,
        SearchMode = "as_is",
        DateGroup = "month",
    }
});
```

## Endpoints

All methods of `ContentAnalysisApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `ContentAnalysisIdListAsync` | POST | `/v3/content_analysis/id_list` |
| `ContentAnalysisAvailableFiltersAsync` | GET | `/v3/content_analysis/available_filters` |
| `LocationsAsync` | GET | `/v3/content_analysis/locations` |
| `LanguagesAsync` | GET | `/v3/content_analysis/languages` |
| `ContentAnalysisCategoriesAsync` | GET | `/v3/content_analysis/categories` |
| `SearchLiveAsync` | POST | `/v3/content_analysis/search/live` |
| `ContentAnalysisSummaryLiveAsync` | POST | `/v3/content_analysis/summary/live` |
| `SentimentAnalysisLiveAsync` | POST | `/v3/content_analysis/sentiment_analysis/live` |
| `RatingDistributionLiveAsync` | POST | `/v3/content_analysis/rating_distribution/live` |
| `PhraseTrendsLiveAsync` | POST | `/v3/content_analysis/phrase_trends/live` |
| `CategoryTrendsLiveAsync` | POST | `/v3/content_analysis/category_trends/live` |