# BacklinksApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**backlinksIdList**](BacklinksApi.md#backlinksIdList) | **POST**  /v3/backlinks/id_list  |
[**backlinksErrors**](BacklinksApi.md#backlinksErrors) | **POST**  /v3/backlinks/errors  |
[**backlinksAvailableFilters**](BacklinksApi.md#backlinksAvailableFilters) | **GET**  /v3/backlinks/available_filters  |
[**index**](BacklinksApi.md#index) | **GET**  /v3/backlinks/index  |
[**summaryLive**](BacklinksApi.md#summaryLive) | **POST**  /v3/backlinks/summary/live  |
[**historyLive**](BacklinksApi.md#historyLive) | **POST**  /v3/backlinks/history/live  |
[**backlinksLive**](BacklinksApi.md#backlinksLive) | **POST**  /v3/backlinks/backlinks/live  |
[**anchorsLive**](BacklinksApi.md#anchorsLive) | **POST**  /v3/backlinks/anchors/live  |
[**domainPagesLive**](BacklinksApi.md#domainPagesLive) | **POST**  /v3/backlinks/domain_pages/live  |
[**domainPagesSummaryLive**](BacklinksApi.md#domainPagesSummaryLive) | **POST**  /v3/backlinks/domain_pages_summary/live  |
[**referringDomainsLive**](BacklinksApi.md#referringDomainsLive) | **POST**  /v3/backlinks/referring_domains/live  |
[**referringNetworksLive**](BacklinksApi.md#referringNetworksLive) | **POST**  /v3/backlinks/referring_networks/live  |
[**competitorsLive**](BacklinksApi.md#competitorsLive) | **POST**  /v3/backlinks/competitors/live  |
[**domainIntersectionLive**](BacklinksApi.md#domainIntersectionLive) | **POST**  /v3/backlinks/domain_intersection/live  |
[**pageIntersectionLive**](BacklinksApi.md#pageIntersectionLive) | **POST**  /v3/backlinks/page_intersection/live  |
[**timeseriesSummaryLive**](BacklinksApi.md#timeseriesSummaryLive) | **POST**  /v3/backlinks/timeseries_summary/live  |
[**timeseriesNewLostSummaryLive**](BacklinksApi.md#timeseriesNewLostSummaryLive) | **POST**  /v3/backlinks/timeseries_new_lost_summary/live  |
[**bulkRanksLive**](BacklinksApi.md#bulkRanksLive) | **POST**  /v3/backlinks/bulk_ranks/live  |
[**bulkBacklinksLive**](BacklinksApi.md#bulkBacklinksLive) | **POST**  /v3/backlinks/bulk_backlinks/live  |
[**bulkSpamScoreLive**](BacklinksApi.md#bulkSpamScoreLive) | **POST**  /v3/backlinks/bulk_spam_score/live  |
[**bulkReferringDomainsLive**](BacklinksApi.md#bulkReferringDomainsLive) | **POST**  /v3/backlinks/bulk_referring_domains/live  |
[**bulkNewLostBacklinksLive**](BacklinksApi.md#bulkNewLostBacklinksLive) | **POST**  /v3/backlinks/bulk_new_lost_backlinks/live  |
[**bulkNewLostReferringDomainsLive**](BacklinksApi.md#bulkNewLostReferringDomainsLive) | **POST**  /v3/backlinks/bulk_new_lost_referring_domains/live  |
[**bulkPagesSummaryLive**](BacklinksApi.md#bulkPagesSummaryLive) | **POST**  /v3/backlinks/bulk_pages_summary/live  |

<a id="backlinksIdList"></a>
# **backlinksIdList**
> BacklinksIdListResponseInfo backlinksIdList()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BacklinksIdListAsync(
    new BacklinksIdListRequestInfo[]
    {
        new BacklinksIdListRequestInfo()
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
| **** | [**List&lt;IEnumerable<BacklinksIdListRequestInfo>&gt;**](IEnumerable<BacklinksIdListRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksIdListResponseInfo**](BacklinksIdListResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="backlinksErrors"></a>
# **backlinksErrors**
> BacklinksErrorsResponseInfo backlinksErrors()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BacklinksErrorsAsync(
    new BacklinksErrorsRequestInfo[]
    {
        new BacklinksErrorsRequestInfo()
        {
            Limit = 10,
            Offset = 0,
            FilteredFunction = "backlinks/content_duplicates",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksErrorsRequestInfo>&gt;**](IEnumerable<BacklinksErrorsRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksErrorsResponseInfo**](BacklinksErrorsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="backlinksAvailableFilters"></a>
# **backlinksAvailableFilters**
> BacklinksAvailableFiltersResponseInfo backlinksAvailableFilters()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BacklinksAvailableFiltersAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BacklinksAvailableFiltersResponseInfo**](BacklinksAvailableFiltersResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="index"></a>
# **index**
> BacklinksIndexResponseInfo index()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.IndexAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**BacklinksIndexResponseInfo**](BacklinksIndexResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="summaryLive"></a>
# **summaryLive**
> BacklinksSummaryLiveResponseInfo summaryLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.SummaryLiveAsync(
    new BacklinksSummaryLiveRequestInfo[]
    {
        new BacklinksSummaryLiveRequestInfo()
        {
            Target = "explodingtopics.com",
            InternalListLimit = 10,
            IncludeSubdomains = true,
            BacklinksFilters = new object[]
        {
            "dofollow",
            "=",
            true,
        },
            BacklinksStatusType = "all",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksSummaryLiveRequestInfo>&gt;**](IEnumerable<BacklinksSummaryLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksSummaryLiveResponseInfo**](BacklinksSummaryLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="historyLive"></a>
# **historyLive**
> BacklinksHistoryLiveResponseInfo historyLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.HistoryLiveAsync(
    new BacklinksHistoryLiveRequestInfo[]
    {
        new BacklinksHistoryLiveRequestInfo()
        {
            Target = "cnn.com",
            DateFrom = "2020-01-01 00:00:00 +02:00",
            DateTo = "2021-01-01 00:00:00 +02:00",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksHistoryLiveRequestInfo>&gt;**](IEnumerable<BacklinksHistoryLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksHistoryLiveResponseInfo**](BacklinksHistoryLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="backlinksLive"></a>
# **backlinksLive**
> BacklinksBacklinksLiveResponseInfo backlinksLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BacklinksLiveAsync(
    new BacklinksBacklinksLiveRequestInfo[]
    {
        new BacklinksBacklinksLiveRequestInfo()
        {
            Target = "forbes.com",
            Mode = "as_is",
            Filters = new object[]
        {
            "dofollow",
            "=",
            true,
        },
            Limit = 5,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksBacklinksLiveRequestInfo>&gt;**](IEnumerable<BacklinksBacklinksLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksBacklinksLiveResponseInfo**](BacklinksBacklinksLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="anchorsLive"></a>
# **anchorsLive**
> BacklinksAnchorsLiveResponseInfo anchorsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.AnchorsLiveAsync(
    new BacklinksAnchorsLiveRequestInfo[]
    {
        new BacklinksAnchorsLiveRequestInfo()
        {
            Target = "forbes.com",
            Limit = 4,
            OrderBy = new string[]
        {
            "backlinks,desc",
        },
            Filters = new object[]
        {
            "anchor",
            "like",
            "%news%",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksAnchorsLiveRequestInfo>&gt;**](IEnumerable<BacklinksAnchorsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksAnchorsLiveResponseInfo**](BacklinksAnchorsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="domainPagesLive"></a>
# **domainPagesLive**
> BacklinksDomainPagesLiveResponseInfo domainPagesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.DomainPagesLiveAsync(
    new BacklinksDomainPagesLiveRequestInfo[]
    {
        new BacklinksDomainPagesLiveRequestInfo()
        {
            Target = "forbes.com",
            Limit = 5,
            Filters = new object[]
        {
            new object[]
            {
                "page_summary.backlinks",
                ">",
                5,
            },
            "and",
            new object[]
            {
                "page",
                "like",
                "%sites%",
            },
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksDomainPagesLiveRequestInfo>&gt;**](IEnumerable<BacklinksDomainPagesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksDomainPagesLiveResponseInfo**](BacklinksDomainPagesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="domainPagesSummaryLive"></a>
# **domainPagesSummaryLive**
> BacklinksDomainPagesSummaryLiveResponseInfo domainPagesSummaryLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.DomainPagesSummaryLiveAsync(
    new BacklinksDomainPagesSummaryLiveRequestInfo[]
    {
        new BacklinksDomainPagesSummaryLiveRequestInfo()
        {
            Target = "forbes.com",
            Limit = 4,
            OrderBy = new string[]
        {
            "backlinks,desc",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksDomainPagesSummaryLiveRequestInfo>&gt;**](IEnumerable<BacklinksDomainPagesSummaryLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksDomainPagesSummaryLiveResponseInfo**](BacklinksDomainPagesSummaryLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="referringDomainsLive"></a>
# **referringDomainsLive**
> BacklinksReferringDomainsLiveResponseInfo referringDomainsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.ReferringDomainsLiveAsync(
    new BacklinksReferringDomainsLiveRequestInfo[]
    {
        new BacklinksReferringDomainsLiveRequestInfo()
        {
            Target = "backlinko.com",
            Limit = 5,
            OrderBy = new string[]
        {
            "rank,desc",
        },
            ExcludeInternalBacklinks = true,
            BacklinksFilters = new object[]
        {
            "dofollow",
            "=",
            true,
        },
            Filters = new object[]
        {
            "backlinks",
            ">",
            100,
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksReferringDomainsLiveRequestInfo>&gt;**](IEnumerable<BacklinksReferringDomainsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksReferringDomainsLiveResponseInfo**](BacklinksReferringDomainsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="referringNetworksLive"></a>
# **referringNetworksLive**
> BacklinksReferringNetworksLiveResponseInfo referringNetworksLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.ReferringNetworksLiveAsync(
    new BacklinksReferringNetworksLiveRequestInfo[]
    {
        new BacklinksReferringNetworksLiveRequestInfo()
        {
            Target = "backlinko.com",
            NetworkAddressType = "subnet",
            Limit = 5,
            OrderBy = new string[]
        {
            "rank,desc",
        },
            ExcludeInternalBacklinks = true,
            BacklinksFilters = new object[]
        {
            "dofollow",
            "=",
            true,
        },
            Filters = new object[]
        {
            "backlinks",
            ">",
            100,
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksReferringNetworksLiveRequestInfo>&gt;**](IEnumerable<BacklinksReferringNetworksLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksReferringNetworksLiveResponseInfo**](BacklinksReferringNetworksLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="competitorsLive"></a>
# **competitorsLive**
> BacklinksCompetitorsLiveResponseInfo competitorsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.CompetitorsLiveAsync(
    new BacklinksCompetitorsLiveRequestInfo[]
    {
        new BacklinksCompetitorsLiveRequestInfo()
        {
            Target = "dataforseo.com",
            Filters = new object[]
        {
            "rank",
            ">",
            100,
        },
            OrderBy = new string[]
        {
            "rank,desc",
        },
            Limit = 5,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksCompetitorsLiveRequestInfo>&gt;**](IEnumerable<BacklinksCompetitorsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksCompetitorsLiveResponseInfo**](BacklinksCompetitorsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="domainIntersectionLive"></a>
# **domainIntersectionLive**
> BacklinksDomainIntersectionLiveResponseInfo domainIntersectionLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.DomainIntersectionLiveAsync(
    new BacklinksDomainIntersectionLiveRequestInfo[]
    {
        new BacklinksDomainIntersectionLiveRequestInfo()
        {
            Targets = new Dictionary<string, string>()
        {
            ["1"] = "moz.com",
            ["2"] = "ahrefs.com",
        },
            IncludeSubdomains = false,
            ExcludeTargets = new string[]
        {
            "semrush.com",
        },
            Limit = 5,
            OrderBy = new string[]
        {
            "1.backlinks,desc",
        },
            ExcludeInternalBacklinks = true,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksDomainIntersectionLiveRequestInfo>&gt;**](IEnumerable<BacklinksDomainIntersectionLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksDomainIntersectionLiveResponseInfo**](BacklinksDomainIntersectionLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="pageIntersectionLive"></a>
# **pageIntersectionLive**
> BacklinksPageIntersectionLiveResponseInfo pageIntersectionLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.PageIntersectionLiveAsync(
    new BacklinksPageIntersectionLiveRequestInfo[]
    {
        new BacklinksPageIntersectionLiveRequestInfo()
        {
            Targets = new Dictionary<string, string>()
        {
            ["1"] = "football.com",
            ["2"] = "fifa.com",
        },
            ExcludeTargets = new string[]
        {
            "skysports.com",
        },
            Limit = 5,
            OrderBy = new string[]
        {
            "1.rank,desc",
        },
            Filters = new object[]
        {
            new object[]
            {
                "2.domain_from_rank",
                ">",
                400,
            },
            "and",
            new object[]
            {
                "1.dofollow",
                "=",
                true,
            },
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksPageIntersectionLiveRequestInfo>&gt;**](IEnumerable<BacklinksPageIntersectionLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksPageIntersectionLiveResponseInfo**](BacklinksPageIntersectionLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="timeseriesSummaryLive"></a>
# **timeseriesSummaryLive**
> BacklinksTimeseriesSummaryLiveResponseInfo timeseriesSummaryLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.TimeseriesSummaryLiveAsync(
    new BacklinksTimeseriesSummaryLiveRequestInfo[]
    {
        new BacklinksTimeseriesSummaryLiveRequestInfo()
        {
            Target = "dataforseo.com",
            DateFrom = "2021-12-01 00:00:00 +02:00",
            DateTo = "2022-02-01 00:00:00 +02:00",
            GroupRange = "month",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksTimeseriesSummaryLiveRequestInfo>&gt;**](IEnumerable<BacklinksTimeseriesSummaryLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksTimeseriesSummaryLiveResponseInfo**](BacklinksTimeseriesSummaryLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="timeseriesNewLostSummaryLive"></a>
# **timeseriesNewLostSummaryLive**
> BacklinksTimeseriesNewLostSummaryLiveResponseInfo timeseriesNewLostSummaryLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.TimeseriesNewLostSummaryLiveAsync(
    new BacklinksTimeseriesNewLostSummaryLiveRequestInfo[]
    {
        new BacklinksTimeseriesNewLostSummaryLiveRequestInfo()
        {
            Target = "dataforseo.com",
            DateFrom = "2021-12-01 00:00:00 +02:00",
            DateTo = "2022-02-01 00:00:00 +02:00",
            GroupRange = "month",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksTimeseriesNewLostSummaryLiveRequestInfo>&gt;**](IEnumerable<BacklinksTimeseriesNewLostSummaryLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksTimeseriesNewLostSummaryLiveResponseInfo**](BacklinksTimeseriesNewLostSummaryLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bulkRanksLive"></a>
# **bulkRanksLive**
> BacklinksBulkRanksLiveResponseInfo bulkRanksLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BulkRanksLiveAsync(
    new BacklinksBulkRanksLiveRequestInfo[]
    {
        new BacklinksBulkRanksLiveRequestInfo()
        {
            Targets = new string[]
        {
            "forbes.com",
            "cnn.com",
            "bbc.com",
            "yelp.com",
            "https://www.apple.com/iphone/",
            "https://ahrefs.com/blog/",
            "ibm.com",
            "https://variety.com/",
            "https://stackoverflow.com/",
            "www.trustpilot.com",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksBulkRanksLiveRequestInfo>&gt;**](IEnumerable<BacklinksBulkRanksLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksBulkRanksLiveResponseInfo**](BacklinksBulkRanksLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bulkBacklinksLive"></a>
# **bulkBacklinksLive**
> BacklinksBulkBacklinksLiveResponseInfo bulkBacklinksLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BulkBacklinksLiveAsync(
    new BacklinksBulkBacklinksLiveRequestInfo[]
    {
        new BacklinksBulkBacklinksLiveRequestInfo()
        {
            Targets = new string[]
        {
            "forbes.com",
            "cnn.com",
            "bbc.com",
            "yelp.com",
            "https://www.apple.com/iphone/",
            "https://ahrefs.com/blog/",
            "ibm.com",
            "https://variety.com/",
            "https://stackoverflow.com/",
            "www.trustpilot.com",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksBulkBacklinksLiveRequestInfo>&gt;**](IEnumerable<BacklinksBulkBacklinksLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksBulkBacklinksLiveResponseInfo**](BacklinksBulkBacklinksLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bulkSpamScoreLive"></a>
# **bulkSpamScoreLive**
> BacklinksBulkSpamScoreLiveResponseInfo bulkSpamScoreLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BulkSpamScoreLiveAsync(
    new BacklinksBulkSpamScoreLiveRequestInfo[]
    {
        new BacklinksBulkSpamScoreLiveRequestInfo()
        {
            Targets = new string[]
        {
            "forbes.com",
            "cnn.com",
            "bbc.com",
            "yelp.com",
            "https://www.apple.com/iphone/",
            "https://ahrefs.com/blog/",
            "ibm.com",
            "https://variety.com/",
            "https://stackoverflow.com/",
            "www.trustpilot.com",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksBulkSpamScoreLiveRequestInfo>&gt;**](IEnumerable<BacklinksBulkSpamScoreLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksBulkSpamScoreLiveResponseInfo**](BacklinksBulkSpamScoreLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bulkReferringDomainsLive"></a>
# **bulkReferringDomainsLive**
> BacklinksBulkReferringDomainsLiveResponseInfo bulkReferringDomainsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BulkReferringDomainsLiveAsync(
    new BacklinksBulkReferringDomainsLiveRequestInfo[]
    {
        new BacklinksBulkReferringDomainsLiveRequestInfo()
        {
            Targets = new string[]
        {
            "forbes.com",
            "cnn.com",
            "bbc.com",
            "yelp.com",
            "https://www.apple.com/iphone/",
            "https://ahrefs.com/blog/",
            "ibm.com",
            "https://variety.com/",
            "https://stackoverflow.com/",
            "www.trustpilot.com",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksBulkReferringDomainsLiveRequestInfo>&gt;**](IEnumerable<BacklinksBulkReferringDomainsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksBulkReferringDomainsLiveResponseInfo**](BacklinksBulkReferringDomainsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bulkNewLostBacklinksLive"></a>
# **bulkNewLostBacklinksLive**
> BacklinksBulkNewLostBacklinksLiveResponseInfo bulkNewLostBacklinksLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BulkNewLostBacklinksLiveAsync(
    new BacklinksBulkNewLostBacklinksLiveRequestInfo[]
    {
        new BacklinksBulkNewLostBacklinksLiveRequestInfo()
        {
            Targets = new string[]
        {
            "forbes.com",
            "cnn.com",
            "bbc.com",
            "yelp.com",
            "https://www.apple.com/iphone/",
            "https://ahrefs.com/blog/",
            "ibm.com",
            "https://variety.com/",
            "https://stackoverflow.com/",
            "www.trustpilot.com",
        },
            DateFrom = "2021-01-01 00:00:00 +02:00",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksBulkNewLostBacklinksLiveRequestInfo>&gt;**](IEnumerable<BacklinksBulkNewLostBacklinksLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksBulkNewLostBacklinksLiveResponseInfo**](BacklinksBulkNewLostBacklinksLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bulkNewLostReferringDomainsLive"></a>
# **bulkNewLostReferringDomainsLive**
> BacklinksBulkNewLostReferringDomainsLiveResponseInfo bulkNewLostReferringDomainsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BulkNewLostReferringDomainsLiveAsync(
    new BacklinksBulkNewLostReferringDomainsLiveRequestInfo[]
    {
        new BacklinksBulkNewLostReferringDomainsLiveRequestInfo()
        {
            Targets = new string[]
        {
            "forbes.com",
            "cnn.com",
            "bbc.com",
            "yelp.com",
            "https://www.apple.com/iphone/",
            "https://ahrefs.com/blog/",
            "ibm.com",
            "https://variety.com/",
            "https://stackoverflow.com/",
            "www.trustpilot.com",
        },
            DateFrom = "2023-09-01 00:00:00 +03:00",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksBulkNewLostReferringDomainsLiveRequestInfo>&gt;**](IEnumerable<BacklinksBulkNewLostReferringDomainsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksBulkNewLostReferringDomainsLiveResponseInfo**](BacklinksBulkNewLostReferringDomainsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="bulkPagesSummaryLive"></a>
# **bulkPagesSummaryLive**
> BacklinksBulkPagesSummaryLiveResponseInfo bulkPagesSummaryLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.BacklinksApi.BulkPagesSummaryLiveAsync(
    new BacklinksBulkPagesSummaryLiveRequestInfo[]
    {
        new BacklinksBulkPagesSummaryLiveRequestInfo()
        {
            Targets = new string[]
        {
            "https://dataforseo.com/solutions",
            "https://dataforseo.com/about-us",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<BacklinksBulkPagesSummaryLiveRequestInfo>&gt;**](IEnumerable<BacklinksBulkPagesSummaryLiveRequestInfo>.md)|  | [optional] |



### Return type

[**BacklinksBulkPagesSummaryLiveResponseInfo**](BacklinksBulkPagesSummaryLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |