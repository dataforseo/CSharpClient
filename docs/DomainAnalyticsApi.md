# DomainAnalyticsApi

Namespace: DataForSeo.Client.Api

```csharp
public class DomainAnalyticsApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/Object) → [DomainAnalyticsApi](./DomainAnalyticsApi.md)

## Properties

### **BaseUrl**

```csharp
public string BaseUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>

### **ReadResponseAsString**

```csharp
public bool ReadResponseAsString { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/Boolean)<br>

## Constructors

### **DomainAnalyticsApi(HttpClient)**

```csharp
public DomainAnalyticsApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **DomainAnalyticsIdListAsync(IEnumerable&lt;DomainAnalyticsIdListRequestInfo&gt;)**

```csharp
public Task<DomainAnalyticsIdListResponseInfo> DomainAnalyticsIdListAsync(IEnumerable<DomainAnalyticsIdListRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsIdListRequestInfo&gt;](./DomainAnalyticsIdListRequestInfo.md)<br>

#### Returns

[Task&lt;DomainAnalyticsIdListResponseInfo&gt;](./DomainAnalyticsIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Domain Analytics tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/id_list/?bash'

### **DomainAnalyticsIdListAsync(IEnumerable&lt;DomainAnalyticsIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DomainAnalyticsIdListResponseInfo> DomainAnalyticsIdListAsync(IEnumerable<DomainAnalyticsIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsIdListRequestInfo&gt;](./DomainAnalyticsIdListRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsIdListResponseInfo&gt;](./DomainAnalyticsIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Domain Analytics tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/id_list/?bash'

### **DomainAnalyticsErrorsAsync(IEnumerable&lt;DomainAnalyticsErrorsRequestInfo&gt;)**

```csharp
public Task<DomainAnalyticsErrorsResponseInfo> DomainAnalyticsErrorsAsync(IEnumerable<DomainAnalyticsErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsErrorsRequestInfo&gt;](./DomainAnalyticsErrorsRequestInfo.md)<br>

#### Returns

[Task&lt;DomainAnalyticsErrorsResponseInfo&gt;](./DomainAnalyticsErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Domain Analytics API tasks that returned an error within the past 7 days.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/errors/?bash'

### **DomainAnalyticsErrorsAsync(IEnumerable&lt;DomainAnalyticsErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DomainAnalyticsErrorsResponseInfo> DomainAnalyticsErrorsAsync(IEnumerable<DomainAnalyticsErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsErrorsRequestInfo&gt;](./DomainAnalyticsErrorsRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsErrorsResponseInfo&gt;](./DomainAnalyticsErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Domain Analytics API tasks that returned an error within the past 7 days.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/errors/?bash'

### **TechnologiesAvailableFiltersAsync()**

```csharp
public Task<DomainAnalyticsTechnologiesAvailableFiltersResponseInfo> TechnologiesAvailableFiltersAsync()
```

#### Returns

[Task&lt;DomainAnalyticsTechnologiesAvailableFiltersResponseInfo&gt;](./DomainAnalyticsTechnologiesAvailableFiltersResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Here you will find all the necessary information about filters that can be used with Domain Analytics Technologies API endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/filters/?bash'

### **TechnologiesAvailableFiltersAsync(CancellationToken)**

```csharp
public Task<DomainAnalyticsTechnologiesAvailableFiltersResponseInfo> TechnologiesAvailableFiltersAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsTechnologiesAvailableFiltersResponseInfo&gt;](./DomainAnalyticsTechnologiesAvailableFiltersResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Here you will find all the necessary information about filters that can be used with Domain Analytics Technologies API endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/filters/?bash'

### **DomainAnalyticsTechnologiesLocationsAsync()**

```csharp
public Task<DomainAnalyticsTechnologiesLocationsResponseInfo> DomainAnalyticsTechnologiesLocationsAsync()
```

#### Returns

[Task&lt;DomainAnalyticsTechnologiesLocationsResponseInfo&gt;](./DomainAnalyticsTechnologiesLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/locations/?bash'

### **DomainAnalyticsTechnologiesLocationsAsync(CancellationToken)**

```csharp
public Task<DomainAnalyticsTechnologiesLocationsResponseInfo> DomainAnalyticsTechnologiesLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsTechnologiesLocationsResponseInfo&gt;](./DomainAnalyticsTechnologiesLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/locations/?bash'

### **DomainAnalyticsTechnologiesLanguagesAsync()**

```csharp
public Task<DomainAnalyticsTechnologiesLanguagesResponseInfo> DomainAnalyticsTechnologiesLanguagesAsync()
```

#### Returns

[Task&lt;DomainAnalyticsTechnologiesLanguagesResponseInfo&gt;](./DomainAnalyticsTechnologiesLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br> 
 <br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/languages/?bash'

### **DomainAnalyticsTechnologiesLanguagesAsync(CancellationToken)**

```csharp
public Task<DomainAnalyticsTechnologiesLanguagesResponseInfo> DomainAnalyticsTechnologiesLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsTechnologiesLanguagesResponseInfo&gt;](./DomainAnalyticsTechnologiesLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br> 
 <br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/languages/?bash'

### **TechnologiesTechnologiesAsync()**

```csharp
public Task<DomainAnalyticsTechnologiesTechnologiesResponseInfo> TechnologiesTechnologiesAsync()
```

#### Returns

[Task&lt;DomainAnalyticsTechnologiesTechnologiesResponseInfo&gt;](./DomainAnalyticsTechnologiesTechnologiesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the full list of available technologies structured by technology groups and categories each particular technology belongs to.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/technologies/?bash'

### **TechnologiesTechnologiesAsync(CancellationToken)**

```csharp
public Task<DomainAnalyticsTechnologiesTechnologiesResponseInfo> TechnologiesTechnologiesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsTechnologiesTechnologiesResponseInfo&gt;](./DomainAnalyticsTechnologiesTechnologiesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the full list of available technologies structured by technology groups and categories each particular technology belongs to.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/technologies/?bash'

### **TechnologiesAggregationTechnologiesLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo&gt;)**

```csharp
public Task<DomainAnalyticsTechnologiesAggregationTechnologiesLiveResponseInfo> TechnologiesAggregationTechnologiesLiveAsync(IEnumerable<DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DomainAnalyticsTechnologiesAggregationTechnologiesLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesAggregationTechnologiesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Aggregation Technologies endpoint will provide you with a list of the most popular technologies websites use alongside the technologies you specify. Alternatively, you can specify technology categories or groups to obtain wider stats.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/aggregation_technologies/live/?bash'

### **TechnologiesAggregationTechnologiesLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DomainAnalyticsTechnologiesAggregationTechnologiesLiveResponseInfo> TechnologiesAggregationTechnologiesLiveAsync(IEnumerable<DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsTechnologiesAggregationTechnologiesLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesAggregationTechnologiesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Aggregation Technologies endpoint will provide you with a list of the most popular technologies websites use alongside the technologies you specify. Alternatively, you can specify technology categories or groups to obtain wider stats.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/aggregation_technologies/live/?bash'

### **TechnologiesTechnologiesSummaryLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo&gt;)**

```csharp
public Task<DomainAnalyticsTechnologiesTechnologiesSummaryLiveResponseInfo> TechnologiesTechnologiesSummaryLiveAsync(IEnumerable<DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DomainAnalyticsTechnologiesTechnologiesSummaryLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesTechnologiesSummaryLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Technologies Summary endpoint will provide you with the number of domains across different countries and languages that use the specified technology names, technology groups, or technology categories.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/technologies_summary/live/?bash'

### **TechnologiesTechnologiesSummaryLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DomainAnalyticsTechnologiesTechnologiesSummaryLiveResponseInfo> TechnologiesTechnologiesSummaryLiveAsync(IEnumerable<DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsTechnologiesTechnologiesSummaryLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesTechnologiesSummaryLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Technologies Summary endpoint will provide you with the number of domains across different countries and languages that use the specified technology names, technology groups, or technology categories.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/technologies_summary/live/?bash'

### **TechnologiesTechnologyStatsLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo&gt;)**

```csharp
public Task<DomainAnalyticsTechnologiesTechnologyStatsLiveResponseInfo> TechnologiesTechnologyStatsLiveAsync(IEnumerable<DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DomainAnalyticsTechnologiesTechnologyStatsLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesTechnologyStatsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Technology Stats endpoint will provide you with historical data on the number of domains across different countries and languages that use the specified technology.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/technology_stats/live/?bash'

### **TechnologiesTechnologyStatsLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DomainAnalyticsTechnologiesTechnologyStatsLiveResponseInfo> TechnologiesTechnologyStatsLiveAsync(IEnumerable<DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsTechnologiesTechnologyStatsLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesTechnologyStatsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Technology Stats endpoint will provide you with historical data on the number of domains across different countries and languages that use the specified technology.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/technology_stats/live/?bash'

### **TechnologiesDomainsByTechnologyLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo&gt;)**

```csharp
public Task<DomainAnalyticsTechnologiesDomainsByTechnologyLiveResponseInfo> TechnologiesDomainsByTechnologyLiveAsync(IEnumerable<DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DomainAnalyticsTechnologiesDomainsByTechnologyLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesDomainsByTechnologyLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides domains based on the technology they use. In addition to the list of domains, you will also get their technology profiles, the country and language they belong to, and other related data.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/domains_by_technology/live/?bash'

### **TechnologiesDomainsByTechnologyLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DomainAnalyticsTechnologiesDomainsByTechnologyLiveResponseInfo> TechnologiesDomainsByTechnologyLiveAsync(IEnumerable<DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsTechnologiesDomainsByTechnologyLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesDomainsByTechnologyLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides domains based on the technology they use. In addition to the list of domains, you will also get their technology profiles, the country and language they belong to, and other related data.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/domains_by_technology/live/?bash'

### **TechnologiesDomainsByHtmlTermsLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo&gt;)**

```csharp
public Task<DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveResponseInfo> TechnologiesDomainsByHtmlTermsLiveAsync(IEnumerable<DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides domains based on the HTML terms they use on their homepage. In addition to the list of domains, you will also get their technology profiles, the country and language they belong to, and other related data.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/domains_by_html_terms/live/?bash'

### **TechnologiesDomainsByHtmlTermsLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveResponseInfo> TechnologiesDomainsByHtmlTermsLiveAsync(IEnumerable<DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides domains based on the HTML terms they use on their homepage. In addition to the list of domains, you will also get their technology profiles, the country and language they belong to, and other related data.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/domains_by_html_terms/live/?bash'

### **TechnologiesDomainTechnologiesLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo&gt;)**

```csharp
public Task<DomainAnalyticsTechnologiesDomainTechnologiesLiveResponseInfo> TechnologiesDomainTechnologiesLiveAsync(IEnumerable<DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DomainAnalyticsTechnologiesDomainTechnologiesLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesDomainTechnologiesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Using this endpoint you will get a list of technologies used in a particular domain.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/domain_technologies/live/?bash'

### **TechnologiesDomainTechnologiesLiveAsync(IEnumerable&lt;DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DomainAnalyticsTechnologiesDomainTechnologiesLiveResponseInfo> TechnologiesDomainTechnologiesLiveAsync(IEnumerable<DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo&gt;](./DomainAnalyticsTechnologiesDomainTechnologiesLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsTechnologiesDomainTechnologiesLiveResponseInfo&gt;](./DomainAnalyticsTechnologiesDomainTechnologiesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Using this endpoint you will get a list of technologies used in a particular domain.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/technologies/domain_technologies/live/?bash'

### **WhoisAvailableFiltersAsync()**

```csharp
public Task<DomainAnalyticsWhoisAvailableFiltersResponseInfo> WhoisAvailableFiltersAsync()
```

#### Returns

[Task&lt;DomainAnalyticsWhoisAvailableFiltersResponseInfo&gt;](./DomainAnalyticsWhoisAvailableFiltersResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Here you will find all the necessary information about filters that can be used with Domain Analytics Whois API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/whois/filters/?bash'

### **WhoisAvailableFiltersAsync(CancellationToken)**

```csharp
public Task<DomainAnalyticsWhoisAvailableFiltersResponseInfo> WhoisAvailableFiltersAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsWhoisAvailableFiltersResponseInfo&gt;](./DomainAnalyticsWhoisAvailableFiltersResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Here you will find all the necessary information about filters that can be used with Domain Analytics Whois API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/whois/filters/?bash'

### **WhoisOverviewLiveAsync(IEnumerable&lt;DomainAnalyticsWhoisOverviewLiveRequestInfo&gt;)**

```csharp
public Task<DomainAnalyticsWhoisOverviewLiveResponseInfo> WhoisOverviewLiveAsync(IEnumerable<DomainAnalyticsWhoisOverviewLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsWhoisOverviewLiveRequestInfo&gt;](./DomainAnalyticsWhoisOverviewLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DomainAnalyticsWhoisOverviewLiveResponseInfo&gt;](./DomainAnalyticsWhoisOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with Whois data enriched with backlink stats, and ranking and traffic info from organic and paid search results. Using this endpoint you will be able to get all these data for the domains matching the parameters you specify in the request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/whois/overview/live/?bash'

### **WhoisOverviewLiveAsync(IEnumerable&lt;DomainAnalyticsWhoisOverviewLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DomainAnalyticsWhoisOverviewLiveResponseInfo> WhoisOverviewLiveAsync(IEnumerable<DomainAnalyticsWhoisOverviewLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DomainAnalyticsWhoisOverviewLiveRequestInfo&gt;](./DomainAnalyticsWhoisOverviewLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DomainAnalyticsWhoisOverviewLiveResponseInfo&gt;](./DomainAnalyticsWhoisOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with Whois data enriched with backlink stats, and ranking and traffic info from organic and paid search results. Using this endpoint you will be able to get all these data for the domains matching the parameters you specify in the request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/domain_analytics/whois/overview/live/?bash'

### **ReadObjectResponseAsync&lt;T&gt;(HttpResponseMessage, IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;, CancellationToken)**

```csharp
protected Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
```

#### Type Parameters

`T`<br>

#### Parameters

`response` HttpResponseMessage<br>

`headers` [IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]])<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>

#### Returns

Task&lt;ObjectResponseResult&lt;T&gt;&gt;<br>
