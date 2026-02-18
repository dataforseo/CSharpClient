# ContentAnalysisApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**contentAnalysisIdList**](ContentAnalysisApi.md#contentAnalysisIdList) | **POST**  /v3/content_analysis/id_list  |
[**contentAnalysisAvailableFilters**](ContentAnalysisApi.md#contentAnalysisAvailableFilters) | **GET**  /v3/content_analysis/available_filters  |
[**locations**](ContentAnalysisApi.md#locations) | **GET**  /v3/content_analysis/locations  |
[**languages**](ContentAnalysisApi.md#languages) | **GET**  /v3/content_analysis/languages  |
[**contentAnalysisCategories**](ContentAnalysisApi.md#contentAnalysisCategories) | **GET**  /v3/content_analysis/categories  |
[**searchLive**](ContentAnalysisApi.md#searchLive) | **POST**  /v3/content_analysis/search/live  |
[**contentAnalysisSummaryLive**](ContentAnalysisApi.md#contentAnalysisSummaryLive) | **POST**  /v3/content_analysis/summary/live  |
[**sentimentAnalysisLive**](ContentAnalysisApi.md#sentimentAnalysisLive) | **POST**  /v3/content_analysis/sentiment_analysis/live  |
[**ratingDistributionLive**](ContentAnalysisApi.md#ratingDistributionLive) | **POST**  /v3/content_analysis/rating_distribution/live  |
[**phraseTrendsLive**](ContentAnalysisApi.md#phraseTrendsLive) | **POST**  /v3/content_analysis/phrase_trends/live  |
[**categoryTrendsLive**](ContentAnalysisApi.md#categoryTrendsLive) | **POST**  /v3/content_analysis/category_trends/live  |

<a id="contentAnalysisIdList"></a>
# **contentAnalysisIdList**
> ContentAnalysisIdListResponseInfo contentAnalysisIdList()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.ContentAnalysisIdListAsync(
    new ContentAnalysisIdListRequestInfo[]
    {
        new ContentAnalysisIdListRequestInfo()
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
| **** | [**List&lt;IEnumerable<ContentAnalysisIdListRequestInfo>&gt;**](IEnumerable<ContentAnalysisIdListRequestInfo>.md)|  | [optional] |



### Return type

[**ContentAnalysisIdListResponseInfo**](ContentAnalysisIdListResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="contentAnalysisAvailableFilters"></a>
# **contentAnalysisAvailableFilters**
> ContentAnalysisAvailableFiltersResponseInfo contentAnalysisAvailableFilters()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.ContentAnalysisAvailableFiltersAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**ContentAnalysisAvailableFiltersResponseInfo**](ContentAnalysisAvailableFiltersResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="locations"></a>
# **locations**
> ContentAnalysisLocationsResponseInfo locations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.LocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**ContentAnalysisLocationsResponseInfo**](ContentAnalysisLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="languages"></a>
# **languages**
> ContentAnalysisLanguagesResponseInfo languages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.LanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**ContentAnalysisLanguagesResponseInfo**](ContentAnalysisLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="contentAnalysisCategories"></a>
# **contentAnalysisCategories**
> ContentAnalysisCategoriesResponseInfo contentAnalysisCategories()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.ContentAnalysisCategoriesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**ContentAnalysisCategoriesResponseInfo**](ContentAnalysisCategoriesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="searchLive"></a>
# **searchLive**
> ContentAnalysisSearchLiveResponseInfo searchLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.SearchLiveAsync(
    new ContentAnalysisSearchLiveRequestInfo[]
    {
        new ContentAnalysisSearchLiveRequestInfo()
        {
            KeywordFields = new Dictionary<string, string>()
        {
            ["Snippet"] = "logitech",
        },
            Keyword = "logitech",
            PageType = new string[]
        {
            "ecommerce",
            "news",
            "blogs",
            "message-boards",
            "organization",
        },
            SearchMode = "as_is",
            Filters = new object[]
        {
            "main_domain",
            "=",
            "reviewfinder.ca",
        },
            OrderBy = new string[]
        {
            "content_info.sentiment_connotations.anger,desc",
        },
            Limit = 10,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentAnalysisSearchLiveRequestInfo>&gt;**](IEnumerable<ContentAnalysisSearchLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentAnalysisSearchLiveResponseInfo**](ContentAnalysisSearchLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="contentAnalysisSummaryLive"></a>
# **contentAnalysisSummaryLive**
> ContentAnalysisSummaryLiveResponseInfo contentAnalysisSummaryLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.ContentAnalysisSummaryLiveAsync(
    new ContentAnalysisSummaryLiveRequestInfo[]
    {
        new ContentAnalysisSummaryLiveRequestInfo()
        {
            Keyword = "logitech",
            PageType = new string[]
        {
            "ecommerce",
            "news",
            "blogs",
            "message-boards",
            "organization",
        },
            InternalListLimit = 8,
            PositiveConnotationThreshold = 0.5,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentAnalysisSummaryLiveRequestInfo>&gt;**](IEnumerable<ContentAnalysisSummaryLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentAnalysisSummaryLiveResponseInfo**](ContentAnalysisSummaryLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="sentimentAnalysisLive"></a>
# **sentimentAnalysisLive**
> ContentAnalysisSentimentAnalysisLiveResponseInfo sentimentAnalysisLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.SentimentAnalysisLiveAsync(
    new ContentAnalysisSentimentAnalysisLiveRequestInfo[]
    {
        new ContentAnalysisSentimentAnalysisLiveRequestInfo()
        {
            Keyword = "logitech",
            InternalListLimit = 1,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentAnalysisSentimentAnalysisLiveRequestInfo>&gt;**](IEnumerable<ContentAnalysisSentimentAnalysisLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentAnalysisSentimentAnalysisLiveResponseInfo**](ContentAnalysisSentimentAnalysisLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="ratingDistributionLive"></a>
# **ratingDistributionLive**
> ContentAnalysisRatingDistributionLiveResponseInfo ratingDistributionLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.RatingDistributionLiveAsync(
    new ContentAnalysisRatingDistributionLiveRequestInfo[]
    {
        new ContentAnalysisRatingDistributionLiveRequestInfo()
        {
            Keyword = "logitech",
            SearchMode = "as_is",
            InternalListLimit = 10,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentAnalysisRatingDistributionLiveRequestInfo>&gt;**](IEnumerable<ContentAnalysisRatingDistributionLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentAnalysisRatingDistributionLiveResponseInfo**](ContentAnalysisRatingDistributionLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="phraseTrendsLive"></a>
# **phraseTrendsLive**
> ContentAnalysisPhraseTrendsLiveResponseInfo phraseTrendsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.PhraseTrendsLiveAsync(
    new ContentAnalysisPhraseTrendsLiveRequestInfo[]
    {
        new ContentAnalysisPhraseTrendsLiveRequestInfo()
        {
            Keyword = "logitech",
            SearchMode = "as_is",
            DateFrom = "2025-11-18 00:00:00 +02:00",
            DateGroup = "month",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentAnalysisPhraseTrendsLiveRequestInfo>&gt;**](IEnumerable<ContentAnalysisPhraseTrendsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentAnalysisPhraseTrendsLiveResponseInfo**](ContentAnalysisPhraseTrendsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="categoryTrendsLive"></a>
# **categoryTrendsLive**
> ContentAnalysisCategoryTrendsLiveResponseInfo categoryTrendsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentAnalysisApi.CategoryTrendsLiveAsync(
    new ContentAnalysisCategoryTrendsLiveRequestInfo[]
    {
        new ContentAnalysisCategoryTrendsLiveRequestInfo()
        {
            CategoryCode = 10994,
            SearchMode = "as_is",
            DateFrom = "2025-11-18 00:00:00 +02:00",
            DateGroup = "month",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentAnalysisCategoryTrendsLiveRequestInfo>&gt;**](IEnumerable<ContentAnalysisCategoryTrendsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentAnalysisCategoryTrendsLiveResponseInfo**](ContentAnalysisCategoryTrendsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |