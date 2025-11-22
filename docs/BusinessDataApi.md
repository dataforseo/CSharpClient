# BusinessDataApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**businessDataIdList**](BusinessDataApi.md#businessDataIdList) | **POST**  /v3/business_data/id_list  |
[**businessDataErrors**](BusinessDataApi.md#businessDataErrors) | **POST**  /v3/business_data/errors  |
[**businessDataBusinessListingsLocations**](BusinessDataApi.md#businessDataBusinessListingsLocations) | **GET**  /v3/business_data/business_listings/locations  |
[**businessListingsCategories**](BusinessDataApi.md#businessListingsCategories) | **GET**  /v3/business_data/business_listings/categories  |
[**businessListingsAvailableFilters**](BusinessDataApi.md#businessListingsAvailableFilters) | **GET**  /v3/business_data/business_listings/available_filters  |
[**businessListingsSearchLive**](BusinessDataApi.md#businessListingsSearchLive) | **POST**  /v3/business_data/business_listings/search/live  |
[**businessListingsCategoriesAggregationLive**](BusinessDataApi.md#businessListingsCategoriesAggregationLive) | **POST**  /v3/business_data/business_listings/categories_aggregation/live  |
[**businessDataGoogleLocations**](BusinessDataApi.md#businessDataGoogleLocations) | **GET**  /v3/business_data/google/locations  |
[**businessDataGoogleLocationsCountry**](BusinessDataApi.md#businessDataGoogleLocationsCountry) | **GET**  /v3/business_data/google/locations/{country}  |
[**businessDataGoogleLanguages**](BusinessDataApi.md#businessDataGoogleLanguages) | **GET**  /v3/business_data/google/languages  |
[**googleMyBusinessInfoTaskPost**](BusinessDataApi.md#googleMyBusinessInfoTaskPost) | **POST**  /v3/business_data/google/my_business_info/task_post  |
[**googleMyBusinessInfoTasksReady**](BusinessDataApi.md#googleMyBusinessInfoTasksReady) | **GET**  /v3/business_data/google/my_business_info/tasks_ready  |
[**businessDataTasksReady**](BusinessDataApi.md#businessDataTasksReady) | **GET**  /v3/business_data/tasks_ready  |
[**googleMyBusinessInfoTaskGet**](BusinessDataApi.md#googleMyBusinessInfoTaskGet) | **GET**  /v3/business_data/google/my_business_info/task_get/{id}  |
[**googleMyBusinessInfoLive**](BusinessDataApi.md#googleMyBusinessInfoLive) | **POST**  /v3/business_data/google/my_business_info/live  |
[**googleMyBusinessUpdatesTaskPost**](BusinessDataApi.md#googleMyBusinessUpdatesTaskPost) | **POST**  /v3/business_data/google/my_business_updates/task_post  |
[**googleMyBusinessUpdatesTasksReady**](BusinessDataApi.md#googleMyBusinessUpdatesTasksReady) | **GET**  /v3/business_data/google/my_business_updates/tasks_ready  |
[**googleMyBusinessUpdatesTaskGet**](BusinessDataApi.md#googleMyBusinessUpdatesTaskGet) | **GET**  /v3/business_data/google/my_business_updates/task_get/{id}  |
[**googleHotelSearchesTaskPost**](BusinessDataApi.md#googleHotelSearchesTaskPost) | **POST**  /v3/business_data/google/hotel_searches/task_post  |
[**googleHotelSearchesTasksReady**](BusinessDataApi.md#googleHotelSearchesTasksReady) | **GET**  /v3/business_data/google/hotel_searches/tasks_ready  |
[**googleHotelSearchesTaskGet**](BusinessDataApi.md#googleHotelSearchesTaskGet) | **GET**  /v3/business_data/google/hotel_searches/task_get/{id}  |
[**googleHotelSearchesLive**](BusinessDataApi.md#googleHotelSearchesLive) | **POST**  /v3/business_data/google/hotel_searches/live  |
[**googleHotelInfoTaskPost**](BusinessDataApi.md#googleHotelInfoTaskPost) | **POST**  /v3/business_data/google/hotel_info/task_post  |
[**googleHotelInfoTasksReady**](BusinessDataApi.md#googleHotelInfoTasksReady) | **GET**  /v3/business_data/google/hotel_info/tasks_ready  |
[**googleHotelInfoTaskGetAdvanced**](BusinessDataApi.md#googleHotelInfoTaskGetAdvanced) | **GET**  /v3/business_data/google/hotel_info/task_get/advanced/{id}  |
[**googleHotelInfoTaskGetHtml**](BusinessDataApi.md#googleHotelInfoTaskGetHtml) | **GET**  /v3/business_data/google/hotel_info/task_get/html/{id}  |
[**googleHotelInfoLiveAdvanced**](BusinessDataApi.md#googleHotelInfoLiveAdvanced) | **POST**  /v3/business_data/google/hotel_info/live/advanced  |
[**googleHotelInfoLiveHtml**](BusinessDataApi.md#googleHotelInfoLiveHtml) | **POST**  /v3/business_data/google/hotel_info/live/html  |
[**googleReviewsTaskPost**](BusinessDataApi.md#googleReviewsTaskPost) | **POST**  /v3/business_data/google/reviews/task_post  |
[**googleReviewsTasksReady**](BusinessDataApi.md#googleReviewsTasksReady) | **GET**  /v3/business_data/google/reviews/tasks_ready  |
[**googleReviewsTaskGet**](BusinessDataApi.md#googleReviewsTaskGet) | **GET**  /v3/business_data/google/reviews/task_get/{id}  |
[**googleExtendedReviewsTaskPost**](BusinessDataApi.md#googleExtendedReviewsTaskPost) | **POST**  /v3/business_data/google/extended_reviews/task_post  |
[**googleExtendedReviewsTasksReady**](BusinessDataApi.md#googleExtendedReviewsTasksReady) | **GET**  /v3/business_data/google/extended_reviews/tasks_ready  |
[**googleExtendedReviewsTaskGet**](BusinessDataApi.md#googleExtendedReviewsTaskGet) | **GET**  /v3/business_data/google/extended_reviews/task_get/{id}  |
[**googleQuestionsAndAnswersTaskPost**](BusinessDataApi.md#googleQuestionsAndAnswersTaskPost) | **POST**  /v3/business_data/google/questions_and_answers/task_post  |
[**googleQuestionsAndAnswersTasksReady**](BusinessDataApi.md#googleQuestionsAndAnswersTasksReady) | **GET**  /v3/business_data/google/questions_and_answers/tasks_ready  |
[**googleQuestionsAndAnswersTaskGet**](BusinessDataApi.md#googleQuestionsAndAnswersTaskGet) | **GET**  /v3/business_data/google/questions_and_answers/task_get/{id}  |
[**googleQuestionsAndAnswersLive**](BusinessDataApi.md#googleQuestionsAndAnswersLive) | **POST**  /v3/business_data/google/questions_and_answers/live  |
[**trustpilotSearchTaskPost**](BusinessDataApi.md#trustpilotSearchTaskPost) | **POST**  /v3/business_data/trustpilot/search/task_post  |
[**trustpilotSearchTasksReady**](BusinessDataApi.md#trustpilotSearchTasksReady) | **GET**  /v3/business_data/trustpilot/search/tasks_ready  |
[**trustpilotSearchTaskGet**](BusinessDataApi.md#trustpilotSearchTaskGet) | **GET**  /v3/business_data/trustpilot/search/task_get/{id}  |
[**trustpilotReviewsTaskPost**](BusinessDataApi.md#trustpilotReviewsTaskPost) | **POST**  /v3/business_data/trustpilot/reviews/task_post  |
[**trustpilotReviewsTasksReady**](BusinessDataApi.md#trustpilotReviewsTasksReady) | **GET**  /v3/business_data/trustpilot/reviews/tasks_ready  |
[**trustpilotReviewsTaskGet**](BusinessDataApi.md#trustpilotReviewsTaskGet) | **GET**  /v3/business_data/trustpilot/reviews/task_get/{id}  |
[**businessDataTripadvisorLocations**](BusinessDataApi.md#businessDataTripadvisorLocations) | **GET**  /v3/business_data/tripadvisor/locations  |
[**businessDataTripadvisorLocationsCountry**](BusinessDataApi.md#businessDataTripadvisorLocationsCountry) | **GET**  /v3/business_data/tripadvisor/locations/{country}  |
[**businessDataTripadvisorLanguages**](BusinessDataApi.md#businessDataTripadvisorLanguages) | **GET**  /v3/business_data/tripadvisor/languages  |
[**tripadvisorSearchTaskPost**](BusinessDataApi.md#tripadvisorSearchTaskPost) | **POST**  /v3/business_data/tripadvisor/search/task_post  |
[**tripadvisorSearchTasksReady**](BusinessDataApi.md#tripadvisorSearchTasksReady) | **GET**  /v3/business_data/tripadvisor/search/tasks_ready  |
[**tripadvisorSearchTaskGet**](BusinessDataApi.md#tripadvisorSearchTaskGet) | **GET**  /v3/business_data/tripadvisor/search/task_get/{id}  |
[**tripadvisorReviewsTaskPost**](BusinessDataApi.md#tripadvisorReviewsTaskPost) | **POST**  /v3/business_data/tripadvisor/reviews/task_post  |
[**tripadvisorReviewsTasksReady**](BusinessDataApi.md#tripadvisorReviewsTasksReady) | **GET**  /v3/business_data/tripadvisor/reviews/tasks_ready  |
[**tripadvisorReviewsTaskGet**](BusinessDataApi.md#tripadvisorReviewsTaskGet) | **GET**  /v3/business_data/tripadvisor/reviews/task_get/{id}  |
[**socialMediaPinterestLive**](BusinessDataApi.md#socialMediaPinterestLive) | **POST**  /v3/business_data/social_media/pinterest/live  |
[**socialMediaFacebookLive**](BusinessDataApi.md#socialMediaFacebookLive) | **POST**  /v3/business_data/social_media/facebook/live  |
[**socialMediaRedditLive**](BusinessDataApi.md#socialMediaRedditLive) | **POST**  /v3/business_data/social_media/reddit/live  |

<a id="businessDataIdList"></a>
# **businessDataIdList**
> BusinessDataIdListResponseInfo businessDataIdList()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessDataIdListAsync(new List<BusinessDataIdListRequestInfo>()
{
    new()
    {
        DatetimeFrom = "2025-08-22 08:11:28 +00:00",
        DatetimeTo = "2025-10-22 08:11:28 +00:00",
        Limit = 100,
        Offset = 0,
        Sort = "desc",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataIdListRequestInfo>&gt;**](IEnumerable<BusinessDataIdListRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataIdListResponseInfo**](BusinessDataIdListResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessDataErrors"></a>
# **businessDataErrors**
> BusinessDataErrorsResponseInfo businessDataErrors()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessDataErrorsAsync(new List<BusinessDataErrorsRequestInfo>()
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
| **** | [**List&lt;IEnumerable<BusinessDataErrorsRequestInfo>&gt;**](IEnumerable<BusinessDataErrorsRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataErrorsResponseInfo**](BusinessDataErrorsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessDataBusinessListingsLocations"></a>
# **businessDataBusinessListingsLocations**
> BusinessDataBusinessListingsLocationsResponseInfo businessDataBusinessListingsLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessDataBusinessListingsLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataBusinessListingsLocationsResponseInfo**](BusinessDataBusinessListingsLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessListingsCategories"></a>
# **businessListingsCategories**
> BusinessDataBusinessListingsCategoriesResponseInfo businessListingsCategories()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessListingsCategoriesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataBusinessListingsCategoriesResponseInfo**](BusinessDataBusinessListingsCategoriesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessListingsAvailableFilters"></a>
# **businessListingsAvailableFilters**
> BusinessDataBusinessListingsAvailableFiltersResponseInfo businessListingsAvailableFilters()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessListingsAvailableFiltersAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataBusinessListingsAvailableFiltersResponseInfo**](BusinessDataBusinessListingsAvailableFiltersResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessListingsSearchLive"></a>
# **businessListingsSearchLive**
> BusinessDataBusinessListingsSearchLiveResponseInfo businessListingsSearchLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessListingsSearchLiveAsync(new List<BusinessDataBusinessListingsSearchLiveRequestInfo>()
{
    new()
    {
        Categories = new List<string>()
        {
            "pizza_restaurant",
        },
        Description = "pizza",
        Title = "pizza",
        IsClaimed = true,
        LocationCoordinate = "53.476225,-2.243572,10",
        Limit = 3,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataBusinessListingsSearchLiveRequestInfo>&gt;**](IEnumerable<BusinessDataBusinessListingsSearchLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataBusinessListingsSearchLiveResponseInfo**](BusinessDataBusinessListingsSearchLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessListingsCategoriesAggregationLive"></a>
# **businessListingsCategoriesAggregationLive**
> BusinessDataBusinessListingsCategoriesAggregationLiveResponseInfo businessListingsCategoriesAggregationLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessListingsCategoriesAggregationLiveAsync(new List<BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo>()
{
    new()
    {
        Categories = new List<string>()
        {
            "pizza_restaurant",
        },
        Description = "pizza",
        Title = "pizza",
        IsClaimed = true,
        LocationCoordinate = "53.476225,-2.243572,10",
        Limit = 3,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo>&gt;**](IEnumerable<BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataBusinessListingsCategoriesAggregationLiveResponseInfo**](BusinessDataBusinessListingsCategoriesAggregationLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessDataGoogleLocations"></a>
# **businessDataGoogleLocations**
> BusinessDataGoogleLocationsResponseInfo businessDataGoogleLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessDataGoogleLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleLocationsResponseInfo**](BusinessDataGoogleLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessDataGoogleLocationsCountry"></a>
# **businessDataGoogleLocationsCountry**
> BusinessDataGoogleLocationsCountryResponseInfo businessDataGoogleLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.BusinessDataApi.BusinessDataGoogleLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleLocationsCountryResponseInfo**](BusinessDataGoogleLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessDataGoogleLanguages"></a>
# **businessDataGoogleLanguages**
> BusinessDataGoogleLanguagesResponseInfo businessDataGoogleLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessDataGoogleLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleLanguagesResponseInfo**](BusinessDataGoogleLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMyBusinessInfoTaskPost"></a>
# **googleMyBusinessInfoTaskPost**
> BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo googleMyBusinessInfoTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleMyBusinessInfoTaskPostAsync(new List<BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "RustyBrick, Inc.",
        LocationName = "New York,New York,United States",
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo**](BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMyBusinessInfoTasksReady"></a>
# **googleMyBusinessInfoTasksReady**
> BusinessDataGoogleMyBusinessInfoTasksReadyResponseInfo googleMyBusinessInfoTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleMyBusinessInfoTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleMyBusinessInfoTasksReadyResponseInfo**](BusinessDataGoogleMyBusinessInfoTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessDataTasksReady"></a>
# **businessDataTasksReady**
> BusinessDataTasksReadyResponseInfo businessDataTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessDataTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTasksReadyResponseInfo**](BusinessDataTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMyBusinessInfoTaskGet"></a>
# **googleMyBusinessInfoTaskGet**
> BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo googleMyBusinessInfoTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.GoogleMyBusinessInfoTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo**](BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMyBusinessInfoLive"></a>
# **googleMyBusinessInfoLive**
> BusinessDataGoogleMyBusinessInfoLiveResponseInfo googleMyBusinessInfoLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleMyBusinessInfoLiveAsync(new List<BusinessDataGoogleMyBusinessInfoLiveRequestInfo>()
{
    new()
    {
        Keyword = "RustyBrick, Inc.",
        LocationName = "New York,New York,United States",
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleMyBusinessInfoLiveRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleMyBusinessInfoLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleMyBusinessInfoLiveResponseInfo**](BusinessDataGoogleMyBusinessInfoLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMyBusinessUpdatesTaskPost"></a>
# **googleMyBusinessUpdatesTaskPost**
> BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo googleMyBusinessUpdatesTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleMyBusinessUpdatesTaskPostAsync(new List<BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "RustyBrick, Inc.",
        LocationName = "New York,New York,United States",
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo**](BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMyBusinessUpdatesTasksReady"></a>
# **googleMyBusinessUpdatesTasksReady**
> BusinessDataGoogleMyBusinessUpdatesTasksReadyResponseInfo googleMyBusinessUpdatesTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleMyBusinessUpdatesTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleMyBusinessUpdatesTasksReadyResponseInfo**](BusinessDataGoogleMyBusinessUpdatesTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleMyBusinessUpdatesTaskGet"></a>
# **googleMyBusinessUpdatesTaskGet**
> BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo googleMyBusinessUpdatesTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.GoogleMyBusinessUpdatesTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo**](BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHotelSearchesTaskPost"></a>
# **googleHotelSearchesTaskPost**
> BusinessDataGoogleHotelSearchesTaskPostResponseInfo googleHotelSearchesTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleHotelSearchesTaskPostAsync(new List<BusinessDataGoogleHotelSearchesTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "cheap hotel",
        Priority = 2,
        LocationName = "New York,New York,United States",
        LanguageCode = "en",
        CheckIn = "2023-06-01",
        CheckOut = "2023-06-30",
        Currency = "USD",
        Adults = 2,
        Children = new List<string>()
        {
            "14",
        },
        SortBy = "highest_rating",
        Tag = "example",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleHotelSearchesTaskPostRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleHotelSearchesTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleHotelSearchesTaskPostResponseInfo**](BusinessDataGoogleHotelSearchesTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHotelSearchesTasksReady"></a>
# **googleHotelSearchesTasksReady**
> BusinessDataGoogleHotelSearchesTasksReadyResponseInfo googleHotelSearchesTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleHotelSearchesTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleHotelSearchesTasksReadyResponseInfo**](BusinessDataGoogleHotelSearchesTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHotelSearchesTaskGet"></a>
# **googleHotelSearchesTaskGet**
> BusinessDataGoogleHotelSearchesTaskGetResponseInfo googleHotelSearchesTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.GoogleHotelSearchesTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleHotelSearchesTaskGetResponseInfo**](BusinessDataGoogleHotelSearchesTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHotelSearchesLive"></a>
# **googleHotelSearchesLive**
> BusinessDataGoogleHotelSearchesLiveResponseInfo googleHotelSearchesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleHotelSearchesLiveAsync(new List<BusinessDataGoogleHotelSearchesLiveRequestInfo>()
{
    new()
    {
        Keyword = "cheap hotel",
        LocationName = "New York,New York,United States",
        LanguageCode = "en",
        CheckIn = "2023-06-01",
        CheckOut = "2023-06-30",
        Currency = "USD",
        Adults = 2,
        Children = new List<string>()
        {
            "14",
        },
        SortBy = "highest_rating",
        Tag = "example",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleHotelSearchesLiveRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleHotelSearchesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleHotelSearchesLiveResponseInfo**](BusinessDataGoogleHotelSearchesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHotelInfoTaskPost"></a>
# **googleHotelInfoTaskPost**
> BusinessDataGoogleHotelInfoTaskPostResponseInfo googleHotelInfoTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleHotelInfoTaskPostAsync(new List<BusinessDataGoogleHotelInfoTaskPostRequestInfo>()
{
    new()
    {
        HotelIdentifier = "ChYIq6SB--i6p6cpGgovbS8wN2s5ODZfEAE",
        LocationName = "New York,New York,United States",
        LanguageCode = "en",
        Tag = "some_string_123",
        PostbackUrl = "https://your-server.com/postbackscript.php",
        PostbackData = "advanced",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleHotelInfoTaskPostRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleHotelInfoTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleHotelInfoTaskPostResponseInfo**](BusinessDataGoogleHotelInfoTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHotelInfoTasksReady"></a>
# **googleHotelInfoTasksReady**
> BusinessDataGoogleHotelInfoTasksReadyResponseInfo googleHotelInfoTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleHotelInfoTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleHotelInfoTasksReadyResponseInfo**](BusinessDataGoogleHotelInfoTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHotelInfoTaskGetAdvanced"></a>
# **googleHotelInfoTaskGetAdvanced**
> BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo googleHotelInfoTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.GoogleHotelInfoTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo**](BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHotelInfoTaskGetHtml"></a>
# **googleHotelInfoTaskGetHtml**
> BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo googleHotelInfoTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.GoogleHotelInfoTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo**](BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHotelInfoLiveAdvanced"></a>
# **googleHotelInfoLiveAdvanced**
> BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo googleHotelInfoLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleHotelInfoLiveAdvancedAsync(new List<BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo>()
{
    new()
    {
        HotelIdentifier = "CgoI-KWyzenM_MV3EAE",
        LocationName = "New York,New York,United States",
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo**](BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleHotelInfoLiveHtml"></a>
# **googleHotelInfoLiveHtml**
> BusinessDataGoogleHotelInfoLiveHtmlResponseInfo googleHotelInfoLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleHotelInfoLiveHtmlAsync(new List<BusinessDataGoogleHotelInfoLiveHtmlRequestInfo>()
{
    new()
    {
        HotelIdentifier = "ChYIq6SB--i6p6cpGgovbS8wN2s5ODZfEAE",
        LocationName = "New York,New York,United States",
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleHotelInfoLiveHtmlRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleHotelInfoLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleHotelInfoLiveHtmlResponseInfo**](BusinessDataGoogleHotelInfoLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleReviewsTaskPost"></a>
# **googleReviewsTaskPost**
> BusinessDataGoogleReviewsTaskPostResponseInfo googleReviewsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleReviewsTaskPostAsync(new List<BusinessDataGoogleReviewsTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "hedonism wines",
        LocationName = "London,England,United Kingdom",
        LanguageName = "English",
        Depth = 50,
        SortBy = "highest_rating",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleReviewsTaskPostRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleReviewsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleReviewsTaskPostResponseInfo**](BusinessDataGoogleReviewsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleReviewsTasksReady"></a>
# **googleReviewsTasksReady**
> BusinessDataGoogleReviewsTasksReadyResponseInfo googleReviewsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleReviewsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleReviewsTasksReadyResponseInfo**](BusinessDataGoogleReviewsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleReviewsTaskGet"></a>
# **googleReviewsTaskGet**
> BusinessDataGoogleReviewsTaskGetResponseInfo googleReviewsTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.GoogleReviewsTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleReviewsTaskGetResponseInfo**](BusinessDataGoogleReviewsTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleExtendedReviewsTaskPost"></a>
# **googleExtendedReviewsTaskPost**
> BusinessDataGoogleExtendedReviewsTaskPostResponseInfo googleExtendedReviewsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleExtendedReviewsTaskPostAsync(new List<BusinessDataGoogleExtendedReviewsTaskPostRequestInfo>()
{
    new()
    {
        Cid = "17626775537598922320",
        LocationName = "London,England,United Kingdom",
        LanguageName = "english",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleExtendedReviewsTaskPostRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleExtendedReviewsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleExtendedReviewsTaskPostResponseInfo**](BusinessDataGoogleExtendedReviewsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleExtendedReviewsTasksReady"></a>
# **googleExtendedReviewsTasksReady**
> BusinessDataGoogleExtendedReviewsTasksReadyResponseInfo googleExtendedReviewsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleExtendedReviewsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleExtendedReviewsTasksReadyResponseInfo**](BusinessDataGoogleExtendedReviewsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleExtendedReviewsTaskGet"></a>
# **googleExtendedReviewsTaskGet**
> BusinessDataGoogleExtendedReviewsTaskGetResponseInfo googleExtendedReviewsTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.GoogleExtendedReviewsTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleExtendedReviewsTaskGetResponseInfo**](BusinessDataGoogleExtendedReviewsTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleQuestionsAndAnswersTaskPost"></a>
# **googleQuestionsAndAnswersTaskPost**
> BusinessDataGoogleQuestionsAndAnswersTaskPostResponseInfo googleQuestionsAndAnswersTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleQuestionsAndAnswersTaskPostAsync(new List<BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "The Last Bookstore",
        LocationName = "Los Angeles,California,United States",
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleQuestionsAndAnswersTaskPostResponseInfo**](BusinessDataGoogleQuestionsAndAnswersTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleQuestionsAndAnswersTasksReady"></a>
# **googleQuestionsAndAnswersTasksReady**
> BusinessDataGoogleQuestionsAndAnswersTasksReadyResponseInfo googleQuestionsAndAnswersTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleQuestionsAndAnswersTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleQuestionsAndAnswersTasksReadyResponseInfo**](BusinessDataGoogleQuestionsAndAnswersTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleQuestionsAndAnswersTaskGet"></a>
# **googleQuestionsAndAnswersTaskGet**
> BusinessDataGoogleQuestionsAndAnswersTaskGetResponseInfo googleQuestionsAndAnswersTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.GoogleQuestionsAndAnswersTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataGoogleQuestionsAndAnswersTaskGetResponseInfo**](BusinessDataGoogleQuestionsAndAnswersTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleQuestionsAndAnswersLive"></a>
# **googleQuestionsAndAnswersLive**
> BusinessDataGoogleQuestionsAndAnswersLiveResponseInfo googleQuestionsAndAnswersLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.GoogleQuestionsAndAnswersLiveAsync(new List<BusinessDataGoogleQuestionsAndAnswersLiveRequestInfo>()
{
    new()
    {
        Keyword = "The Last Bookstore",
        LocationName = "Los Angeles,California,United States",
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataGoogleQuestionsAndAnswersLiveRequestInfo>&gt;**](IEnumerable<BusinessDataGoogleQuestionsAndAnswersLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataGoogleQuestionsAndAnswersLiveResponseInfo**](BusinessDataGoogleQuestionsAndAnswersLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="trustpilotSearchTaskPost"></a>
# **trustpilotSearchTaskPost**
> BusinessDataTrustpilotSearchTaskPostResponseInfo trustpilotSearchTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.TrustpilotSearchTaskPostAsync(new List<BusinessDataTrustpilotSearchTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "pizza restaurant",
        Depth = 20,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataTrustpilotSearchTaskPostRequestInfo>&gt;**](IEnumerable<BusinessDataTrustpilotSearchTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataTrustpilotSearchTaskPostResponseInfo**](BusinessDataTrustpilotSearchTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="trustpilotSearchTasksReady"></a>
# **trustpilotSearchTasksReady**
> BusinessDataTrustpilotSearchTasksReadyResponseInfo trustpilotSearchTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.TrustpilotSearchTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTrustpilotSearchTasksReadyResponseInfo**](BusinessDataTrustpilotSearchTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="trustpilotSearchTaskGet"></a>
# **trustpilotSearchTaskGet**
> BusinessDataTrustpilotSearchTaskGetResponseInfo trustpilotSearchTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.TrustpilotSearchTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTrustpilotSearchTaskGetResponseInfo**](BusinessDataTrustpilotSearchTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="trustpilotReviewsTaskPost"></a>
# **trustpilotReviewsTaskPost**
> BusinessDataTrustpilotReviewsTaskPostResponseInfo trustpilotReviewsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.TrustpilotReviewsTaskPostAsync(new List<BusinessDataTrustpilotReviewsTaskPostRequestInfo>()
{
    new()
    {
        Domain = "www.thepearlsource.com",
        Depth = 40,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataTrustpilotReviewsTaskPostRequestInfo>&gt;**](IEnumerable<BusinessDataTrustpilotReviewsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataTrustpilotReviewsTaskPostResponseInfo**](BusinessDataTrustpilotReviewsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="trustpilotReviewsTasksReady"></a>
# **trustpilotReviewsTasksReady**
> BusinessDataTrustpilotReviewsTasksReadyResponseInfo trustpilotReviewsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.TrustpilotReviewsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTrustpilotReviewsTasksReadyResponseInfo**](BusinessDataTrustpilotReviewsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="trustpilotReviewsTaskGet"></a>
# **trustpilotReviewsTaskGet**
> BusinessDataTrustpilotReviewsTaskGetResponseInfo trustpilotReviewsTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.TrustpilotReviewsTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTrustpilotReviewsTaskGetResponseInfo**](BusinessDataTrustpilotReviewsTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessDataTripadvisorLocations"></a>
# **businessDataTripadvisorLocations**
> BusinessDataTripadvisorLocationsResponseInfo businessDataTripadvisorLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessDataTripadvisorLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTripadvisorLocationsResponseInfo**](BusinessDataTripadvisorLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessDataTripadvisorLocationsCountry"></a>
# **businessDataTripadvisorLocationsCountry**
> BusinessDataTripadvisorLocationsCountryResponseInfo businessDataTripadvisorLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.BusinessDataApi.BusinessDataTripadvisorLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTripadvisorLocationsCountryResponseInfo**](BusinessDataTripadvisorLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="businessDataTripadvisorLanguages"></a>
# **businessDataTripadvisorLanguages**
> BusinessDataTripadvisorLanguagesResponseInfo businessDataTripadvisorLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.BusinessDataTripadvisorLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTripadvisorLanguagesResponseInfo**](BusinessDataTripadvisorLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="tripadvisorSearchTaskPost"></a>
# **tripadvisorSearchTaskPost**
> BusinessDataTripadvisorSearchTaskPostResponseInfo tripadvisorSearchTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.TripadvisorSearchTaskPostAsync(new List<BusinessDataTripadvisorSearchTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "pizza",
        LocationCode = 1003854,
        Depth = 30,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataTripadvisorSearchTaskPostRequestInfo>&gt;**](IEnumerable<BusinessDataTripadvisorSearchTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataTripadvisorSearchTaskPostResponseInfo**](BusinessDataTripadvisorSearchTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="tripadvisorSearchTasksReady"></a>
# **tripadvisorSearchTasksReady**
> BusinessDataTripadvisorSearchTasksReadyResponseInfo tripadvisorSearchTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.TripadvisorSearchTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTripadvisorSearchTasksReadyResponseInfo**](BusinessDataTripadvisorSearchTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="tripadvisorSearchTaskGet"></a>
# **tripadvisorSearchTaskGet**
> BusinessDataTripadvisorSearchTaskGetResponseInfo tripadvisorSearchTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.TripadvisorSearchTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTripadvisorSearchTaskGetResponseInfo**](BusinessDataTripadvisorSearchTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="tripadvisorReviewsTaskPost"></a>
# **tripadvisorReviewsTaskPost**
> BusinessDataTripadvisorReviewsTaskPostResponseInfo tripadvisorReviewsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.TripadvisorReviewsTaskPostAsync(new List<BusinessDataTripadvisorReviewsTaskPostRequestInfo>()
{
    new()
    {
        UrlPath = "Hotel_Review-g60763-d23462501-Reviews-Margaritaville_Times_Square-New_York_City_New_York.html",
        LocationCode = 1003854,
        Tag = "some_string_123",
        PingbackUrl = "https://your-server.com/pingback.php?id=$id&tag=$tag",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataTripadvisorReviewsTaskPostRequestInfo>&gt;**](IEnumerable<BusinessDataTripadvisorReviewsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataTripadvisorReviewsTaskPostResponseInfo**](BusinessDataTripadvisorReviewsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="tripadvisorReviewsTasksReady"></a>
# **tripadvisorReviewsTasksReady**
> BusinessDataTripadvisorReviewsTasksReadyResponseInfo tripadvisorReviewsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.TripadvisorReviewsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTripadvisorReviewsTasksReadyResponseInfo**](BusinessDataTripadvisorReviewsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="tripadvisorReviewsTaskGet"></a>
# **tripadvisorReviewsTaskGet**
> BusinessDataTripadvisorReviewsTaskGetResponseInfo tripadvisorReviewsTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.BusinessDataApi.TripadvisorReviewsTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BusinessDataTripadvisorReviewsTaskGetResponseInfo**](BusinessDataTripadvisorReviewsTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="socialMediaPinterestLive"></a>
# **socialMediaPinterestLive**
> BusinessDataSocialMediaPinterestLiveResponseInfo socialMediaPinterestLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.SocialMediaPinterestLiveAsync(new List<BusinessDataSocialMediaPinterestLiveRequestInfo>()
{
    new()
    {
        Targets = new List<string>()
        {
            "https://www.simplyrecipes.com/recipes/grilled_salmon_with_cucumber_mango_salsa/",
            "https://tasty.co/recipe/classic-lasagna",
            "https://www.allrecipes.com/recipe/255263/sicilian-roasted-chicken/",
        },
        Tag = "some_string_123",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataSocialMediaPinterestLiveRequestInfo>&gt;**](IEnumerable<BusinessDataSocialMediaPinterestLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataSocialMediaPinterestLiveResponseInfo**](BusinessDataSocialMediaPinterestLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="socialMediaFacebookLive"></a>
# **socialMediaFacebookLive**
> BusinessDataSocialMediaFacebookLiveResponseInfo socialMediaFacebookLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.SocialMediaFacebookLiveAsync(new List<BusinessDataSocialMediaFacebookLiveRequestInfo>()
{
    new()
    {
        Targets = new List<string>()
        {
            "https://prnt.sc/",
            "https://developers.facebook.com/docs/plugins/like-button/",
            "https://www.shbarcelona.com/blog/en/salsa-dance-clubs-in-barcelona/",
        },
        Tag = "some_string_123",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataSocialMediaFacebookLiveRequestInfo>&gt;**](IEnumerable<BusinessDataSocialMediaFacebookLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataSocialMediaFacebookLiveResponseInfo**](BusinessDataSocialMediaFacebookLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="socialMediaRedditLive"></a>
# **socialMediaRedditLive**
> BusinessDataSocialMediaRedditLiveResponseInfo socialMediaRedditLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BusinessDataApi.SocialMediaRedditLiveAsync(new List<BusinessDataSocialMediaRedditLiveRequestInfo>()
{
    new()
    {
        Targets = new List<string>()
        {
            "https://vk.com/",
            "https://ahrefs.com/",
            "https://google.com/",
            "https://twitter.com/",
            "https://reddit.com/",
            "https://facebook.com/",
        },
        Tag = "some_string_123",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BusinessDataSocialMediaRedditLiveRequestInfo>&gt;**](IEnumerable<BusinessDataSocialMediaRedditLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BusinessDataSocialMediaRedditLiveResponseInfo**](BusinessDataSocialMediaRedditLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |