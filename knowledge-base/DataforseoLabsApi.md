# DataforseoLabsApi

Knowledge base for `dfsClient.DataforseoLabsApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

Keyword research, competitor analysis and search analytics from DataForSEO's own databases of keywords, search results and rankings, for search engines and platforms such as Google, Amazon, Google Play and the App Store.

Because the data is precomputed, one request can cover many keywords or domains, return historical data and combine metrics (search volume, keyword difficulty, search intent, rankings, estimated traffic) without crawling search results on demand.

## Use it when you need

- Keyword research: ideas, suggestions and related keywords for a topic, with their search volume, difficulty and intent.
- The keywords a domain, page, product or app ranks for, its positions and estimated traffic, now and in the past.
- Competitors of a domain, product or app in search, and the keywords they share or do not share (keyword gap).
- Market-level views: top searches, keyword categories, rankings across many domains at once.

## Use another API when

- You need live, exact search results for a specific query right now: `SerpApi`.
- You need search volume and CPC as reported by an advertising platform, ad traffic forecasts or trends: `KeywordsDataApi`.
- You need backlinks and link-based authority: `BacklinksApi`.
- You need AI search visibility rather than classic search: `AiOptimizationApi`.

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### GoogleRankedKeywordsLiveAsync

`POST /v3/dataforseo_labs/google/ranked_keywords/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleRankedKeywordsLiveAsync(new List<DataforseoLabsGoogleRankedKeywordsLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LanguageName = "English",
        LocationName = "United States",
        LoadRankAbsolute = true,
        Limit = 3,
    }
});
```

### GoogleKeywordSuggestionsLiveAsync

`POST /v3/dataforseo_labs/google/keyword_suggestions/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordSuggestionsLiveAsync(new List<DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo>()
{
    new()
    {
        Keyword = "phone",
        LocationCode = 2840,
        LanguageCode = "en",
        IncludeSerpInfo = true,
        IncludeSeedKeyword = true,
        Limit = 1,
    }
});
```

### GoogleDomainIntersectionLiveAsync

`POST /v3/dataforseo_labs/google/domain_intersection/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleDomainIntersectionLiveAsync(new List<DataforseoLabsGoogleDomainIntersectionLiveRequestInfo>()
{
    new()
    {
        Target1 = "mom.com",
        Target2 = "quora.com",
        LanguageCode = "en",
        LocationCode = 2840,
        IncludeSerpInfo = true,
        Limit = 3,
    }
});
```

### GoogleKeywordOverviewLiveAsync

`POST /v3/dataforseo_labs/google/keyword_overview/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordOverviewLiveAsync(new List<DataforseoLabsGoogleKeywordOverviewLiveRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        IncludeClickstreamData = true,
        IncludeSerpInfo = true,
        Keywords = new List<string>()
        {
            "iphone",
        },
    }
});
```

### GoogleHistoricalSerpsLiveAsync

`POST /v3/dataforseo_labs/google/historical_serps/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleHistoricalSerpsLiveAsync(new List<DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### GoogleRelatedKeywordsLiveAsync

`POST /v3/dataforseo_labs/google/related_keywords/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleRelatedKeywordsLiveAsync(new List<DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo>()
{
    new()
    {
        Keyword = "phone",
        LanguageName = "English",
        LocationCode = 2840,
        Limit = 3,
    }
});
```

### GoogleDomainRankOverviewLiveAsync

`POST /v3/dataforseo_labs/google/domain_rank_overview/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleDomainRankOverviewLiveAsync(new List<DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LanguageName = "English",
        LocationCode = 2840,
    }
});
```

### GoogleSearchIntentLiveAsync

`POST /v3/dataforseo_labs/google/search_intent/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleSearchIntentLiveAsync(new List<DataforseoLabsGoogleSearchIntentLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "login page",
            "audi a7",
            "elon musk",
            "milk store new york",
        },
    }
});
```

### GoogleCategoriesForDomainLiveAsync

`POST /v3/dataforseo_labs/google/categories_for_domain/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleCategoriesForDomainLiveAsync(new List<DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LanguageCode = "en",
        LocationName = "United States",
        ItemTypes = new List<string>()
        {
            "paid",
            "organic",
            "featured_snippet",
            "local_pack",
        },
        Limit = 3,
    }
});
```

## Endpoints

All methods of `DataforseoLabsApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `DataforseoLabsIdListAsync` | POST | `/v3/dataforseo_labs/id_list` |
| `StatusAsync` | GET | `/v3/dataforseo_labs/status` |
| `DataforseoLabsErrorsAsync` | POST | `/v3/dataforseo_labs/errors` |
| `AvailableFiltersAsync` | GET | `/v3/dataforseo_labs/available_filters` |
| `LocationsAndLanguagesAsync` | GET | `/v3/dataforseo_labs/locations_and_languages` |
| `CategoriesAsync` | GET | `/v3/dataforseo_labs/categories` |
| `GoogleAvailableHistoryAsync` | GET | `/v3/dataforseo_labs/google/available_history` |
| `GoogleKeywordsForSiteLiveAsync` | POST | `/v3/dataforseo_labs/google/keywords_for_site/live` |
| `GoogleRelatedKeywordsLiveAsync` | POST | `/v3/dataforseo_labs/google/related_keywords/live` |
| `GoogleKeywordSuggestionsLiveAsync` | POST | `/v3/dataforseo_labs/google/keyword_suggestions/live` |
| `GoogleKeywordIdeasLiveAsync` | POST | `/v3/dataforseo_labs/google/keyword_ideas/live` |
| `GoogleBulkKeywordDifficultyLiveAsync` | POST | `/v3/dataforseo_labs/google/bulk_keyword_difficulty/live` |
| `GoogleSearchIntentLiveAsync` | POST | `/v3/dataforseo_labs/google/search_intent/live` |
| `GoogleCategoriesForKeywordsLanguagesAsync` | GET | `/v3/dataforseo_labs/google/categories_for_keywords/languages` |
| `GoogleCategoriesForDomainLiveAsync` | POST | `/v3/dataforseo_labs/google/categories_for_domain/live` |
| `GoogleCategoriesForKeywordsLiveAsync` | POST | `/v3/dataforseo_labs/google/categories_for_keywords/live` |
| `GoogleKeywordsForCategoriesLiveAsync` | POST | `/v3/dataforseo_labs/google/keywords_for_categories/live` |
| `GoogleDomainMetricsByCategoriesLiveAsync` | POST | `/v3/dataforseo_labs/google/domain_metrics_by_categories/live` |
| `GoogleTopSearchesLiveAsync` | POST | `/v3/dataforseo_labs/google/top_searches/live` |
| `GoogleRankedKeywordsLiveAsync` | POST | `/v3/dataforseo_labs/google/ranked_keywords/live` |
| `GoogleSerpCompetitorsLiveAsync` | POST | `/v3/dataforseo_labs/google/serp_competitors/live` |
| `GoogleCompetitorsDomainLiveAsync` | POST | `/v3/dataforseo_labs/google/competitors_domain/live` |
| `GoogleDomainIntersectionLiveAsync` | POST | `/v3/dataforseo_labs/google/domain_intersection/live` |
| `GoogleSubdomainsLiveAsync` | POST | `/v3/dataforseo_labs/google/subdomains/live` |
| `GoogleRelevantPagesLiveAsync` | POST | `/v3/dataforseo_labs/google/relevant_pages/live` |
| `GoogleDomainRankOverviewLiveAsync` | POST | `/v3/dataforseo_labs/google/domain_rank_overview/live` |
| `GoogleHistoricalSerpsLiveAsync` | POST | `/v3/dataforseo_labs/google/historical_serps/live` |
| `GoogleHistoricalRankOverviewLiveAsync` | POST | `/v3/dataforseo_labs/google/historical_rank_overview/live` |
| `GooglePageIntersectionLiveAsync` | POST | `/v3/dataforseo_labs/google/page_intersection/live` |
| `GoogleHistoricalSearchVolumeLiveAsync` | POST | `/v3/dataforseo_labs/google/historical_search_volume/live` |
| `GoogleBulkTrafficEstimationLiveAsync` | POST | `/v3/dataforseo_labs/google/bulk_traffic_estimation/live` |
| `GoogleHistoricalBulkTrafficEstimationLiveAsync` | POST | `/v3/dataforseo_labs/google/historical_bulk_traffic_estimation/live` |
| `GoogleHistoricalKeywordDataLiveAsync` | POST | `/v3/dataforseo_labs/google/historical_keyword_data/live` |
| `GoogleKeywordOverviewLiveAsync` | POST | `/v3/dataforseo_labs/google/keyword_overview/live` |
| `AmazonBulkSearchVolumeLiveAsync` | POST | `/v3/dataforseo_labs/amazon/bulk_search_volume/live` |
| `AmazonRelatedKeywordsLiveAsync` | POST | `/v3/dataforseo_labs/amazon/related_keywords/live` |
| `AmazonRankedKeywordsLiveAsync` | POST | `/v3/dataforseo_labs/amazon/ranked_keywords/live` |
| `AmazonProductRankOverviewLiveAsync` | POST | `/v3/dataforseo_labs/amazon/product_rank_overview/live` |
| `AmazonProductCompetitorsLiveAsync` | POST | `/v3/dataforseo_labs/amazon/product_competitors/live` |
| `AmazonProductKeywordIntersectionsLiveAsync` | POST | `/v3/dataforseo_labs/amazon/product_keyword_intersections/live` |
| `GoogleBulkAppMetricsLiveAsync` | POST | `/v3/dataforseo_labs/google/bulk_app_metrics/live` |
| `GoogleKeywordsForAppLiveAsync` | POST | `/v3/dataforseo_labs/google/keywords_for_app/live` |
| `GoogleAppCompetitorsLiveAsync` | POST | `/v3/dataforseo_labs/google/app_competitors/live` |
| `GoogleAppIntersectionLiveAsync` | POST | `/v3/dataforseo_labs/google/app_intersection/live` |
| `AppleBulkAppMetricsLiveAsync` | POST | `/v3/dataforseo_labs/apple/bulk_app_metrics/live` |
| `AppleKeywordsForAppLiveAsync` | POST | `/v3/dataforseo_labs/apple/keywords_for_app/live` |
| `AppleAppCompetitorsLiveAsync` | POST | `/v3/dataforseo_labs/apple/app_competitors/live` |
| `AppleAppIntersectionLiveAsync` | POST | `/v3/dataforseo_labs/apple/app_intersection/live` |