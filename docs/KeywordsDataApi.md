# KeywordsDataApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**keywordsDataIdList**](KeywordsDataApi.md#keywordsDataIdList) | **POST**  /v3/keywords_data/id_list  |
[**keywordsDataErrors**](KeywordsDataApi.md#keywordsDataErrors) | **POST**  /v3/keywords_data/errors  |
[**googleAdsStatus**](KeywordsDataApi.md#googleAdsStatus) | **GET**  /v3/keywords_data/google_ads/status  |
[**googleAdsLocations**](KeywordsDataApi.md#googleAdsLocations) | **GET**  /v3/keywords_data/google_ads/locations  |
[**googleAdsLocationsCountry**](KeywordsDataApi.md#googleAdsLocationsCountry) | **GET**  /v3/keywords_data/google_ads/locations/{country}  |
[**googleAdsLanguages**](KeywordsDataApi.md#googleAdsLanguages) | **GET**  /v3/keywords_data/google_ads/languages  |
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
[**googleTrendsLocations**](KeywordsDataApi.md#googleTrendsLocations) | **GET**  /v3/keywords_data/google_trends/locations  |
[**googleTrendsLocationsCountry**](KeywordsDataApi.md#googleTrendsLocationsCountry) | **GET**  /v3/keywords_data/google_trends/locations/{country}  |
[**googleTrendsLanguages**](KeywordsDataApi.md#googleTrendsLanguages) | **GET**  /v3/keywords_data/google_trends/languages  |
[**googleTrendsCategories**](KeywordsDataApi.md#googleTrendsCategories) | **GET**  /v3/keywords_data/google_trends/categories  |
[**googleTrendsExploreTaskPost**](KeywordsDataApi.md#googleTrendsExploreTaskPost) | **POST**  /v3/keywords_data/google_trends/explore/task_post  |
[**googleTrendsExploreTasksReady**](KeywordsDataApi.md#googleTrendsExploreTasksReady) | **GET**  /v3/keywords_data/google_trends/explore/tasks_ready  |
[**googleTrendsExploreTaskGet**](KeywordsDataApi.md#googleTrendsExploreTaskGet) | **GET**  /v3/keywords_data/google_trends/explore/task_get/{id}  |
[**googleTrendsExploreLive**](KeywordsDataApi.md#googleTrendsExploreLive) | **POST**  /v3/keywords_data/google_trends/explore/live  |
[**dataforseoTrendsLocations**](KeywordsDataApi.md#dataforseoTrendsLocations) | **GET**  /v3/keywords_data/dataforseo_trends/locations  |
[**dataforseoTrendsLocationsCountry**](KeywordsDataApi.md#dataforseoTrendsLocationsCountry) | **GET**  /v3/keywords_data/dataforseo_trends/locations/{country}  |
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
[**bingKeywordPerformanceLocationsAndLanguages**](KeywordsDataApi.md#bingKeywordPerformanceLocationsAndLanguages) | **GET**  /v3/keywords_data/bing/keyword_performance/locations_and_languages  |
[**bingKeywordPerformanceTaskPost**](KeywordsDataApi.md#bingKeywordPerformanceTaskPost) | **POST**  /v3/keywords_data/bing/keyword_performance/task_post  |
[**bingKeywordPerformanceTasksReady**](KeywordsDataApi.md#bingKeywordPerformanceTasksReady) | **GET**  /v3/keywords_data/bing/keyword_performance/tasks_ready  |
[**bingKeywordPerformanceTaskGet**](KeywordsDataApi.md#bingKeywordPerformanceTaskGet) | **GET**  /v3/keywords_data/bing/keyword_performance/task_get/{id}  |
[**bingKeywordPerformanceLive**](KeywordsDataApi.md#bingKeywordPerformanceLive) | **POST**  /v3/keywords_data/bing/keyword_performance/live  |
[**bingSearchVolumeHistoryLocationsAndLanguages**](KeywordsDataApi.md#bingSearchVolumeHistoryLocationsAndLanguages) | **GET**  /v3/keywords_data/bing/search_volume_history/locations_and_languages  |
[**bingSearchVolumeHistoryTaskPost**](KeywordsDataApi.md#bingSearchVolumeHistoryTaskPost) | **POST**  /v3/keywords_data/bing/search_volume_history/task_post  |
[**bingSearchVolumeHistoryTasksReady**](KeywordsDataApi.md#bingSearchVolumeHistoryTasksReady) | **GET**  /v3/keywords_data/bing/search_volume_history/tasks_ready  |
[**bingSearchVolumeHistoryTaskGet**](KeywordsDataApi.md#bingSearchVolumeHistoryTaskGet) | **GET**  /v3/keywords_data/bing/search_volume_history/task_get/{id}  |
[**bingSearchVolumeHistoryLive**](KeywordsDataApi.md#bingSearchVolumeHistoryLive) | **POST**  /v3/keywords_data/bing/search_volume_history/live  |
[**clickstreamDataLocationsAndLanguages**](KeywordsDataApi.md#clickstreamDataLocationsAndLanguages) | **GET**  /v3/keywords_data/clickstream_data/locations_and_languages  |
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
var result = await dfsClient.KeywordsDataApi.KeywordsDataIdListAsync(
    new KeywordsDataIdListRequestInfo[]
    {
        new KeywordsDataIdListRequestInfo()
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
var result = await dfsClient.KeywordsDataApi.KeywordsDataErrorsAsync(
    new KeywordsDataErrorsRequestInfo[]
    {
        new KeywordsDataErrorsRequestInfo()
        {
            Limit = 10,
            Offset = 0,
            FilteredFunction = "pingback_url",
        },
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

<a id="googleAdsLocations"></a>
# **googleAdsLocations**
> KeywordsDataGoogleAdsLocationsResponseInfo googleAdsLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsLocationsAsync();
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

<a id="googleAdsLocationsCountry"></a>
# **googleAdsLocationsCountry**
> KeywordsDataGoogleAdsLocationsCountryResponseInfo googleAdsLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.KeywordsDataApi.GoogleAdsLocationsCountryAsync(country);
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

<a id="googleAdsLanguages"></a>
# **googleAdsLanguages**
> KeywordsDataGoogleAdsLanguagesResponseInfo googleAdsLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleAdsLanguagesAsync();
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
var result = await dfsClient.KeywordsDataApi.GoogleAdsSearchVolumeTaskPostAsync(
    new KeywordsDataGoogleAdsSearchVolumeTaskPostRequestInfo[]
    {
        new KeywordsDataGoogleAdsSearchVolumeTaskPostRequestInfo()
        {
            LocationName = "United States",
            Keywords = new string[]
        {
            "buy laptop",
            "cheap laptops for sale",
            "purchase laptop",
        },
        },
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
var id = "00000000-0000-0000-0000-000000000000";
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
var result = await dfsClient.KeywordsDataApi.GoogleAdsSearchVolumeLiveAsync(
    new KeywordsDataGoogleAdsSearchVolumeLiveRequestInfo[]
    {
        new KeywordsDataGoogleAdsSearchVolumeLiveRequestInfo()
        {
            LocationCode = 2840,
            Keywords = new string[]
        {
            "buy laptop",
            "cheap laptops for sale",
            "purchase laptop",
        },
            DateFrom = "2025-11-18 00:00:00 +02:00",
            SearchPartners = true,
        },
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
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForSiteTaskPostAsync(
    new KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo[]
    {
        new KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo()
        {
            LocationCode = 2840,
            Target = "dataforseo.com",
        },
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
var id = "00000000-0000-0000-0000-000000000000";
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
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForSiteLiveAsync(
    new KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo[]
    {
        new KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo()
        {
            LocationCode = 2840,
            Target = "dataforseo.com",
        },
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
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForKeywordsTaskPostAsync(
    new KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo[]
    {
        new KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo()
        {
            LocationCode = 2840,
            Keywords = new string[]
        {
            "phone",
            "cellphone",
        },
        },
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
var id = "00000000-0000-0000-0000-000000000000";
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
var result = await dfsClient.KeywordsDataApi.GoogleAdsKeywordsForKeywordsLiveAsync(
    new KeywordsDataGoogleAdsKeywordsForKeywordsLiveRequestInfo[]
    {
        new KeywordsDataGoogleAdsKeywordsForKeywordsLiveRequestInfo()
        {
            LocationCode = 2840,
            Keywords = new string[]
        {
            "phone",
            "cellphone",
        },
        },
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
var result = await dfsClient.KeywordsDataApi.GoogleAdsAdTrafficByKeywordsTaskPostAsync(
    new KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo[]
    {
        new KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo()
        {
            LanguageCode = "en",
            LocationCode = 2840,
            Bid = 999,
            Match = "exact",
            Keywords = new string[]
        {
            "seo marketing",
        },
        },
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
var id = "00000000-0000-0000-0000-000000000000";
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
var result = await dfsClient.KeywordsDataApi.GoogleAdsAdTrafficByKeywordsLiveAsync(
    new KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo[]
    {
        new KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo()
        {
            LocationCode = 2840,
            LanguageCode = "en",
            Bid = 999,
            Match = "exact",
            Keywords = new string[]
        {
            "seo marketing",
        },
        },
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

<a id="googleTrendsLocations"></a>
# **googleTrendsLocations**
> KeywordsDataGoogleTrendsLocationsResponseInfo googleTrendsLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleTrendsLocationsAsync();
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

<a id="googleTrendsLocationsCountry"></a>
# **googleTrendsLocationsCountry**
> KeywordsDataGoogleTrendsLocationsCountryResponseInfo googleTrendsLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.KeywordsDataApi.GoogleTrendsLocationsCountryAsync(country);
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

<a id="googleTrendsLanguages"></a>
# **googleTrendsLanguages**
> KeywordsDataGoogleTrendsLanguagesResponseInfo googleTrendsLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.GoogleTrendsLanguagesAsync();
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
var result = await dfsClient.KeywordsDataApi.GoogleTrendsExploreTaskPostAsync(
    new KeywordsDataGoogleTrendsExploreTaskPostRequestInfo[]
    {
        new KeywordsDataGoogleTrendsExploreTaskPostRequestInfo()
        {
            DateFrom = "2025-11-18 00:00:00 +02:00",
            DateTo = "2026-01-18 00:00:00 +02:00",
            Type = "youtube",
            CategoryCode = 3,
            Keywords = new string[]
        {
            "seo api",
            "rank api",
        },
        },
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
var id = "00000000-0000-0000-0000-000000000000";
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
var result = await dfsClient.KeywordsDataApi.GoogleTrendsExploreLiveAsync(
    new KeywordsDataGoogleTrendsExploreLiveRequestInfo[]
    {
        new KeywordsDataGoogleTrendsExploreLiveRequestInfo()
        {
            LocationName = "United States",
            DateFrom = "2025-11-18 00:00:00 +02:00",
            DateTo = "2026-01-18 00:00:00 +02:00",
            Type = "youtube",
            CategoryCode = 3,
            Keywords = new string[]
        {
            "rugby",
            "cricket",
        },
        },
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

<a id="dataforseoTrendsLocations"></a>
# **dataforseoTrendsLocations**
> KeywordsDataDataforseoTrendsLocationsResponseInfo dataforseoTrendsLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.DataforseoTrendsLocationsAsync();
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

<a id="dataforseoTrendsLocationsCountry"></a>
# **dataforseoTrendsLocationsCountry**
> KeywordsDataDataforseoTrendsLocationsCountryResponseInfo dataforseoTrendsLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.KeywordsDataApi.DataforseoTrendsLocationsCountryAsync(country);
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
var result = await dfsClient.KeywordsDataApi.DataforseoTrendsExploreLiveAsync(
    new KeywordsDataDataforseoTrendsExploreLiveRequestInfo[]
    {
        new KeywordsDataDataforseoTrendsExploreLiveRequestInfo()
        {
            Keywords = new string[]
        {
            "iphone 14",
            "samsung s23",
        },
            LocationCode = 2840,
        },
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
var result = await dfsClient.KeywordsDataApi.DataforseoTrendsSubregionInterestsLiveAsync(
    new KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo[]
    {
        new KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo()
        {
            Keywords = new string[]
        {
            "rugby",
            "cricket",
        },
            DateFrom = "2025-11-18 00:00:00 +02:00",
            DateTo = "2026-01-18 00:00:00 +02:00",
            Type = "web",
            LocationName = "United States",
        },
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
var result = await dfsClient.KeywordsDataApi.DataforseoTrendsDemographyLiveAsync(
    new KeywordsDataDataforseoTrendsDemographyLiveRequestInfo[]
    {
        new KeywordsDataDataforseoTrendsDemographyLiveRequestInfo()
        {
            Keywords = new string[]
        {
            "rugby",
            "cricket",
        },
            DateFrom = "2025-11-18 00:00:00 +02:00",
            DateTo = "2026-01-18 00:00:00 +02:00",
            Type = "web",
            LocationName = "United States",
        },
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
var result = await dfsClient.KeywordsDataApi.DataforseoTrendsMergedDataLiveAsync(
    new KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo[]
    {
        new KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo()
        {
            Keywords = new string[]
        {
            "rugby",
            "cricket",
        },
            DateFrom = "2025-11-18 00:00:00 +02:00",
            DateTo = "2026-01-18 00:00:00 +02:00",
            Type = "web",
            LocationName = "United States",
        },
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
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeTaskPostAsync(
    new KeywordsDataBingSearchVolumeTaskPostRequestInfo[]
    {
        new KeywordsDataBingSearchVolumeTaskPostRequestInfo()
        {
            LocationName = "United States",
            LanguageName = "English",
            Keywords = new string[]
        {
            "average page rpm adsense",
            "adsense blank ads how long",
            "leads and prospects",
        },
        },
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
var id = "00000000-0000-0000-0000-000000000000";
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
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeLiveAsync(
    new KeywordsDataBingSearchVolumeLiveRequestInfo[]
    {
        new KeywordsDataBingSearchVolumeLiveRequestInfo()
        {
            LocationName = "United States",
            LanguageCode = "en",
            Keywords = new string[]
        {
            "tom and jerry",
            "silicon valley",
            "spider man",
        },
        },
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
var result = await dfsClient.KeywordsDataApi.BingAudienceEstimationTaskPostAsync(
    new KeywordsDataBingAudienceEstimationTaskPostRequestInfo[]
    {
        new KeywordsDataBingAudienceEstimationTaskPostRequestInfo()
        {
            LocationCoordinate = "29.6821525,-82.4098881,100",
            Age = new string[]
        {
            "twenty_five_to_thirty_four",
            "eighteen_to_twenty_four",
            "unknown",
        },
            Bid = 1,
            DailyBudget = 24,
            Gender = new string[]
        {
            "male",
        },
            Industry = new string[]
        {
            "806303407",
            "806301758",
        },
            JobFunction = new string[]
        {
            "806298607",
        },
        },
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
var id = "00000000-0000-0000-0000-000000000000";
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
var result = await dfsClient.KeywordsDataApi.BingAudienceEstimationLiveAsync(
    new KeywordsDataBingAudienceEstimationLiveRequestInfo[]
    {
        new KeywordsDataBingAudienceEstimationLiveRequestInfo()
        {
            LocationCoordinate = "29.6821525,-82.4098881,100",
            Age = new string[]
        {
            "twenty_five_to_thirty_four",
            "eighteen_to_twenty_four",
            "unknown",
        },
            Bid = 1,
            DailyBudget = 24,
            Gender = new string[]
        {
            "male",
        },
            Industry = new string[]
        {
            "806303407",
            "806301758",
        },
            JobFunction = new string[]
        {
            "806298607",
        },
        },
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
var result = await dfsClient.KeywordsDataApi.BingKeywordsForSiteTaskPostAsync(
    new KeywordsDataBingKeywordsForSiteTaskPostRequestInfo[]
    {
        new KeywordsDataBingKeywordsForSiteTaskPostRequestInfo()
        {
            LanguageCode = "en",
            LocationCode = 2840,
            Target = "dataforseo.com",
        },
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
var id = "00000000-0000-0000-0000-000000000000";
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
var result = await dfsClient.KeywordsDataApi.BingKeywordsForSiteLiveAsync(
    new KeywordsDataBingKeywordsForSiteLiveRequestInfo[]
    {
        new KeywordsDataBingKeywordsForSiteLiveRequestInfo()
        {
            LanguageCode = "en",
            LocationCode = 2840,
            Target = "dataforseo.com",
        },
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
var result = await dfsClient.KeywordsDataApi.BingKeywordsForKeywordsTaskPostAsync(
    new KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo[]
    {
        new KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo()
        {
            LocationCode = 2840,
            LanguageCode = "en",
            Keywords = new string[]
        {
            "average page rpm adsense",
            "adsense blank ads how long",
            "leads and prospects",
        },
        },
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
var id = "00000000-0000-0000-0000-000000000000";
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
var result = await dfsClient.KeywordsDataApi.BingKeywordsForKeywordsLiveAsync(
    new KeywordsDataBingKeywordsForKeywordsLiveRequestInfo[]
    {
        new KeywordsDataBingKeywordsForKeywordsLiveRequestInfo()
        {
            LocationName = "United States",
            LanguageName = "English",
            Keywords = new string[]
        {
            "average page rpm adsense",
            "adsense blank ads how long",
            "leads and prospects",
        },
        },
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

<a id="bingKeywordPerformanceLocationsAndLanguages"></a>
# **bingKeywordPerformanceLocationsAndLanguages**
> KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo bingKeywordPerformanceLocationsAndLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingKeywordPerformanceLocationsAndLanguagesAsync();
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
var result = await dfsClient.KeywordsDataApi.BingKeywordPerformanceTaskPostAsync(
    new KeywordsDataBingKeywordPerformanceTaskPostRequestInfo[]
    {
        new KeywordsDataBingKeywordPerformanceTaskPostRequestInfo()
        {
            LocationCode = 2840,
            LanguageCode = "en",
            Keywords = new string[]
        {
            "dataforseo",
            "seo",
            "ranking",
        },
        },
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
var id = "00000000-0000-0000-0000-000000000000";
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
var result = await dfsClient.KeywordsDataApi.BingKeywordPerformanceLiveAsync(
    new KeywordsDataBingKeywordPerformanceLiveRequestInfo[]
    {
        new KeywordsDataBingKeywordPerformanceLiveRequestInfo()
        {
            LocationCode = 2840,
            LanguageCode = "en",
            Keywords = new string[]
        {
            "dataforseo",
            "seo",
            "ranking",
        },
        },
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

<a id="bingSearchVolumeHistoryLocationsAndLanguages"></a>
# **bingSearchVolumeHistoryLocationsAndLanguages**
> KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo bingSearchVolumeHistoryLocationsAndLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeHistoryLocationsAndLanguagesAsync();
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
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeHistoryTaskPostAsync(
    new KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo[]
    {
        new KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo()
        {
            LocationCode = 2840,
            LanguageCode = "en",
            Keywords = new string[]
        {
            "10 minute timer",
        },
        },
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
var id = "00000000-0000-0000-0000-000000000000";
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
var result = await dfsClient.KeywordsDataApi.BingSearchVolumeHistoryLiveAsync(
    new KeywordsDataBingSearchVolumeHistoryLiveRequestInfo[]
    {
        new KeywordsDataBingSearchVolumeHistoryLiveRequestInfo()
        {
            LocationCode = 2840,
            LanguageCode = "en",
            Keywords = new string[]
        {
            "10 minute timer",
        },
        },
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

<a id="clickstreamDataLocationsAndLanguages"></a>
# **clickstreamDataLocationsAndLanguages**
> KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo clickstreamDataLocationsAndLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.KeywordsDataApi.ClickstreamDataLocationsAndLanguagesAsync();
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
var result = await dfsClient.KeywordsDataApi.ClickstreamDataDataforseoSearchVolumeLiveAsync(
    new KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo[]
    {
        new KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo()
        {
            LocationCode = 2840,
            LanguageCode = "en",
            Tag = "test-tag",
            Keywords = new string[]
        {
            "you tube",
            "youtube",
            "youtub",
        },
        },
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
var result = await dfsClient.KeywordsDataApi.ClickstreamDataGlobalSearchVolumeLiveAsync(
    new KeywordsDataClickstreamDataGlobalSearchVolumeLiveRequestInfo[]
    {
        new KeywordsDataClickstreamDataGlobalSearchVolumeLiveRequestInfo()
        {
            Tag = "test-tag",
            Keywords = new string[]
        {
            "you tube",
            "youtube",
            "youtub",
        },
        },
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
var result = await dfsClient.KeywordsDataApi.ClickstreamDataBulkSearchVolumeLiveAsync(
    new KeywordsDataClickstreamDataBulkSearchVolumeLiveRequestInfo[]
    {
        new KeywordsDataClickstreamDataBulkSearchVolumeLiveRequestInfo()
        {
            LocationCode = 2840,
            Tag = "test-tag",
            Keywords = new string[]
        {
            "you tube",
            "youtube",
            "youtub",
        },
        },
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