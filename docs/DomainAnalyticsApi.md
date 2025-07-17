# DomainAnalyticsApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**domainAnalyticsIdList**](DomainAnalyticsApi.md#domainAnalyticsIdList) | **POST**  /v3/domain_analytics/id_list  |
[**domainAnalyticsErrors**](DomainAnalyticsApi.md#domainAnalyticsErrors) | **POST**  /v3/domain_analytics/errors  |
[**technologiesAvailableFilters**](DomainAnalyticsApi.md#technologiesAvailableFilters) | **GET**  /v3/domain_analytics/technologies/available_filters  |
[**domainAnalyticsTechnologiesLocations**](DomainAnalyticsApi.md#domainAnalyticsTechnologiesLocations) | **GET**  /v3/domain_analytics/technologies/locations  |
[**domainAnalyticsTechnologiesLanguages**](DomainAnalyticsApi.md#domainAnalyticsTechnologiesLanguages) | **GET**  /v3/domain_analytics/technologies/languages  |
[**technologiesTechnologies**](DomainAnalyticsApi.md#technologiesTechnologies) | **GET**  /v3/domain_analytics/technologies/technologies  |
[**technologiesAggregationTechnologiesLive**](DomainAnalyticsApi.md#technologiesAggregationTechnologiesLive) | **POST**  /v3/domain_analytics/technologies/aggregation_technologies/live  |
[**technologiesTechnologiesSummaryLive**](DomainAnalyticsApi.md#technologiesTechnologiesSummaryLive) | **POST**  /v3/domain_analytics/technologies/technologies_summary/live  |
[**technologiesTechnologyStatsLive**](DomainAnalyticsApi.md#technologiesTechnologyStatsLive) | **POST**  /v3/domain_analytics/technologies/technology_stats/live  |
[**technologiesDomainsByTechnologyLive**](DomainAnalyticsApi.md#technologiesDomainsByTechnologyLive) | **POST**  /v3/domain_analytics/technologies/domains_by_technology/live  |
[**technologiesDomainsByHtmlTermsLive**](DomainAnalyticsApi.md#technologiesDomainsByHtmlTermsLive) | **POST**  /v3/domain_analytics/technologies/domains_by_html_terms/live  |
[**technologiesDomainTechnologiesLive**](DomainAnalyticsApi.md#technologiesDomainTechnologiesLive) | **POST**  /v3/domain_analytics/technologies/domain_technologies/live  |
[**whoisAvailableFilters**](DomainAnalyticsApi.md#whoisAvailableFilters) | **GET**  /v3/domain_analytics/whois/available_filters  |
[**whoisOverviewLive**](DomainAnalyticsApi.md#whoisOverviewLive) | **POST**  /v3/domain_analytics/whois/overview/live  |

<a id="domainAnalyticsIdList"></a>
# **domainAnalyticsIdList**
> DomainAnalyticsIdListResponseInfo domainAnalyticsIdList()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.DomainAnalyticsIdListAsync(new List<DomainAnalyticsIdListRequestInfo>()
{
    new()
    {
        DatetimeFrom = "2025-04-17 06:08:16 +00:00",
        DatetimeTo = "2025-06-17 06:08:16 +00:00",
        Limit = 100,
        Offset = 0,
        Sort = "desc",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DomainAnalyticsIdListRequestInfo>&gt;**](IEnumerable<DomainAnalyticsIdListRequestInfo>.md)|  | [optional] |



### Return type

[**DomainAnalyticsIdListResponseInfo**](DomainAnalyticsIdListResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="domainAnalyticsErrors"></a>
# **domainAnalyticsErrors**
> DomainAnalyticsErrorsResponseInfo domainAnalyticsErrors()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.DomainAnalyticsErrorsAsync(new List<DomainAnalyticsErrorsRequestInfo>()
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
| **** | [**List&lt;IEnumerable<DomainAnalyticsErrorsRequestInfo>&gt;**](IEnumerable<DomainAnalyticsErrorsRequestInfo>.md)|  | [optional] |



### Return type

[**DomainAnalyticsErrorsResponseInfo**](DomainAnalyticsErrorsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="technologiesAvailableFilters"></a>
# **technologiesAvailableFilters**
> DomainAnalyticsTechnologiesAvailableFiltersResponseInfo technologiesAvailableFilters()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesAvailableFiltersAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**DomainAnalyticsTechnologiesAvailableFiltersResponseInfo**](DomainAnalyticsTechnologiesAvailableFiltersResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="domainAnalyticsTechnologiesLocations"></a>
# **domainAnalyticsTechnologiesLocations**
> DomainAnalyticsTechnologiesLocationsResponseInfo domainAnalyticsTechnologiesLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.DomainAnalyticsTechnologiesLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**DomainAnalyticsTechnologiesLocationsResponseInfo**](DomainAnalyticsTechnologiesLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="domainAnalyticsTechnologiesLanguages"></a>
# **domainAnalyticsTechnologiesLanguages**
> DomainAnalyticsTechnologiesLanguagesResponseInfo domainAnalyticsTechnologiesLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.DomainAnalyticsTechnologiesLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**DomainAnalyticsTechnologiesLanguagesResponseInfo**](DomainAnalyticsTechnologiesLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="technologiesTechnologies"></a>
# **technologiesTechnologies**
> DomainAnalyticsTechnologiesTechnologiesResponseInfo technologiesTechnologies()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesTechnologiesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**DomainAnalyticsTechnologiesTechnologiesResponseInfo**](DomainAnalyticsTechnologiesTechnologiesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="technologiesAggregationTechnologiesLive"></a>
# **technologiesAggregationTechnologiesLive**
> DomainAnalyticsTechnologiesAggregationTechnologiesLiveResponseInfo technologiesAggregationTechnologiesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesAggregationTechnologiesLiveAsync(new List<DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo>()
{
    new()
    {
        Technology = "Nginx",
        Keyword = "WordPress",
        Mode = "entry",
        Limit = 10,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo>&gt;**](IEnumerable<DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DomainAnalyticsTechnologiesAggregationTechnologiesLiveResponseInfo**](DomainAnalyticsTechnologiesAggregationTechnologiesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="technologiesTechnologiesSummaryLive"></a>
# **technologiesTechnologiesSummaryLive**
> DomainAnalyticsTechnologiesTechnologiesSummaryLiveResponseInfo technologiesTechnologiesSummaryLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesTechnologiesSummaryLiveAsync(new List<DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo>()
{
    new()
    {
        Technologies = new List<string>()
        {
            "Ngi",
        },
        Keywords = new List<string>()
        {
            "WordPress",
        },
        Mode = "entry",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo>&gt;**](IEnumerable<DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DomainAnalyticsTechnologiesTechnologiesSummaryLiveResponseInfo**](DomainAnalyticsTechnologiesTechnologiesSummaryLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="technologiesTechnologyStatsLive"></a>
# **technologiesTechnologyStatsLive**
> DomainAnalyticsTechnologiesTechnologyStatsLiveResponseInfo technologiesTechnologyStatsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesTechnologyStatsLiveAsync(new List<DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo>()
{
    new()
    {
        Technology = "jQuery",
        DateFrom = "2025-04-17",
        DateTo = "2025-06-17",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo>&gt;**](IEnumerable<DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DomainAnalyticsTechnologiesTechnologyStatsLiveResponseInfo**](DomainAnalyticsTechnologiesTechnologyStatsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="technologiesDomainsByTechnologyLive"></a>
# **technologiesDomainsByTechnologyLive**
> DomainAnalyticsTechnologiesDomainsByTechnologyLiveResponseInfo technologiesDomainsByTechnologyLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesDomainsByTechnologyLiveAsync(new List<DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo>()
{
    new()
    {
        Technologies = new List<string>()
        {
            "Nginx",
        },
        Limit = 10,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo>&gt;**](IEnumerable<DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DomainAnalyticsTechnologiesDomainsByTechnologyLiveResponseInfo**](DomainAnalyticsTechnologiesDomainsByTechnologyLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="technologiesDomainsByHtmlTermsLive"></a>
# **technologiesDomainsByHtmlTermsLive**
> DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveResponseInfo technologiesDomainsByHtmlTermsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesDomainsByHtmlTermsLiveAsync(new List<DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo>()
{
    new()
    {
        SearchTerms = new List<string>()
        {
            "data-attrid",
        },
        Limit = 10,
        Offset = 0,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo>&gt;**](IEnumerable<DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveResponseInfo**](DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="technologiesDomainTechnologiesLive"></a>
# **technologiesDomainTechnologiesLive**
> DomainAnalyticsTechnologiesDomainTechnologiesLiveResponseInfo technologiesDomainTechnologiesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesDomainTechnologiesLiveAsync(new List<DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo>()
{
    new()
    {
        Target = "dataforseo.com",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo>&gt;**](IEnumerable<DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DomainAnalyticsTechnologiesDomainTechnologiesLiveResponseInfo**](DomainAnalyticsTechnologiesDomainTechnologiesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="whoisAvailableFilters"></a>
# **whoisAvailableFilters**
> DomainAnalyticsWhoisAvailableFiltersResponseInfo whoisAvailableFilters()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.WhoisAvailableFiltersAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**DomainAnalyticsWhoisAvailableFiltersResponseInfo**](DomainAnalyticsWhoisAvailableFiltersResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="whoisOverviewLive"></a>
# **whoisOverviewLive**
> DomainAnalyticsWhoisOverviewLiveResponseInfo whoisOverviewLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.WhoisOverviewLiveAsync(new List<DomainAnalyticsWhoisOverviewLiveRequestInfo>()
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
| **** | [**List&lt;IEnumerable<DomainAnalyticsWhoisOverviewLiveRequestInfo>&gt;**](IEnumerable<DomainAnalyticsWhoisOverviewLiveRequestInfo>.md)|  | [optional] |



### Return type

[**DomainAnalyticsWhoisOverviewLiveResponseInfo**](DomainAnalyticsWhoisOverviewLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |