# AppDataApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**appDataIdList**](AppDataApi.md#appDataIdList) | **POST**  /v3/app_data/id_list  |
[**appDataErrors**](AppDataApi.md#appDataErrors) | **POST**  /v3/app_data/errors  |
[**googleCategories**](AppDataApi.md#googleCategories) | **GET**  /v3/app_data/google/categories  |
[**appDataGoogleLocations**](AppDataApi.md#appDataGoogleLocations) | **GET**  /v3/app_data/google/locations  |
[**appDataGoogleLocationsCountry**](AppDataApi.md#appDataGoogleLocationsCountry) | **GET**  /v3/app_data/google/locations/{country}  |
[**appDataGoogleLanguages**](AppDataApi.md#appDataGoogleLanguages) | **GET**  /v3/app_data/google/languages  |
[**googleAppSearchesTaskPost**](AppDataApi.md#googleAppSearchesTaskPost) | **POST**  /v3/app_data/google/app_searches/task_post  |
[**googleAppSearchesTasksReady**](AppDataApi.md#googleAppSearchesTasksReady) | **GET**  /v3/app_data/google/app_searches/tasks_ready  |
[**appDataTasksReady**](AppDataApi.md#appDataTasksReady) | **GET**  /v3/app_data/tasks_ready  |
[**googleAppSearchesTaskGetAdvanced**](AppDataApi.md#googleAppSearchesTaskGetAdvanced) | **GET**  /v3/app_data/google/app_searches/task_get/advanced/{id}  |
[**googleAppSearchesTaskGetHtml**](AppDataApi.md#googleAppSearchesTaskGetHtml) | **GET**  /v3/app_data/google/app_searches/task_get/html/{id}  |
[**googleAppListTaskPost**](AppDataApi.md#googleAppListTaskPost) | **POST**  /v3/app_data/google/app_list/task_post  |
[**googleAppListTasksReady**](AppDataApi.md#googleAppListTasksReady) | **GET**  /v3/app_data/google/app_list/tasks_ready  |
[**googleAppListTaskGetAdvanced**](AppDataApi.md#googleAppListTaskGetAdvanced) | **GET**  /v3/app_data/google/app_list/task_get/advanced/{id}  |
[**googleAppListTaskGetHtml**](AppDataApi.md#googleAppListTaskGetHtml) | **GET**  /v3/app_data/google/app_list/task_get/html/{id}  |
[**googleAppInfoTaskPost**](AppDataApi.md#googleAppInfoTaskPost) | **POST**  /v3/app_data/google/app_info/task_post  |
[**googleAppInfoTasksReady**](AppDataApi.md#googleAppInfoTasksReady) | **GET**  /v3/app_data/google/app_info/tasks_ready  |
[**googleAppInfoTaskGetAdvanced**](AppDataApi.md#googleAppInfoTaskGetAdvanced) | **GET**  /v3/app_data/google/app_info/task_get/advanced/{id}  |
[**googleAppInfoTaskGetHtml**](AppDataApi.md#googleAppInfoTaskGetHtml) | **GET**  /v3/app_data/google/app_info/task_get/html/{id}  |
[**googleAppReviewsTaskPost**](AppDataApi.md#googleAppReviewsTaskPost) | **POST**  /v3/app_data/google/app_reviews/task_post  |
[**googleAppReviewsTasksReady**](AppDataApi.md#googleAppReviewsTasksReady) | **GET**  /v3/app_data/google/app_reviews/tasks_ready  |
[**googleAppReviewsTaskGetAdvanced**](AppDataApi.md#googleAppReviewsTaskGetAdvanced) | **GET**  /v3/app_data/google/app_reviews/task_get/advanced/{id}  |
[**googleAppReviewsTaskGetHtml**](AppDataApi.md#googleAppReviewsTaskGetHtml) | **GET**  /v3/app_data/google/app_reviews/task_get/html/{id}  |
[**googleAppListingsCategories**](AppDataApi.md#googleAppListingsCategories) | **GET**  /v3/app_data/google/app_listings/categories  |
[**googleAppListingsSearchLive**](AppDataApi.md#googleAppListingsSearchLive) | **POST**  /v3/app_data/google/app_listings/search/live  |
[**appleCategories**](AppDataApi.md#appleCategories) | **GET**  /v3/app_data/apple/categories  |
[**appDataAppleLocations**](AppDataApi.md#appDataAppleLocations) | **GET**  /v3/app_data/apple/locations  |
[**appDataAppleLanguages**](AppDataApi.md#appDataAppleLanguages) | **GET**  /v3/app_data/apple/languages  |
[**appleAppSearchesTaskPost**](AppDataApi.md#appleAppSearchesTaskPost) | **POST**  /v3/app_data/apple/app_searches/task_post  |
[**appleAppSearchesTasksReady**](AppDataApi.md#appleAppSearchesTasksReady) | **GET**  /v3/app_data/apple/app_searches/tasks_ready  |
[**appleAppSearchesTaskGetAdvanced**](AppDataApi.md#appleAppSearchesTaskGetAdvanced) | **GET**  /v3/app_data/apple/app_searches/task_get/advanced/{id}  |
[**appleAppInfoTaskPost**](AppDataApi.md#appleAppInfoTaskPost) | **POST**  /v3/app_data/apple/app_info/task_post  |
[**appleAppInfoTasksReady**](AppDataApi.md#appleAppInfoTasksReady) | **GET**  /v3/app_data/apple/app_info/tasks_ready  |
[**appleAppInfoTaskGetAdvanced**](AppDataApi.md#appleAppInfoTaskGetAdvanced) | **GET**  /v3/app_data/apple/app_info/task_get/advanced/{id}  |
[**appleAppListTaskPost**](AppDataApi.md#appleAppListTaskPost) | **POST**  /v3/app_data/apple/app_list/task_post  |
[**appleAppListTasksReady**](AppDataApi.md#appleAppListTasksReady) | **GET**  /v3/app_data/apple/app_list/tasks_ready  |
[**appleAppListTaskGetAdvanced**](AppDataApi.md#appleAppListTaskGetAdvanced) | **GET**  /v3/app_data/apple/app_list/task_get/advanced/{id}  |
[**appleAppReviewsTaskPost**](AppDataApi.md#appleAppReviewsTaskPost) | **POST**  /v3/app_data/apple/app_reviews/task_post  |
[**appleAppReviewsTasksReady**](AppDataApi.md#appleAppReviewsTasksReady) | **GET**  /v3/app_data/apple/app_reviews/tasks_ready  |
[**appleAppReviewsTaskGetAdvanced**](AppDataApi.md#appleAppReviewsTaskGetAdvanced) | **GET**  /v3/app_data/apple/app_reviews/task_get/advanced/{id}  |
[**appleAppListingsCategories**](AppDataApi.md#appleAppListingsCategories) | **GET**  /v3/app_data/apple/app_listings/categories  |
[**appleAppListingsSearchLive**](AppDataApi.md#appleAppListingsSearchLive) | **POST**  /v3/app_data/apple/app_listings/search/live  |

<a id="appDataIdList"></a>
# **appDataIdList**
> AppDataIdListResponseInfo appDataIdList()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppDataIdListAsync(new List<AppDataIdListRequestInfo>()
{
    new()
    {
        DatetimeFrom = "2025-06-24 11:17:44 +00:00",
        DatetimeTo = "2025-08-24 11:17:44 +00:00",
        Limit = 100,
        Offset = 0,
        Sort = "desc",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppDataIdListRequestInfo>&gt;**](IEnumerable<AppDataIdListRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataIdListResponseInfo**](AppDataIdListResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appDataErrors"></a>
# **appDataErrors**
> AppDataErrorsResponseInfo appDataErrors()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppDataErrorsAsync(new List<AppDataErrorsRequestInfo>()
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
| **** | [**List&lt;IEnumerable<AppDataErrorsRequestInfo>&gt;**](IEnumerable<AppDataErrorsRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataErrorsResponseInfo**](AppDataErrorsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleCategories"></a>
# **googleCategories**
> AppDataGoogleCategoriesResponseInfo googleCategories()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleCategoriesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleCategoriesResponseInfo**](AppDataGoogleCategoriesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appDataGoogleLocations"></a>
# **appDataGoogleLocations**
> AppDataGoogleLocationsResponseInfo appDataGoogleLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppDataGoogleLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleLocationsResponseInfo**](AppDataGoogleLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appDataGoogleLocationsCountry"></a>
# **appDataGoogleLocationsCountry**
> AppDataGoogleLocationsCountryResponseInfo appDataGoogleLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.AppDataApi.AppDataGoogleLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleLocationsCountryResponseInfo**](AppDataGoogleLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appDataGoogleLanguages"></a>
# **appDataGoogleLanguages**
> AppDataGoogleLanguagesResponseInfo appDataGoogleLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppDataGoogleLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleLanguagesResponseInfo**](AppDataGoogleLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppSearchesTaskPost"></a>
# **googleAppSearchesTaskPost**
> AppDataGoogleAppSearchesTaskPostResponseInfo googleAppSearchesTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppSearchesTaskPostAsync(new List<AppDataGoogleAppSearchesTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "vpn",
        LocationCode = 2840,
        LanguageCode = "en",
        Depth = 30,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppDataGoogleAppSearchesTaskPostRequestInfo>&gt;**](IEnumerable<AppDataGoogleAppSearchesTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataGoogleAppSearchesTaskPostResponseInfo**](AppDataGoogleAppSearchesTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppSearchesTasksReady"></a>
# **googleAppSearchesTasksReady**
> AppDataGoogleAppSearchesTasksReadyResponseInfo googleAppSearchesTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppSearchesTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppSearchesTasksReadyResponseInfo**](AppDataGoogleAppSearchesTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appDataTasksReady"></a>
# **appDataTasksReady**
> AppDataTasksReadyResponseInfo appDataTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppDataTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataTasksReadyResponseInfo**](AppDataTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppSearchesTaskGetAdvanced"></a>
# **googleAppSearchesTaskGetAdvanced**
> AppDataGoogleAppSearchesTaskGetAdvancedResponseInfo googleAppSearchesTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.GoogleAppSearchesTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppSearchesTaskGetAdvancedResponseInfo**](AppDataGoogleAppSearchesTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppSearchesTaskGetHtml"></a>
# **googleAppSearchesTaskGetHtml**
> AppDataGoogleAppSearchesTaskGetHtmlResponseInfo googleAppSearchesTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.GoogleAppSearchesTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppSearchesTaskGetHtmlResponseInfo**](AppDataGoogleAppSearchesTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppListTaskPost"></a>
# **googleAppListTaskPost**
> AppDataGoogleAppListTaskPostResponseInfo googleAppListTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppListTaskPostAsync(new List<AppDataGoogleAppListTaskPostRequestInfo>()
{
    new()
    {
        AppCollection = "topselling_free",
        LocationCode = 2840,
        LanguageCode = "en",
        Depth = 100,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppDataGoogleAppListTaskPostRequestInfo>&gt;**](IEnumerable<AppDataGoogleAppListTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataGoogleAppListTaskPostResponseInfo**](AppDataGoogleAppListTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppListTasksReady"></a>
# **googleAppListTasksReady**
> AppDataGoogleAppListTasksReadyResponseInfo googleAppListTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppListTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppListTasksReadyResponseInfo**](AppDataGoogleAppListTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppListTaskGetAdvanced"></a>
# **googleAppListTaskGetAdvanced**
> AppDataGoogleAppListTaskGetAdvancedResponseInfo googleAppListTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.GoogleAppListTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppListTaskGetAdvancedResponseInfo**](AppDataGoogleAppListTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppListTaskGetHtml"></a>
# **googleAppListTaskGetHtml**
> AppDataGoogleAppListTaskGetHtmlResponseInfo googleAppListTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.GoogleAppListTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppListTaskGetHtmlResponseInfo**](AppDataGoogleAppListTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppInfoTaskPost"></a>
# **googleAppInfoTaskPost**
> AppDataGoogleAppInfoTaskPostResponseInfo googleAppInfoTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppInfoTaskPostAsync(new List<AppDataGoogleAppInfoTaskPostRequestInfo>()
{
    new()
    {
        AppId = "org.telegram.messenger",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppDataGoogleAppInfoTaskPostRequestInfo>&gt;**](IEnumerable<AppDataGoogleAppInfoTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataGoogleAppInfoTaskPostResponseInfo**](AppDataGoogleAppInfoTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppInfoTasksReady"></a>
# **googleAppInfoTasksReady**
> AppDataGoogleAppInfoTasksReadyResponseInfo googleAppInfoTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppInfoTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppInfoTasksReadyResponseInfo**](AppDataGoogleAppInfoTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppInfoTaskGetAdvanced"></a>
# **googleAppInfoTaskGetAdvanced**
> AppDataGoogleAppInfoTaskGetAdvancedResponseInfo googleAppInfoTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.GoogleAppInfoTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppInfoTaskGetAdvancedResponseInfo**](AppDataGoogleAppInfoTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppInfoTaskGetHtml"></a>
# **googleAppInfoTaskGetHtml**
> AppDataGoogleAppInfoTaskGetHtmlResponseInfo googleAppInfoTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.GoogleAppInfoTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppInfoTaskGetHtmlResponseInfo**](AppDataGoogleAppInfoTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppReviewsTaskPost"></a>
# **googleAppReviewsTaskPost**
> AppDataGoogleAppReviewsTaskPostResponseInfo googleAppReviewsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppReviewsTaskPostAsync(new List<AppDataGoogleAppReviewsTaskPostRequestInfo>()
{
    new()
    {
        AppId = "org.telegram.messenger",
        LocationCode = 2840,
        LanguageCode = "en",
        Depth = 150,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppDataGoogleAppReviewsTaskPostRequestInfo>&gt;**](IEnumerable<AppDataGoogleAppReviewsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataGoogleAppReviewsTaskPostResponseInfo**](AppDataGoogleAppReviewsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppReviewsTasksReady"></a>
# **googleAppReviewsTasksReady**
> AppDataGoogleAppReviewsTasksReadyResponseInfo googleAppReviewsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppReviewsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppReviewsTasksReadyResponseInfo**](AppDataGoogleAppReviewsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppReviewsTaskGetAdvanced"></a>
# **googleAppReviewsTaskGetAdvanced**
> AppDataGoogleAppReviewsTaskGetAdvancedResponseInfo googleAppReviewsTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.GoogleAppReviewsTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppReviewsTaskGetAdvancedResponseInfo**](AppDataGoogleAppReviewsTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppReviewsTaskGetHtml"></a>
# **googleAppReviewsTaskGetHtml**
> AppDataGoogleAppReviewsTaskGetHtmlResponseInfo googleAppReviewsTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.GoogleAppReviewsTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppReviewsTaskGetHtmlResponseInfo**](AppDataGoogleAppReviewsTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppListingsCategories"></a>
# **googleAppListingsCategories**
> AppDataGoogleAppListingsCategoriesResponseInfo googleAppListingsCategories()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppListingsCategoriesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataGoogleAppListingsCategoriesResponseInfo**](AppDataGoogleAppListingsCategoriesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="googleAppListingsSearchLive"></a>
# **googleAppListingsSearchLive**
> AppDataGoogleAppListingsSearchLiveResponseInfo googleAppListingsSearchLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.GoogleAppListingsSearchLiveAsync(new List<AppDataGoogleAppListingsSearchLiveRequestInfo>()
{
    new()
    {
        Categories = new List<string>()
        {
            "Tools",
        },
        Description = "vpn",
        Title = "vpn",
        Limit = 10,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppDataGoogleAppListingsSearchLiveRequestInfo>&gt;**](IEnumerable<AppDataGoogleAppListingsSearchLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataGoogleAppListingsSearchLiveResponseInfo**](AppDataGoogleAppListingsSearchLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleCategories"></a>
# **appleCategories**
> AppDataAppleCategoriesResponseInfo appleCategories()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleCategoriesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleCategoriesResponseInfo**](AppDataAppleCategoriesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appDataAppleLocations"></a>
# **appDataAppleLocations**
> AppDataAppleLocationsResponseInfo appDataAppleLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppDataAppleLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleLocationsResponseInfo**](AppDataAppleLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appDataAppleLanguages"></a>
# **appDataAppleLanguages**
> AppDataAppleLanguagesResponseInfo appDataAppleLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppDataAppleLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleLanguagesResponseInfo**](AppDataAppleLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppSearchesTaskPost"></a>
# **appleAppSearchesTaskPost**
> AppDataAppleAppSearchesTaskPostResponseInfo appleAppSearchesTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppSearchesTaskPostAsync(new List<AppDataAppleAppSearchesTaskPostRequestInfo>()
{
    new()
    {
        Keyword = "vpn",
        LocationCode = 2840,
        LanguageCode = "en",
        Depth = 200,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppDataAppleAppSearchesTaskPostRequestInfo>&gt;**](IEnumerable<AppDataAppleAppSearchesTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataAppleAppSearchesTaskPostResponseInfo**](AppDataAppleAppSearchesTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppSearchesTasksReady"></a>
# **appleAppSearchesTasksReady**
> AppDataAppleAppSearchesTasksReadyResponseInfo appleAppSearchesTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppSearchesTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleAppSearchesTasksReadyResponseInfo**](AppDataAppleAppSearchesTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppSearchesTaskGetAdvanced"></a>
# **appleAppSearchesTaskGetAdvanced**
> AppDataAppleAppSearchesTaskGetAdvancedResponseInfo appleAppSearchesTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.AppleAppSearchesTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleAppSearchesTaskGetAdvancedResponseInfo**](AppDataAppleAppSearchesTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppInfoTaskPost"></a>
# **appleAppInfoTaskPost**
> AppDataAppleAppInfoTaskPostResponseInfo appleAppInfoTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppInfoTaskPostAsync(new List<AppDataAppleAppInfoTaskPostRequestInfo>()
{
    new()
    {
        AppId = "835599320",
        LocationCode = 2840,
        LanguageCode = "en",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppDataAppleAppInfoTaskPostRequestInfo>&gt;**](IEnumerable<AppDataAppleAppInfoTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataAppleAppInfoTaskPostResponseInfo**](AppDataAppleAppInfoTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppInfoTasksReady"></a>
# **appleAppInfoTasksReady**
> AppDataAppleAppInfoTasksReadyResponseInfo appleAppInfoTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppInfoTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleAppInfoTasksReadyResponseInfo**](AppDataAppleAppInfoTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppInfoTaskGetAdvanced"></a>
# **appleAppInfoTaskGetAdvanced**
> AppDataAppleAppInfoTaskGetAdvancedResponseInfo appleAppInfoTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.AppleAppInfoTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleAppInfoTaskGetAdvancedResponseInfo**](AppDataAppleAppInfoTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppListTaskPost"></a>
# **appleAppListTaskPost**
> AppDataAppleAppListTaskPostResponseInfo appleAppListTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppListTaskPostAsync(new List<AppDataAppleAppListTaskPostRequestInfo>()
{
    new()
    {
        AppCollection = "top_free_ios",
        LocationCode = 2840,
        LanguageCode = "en",
        Depth = 200,
        AppCategory = "games",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppDataAppleAppListTaskPostRequestInfo>&gt;**](IEnumerable<AppDataAppleAppListTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataAppleAppListTaskPostResponseInfo**](AppDataAppleAppListTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppListTasksReady"></a>
# **appleAppListTasksReady**
> AppDataAppleAppListTasksReadyResponseInfo appleAppListTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppListTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleAppListTasksReadyResponseInfo**](AppDataAppleAppListTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppListTaskGetAdvanced"></a>
# **appleAppListTaskGetAdvanced**
> AppDataAppleAppListTaskGetAdvancedResponseInfo appleAppListTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.AppleAppListTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleAppListTaskGetAdvancedResponseInfo**](AppDataAppleAppListTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppReviewsTaskPost"></a>
# **appleAppReviewsTaskPost**
> AppDataAppleAppReviewsTaskPostResponseInfo appleAppReviewsTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppReviewsTaskPostAsync(new List<AppDataAppleAppReviewsTaskPostRequestInfo>()
{
    new()
    {
        AppId = "835599320",
        LocationCode = 2840,
        LanguageCode = "en",
        Depth = 200,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppDataAppleAppReviewsTaskPostRequestInfo>&gt;**](IEnumerable<AppDataAppleAppReviewsTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataAppleAppReviewsTaskPostResponseInfo**](AppDataAppleAppReviewsTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppReviewsTasksReady"></a>
# **appleAppReviewsTasksReady**
> AppDataAppleAppReviewsTasksReadyResponseInfo appleAppReviewsTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppReviewsTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleAppReviewsTasksReadyResponseInfo**](AppDataAppleAppReviewsTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppReviewsTaskGetAdvanced"></a>
# **appleAppReviewsTaskGetAdvanced**
> AppDataAppleAppReviewsTaskGetAdvancedResponseInfo appleAppReviewsTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AppDataApi.AppleAppReviewsTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleAppReviewsTaskGetAdvancedResponseInfo**](AppDataAppleAppReviewsTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppListingsCategories"></a>
# **appleAppListingsCategories**
> AppDataAppleAppListingsCategoriesResponseInfo appleAppListingsCategories()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppListingsCategoriesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppDataAppleAppListingsCategoriesResponseInfo**](AppDataAppleAppListingsCategoriesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appleAppListingsSearchLive"></a>
# **appleAppListingsSearchLive**
> AppDataAppleAppListingsSearchLiveResponseInfo appleAppListingsSearchLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppDataApi.AppleAppListingsSearchLiveAsync(new List<AppDataAppleAppListingsSearchLiveRequestInfo>()
{
    new()
    {
        Categories = new List<string>()
        {
            "Tools",
        },
        Description = "vpn",
        Title = "vpn",
        Limit = 10,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppDataAppleAppListingsSearchLiveRequestInfo>&gt;**](IEnumerable<AppDataAppleAppListingsSearchLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AppDataAppleAppListingsSearchLiveResponseInfo**](AppDataAppleAppListingsSearchLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |