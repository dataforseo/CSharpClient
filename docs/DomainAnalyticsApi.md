# DomainAnalyticsApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**domainAnalyticsIdList**](DomainAnalyticsApi.md#domainAnalyticsIdList) | **POST**  /v3/domain_analytics/id_list  |
[**domainAnalyticsErrors**](DomainAnalyticsApi.md#domainAnalyticsErrors) | **POST**  /v3/domain_analytics/errors  |
[**technologiesAvailableFilters**](DomainAnalyticsApi.md#technologiesAvailableFilters) | **GET**  /v3/domain_analytics/technologies/available_filters  |
[**technologiesLocations**](DomainAnalyticsApi.md#technologiesLocations) | **GET**  /v3/domain_analytics/technologies/locations  |
[**technologiesLanguages**](DomainAnalyticsApi.md#technologiesLanguages) | **GET**  /v3/domain_analytics/technologies/languages  |
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
var result = await dfsClient.DomainAnalyticsApi.DomainAnalyticsIdListAsync(
    new DomainAnalyticsIdListRequestInfo[]
    {
        new DomainAnalyticsIdListRequestInfo()
        {
            DatetimeFrom = "2023-01-31 00:00:00 +02:00",
            DatetimeTo = "2023-02-01 00:00:00 +02:00",
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
var result = await dfsClient.DomainAnalyticsApi.DomainAnalyticsErrorsAsync(
    new DomainAnalyticsErrorsRequestInfo[]
    {
        new DomainAnalyticsErrorsRequestInfo()
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

<a id="technologiesLocations"></a>
# **technologiesLocations**
> DomainAnalyticsTechnologiesLocationsResponseInfo technologiesLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesLocationsAsync();
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

<a id="technologiesLanguages"></a>
# **technologiesLanguages**
> DomainAnalyticsTechnologiesLanguagesResponseInfo technologiesLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.DomainAnalyticsApi.TechnologiesLanguagesAsync();
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
var result = await dfsClient.DomainAnalyticsApi.TechnologiesAggregationTechnologiesLiveAsync(
    new DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo[]
    {
        new DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo()
        {
            Mode = "entry",
            Technology = "Nginx",
            Keyword = "WordPress",
            Filters = new object[]
        {
            new object[]
            {
                "country_iso_code",
                "=",
                "US",
            },
            "and",
            new object[]
            {
                "domain_rank",
                ">",
                800,
            },
        },
            OrderBy = new string[]
        {
            "groups_count,desc",
        },
            Limit = 10,
        },
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
var result = await dfsClient.DomainAnalyticsApi.TechnologiesTechnologiesSummaryLiveAsync(
    new DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo[]
    {
        new DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo()
        {
            Mode = "entry",
            Technologies = new string[]
        {
            "Ngi",
        },
            Keywords = new string[]
        {
            "WordPress",
        },
            Filters = new object[]
        {
            new object[]
            {
                "country_iso_code",
                "=",
                "US",
            },
            "and",
            new object[]
            {
                "domain_rank",
                ">",
                800,
            },
        },
        },
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
var result = await dfsClient.DomainAnalyticsApi.TechnologiesTechnologyStatsLiveAsync(
    new DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo[]
    {
        new DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo()
        {
            Technology = "jQuery",
            DateFrom = "2022-10-31 00:00:00 +02:00",
            DateTo = "2023-06-01 00:00:00 +03:00",
        },
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
var result = await dfsClient.DomainAnalyticsApi.TechnologiesDomainsByTechnologyLiveAsync(
    new DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo[]
    {
        new DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo()
        {
            Technologies = new string[]
        {
            "Nginx",
        },
            Filters = new object[]
        {
            new object[]
            {
                "country_iso_code",
                "=",
                "US",
            },
            "and",
            new object[]
            {
                "domain_rank",
                ">",
                800,
            },
        },
            OrderBy = new string[]
        {
            "last_visited,desc",
        },
            Limit = 10,
        },
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
var result = await dfsClient.DomainAnalyticsApi.TechnologiesDomainsByHtmlTermsLiveAsync(
    new DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo[]
    {
        new DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo()
        {
            SearchTerms = new string[]
        {
            "data-attrid",
        },
            OrderBy = new string[]
        {
            "last_visited,desc",
        },
            Limit = 10,
            Offset = 0,
        },
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
var result = await dfsClient.DomainAnalyticsApi.TechnologiesDomainTechnologiesLiveAsync(
    new DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo[]
    {
        new DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo()
        {
            Target = "dataforseo.com",
        },
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
var result = await dfsClient.DomainAnalyticsApi.WhoisOverviewLiveAsync(
    new DomainAnalyticsWhoisOverviewLiveRequestInfo[]
    {
        new DomainAnalyticsWhoisOverviewLiveRequestInfo()
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