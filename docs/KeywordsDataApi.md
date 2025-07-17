# KeywordsDataApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**keywordsDataIdList**](KeywordsDataApi.md#keywordsDataIdList) | **POST**  /v3/keywords_data/id_list  |
[**keywordsDataErrors**](KeywordsDataApi.md#keywordsDataErrors) | **POST**  /v3/keywords_data/errors  |
[**googleAdsStatus**](KeywordsDataApi.md#googleAdsStatus) | **GET**  /v3/keywords_data/google_ads/status  |
[**keywordsDataGoogleAdsLocations**](KeywordsDataApi.md#keywordsDataGoogleAdsLocations) | **GET**  /v3/keywords_data/google_ads/locations  |
[**keywordsDataGoogleAdsLocationsCountry**](KeywordsDataApi.md#keywordsDataGoogleAdsLocationsCountry) | **GET**  /v3/keywords_data/google_ads/locations/{country}  |
[**keywordsDataGoogleAdsLanguages**](KeywordsDataApi.md#keywordsDataGoogleAdsLanguages) | **GET**  /v3/keywords_data/google_ads/languages  |
[**googleAdsSearchVolumeTaskPost**](KeywordsDataApi.md#googleAdsSearchVolumeTaskPost) | **POST**  /v3/keywords_data/google_ads/search_volume/task_post  |
[**googleAdsSearchVolumeTasksReady**](KeywordsDataApi.md#googleAdsSearchVolumeTasksReady) | **GET**  /v3/keywords_data/google_ads/search_volume/tasks_ready  |
[**googleAdsSearchVolumeTaskGet**](KeywordsDataApi.md#googleAdsSearchVolumeTaskGet) | **GET**  /v3/keywords_data/google_ads/search_volume/task_get/{id}  |
[**googleAdsSearchVolumeLive**](KeywordsDataApi.md#googleAdsSearchVolumeLive) | **POST**  /v3/keywords_data/google_ads/search_volume/live  |
[**googleAdsKeywordsForSiteTaskPost**](KeywordsDataApi.md#googleAdsKeywordsForSiteTaskPost) | **POST**  /v3/keywords_data/google_ads/keywords_for_site/task_post  |
[**googleAdsKeywordsForSiteTasksReady**](KeywordsDataApi.md#googleAdsKeywordsForSiteTasksReady) | **GET**  /v3/keywords_data/google_ads/keywords_for_site/tasks_ready  |
[**googleAdsKeywordsForSiteTaskGet**](KeywordsDataApi.md#googleAdsKeywordsForSiteTaskGet) | **GET**  /v3/keywords_data/google_ads/keywords_for_site/task_get/{id}  |
[**googleAdsKeywordsForSiteLive**](KeywordsDataApi.md#googleAdsKeywordsForSiteLive) | **POST**  /v3/keywords_data/google_ads/keywords_for_site/live  |
[**googleAdsKeywordsForKeywordsTaskPost**](KeywordsDataApi.md#googleAdsKeywordsForKeywordsTaskPost) | **POST**  /v3/keywords_data/google_ads/keywords_for_keywords/task_post  |
[**googleAdsKeywordsForKeywordsTasksReady**](KeywordsDataApi.md#googleAdsKeywordsForKeywordsTasksReady) | **GET**  /v3/keywords_data/google_ads/keywords_for_keywords/tasks_ready  |
[**googleAdsKeywordsForKeywordsTaskGet**](KeywordsDataApi.md#googleAdsKeywordsForKeywordsTaskGet) | **GET**  /v3/keywords_data/google_ads/keywords_for_keywords/task_get/{id}  |
[**googleAdsKeywordsForKeywordsLive**](KeywordsDataApi.md#googleAdsKeywordsForKeywordsLive) | **POST**  /v3/keywords_data/google_ads/keywords_for_keywords/live  |
[**googleAdsAdTrafficByKeywordsTaskPost**](KeywordsDataApi.md#googleAdsAdTrafficByKeywordsTaskPost) | **POST**  /v3/keywords_data/google_ads/ad_traffic_by_keywords/task_post  |
[**googleAdsAdTrafficByKeywordsTasksReady**](KeywordsDataApi.md#googleAdsAdTrafficByKeywordsTasksReady) | **GET**  /v3/keywords_data/google_ads/ad_traffic_by_keywords/tasks_ready  |
[**googleAdsAdTrafficByKeywordsTaskGet**](KeywordsDataApi.md#googleAdsAdTrafficByKeywordsTaskGet) | **GET**  /v3/keywords_data/google_ads/ad_traffic_by_keywords/task_get/{id}  |
[**googleAdsAdTrafficByKeywordsLive**](KeywordsDataApi.md#googleAdsAdTrafficByKeywordsLive) | **POST**  /v3/keywords_data/google_ads/ad_traffic_by_keywords/live  |
[**keywordsDataGoogleTrendsLocations**](KeywordsDataApi.md#keywordsDataGoogleTrendsLocations) | **GET**  /v3/keywords_data/google_trends/locations  |
[**keywordsDataGoogleTrendsLocationsCountry**](KeywordsDataApi.md#keywordsDataGoogleTrendsLocationsCountry) | **GET**  /v3/keywords_data/google_trends/locations/{country}  |
[**keywordsDataGoogleTrendsLanguages**](KeywordsDataApi.md#keywordsDataGoogleTrendsLanguages) | **GET**  /v3/keywords_data/google_trends/languages  |
[**googleTrendsCategories**](KeywordsDataApi.md#googleTrendsCategories) | **GET**  /v3/keywords_data/google_trends/categories  |
[**googleTrendsExploreTaskPost**](KeywordsDataApi.md#googleTrendsExploreTaskPost) | **POST**  /v3/keywords_data/google_trends/explore/task_post  |
[**googleTrendsExploreTasksReady**](KeywordsDataApi.md#googleTrendsExploreTasksReady) | **GET**  /v3/keywords_data/google_trends/explore/tasks_ready  |
[**googleTrendsExploreTaskGet**](KeywordsDataApi.md#googleTrendsExploreTaskGet) | **GET**  /v3/keywords_data/google_trends/explore/task_get/{id}  |
[**googleTrendsExploreLive**](KeywordsDataApi.md#googleTrendsExploreLive) | **POST**  /v3/keywords_data/google_trends/explore/live  |
[**keywordsDataDataforseoTrendsLocations**](KeywordsDataApi.md#keywordsDataDataforseoTrendsLocations) | **GET**  /v3/keywords_data/dataforseo_trends/locations  |
[**keywordsDataDataforseoTrendsLocationsCountry**](KeywordsDataApi.md#keywordsDataDataforseoTrendsLocationsCountry) | **GET**  /v3/keywords_data/dataforseo_trends/locations/{country}  |
[**dataforseoTrendsExploreLive**](KeywordsDataApi.md#dataforseoTrendsExploreLive) | **POST**  /v3/keywords_data/dataforseo_trends/explore/live  |
[**dataforseoTrendsSubregionInterestsLive**](KeywordsDataApi.md#dataforseoTrendsSubregionInterestsLive) | **POST**  /v3/keywords_data/dataforseo_trends/subregion_interests/live  |
[**dataforseoTrendsDemographyLive**](KeywordsDataApi.md#dataforseoTrendsDemographyLive) | **POST**  /v3/keywords_data/dataforseo_trends/demography/live  |
[**dataforseoTrendsMergedDataLive**](KeywordsDataApi.md#dataforseoTrendsMergedDataLive) | **POST**  /v3/keywords_data/dataforseo_trends/merged_data/live  |
[**keywordsDataBingLocations**](KeywordsDataApi.md#keywordsDataBingLocations) | **GET**  /v3/keywords_data/bing/locations  |
[**keywordsDataBingLanguages**](KeywordsDataApi.md#keywordsDataBingLanguages) | **GET**  /v3/keywords_data/bing/languages  |
[**bingSearchVolumeTaskPost**](KeywordsDataApi.md#bingSearchVolumeTaskPost) | **POST**  /v3/keywords_data/bing/search_volume/task_post  |
[**bingSearchVolumeTasksReady**](KeywordsDataApi.md#bingSearchVolumeTasksReady) | **GET**  /v3/keywords_data/bing/search_volume/tasks_ready  |
[**bingSearchVolumeTaskGet**](KeywordsDataApi.md#bingSearchVolumeTaskGet) | **GET**  /v3/keywords_data/bing/search_volume/task_get/{id}  |
[**bingSearchVolumeLive**](KeywordsDataApi.md#bingSearchVolumeLive) | **POST**  /v3/keywords_data/bing/search_volume/live  |
[**bingAudienceEstimationJobFunctions**](KeywordsDataApi.md#bingAudienceEstimationJobFunctions) | **GET**  /v3/keywords_data/bing/audience_estimation/job_functions  |
[**bingAudienceEstimationIndustries**](KeywordsDataApi.md#bingAudienceEstimationIndustries) | **GET**  /v3/keywords_data/bing/audience_estimation/industries  |
[**bingAudienceEstimationTaskPost**](KeywordsDataApi.md#bingAudienceEstimationTaskPost) | **POST**  /v3/keywords_data/bing/audience_estimation/task_post  |
[**bingAudienceEstimationTasksReady**](KeywordsDataApi.md#bingAudienceEstimationTasksReady) | **GET**  /v3/keywords_data/bing/audience_estimation/tasks_ready  |
[**bingAudienceEstimationTaskGet**](KeywordsDataApi.md#bingAudienceEstimationTaskGet) | **GET**  /v3/keywords_data/bing/audience_estimation/task_get/{id}  |
[**bingAudienceEstimationLive**](KeywordsDataApi.md#bingAudienceEstimationLive) | **POST**  /v3/keywords_data/bing/audience_estimation/live  |
[**bingKeywordsForSiteTaskPost**](KeywordsDataApi.md#bingKeywordsForSiteTaskPost) | **POST**  /v3/keywords_data/bing/keywords_for_site/task_post  |
[**bingKeywordsForSiteTasksReady**](KeywordsDataApi.md#bingKeywordsForSiteTasksReady) | **GET**  /v3/keywords_data/bing/keywords_for_site/tasks_ready  |
[**bingKeywordsForSiteTaskGet**](KeywordsDataApi.md#bingKeywordsForSiteTaskGet) | **GET**  /v3/keywords_data/bing/keywords_for_site/task_get/{id}  |
[**bingKeywordsForSiteLive**](KeywordsDataApi.md#bingKeywordsForSiteLive) | **POST**  /v3/keywords_data/bing/keywords_for_site/live  |
[**bingKeywordsForKeywordsTaskPost**](KeywordsDataApi.md#bingKeywordsForKeywordsTaskPost) | **POST**  /v3/keywords_data/bing/keywords_for_keywords/task_post  |
[**bingKeywordsForKeywordsTasksReady**](KeywordsDataApi.md#bingKeywordsForKeywordsTasksReady) | **GET**  /v3/keywords_data/bing/keywords_for_keywords/tasks_ready  |
[**bingKeywordsForKeywordsTaskGet**](KeywordsDataApi.md#bingKeywordsForKeywordsTaskGet) | **GET**  /v3/keywords_data/bing/keywords_for_keywords/task_get/{id}  |
[**bingKeywordsForKeywordsLive**](KeywordsDataApi.md#bingKeywordsForKeywordsLive) | **POST**  /v3/keywords_data/bing/keywords_for_keywords/live  |
[**keywordsDataBingKeywordPerformanceLocationsAndLanguages**](KeywordsDataApi.md#keywordsDataBingKeywordPerformanceLocationsAndLanguages) | **GET**  /v3/keywords_data/bing/keyword_performance/locations_and_languages  |
[**bingKeywordPerformanceTaskPost**](KeywordsDataApi.md#bingKeywordPerformanceTaskPost) | **POST**  /v3/keywords_data/bing/keyword_performance/task_post  |
[**bingKeywordPerformanceTasksReady**](KeywordsDataApi.md#bingKeywordPerformanceTasksReady) | **GET**  /v3/keywords_data/bing/keyword_performance/tasks_ready  |
[**bingKeywordPerformanceTaskGet**](KeywordsDataApi.md#bingKeywordPerformanceTaskGet) | **GET**  /v3/keywords_data/bing/keyword_performance/task_get/{id}  |
[**bingKeywordPerformanceLive**](KeywordsDataApi.md#bingKeywordPerformanceLive) | **POST**  /v3/keywords_data/bing/keyword_performance/live  |
[**keywordsDataBingSearchVolumeHistoryLocationsAndLanguages**](KeywordsDataApi.md#keywordsDataBingSearchVolumeHistoryLocationsAndLanguages) | **GET**  /v3/keywords_data/bing/search_volume_history/locations_and_languages  |
[**bingSearchVolumeHistoryTaskPost**](KeywordsDataApi.md#bingSearchVolumeHistoryTaskPost) | **POST**  /v3/keywords_data/bing/search_volume_history/task_post  |
[**bingSearchVolumeHistoryTasksReady**](KeywordsDataApi.md#bingSearchVolumeHistoryTasksReady) | **GET**  /v3/keywords_data/bing/search_volume_history/tasks_ready  |
[**bingSearchVolumeHistoryTaskGet**](KeywordsDataApi.md#bingSearchVolumeHistoryTaskGet) | **GET**  /v3/keywords_data/bing/search_volume_history/task_get/{id}  |
[**bingSearchVolumeHistoryLive**](KeywordsDataApi.md#bingSearchVolumeHistoryLive) | **POST**  /v3/keywords_data/bing/search_volume_history/live  |
[**keywordsDataClickstreamDataLocationsAndLanguages**](KeywordsDataApi.md#keywordsDataClickstreamDataLocationsAndLanguages) | **GET**  /v3/keywords_data/clickstream_data/locations_and_languages  |
[**clickstreamDataDataforseoSearchVolumeLive**](KeywordsDataApi.md#clickstreamDataDataforseoSearchVolumeLive) | **POST**  /v3/keywords_data/clickstream_data/dataforseo_search_volume/live  |
[**clickstreamDataGlobalSearchVolumeLive**](KeywordsDataApi.md#clickstreamDataGlobalSearchVolumeLive) | **POST**  /v3/keywords_data/clickstream_data/global_search_volume/live  |
[**clickstreamDataBulkSearchVolumeLive**](KeywordsDataApi.md#clickstreamDataBulkSearchVolumeLive) | **POST**  /v3/keywords_data/clickstream_data/bulk_search_volume/live  |

<a id="keywordsDataIdList"></a>
# **keywordsDataIdList**
> KeywordsDataIdListResponseInfo keywordsDataIdList()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataIdListAsync(new List<KeywordsDataIdListRequestInfo>()
{
    new()
    {
        DatetimeFrom = "2025-04-17 06:08:20 +00:00",
        DatetimeTo = "2025-06-17 06:08:20 +00:00",
        Limit = 100,
        Offset = 0,
        Sort = "desc",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataIdListRequestInfo>&gt;**](IEnumerable<KeywordsDataIdListRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataIdListResponseInfo**](KeywordsDataIdListResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataErrors"></a>
# **keywordsDataErrors**
> KeywordsDataErrorsResponseInfo keywordsDataErrors()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataErrorsAsync(new List<KeywordsDataErrorsRequestInfo>()
{
    new()
    {
        Limit = 10,
        Offset = 0,
        FilteredFunction = "pingback_url",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataErrorsRequestInfo>&gt;**](IEnumerable<KeywordsDataErrorsRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataErrorsResponseInfo**](KeywordsDataErrorsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsStatus"></a>
# **googleAdsStatus**
> KeywordsDataGoogleAdsStatusResponseInfo googleAdsStatus()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsStatusAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsStatusResponseInfo**](KeywordsDataGoogleAdsStatusResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataGoogleAdsLocations"></a>
# **keywordsDataGoogleAdsLocations**
> KeywordsDataGoogleAdsLocationsResponseInfo keywordsDataGoogleAdsLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataGoogleAdsLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsLocationsResponseInfo**](KeywordsDataGoogleAdsLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataGoogleAdsLocationsCountry"></a>
# **keywordsDataGoogleAdsLocationsCountry**
> KeywordsDataGoogleAdsLocationsCountryResponseInfo keywordsDataGoogleAdsLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.KeywordsDataApi.KeywordsDataGoogleAdsLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsLocationsCountryResponseInfo**](KeywordsDataGoogleAdsLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataGoogleAdsLanguages"></a>
# **keywordsDataGoogleAdsLanguages**
> KeywordsDataGoogleAdsLanguagesResponseInfo keywordsDataGoogleAdsLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataGoogleAdsLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsLanguagesResponseInfo**](KeywordsDataGoogleAdsLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsSearchVolumeTaskPost"></a>
# **googleAdsSearchVolumeTaskPost**
> KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo googleAdsSearchVolumeTaskPost()


### Example
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
        Keywords = new List<string>()
        {
            "buy laptop",
            "cheap laptops for sale",
            "purchase laptop",
        },
        LocationName = "United States",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataGoogleAdsSearchVolumeTaskPostRequestInfo>&gt;**](IEnumerable<KeywordsDataGoogleAdsSearchVolumeTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo**](KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsSearchVolumeTasksReady"></a>
# **googleAdsSearchVolumeTasksReady**
> KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo googleAdsSearchVolumeTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsSearchVolumeTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo**](KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsSearchVolumeTaskGet"></a>
# **googleAdsSearchVolumeTaskGet**
> KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo googleAdsSearchVolumeTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "cd8d055b-efc0-488d-a90a-7422f6f03521";
var result = await dfsClient.KeywordsDataApi.GoogleAdsSearchVolumeTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo**](KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsSearchVolumeLive"></a>
# **googleAdsSearchVolumeLive**
> KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo googleAdsSearchVolumeLive()


### Example
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
        Keywords = new List<string>()
        {
            "buy laptop",
            "cheap laptops for sale",
            "purchase laptop",
        },
        LocationCode = 2840,
        SearchPartners = true,
        DateFrom = "2025-04-17",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataGoogleAdsSearchVolumeLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataGoogleAdsSearchVolumeLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo**](KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsKeywordsForSiteTaskPost"></a>
# **googleAdsKeywordsForSiteTaskPost**
> KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo googleAdsKeywordsForSiteTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForSiteTaskPostAsync(new List<KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationCode = 2840,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo>&gt;**](IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo**](KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsKeywordsForSiteTasksReady"></a>
# **googleAdsKeywordsForSiteTasksReady**
> KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo googleAdsKeywordsForSiteTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForSiteTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo**](KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsKeywordsForSiteTaskGet"></a>
# **googleAdsKeywordsForSiteTaskGet**
> KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo googleAdsKeywordsForSiteTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "808ccc62-77f2-413d-985a-62c975562c92";
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForSiteTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo**](KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsKeywordsForSiteLive"></a>
# **googleAdsKeywordsForSiteLive**
> KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo googleAdsKeywordsForSiteLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForSiteLiveAsync(new List<KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationCode = 2840,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo**](KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsKeywordsForKeywordsTaskPost"></a>
# **googleAdsKeywordsForKeywordsTaskPost**
> KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo googleAdsKeywordsForKeywordsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForKeywordsTaskPostAsync(new List<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "phone",
            "cellphone",
        },
        LocationCode = 2840,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo>&gt;**](IEnumerable<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo**](KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsKeywordsForKeywordsTasksReady"></a>
# **googleAdsKeywordsForKeywordsTasksReady**
> KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo googleAdsKeywordsForKeywordsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForKeywordsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo**](KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsKeywordsForKeywordsTaskGet"></a>
# **googleAdsKeywordsForKeywordsTaskGet**
> KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo googleAdsKeywordsForKeywordsTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "fa3783b5-c9c6-4de3-9288-4898ae9490e4";
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForKeywordsTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo**](KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsKeywordsForKeywordsLive"></a>
# **googleAdsKeywordsForKeywordsLive**
> KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo googleAdsKeywordsForKeywordsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForKeywordsLiveAsync(new List<KeywordsDataGoogleAdsKeywordsForKeywordsLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "phone",
            "cellphone",
        },
        LocationCode = 2840,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataGoogleAdsKeywordsForKeywordsLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataGoogleAdsKeywordsForKeywordsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo**](KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsAdTrafficByKeywordsTaskPost"></a>
# **googleAdsAdTrafficByKeywordsTaskPost**
> KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo googleAdsAdTrafficByKeywordsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsAdTrafficByKeywordsTaskPostAsync(new List<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "seo marketing",
        },
        Bid = 999,
        Match = "exact",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo>&gt;**](IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo**](KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsAdTrafficByKeywordsTasksReady"></a>
# **googleAdsAdTrafficByKeywordsTasksReady**
> KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo googleAdsAdTrafficByKeywordsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsAdTrafficByKeywordsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo**](KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsAdTrafficByKeywordsTaskGet"></a>
# **googleAdsAdTrafficByKeywordsTaskGet**
> KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo googleAdsAdTrafficByKeywordsTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "2fefd35b-ddcd-425a-88d2-523fd333c10b";
var result = await dfsClient.KeywordsDataApi.GoogleAdsAdTrafficByKeywordsTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo**](KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAdsAdTrafficByKeywordsLive"></a>
# **googleAdsAdTrafficByKeywordsLive**
> KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo googleAdsAdTrafficByKeywordsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsAdTrafficByKeywordsLiveAsync(new List<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "seo marketing",
        },
        Bid = 999,
        Match = "exact",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo**](KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataGoogleTrendsLocations"></a>
# **keywordsDataGoogleTrendsLocations**
> KeywordsDataGoogleTrendsLocationsResponseInfo keywordsDataGoogleTrendsLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataGoogleTrendsLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleTrendsLocationsResponseInfo**](KeywordsDataGoogleTrendsLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataGoogleTrendsLocationsCountry"></a>
# **keywordsDataGoogleTrendsLocationsCountry**
> KeywordsDataGoogleTrendsLocationsCountryResponseInfo keywordsDataGoogleTrendsLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.KeywordsDataApi.KeywordsDataGoogleTrendsLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleTrendsLocationsCountryResponseInfo**](KeywordsDataGoogleTrendsLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataGoogleTrendsLanguages"></a>
# **keywordsDataGoogleTrendsLanguages**
> KeywordsDataGoogleTrendsLanguagesResponseInfo keywordsDataGoogleTrendsLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataGoogleTrendsLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleTrendsLanguagesResponseInfo**](KeywordsDataGoogleTrendsLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleTrendsCategories"></a>
# **googleTrendsCategories**
> KeywordsDataGoogleTrendsCategoriesResponseInfo googleTrendsCategories()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleTrendsCategoriesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleTrendsCategoriesResponseInfo**](KeywordsDataGoogleTrendsCategoriesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleTrendsExploreTaskPost"></a>
# **googleTrendsExploreTaskPost**
> KeywordsDataGoogleTrendsExploreTaskPostResponseInfo googleTrendsExploreTaskPost()


### Example
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
        Keywords = new List<string>()
        {
            "seo api",
            "rank api",
        },
        Type = "youtube",
        CategoryCode = 3,
        DateFrom = "2025-04-17",
        DateTo = "2025-06-17",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataGoogleTrendsExploreTaskPostRequestInfo>&gt;**](IEnumerable<KeywordsDataGoogleTrendsExploreTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataGoogleTrendsExploreTaskPostResponseInfo**](KeywordsDataGoogleTrendsExploreTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleTrendsExploreTasksReady"></a>
# **googleTrendsExploreTasksReady**
> KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo googleTrendsExploreTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleTrendsExploreTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo**](KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleTrendsExploreTaskGet"></a>
# **googleTrendsExploreTaskGet**
> KeywordsDataGoogleTrendsExploreTaskGetResponseInfo googleTrendsExploreTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "41f93df3-f107-4caa-a683-d907feaa7db3";
var result = await dfsClient.KeywordsDataApi.GoogleTrendsExploreTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataGoogleTrendsExploreTaskGetResponseInfo**](KeywordsDataGoogleTrendsExploreTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleTrendsExploreLive"></a>
# **googleTrendsExploreLive**
> KeywordsDataGoogleTrendsExploreLiveResponseInfo googleTrendsExploreLive()


### Example
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
        Keywords = new List<string>()
        {
            "rugby",
            "cricket",
        },
        LocationName = "United States",
        Type = "youtube",
        CategoryCode = 3,
        DateFrom = "2025-04-17",
        DateTo = "2025-06-17",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataGoogleTrendsExploreLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataGoogleTrendsExploreLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataGoogleTrendsExploreLiveResponseInfo**](KeywordsDataGoogleTrendsExploreLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataDataforseoTrendsLocations"></a>
# **keywordsDataDataforseoTrendsLocations**
> KeywordsDataDataforseoTrendsLocationsResponseInfo keywordsDataDataforseoTrendsLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataDataforseoTrendsLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataDataforseoTrendsLocationsResponseInfo**](KeywordsDataDataforseoTrendsLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataDataforseoTrendsLocationsCountry"></a>
# **keywordsDataDataforseoTrendsLocationsCountry**
> KeywordsDataDataforseoTrendsLocationsCountryResponseInfo keywordsDataDataforseoTrendsLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.KeywordsDataApi.KeywordsDataDataforseoTrendsLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataDataforseoTrendsLocationsCountryResponseInfo**](KeywordsDataDataforseoTrendsLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="dataforseoTrendsExploreLive"></a>
# **dataforseoTrendsExploreLive**
> KeywordsDataDataforseoTrendsExploreLiveResponseInfo dataforseoTrendsExploreLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.DataforseoTrendsExploreLiveAsync(new List<KeywordsDataDataforseoTrendsExploreLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "iphone 14",
            "samsung s23",
        },
        LocationCode = 2840,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataDataforseoTrendsExploreLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataDataforseoTrendsExploreLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataDataforseoTrendsExploreLiveResponseInfo**](KeywordsDataDataforseoTrendsExploreLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="dataforseoTrendsSubregionInterestsLive"></a>
# **dataforseoTrendsSubregionInterestsLive**
> KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo dataforseoTrendsSubregionInterestsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.DataforseoTrendsSubregionInterestsLiveAsync(new List<KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "rugby",
            "cricket",
        },
        LocationName = "United States",
        Type = "web",
        DateFrom = "2025-04-17",
        DateTo = "2025-06-17",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo**](KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="dataforseoTrendsDemographyLive"></a>
# **dataforseoTrendsDemographyLive**
> KeywordsDataDataforseoTrendsDemographyLiveResponseInfo dataforseoTrendsDemographyLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.DataforseoTrendsDemographyLiveAsync(new List<KeywordsDataDataforseoTrendsDemographyLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "rugby",
            "cricket",
        },
        LocationName = "United States",
        Type = "web",
        DateFrom = "2025-04-17",
        DateTo = "2025-06-17",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataDataforseoTrendsDemographyLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataDataforseoTrendsDemographyLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataDataforseoTrendsDemographyLiveResponseInfo**](KeywordsDataDataforseoTrendsDemographyLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="dataforseoTrendsMergedDataLive"></a>
# **dataforseoTrendsMergedDataLive**
> KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo dataforseoTrendsMergedDataLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.DataforseoTrendsMergedDataLiveAsync(new List<KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "rugby",
            "cricket",
        },
        LocationName = "United States",
        Type = "web",
        DateFrom = "2025-04-17",
        DateTo = "2025-06-17",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo**](KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataBingLocations"></a>
# **keywordsDataBingLocations**
> KeywordsDataBingLocationsResponseInfo keywordsDataBingLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataBingLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingLocationsResponseInfo**](KeywordsDataBingLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataBingLanguages"></a>
# **keywordsDataBingLanguages**
> KeywordsDataBingLanguagesResponseInfo keywordsDataBingLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataBingLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingLanguagesResponseInfo**](KeywordsDataBingLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingSearchVolumeTaskPost"></a>
# **bingSearchVolumeTaskPost**
> KeywordsDataBingSearchVolumeTaskPostResponseInfo bingSearchVolumeTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeTaskPostAsync(new List<KeywordsDataBingSearchVolumeTaskPostRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "average page rpm adsense",
            "adsense blank ads how long",
            "leads and prospects",
        },
        LocationName = "United States",
        LanguageName = "English",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingSearchVolumeTaskPostRequestInfo>&gt;**](IEnumerable<KeywordsDataBingSearchVolumeTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingSearchVolumeTaskPostResponseInfo**](KeywordsDataBingSearchVolumeTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingSearchVolumeTasksReady"></a>
# **bingSearchVolumeTasksReady**
> KeywordsDataBingSearchVolumeTasksReadyResponseInfo bingSearchVolumeTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingSearchVolumeTasksReadyResponseInfo**](KeywordsDataBingSearchVolumeTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingSearchVolumeTaskGet"></a>
# **bingSearchVolumeTaskGet**
> KeywordsDataBingSearchVolumeTaskGetResponseInfo bingSearchVolumeTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "90124676-c060-4ece-af1c-e4610493f5d2";
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingSearchVolumeTaskGetResponseInfo**](KeywordsDataBingSearchVolumeTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingSearchVolumeLive"></a>
# **bingSearchVolumeLive**
> KeywordsDataBingSearchVolumeLiveResponseInfo bingSearchVolumeLive()


### Example
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
        Keywords = new List<string>()
        {
            "tom and jerry",
            "silicon valley",
            "spider man",
        },
        LocationName = "United States",
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingSearchVolumeLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataBingSearchVolumeLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingSearchVolumeLiveResponseInfo**](KeywordsDataBingSearchVolumeLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingAudienceEstimationJobFunctions"></a>
# **bingAudienceEstimationJobFunctions**
> KeywordsDataBingAudienceEstimationJobFunctionsResponseInfo bingAudienceEstimationJobFunctions()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingAudienceEstimationJobFunctionsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingAudienceEstimationJobFunctionsResponseInfo**](KeywordsDataBingAudienceEstimationJobFunctionsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingAudienceEstimationIndustries"></a>
# **bingAudienceEstimationIndustries**
> KeywordsDataBingAudienceEstimationIndustriesResponseInfo bingAudienceEstimationIndustries()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingAudienceEstimationIndustriesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingAudienceEstimationIndustriesResponseInfo**](KeywordsDataBingAudienceEstimationIndustriesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingAudienceEstimationTaskPost"></a>
# **bingAudienceEstimationTaskPost**
> KeywordsDataBingAudienceEstimationTaskPostResponseInfo bingAudienceEstimationTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingAudienceEstimationTaskPostAsync(new List<KeywordsDataBingAudienceEstimationTaskPostRequestInfo>()
{
    new()
    {
        LocationCoordinate = "29.6821525,-82.4098881,100",
        Age = new List<string>()
        {
            "twenty_five_to_thirty_four",
            "eighteen_to_twenty_four",
            "unknown",
        },
        Bid = 1,
        DailyBudget = 24,
        Gender = new List<string>()
        {
            "male",
        },
        Industry = new List<string>()
        {
            "806303407",
            "806301758",
        },
        JobFunction = new List<string>()
        {
            "806298607",
        },
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingAudienceEstimationTaskPostRequestInfo>&gt;**](IEnumerable<KeywordsDataBingAudienceEstimationTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingAudienceEstimationTaskPostResponseInfo**](KeywordsDataBingAudienceEstimationTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingAudienceEstimationTasksReady"></a>
# **bingAudienceEstimationTasksReady**
> KeywordsDataBingAudienceEstimationTasksReadyResponseInfo bingAudienceEstimationTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingAudienceEstimationTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingAudienceEstimationTasksReadyResponseInfo**](KeywordsDataBingAudienceEstimationTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingAudienceEstimationTaskGet"></a>
# **bingAudienceEstimationTaskGet**
> KeywordsDataBingAudienceEstimationTaskGetResponseInfo bingAudienceEstimationTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "678a7766-a39c-4cb8-bdc6-3b87cbb82b3d";
var result = await dfsClient.KeywordsDataApi.BingAudienceEstimationTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingAudienceEstimationTaskGetResponseInfo**](KeywordsDataBingAudienceEstimationTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingAudienceEstimationLive"></a>
# **bingAudienceEstimationLive**
> KeywordsDataBingAudienceEstimationLiveResponseInfo bingAudienceEstimationLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingAudienceEstimationLiveAsync(new List<KeywordsDataBingAudienceEstimationLiveRequestInfo>()
{
    new()
    {
        LocationCoordinate = "29.6821525,-82.4098881,100",
        Age = new List<string>()
        {
            "twenty_five_to_thirty_four",
            "eighteen_to_twenty_four",
            "unknown",
        },
        Bid = 1,
        DailyBudget = 24,
        Gender = new List<string>()
        {
            "male",
        },
        Industry = new List<string>()
        {
            "806303407",
            "806301758",
        },
        JobFunction = new List<string>()
        {
            "806298607",
        },
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingAudienceEstimationLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataBingAudienceEstimationLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingAudienceEstimationLiveResponseInfo**](KeywordsDataBingAudienceEstimationLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordsForSiteTaskPost"></a>
# **bingKeywordsForSiteTaskPost**
> KeywordsDataBingKeywordsForSiteTaskPostResponseInfo bingKeywordsForSiteTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingKeywordsForSiteTaskPostAsync(new List<KeywordsDataBingKeywordsForSiteTaskPostRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingKeywordsForSiteTaskPostRequestInfo>&gt;**](IEnumerable<KeywordsDataBingKeywordsForSiteTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingKeywordsForSiteTaskPostResponseInfo**](KeywordsDataBingKeywordsForSiteTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordsForSiteTasksReady"></a>
# **bingKeywordsForSiteTasksReady**
> KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo bingKeywordsForSiteTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingKeywordsForSiteTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo**](KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordsForSiteTaskGet"></a>
# **bingKeywordsForSiteTaskGet**
> KeywordsDataBingKeywordsForSiteTaskGetResponseInfo bingKeywordsForSiteTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "c543528c-53d4-4694-ba0d-1a0b3234bac5";
var result = await dfsClient.KeywordsDataApi.BingKeywordsForSiteTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingKeywordsForSiteTaskGetResponseInfo**](KeywordsDataBingKeywordsForSiteTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordsForSiteLive"></a>
# **bingKeywordsForSiteLive**
> KeywordsDataBingKeywordsForSiteLiveResponseInfo bingKeywordsForSiteLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingKeywordsForSiteLiveAsync(new List<KeywordsDataBingKeywordsForSiteLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingKeywordsForSiteLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataBingKeywordsForSiteLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingKeywordsForSiteLiveResponseInfo**](KeywordsDataBingKeywordsForSiteLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordsForKeywordsTaskPost"></a>
# **bingKeywordsForKeywordsTaskPost**
> KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo bingKeywordsForKeywordsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingKeywordsForKeywordsTaskPostAsync(new List<KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "average page rpm adsense",
            "adsense blank ads how long",
            "leads and prospects",
        },
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo>&gt;**](IEnumerable<KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo**](KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordsForKeywordsTasksReady"></a>
# **bingKeywordsForKeywordsTasksReady**
> KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo bingKeywordsForKeywordsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingKeywordsForKeywordsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo**](KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordsForKeywordsTaskGet"></a>
# **bingKeywordsForKeywordsTaskGet**
> KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo bingKeywordsForKeywordsTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "590a0c65-6eb0-40cb-8db3-48c9ea64028b";
var result = await dfsClient.KeywordsDataApi.BingKeywordsForKeywordsTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo**](KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordsForKeywordsLive"></a>
# **bingKeywordsForKeywordsLive**
> KeywordsDataBingKeywordsForKeywordsLiveResponseInfo bingKeywordsForKeywordsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingKeywordsForKeywordsLiveAsync(new List<KeywordsDataBingKeywordsForKeywordsLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "average page rpm adsense",
            "adsense blank ads how long",
            "leads and prospects",
        },
        LocationName = "United States",
        LanguageName = "English",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingKeywordsForKeywordsLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataBingKeywordsForKeywordsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingKeywordsForKeywordsLiveResponseInfo**](KeywordsDataBingKeywordsForKeywordsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataBingKeywordPerformanceLocationsAndLanguages"></a>
# **keywordsDataBingKeywordPerformanceLocationsAndLanguages**
> KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo keywordsDataBingKeywordPerformanceLocationsAndLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataBingKeywordPerformanceLocationsAndLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo**](KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordPerformanceTaskPost"></a>
# **bingKeywordPerformanceTaskPost**
> KeywordsDataBingKeywordPerformanceTaskPostResponseInfo bingKeywordPerformanceTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingKeywordPerformanceTaskPostAsync(new List<KeywordsDataBingKeywordPerformanceTaskPostRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "dataforseo",
            "seo",
            "ranking",
        },
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingKeywordPerformanceTaskPostRequestInfo>&gt;**](IEnumerable<KeywordsDataBingKeywordPerformanceTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingKeywordPerformanceTaskPostResponseInfo**](KeywordsDataBingKeywordPerformanceTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordPerformanceTasksReady"></a>
# **bingKeywordPerformanceTasksReady**
> KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo bingKeywordPerformanceTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingKeywordPerformanceTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo**](KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordPerformanceTaskGet"></a>
# **bingKeywordPerformanceTaskGet**
> KeywordsDataBingKeywordPerformanceTaskGetResponseInfo bingKeywordPerformanceTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "a4da66d6-e62b-4bde-b11b-5c2b6775f89a";
var result = await dfsClient.KeywordsDataApi.BingKeywordPerformanceTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingKeywordPerformanceTaskGetResponseInfo**](KeywordsDataBingKeywordPerformanceTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingKeywordPerformanceLive"></a>
# **bingKeywordPerformanceLive**
> KeywordsDataBingKeywordPerformanceLiveResponseInfo bingKeywordPerformanceLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingKeywordPerformanceLiveAsync(new List<KeywordsDataBingKeywordPerformanceLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "dataforseo",
            "seo",
            "ranking",
        },
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingKeywordPerformanceLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataBingKeywordPerformanceLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingKeywordPerformanceLiveResponseInfo**](KeywordsDataBingKeywordPerformanceLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataBingSearchVolumeHistoryLocationsAndLanguages"></a>
# **keywordsDataBingSearchVolumeHistoryLocationsAndLanguages**
> KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo keywordsDataBingSearchVolumeHistoryLocationsAndLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo**](KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingSearchVolumeHistoryTaskPost"></a>
# **bingSearchVolumeHistoryTaskPost**
> KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo bingSearchVolumeHistoryTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeHistoryTaskPostAsync(new List<KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "10 minute timer",
        },
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo>&gt;**](IEnumerable<KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo**](KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingSearchVolumeHistoryTasksReady"></a>
# **bingSearchVolumeHistoryTasksReady**
> KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo bingSearchVolumeHistoryTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeHistoryTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo**](KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingSearchVolumeHistoryTaskGet"></a>
# **bingSearchVolumeHistoryTaskGet**
> KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo bingSearchVolumeHistoryTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "b09a55a7-59b3-4355-a5fd-2800894e9480";
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeHistoryTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo**](KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bingSearchVolumeHistoryLive"></a>
# **bingSearchVolumeHistoryLive**
> KeywordsDataBingSearchVolumeHistoryLiveResponseInfo bingSearchVolumeHistoryLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeHistoryLiveAsync(new List<KeywordsDataBingSearchVolumeHistoryLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "10 minute timer",
        },
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataBingSearchVolumeHistoryLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataBingSearchVolumeHistoryLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataBingSearchVolumeHistoryLiveResponseInfo**](KeywordsDataBingSearchVolumeHistoryLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="keywordsDataClickstreamDataLocationsAndLanguages"></a>
# **keywordsDataClickstreamDataLocationsAndLanguages**
> KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo keywordsDataClickstreamDataLocationsAndLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.KeywordsDataClickstreamDataLocationsAndLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo**](KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="clickstreamDataDataforseoSearchVolumeLive"></a>
# **clickstreamDataDataforseoSearchVolumeLive**
> KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo clickstreamDataDataforseoSearchVolumeLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.ClickstreamDataDataforseoSearchVolumeLiveAsync(new List<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "you tube",
            "youtube",
            "youtub",
        },
        LocationCode = 2840,
        LanguageCode = "en",
        Tag = "test-tag",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo**](KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="clickstreamDataGlobalSearchVolumeLive"></a>
# **clickstreamDataGlobalSearchVolumeLive**
> KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo clickstreamDataGlobalSearchVolumeLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.ClickstreamDataGlobalSearchVolumeLiveAsync(new List<KeywordsDataClickstreamDataGlobalSearchVolumeLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "you tube",
            "youtube",
            "youtub",
        },
        Tag = "test-tag",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataClickstreamDataGlobalSearchVolumeLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataClickstreamDataGlobalSearchVolumeLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo**](KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="clickstreamDataBulkSearchVolumeLive"></a>
# **clickstreamDataBulkSearchVolumeLive**
> KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo clickstreamDataBulkSearchVolumeLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.ClickstreamDataBulkSearchVolumeLiveAsync(new List<KeywordsDataClickstreamDataBulkSearchVolumeLiveRequestInfo>()
{
    new()
    {
        Keywords = new List<string>()
        {
            "you tube",
            "youtube",
            "youtub",
        },
        LocationCode = 2840,
        Tag = "test-tag",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<KeywordsDataClickstreamDataBulkSearchVolumeLiveRequestInfo>&gt;**](IEnumerable<KeywordsDataClickstreamDataBulkSearchVolumeLiveRequestInfo>.md)|  | [optional] |



### Return type

[**KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo**](KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |