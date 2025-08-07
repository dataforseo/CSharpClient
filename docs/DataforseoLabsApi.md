# DataforseoLabsApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**dataforseoLabsIdList**](DataforseoLabsApi.md#dataforseoLabsIdList) | **POST**  /v3/dataforseo_labs/id_list  |
[**dataforseoLabsStatus**](DataforseoLabsApi.md#dataforseoLabsStatus) | **GET**  /v3/dataforseo_labs/status  |
[**dataforseoLabsErrors**](DataforseoLabsApi.md#dataforseoLabsErrors) | **POST**  /v3/dataforseo_labs/errors  |
[**availableFilters**](DataforseoLabsApi.md#availableFilters) | **GET**  /v3/dataforseo_labs/available_filters  |
[**dataforseoLabsLocationsAndLanguages**](DataforseoLabsApi.md#dataforseoLabsLocationsAndLanguages) | **GET**  /v3/dataforseo_labs/locations_and_languages  |
[**categories**](DataforseoLabsApi.md#categories) | **GET**  /v3/dataforseo_labs/categories  |
[**googleAvailableHistory**](DataforseoLabsApi.md#googleAvailableHistory) | **GET**  /v3/dataforseo_labs/google/available_history  |
[**googleKeywordsForSiteLive**](DataforseoLabsApi.md#googleKeywordsForSiteLive) | **POST**  /v3/dataforseo_labs/google/keywords_for_site/live  |
[**googleRelatedKeywordsLive**](DataforseoLabsApi.md#googleRelatedKeywordsLive) | **POST**  /v3/dataforseo_labs/google/related_keywords/live  |
[**googleKeywordSuggestionsLive**](DataforseoLabsApi.md#googleKeywordSuggestionsLive) | **POST**  /v3/dataforseo_labs/google/keyword_suggestions/live  |
[**googleKeywordIdeasLive**](DataforseoLabsApi.md#googleKeywordIdeasLive) | **POST**  /v3/dataforseo_labs/google/keyword_ideas/live  |
[**googleBulkKeywordDifficultyLive**](DataforseoLabsApi.md#googleBulkKeywordDifficultyLive) | **POST**  /v3/dataforseo_labs/google/bulk_keyword_difficulty/live  |
[**googleSearchIntentLive**](DataforseoLabsApi.md#googleSearchIntentLive) | **POST**  /v3/dataforseo_labs/google/search_intent/live  |
[**dataforseoLabsGoogleCategoriesForKeywordsLanguages**](DataforseoLabsApi.md#dataforseoLabsGoogleCategoriesForKeywordsLanguages) | **GET**  /v3/dataforseo_labs/google/categories_for_keywords/languages  |
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
[**bingBulkKeywordDifficultyLive**](DataforseoLabsApi.md#bingBulkKeywordDifficultyLive) | **POST**  /v3/dataforseo_labs/bing/bulk_keyword_difficulty/live  |
[**bingBulkTrafficEstimationLive**](DataforseoLabsApi.md#bingBulkTrafficEstimationLive) | **POST**  /v3/dataforseo_labs/bing/bulk_traffic_estimation/live  |
[**bingCompetitorsDomainLive**](DataforseoLabsApi.md#bingCompetitorsDomainLive) | **POST**  /v3/dataforseo_labs/bing/competitors_domain/live  |
[**bingDomainIntersectionLive**](DataforseoLabsApi.md#bingDomainIntersectionLive) | **POST**  /v3/dataforseo_labs/bing/domain_intersection/live  |
[**bingDomainRankOverviewLive**](DataforseoLabsApi.md#bingDomainRankOverviewLive) | **POST**  /v3/dataforseo_labs/bing/domain_rank_overview/live  |
[**bingPageIntersectionLive**](DataforseoLabsApi.md#bingPageIntersectionLive) | **POST**  /v3/dataforseo_labs/bing/page_intersection/live  |
[**bingRankedKeywordsLive**](DataforseoLabsApi.md#bingRankedKeywordsLive) | **POST**  /v3/dataforseo_labs/bing/ranked_keywords/live  |
[**bingRelatedKeywordsLive**](DataforseoLabsApi.md#bingRelatedKeywordsLive) | **POST**  /v3/dataforseo_labs/bing/related_keywords/live  |
[**bingRelevantPagesLive**](DataforseoLabsApi.md#bingRelevantPagesLive) | **POST**  /v3/dataforseo_labs/bing/relevant_pages/live  |
[**bingSerpCompetitorsLive**](DataforseoLabsApi.md#bingSerpCompetitorsLive) | **POST**  /v3/dataforseo_labs/bing/serp_competitors/live  |
[**bingSubdomainsLive**](DataforseoLabsApi.md#bingSubdomainsLive) | **POST**  /v3/dataforseo_labs/bing/subdomains/live  |
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
var result = await dfsClient.DataforseoLabsApi.DataforseoLabsIdListAsync(new List<DataforseoLabsIdListRequestInfo>()
{
    new()
    {
        DatetimeFrom = "2025-05-06 08:28:57 +00:00",
        DatetimeTo = "2025-07-06 08:28:57 +00:00",
        Limit = 100,
        Offset = 0,
        Sort = "desc",
    }
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

<a id="dataforseoLabsStatus"></a>
# **dataforseoLabsStatus**
> DataforseoLabsStatusResponseInfo dataforseoLabsStatus()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.DataforseoLabsStatusAsync();
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
var result = await dfsClient.DataforseoLabsApi.DataforseoLabsErrorsAsync(new List<DataforseoLabsErrorsRequestInfo>()
{
    new()
    {
        Limit = 10,
        Offset = 0,
    }
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

<a id="dataforseoLabsLocationsAndLanguages"></a>
# **dataforseoLabsLocationsAndLanguages**
> DataforseoLabsLocationsAndLanguagesResponseInfo dataforseoLabsLocationsAndLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.DataforseoLabsLocationsAndLanguagesAsync();
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
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordsForSiteLiveAsync(new List<DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo>()
{
    new()
    {
        Target = "apple.com",
        LocationCode = 2840,
        LanguageCode = "en",
        IncludeSerpInfo = true,
        IncludeSubdomains = true,
        Limit = 3,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleRelatedKeywordsLiveAsync(new List<DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo>()
{
    new()
    {
        Keyword = "phone",
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 3,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordSuggestionsLiveAsync(new List<DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo>()
{
    new()
    {
        Keyword = "phone",
        LocationCode = 2840,
        LanguageCode = "en",
        IncludeSeedKeyword = true,
        IncludeSerpInfo = true,
        Limit = 1,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordIdeasLiveAsync(new List<DataforseoLabsGoogleKeywordIdeasLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "phone",
            "watch",
        },
        LocationCode = 2840,
        LanguageCode = "en",
        IncludeSerpInfo = true,
        Limit = 3,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleBulkKeywordDifficultyLiveAsync(new List<DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "dentist new york",
            "pizza brooklyn",
            "car dealer los angeles",
        },
        LocationCode = 2840,
        LanguageCode = "en",
    }
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
        LanguageCode = "en",
    }
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

<a id="dataforseoLabsGoogleCategoriesForKeywordsLanguages"></a>
# **dataforseoLabsGoogleCategoriesForKeywordsLanguages**
> DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo dataforseoLabsGoogleCategoriesForKeywordsLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.DataforseoLabsGoogleCategoriesForKeywordsLanguagesAsync();
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
var result = await dfsClient.DataforseoLabsApi.GoogleCategoriesForDomainLiveAsync(new List<DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationName = "United States",
        LanguageCode = "en",
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
var result = await dfsClient.DataforseoLabsApi.GoogleCategoriesForKeywordsLiveAsync(new List<DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "dentist new york",
            "pizza brooklyn",
            "car dealer los angeles",
        },
        LanguageCode = "en",
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordsForCategoriesLiveAsync(new List<DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo>()
{
    new()
    {
        CategoryCodes = new List<string>()
        {
            "12191",
            "12193",
        },
        LocationCode = 2840,
        LanguageName = "English",
        IncludeSerpInfo = true,
        Limit = 3,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleDomainMetricsByCategoriesLiveAsync(new List<DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo>()
{
    new()
    {
        CategoryCodes = new List<string>()
        {
            "13418",
            "11494",
        },
        FirstDate = "2025-05-06",
        SecondDate = "2025-07-06",
        LocationCode = 2840,
        LanguageCode = "en",
        Limit = 3,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleTopSearchesLiveAsync(new List<DataforseoLabsGoogleTopSearchesLiveRequestInfo>()
{
    new()
    {
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 3,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleDomainWhoisOverviewLiveAsync(new List<DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo>()
{
    new()
    {
        Limit = 2,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleRankedKeywordsLiveAsync(new List<DataforseoLabsGoogleRankedKeywordsLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationName = "United States",
        LanguageName = "English",
        Limit = 3,
        LoadRankAbsolute = true,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleSerpCompetitorsLiveAsync(new List<DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "phone",
        },
        LocationCode = 2840,
        LanguageName = "English",
        ItemTypes = new List<string>()
        {
            "organic",
        },
        Limit = 5,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleCompetitorsDomainLiveAsync(new List<DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo>()
{
    new()
    {
        Target = "newmouth.com",
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 3,
        IntersectingDomains = new List<string>()
        {
            "dentaly.org",
            "health.com",
            "trysnow.com",
        },
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleDomainIntersectionLiveAsync(new List<DataforseoLabsGoogleDomainIntersectionLiveRequestInfo>()
{
    new()
    {
        Target1 = "mom.com",
        Target2 = "quora.com",
        LocationCode = 2840,
        LanguageCode = "en",
        IncludeSerpInfo = true,
        Limit = 3,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleSubdomainsLiveAsync(new List<DataforseoLabsGoogleSubdomainsLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationCode = 2840,
        LanguageName = "English",
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleRelevantPagesLiveAsync(new List<DataforseoLabsGoogleRelevantPagesLiveRequestInfo>()
{
    new()
    {
        Target = "amazon.com",
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 3,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleDomainRankOverviewLiveAsync(new List<DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationCode = 2840,
        LanguageName = "English",
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleHistoricalSerpsLiveAsync(new List<DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo>()
{
    new()
    {
        Keyword = "albert einstein",
        DateFrom = "2025-05-06",
        DateTo = "2025-07-06",
        LocationCode = 2840,
        LanguageCode = "en",
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleHistoricalRankOverviewLiveAsync(new List<DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationCode = 2840,
        LanguageCode = "en",
        DateFrom = "2025-05-06",
        DateTo = "2025-07-06",
    }
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
var result = await dfsClient.DataforseoLabsApi.GooglePageIntersectionLiveAsync(new List<DataforseoLabsGooglePageIntersectionLiveRequestInfo>()
{
    new()
    {
        Pages = new Dictionary<string, string>()
        {
            ["1"] = "https://forbes.com",
            ["2"] = "https://cnn.com/*",
        },
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 3,
        IncludeSerpInfo = true,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleBulkTrafficEstimationLiveAsync(new List<DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo>()
{
    new()
    {
        Targets = new List<string>()
        {
            "dataforseo.com",
            "cnn.com",
            "forbes.com",
        },
        LocationCode = 2840,
        LanguageCode = "en",
        ItemTypes = new List<string>()
        {
            "organic",
            "paid",
        },
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleHistoricalBulkTrafficEstimationLiveAsync(new List<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo>()
{
    new()
    {
        Targets = new List<string>()
        {
            "dataforseo.com",
            "cnn.com",
            "forbes.com",
        },
        LocationCode = 2840,
        LanguageCode = "en",
        DateFrom = "2025-05-06",
        DateTo = "2025-07-06",
        ItemTypes = new List<string>()
        {
            "organic",
            "paid",
        },
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleHistoricalKeywordDataLiveAsync(new List<DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "iphone",
        },
        LocationCode = 2840,
        LanguageCode = "en",
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordOverviewLiveAsync(new List<DataforseoLabsGoogleKeywordOverviewLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "iphone",
        },
        LocationCode = 2840,
        LanguageCode = "en",
        IncludeSerpInfo = true,
        IncludeClickstreamData = true,
    }
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
var result = await dfsClient.DataforseoLabsApi.AmazonBulkSearchVolumeLiveAsync(new List<DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "buy laptop",
            "cheap laptops for sale",
            "purchase laptop",
        },
        LocationCode = 2840,
        LanguageCode = "en",
    }
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
var result = await dfsClient.DataforseoLabsApi.AmazonRelatedKeywordsLiveAsync(new List<DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo>()
{
    new()
    {
        Keyword = "computer mouse",
        LocationCode = 2840,
        LanguageName = "English",
        IncludeSeedKeyword = true,
        Limit = 5,
    }
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
var result = await dfsClient.DataforseoLabsApi.AmazonRankedKeywordsLiveAsync(new List<DataforseoLabsAmazonRankedKeywordsLiveRequestInfo>()
{
    new()
    {
        Asin = "B00R92CL5E",
        LocationCode = 2840,
        LanguageCode = "en",
    }
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
var result = await dfsClient.DataforseoLabsApi.AmazonProductRankOverviewLiveAsync(new List<DataforseoLabsAmazonProductRankOverviewLiveRequestInfo>()
{
    new()
    {
        Asins = new List<string>()
        {
            "B001TJ3HUG",
            "B01LW2SL7R",
        },
        LocationCode = 2840,
        LanguageName = "English",
    }
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
var result = await dfsClient.DataforseoLabsApi.AmazonProductCompetitorsLiveAsync(new List<DataforseoLabsAmazonProductCompetitorsLiveRequestInfo>()
{
    new()
    {
        Asin = "019005476X",
        LocationCode = 2840,
        LanguageCode = "en",
    }
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
var result = await dfsClient.DataforseoLabsApi.AmazonProductKeywordIntersectionsLiveAsync(new List<DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo>()
{
    new()
    {
        Asins = new Dictionary<string, string>()
        {
            ["1"] = "B09172433Z",
            ["2"] = "B07GBZ4Q68",
            ["3"] = "B07GCKQD77",
        },
        LocationCode = 2840,
        LanguageName = "English",
    }
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

<a id="bingBulkKeywordDifficultyLive"></a>
# **bingBulkKeywordDifficultyLive**
> DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo bingBulkKeywordDifficultyLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.BingBulkKeywordDifficultyLiveAsync(new List<DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "dentist new york",
            "pizza brooklyn",
            "car dealer los angeles",
        },
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo**](DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingBulkTrafficEstimationLive"></a>
# **bingBulkTrafficEstimationLive**
> DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo bingBulkTrafficEstimationLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.BingBulkTrafficEstimationLiveAsync(new List<DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo>()
{
    new()
    {
        Targets = new List<string>()
        {
            "dataforseo.com",
            "cnn.com",
            "forbes.com",
        },
        LocationCode = 2840,
        LanguageCode = "en",
        ItemTypes = new List<string>()
        {
            "organic",
            "paid",
        },
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo**](DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingCompetitorsDomainLive"></a>
# **bingCompetitorsDomainLive**
> DataforseoLabsBingCompetitorsDomainLiveResponseInfo bingCompetitorsDomainLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.BingCompetitorsDomainLiveAsync(new List<DataforseoLabsBingCompetitorsDomainLiveRequestInfo>()
{
    new()
    {
        Target = "newmouth.com",
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 3,
        IntersectingDomains = new List<string>()
        {
            "dentaly.org",
            "health.com",
            "trysnow.com",
        },
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsBingCompetitorsDomainLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsBingCompetitorsDomainLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsBingCompetitorsDomainLiveResponseInfo**](DataforseoLabsBingCompetitorsDomainLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingDomainIntersectionLive"></a>
# **bingDomainIntersectionLive**
> DataforseoLabsBingDomainIntersectionLiveResponseInfo bingDomainIntersectionLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.BingDomainIntersectionLiveAsync(new List<DataforseoLabsBingDomainIntersectionLiveRequestInfo>()
{
    new()
    {
        Target1 = "mom.me",
        Target2 = "quora.com",
        LocationCode = 2840,
        LanguageCode = "en",
        Limit = 5,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsBingDomainIntersectionLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsBingDomainIntersectionLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsBingDomainIntersectionLiveResponseInfo**](DataforseoLabsBingDomainIntersectionLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingDomainRankOverviewLive"></a>
# **bingDomainRankOverviewLive**
> DataforseoLabsBingDomainRankOverviewLiveResponseInfo bingDomainRankOverviewLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.BingDomainRankOverviewLiveAsync(new List<DataforseoLabsBingDomainRankOverviewLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationCode = 2840,
        LanguageName = "English",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsBingDomainRankOverviewLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsBingDomainRankOverviewLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsBingDomainRankOverviewLiveResponseInfo**](DataforseoLabsBingDomainRankOverviewLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingPageIntersectionLive"></a>
# **bingPageIntersectionLive**
> DataforseoLabsBingPageIntersectionLiveResponseInfo bingPageIntersectionLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.BingPageIntersectionLiveAsync(new List<DataforseoLabsBingPageIntersectionLiveRequestInfo>()
{
    new()
    {
        Pages = new Dictionary<string, string>()
        {
            ["1"] = "https://dataforseo.com",
            ["2"] = "https://ahrefs.com/*",
        },
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 3,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsBingPageIntersectionLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsBingPageIntersectionLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsBingPageIntersectionLiveResponseInfo**](DataforseoLabsBingPageIntersectionLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingRankedKeywordsLive"></a>
# **bingRankedKeywordsLive**
> DataforseoLabsBingRankedKeywordsLiveResponseInfo bingRankedKeywordsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.BingRankedKeywordsLiveAsync(new List<DataforseoLabsBingRankedKeywordsLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationName = "United States",
        LanguageName = "English",
        Limit = 3,
        LoadRankAbsolute = true,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsBingRankedKeywordsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsBingRankedKeywordsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsBingRankedKeywordsLiveResponseInfo**](DataforseoLabsBingRankedKeywordsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingRelatedKeywordsLive"></a>
# **bingRelatedKeywordsLive**
> DataforseoLabsBingRelatedKeywordsLiveResponseInfo bingRelatedKeywordsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.BingRelatedKeywordsLiveAsync(new List<DataforseoLabsBingRelatedKeywordsLiveRequestInfo>()
{
    new()
    {
        Keyword = "phone",
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 3,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsBingRelatedKeywordsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsBingRelatedKeywordsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsBingRelatedKeywordsLiveResponseInfo**](DataforseoLabsBingRelatedKeywordsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingRelevantPagesLive"></a>
# **bingRelevantPagesLive**
> DataforseoLabsBingRelevantPagesLiveResponseInfo bingRelevantPagesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.BingRelevantPagesLiveAsync(new List<DataforseoLabsBingRelevantPagesLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 5,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsBingRelevantPagesLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsBingRelevantPagesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsBingRelevantPagesLiveResponseInfo**](DataforseoLabsBingRelevantPagesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingSerpCompetitorsLive"></a>
# **bingSerpCompetitorsLive**
> DataforseoLabsBingSerpCompetitorsLiveResponseInfo bingSerpCompetitorsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.BingSerpCompetitorsLiveAsync(new List<DataforseoLabsBingSerpCompetitorsLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "phone",
        },
        LocationCode = 2840,
        LanguageName = "English",
        ItemTypes = new List<string>()
        {
            "organic",
        },
        Limit = 5,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsBingSerpCompetitorsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsBingSerpCompetitorsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsBingSerpCompetitorsLiveResponseInfo**](DataforseoLabsBingSerpCompetitorsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingSubdomainsLive"></a>
# **bingSubdomainsLive**
> DataforseoLabsBingSubdomainsLiveResponseInfo bingSubdomainsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DataforseoLabsApi.BingSubdomainsLiveAsync(new List<DataforseoLabsBingSubdomainsLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 5,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DataforseoLabsBingSubdomainsLiveRequestInfo>&gt;**](IEnumerable<DataforseoLabsBingSubdomainsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DataforseoLabsBingSubdomainsLiveResponseInfo**](DataforseoLabsBingSubdomainsLiveResponseInfo.md)

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
var result = await dfsClient.DataforseoLabsApi.GoogleBulkAppMetricsLiveAsync(new List<DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo>()
{
    new()
    {
        AppIds = new List<string>()
        {
            "org.telegram.messenger",
            "com.zhiliaoapp.musically",
        },
        LocationCode = 2840,
        LanguageName = "English",
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleKeywordsForAppLiveAsync(new List<DataforseoLabsGoogleKeywordsForAppLiveRequestInfo>()
{
    new()
    {
        AppId = "org.telegram.messenger",
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 10,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleAppCompetitorsLiveAsync(new List<DataforseoLabsGoogleAppCompetitorsLiveRequestInfo>()
{
    new()
    {
        AppId = "org.telegram.messenger",
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 10,
    }
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
var result = await dfsClient.DataforseoLabsApi.GoogleAppIntersectionLiveAsync(new List<DataforseoLabsGoogleAppIntersectionLiveRequestInfo>()
{
    new()
    {
        AppIds = new Dictionary<string, string>()
        {
            ["1"] = "686449807",
            ["2"] = "382617920",
        },
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 10,
    }
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
var result = await dfsClient.DataforseoLabsApi.AppleBulkAppMetricsLiveAsync(new List<DataforseoLabsAppleBulkAppMetricsLiveRequestInfo>()
{
    new()
    {
        AppIds = new List<string>()
        {
            "686449807",
            "382617920",
        },
        LocationCode = 2840,
        LanguageName = "English",
    }
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
var result = await dfsClient.DataforseoLabsApi.AppleKeywordsForAppLiveAsync(new List<DataforseoLabsAppleKeywordsForAppLiveRequestInfo>()
{
    new()
    {
        AppId = "686449807",
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 10,
    }
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
var result = await dfsClient.DataforseoLabsApi.AppleAppCompetitorsLiveAsync(new List<DataforseoLabsAppleAppCompetitorsLiveRequestInfo>()
{
    new()
    {
        AppId = "686449807",
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 10,
    }
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
var result = await dfsClient.DataforseoLabsApi.AppleAppIntersectionLiveAsync(new List<DataforseoLabsAppleAppIntersectionLiveRequestInfo>()
{
    new()
    {
        AppIds = new Dictionary<string, string>()
        {
            ["1"] = "686449807",
            ["2"] = "382617920",
        },
        LocationCode = 2840,
        LanguageName = "English",
        Limit = 10,
    }
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