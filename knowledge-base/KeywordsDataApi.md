# KeywordsDataApi

Knowledge base for `dfsClient.KeywordsDataApi` of the DataForSEO C# client. Naming rules, the response envelope, polymorphic items and errors are described in [SKILL.md](../SKILL.md).

Keyword metrics from advertising platforms and trend services: search volume, cost per click, competition and their monthly dynamics, keyword ideas, ad traffic forecasts and keyword popularity trends, from sources such as Google Ads, Bing Ads, Google Trends, DataForSEO Trends and clickstream data.

The data comes from the original sources, so it follows their rules: advertising platforms do not return data for restricted topics, and trend services return relative popularity rather than absolute numbers.

## Use it when you need

- Search volume, CPC and competition for a known list of keywords, as reported by an advertising platform.
- Keyword ideas suggested by an advertising platform for a website or for seed keywords.
- A forecast of impressions, clicks and cost for a planned advertising campaign.
- How interest in a keyword or topic changes over time and across regions, or which related topics and queries are rising.

## Use another API when

- You do SEO-oriented keyword research (difficulty, search intent, keywords a domain ranks for, competitors) or need large volumes of keywords from a database: `DataforseoLabsApi`.
- You need how often keywords are asked in AI assistants: `AiOptimizationApi`.
- You need what the search results look like for a keyword: `SerpApi`.

## Examples

Generated from the API specification in the same way as the client tests. Replace `USERNAME` / `PASSWORD` with your API login and password. Every example needs:

```csharp
using DataForSeo.Client;
using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
```

### GoogleTrendsExploreTaskGetAsync

`GET /v3/keywords_data/google_trends/explore/task_get/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.KeywordsDataApi.GoogleTrendsExploreTaskGetAsync(id);
```

### GoogleTrendsExploreTaskPostAsync

`POST /v3/keywords_data/google_trends/explore/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleTrendsExploreTaskPostAsync(new List<KeywordsDataGoogleTrendsExploreTaskPostRequestInfo>()
{
    new()
    {
        Type = "youtube",
        CategoryCode = 3,
        Keywords = new List<string>()
        {
            "seo api",
            "rank api",
        },
    }
});
```

### GoogleAdsSearchVolumeLiveAsync

`POST /v3/keywords_data/google_ads/search_volume/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsSearchVolumeLiveAsync(new List<KeywordsDataGoogleAdsSearchVolumeLiveRequestInfo>()
{
    new()
    {
        LocationCode = 2840,
        Keywords = new List<string>()
        {
            "buy laptop",
            "cheap laptops for sale",
            "purchase laptop",
        },
        SearchPartners = true,
    }
});
```

### BingSearchVolumeLiveAsync

`POST /v3/keywords_data/bing/search_volume/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeLiveAsync(new List<KeywordsDataBingSearchVolumeLiveRequestInfo>()
{
    new()
    {
        LocationName = "United States",
        LanguageCode = "en",
        Keywords = new List<string>()
        {
            "tom and jerry",
            "silicon valley",
            "spider man",
        },
    }
});
```

### GoogleTrendsExploreLiveAsync

`POST /v3/keywords_data/google_trends/explore/live`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleTrendsExploreLiveAsync(new List<KeywordsDataGoogleTrendsExploreLiveRequestInfo>()
{
    new()
    {
        LocationName = "United States",
        Type = "youtube",
        CategoryCode = 3,
        Keywords = new List<string>()
        {
            "rugby",
            "cricket",
        },
    }
});
```

### GoogleAdsSearchVolumeTaskGetAsync

`GET /v3/keywords_data/google_ads/search_volume/task_get/{id}`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.KeywordsDataApi.GoogleAdsSearchVolumeTaskGetAsync(id);
```

### GoogleAdsSearchVolumeTaskPostAsync

`POST /v3/keywords_data/google_ads/search_volume/task_post`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsSearchVolumeTaskPostAsync(new List<KeywordsDataGoogleAdsSearchVolumeTaskPostRequestInfo>()
{
    new()
    {
        LocationName = "United States",
        Keywords = new List<string>()
        {
            "buy laptop",
            "cheap laptops for sale",
            "purchase laptop",
        },
    }
});
```

### GoogleAdsSearchVolumeTasksReadyAsync

`GET /v3/keywords_data/google_ads/search_volume/tasks_ready`

```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsSearchVolumeTasksReadyAsync();
```

## Endpoints

All methods of `KeywordsDataApi`. Request and response DTO names are derived from the path (see SKILL.md).

| Method | HTTP | Path |
|---|---|---|
| `KeywordsDataIdListAsync` | POST | `/v3/keywords_data/id_list` |
| `KeywordsDataErrorsAsync` | POST | `/v3/keywords_data/errors` |
| `GoogleAdsStatusAsync` | GET | `/v3/keywords_data/google_ads/status` |
| `GoogleAdsLocationsAsync` | GET | `/v3/keywords_data/google_ads/locations` |
| `GoogleAdsLocationsCountryAsync` | GET | `/v3/keywords_data/google_ads/locations/{country}` |
| `GoogleAdsLanguagesAsync` | GET | `/v3/keywords_data/google_ads/languages` |
| `GoogleAdsSearchVolumeTaskPostAsync` | POST | `/v3/keywords_data/google_ads/search_volume/task_post` |
| `GoogleAdsSearchVolumeTasksReadyAsync` | GET | `/v3/keywords_data/google_ads/search_volume/tasks_ready` |
| `GoogleAdsSearchVolumeTaskGetAsync` | GET | `/v3/keywords_data/google_ads/search_volume/task_get/{id}` |
| `GoogleAdsSearchVolumeLiveAsync` | POST | `/v3/keywords_data/google_ads/search_volume/live` |
| `GoogleAdsKeywordsForSiteTaskPostAsync` | POST | `/v3/keywords_data/google_ads/keywords_for_site/task_post` |
| `GoogleAdsKeywordsForSiteTasksReadyAsync` | GET | `/v3/keywords_data/google_ads/keywords_for_site/tasks_ready` |
| `GoogleAdsKeywordsForSiteTaskGetAsync` | GET | `/v3/keywords_data/google_ads/keywords_for_site/task_get/{id}` |
| `GoogleAdsKeywordsForSiteLiveAsync` | POST | `/v3/keywords_data/google_ads/keywords_for_site/live` |
| `GoogleAdsKeywordsForKeywordsTaskPostAsync` | POST | `/v3/keywords_data/google_ads/keywords_for_keywords/task_post` |
| `GoogleAdsKeywordsForKeywordsTasksReadyAsync` | GET | `/v3/keywords_data/google_ads/keywords_for_keywords/tasks_ready` |
| `GoogleAdsKeywordsForKeywordsTaskGetAsync` | GET | `/v3/keywords_data/google_ads/keywords_for_keywords/task_get/{id}` |
| `GoogleAdsKeywordsForKeywordsLiveAsync` | POST | `/v3/keywords_data/google_ads/keywords_for_keywords/live` |
| `GoogleAdsAdTrafficByKeywordsTaskPostAsync` | POST | `/v3/keywords_data/google_ads/ad_traffic_by_keywords/task_post` |
| `GoogleAdsAdTrafficByKeywordsTasksReadyAsync` | GET | `/v3/keywords_data/google_ads/ad_traffic_by_keywords/tasks_ready` |
| `GoogleAdsAdTrafficByKeywordsTaskGetAsync` | GET | `/v3/keywords_data/google_ads/ad_traffic_by_keywords/task_get/{id}` |
| `GoogleAdsAdTrafficByKeywordsLiveAsync` | POST | `/v3/keywords_data/google_ads/ad_traffic_by_keywords/live` |
| `GoogleTrendsLocationsAsync` | GET | `/v3/keywords_data/google_trends/locations` |
| `GoogleTrendsLocationsCountryAsync` | GET | `/v3/keywords_data/google_trends/locations/{country}` |
| `GoogleTrendsLanguagesAsync` | GET | `/v3/keywords_data/google_trends/languages` |
| `GoogleTrendsCategoriesAsync` | GET | `/v3/keywords_data/google_trends/categories` |
| `GoogleTrendsExploreTaskPostAsync` | POST | `/v3/keywords_data/google_trends/explore/task_post` |
| `GoogleTrendsExploreTasksReadyAsync` | GET | `/v3/keywords_data/google_trends/explore/tasks_ready` |
| `GoogleTrendsExploreTaskGetAsync` | GET | `/v3/keywords_data/google_trends/explore/task_get/{id}` |
| `GoogleTrendsExploreLiveAsync` | POST | `/v3/keywords_data/google_trends/explore/live` |
| `DataforseoTrendsLocationsAsync` | GET | `/v3/keywords_data/dataforseo_trends/locations` |
| `DataforseoTrendsLocationsCountryAsync` | GET | `/v3/keywords_data/dataforseo_trends/locations/{country}` |
| `DataforseoTrendsExploreLiveAsync` | POST | `/v3/keywords_data/dataforseo_trends/explore/live` |
| `DataforseoTrendsSubregionInterestsLiveAsync` | POST | `/v3/keywords_data/dataforseo_trends/subregion_interests/live` |
| `DataforseoTrendsDemographyLiveAsync` | POST | `/v3/keywords_data/dataforseo_trends/demography/live` |
| `DataforseoTrendsMergedDataLiveAsync` | POST | `/v3/keywords_data/dataforseo_trends/merged_data/live` |
| `KeywordsDataBingLocationsAsync` | GET | `/v3/keywords_data/bing/locations` |
| `KeywordsDataBingLanguagesAsync` | GET | `/v3/keywords_data/bing/languages` |
| `BingSearchVolumeTaskPostAsync` | POST | `/v3/keywords_data/bing/search_volume/task_post` |
| `BingSearchVolumeTasksReadyAsync` | GET | `/v3/keywords_data/bing/search_volume/tasks_ready` |
| `BingSearchVolumeTaskGetAsync` | GET | `/v3/keywords_data/bing/search_volume/task_get/{id}` |
| `BingSearchVolumeLiveAsync` | POST | `/v3/keywords_data/bing/search_volume/live` |
| `BingAudienceEstimationJobFunctionsAsync` | GET | `/v3/keywords_data/bing/audience_estimation/job_functions` |
| `BingAudienceEstimationIndustriesAsync` | GET | `/v3/keywords_data/bing/audience_estimation/industries` |
| `BingAudienceEstimationTaskPostAsync` | POST | `/v3/keywords_data/bing/audience_estimation/task_post` |
| `BingAudienceEstimationTasksReadyAsync` | GET | `/v3/keywords_data/bing/audience_estimation/tasks_ready` |
| `BingAudienceEstimationTaskGetAsync` | GET | `/v3/keywords_data/bing/audience_estimation/task_get/{id}` |
| `BingAudienceEstimationLiveAsync` | POST | `/v3/keywords_data/bing/audience_estimation/live` |
| `BingKeywordsForSiteTaskPostAsync` | POST | `/v3/keywords_data/bing/keywords_for_site/task_post` |
| `BingKeywordsForSiteTasksReadyAsync` | GET | `/v3/keywords_data/bing/keywords_for_site/tasks_ready` |
| `BingKeywordsForSiteTaskGetAsync` | GET | `/v3/keywords_data/bing/keywords_for_site/task_get/{id}` |
| `BingKeywordsForSiteLiveAsync` | POST | `/v3/keywords_data/bing/keywords_for_site/live` |
| `BingKeywordsForKeywordsTaskPostAsync` | POST | `/v3/keywords_data/bing/keywords_for_keywords/task_post` |
| `BingKeywordsForKeywordsTasksReadyAsync` | GET | `/v3/keywords_data/bing/keywords_for_keywords/tasks_ready` |
| `BingKeywordsForKeywordsTaskGetAsync` | GET | `/v3/keywords_data/bing/keywords_for_keywords/task_get/{id}` |
| `BingKeywordsForKeywordsLiveAsync` | POST | `/v3/keywords_data/bing/keywords_for_keywords/live` |
| `BingKeywordPerformanceLocationsAndLanguagesAsync` | GET | `/v3/keywords_data/bing/keyword_performance/locations_and_languages` |
| `BingKeywordPerformanceTaskPostAsync` | POST | `/v3/keywords_data/bing/keyword_performance/task_post` |
| `BingKeywordPerformanceTasksReadyAsync` | GET | `/v3/keywords_data/bing/keyword_performance/tasks_ready` |
| `BingKeywordPerformanceTaskGetAsync` | GET | `/v3/keywords_data/bing/keyword_performance/task_get/{id}` |
| `BingKeywordPerformanceLiveAsync` | POST | `/v3/keywords_data/bing/keyword_performance/live` |
| `BingSearchVolumeHistoryLocationsAndLanguagesAsync` | GET | `/v3/keywords_data/bing/search_volume_history/locations_and_languages` |
| `BingSearchVolumeHistoryTaskPostAsync` | POST | `/v3/keywords_data/bing/search_volume_history/task_post` |
| `BingSearchVolumeHistoryTasksReadyAsync` | GET | `/v3/keywords_data/bing/search_volume_history/tasks_ready` |
| `BingSearchVolumeHistoryTaskGetAsync` | GET | `/v3/keywords_data/bing/search_volume_history/task_get/{id}` |
| `BingSearchVolumeHistoryLiveAsync` | POST | `/v3/keywords_data/bing/search_volume_history/live` |
| `ClickstreamDataLocationsAndLanguagesAsync` | GET | `/v3/keywords_data/clickstream_data/locations_and_languages` |
| `ClickstreamDataDataforseoSearchVolumeLiveAsync` | POST | `/v3/keywords_data/clickstream_data/dataforseo_search_volume/live` |
| `ClickstreamDataGlobalSearchVolumeLiveAsync` | POST | `/v3/keywords_data/clickstream_data/global_search_volume/live` |
| `ClickstreamDataBulkSearchVolumeLiveAsync` | POST | `/v3/keywords_data/clickstream_data/bulk_search_volume/live` |