[`< Back`](./)

---

# OnPageApi

Namespace: DataForSeo.Client.Api

```csharp
public class OnPageApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageApi](./dataforseo.client.api.onpageapi)

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

### **OnPageApi(HttpClient)**

```csharp
public OnPageApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **OnPageIdListAsync(IEnumerable&lt;OnPageIdListRequestInfo&gt;)**

```csharp
public Task<OnPageIdListResponseInfo> OnPageIdListAsync(IEnumerable<OnPageIdListRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageIdListRequestInfo&gt;](./dataforseo.client.models.requests.onpageidlistrequestinfo)<br>

#### Returns

[Task&lt;OnPageIdListResponseInfo&gt;](./dataforseo.client.models.responses.onpageidlistresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed On Page tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/id_list/?bash'

### **OnPageIdListAsync(IEnumerable&lt;OnPageIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageIdListResponseInfo> OnPageIdListAsync(IEnumerable<OnPageIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageIdListRequestInfo&gt;](./dataforseo.client.models.requests.onpageidlistrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageIdListResponseInfo&gt;](./dataforseo.client.models.responses.onpageidlistresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed On Page tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/id_list/?bash'

### **OnPageErrorsAsync(IEnumerable&lt;OnPageErrorsRequestInfo&gt;)**

```csharp
public Task<OnPageErrorsResponseInfo> OnPageErrorsAsync(IEnumerable<OnPageErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageErrorsRequestInfo&gt;](./dataforseo.client.models.requests.onpageerrorsrequestinfo)<br>

#### Returns

[Task&lt;OnPageErrorsResponseInfo&gt;](./dataforseo.client.models.responses.onpageerrorsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the OnPage API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/errors/?bash'

### **OnPageErrorsAsync(IEnumerable&lt;OnPageErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageErrorsResponseInfo> OnPageErrorsAsync(IEnumerable<OnPageErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageErrorsRequestInfo&gt;](./dataforseo.client.models.requests.onpageerrorsrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageErrorsResponseInfo&gt;](./dataforseo.client.models.responses.onpageerrorsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the OnPage API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/errors/?bash'

### **ForceStopAsync(IEnumerable&lt;OnPageForceStopRequestInfo&gt;)**

```csharp
public Task<OnPageForceStopResponseInfo> ForceStopAsync(IEnumerable<OnPageForceStopRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageForceStopRequestInfo&gt;](./dataforseo.client.models.requests.onpageforcestoprequestinfo)<br>

#### Returns

[Task&lt;OnPageForceStopResponseInfo&gt;](./dataforseo.client.models.responses.onpageforcestopresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint is designed to force stop the crawl process of websites you specified in a task. The execution of all the tasks associated with the IDs indicated in your request to this endpoint will be stopped. You will still be able to obtain the data on pages that have been scanned until the crawling process was stopped.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/force_stop/?bash'

### **ForceStopAsync(IEnumerable&lt;OnPageForceStopRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageForceStopResponseInfo> ForceStopAsync(IEnumerable<OnPageForceStopRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageForceStopRequestInfo&gt;](./dataforseo.client.models.requests.onpageforcestoprequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageForceStopResponseInfo&gt;](./dataforseo.client.models.responses.onpageforcestopresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint is designed to force stop the crawl process of websites you specified in a task. The execution of all the tasks associated with the IDs indicated in your request to this endpoint will be stopped. You will still be able to obtain the data on pages that have been scanned until the crawling process was stopped.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/force_stop/?bash'

### **OnPageAvailableFiltersAsync()**

```csharp
public Task<OnPageAvailableFiltersResponseInfo> OnPageAvailableFiltersAsync()
```

#### Returns

[Task&lt;OnPageAvailableFiltersResponseInfo&gt;](./dataforseo.client.models.responses.onpageavailablefiltersresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

OnPage API supports plenty of customizable crawling parameters that allow you to adapt the extraction of website data to your requirements and modify the thresholds for various performance indicators.
 <br>‌‌
 <br>Here you will find all the necessary information about filters and thresholds that can be used with DataForSEO OnPage API endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/filters_and_thresholds/?bash'

### **OnPageAvailableFiltersAsync(CancellationToken)**

```csharp
public Task<OnPageAvailableFiltersResponseInfo> OnPageAvailableFiltersAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageAvailableFiltersResponseInfo&gt;](./dataforseo.client.models.responses.onpageavailablefiltersresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

OnPage API supports plenty of customizable crawling parameters that allow you to adapt the extraction of website data to your requirements and modify the thresholds for various performance indicators.
 <br>‌‌
 <br>Here you will find all the necessary information about filters and thresholds that can be used with DataForSEO OnPage API endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/filters_and_thresholds/?bash'

### **TaskPostAsync(IEnumerable&lt;OnPageTaskRequestInfo&gt;)**

```csharp
public Task<OnPageTaskPostResponseInfo> TaskPostAsync(IEnumerable<OnPageTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageTaskRequestInfo&gt;](./dataforseo.client.models.requests.onpagetaskrequestinfo)<br>

#### Returns

[Task&lt;OnPageTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.onpagetaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>OnPage API checks websites for 60+ customizable on-page parameters defines and displays all found flaws and opportunities for optimization so that you can easily fix them. It checks meta tags, duplicate content, image tags, response codes, and other parameters on every page. You can find the full list of OnPage API check-up parameters in the Pages section.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/task_post/?bash'

### **TaskPostAsync(IEnumerable&lt;OnPageTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageTaskPostResponseInfo> TaskPostAsync(IEnumerable<OnPageTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageTaskRequestInfo&gt;](./dataforseo.client.models.requests.onpagetaskrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.onpagetaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>OnPage API checks websites for 60+ customizable on-page parameters defines and displays all found flaws and opportunities for optimization so that you can easily fix them. It checks meta tags, duplicate content, image tags, response codes, and other parameters on every page. You can find the full list of OnPage API check-up parameters in the Pages section.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/task_post/?bash'

### **TasksReadyAsync()**

```csharp
public Task<OnPageTasksReadyResponseInfo> TasksReadyAsync()
```

#### Returns

[Task&lt;OnPageTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.onpagetasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks, which results haven’t been collected yet.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page-tasks_ready/?bash'

### **TasksReadyAsync(CancellationToken)**

```csharp
public Task<OnPageTasksReadyResponseInfo> TasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.onpagetasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks, which results haven’t been collected yet.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page-tasks_ready/?bash'

### **SummaryAsync(String)**

```csharp
public Task<OnPageSummaryResponseInfo> SummaryAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>required field
 <br>you can get this ID in the response of the Task POST endpoint
 <br>example:
 <br>“07131248-1535-0216-1000-17384017ad04”

#### Returns

[Task&lt;OnPageSummaryResponseInfo&gt;](./dataforseo.client.models.responses.onpagesummaryresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Using this function, you can get the overall information on a website as well as drill down into exact on-page issues of a website that has been scanned. As a result, you will know what functions to use for receiving detailed data for each of the found issues.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/summary/?bash'

### **SummaryAsync(String, CancellationToken)**

```csharp
public Task<OnPageSummaryResponseInfo> SummaryAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>required field
 <br>you can get this ID in the response of the Task POST endpoint
 <br>example:
 <br>“07131248-1535-0216-1000-17384017ad04”

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageSummaryResponseInfo&gt;](./dataforseo.client.models.responses.onpagesummaryresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Using this function, you can get the overall information on a website as well as drill down into exact on-page issues of a website that has been scanned. As a result, you will know what functions to use for receiving detailed data for each of the found issues.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/summary/?bash'

### **PagesAsync(IEnumerable&lt;OnPagePagesRequestInfo&gt;)**

```csharp
public Task<OnPagePagesResponseInfo> PagesAsync(IEnumerable<OnPagePagesRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPagePagesRequestInfo&gt;](./dataforseo.client.models.requests.onpagepagesrequestinfo)<br>

#### Returns

[Task&lt;OnPagePagesResponseInfo&gt;](./dataforseo.client.models.responses.onpagepagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint returns a list of crawled pages with on-page check-ups and other metrics related to the page performance.
 <br>Using this function you will get page-specific data with detailed information on how well your pages are optimized for search.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/pages/?bash'

### **PagesAsync(IEnumerable&lt;OnPagePagesRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPagePagesResponseInfo> PagesAsync(IEnumerable<OnPagePagesRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPagePagesRequestInfo&gt;](./dataforseo.client.models.requests.onpagepagesrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPagePagesResponseInfo&gt;](./dataforseo.client.models.responses.onpagepagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint returns a list of crawled pages with on-page check-ups and other metrics related to the page performance.
 <br>Using this function you will get page-specific data with detailed information on how well your pages are optimized for search.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/pages/?bash'

### **PagesByResourceAsync(IEnumerable&lt;OnPagePagesByResourceRequestInfo&gt;)**

```csharp
public Task<OnPagePagesByResourceResponseInfo> PagesByResourceAsync(IEnumerable<OnPagePagesByResourceRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPagePagesByResourceRequestInfo&gt;](./dataforseo.client.models.requests.onpagepagesbyresourcerequestinfo)<br>

#### Returns

[Task&lt;OnPagePagesByResourceResponseInfo&gt;](./dataforseo.client.models.responses.onpagepagesbyresourceresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will return the list of pages where a specific resource is located. Using this function you will also get the data related to the pages that contain a specified resource.
 <br>You can get the URL of a resource using the Resources endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/page_by_resource/?bash'

### **PagesByResourceAsync(IEnumerable&lt;OnPagePagesByResourceRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPagePagesByResourceResponseInfo> PagesByResourceAsync(IEnumerable<OnPagePagesByResourceRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPagePagesByResourceRequestInfo&gt;](./dataforseo.client.models.requests.onpagepagesbyresourcerequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPagePagesByResourceResponseInfo&gt;](./dataforseo.client.models.responses.onpagepagesbyresourceresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will return the list of pages where a specific resource is located. Using this function you will also get the data related to the pages that contain a specified resource.
 <br>You can get the URL of a resource using the Resources endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/page_by_resource/?bash'

### **ResourcesAsync(IEnumerable&lt;OnPageResourcesRequestInfo&gt;)**

```csharp
public Task<OnPageResourcesResponseInfo> ResourcesAsync(IEnumerable<OnPageResourcesRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageResourcesRequestInfo&gt;](./dataforseo.client.models.requests.onpageresourcesrequestinfo)<br>

#### Returns

[Task&lt;OnPageResourcesResponseInfo&gt;](./dataforseo.client.models.responses.onpageresourcesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of resources, including images, scripts, stylesheets, and broken elements.
 <br>You will get a detailed overview of every resource found on the crawled pages.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/resources/?bash'

### **ResourcesAsync(IEnumerable&lt;OnPageResourcesRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageResourcesResponseInfo> ResourcesAsync(IEnumerable<OnPageResourcesRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageResourcesRequestInfo&gt;](./dataforseo.client.models.requests.onpageresourcesrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageResourcesResponseInfo&gt;](./dataforseo.client.models.responses.onpageresourcesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of resources, including images, scripts, stylesheets, and broken elements.
 <br>You will get a detailed overview of every resource found on the crawled pages.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/resources/?bash'

### **DuplicateTagsAsync(IEnumerable&lt;OnPageDuplicateTagsRequestInfo&gt;)**

```csharp
public Task<OnPageDuplicateTagsResponseInfo> DuplicateTagsAsync(IEnumerable<OnPageDuplicateTagsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageDuplicateTagsRequestInfo&gt;](./dataforseo.client.models.requests.onpageduplicatetagsrequestinfo)<br>

#### Returns

[Task&lt;OnPageDuplicateTagsResponseInfo&gt;](./dataforseo.client.models.responses.onpageduplicatetagsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint returns a list of pages that contain duplicate title or description tags. The response also contains data related to page performance.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/duplicate_tags/?bash'

### **DuplicateTagsAsync(IEnumerable&lt;OnPageDuplicateTagsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageDuplicateTagsResponseInfo> DuplicateTagsAsync(IEnumerable<OnPageDuplicateTagsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageDuplicateTagsRequestInfo&gt;](./dataforseo.client.models.requests.onpageduplicatetagsrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageDuplicateTagsResponseInfo&gt;](./dataforseo.client.models.responses.onpageduplicatetagsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint returns a list of pages that contain duplicate title or description tags. The response also contains data related to page performance.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/duplicate_tags/?bash'

### **DuplicateContentAsync(IEnumerable&lt;OnPageDuplicateContentRequestInfo&gt;)**

```csharp
public Task<OnPageDuplicateContentResponseInfo> DuplicateContentAsync(IEnumerable<OnPageDuplicateContentRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageDuplicateContentRequestInfo&gt;](./dataforseo.client.models.requests.onpageduplicatecontentrequestinfo)<br>

#### Returns

[Task&lt;OnPageDuplicateContentResponseInfo&gt;](./dataforseo.client.models.responses.onpageduplicatecontentresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint returns a list of pages that have content similar to the page specified in the request. The response also contains data related to page performance and the similarity index that indicates how similar the compared pages are.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/duplicate_content/?bash'

### **DuplicateContentAsync(IEnumerable&lt;OnPageDuplicateContentRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageDuplicateContentResponseInfo> DuplicateContentAsync(IEnumerable<OnPageDuplicateContentRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageDuplicateContentRequestInfo&gt;](./dataforseo.client.models.requests.onpageduplicatecontentrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageDuplicateContentResponseInfo&gt;](./dataforseo.client.models.responses.onpageduplicatecontentresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint returns a list of pages that have content similar to the page specified in the request. The response also contains data related to page performance and the similarity index that indicates how similar the compared pages are.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/duplicate_content/?bash'

### **LinksAsync(IEnumerable&lt;OnPageLinksRequestInfo&gt;)**

```csharp
public Task<OnPageLinksResponseInfo> LinksAsync(IEnumerable<OnPageLinksRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageLinksRequestInfo&gt;](./dataforseo.client.models.requests.onpagelinksrequestinfo)<br>

#### Returns

[Task&lt;OnPageLinksResponseInfo&gt;](./dataforseo.client.models.responses.onpagelinksresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of internal and external links detected on a target website.
 <br>The following link types are supported: anchor, image, link, canonical, meta, alternate, redirect.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/links/?bash'

### **LinksAsync(IEnumerable&lt;OnPageLinksRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageLinksResponseInfo> LinksAsync(IEnumerable<OnPageLinksRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageLinksRequestInfo&gt;](./dataforseo.client.models.requests.onpagelinksrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageLinksResponseInfo&gt;](./dataforseo.client.models.responses.onpagelinksresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of internal and external links detected on a target website.
 <br>The following link types are supported: anchor, image, link, canonical, meta, alternate, redirect.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/links/?bash'

### **RedirectChainsAsync(IEnumerable&lt;OnPageRedirectChainsRequestInfo&gt;)**

```csharp
public Task<OnPageRedirectChainsResponseInfo> RedirectChainsAsync(IEnumerable<OnPageRedirectChainsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageRedirectChainsRequestInfo&gt;](./dataforseo.client.models.requests.onpageredirectchainsrequestinfo)<br>

#### Returns

[Task&lt;OnPageRedirectChainsResponseInfo&gt;](./dataforseo.client.models.responses.onpageredirectchainsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Redirect chains occur when there are at least two redirects between the initial URL and the destination URL. For example, if page A redirects to page B which redirects to page C, such a series of redirects is considered a redirect chain. Sometimes, if page B redirects back to page A, the redirect chain becomes closed and is considered a redirect loop.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/redirect_chains/?bash'

### **RedirectChainsAsync(IEnumerable&lt;OnPageRedirectChainsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageRedirectChainsResponseInfo> RedirectChainsAsync(IEnumerable<OnPageRedirectChainsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageRedirectChainsRequestInfo&gt;](./dataforseo.client.models.requests.onpageredirectchainsrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageRedirectChainsResponseInfo&gt;](./dataforseo.client.models.responses.onpageredirectchainsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Redirect chains occur when there are at least two redirects between the initial URL and the destination URL. For example, if page A redirects to page B which redirects to page C, such a series of redirects is considered a redirect chain. Sometimes, if page B redirects back to page A, the redirect chain becomes closed and is considered a redirect loop.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/redirect_chains/?bash'

### **NonIndexableAsync(IEnumerable&lt;OnPageNonIndexableRequestInfo&gt;)**

```csharp
public Task<OnPageNonIndexableResponseInfo> NonIndexableAsync(IEnumerable<OnPageNonIndexableRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageNonIndexableRequestInfo&gt;](./dataforseo.client.models.requests.onpagenonindexablerequestinfo)<br>

#### Returns

[Task&lt;OnPageNonIndexableResponseInfo&gt;](./dataforseo.client.models.responses.onpagenonindexableresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint returns a list of pages that are blocked from being indexed by Google and other search engines by robots.txt, HTTP headers, or meta tags settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/non_indexable/?bash'

### **NonIndexableAsync(IEnumerable&lt;OnPageNonIndexableRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageNonIndexableResponseInfo> NonIndexableAsync(IEnumerable<OnPageNonIndexableRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageNonIndexableRequestInfo&gt;](./dataforseo.client.models.requests.onpagenonindexablerequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageNonIndexableResponseInfo&gt;](./dataforseo.client.models.responses.onpagenonindexableresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint returns a list of pages that are blocked from being indexed by Google and other search engines by robots.txt, HTTP headers, or meta tags settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/non_indexable/?bash'

### **WaterfallAsync(IEnumerable&lt;OnPageWaterfallRequestInfo&gt;)**

```csharp
public Task<OnPageWaterfallResponseInfo> WaterfallAsync(IEnumerable<OnPageWaterfallRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageWaterfallRequestInfo&gt;](./dataforseo.client.models.requests.onpagewaterfallrequestinfo)<br>

#### Returns

[Task&lt;OnPageWaterfallResponseInfo&gt;](./dataforseo.client.models.responses.onpagewaterfallresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint is designed to provide you with the page speed insights. Using this function you can get detailed information about the page loading time, time to secure connection, the time it takes to load page resources, and so on.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/waterfall/?bash'

### **WaterfallAsync(IEnumerable&lt;OnPageWaterfallRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageWaterfallResponseInfo> WaterfallAsync(IEnumerable<OnPageWaterfallRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageWaterfallRequestInfo&gt;](./dataforseo.client.models.requests.onpagewaterfallrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageWaterfallResponseInfo&gt;](./dataforseo.client.models.responses.onpagewaterfallresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint is designed to provide you with the page speed insights. Using this function you can get detailed information about the page loading time, time to secure connection, the time it takes to load page resources, and so on.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/waterfall/?bash'

### **KeywordDensityAsync(IEnumerable&lt;OnPageKeywordDensityRequestInfo&gt;)**

```csharp
public Task<OnPageKeywordDensityResponseInfo> KeywordDensityAsync(IEnumerable<OnPageKeywordDensityRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageKeywordDensityRequestInfo&gt;](./dataforseo.client.models.requests.onpagekeyworddensityrequestinfo)<br>

#### Returns

[Task&lt;OnPageKeywordDensityResponseInfo&gt;](./dataforseo.client.models.responses.onpagekeyworddensityresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with keyword density and keyword frequency data for terms appearing on the specified website or web page. You can filter and sort the data that will be retrieved with this API call.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/keyword_density/?bash'

### **KeywordDensityAsync(IEnumerable&lt;OnPageKeywordDensityRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageKeywordDensityResponseInfo> KeywordDensityAsync(IEnumerable<OnPageKeywordDensityRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageKeywordDensityRequestInfo&gt;](./dataforseo.client.models.requests.onpagekeyworddensityrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageKeywordDensityResponseInfo&gt;](./dataforseo.client.models.responses.onpagekeyworddensityresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with keyword density and keyword frequency data for terms appearing on the specified website or web page. You can filter and sort the data that will be retrieved with this API call.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/keyword_density/?bash'

### **MicrodataAsync(IEnumerable&lt;OnPageMicrodataRequestInfo&gt;)**

```csharp
public Task<OnPageMicrodataResponseInfo> MicrodataAsync(IEnumerable<OnPageMicrodataRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageMicrodataRequestInfo&gt;](./dataforseo.client.models.requests.onpagemicrodatarequestinfo)<br>

#### Returns

[Task&lt;OnPageMicrodataResponseInfo&gt;](./dataforseo.client.models.responses.onpagemicrodataresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint is designed to validate structured JSON-LD data and Microdata. Using this function you will obtain microdata available on the specified page of the target website and detailed results of its validation.
 <br>To use this endpoint, set the validate_micromarkup parameter to true in the POST request to OnPage API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/microdata/?bash'

### **MicrodataAsync(IEnumerable&lt;OnPageMicrodataRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageMicrodataResponseInfo> MicrodataAsync(IEnumerable<OnPageMicrodataRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageMicrodataRequestInfo&gt;](./dataforseo.client.models.requests.onpagemicrodatarequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageMicrodataResponseInfo&gt;](./dataforseo.client.models.responses.onpagemicrodataresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint is designed to validate structured JSON-LD data and Microdata. Using this function you will obtain microdata available on the specified page of the target website and detailed results of its validation.
 <br>To use this endpoint, set the validate_micromarkup parameter to true in the POST request to OnPage API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/microdata/?bash'

### **RawHtmlAsync(IEnumerable&lt;OnPageRawHtmlRequestInfo&gt;)**

```csharp
public Task<OnPageRawHtmlResponseInfo> RawHtmlAsync(IEnumerable<OnPageRawHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageRawHtmlRequestInfo&gt;](./dataforseo.client.models.requests.onpagerawhtmlrequestinfo)<br>

#### Returns

[Task&lt;OnPageRawHtmlResponseInfo&gt;](./dataforseo.client.models.responses.onpagerawhtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint returns the HTML of a page you indicate in the request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/raw_html/?bash'

### **RawHtmlAsync(IEnumerable&lt;OnPageRawHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageRawHtmlResponseInfo> RawHtmlAsync(IEnumerable<OnPageRawHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageRawHtmlRequestInfo&gt;](./dataforseo.client.models.requests.onpagerawhtmlrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageRawHtmlResponseInfo&gt;](./dataforseo.client.models.responses.onpagerawhtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint returns the HTML of a page you indicate in the request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/raw_html/?bash'

### **PageScreenshotAsync(IEnumerable&lt;OnPagePageScreenshotRequestInfo&gt;)**

```csharp
public Task<OnPagePageScreenshotResponseInfo> PageScreenshotAsync(IEnumerable<OnPagePageScreenshotRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPagePageScreenshotRequestInfo&gt;](./dataforseo.client.models.requests.onpagepagescreenshotrequestinfo)<br>

#### Returns

[Task&lt;OnPagePageScreenshotResponseInfo&gt;](./dataforseo.client.models.responses.onpagepagescreenshotresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Using this endpoint, you can capture a full high-quality screenshot of any webpage. In this way, you can review the target page as the DataForSEO crawler and Googlebot see it.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/page_screenshot/?bash'

### **PageScreenshotAsync(IEnumerable&lt;OnPagePageScreenshotRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPagePageScreenshotResponseInfo> PageScreenshotAsync(IEnumerable<OnPagePageScreenshotRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPagePageScreenshotRequestInfo&gt;](./dataforseo.client.models.requests.onpagepagescreenshotrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPagePageScreenshotResponseInfo&gt;](./dataforseo.client.models.responses.onpagepagescreenshotresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Using this endpoint, you can capture a full high-quality screenshot of any webpage. In this way, you can review the target page as the DataForSEO crawler and Googlebot see it.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/page_screenshot/?bash'

### **ContentParsingAsync(IEnumerable&lt;OnPageContentParsingRequestInfo&gt;)**

```csharp
public Task<OnPageContentParsingResponseInfo> ContentParsingAsync(IEnumerable<OnPageContentParsingRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageContentParsingRequestInfo&gt;](./dataforseo.client.models.requests.onpagecontentparsingrequestinfo)<br>

#### Returns

[Task&lt;OnPageContentParsingResponseInfo&gt;](./dataforseo.client.models.responses.onpagecontentparsingresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint allows parsing the content on any page you specify and will return the structured content of the target page, including link URLs, anchors, headings, and textual content.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/content_parsing/?bash'

### **ContentParsingAsync(IEnumerable&lt;OnPageContentParsingRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageContentParsingResponseInfo> ContentParsingAsync(IEnumerable<OnPageContentParsingRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageContentParsingRequestInfo&gt;](./dataforseo.client.models.requests.onpagecontentparsingrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageContentParsingResponseInfo&gt;](./dataforseo.client.models.responses.onpagecontentparsingresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint allows parsing the content on any page you specify and will return the structured content of the target page, including link URLs, anchors, headings, and textual content.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/content_parsing/?bash'

### **ContentParsingLiveAsync(IEnumerable&lt;OnPageContentParsingLiveRequestInfo&gt;)**

```csharp
public Task<OnPageContentParsingLiveResponseInfo> ContentParsingLiveAsync(IEnumerable<OnPageContentParsingLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageContentParsingLiveRequestInfo&gt;](./dataforseo.client.models.requests.onpagecontentparsingliverequestinfo)<br>

#### Returns

[Task&lt;OnPageContentParsingLiveResponseInfo&gt;](./dataforseo.client.models.responses.onpagecontentparsingliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint allows parsing the content on any page you specify and will return the structured content of the target page, including link URLs, anchors, headings, and textual content.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/content_parsing/live/?bash'

### **ContentParsingLiveAsync(IEnumerable&lt;OnPageContentParsingLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageContentParsingLiveResponseInfo> ContentParsingLiveAsync(IEnumerable<OnPageContentParsingLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageContentParsingLiveRequestInfo&gt;](./dataforseo.client.models.requests.onpagecontentparsingliverequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageContentParsingLiveResponseInfo&gt;](./dataforseo.client.models.responses.onpagecontentparsingliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint allows parsing the content on any page you specify and will return the structured content of the target page, including link URLs, anchors, headings, and textual content.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/content_parsing/live/?bash'

### **InstantPagesAsync(IEnumerable&lt;OnPageInstantPagesRequestInfo&gt;)**

```csharp
public Task<OnPageInstantPagesResponseInfo> InstantPagesAsync(IEnumerable<OnPageInstantPagesRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageInstantPagesRequestInfo&gt;](./dataforseo.client.models.requests.onpageinstantpagesrequestinfo)<br>

#### Returns

[Task&lt;OnPageInstantPagesResponseInfo&gt;](./dataforseo.client.models.responses.onpageinstantpagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Using this function you will get page-specific data with detailed information on how well a particular page is optimized for organic search.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/instant_pages/?bash'

### **InstantPagesAsync(IEnumerable&lt;OnPageInstantPagesRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageInstantPagesResponseInfo> InstantPagesAsync(IEnumerable<OnPageInstantPagesRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageInstantPagesRequestInfo&gt;](./dataforseo.client.models.requests.onpageinstantpagesrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageInstantPagesResponseInfo&gt;](./dataforseo.client.models.responses.onpageinstantpagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Using this function you will get page-specific data with detailed information on how well a particular page is optimized for organic search.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/instant_pages/?bash'

### **OnPageLighthouseLanguagesAsync()**

```csharp
public Task<OnPageLighthouseLanguagesResponseInfo> OnPageLighthouseLanguagesAsync()
```

#### Returns

[Task&lt;OnPageLighthouseLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthouselanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br> 
 <br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/languages/?bash'

### **OnPageLighthouseLanguagesAsync(CancellationToken)**

```csharp
public Task<OnPageLighthouseLanguagesResponseInfo> OnPageLighthouseLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageLighthouseLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthouselanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br> 
 <br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/languages/?bash'

### **LighthouseAuditsAsync()**

```csharp
public Task<OnPageLighthouseAuditsResponseInfo> LighthouseAuditsAsync()
```

#### Returns

[Task&lt;OnPageLighthouseAuditsResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthouseauditsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

The OnPage Lighthouse API is based on Google’s open-source Lighthouse project and provides data on the quality of web pages.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/audits/?bash'

### **LighthouseAuditsAsync(CancellationToken)**

```csharp
public Task<OnPageLighthouseAuditsResponseInfo> LighthouseAuditsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageLighthouseAuditsResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthouseauditsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

The OnPage Lighthouse API is based on Google’s open-source Lighthouse project and provides data on the quality of web pages.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/audits/?bash'

### **LighthouseVersionsAsync()**

```csharp
public Task<OnPageLighthouseVersionsResponseInfo> LighthouseVersionsAsync()
```

#### Returns

[Task&lt;OnPageLighthouseVersionsResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthouseversionsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

OnPage Lighthouse API is based on Google’s open-source Lighthouse project and provides data on the quality of web pages.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/versions/?bash'

### **LighthouseVersionsAsync(CancellationToken)**

```csharp
public Task<OnPageLighthouseVersionsResponseInfo> LighthouseVersionsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageLighthouseVersionsResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthouseversionsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

OnPage Lighthouse API is based on Google’s open-source Lighthouse project and provides data on the quality of web pages.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/versions/?bash'

### **LighthouseTaskPostAsync(IEnumerable&lt;OnPageLighthouseTaskPostRequestInfo&gt;)**

```csharp
public Task<OnPageLighthouseTaskPostResponseInfo> LighthouseTaskPostAsync(IEnumerable<OnPageLighthouseTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageLighthouseTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.onpagelighthousetaskpostrequestinfo)<br>

#### Returns

[Task&lt;OnPageLighthouseTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthousetaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌The OnPage Lighthouse API is based on Google’s open-source Lighthouse project for measuring the quality of web pages and web apps.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/task_post/?bash'

### **LighthouseTaskPostAsync(IEnumerable&lt;OnPageLighthouseTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageLighthouseTaskPostResponseInfo> LighthouseTaskPostAsync(IEnumerable<OnPageLighthouseTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageLighthouseTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.onpagelighthousetaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageLighthouseTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthousetaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌The OnPage Lighthouse API is based on Google’s open-source Lighthouse project for measuring the quality of web pages and web apps.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/task_post/?bash'

### **LighthouseTasksReadyAsync()**

```csharp
public Task<OnPageLighthouseTasksReadyResponseInfo> LighthouseTasksReadyAsync()
```

#### Returns

[Task&lt;OnPageLighthouseTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthousetasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/tasks_ready/?bash'

### **LighthouseTasksReadyAsync(CancellationToken)**

```csharp
public Task<OnPageLighthouseTasksReadyResponseInfo> LighthouseTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageLighthouseTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthousetasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/tasks_ready/?bash'

### **LighthouseTaskGetJsonAsync(String)**

```csharp
public Task<OnPageLighthouseTaskGetJsonResponseInfo> LighthouseTaskGetJsonAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>required field
 <br>you can get this ID in the response of the Task POST endpoint
 <br>example:
 <br>“07131248-1535-0216-1000-17384017ad04”

#### Returns

[Task&lt;OnPageLighthouseTaskGetJsonResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthousetaskgetjsonresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The OnPage Lighthouse API is based on Google’s open-source Lighthouse project for measuring the quality of web pages and web apps. This endpoint will provide you with the results of Lighthouse Audit. Use the id received in the response of your Task POST request to get the results. The response will include data about all categories and audits specified in the Task POST. By default, the response will include all available data about the webpage including its performance, accessibility, progressive web apps, SEO, and compliance with best practices.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/task_get/json/?bash'

### **LighthouseTaskGetJsonAsync(String, CancellationToken)**

```csharp
public Task<OnPageLighthouseTaskGetJsonResponseInfo> LighthouseTaskGetJsonAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>required field
 <br>you can get this ID in the response of the Task POST endpoint
 <br>example:
 <br>“07131248-1535-0216-1000-17384017ad04”

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageLighthouseTaskGetJsonResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthousetaskgetjsonresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The OnPage Lighthouse API is based on Google’s open-source Lighthouse project for measuring the quality of web pages and web apps. This endpoint will provide you with the results of Lighthouse Audit. Use the id received in the response of your Task POST request to get the results. The response will include data about all categories and audits specified in the Task POST. By default, the response will include all available data about the webpage including its performance, accessibility, progressive web apps, SEO, and compliance with best practices.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/task_get/json/?bash'

### **LighthouseLiveJsonAsync(IEnumerable&lt;OnPageLighthouseLiveJsonRequestInfo&gt;)**

```csharp
public Task<OnPageLighthouseLiveJsonResponseInfo> LighthouseLiveJsonAsync(IEnumerable<OnPageLighthouseLiveJsonRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;OnPageLighthouseLiveJsonRequestInfo&gt;](./dataforseo.client.models.requests.onpagelighthouselivejsonrequestinfo)<br>

#### Returns

[Task&lt;OnPageLighthouseLiveJsonResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthouselivejsonresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌The OnPage Lighthouse API is based on Google’s open-source Lighthouse project for measuring the quality of web pages and web apps.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/live/json/?bash'

### **LighthouseLiveJsonAsync(IEnumerable&lt;OnPageLighthouseLiveJsonRequestInfo&gt;, CancellationToken)**

```csharp
public Task<OnPageLighthouseLiveJsonResponseInfo> LighthouseLiveJsonAsync(IEnumerable<OnPageLighthouseLiveJsonRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;OnPageLighthouseLiveJsonRequestInfo&gt;](./dataforseo.client.models.requests.onpagelighthouselivejsonrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;OnPageLighthouseLiveJsonResponseInfo&gt;](./dataforseo.client.models.responses.onpagelighthouselivejsonresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌The OnPage Lighthouse API is based on Google’s open-source Lighthouse project for measuring the quality of web pages and web apps.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/on_page/lighthouse/live/json/?bash'

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

---

[`< Back`](./)
