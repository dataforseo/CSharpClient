# SerpApi

Namespace: DataForSeo.Client.Api

```csharp
public class SerpApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SerpApi](./dataforseo.client.api.serpapi.md)

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

### **SerpApi(HttpClient)**

```csharp
public SerpApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **BaiduOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpBaiduOrganicTaskGetHtmlResponseInfo> BaiduOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/html/?bash'

### **BaiduOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpBaiduOrganicTaskGetHtmlResponseInfo> BaiduOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/html/?bash'

### **NaverOrganicTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpNaverOrganicTaskPostResponseInfo> NaverOrganicTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpNaverOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Naver SERP API provides top 100 search engine results. Naver search results do not vary by location and language, and the search parameters for this search engine do not contain language and location variables. However, you can specify a keyword in any language, and the search engine results may vary depending on the language you used for specifying the search query.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_post/?bash'

### **NaverOrganicTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpNaverOrganicTaskPostResponseInfo> NaverOrganicTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Naver SERP API provides top 100 search engine results. Naver search results do not vary by location and language, and the search parameters for this search engine do not contain language and location variables. However, you can specify a keyword in any language, and the search engine results may vary depending on the language you used for specifying the search query.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_post/?bash'

### **NaverOrganicTasksReadyAsync()**

```csharp
public Task<SerpNaverOrganicTasksReadyResponseInfo> NaverOrganicTasksReadyAsync()
```

#### Returns

[Task&lt;SerpNaverOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/tasks_ready/?bash'

### **NaverOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpNaverOrganicTasksReadyResponseInfo> NaverOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/tasks_ready/?bash'

### **NaverOrganicTasksFixedAsync()**

```csharp
public Task<SerpNaverOrganicTasksFixedResponseInfo> NaverOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpNaverOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/tasks_fixed/?bash'

### **NaverOrganicTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpNaverOrganicTasksFixedResponseInfo> NaverOrganicTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/tasks_fixed/?bash'

### **NaverOrganicTaskGetRegularAsync(String)**

```csharp
public Task<SerpNaverOrganicTaskGetRegularResponseInfo> NaverOrganicTaskGetRegularAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpNaverOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/regular/?bash'

### **NaverOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpNaverOrganicTaskGetRegularResponseInfo> NaverOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/regular/?bash'

### **NaverOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpNaverOrganicTaskGetAdvancedResponseInfo> NaverOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpNaverOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/advanced/?bash'

### **NaverOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpNaverOrganicTaskGetAdvancedResponseInfo> NaverOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/advanced/?bash'

### **NaverOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpNaverOrganicTaskGetHtmlResponseInfo> NaverOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpNaverOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/html/?bash'

### **NaverOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpNaverOrganicTaskGetHtmlResponseInfo> NaverOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/html/?bash'

### **SerpSeznamLocationsAsync()**

```csharp
public Task<SerpSeznamLocationsResponseInfo> SerpSeznamLocationsAsync()
```

#### Returns

[Task&lt;SerpSeznamLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamlocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'

### **SerpSeznamLocationsAsync(CancellationToken)**

```csharp
public Task<SerpSeznamLocationsResponseInfo> SerpSeznamLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamlocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'

### **SerpSeznamLocationsCountryAsync(String)**

```csharp
public Task<SerpSeznamLocationsCountryResponseInfo> SerpSeznamLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpSeznamLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamlocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'

### **SerpSeznamLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpSeznamLocationsCountryResponseInfo> SerpSeznamLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamlocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'

### **SerpSeznamLanguagesAsync()**

```csharp
public Task<SerpSeznamLanguagesResponseInfo> SerpSeznamLanguagesAsync()
```

#### Returns

[Task&lt;SerpSeznamLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamlanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/languages/?bash'

### **SerpSeznamLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpSeznamLanguagesResponseInfo> SerpSeznamLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamlanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/languages/?bash'

### **SeznamOrganicTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpSeznamOrganicTaskPostResponseInfo> SeznamOrganicTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpSeznamOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Seznam SERP API provides top 10 search engine results from one of the most popular search engines in the Czech Republic. Seznam is focused on the local search market, and thus supports the Czech language only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_post/?bash'

### **SeznamOrganicTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpSeznamOrganicTaskPostResponseInfo> SeznamOrganicTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Seznam SERP API provides top 10 search engine results from one of the most popular search engines in the Czech Republic. Seznam is focused on the local search market, and thus supports the Czech language only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_post/?bash'

### **SeznamOrganicTasksReadyAsync()**

```csharp
public Task<SerpSeznamOrganicTasksReadyResponseInfo> SeznamOrganicTasksReadyAsync()
```

#### Returns

[Task&lt;SerpSeznamOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/tasks_ready/?bash'

### **SeznamOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpSeznamOrganicTasksReadyResponseInfo> SeznamOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/tasks_ready/?bash'

### **SeznamOrganicTasksFixedAsync()**

```csharp
public Task<SerpSeznamOrganicTasksFixedResponseInfo> SeznamOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpSeznamOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/tasks_fixed/?bash'

### **SeznamOrganicTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpSeznamOrganicTasksFixedResponseInfo> SeznamOrganicTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/tasks_fixed/?bash'

### **SeznamOrganicTaskGetRegularAsync(String)**

```csharp
public Task<SerpSeznamOrganicTaskGetRegularResponseInfo> SeznamOrganicTaskGetRegularAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/regular/?bash'

### **SeznamOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpSeznamOrganicTaskGetRegularResponseInfo> SeznamOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/regular/?bash'

### **SeznamOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpSeznamOrganicTaskGetAdvancedResponseInfo> SeznamOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/advanced/?bash'

### **SeznamOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpSeznamOrganicTaskGetAdvancedResponseInfo> SeznamOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/advanced/?bash'

### **SeznamOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpSeznamOrganicTaskGetHtmlResponseInfo> SeznamOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/html/?bash'

### **SeznamOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpSeznamOrganicTaskGetHtmlResponseInfo> SeznamOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpseznamorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/html/?bash'

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

### **SerpIdListAsync(IEnumerable&lt;SerpIdListRequestInfo&gt;)**

```csharp
public Task<SerpIdListResponseInfo> SerpIdListAsync(IEnumerable<SerpIdListRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpIdListRequestInfo&gt;](./dataforseo.client.models.requests.serpidlistrequestinfo.md)<br>

#### Returns

[Task&lt;SerpIdListResponseInfo&gt;](./dataforseo.client.models.responses.serpidlistresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed SERP tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/id_list/?bash'

### **SerpIdListAsync(IEnumerable&lt;SerpIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpIdListResponseInfo> SerpIdListAsync(IEnumerable<SerpIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpIdListRequestInfo&gt;](./dataforseo.client.models.requests.serpidlistrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpIdListResponseInfo&gt;](./dataforseo.client.models.responses.serpidlistresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed SERP tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/id_list/?bash'

### **SerpErrorsAsync(IEnumerable&lt;SerpErrorsRequestInfo&gt;)**

```csharp
public Task<SerpErrorsResponseInfo> SerpErrorsAsync(IEnumerable<SerpErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpErrorsRequestInfo&gt;](./dataforseo.client.models.requests.serperrorsrequestinfo.md)<br>

#### Returns

[Task&lt;SerpErrorsResponseInfo&gt;](./dataforseo.client.models.responses.serperrorsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the SERP API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/errors/?bash'

### **SerpErrorsAsync(IEnumerable&lt;SerpErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpErrorsResponseInfo> SerpErrorsAsync(IEnumerable<SerpErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpErrorsRequestInfo&gt;](./dataforseo.client.models.requests.serperrorsrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpErrorsResponseInfo&gt;](./dataforseo.client.models.responses.serperrorsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the SERP API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/errors/?bash'

### **ScreenshotAsync(IEnumerable&lt;SerpScreenshotRequestInfo&gt;)**

```csharp
public Task<SerpScreenshotResponseInfo> ScreenshotAsync(IEnumerable<SerpScreenshotRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpScreenshotRequestInfo&gt;](./dataforseo.client.models.requests.serpscreenshotrequestinfo.md)<br>

#### Returns

[Task&lt;SerpScreenshotResponseInfo&gt;](./dataforseo.client.models.responses.serpscreenshotresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Using the Live Page Screenshot endpoint, you can capture a screenshot of any SERP page.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/screenshot/?bash'

### **ScreenshotAsync(IEnumerable&lt;SerpScreenshotRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpScreenshotResponseInfo> ScreenshotAsync(IEnumerable<SerpScreenshotRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpScreenshotRequestInfo&gt;](./dataforseo.client.models.requests.serpscreenshotrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpScreenshotResponseInfo&gt;](./dataforseo.client.models.responses.serpscreenshotresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Using the Live Page Screenshot endpoint, you can capture a screenshot of any SERP page.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/screenshot/?bash'

### **AiSummaryAsync(IEnumerable&lt;SerpAiSummaryRequestInfo&gt;)**

```csharp
public Task<SerpAiSummaryResponseInfo> AiSummaryAsync(IEnumerable<SerpAiSummaryRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpAiSummaryRequestInfo&gt;](./dataforseo.client.models.requests.serpaisummaryrequestinfo.md)<br>

#### Returns

[Task&lt;SerpAiSummaryResponseInfo&gt;](./dataforseo.client.models.responses.serpaisummaryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The purpose of the Live SERP API AI Summary endpoint is to provide a summary of the content found on any SERP and generate a response based on the user’s specified prompt.
 <br>To obtain results, you have to specify task_id, which you can find in the response to the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/ai_summary/?bash'

### **AiSummaryAsync(IEnumerable&lt;SerpAiSummaryRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpAiSummaryResponseInfo> AiSummaryAsync(IEnumerable<SerpAiSummaryRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpAiSummaryRequestInfo&gt;](./dataforseo.client.models.requests.serpaisummaryrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpAiSummaryResponseInfo&gt;](./dataforseo.client.models.responses.serpaisummaryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The purpose of the Live SERP API AI Summary endpoint is to provide a summary of the content found on any SERP and generate a response based on the user’s specified prompt.
 <br>To obtain results, you have to specify task_id, which you can find in the response to the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/ai_summary/?bash'

### **SerpGoogleLocationsAsync()**

```csharp
public Task<SerpGoogleLocationsResponseInfo> SerpGoogleLocationsAsync()
```

#### Returns

[Task&lt;SerpGoogleLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'

### **SerpGoogleLocationsAsync(CancellationToken)**

```csharp
public Task<SerpGoogleLocationsResponseInfo> SerpGoogleLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'

### **SerpGoogleLocationsCountryAsync(String)**

```csharp
public Task<SerpGoogleLocationsCountryResponseInfo> SerpGoogleLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpGoogleLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'

### **SerpGoogleLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleLocationsCountryResponseInfo> SerpGoogleLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'

### **SerpGoogleLanguagesAsync()**

```csharp
public Task<SerpGoogleLanguagesResponseInfo> SerpGoogleLanguagesAsync()
```

#### Returns

[Task&lt;SerpGoogleLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/languages/?bash'

### **SerpGoogleLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpGoogleLanguagesResponseInfo> SerpGoogleLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/languages/?bash'

### **GoogleOrganicTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpGoogleOrganicTaskPostResponseInfo> GoogleOrganicTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_post/?bash'

### **GoogleOrganicTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicTaskPostResponseInfo> GoogleOrganicTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_post/?bash'

### **GoogleOrganicTasksReadyAsync()**

```csharp
public Task<SerpGoogleOrganicTasksReadyResponseInfo> GoogleOrganicTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_ready/?bash'

### **GoogleOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleOrganicTasksReadyResponseInfo> GoogleOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_ready/?bash'

### **GoogleOrganicTasksFixedAsync()**

```csharp
public Task<SerpGoogleOrganicTasksFixedResponseInfo> GoogleOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_fixed/?bash'

### **GoogleOrganicTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpGoogleOrganicTasksFixedResponseInfo> GoogleOrganicTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_fixed/?bash'

### **GoogleOrganicTaskGetRegularAsync(String)**

```csharp
public Task<SerpGoogleOrganicTaskGetRegularResponseInfo> GoogleOrganicTaskGetRegularAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/regular/?bash'

### **GoogleOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicTaskGetRegularResponseInfo> GoogleOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/regular/?bash'

### **GoogleOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleOrganicTaskGetAdvancedResponseInfo> GoogleOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/advanced/?bash'

### **GoogleOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicTaskGetAdvancedResponseInfo> GoogleOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/advanced/?bash'

### **GoogleOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleOrganicTaskGetHtmlResponseInfo> GoogleOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/html/?bash'

### **GoogleOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicTaskGetHtmlResponseInfo> GoogleOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/html/?bash'

### **GoogleOrganicLiveRegularAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpGoogleOrganicLiveRegularResponseInfo> GoogleOrganicLiveRegularAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleOrganicLiveRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganicliveregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/regular/?bash'

### **GoogleOrganicLiveRegularAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicLiveRegularResponseInfo> GoogleOrganicLiveRegularAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicLiveRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganicliveregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/regular/?bash'

### **GoogleOrganicLiveAdvancedAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpGoogleOrganicLiveAdvancedResponseInfo> GoogleOrganicLiveAdvancedAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleOrganicLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganicliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/advanced/?bash'

### **GoogleOrganicLiveAdvancedAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicLiveAdvancedResponseInfo> GoogleOrganicLiveAdvancedAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganicliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/advanced/?bash'

### **GoogleOrganicLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpGoogleOrganicLiveHtmlResponseInfo> GoogleOrganicLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleOrganicLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganiclivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/html/?bash'

### **GoogleOrganicLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicLiveHtmlResponseInfo> GoogleOrganicLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleorganiclivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/html/?bash'

### **GoogleMapsTaskPostAsync(IEnumerable&lt;SerpGoogleMapsTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleMapsTaskPostResponseInfo> GoogleMapsTaskPostAsync(IEnumerable<SerpGoogleMapsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleMapsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglemapstaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleMapsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglemapstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/task_post/?bash'

### **GoogleMapsTaskPostAsync(IEnumerable&lt;SerpGoogleMapsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleMapsTaskPostResponseInfo> GoogleMapsTaskPostAsync(IEnumerable<SerpGoogleMapsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleMapsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglemapstaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleMapsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglemapstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/task_post/?bash'

### **GoogleMapsTasksReadyAsync()**

```csharp
public Task<SerpGoogleMapsTasksReadyResponseInfo> GoogleMapsTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleMapsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglemapstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/tasks_ready/?bash'

### **GoogleMapsTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleMapsTasksReadyResponseInfo> GoogleMapsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleMapsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglemapstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/tasks_ready/?bash'

### **GoogleMapsTasksFixedAsync()**

```csharp
public Task<SerpGoogleMapsTasksFixedResponseInfo> GoogleMapsTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleMapsTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglemapstasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/tasks_fixed/?bash'

### **GoogleMapsTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpGoogleMapsTasksFixedResponseInfo> GoogleMapsTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleMapsTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglemapstasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/tasks_fixed/?bash'

### **GoogleMapsTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleMapsTaskGetAdvancedResponseInfo> GoogleMapsTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>a universally unique identifier (UUID)
 <br>unique task identifier in our system
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleMapsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglemapstaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/task_get/advanced/?bash'

### **GoogleMapsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleMapsTaskGetAdvancedResponseInfo> GoogleMapsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>a universally unique identifier (UUID)
 <br>unique task identifier in our system
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleMapsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglemapstaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/task_get/advanced/?bash'

### **GoogleMapsLiveAdvancedAsync(IEnumerable&lt;SerpGoogleMapsLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleMapsLiveAdvancedResponseInfo> GoogleMapsLiveAdvancedAsync(IEnumerable<SerpGoogleMapsLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleMapsLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglemapsliveadvancedrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleMapsLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglemapsliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Google Maps SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/live/advanced/?bash'

### **GoogleMapsLiveAdvancedAsync(IEnumerable&lt;SerpGoogleMapsLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleMapsLiveAdvancedResponseInfo> GoogleMapsLiveAdvancedAsync(IEnumerable<SerpGoogleMapsLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleMapsLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglemapsliveadvancedrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleMapsLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglemapsliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Google Maps SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/live/advanced/?bash'

### **GoogleLocalFinderTaskPostAsync(IEnumerable&lt;SerpGoogleLocalFinderTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleLocalFinderTaskPostResponseInfo> GoogleLocalFinderTaskPostAsync(IEnumerable<SerpGoogleLocalFinderTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleLocalFinderTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglelocalfindertaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfindertaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Local Finder SERP API provides top search engine results specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_post/?bash'

### **GoogleLocalFinderTaskPostAsync(IEnumerable&lt;SerpGoogleLocalFinderTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleLocalFinderTaskPostResponseInfo> GoogleLocalFinderTaskPostAsync(IEnumerable<SerpGoogleLocalFinderTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleLocalFinderTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglelocalfindertaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfindertaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Local Finder SERP API provides top search engine results specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_post/?bash'

### **GoogleLocalFinderTasksReadyAsync()**

```csharp
public Task<SerpGoogleLocalFinderTasksReadyResponseInfo> GoogleLocalFinderTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleLocalFinderTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfindertasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/tasks_ready/?bash'

### **GoogleLocalFinderTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleLocalFinderTasksReadyResponseInfo> GoogleLocalFinderTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfindertasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/tasks_ready/?bash'

### **GoogleLocalFinderTasksFixedAsync()**

```csharp
public Task<SerpGoogleLocalFinderTasksFixedResponseInfo> GoogleLocalFinderTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleLocalFinderTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfindertasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/tasks_fixed/?bash'

### **GoogleLocalFinderTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpGoogleLocalFinderTasksFixedResponseInfo> GoogleLocalFinderTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfindertasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/tasks_fixed/?bash'

### **GoogleLocalFinderTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleLocalFinderTaskGetAdvancedResponseInfo> GoogleLocalFinderTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>a universally unique identifier (UUID)
 <br>unique task identifier in our system
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfindertaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/advanced/?bash'

### **GoogleLocalFinderTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleLocalFinderTaskGetAdvancedResponseInfo> GoogleLocalFinderTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>a universally unique identifier (UUID)
 <br>unique task identifier in our system
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfindertaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/advanced/?bash'

### **GoogleLocalFinderTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleLocalFinderTaskGetHtmlResponseInfo> GoogleLocalFinderTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfindertaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/html/?bash'

### **GoogleLocalFinderTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleLocalFinderTaskGetHtmlResponseInfo> GoogleLocalFinderTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfindertaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/html/?bash'

### **GoogleLocalFinderLiveAdvancedAsync(IEnumerable&lt;SerpGoogleLocalFinderLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleLocalFinderLiveAdvancedResponseInfo> GoogleLocalFinderLiveAdvancedAsync(IEnumerable<SerpGoogleLocalFinderLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleLocalFinderLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglelocalfinderliveadvancedrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleLocalFinderLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfinderliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Google Local finder SERP provides real-time search engine results for the specified keyword and location. By default, you can get up to 20 results for desktop and up to 10 results for mobile.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/live/advanced/?bash'

### **GoogleLocalFinderLiveAdvancedAsync(IEnumerable&lt;SerpGoogleLocalFinderLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleLocalFinderLiveAdvancedResponseInfo> GoogleLocalFinderLiveAdvancedAsync(IEnumerable<SerpGoogleLocalFinderLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleLocalFinderLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglelocalfinderliveadvancedrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfinderliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Google Local finder SERP provides real-time search engine results for the specified keyword and location. By default, you can get up to 20 results for desktop and up to 10 results for mobile.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/live/advanced/?bash'

### **GoogleLocalFinderLiveHtmlAsync(IEnumerable&lt;SerpGoogleLocalFinderLiveHtmlRequestInfo&gt;)**

```csharp
public Task<SerpGoogleLocalFinderLiveHtmlResponseInfo> GoogleLocalFinderLiveHtmlAsync(IEnumerable<SerpGoogleLocalFinderLiveHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleLocalFinderLiveHtmlRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglelocalfinderlivehtmlrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleLocalFinderLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfinderlivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Local Finder SERP HTML provides a raw HTML page of the search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/live/html/?bash'

### **GoogleLocalFinderLiveHtmlAsync(IEnumerable&lt;SerpGoogleLocalFinderLiveHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleLocalFinderLiveHtmlResponseInfo> GoogleLocalFinderLiveHtmlAsync(IEnumerable<SerpGoogleLocalFinderLiveHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleLocalFinderLiveHtmlRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglelocalfinderlivehtmlrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglelocalfinderlivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Local Finder SERP HTML provides a raw HTML page of the search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/live/html/?bash'

### **GoogleNewsTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpGoogleNewsTaskPostResponseInfo> GoogleNewsTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleNewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_post/?bash'

### **GoogleNewsTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleNewsTaskPostResponseInfo> GoogleNewsTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_post/?bash'

### **GoogleNewsTasksReadyAsync()**

```csharp
public Task<SerpGoogleNewsTasksReadyResponseInfo> GoogleNewsTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleNewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/tasks_ready/?bash'

### **GoogleNewsTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleNewsTasksReadyResponseInfo> GoogleNewsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/tasks_ready/?bash'

### **GoogleNewsTasksFixedAsync()**

```csharp
public Task<SerpGoogleNewsTasksFixedResponseInfo> GoogleNewsTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleNewsTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewstasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/tasks_fixed/?bash'

### **GoogleNewsTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpGoogleNewsTasksFixedResponseInfo> GoogleNewsTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewstasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/tasks_fixed/?bash'

### **GoogleNewsTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleNewsTaskGetAdvancedResponseInfo> GoogleNewsTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleNewsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewstaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/advanced/?bash'

### **GoogleNewsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleNewsTaskGetAdvancedResponseInfo> GoogleNewsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewstaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/advanced/?bash'

### **GoogleNewsTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleNewsTaskGetHtmlResponseInfo> GoogleNewsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleNewsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewstaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/html/?bash'

### **GoogleNewsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleNewsTaskGetHtmlResponseInfo> GoogleNewsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewstaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/html/?bash'

### **GoogleNewsLiveAdvancedAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpGoogleNewsLiveAdvancedResponseInfo> GoogleNewsLiveAdvancedAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleNewsLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewsliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Google News SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/live/advanced/?bash'

### **GoogleNewsLiveAdvancedAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleNewsLiveAdvancedResponseInfo> GoogleNewsLiveAdvancedAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewsliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Google News SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/live/advanced/?bash'

### **GoogleNewsLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpGoogleNewsLiveHtmlResponseInfo> GoogleNewsLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleNewsLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewslivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/live/html/?bash'

### **GoogleNewsLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleNewsLiveHtmlResponseInfo> GoogleNewsLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglenewslivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/live/html/?bash'

### **GoogleEventsTaskPostAsync(IEnumerable&lt;SerpGoogleEventsTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleEventsTaskPostResponseInfo> GoogleEventsTaskPostAsync(IEnumerable<SerpGoogleEventsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleEventsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogleeventstaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleEventsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleeventstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Events SERP provides data from Google Events Search for the specified keyword and location (see the List of Locations). Note that Google Events SERP API works for the English language only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/task_post/?bash'

### **GoogleEventsTaskPostAsync(IEnumerable&lt;SerpGoogleEventsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleEventsTaskPostResponseInfo> GoogleEventsTaskPostAsync(IEnumerable<SerpGoogleEventsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleEventsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogleeventstaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleEventsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleeventstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Events SERP provides data from Google Events Search for the specified keyword and location (see the List of Locations). Note that Google Events SERP API works for the English language only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/task_post/?bash'

### **GoogleEventsTasksReadyAsync()**

```csharp
public Task<SerpGoogleEventsTasksReadyResponseInfo> GoogleEventsTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleEventsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleeventstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/tasks_ready/?bash'

### **GoogleEventsTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleEventsTasksReadyResponseInfo> GoogleEventsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleEventsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleeventstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/tasks_ready/?bash'

### **GoogleEventsTasksFixedAsync()**

```csharp
public Task<SerpGoogleEventsTasksFixedResponseInfo> GoogleEventsTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleEventsTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleeventstasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/tasks_fixed/?bash'

### **GoogleEventsTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpGoogleEventsTasksFixedResponseInfo> GoogleEventsTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleEventsTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleeventstasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/tasks_fixed/?bash'

### **GoogleEventsTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleEventsTaskGetAdvancedResponseInfo> GoogleEventsTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleEventsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleeventstaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/task_get/advanced/?bash'

### **GoogleEventsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleEventsTaskGetAdvancedResponseInfo> GoogleEventsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleEventsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleeventstaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/task_get/advanced/?bash'

### **GoogleEventsLiveAdvancedAsync(IEnumerable&lt;SerpGoogleEventsLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleEventsLiveAdvancedResponseInfo> GoogleEventsLiveAdvancedAsync(IEnumerable<SerpGoogleEventsLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleEventsLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogleeventsliveadvancedrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleEventsLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleeventsliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Google Events SERP provides real-time data from Google Events Search for the specified keyword and location. Note that Google Events SERP API works for the English language only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/live/advanced/?bash'

### **GoogleEventsLiveAdvancedAsync(IEnumerable&lt;SerpGoogleEventsLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleEventsLiveAdvancedResponseInfo> GoogleEventsLiveAdvancedAsync(IEnumerable<SerpGoogleEventsLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleEventsLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogleeventsliveadvancedrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleEventsLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleeventsliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Google Events SERP provides real-time data from Google Events Search for the specified keyword and location. Note that Google Events SERP API works for the English language only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/live/advanced/?bash'

### **GoogleImagesTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpGoogleImagesTaskPostResponseInfo> GoogleImagesTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleImagesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagestaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_post/?bash'

### **GoogleImagesTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleImagesTaskPostResponseInfo> GoogleImagesTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagestaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_post/?bash'

### **GoogleImagesTasksReadyAsync()**

```csharp
public Task<SerpGoogleImagesTasksReadyResponseInfo> GoogleImagesTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleImagesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagestasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/tasks_ready/?bash'

### **GoogleImagesTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleImagesTasksReadyResponseInfo> GoogleImagesTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagestasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/tasks_ready/?bash'

### **GoogleImagesTasksFixedAsync()**

```csharp
public Task<SerpGoogleImagesTasksFixedResponseInfo> GoogleImagesTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleImagesTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagestasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/tasks_fixed/?bash'

### **GoogleImagesTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpGoogleImagesTasksFixedResponseInfo> GoogleImagesTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagestasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/tasks_fixed/?bash'

### **GoogleImagesTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleImagesTaskGetAdvancedResponseInfo> GoogleImagesTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleImagesTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagestaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/advanced/?bash'

### **GoogleImagesTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleImagesTaskGetAdvancedResponseInfo> GoogleImagesTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagestaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/advanced/?bash'

### **GoogleImagesTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleImagesTaskGetHtmlResponseInfo> GoogleImagesTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleImagesTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagestaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/html/?bash'

### **GoogleImagesTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleImagesTaskGetHtmlResponseInfo> GoogleImagesTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagestaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/html/?bash'

### **GoogleImagesLiveAdvancedAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpGoogleImagesLiveAdvancedResponseInfo> GoogleImagesLiveAdvancedAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleImagesLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagesliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Images SERP provides real-time data on top 100 images results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/live/advanced/?bash'

### **GoogleImagesLiveAdvancedAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleImagesLiveAdvancedResponseInfo> GoogleImagesLiveAdvancedAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimagesliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Images SERP provides real-time data on top 100 images results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/live/advanced/?bash'

### **GoogleImagesLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpGoogleImagesLiveHtmlResponseInfo> GoogleImagesLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleImagesLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimageslivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/live/html/?bash'

### **GoogleImagesLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleImagesLiveHtmlResponseInfo> GoogleImagesLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogleimageslivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/live/html/?bash'

### **GoogleSearchByImageTaskPostAsync(IEnumerable&lt;SerpGoogleSearchByImageTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleSearchByImageTaskPostResponseInfo> GoogleSearchByImageTaskPostAsync(IEnumerable<SerpGoogleSearchByImageTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleSearchByImageTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglesearchbyimagetaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleSearchByImageTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglesearchbyimagetaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Search By Image SERP API provides up to top 100 search engine results based on the image you specified. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/task_post/?bash'

### **GoogleSearchByImageTaskPostAsync(IEnumerable&lt;SerpGoogleSearchByImageTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleSearchByImageTaskPostResponseInfo> GoogleSearchByImageTaskPostAsync(IEnumerable<SerpGoogleSearchByImageTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleSearchByImageTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglesearchbyimagetaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleSearchByImageTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglesearchbyimagetaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Search By Image SERP API provides up to top 100 search engine results based on the image you specified. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/task_post/?bash'

### **GoogleSearchByImageTasksReadyAsync()**

```csharp
public Task<SerpGoogleSearchByImageTasksReadyResponseInfo> GoogleSearchByImageTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleSearchByImageTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglesearchbyimagetasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/tasks_ready/?bash'

### **GoogleSearchByImageTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleSearchByImageTasksReadyResponseInfo> GoogleSearchByImageTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleSearchByImageTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglesearchbyimagetasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/tasks_ready/?bash'

### **GoogleSearchByImageTasksFixedAsync()**

```csharp
public Task<SerpGoogleSearchByImageTasksFixedResponseInfo> GoogleSearchByImageTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleSearchByImageTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglesearchbyimagetasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/tasks_fixed/?bash'

### **GoogleSearchByImageTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpGoogleSearchByImageTasksFixedResponseInfo> GoogleSearchByImageTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleSearchByImageTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglesearchbyimagetasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/tasks_fixed/?bash'

### **GoogleSearchByImageTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleSearchByImageTaskGetAdvancedResponseInfo> GoogleSearchByImageTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleSearchByImageTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglesearchbyimagetaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/task_get/advanced/?bash'

### **GoogleSearchByImageTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleSearchByImageTaskGetAdvancedResponseInfo> GoogleSearchByImageTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleSearchByImageTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglesearchbyimagetaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/task_get/advanced/?bash'

### **GoogleJobsTaskPostAsync(IEnumerable&lt;SerpGoogleJobsTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleJobsTaskPostResponseInfo> GoogleJobsTaskPostAsync(IEnumerable<SerpGoogleJobsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleJobsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglejobstaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleJobsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglejobstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with SERP data from the Google Jobs search engine. The returned results are specific to the keyword as well as the language and location parameters of the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_post/?bash'

### **GoogleJobsTaskPostAsync(IEnumerable&lt;SerpGoogleJobsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleJobsTaskPostResponseInfo> GoogleJobsTaskPostAsync(IEnumerable<SerpGoogleJobsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleJobsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgooglejobstaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleJobsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglejobstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with SERP data from the Google Jobs search engine. The returned results are specific to the keyword as well as the language and location parameters of the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_post/?bash'

### **GoogleJobsTasksReadyAsync()**

```csharp
public Task<SerpGoogleJobsTasksReadyResponseInfo> GoogleJobsTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleJobsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglejobstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/tasks_ready/?bash'

### **GoogleJobsTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleJobsTasksReadyResponseInfo> GoogleJobsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleJobsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglejobstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/tasks_ready/?bash'

### **GoogleJobsTasksFixedAsync()**

```csharp
public Task<SerpGoogleJobsTasksFixedResponseInfo> GoogleJobsTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleJobsTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglejobstasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/tasks_fixed/?bash'

### **GoogleJobsTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpGoogleJobsTasksFixedResponseInfo> GoogleJobsTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleJobsTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglejobstasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/tasks_fixed/?bash'

### **GoogleJobsTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleJobsTaskGetAdvancedResponseInfo> GoogleJobsTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleJobsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglejobstaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/advanced/?bash'

### **GoogleJobsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleJobsTaskGetAdvancedResponseInfo> GoogleJobsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleJobsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglejobstaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/advanced/?bash'

### **GoogleJobsTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleJobsTaskGetHtmlResponseInfo> GoogleJobsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleJobsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglejobstaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/html/?bash'

### **GoogleJobsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleJobsTaskGetHtmlResponseInfo> GoogleJobsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleJobsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpgooglejobstaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/html/?bash'

### **GoogleDatasetSearchTaskPostAsync(IEnumerable&lt;SerpGoogleDatasetSearchTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleDatasetSearchTaskPostResponseInfo> GoogleDatasetSearchTaskPostAsync(IEnumerable<SerpGoogleDatasetSearchTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleDatasetSearchTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogledatasetsearchtaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleDatasetSearchTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetsearchtaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Dataset Search API provides top 20 Google Dataset search engine results. These results are specific to the indicated keyword. You can specify other parameters optionally.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/task_post/?bash'

### **GoogleDatasetSearchTaskPostAsync(IEnumerable&lt;SerpGoogleDatasetSearchTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleDatasetSearchTaskPostResponseInfo> GoogleDatasetSearchTaskPostAsync(IEnumerable<SerpGoogleDatasetSearchTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleDatasetSearchTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogledatasetsearchtaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetSearchTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetsearchtaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Dataset Search API provides top 20 Google Dataset search engine results. These results are specific to the indicated keyword. You can specify other parameters optionally.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/task_post/?bash'

### **GoogleDatasetSearchTasksReadyAsync()**

```csharp
public Task<SerpGoogleDatasetSearchTasksReadyResponseInfo> GoogleDatasetSearchTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleDatasetSearchTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetsearchtasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/tasks_ready/?bash'

### **GoogleDatasetSearchTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleDatasetSearchTasksReadyResponseInfo> GoogleDatasetSearchTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetSearchTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetsearchtasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/tasks_ready/?bash'

### **GoogleDatasetSearchTasksFixedAsync()**

```csharp
public Task<SerpGoogleDatasetSearchTasksFixedResponseInfo> GoogleDatasetSearchTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleDatasetSearchTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetsearchtasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/tasks_fixed/?bash'

### **GoogleDatasetSearchTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpGoogleDatasetSearchTasksFixedResponseInfo> GoogleDatasetSearchTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetSearchTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetsearchtasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/tasks_fixed/?bash'

### **GoogleDatasetSearchTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo> GoogleDatasetSearchTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetsearchtaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/task_get/advanced/?bash'

### **GoogleDatasetSearchTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo> GoogleDatasetSearchTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetsearchtaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/task_get/advanced/?bash'

### **GoogleDatasetSearchLiveAdvancedAsync(IEnumerable&lt;SerpGoogleDatasetSearchLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleDatasetSearchLiveAdvancedResponseInfo> GoogleDatasetSearchLiveAdvancedAsync(IEnumerable<SerpGoogleDatasetSearchLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleDatasetSearchLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogledatasetsearchliveadvancedrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleDatasetSearchLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetsearchliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Dataset Search provides real-time data on the top 20 Google Dataset search engine results. These results are specific to the indicated keyword. You can specify other parameters optionally.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/live/advanced/?bash'

### **GoogleDatasetSearchLiveAdvancedAsync(IEnumerable&lt;SerpGoogleDatasetSearchLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleDatasetSearchLiveAdvancedResponseInfo> GoogleDatasetSearchLiveAdvancedAsync(IEnumerable<SerpGoogleDatasetSearchLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleDatasetSearchLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogledatasetsearchliveadvancedrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetSearchLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetsearchliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Dataset Search provides real-time data on the top 20 Google Dataset search engine results. These results are specific to the indicated keyword. You can specify other parameters optionally.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/live/advanced/?bash'

### **GoogleDatasetInfoTaskPostAsync(IEnumerable&lt;SerpGoogleDatasetInfoTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleDatasetInfoTaskPostResponseInfo> GoogleDatasetInfoTaskPostAsync(IEnumerable<SerpGoogleDatasetInfoTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleDatasetInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogledatasetinfotaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleDatasetInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetinfotaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Dataset Info API provides detailed information about the dataset you specify in the POST request. You will get data from a page of the dataset displayed separately from the SERP. It contains information about dataset content, authors, licenses, and description on the SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/task_post/?bash'

### **GoogleDatasetInfoTaskPostAsync(IEnumerable&lt;SerpGoogleDatasetInfoTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleDatasetInfoTaskPostResponseInfo> GoogleDatasetInfoTaskPostAsync(IEnumerable<SerpGoogleDatasetInfoTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleDatasetInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogledatasetinfotaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetinfotaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Dataset Info API provides detailed information about the dataset you specify in the POST request. You will get data from a page of the dataset displayed separately from the SERP. It contains information about dataset content, authors, licenses, and description on the SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/task_post/?bash'

### **GoogleDatasetInfoTasksReadyAsync()**

```csharp
public Task<SerpGoogleDatasetInfoTasksReadyResponseInfo> GoogleDatasetInfoTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleDatasetInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetinfotasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/tasks_ready/?bash'

### **GoogleDatasetInfoTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleDatasetInfoTasksReadyResponseInfo> GoogleDatasetInfoTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetinfotasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/tasks_ready/?bash'

### **GoogleDatasetInfoTasksFixedAsync()**

```csharp
public Task<SerpGoogleDatasetInfoTasksFixedResponseInfo> GoogleDatasetInfoTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleDatasetInfoTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetinfotasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/tasks_fixed/?bash'

### **GoogleDatasetInfoTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpGoogleDatasetInfoTasksFixedResponseInfo> GoogleDatasetInfoTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetInfoTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetinfotasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/tasks_fixed/?bash'

### **GoogleDatasetInfoTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo> GoogleDatasetInfoTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetinfotaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/task_get/advanced/?bash'

### **GoogleDatasetInfoTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo> GoogleDatasetInfoTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetinfotaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/task_get/advanced/?bash'

### **GoogleDatasetInfoLiveAdvancedAsync(IEnumerable&lt;SerpGoogleDatasetInfoLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleDatasetInfoLiveAdvancedResponseInfo> GoogleDatasetInfoLiveAdvancedAsync(IEnumerable<SerpGoogleDatasetInfoLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleDatasetInfoLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogledatasetinfoliveadvancedrequestinfo.md)<br>

#### Returns

[Task&lt;SerpGoogleDatasetInfoLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetinfoliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Dataset Info provides real-time data on the dataset you specify in the request. You will get data from a page of the dataset displayed separately from the SERP. It contains information about dataset content, authors, licenses, and description on the SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/live/advanced/?bash'

### **GoogleDatasetInfoLiveAdvancedAsync(IEnumerable&lt;SerpGoogleDatasetInfoLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleDatasetInfoLiveAdvancedResponseInfo> GoogleDatasetInfoLiveAdvancedAsync(IEnumerable<SerpGoogleDatasetInfoLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleDatasetInfoLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpgoogledatasetinfoliveadvancedrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetInfoLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpgoogledatasetinfoliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Dataset Info provides real-time data on the dataset you specify in the request. You will get data from a page of the dataset displayed separately from the SERP. It contains information about dataset content, authors, licenses, and description on the SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/live/advanced/?bash'

### **SerpBingLocationsAsync()**

```csharp
public Task<SerpBingLocationsResponseInfo> SerpBingLocationsAsync()
```

#### Returns

[Task&lt;SerpBingLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'

### **SerpBingLocationsAsync(CancellationToken)**

```csharp
public Task<SerpBingLocationsResponseInfo> SerpBingLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'

### **SerpBingLocationsCountryAsync(String)**

```csharp
public Task<SerpBingLocationsCountryResponseInfo> SerpBingLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpBingLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'

### **SerpBingLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpBingLocationsCountryResponseInfo> SerpBingLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'

### **SerpBingLanguagesAsync()**

```csharp
public Task<SerpBingLanguagesResponseInfo> SerpBingLanguagesAsync()
```

#### Returns

[Task&lt;SerpBingLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/languages/?bash'

### **SerpBingLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpBingLanguagesResponseInfo> SerpBingLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/languages/?bash'

### **BingOrganicTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpBingOrganicTaskPostResponseInfo> BingOrganicTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpBingOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_post/?bash'

### **BingOrganicTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingOrganicTaskPostResponseInfo> BingOrganicTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_post/?bash'

### **BingOrganicTasksReadyAsync()**

```csharp
public Task<SerpBingOrganicTasksReadyResponseInfo> BingOrganicTasksReadyAsync()
```

#### Returns

[Task&lt;SerpBingOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/tasks_ready/?bash'

### **BingOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpBingOrganicTasksReadyResponseInfo> BingOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/tasks_ready/?bash'

### **BingOrganicTasksFixedAsync()**

```csharp
public Task<SerpBingOrganicTasksFixedResponseInfo> BingOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpBingOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/tasks_fixed/?bash'

### **BingOrganicTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpBingOrganicTasksFixedResponseInfo> BingOrganicTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/tasks_fixed/?bash'

### **BingOrganicTaskGetRegularAsync(String)**

```csharp
public Task<SerpBingOrganicTaskGetRegularResponseInfo> BingOrganicTaskGetRegularAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBingOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/regular/?bash'

### **BingOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpBingOrganicTaskGetRegularResponseInfo> BingOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/regular/?bash'

### **BingOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpBingOrganicTaskGetAdvancedResponseInfo> BingOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBingOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/advanced/?bash'

### **BingOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpBingOrganicTaskGetAdvancedResponseInfo> BingOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/advanced/?bash'

### **BingOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpBingOrganicTaskGetHtmlResponseInfo> BingOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBingOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/html/?bash'

### **BingOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpBingOrganicTaskGetHtmlResponseInfo> BingOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/html/?bash'

### **BingOrganicLiveRegularAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpBingOrganicLiveRegularResponseInfo> BingOrganicLiveRegularAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpBingOrganicLiveRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganicliveregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/regular/?bash'

### **BingOrganicLiveRegularAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingOrganicLiveRegularResponseInfo> BingOrganicLiveRegularAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicLiveRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganicliveregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/regular/?bash'

### **BingOrganicLiveAdvancedAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpBingOrganicLiveAdvancedResponseInfo> BingOrganicLiveAdvancedAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpBingOrganicLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganicliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/advanced/?bash'

### **BingOrganicLiveAdvancedAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingOrganicLiveAdvancedResponseInfo> BingOrganicLiveAdvancedAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganicliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/advanced/?bash'

### **BingOrganicLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpBingOrganicLiveHtmlResponseInfo> BingOrganicLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpBingOrganicLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganiclivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/html/?bash'

### **BingOrganicLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingOrganicLiveHtmlResponseInfo> BingOrganicLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpbingorganiclivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/html/?bash'

### **BingLocalPackTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpBingLocalPackTaskPostResponseInfo> BingLocalPackTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpBingLocalPackTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacktaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_post/?bash'

### **BingLocalPackTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingLocalPackTaskPostResponseInfo> BingLocalPackTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacktaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_post/?bash'

### **BingLocalPackTasksReadyAsync()**

```csharp
public Task<SerpBingLocalPackTasksReadyResponseInfo> BingLocalPackTasksReadyAsync()
```

#### Returns

[Task&lt;SerpBingLocalPackTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacktasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/tasks_ready/?bash'

### **BingLocalPackTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpBingLocalPackTasksReadyResponseInfo> BingLocalPackTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacktasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/tasks_ready/?bash'

### **BingLocalPackTasksFixedAsync()**

```csharp
public Task<SerpBingLocalPackTasksFixedResponseInfo> BingLocalPackTasksFixedAsync()
```

#### Returns

[Task&lt;SerpBingLocalPackTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacktasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/tasks_fixed/?bash'

### **BingLocalPackTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpBingLocalPackTasksFixedResponseInfo> BingLocalPackTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacktasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/tasks_fixed/?bash'

### **BingLocalPackTaskGetRegularAsync(String)**

```csharp
public Task<SerpBingLocalPackTaskGetRegularResponseInfo> BingLocalPackTaskGetRegularAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBingLocalPackTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacktaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/regular/?bash'

### **BingLocalPackTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpBingLocalPackTaskGetRegularResponseInfo> BingLocalPackTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacktaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/regular/?bash'

### **BingLocalPackTaskGetHtmlAsync(String)**

```csharp
public Task<SerpBingLocalPackTaskGetHtmlResponseInfo> BingLocalPackTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBingLocalPackTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacktaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/html/?bash'

### **BingLocalPackTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpBingLocalPackTaskGetHtmlResponseInfo> BingLocalPackTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacktaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/html/?bash'

### **BingLocalPackLiveRegularAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpBingLocalPackLiveRegularResponseInfo> BingLocalPackLiveRegularAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpBingLocalPackLiveRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpackliveregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Bing Local Pack SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/live/regular/?bash'

### **BingLocalPackLiveRegularAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingLocalPackLiveRegularResponseInfo> BingLocalPackLiveRegularAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackLiveRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpackliveregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Bing Local Pack SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/live/regular/?bash'

### **BingLocalPackLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpBingLocalPackLiveHtmlResponseInfo> BingLocalPackLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpBingLocalPackLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacklivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/live/html/?bash'

### **BingLocalPackLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingLocalPackLiveHtmlResponseInfo> BingLocalPackLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpbinglocalpacklivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/live/html/?bash'

### **SerpYoutubeLocationsAsync()**

```csharp
public Task<SerpYoutubeLocationsResponseInfo> SerpYoutubeLocationsAsync()
```

#### Returns

[Task&lt;SerpYoutubeLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubelocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'

### **SerpYoutubeLocationsAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeLocationsResponseInfo> SerpYoutubeLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubelocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'

### **SerpYoutubeLocationsCountryAsync(String)**

```csharp
public Task<SerpYoutubeLocationsCountryResponseInfo> SerpYoutubeLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpYoutubeLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubelocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'

### **SerpYoutubeLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpYoutubeLocationsCountryResponseInfo> SerpYoutubeLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubelocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'

### **SerpYoutubeLanguagesAsync()**

```csharp
public Task<SerpYoutubeLanguagesResponseInfo> SerpYoutubeLanguagesAsync()
```

#### Returns

[Task&lt;SerpYoutubeLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubelanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/languages/?bash'

### **SerpYoutubeLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeLanguagesResponseInfo> SerpYoutubeLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubelanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/languages/?bash'

### **YoutubeVideoInfoTaskPostAsync(IEnumerable&lt;SerpYoutubeVideoInfoTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpYoutubeVideoInfoTaskPostResponseInfo> YoutubeVideoInfoTaskPostAsync(IEnumerable<SerpYoutubeVideoInfoTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideoinfotaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideoinfotaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>YouTube Video Info API provides detailed information about the video you specify in the POST request. You will get data from the watching page containing key video and content metrics as well as the channel where the video is published.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/task_post/?bash'

### **YoutubeVideoInfoTaskPostAsync(IEnumerable&lt;SerpYoutubeVideoInfoTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoInfoTaskPostResponseInfo> YoutubeVideoInfoTaskPostAsync(IEnumerable<SerpYoutubeVideoInfoTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideoinfotaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideoinfotaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>YouTube Video Info API provides detailed information about the video you specify in the POST request. You will get data from the watching page containing key video and content metrics as well as the channel where the video is published.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/task_post/?bash'

### **YoutubeVideoInfoTasksReadyAsync()**

```csharp
public Task<SerpYoutubeVideoInfoTasksReadyResponseInfo> YoutubeVideoInfoTasksReadyAsync()
```

#### Returns

[Task&lt;SerpYoutubeVideoInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideoinfotasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/tasks_ready/?bash'

### **YoutubeVideoInfoTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeVideoInfoTasksReadyResponseInfo> YoutubeVideoInfoTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideoinfotasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/tasks_ready/?bash'

### **YoutubeVideoInfoTasksFixedAsync()**

```csharp
public Task<SerpYoutubeVideoInfoTasksFixedResponseInfo> YoutubeVideoInfoTasksFixedAsync()
```

#### Returns

[Task&lt;SerpYoutubeVideoInfoTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideoinfotasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/tasks_fixed/?bash'

### **YoutubeVideoInfoTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeVideoInfoTasksFixedResponseInfo> YoutubeVideoInfoTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoInfoTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideoinfotasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/tasks_fixed/?bash'

### **YoutubeVideoInfoTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo> YoutubeVideoInfoTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideoinfotaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/task_get/advanced/?bash'

### **YoutubeVideoInfoTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo> YoutubeVideoInfoTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideoinfotaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/task_get/advanced/?bash'

### **YoutubeVideoInfoLiveAdvancedAsync(IEnumerable&lt;SerpYoutubeVideoInfoLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpYoutubeVideoInfoLiveAdvancedResponseInfo> YoutubeVideoInfoLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoInfoLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoInfoLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideoinfoliveadvancedrequestinfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoInfoLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideoinfoliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live YouTube Video Info provides real-time data on the video you specify in the request. You will get data from the watching page containing key video and content metrics as well as the channel where the video is published.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/live/advanced/?bash'

### **YoutubeVideoInfoLiveAdvancedAsync(IEnumerable&lt;SerpYoutubeVideoInfoLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoInfoLiveAdvancedResponseInfo> YoutubeVideoInfoLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoInfoLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoInfoLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideoinfoliveadvancedrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoInfoLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideoinfoliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live YouTube Video Info provides real-time data on the video you specify in the request. You will get data from the watching page containing key video and content metrics as well as the channel where the video is published.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/live/advanced/?bash'

### **YoutubeVideoSubtitlesTaskPostAsync(IEnumerable&lt;SerpYoutubeVideoSubtitlesTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpYoutubeVideoSubtitlesTaskPostResponseInfo> YoutubeVideoSubtitlesTaskPostAsync(IEnumerable<SerpYoutubeVideoSubtitlesTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoSubtitlesTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideosubtitlestaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideosubtitlestaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>YouTube Subtitles API provides data on all subtitles in the video you specify in the POST request. You will get data from the watching page containing subtitled text, its language, and duration in the video.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/task_post/?bash'

### **YoutubeVideoSubtitlesTaskPostAsync(IEnumerable&lt;SerpYoutubeVideoSubtitlesTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoSubtitlesTaskPostResponseInfo> YoutubeVideoSubtitlesTaskPostAsync(IEnumerable<SerpYoutubeVideoSubtitlesTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoSubtitlesTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideosubtitlestaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideosubtitlestaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>YouTube Subtitles API provides data on all subtitles in the video you specify in the POST request. You will get data from the watching page containing subtitled text, its language, and duration in the video.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/task_post/?bash'

### **YoutubeVideoSubtitlesTasksReadyAsync()**

```csharp
public Task<SerpYoutubeVideoSubtitlesTasksReadyResponseInfo> YoutubeVideoSubtitlesTasksReadyAsync()
```

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideosubtitlestasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/tasks_ready/?bash'

### **YoutubeVideoSubtitlesTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeVideoSubtitlesTasksReadyResponseInfo> YoutubeVideoSubtitlesTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideosubtitlestasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/tasks_ready/?bash'

### **YoutubeVideoSubtitlesTasksFixedAsync()**

```csharp
public Task<SerpYoutubeVideoSubtitlesTasksFixedResponseInfo> YoutubeVideoSubtitlesTasksFixedAsync()
```

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideosubtitlestasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/tasks_fixed/?bash'

### **YoutubeVideoSubtitlesTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeVideoSubtitlesTasksFixedResponseInfo> YoutubeVideoSubtitlesTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideosubtitlestasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/tasks_fixed/?bash'

### **YoutubeVideoSubtitlesTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo> YoutubeVideoSubtitlesTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideosubtitlestaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/task_get/advanced/?bash'

### **YoutubeVideoSubtitlesTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo> YoutubeVideoSubtitlesTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideosubtitlestaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/task_get/advanced/?bash'

### **YoutubeVideoSubtitlesLiveAdvancedAsync(IEnumerable&lt;SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo> YoutubeVideoSubtitlesLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideosubtitlesliveadvancedrequestinfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideosubtitlesliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live YouTube Subtitles provides real-time data on subtitles in the video you specify in the request. You will get data from the watching page containing subtitled text, its language, and duration in the video.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/live/advanced/?bash'

### **YoutubeVideoSubtitlesLiveAdvancedAsync(IEnumerable&lt;SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo> YoutubeVideoSubtitlesLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideosubtitlesliveadvancedrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideosubtitlesliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live YouTube Subtitles provides real-time data on subtitles in the video you specify in the request. You will get data from the watching page containing subtitled text, its language, and duration in the video.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/live/advanced/?bash'

### **YoutubeVideoCommentsTaskPostAsync(IEnumerable&lt;SerpYoutubeVideoCommentsTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpYoutubeVideoCommentsTaskPostResponseInfo> YoutubeVideoCommentsTaskPostAsync(IEnumerable<SerpYoutubeVideoCommentsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoCommentsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideocommentstaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideocommentstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>YouTube Comments API provides data on comments on the video you specify in the request. You will get the top 20 comments on the video as well as information about the author, and key comment metrics.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/task_post/?bash'

### **YoutubeVideoCommentsTaskPostAsync(IEnumerable&lt;SerpYoutubeVideoCommentsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoCommentsTaskPostResponseInfo> YoutubeVideoCommentsTaskPostAsync(IEnumerable<SerpYoutubeVideoCommentsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoCommentsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideocommentstaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideocommentstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>YouTube Comments API provides data on comments on the video you specify in the request. You will get the top 20 comments on the video as well as information about the author, and key comment metrics.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/task_post/?bash'

### **YoutubeVideoCommentsTasksReadyAsync()**

```csharp
public Task<SerpYoutubeVideoCommentsTasksReadyResponseInfo> YoutubeVideoCommentsTasksReadyAsync()
```

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideocommentstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/tasks_ready/?bash'

### **YoutubeVideoCommentsTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeVideoCommentsTasksReadyResponseInfo> YoutubeVideoCommentsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideocommentstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/tasks_ready/?bash'

### **YoutubeVideoCommentsTasksFixedAsync()**

```csharp
public Task<SerpYoutubeVideoCommentsTasksFixedResponseInfo> YoutubeVideoCommentsTasksFixedAsync()
```

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideocommentstasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/tasks_fixed/?bash'

### **YoutubeVideoCommentsTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeVideoCommentsTasksFixedResponseInfo> YoutubeVideoCommentsTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideocommentstasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/tasks_fixed/?bash'

### **YoutubeVideoCommentsTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo> YoutubeVideoCommentsTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideocommentstaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/task_get/advanced/?bash'

### **YoutubeVideoCommentsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo> YoutubeVideoCommentsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideocommentstaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/task_get/advanced/?bash'

### **YoutubeVideoCommentsLiveAdvancedAsync(IEnumerable&lt;SerpYoutubeVideoCommentsLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpYoutubeVideoCommentsLiveAdvancedResponseInfo> YoutubeVideoCommentsLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoCommentsLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoCommentsLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideocommentsliveadvancedrequestinfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoCommentsLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideocommentsliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live YouTube Comments provides real-time data on comments on the video you specify in the request. You will get the top 20 comments on the video as well as information about the author, and key comment metrics.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/live/advanced/?bash'

### **YoutubeVideoCommentsLiveAdvancedAsync(IEnumerable&lt;SerpYoutubeVideoCommentsLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoCommentsLiveAdvancedResponseInfo> YoutubeVideoCommentsLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoCommentsLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoCommentsLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.serpyoutubevideocommentsliveadvancedrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoCommentsLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyoutubevideocommentsliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live YouTube Comments provides real-time data on comments on the video you specify in the request. You will get the top 20 comments on the video as well as information about the author, and key comment metrics.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/live/advanced/?bash'

### **SerpYahooLocationsAsync()**

```csharp
public Task<SerpYahooLocationsResponseInfo> SerpYahooLocationsAsync()
```

#### Returns

[Task&lt;SerpYahooLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpyahoolocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'

### **SerpYahooLocationsAsync(CancellationToken)**

```csharp
public Task<SerpYahooLocationsResponseInfo> SerpYahooLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpyahoolocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'

### **SerpYahooLocationsCountryAsync(String)**

```csharp
public Task<SerpYahooLocationsCountryResponseInfo> SerpYahooLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpYahooLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpyahoolocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'

### **SerpYahooLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpYahooLocationsCountryResponseInfo> SerpYahooLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpyahoolocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'

### **SerpYahooLanguagesAsync()**

```csharp
public Task<SerpYahooLanguagesResponseInfo> SerpYahooLanguagesAsync()
```

#### Returns

[Task&lt;SerpYahooLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpyahoolanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/languages/?bash'

### **SerpYahooLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpYahooLanguagesResponseInfo> SerpYahooLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpyahoolanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/languages/?bash'

### **YahooOrganicTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpYahooOrganicTaskPostResponseInfo> YahooOrganicTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpYahooOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_post/?bash'

### **YahooOrganicTaskPostAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYahooOrganicTaskPostResponseInfo> YahooOrganicTaskPostAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_post/?bash'

### **YahooOrganicTasksReadyAsync()**

```csharp
public Task<SerpYahooOrganicTasksReadyResponseInfo> YahooOrganicTasksReadyAsync()
```

#### Returns

[Task&lt;SerpYahooOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/tasks_ready/?bash'

### **YahooOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpYahooOrganicTasksReadyResponseInfo> YahooOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/tasks_ready/?bash'

### **YahooOrganicTasksFixedAsync()**

```csharp
public Task<SerpYahooOrganicTasksFixedResponseInfo> YahooOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpYahooOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/tasks_fixed/?bash'

### **YahooOrganicTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpYahooOrganicTasksFixedResponseInfo> YahooOrganicTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/tasks_fixed/?bash'

### **YahooOrganicTaskGetRegularAsync(String)**

```csharp
public Task<SerpYahooOrganicTaskGetRegularResponseInfo> YahooOrganicTaskGetRegularAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYahooOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/regular/?bash'

### **YahooOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpYahooOrganicTaskGetRegularResponseInfo> YahooOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/regular/?bash'

### **YahooOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpYahooOrganicTaskGetAdvancedResponseInfo> YahooOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYahooOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/advanced/?bash'

### **YahooOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpYahooOrganicTaskGetAdvancedResponseInfo> YahooOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/advanced/?bash'

### **YahooOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpYahooOrganicTaskGetHtmlResponseInfo> YahooOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYahooOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/html/?bash'

### **YahooOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpYahooOrganicTaskGetHtmlResponseInfo> YahooOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganictaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/html/?bash'

### **YahooOrganicLiveRegularAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpYahooOrganicLiveRegularResponseInfo> YahooOrganicLiveRegularAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpYahooOrganicLiveRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganicliveregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Yahoo SERP provides real-time data on up to 100 top search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/regular/?bash'

### **YahooOrganicLiveRegularAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYahooOrganicLiveRegularResponseInfo> YahooOrganicLiveRegularAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicLiveRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganicliveregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Yahoo SERP provides real-time data on up to 100 top search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/regular/?bash'

### **YahooOrganicLiveAdvancedAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpYahooOrganicLiveAdvancedResponseInfo> YahooOrganicLiveAdvancedAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpYahooOrganicLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganicliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP provides real-time data on top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/advanced/?bash'

### **YahooOrganicLiveAdvancedAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYahooOrganicLiveAdvancedResponseInfo> YahooOrganicLiveAdvancedAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganicliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP provides real-time data on top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/advanced/?bash'

### **YahooOrganicLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;)**

```csharp
public Task<SerpYahooOrganicLiveHtmlResponseInfo> YahooOrganicLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

#### Returns

[Task&lt;SerpYahooOrganicLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganiclivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/html/?bash'

### **YahooOrganicLiveHtmlAsync(IEnumerable&lt;SerpTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYahooOrganicLiveHtmlResponseInfo> YahooOrganicLiveHtmlAsync(IEnumerable<SerpTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpTaskRequestInfo&gt;](./dataforseo.client.models.requests.serptaskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.serpyahooorganiclivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/html/?bash'

### **SerpBaiduLocationsAsync()**

```csharp
public Task<SerpBaiduLocationsResponseInfo> SerpBaiduLocationsAsync()
```

#### Returns

[Task&lt;SerpBaiduLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpbaidulocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'

### **SerpBaiduLocationsAsync(CancellationToken)**

```csharp
public Task<SerpBaiduLocationsResponseInfo> SerpBaiduLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduLocationsResponseInfo&gt;](./dataforseo.client.models.responses.serpbaidulocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'

### **SerpBaiduLocationsCountryAsync(String)**

```csharp
public Task<SerpBaiduLocationsCountryResponseInfo> SerpBaiduLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpBaiduLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpbaidulocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'

### **SerpBaiduLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpBaiduLocationsCountryResponseInfo> SerpBaiduLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.serpbaidulocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'

### **SerpBaiduLanguagesAsync()**

```csharp
public Task<SerpBaiduLanguagesResponseInfo> SerpBaiduLanguagesAsync()
```

#### Returns

[Task&lt;SerpBaiduLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpbaidulanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API. You can also download the full list of supported languages in the CSV format (last updated 2023-05-02).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/languages/?bash'

### **SerpBaiduLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpBaiduLanguagesResponseInfo> SerpBaiduLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.serpbaidulanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API. You can also download the full list of supported languages in the CSV format (last updated 2023-05-02).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/languages/?bash'

### **BaiduOrganicTaskPostAsync(IEnumerable&lt;SerpBaiduOrganicTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpBaiduOrganicTaskPostResponseInfo> BaiduOrganicTaskPostAsync(IEnumerable<SerpBaiduOrganicTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpBaiduOrganicTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpbaiduorganictaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;SerpBaiduOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Baidu SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and other settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_post/?bash'

### **BaiduOrganicTaskPostAsync(IEnumerable&lt;SerpBaiduOrganicTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBaiduOrganicTaskPostResponseInfo> BaiduOrganicTaskPostAsync(IEnumerable<SerpBaiduOrganicTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpBaiduOrganicTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.serpbaiduorganictaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Baidu SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and other settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_post/?bash'

### **BaiduOrganicTasksReadyAsync()**

```csharp
public Task<SerpBaiduOrganicTasksReadyResponseInfo> BaiduOrganicTasksReadyAsync()
```

#### Returns

[Task&lt;SerpBaiduOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/tasks_ready/?bash'

### **BaiduOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpBaiduOrganicTasksReadyResponseInfo> BaiduOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/tasks_ready/?bash'

### **BaiduOrganicTasksFixedAsync()**

```csharp
public Task<SerpBaiduOrganicTasksFixedResponseInfo> BaiduOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpBaiduOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/tasks_fixed/?bash'

### **BaiduOrganicTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpBaiduOrganicTasksFixedResponseInfo> BaiduOrganicTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTasksFixedResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictasksfixedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/tasks_fixed/?bash'

### **BaiduOrganicTaskGetRegularAsync(String)**

```csharp
public Task<SerpBaiduOrganicTaskGetRegularResponseInfo> BaiduOrganicTaskGetRegularAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/regular/?bash'

### **BaiduOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpBaiduOrganicTaskGetRegularResponseInfo> BaiduOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetRegularResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictaskgetregularresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/regular/?bash'

### **BaiduOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpBaiduOrganicTaskGetAdvancedResponseInfo> BaiduOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/advanced/?bash'

### **BaiduOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpBaiduOrganicTaskGetAdvancedResponseInfo> BaiduOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.serpbaiduorganictaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/advanced/?bash'
