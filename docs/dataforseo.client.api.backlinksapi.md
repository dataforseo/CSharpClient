# BacklinksApi

Namespace: DataForSeo.Client.Api

```csharp
public class BacklinksApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksApi](./dataforseo.client.api.backlinksapi.md)

## Properties

### **BaseUrl**

```csharp
public string BaseUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReadResponseAsString**

```csharp
public bool ReadResponseAsString { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### **BacklinksApi(HttpClient)**

```csharp
public BacklinksApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **BacklinksIdListAsync(IEnumerable&lt;BacklinksIdListRequestInfo&gt;)**

```csharp
public Task<BacklinksIdListResponseInfo> BacklinksIdListAsync(IEnumerable<BacklinksIdListRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksIdListRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksIdListResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Backlinks tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/id_list/?bash'

### **BacklinksIdListAsync(IEnumerable&lt;BacklinksIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksIdListResponseInfo> BacklinksIdListAsync(IEnumerable<BacklinksIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksIdListRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksIdListResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Backlinks tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/id_list/?bash'

### **BacklinksErrorsAsync(IEnumerable&lt;BacklinksErrorsRequestInfo&gt;)**

```csharp
public Task<BacklinksErrorsResponseInfo> BacklinksErrorsAsync(IEnumerable<BacklinksErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksErrorsRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksErrorsResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Backlinks API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/errors/?bash'

### **BacklinksErrorsAsync(IEnumerable&lt;BacklinksErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksErrorsResponseInfo> BacklinksErrorsAsync(IEnumerable<BacklinksErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksErrorsRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksErrorsResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Backlinks API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/errors/?bash'

### **BacklinksAvailableFiltersAsync()**

```csharp
public Task<BacklinksAvailableFiltersResponseInfo> BacklinksAvailableFiltersAsync()
```

#### Returns

[Task&lt;BacklinksAvailableFiltersResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Backlinks API features plenty of parameters that support custom filtration. By applying filters to your POST requests, you will be able to effortlessly extract data that matches your requirements. Note that we do not charge any fees for using data filtering or sorting rules.
 <br>‌‌
 <br>Here you will find all the necessary information about filters that can be used with DataForSEO Backlinks API endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/filters/?bash'

### **BacklinksAvailableFiltersAsync(CancellationToken)**

```csharp
public Task<BacklinksAvailableFiltersResponseInfo> BacklinksAvailableFiltersAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksAvailableFiltersResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Backlinks API features plenty of parameters that support custom filtration. By applying filters to your POST requests, you will be able to effortlessly extract data that matches your requirements. Note that we do not charge any fees for using data filtering or sorting rules.
 <br>‌‌
 <br>Here you will find all the necessary information about filters that can be used with DataForSEO Backlinks API endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/filters/?bash'

### **IndexAsync()**

```csharp
public Task<BacklinksIndexResponseInfo> IndexAsync()
```

#### Returns

[Task&lt;BacklinksIndexResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the total number of backlinks, domains, and pages our database contains for the moment when you make a request. You will also get stats for the last 12 months.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/index/?bash'

### **IndexAsync(CancellationToken)**

```csharp
public Task<BacklinksIndexResponseInfo> IndexAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksIndexResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the total number of backlinks, domains, and pages our database contains for the moment when you make a request. You will also get stats for the last 12 months.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/index/?bash'

### **SummaryLiveAsync(IEnumerable&lt;BacklinksSummaryLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksSummaryLiveResponseInfo> SummaryLiveAsync(IEnumerable<BacklinksSummaryLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksSummaryLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksSummaryLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with an overview of backlinks data available for a given domain, subdomain, or webpage.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/summary/live/?bash'

### **SummaryLiveAsync(IEnumerable&lt;BacklinksSummaryLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksSummaryLiveResponseInfo> SummaryLiveAsync(IEnumerable<BacklinksSummaryLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksSummaryLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksSummaryLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with an overview of backlinks data available for a given domain, subdomain, or webpage.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/summary/live/?bash'

### **HistoryLiveAsync(IEnumerable&lt;BacklinksHistoryLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksHistoryLiveResponseInfo> HistoryLiveAsync(IEnumerable<BacklinksHistoryLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksHistoryLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksHistoryLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with historical backlinks data back to the beginning of 2019. You can receive the number of backlinks a given domain had in a specific time period, the number of new &amp; lost backlinks, referring domains, and more.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/history/live/?bash'

### **HistoryLiveAsync(IEnumerable&lt;BacklinksHistoryLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksHistoryLiveResponseInfo> HistoryLiveAsync(IEnumerable<BacklinksHistoryLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksHistoryLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksHistoryLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with historical backlinks data back to the beginning of 2019. You can receive the number of backlinks a given domain had in a specific time period, the number of new &amp; lost backlinks, referring domains, and more.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/history/live/?bash'

### **BacklinksLiveAsync(IEnumerable&lt;BacklinksBacklinksLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksBacklinksLiveResponseInfo> BacklinksLiveAsync(IEnumerable<BacklinksBacklinksLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBacklinksLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksBacklinksLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of backlinks and relevant data for the specified domain, subdomain, or webpage.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/backlinks/live/?bash'

### **BacklinksLiveAsync(IEnumerable&lt;BacklinksBacklinksLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksBacklinksLiveResponseInfo> BacklinksLiveAsync(IEnumerable<BacklinksBacklinksLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBacklinksLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksBacklinksLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of backlinks and relevant data for the specified domain, subdomain, or webpage.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/backlinks/live/?bash'

### **AnchorsLiveAsync(IEnumerable&lt;BacklinksAnchorsLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksAnchorsLiveResponseInfo> AnchorsLiveAsync(IEnumerable<BacklinksAnchorsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksAnchorsLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksAnchorsLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of anchors used when linking to the specified website with relevant backlink data for each of them.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/anchors/live/?bash'

### **AnchorsLiveAsync(IEnumerable&lt;BacklinksAnchorsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksAnchorsLiveResponseInfo> AnchorsLiveAsync(IEnumerable<BacklinksAnchorsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksAnchorsLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksAnchorsLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of anchors used when linking to the specified website with relevant backlink data for each of them.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/anchors/live/?bash'

### **DomainPagesLiveAsync(IEnumerable&lt;BacklinksDomainPagesLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksDomainPagesLiveResponseInfo> DomainPagesLiveAsync(IEnumerable<BacklinksDomainPagesLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksDomainPagesLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksDomainPagesLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of domain pages with backlink data for each page.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/domain_pages/live/?bash'

### **DomainPagesLiveAsync(IEnumerable&lt;BacklinksDomainPagesLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksDomainPagesLiveResponseInfo> DomainPagesLiveAsync(IEnumerable<BacklinksDomainPagesLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksDomainPagesLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksDomainPagesLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of domain pages with backlink data for each page.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/domain_pages/live/?bash'

### **DomainPagesSummaryLiveAsync(IEnumerable&lt;BacklinksDomainPagesSummaryLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksDomainPagesSummaryLiveResponseInfo> DomainPagesSummaryLiveAsync(IEnumerable<BacklinksDomainPagesSummaryLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksDomainPagesSummaryLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksDomainPagesSummaryLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with detailed summary data on all backlinks and related metrics for each page of the target domain or subdomain you specify. If you indicate a single page as a target, you will get comprehensive summary data on all backlinks for that page.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/domain_pages_summary/live/?bash'

### **DomainPagesSummaryLiveAsync(IEnumerable&lt;BacklinksDomainPagesSummaryLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksDomainPagesSummaryLiveResponseInfo> DomainPagesSummaryLiveAsync(IEnumerable<BacklinksDomainPagesSummaryLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksDomainPagesSummaryLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksDomainPagesSummaryLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with detailed summary data on all backlinks and related metrics for each page of the target domain or subdomain you specify. If you indicate a single page as a target, you will get comprehensive summary data on all backlinks for that page.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/domain_pages_summary/live/?bash'

### **ReferringDomainsLiveAsync(IEnumerable&lt;BacklinksReferringDomainsLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksReferringDomainsLiveResponseInfo> ReferringDomainsLiveAsync(IEnumerable<BacklinksReferringDomainsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksReferringDomainsLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksReferringDomainsLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of referring domains pointing to the target domain you specify.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/referring_domains/live/?bash'

### **ReferringDomainsLiveAsync(IEnumerable&lt;BacklinksReferringDomainsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksReferringDomainsLiveResponseInfo> ReferringDomainsLiveAsync(IEnumerable<BacklinksReferringDomainsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksReferringDomainsLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksReferringDomainsLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of referring domains pointing to the target domain you specify.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/referring_domains/live/?bash'

### **ReferringNetworksLiveAsync(IEnumerable&lt;BacklinksReferringNetworksLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksReferringNetworksLiveResponseInfo> ReferringNetworksLiveAsync(IEnumerable<BacklinksReferringNetworksLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksReferringNetworksLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksReferringNetworksLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of referring IPs and subnets pointing to the target you specify.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/referring_networks/live/?bash'

### **ReferringNetworksLiveAsync(IEnumerable&lt;BacklinksReferringNetworksLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksReferringNetworksLiveResponseInfo> ReferringNetworksLiveAsync(IEnumerable<BacklinksReferringNetworksLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksReferringNetworksLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksReferringNetworksLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of referring IPs and subnets pointing to the target you specify.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/referring_networks/live/?bash'

### **CompetitorsLiveAsync(IEnumerable&lt;BacklinksCompetitorsLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksCompetitorsLiveResponseInfo> CompetitorsLiveAsync(IEnumerable<BacklinksCompetitorsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksCompetitorsLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksCompetitorsLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of competitors that share some part of the backlink profile with a target website, along with a number of backlink intersections and the rank of every competing website.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/competitors/live/?bash'

### **CompetitorsLiveAsync(IEnumerable&lt;BacklinksCompetitorsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksCompetitorsLiveResponseInfo> CompetitorsLiveAsync(IEnumerable<BacklinksCompetitorsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksCompetitorsLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksCompetitorsLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of competitors that share some part of the backlink profile with a target website, along with a number of backlink intersections and the rank of every competing website.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/competitors/live/?bash'

### **DomainIntersectionLiveAsync(IEnumerable&lt;BacklinksDomainIntersectionLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksDomainIntersectionLiveResponseInfo> DomainIntersectionLiveAsync(IEnumerable<BacklinksDomainIntersectionLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksDomainIntersectionLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksDomainIntersectionLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the list of domains pointing to the specified websites. This endpoint is especially useful for creating a Link Gap feature that shows what domains link to your competitors but do not link out to your website.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/domain_intersection/live/?bash'

### **DomainIntersectionLiveAsync(IEnumerable&lt;BacklinksDomainIntersectionLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksDomainIntersectionLiveResponseInfo> DomainIntersectionLiveAsync(IEnumerable<BacklinksDomainIntersectionLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksDomainIntersectionLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksDomainIntersectionLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the list of domains pointing to the specified websites. This endpoint is especially useful for creating a Link Gap feature that shows what domains link to your competitors but do not link out to your website.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/domain_intersection/live/?bash'

### **PageIntersectionLiveAsync(IEnumerable&lt;BacklinksPageIntersectionLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksPageIntersectionLiveResponseInfo> PageIntersectionLiveAsync(IEnumerable<BacklinksPageIntersectionLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksPageIntersectionLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksPageIntersectionLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the list of referring pages pointing to the specified targets. It is especially useful for finding the backlinks that point to your competitors but don’t point to your website.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/page_intersection/live/?bash'

### **PageIntersectionLiveAsync(IEnumerable&lt;BacklinksPageIntersectionLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksPageIntersectionLiveResponseInfo> PageIntersectionLiveAsync(IEnumerable<BacklinksPageIntersectionLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksPageIntersectionLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksPageIntersectionLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the list of referring pages pointing to the specified targets. It is especially useful for finding the backlinks that point to your competitors but don’t point to your website.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/page_intersection/live/?bash'

### **TimeseriesSummaryLiveAsync(IEnumerable&lt;BacklinksTimeseriesSummaryLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksTimeseriesSummaryLiveResponseInfo> TimeseriesSummaryLiveAsync(IEnumerable<BacklinksTimeseriesSummaryLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksTimeseriesSummaryLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksTimeseriesSummaryLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with an overview of backlink data for the target domain available during a period between the two indicated dates. Backlink metrics will be grouped by the time range that you define: day, week, month, or year.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/timeseries_summary/live/?bash'

### **TimeseriesSummaryLiveAsync(IEnumerable&lt;BacklinksTimeseriesSummaryLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksTimeseriesSummaryLiveResponseInfo> TimeseriesSummaryLiveAsync(IEnumerable<BacklinksTimeseriesSummaryLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksTimeseriesSummaryLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksTimeseriesSummaryLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with an overview of backlink data for the target domain available during a period between the two indicated dates. Backlink metrics will be grouped by the time range that you define: day, week, month, or year.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/timeseries_summary/live/?bash'

### **TimeseriesNewLostSummaryLiveAsync(IEnumerable&lt;BacklinksTimeseriesNewLostSummaryLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksTimeseriesNewLostSummaryLiveResponseInfo> TimeseriesNewLostSummaryLiveAsync(IEnumerable<BacklinksTimeseriesNewLostSummaryLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksTimeseriesNewLostSummaryLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksTimeseriesNewLostSummaryLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the number of new and lost backlinks and referring domains for the domain specified in the target field.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/timeseries_new_lost_summary/live/?bash'

### **TimeseriesNewLostSummaryLiveAsync(IEnumerable&lt;BacklinksTimeseriesNewLostSummaryLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksTimeseriesNewLostSummaryLiveResponseInfo> TimeseriesNewLostSummaryLiveAsync(IEnumerable<BacklinksTimeseriesNewLostSummaryLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksTimeseriesNewLostSummaryLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksTimeseriesNewLostSummaryLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the number of new and lost backlinks and referring domains for the domain specified in the target field.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/timeseries_new_lost_summary/live/?bash'

### **BulkRanksLiveAsync(IEnumerable&lt;BacklinksBulkRanksLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksBulkRanksLiveResponseInfo> BulkRanksLiveAsync(IEnumerable<BacklinksBulkRanksLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkRanksLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksBulkRanksLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with rank scores of the domains, subdomains, and pages specified in the targets array. The score is based on the number of referring domains pointing to the specified domains, subdomains, or pages. rank values range from 0 (no backlinks detected) to 1,000 (highest rank). A similar scoring system is used in Google’s Page Rank algorithm. You can learn more about rank scores in this help center article
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_ranks/live/?bash'

### **BulkRanksLiveAsync(IEnumerable&lt;BacklinksBulkRanksLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksBulkRanksLiveResponseInfo> BulkRanksLiveAsync(IEnumerable<BacklinksBulkRanksLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkRanksLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksBulkRanksLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with rank scores of the domains, subdomains, and pages specified in the targets array. The score is based on the number of referring domains pointing to the specified domains, subdomains, or pages. rank values range from 0 (no backlinks detected) to 1,000 (highest rank). A similar scoring system is used in Google’s Page Rank algorithm. You can learn more about rank scores in this help center article
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_ranks/live/?bash'

### **BulkBacklinksLiveAsync(IEnumerable&lt;BacklinksBulkBacklinksLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksBulkBacklinksLiveResponseInfo> BulkBacklinksLiveAsync(IEnumerable<BacklinksBulkBacklinksLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkBacklinksLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksBulkBacklinksLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the number of backlinks pointing to domains, subdomains, and pages specified in the targets array. The returned numbers correspond to all live backlinks, that is, total number of referring links with all attributes (e.g., nofollow, noreferrer, ugc, sponsored etc) that were found during the latest check.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_backlinks/live/?bash'

### **BulkBacklinksLiveAsync(IEnumerable&lt;BacklinksBulkBacklinksLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksBulkBacklinksLiveResponseInfo> BulkBacklinksLiveAsync(IEnumerable<BacklinksBulkBacklinksLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkBacklinksLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksBulkBacklinksLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the number of backlinks pointing to domains, subdomains, and pages specified in the targets array. The returned numbers correspond to all live backlinks, that is, total number of referring links with all attributes (e.g., nofollow, noreferrer, ugc, sponsored etc) that were found during the latest check.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_backlinks/live/?bash'

### **BulkSpamScoreLiveAsync(IEnumerable&lt;BacklinksBulkSpamScoreLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksBulkSpamScoreLiveResponseInfo> BulkSpamScoreLiveAsync(IEnumerable<BacklinksBulkSpamScoreLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkSpamScoreLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksBulkSpamScoreLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with spam scores of the domains, subdomains, and pages you specified in the targets array. Spam Score is DataForSEO’s proprietary metric that indicates how “spammy” your target is on a scale from 0 to 100. You can learn more about Spam Score, how it is calculated, and signals it takes into account in this help center article
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_spam_score/live/?bash'

### **BulkSpamScoreLiveAsync(IEnumerable&lt;BacklinksBulkSpamScoreLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksBulkSpamScoreLiveResponseInfo> BulkSpamScoreLiveAsync(IEnumerable<BacklinksBulkSpamScoreLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkSpamScoreLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksBulkSpamScoreLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with spam scores of the domains, subdomains, and pages you specified in the targets array. Spam Score is DataForSEO’s proprietary metric that indicates how “spammy” your target is on a scale from 0 to 100. You can learn more about Spam Score, how it is calculated, and signals it takes into account in this help center article
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_spam_score/live/?bash'

### **BulkReferringDomainsLiveAsync(IEnumerable&lt;BacklinksBulkReferringDomainsLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksBulkReferringDomainsLiveResponseInfo> BulkReferringDomainsLiveAsync(IEnumerable<BacklinksBulkReferringDomainsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkReferringDomainsLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksBulkReferringDomainsLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the number of referring domains pointing to domains, subdomains, and pages specified in the targets array. The returned numbers are based on all live referring domains, that is, total number of domains pointing to the target with any type of backlinks (e.g., nofollow, noreferrer, ugc, sponsored etc) that were found during the latest check.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_referring_domains/live/?bash'

### **BulkReferringDomainsLiveAsync(IEnumerable&lt;BacklinksBulkReferringDomainsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksBulkReferringDomainsLiveResponseInfo> BulkReferringDomainsLiveAsync(IEnumerable<BacklinksBulkReferringDomainsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkReferringDomainsLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksBulkReferringDomainsLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the number of referring domains pointing to domains, subdomains, and pages specified in the targets array. The returned numbers are based on all live referring domains, that is, total number of domains pointing to the target with any type of backlinks (e.g., nofollow, noreferrer, ugc, sponsored etc) that were found during the latest check.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_referring_domains/live/?bash'

### **BulkNewLostBacklinksLiveAsync(IEnumerable&lt;BacklinksBulkNewLostBacklinksLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksBulkNewLostBacklinksLiveResponseInfo> BulkNewLostBacklinksLiveAsync(IEnumerable<BacklinksBulkNewLostBacklinksLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkNewLostBacklinksLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksBulkNewLostBacklinksLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the number of new and lost backlinks for the domains, subdomains, and pages specified in the targets array.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_new_lost_backlinks/live/?bash'

### **BulkNewLostBacklinksLiveAsync(IEnumerable&lt;BacklinksBulkNewLostBacklinksLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksBulkNewLostBacklinksLiveResponseInfo> BulkNewLostBacklinksLiveAsync(IEnumerable<BacklinksBulkNewLostBacklinksLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkNewLostBacklinksLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksBulkNewLostBacklinksLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the number of new and lost backlinks for the domains, subdomains, and pages specified in the targets array.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_new_lost_backlinks/live/?bash'

### **BulkNewLostReferringDomainsLiveAsync(IEnumerable&lt;BacklinksBulkNewLostReferringDomainsLiveRequestInfo&gt;)**

```csharp
public Task<BacklinksBulkNewLostReferringDomainsLiveResponseInfo> BulkNewLostReferringDomainsLiveAsync(IEnumerable<BacklinksBulkNewLostReferringDomainsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkNewLostReferringDomainsLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

#### Returns

[Task&lt;BacklinksBulkNewLostReferringDomainsLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the number of referring domains pointing to the domains, subdomains and pages specified in the targets array.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_new_lost_referring_domains/live/?bash'

### **BulkNewLostReferringDomainsLiveAsync(IEnumerable&lt;BacklinksBulkNewLostReferringDomainsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BacklinksBulkNewLostReferringDomainsLiveResponseInfo> BulkNewLostReferringDomainsLiveAsync(IEnumerable<BacklinksBulkNewLostReferringDomainsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BacklinksBulkNewLostReferringDomainsLiveRequestInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BacklinksBulkNewLostReferringDomainsLiveResponseInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the number of referring domains pointing to the domains, subdomains and pages specified in the targets array.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/backlinks/bulk_new_lost_referring_domains/live/?bash'

### **ReadObjectResponseAsync&lt;T&gt;(HttpResponseMessage, IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;, CancellationToken)**

```csharp
protected Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
```

#### Type Parameters

`T`<br>

#### Parameters

`response` HttpResponseMessage<br>

`headers` [IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

Task&lt;ObjectResponseResult&lt;T&gt;&gt;<br>
