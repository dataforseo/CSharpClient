# DataforseoLabsApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**dataforseoLabsIdList**](DataforseoLabsApi.md#dataforseoLabsIdList) | **POST**  /v3/dataforseo_labs/id_list  |
[**status**](DataforseoLabsApi.md#status) | **GET**  /v3/dataforseo_labs/status  |
[**dataforseoLabsErrors**](DataforseoLabsApi.md#dataforseoLabsErrors) | **POST**  /v3/dataforseo_labs/errors  |
[**availableFilters**](DataforseoLabsApi.md#availableFilters) | **GET**  /v3/dataforseo_labs/available_filters  |
[**locationsAndLanguages**](DataforseoLabsApi.md#locationsAndLanguages) | **GET**  /v3/dataforseo_labs/locations_and_languages  |
[**categories**](DataforseoLabsApi.md#categories) | **GET**  /v3/dataforseo_labs/categories  |
[**googleAvailableHistory**](DataforseoLabsApi.md#googleAvailableHistory) | **GET**  /v3/dataforseo_labs/google/available_history  |
[**googleKeywordsForSiteLive**](DataforseoLabsApi.md#googleKeywordsForSiteLive) | **POST**  /v3/dataforseo_labs/google/keywords_for_site/live  |
[**googleRelatedKeywordsLive**](DataforseoLabsApi.md#googleRelatedKeywordsLive) | **POST**  /v3/dataforseo_labs/google/related_keywords/live  |
[**googleKeywordSuggestionsLive**](DataforseoLabsApi.md#googleKeywordSuggestionsLive) | **POST**  /v3/dataforseo_labs/google/keyword_suggestions/live  |
[**googleKeywordIdeasLive**](DataforseoLabsApi.md#googleKeywordIdeasLive) | **POST**  /v3/dataforseo_labs/google/keyword_ideas/live  |
[**googleBulkKeywordDifficultyLive**](DataforseoLabsApi.md#googleBulkKeywordDifficultyLive) | **POST**  /v3/dataforseo_labs/google/bulk_keyword_difficulty/live  |
[**googleSearchIntentLive**](DataforseoLabsApi.md#googleSearchIntentLive) | **POST**  /v3/dataforseo_labs/google/search_intent/live  |
[**googleCategoriesForKeywordsLanguages**](DataforseoLabsApi.md#googleCategoriesForKeywordsLanguages) | **GET**  /v3/dataforseo_labs/google/categories_for_keywords/languages  |
[**googleCategoriesForDomainLive**](DataforseoLabsApi.md#googleCategoriesForDomainLive) | **POST**  /v3/dataforseo_labs/google/categories_for_domain/live  |
[**googleCategoriesForKeywordsLive**](DataforseoLabsApi.md#googleCategoriesForKeywordsLive) | **POST**  /v3/dataforseo_labs/google/categories_for_keywords/live  |
[**googleKeywordsForCategoriesLive**](DataforseoLabsApi.md#googleKeywordsForCategoriesLive) | **POST**  /v3/dataforseo_labs/google/keywords_for_categories/live  |
[**googleDomainMetricsByCategoriesLive**](DataforseoLabsApi.md#googleDomainMetricsByCategoriesLive) | **POST**  /v3/dataforseo_labs/google/domain_metrics_by_categories/live  |
[**googleTopSearchesLive**](DataforseoLabsApi.md#googleTopSearchesLive) | **POST**  /v3/dataforseo_labs/google/top_searches/live  |
[**googleDomainWhoisOverviewLive**](DataforseoLabsApi.md#googleDomainWhoisOverviewLive) | **POST**  /v3/dataforseo_labs/google/domain_whois_overview/live  |
[**googleRankedKeywordsLive**](DataforseoLabsApi.md#googleRankedKeywordsLive) | **POST**  /v3/dataforseo_labs/google/ranked_keywords/live  |
[**googleSerpCompetitorsLive**](DataforseoLabsApi.md#googleSerpCompetitorsLive) | **POST**  /v3/dataforseo_labs/google/serp_competitors/live  |
[**googleCompetitorsDomainLive**](DataforseoLabsApi.md#googleCompetitorsDomainLive) | **POST**  /v3/dataforseo_labs/google/competitors_domain/live  |
[**googleDomainIntersectionLive**](DataforseoLabsApi.md#googleDomainIntersectionLive) | **POST**  /v3/dataforseo_labs/google/domain_intersection/live  |
[**googleSubdomainsLive**](DataforseoLabsApi.md#googleSubdomainsLive) | **POST**  /v3/dataforseo_labs/google/subdomains/live  |
[**googleRelevantPagesLive**](DataforseoLabsApi.md#googleRelevantPagesLive) | **POST**  /v3/dataforseo_labs/google/relevant_pages/live  |
[**googleDomainRankOverviewLive**](DataforseoLabsApi.md#googleDomainRankOverviewLive) | **POST**  /v3/dataforseo_labs/google/domain_rank_overview/live  |
[**googleHistoricalSerpsLive**](DataforseoLabsApi.md#googleHistoricalSerpsLive) | **POST**  /v3/dataforseo_labs/google/historical_serps/live  |
[**googleHistoricalRankOverviewLive**](DataforseoLabsApi.md#googleHistoricalRankOverviewLive) | **POST**  /v3/dataforseo_labs/google/historical_rank_overview/live  |
[**googlePageIntersectionLive**](DataforseoLabsApi.md#googlePageIntersectionLive) | **POST**  /v3/dataforseo_labs/google/page_intersection/live  |
[**googleBulkTrafficEstimationLive**](DataforseoLabsApi.md#googleBulkTrafficEstimationLive) | **POST**  /v3/dataforseo_labs/google/bulk_traffic_estimation/live  |
[**googleHistoricalBulkTrafficEstimationLive**](DataforseoLabsApi.md#googleHistoricalBulkTrafficEstimationLive) | **POST**  /v3/dataforseo_labs/google/historical_bulk_traffic_estimation/live  |
[**googleHistoricalKeywordDataLive**](DataforseoLabsApi.md#googleHistoricalKeywordDataLive) | **POST**  /v3/dataforseo_labs/google/historical_keyword_data/live  |
[**googleKeywordOverviewLive**](DataforseoLabsApi.md#googleKeywordOverviewLive) | **POST**  /v3/dataforseo_labs/google/keyword_overview/live  |
[**amazonBulkSearchVolumeLive**](DataforseoLabsApi.md#amazonBulkSearchVolumeLive) | **POST**  /v3/dataforseo_labs/amazon/bulk_search_volume/live  |
[**amazonRelatedKeywordsLive**](DataforseoLabsApi.md#amazonRelatedKeywordsLive) | **POST**  /v3/dataforseo_labs/amazon/related_keywords/live  |
[**amazonRankedKeywordsLive**](DataforseoLabsApi.md#amazonRankedKeywordsLive) | **POST**  /v3/dataforseo_labs/amazon/ranked_keywords/live  |
[**amazonProductRankOverviewLive**](DataforseoLabsApi.md#amazonProductRankOverviewLive) | **POST**  /v3/dataforseo_labs/amazon/product_rank_overview/live  |
[**amazonProductCompetitorsLive**](DataforseoLabsApi.md#amazonProductCompetitorsLive) | **POST**  /v3/dataforseo_labs/amazon/product_competitors/live  |
[**amazonProductKeywordIntersectionsLive**](DataforseoLabsApi.md#amazonProductKeywordIntersectionsLive) | **POST**  /v3/dataforseo_labs/amazon/product_keyword_intersections/live  |
[**googleBulkAppMetricsLive**](DataforseoLabsApi.md#googleBulkAppMetricsLive) | **POST**  /v3/dataforseo_labs/google/bulk_app_metrics/live  |
[**googleKeywordsForAppLive**](DataforseoLabsApi.md#googleKeywordsForAppLive) | **POST**  /v3/dataforseo_labs/google/keywords_for_app/live  |
[**googleAppCompetitorsLive**](DataforseoLabsApi.md#googleAppCompetitorsLive) | **POST**  /v3/dataforseo_labs/google/app_competitors/live  |
[**googleAppIntersectionLive**](DataforseoLabsApi.md#googleAppIntersectionLive) | **POST**  /v3/dataforseo_labs/google/app_intersection/live  |
[**appleBulkAppMetricsLive**](DataforseoLabsApi.md#appleBulkAppMetricsLive) | **POST**  /v3/dataforseo_labs/apple/bulk_app_metrics/live  |
[**appleKeywordsForAppLive**](DataforseoLabsApi.md#appleKeywordsForAppLive) | **POST**  /v3/dataforseo_labs/apple/keywords_for_app/live  |
[**appleAppCompetitorsLive**](DataforseoLabsApi.md#appleAppCompetitorsLive) | **POST**  /v3/dataforseo_labs/apple/app_competitors/live  |
[**appleAppIntersectionLive**](DataforseoLabsApi.md#appleAppIntersectionLive) | **POST**  /v3/dataforseo_labs/apple/app_intersection/live  |

<a id="dataforseoLabsIdList"></a>
# **dataforseoLabsIdList**
> DataforseoLabsIdListResponseInfo dataforseoLabsIdList()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.DataforseoLabsIdListAsync(
    new DataforseoLabsIdListRequestInfo[]
    {
        new DataforseoLabsIdListRequestInfo()
        {
            DatetimeFrom = "2026-02-15 08:21:04 +00:00",
            DatetimeTo = "2026-02-17 08:21:04 +00:00",
            Limit = 100,
            Offset = 0,
            Sort = "desc",
            IncludeMetadata = true,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsIdListRequestInfo>&gt;**](IEnumerable<DataforseoLabsIdListRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsIdListResponseInfo**](DataforseoLabsIdListResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="status"></a>
# **status**
> DataforseoLabsStatusResponseInfo status()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.StatusAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**DataforseoLabsStatusResponseInfo**](DataforseoLabsStatusResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="dataforseoLabsErrors"></a>
# **dataforseoLabsErrors**
> DataforseoLabsErrorsResponseInfo dataforseoLabsErrors()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.DataforseoLabsErrorsAsync(
    new DataforseoLabsErrorsRequestInfo[]
    {
        new DataforseoLabsErrorsRequestInfo()
        {
            Limit = 10,
            Offset = 0,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsErrorsRequestInfo>&gt;**](IEnumerable<DataforseoLabsErrorsRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsErrorsResponseInfo**](DataforseoLabsErrorsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="availableFilters"></a>
# **availableFilters**
> DataforseoLabsAvailableFiltersResponseInfo availableFilters()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.AvailableFiltersAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**DataforseoLabsAvailableFiltersResponseInfo**](DataforseoLabsAvailableFiltersResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="locationsAndLanguages"></a>
# **locationsAndLanguages**
> DataforseoLabsLocationsAndLanguagesResponseInfo locationsAndLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.LocationsAndLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**DataforseoLabsLocationsAndLanguagesResponseInfo**](DataforseoLabsLocationsAndLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="categories"></a>
# **categories**
> DataforseoLabsCategoriesResponseInfo categories()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.CategoriesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**DataforseoLabsCategoriesResponseInfo**](DataforseoLabsCategoriesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAvailableHistory"></a>
# **googleAvailableHistory**
> DataforseoLabsGoogleAvailableHistoryResponseInfo googleAvailableHistory()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleAvailableHistoryAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**DataforseoLabsGoogleAvailableHistoryResponseInfo**](DataforseoLabsGoogleAvailableHistoryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleKeywordsForSiteLive"></a>
# **googleKeywordsForSiteLive**
> DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo googleKeywordsForSiteLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordsForSiteLiveAsync(
    new DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo[]
    {
        new DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo()
        {
            Target = "apple.com",
            LanguageCode = "en",
            LocationCode = 2840,
            IncludeSerpInfo = true,
            IncludeSubdomains = true,
            Filters = new object[]
        {
            "serp_info.se_results_count",
            ">",
            0,
        },
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo**](DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleRelatedKeywordsLive"></a>
# **googleRelatedKeywordsLive**
> DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo googleRelatedKeywordsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleRelatedKeywordsLiveAsync(
    new DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo[]
    {
        new DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo()
        {
            Keyword = "phone",
            LanguageName = "English",
            LocationCode = 2840,
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo**](DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleKeywordSuggestionsLive"></a>
# **googleKeywordSuggestionsLive**
> DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo googleKeywordSuggestionsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordSuggestionsLiveAsync(
    new DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo[]
    {
        new DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo()
        {
            Keyword = "phone",
            LocationCode = 2840,
            LanguageCode = "en",
            IncludeSerpInfo = true,
            IncludeSeedKeyword = true,
            Limit = 1,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo**](DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleKeywordIdeasLive"></a>
# **googleKeywordIdeasLive**
> DataforseoLabsGoogleKeywordIdeasLiveResponseInfo googleKeywordIdeasLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordIdeasLiveAsync(
    new DataforseoLabsGoogleKeywordIdeasLiveRequestInfo[]
    {
        new DataforseoLabsGoogleKeywordIdeasLiveRequestInfo()
        {
            Keywords = new string[]
        {
            "phone",
            "watch",
        },
            LocationCode = 2840,
            LanguageCode = "en",
            IncludeSerpInfo = true,
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleKeywordIdeasLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleKeywordIdeasLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleKeywordIdeasLiveResponseInfo**](DataforseoLabsGoogleKeywordIdeasLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleBulkKeywordDifficultyLive"></a>
# **googleBulkKeywordDifficultyLive**
> DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo googleBulkKeywordDifficultyLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleBulkKeywordDifficultyLiveAsync(
    new DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo[]
    {
        new DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo()
        {
            LocationCode = 2840,
            LanguageCode = "en",
            Keywords = new string[]
        {
            "dentist new york",
            "pizza brooklyn",
            "car dealer los angeles",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo**](DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleSearchIntentLive"></a>
# **googleSearchIntentLive**
> DataforseoLabsGoogleSearchIntentLiveResponseInfo googleSearchIntentLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleSearchIntentLiveAsync(
    new DataforseoLabsGoogleSearchIntentLiveRequestInfo[]
    {
        new DataforseoLabsGoogleSearchIntentLiveRequestInfo()
        {
            LanguageCode = "en",
            Keywords = new string[]
        {
            "login page",
            "audi a7",
            "elon musk",
            "milk store new york",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleSearchIntentLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleSearchIntentLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleSearchIntentLiveResponseInfo**](DataforseoLabsGoogleSearchIntentLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleCategoriesForKeywordsLanguages"></a>
# **googleCategoriesForKeywordsLanguages**
> DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo googleCategoriesForKeywordsLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleCategoriesForKeywordsLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo**](DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleCategoriesForDomainLive"></a>
# **googleCategoriesForDomainLive**
> DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo googleCategoriesForDomainLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleCategoriesForDomainLiveAsync(
    new DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo[]
    {
        new DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo()
        {
            Target = "dataforseo.com",
            LanguageCode = "en",
            LocationName = "United States",
            ItemTypes = new string[]
        {
            "paid",
            "organic",
            "featured_snippet",
            "local_pack",
        },
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo**](DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleCategoriesForKeywordsLive"></a>
# **googleCategoriesForKeywordsLive**
> DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo googleCategoriesForKeywordsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleCategoriesForKeywordsLiveAsync(
    new DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo[]
    {
        new DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo()
        {
            LanguageCode = "en",
            Keywords = new string[]
        {
            "dentist new york",
            "pizza brooklyn",
            "car dealer los angeles",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo**](DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleKeywordsForCategoriesLive"></a>
# **googleKeywordsForCategoriesLive**
> DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo googleKeywordsForCategoriesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordsForCategoriesLiveAsync(
    new DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo[]
    {
        new DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo()
        {
            CategoryCodes = new string[]
        {
            "12191",
            "12193",
        },
            LanguageName = "English",
            LocationCode = 2840,
            IncludeSerpInfo = true,
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo**](DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDomainMetricsByCategoriesLive"></a>
# **googleDomainMetricsByCategoriesLive**
> DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo googleDomainMetricsByCategoriesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleDomainMetricsByCategoriesLiveAsync(
    new DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo[]
    {
        new DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo()
        {
            LocationCode = 2840,
            LanguageCode = "en",
            CategoryCodes = new string[]
        {
            "13418",
            "11494",
        },
            FirstDate = "2025-11-18 00:00:00 +02:00",
            SecondDate = "2026-01-18 00:00:00 +02:00",
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo**](DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleTopSearchesLive"></a>
# **googleTopSearchesLive**
> DataforseoLabsGoogleTopSearchesLiveResponseInfo googleTopSearchesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleTopSearchesLiveAsync(
    new DataforseoLabsGoogleTopSearchesLiveRequestInfo[]
    {
        new DataforseoLabsGoogleTopSearchesLiveRequestInfo()
        {
            LanguageName = "English",
            LocationCode = 2840,
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleTopSearchesLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleTopSearchesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleTopSearchesLiveResponseInfo**](DataforseoLabsGoogleTopSearchesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDomainWhoisOverviewLive"></a>
# **googleDomainWhoisOverviewLive**
> DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo googleDomainWhoisOverviewLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleDomainWhoisOverviewLiveAsync(
    new DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo[]
    {
        new DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo()
        {
            Limit = 2,
            Filters = new object[]
        {
            new object[]
            {
                "epp_status_codes",
                "in",
                new object[]
                {
                    "client_transfer_prohibited",
                    "client_update_prohibited",
                },
            },
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo**](DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleRankedKeywordsLive"></a>
# **googleRankedKeywordsLive**
> DataforseoLabsGoogleRankedKeywordsLiveResponseInfo googleRankedKeywordsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleRankedKeywordsLiveAsync(
    new DataforseoLabsGoogleRankedKeywordsLiveRequestInfo[]
    {
        new DataforseoLabsGoogleRankedKeywordsLiveRequestInfo()
        {
            Target = "dataforseo.com",
            LanguageName = "English",
            LocationName = "United States",
            LoadRankAbsolute = true,
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleRankedKeywordsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleRankedKeywordsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleRankedKeywordsLiveResponseInfo**](DataforseoLabsGoogleRankedKeywordsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleSerpCompetitorsLive"></a>
# **googleSerpCompetitorsLive**
> DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo googleSerpCompetitorsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleSerpCompetitorsLiveAsync(
    new DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo[]
    {
        new DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo()
        {
            Keywords = new string[]
        {
            "phone",
        },
            LanguageName = "English",
            LocationCode = 2840,
            ItemTypes = new string[]
        {
            "organic",
        },
            Limit = 5,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo**](DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleCompetitorsDomainLive"></a>
# **googleCompetitorsDomainLive**
> DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo googleCompetitorsDomainLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleCompetitorsDomainLiveAsync(
    new DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo[]
    {
        new DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo()
        {
            Target = "newmouth.com",
            IntersectingDomains = new string[]
        {
            "dentaly.org",
            "health.com",
            "trysnow.com",
        },
            LanguageName = "English",
            LocationCode = 2840,
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo**](DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDomainIntersectionLive"></a>
# **googleDomainIntersectionLive**
> DataforseoLabsGoogleDomainIntersectionLiveResponseInfo googleDomainIntersectionLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleDomainIntersectionLiveAsync(
    new DataforseoLabsGoogleDomainIntersectionLiveRequestInfo[]
    {
        new DataforseoLabsGoogleDomainIntersectionLiveRequestInfo()
        {
            Target1 = "mom.com",
            Target2 = "quora.com",
            LanguageCode = "en",
            LocationCode = 2840,
            IncludeSerpInfo = true,
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleDomainIntersectionLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleDomainIntersectionLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleDomainIntersectionLiveResponseInfo**](DataforseoLabsGoogleDomainIntersectionLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleSubdomainsLive"></a>
# **googleSubdomainsLive**
> DataforseoLabsGoogleSubdomainsLiveResponseInfo googleSubdomainsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleSubdomainsLiveAsync(
    new DataforseoLabsGoogleSubdomainsLiveRequestInfo[]
    {
        new DataforseoLabsGoogleSubdomainsLiveRequestInfo()
        {
            Target = "dataforseo.com",
            LanguageName = "English",
            LocationCode = 2840,
            Filters = new object[]
        {
            new object[]
            {
                "metrics.organic.pos_1",
                "<>",
                0,
            },
            "or",
            new object[]
            {
                "metrics.organic.pos_2_3",
                "<>",
                0,
            },
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleSubdomainsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleSubdomainsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleSubdomainsLiveResponseInfo**](DataforseoLabsGoogleSubdomainsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleRelevantPagesLive"></a>
# **googleRelevantPagesLive**
> DataforseoLabsGoogleRelevantPagesLiveResponseInfo googleRelevantPagesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleRelevantPagesLiveAsync(
    new DataforseoLabsGoogleRelevantPagesLiveRequestInfo[]
    {
        new DataforseoLabsGoogleRelevantPagesLiveRequestInfo()
        {
            Target = "amazon.com",
            LanguageName = "English",
            LocationCode = 2840,
            Filters = new object[]
        {
            new object[]
            {
                "metrics.organic.pos_1",
                "<>",
                0,
            },
            "or",
            new object[]
            {
                "metrics.organic.pos_2_3",
                "<>",
                0,
            },
        },
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleRelevantPagesLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleRelevantPagesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleRelevantPagesLiveResponseInfo**](DataforseoLabsGoogleRelevantPagesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleDomainRankOverviewLive"></a>
# **googleDomainRankOverviewLive**
> DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo googleDomainRankOverviewLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleDomainRankOverviewLiveAsync(
    new DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo[]
    {
        new DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo()
        {
            Target = "dataforseo.com",
            LanguageName = "English",
            LocationCode = 2840,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo**](DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHistoricalSerpsLive"></a>
# **googleHistoricalSerpsLive**
> DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo googleHistoricalSerpsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleHistoricalSerpsLiveAsync(
    new DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo[]
    {
        new DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo()
        {
            Keyword = "albert einstein",
            LocationCode = 2840,
            LanguageCode = "en",
            DateFrom = "2025-11-18 00:00:00 +02:00",
            DateTo = "2026-01-18 00:00:00 +02:00",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo**](DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHistoricalRankOverviewLive"></a>
# **googleHistoricalRankOverviewLive**
> DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo googleHistoricalRankOverviewLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleHistoricalRankOverviewLiveAsync(
    new DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo[]
    {
        new DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo()
        {
            Target = "dataforseo.com",
            LocationCode = 2840,
            LanguageCode = "en",
            DateFrom = "2025-11-18 00:00:00 +02:00",
            DateTo = "2026-01-18 00:00:00 +02:00",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo**](DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googlePageIntersectionLive"></a>
# **googlePageIntersectionLive**
> DataforseoLabsGooglePageIntersectionLiveResponseInfo googlePageIntersectionLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GooglePageIntersectionLiveAsync(
    new DataforseoLabsGooglePageIntersectionLiveRequestInfo[]
    {
        new DataforseoLabsGooglePageIntersectionLiveRequestInfo()
        {
            Pages = new Dictionary<string, string>()
        {
            ["1"] = "https://forbes.com",
            ["2"] = "https://cnn.com/*",
        },
            LanguageName = "English",
            LocationCode = 2840,
            IncludeSerpInfo = true,
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGooglePageIntersectionLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGooglePageIntersectionLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGooglePageIntersectionLiveResponseInfo**](DataforseoLabsGooglePageIntersectionLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleBulkTrafficEstimationLive"></a>
# **googleBulkTrafficEstimationLive**
> DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo googleBulkTrafficEstimationLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleBulkTrafficEstimationLiveAsync(
    new DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo[]
    {
        new DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo()
        {
            Targets = new string[]
        {
            "dataforseo.com",
            "cnn.com",
            "forbes.com",
        },
            LocationCode = 2840,
            LanguageCode = "en",
            ItemTypes = new string[]
        {
            "organic",
            "paid",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo**](DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHistoricalBulkTrafficEstimationLive"></a>
# **googleHistoricalBulkTrafficEstimationLive**
> DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo googleHistoricalBulkTrafficEstimationLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleHistoricalBulkTrafficEstimationLiveAsync(
    new DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo[]
    {
        new DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo()
        {
            Targets = new string[]
        {
            "dataforseo.com",
            "cnn.com",
            "forbes.com",
        },
            LocationCode = 2840,
            LanguageCode = "en",
            DateFrom = "2025-11-18 00:00:00 +02:00",
            DateTo = "2026-01-18 00:00:00 +02:00",
            ItemTypes = new string[]
        {
            "organic",
            "paid",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo**](DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHistoricalKeywordDataLive"></a>
# **googleHistoricalKeywordDataLive**
> DataforseoLabsGoogleHistoricalKeywordDataLiveResponseInfo googleHistoricalKeywordDataLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleHistoricalKeywordDataLiveAsync(
    new DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo[]
    {
        new DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo()
        {
            LanguageCode = "en",
            LocationCode = 2840,
            Keywords = new string[]
        {
            "iphone",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleHistoricalKeywordDataLiveResponseInfo**](DataforseoLabsGoogleHistoricalKeywordDataLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleKeywordOverviewLive"></a>
# **googleKeywordOverviewLive**
> DataforseoLabsGoogleKeywordOverviewLiveResponseInfo googleKeywordOverviewLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordOverviewLiveAsync(
    new DataforseoLabsGoogleKeywordOverviewLiveRequestInfo[]
    {
        new DataforseoLabsGoogleKeywordOverviewLiveRequestInfo()
        {
            LanguageCode = "en",
            LocationCode = 2840,
            IncludeClickstreamData = true,
            IncludeSerpInfo = true,
            Keywords = new string[]
        {
            "iphone",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleKeywordOverviewLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleKeywordOverviewLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleKeywordOverviewLiveResponseInfo**](DataforseoLabsGoogleKeywordOverviewLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="amazonBulkSearchVolumeLive"></a>
# **amazonBulkSearchVolumeLive**
> DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo amazonBulkSearchVolumeLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.AmazonBulkSearchVolumeLiveAsync(
    new DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo[]
    {
        new DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo()
        {
            Keywords = new string[]
        {
            "buy laptop",
            "cheap laptops for sale",
            "purchase laptop",
        },
            LocationCode = 2840,
            LanguageCode = "en",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo**](DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="amazonRelatedKeywordsLive"></a>
# **amazonRelatedKeywordsLive**
> DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo amazonRelatedKeywordsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.AmazonRelatedKeywordsLiveAsync(
    new DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo[]
    {
        new DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo()
        {
            Keyword = "computer mouse",
            LanguageName = "English",
            LocationCode = 2840,
            Limit = 5,
            IncludeSeedKeyword = true,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo**](DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="amazonRankedKeywordsLive"></a>
# **amazonRankedKeywordsLive**
> DataforseoLabsAmazonRankedKeywordsLiveResponseInfo amazonRankedKeywordsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.AmazonRankedKeywordsLiveAsync(
    new DataforseoLabsAmazonRankedKeywordsLiveRequestInfo[]
    {
        new DataforseoLabsAmazonRankedKeywordsLiveRequestInfo()
        {
            Asin = "B00R92CL5E",
            LocationCode = 2840,
            LanguageCode = "en",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsAmazonRankedKeywordsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsAmazonRankedKeywordsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsAmazonRankedKeywordsLiveResponseInfo**](DataforseoLabsAmazonRankedKeywordsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="amazonProductRankOverviewLive"></a>
# **amazonProductRankOverviewLive**
> DataforseoLabsAmazonProductRankOverviewLiveResponseInfo amazonProductRankOverviewLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.AmazonProductRankOverviewLiveAsync(
    new DataforseoLabsAmazonProductRankOverviewLiveRequestInfo[]
    {
        new DataforseoLabsAmazonProductRankOverviewLiveRequestInfo()
        {
            Asins = new string[]
        {
            "B001TJ3HUG",
            "B01LW2SL7R",
        },
            LanguageName = "English",
            LocationCode = 2840,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsAmazonProductRankOverviewLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsAmazonProductRankOverviewLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsAmazonProductRankOverviewLiveResponseInfo**](DataforseoLabsAmazonProductRankOverviewLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="amazonProductCompetitorsLive"></a>
# **amazonProductCompetitorsLive**
> DataforseoLabsAmazonProductCompetitorsLiveResponseInfo amazonProductCompetitorsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.AmazonProductCompetitorsLiveAsync(
    new DataforseoLabsAmazonProductCompetitorsLiveRequestInfo[]
    {
        new DataforseoLabsAmazonProductCompetitorsLiveRequestInfo()
        {
            Asin = "019005476X",
            LocationCode = 2840,
            LanguageCode = "en",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsAmazonProductCompetitorsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsAmazonProductCompetitorsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsAmazonProductCompetitorsLiveResponseInfo**](DataforseoLabsAmazonProductCompetitorsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="amazonProductKeywordIntersectionsLive"></a>
# **amazonProductKeywordIntersectionsLive**
> DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo amazonProductKeywordIntersectionsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.AmazonProductKeywordIntersectionsLiveAsync(
    new DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo[]
    {
        new DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo()
        {
            Asins = new Dictionary<string, string>()
        {
            ["1"] = "B09172433Z",
            ["2"] = "B07GBZ4Q68",
            ["3"] = "B07GCKQD77",
        },
            LanguageName = "English",
            LocationCode = 2840,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo**](DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleBulkAppMetricsLive"></a>
# **googleBulkAppMetricsLive**
> DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo googleBulkAppMetricsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleBulkAppMetricsLiveAsync(
    new DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo[]
    {
        new DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo()
        {
            AppIds = new string[]
        {
            "org.telegram.messenger",
            "com.zhiliaoapp.musically",
        },
            LanguageName = "English",
            LocationCode = 2840,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo**](DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleKeywordsForAppLive"></a>
# **googleKeywordsForAppLive**
> DataforseoLabsGoogleKeywordsForAppLiveResponseInfo googleKeywordsForAppLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordsForAppLiveAsync(
    new DataforseoLabsGoogleKeywordsForAppLiveRequestInfo[]
    {
        new DataforseoLabsGoogleKeywordsForAppLiveRequestInfo()
        {
            AppId = "org.telegram.messenger",
            LanguageName = "English",
            LocationCode = 2840,
            Limit = 10,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleKeywordsForAppLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleKeywordsForAppLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleKeywordsForAppLiveResponseInfo**](DataforseoLabsGoogleKeywordsForAppLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppCompetitorsLive"></a>
# **googleAppCompetitorsLive**
> DataforseoLabsGoogleAppCompetitorsLiveResponseInfo googleAppCompetitorsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleAppCompetitorsLiveAsync(
    new DataforseoLabsGoogleAppCompetitorsLiveRequestInfo[]
    {
        new DataforseoLabsGoogleAppCompetitorsLiveRequestInfo()
        {
            AppId = "org.telegram.messenger",
            LanguageName = "English",
            LocationCode = 2840,
            Limit = 10,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleAppCompetitorsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleAppCompetitorsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleAppCompetitorsLiveResponseInfo**](DataforseoLabsGoogleAppCompetitorsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppIntersectionLive"></a>
# **googleAppIntersectionLive**
> DataforseoLabsGoogleAppIntersectionLiveResponseInfo googleAppIntersectionLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.GoogleAppIntersectionLiveAsync(
    new DataforseoLabsGoogleAppIntersectionLiveRequestInfo[]
    {
        new DataforseoLabsGoogleAppIntersectionLiveRequestInfo()
        {
            AppIds = new Dictionary<string, string>()
        {
            ["1"] = "org.telegram.messenger",
            ["2"] = "com.zhiliaoapp.musically",
        },
            LanguageName = "English",
            LocationCode = 2840,
            Limit = 10,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsGoogleAppIntersectionLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsGoogleAppIntersectionLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsGoogleAppIntersectionLiveResponseInfo**](DataforseoLabsGoogleAppIntersectionLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleBulkAppMetricsLive"></a>
# **appleBulkAppMetricsLive**
> DataforseoLabsAppleBulkAppMetricsLiveResponseInfo appleBulkAppMetricsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.AppleBulkAppMetricsLiveAsync(
    new DataforseoLabsAppleBulkAppMetricsLiveRequestInfo[]
    {
        new DataforseoLabsAppleBulkAppMetricsLiveRequestInfo()
        {
            AppIds = new string[]
        {
            "686449807",
            "382617920",
        },
            LanguageName = "English",
            LocationCode = 2840,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsAppleBulkAppMetricsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsAppleBulkAppMetricsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsAppleBulkAppMetricsLiveResponseInfo**](DataforseoLabsAppleBulkAppMetricsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleKeywordsForAppLive"></a>
# **appleKeywordsForAppLive**
> DataforseoLabsAppleKeywordsForAppLiveResponseInfo appleKeywordsForAppLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.AppleKeywordsForAppLiveAsync(
    new DataforseoLabsAppleKeywordsForAppLiveRequestInfo[]
    {
        new DataforseoLabsAppleKeywordsForAppLiveRequestInfo()
        {
            AppId = "686449807",
            LanguageName = "English",
            LocationCode = 2840,
            Limit = 10,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsAppleKeywordsForAppLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsAppleKeywordsForAppLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsAppleKeywordsForAppLiveResponseInfo**](DataforseoLabsAppleKeywordsForAppLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppCompetitorsLive"></a>
# **appleAppCompetitorsLive**
> DataforseoLabsAppleAppCompetitorsLiveResponseInfo appleAppCompetitorsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.AppleAppCompetitorsLiveAsync(
    new DataforseoLabsAppleAppCompetitorsLiveRequestInfo[]
    {
        new DataforseoLabsAppleAppCompetitorsLiveRequestInfo()
        {
            AppId = "686449807",
            LanguageName = "English",
            LocationCode = 2840,
            Limit = 10,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsAppleAppCompetitorsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsAppleAppCompetitorsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsAppleAppCompetitorsLiveResponseInfo**](DataforseoLabsAppleAppCompetitorsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppIntersectionLive"></a>
# **appleAppIntersectionLive**
> DataforseoLabsAppleAppIntersectionLiveResponseInfo appleAppIntersectionLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.AppleAppIntersectionLiveAsync(
    new DataforseoLabsAppleAppIntersectionLiveRequestInfo[]
    {
        new DataforseoLabsAppleAppIntersectionLiveRequestInfo()
        {
            AppIds = new Dictionary<string, string>()
        {
            ["1"] = "686449807",
            ["2"] = "382617920",
        },
            LanguageName = "English",
            LocationCode = 2840,
            Limit = 10,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsAppleAppIntersectionLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsAppleAppIntersectionLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsAppleAppIntersectionLiveResponseInfo**](DataforseoLabsAppleAppIntersectionLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |