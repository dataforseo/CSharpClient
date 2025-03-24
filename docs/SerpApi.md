# SerpApi

Namespace: DataForSeo.Client.Api

```csharp
public class SerpApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/Object) → [SerpApi](./SerpApi.md)

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

### **SerpApi(HttpClient)**

```csharp
public SerpApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **YahooOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpYahooOrganicTaskGetAdvancedResponseInfo> YahooOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYahooOrganicTaskGetAdvancedResponseInfo&gt;](./SerpYahooOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/advanced/?bash'

### **YahooOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpYahooOrganicTaskGetAdvancedResponseInfo> YahooOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTaskGetAdvancedResponseInfo&gt;](./SerpYahooOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/advanced/?bash'

### **YahooOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpYahooOrganicTaskGetHtmlResponseInfo> YahooOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYahooOrganicTaskGetHtmlResponseInfo&gt;](./SerpYahooOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/html/?bash'

### **YahooOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpYahooOrganicTaskGetHtmlResponseInfo> YahooOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTaskGetHtmlResponseInfo&gt;](./SerpYahooOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/html/?bash'

### **YahooOrganicLiveRegularAsync(IEnumerable&lt;SerpYahooOrganicLiveRegularRequestInfo&gt;)**

```csharp
public Task<SerpYahooOrganicLiveRegularResponseInfo> YahooOrganicLiveRegularAsync(IEnumerable<SerpYahooOrganicLiveRegularRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYahooOrganicLiveRegularRequestInfo&gt;](./SerpYahooOrganicLiveRegularRequestInfo.md)<br>

#### Returns

[Task&lt;SerpYahooOrganicLiveRegularResponseInfo&gt;](./SerpYahooOrganicLiveRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Yahoo SERP provides real-time data on up to 100 top search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/regular/?bash'

### **YahooOrganicLiveRegularAsync(IEnumerable&lt;SerpYahooOrganicLiveRegularRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYahooOrganicLiveRegularResponseInfo> YahooOrganicLiveRegularAsync(IEnumerable<SerpYahooOrganicLiveRegularRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpYahooOrganicLiveRegularRequestInfo&gt;](./SerpYahooOrganicLiveRegularRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicLiveRegularResponseInfo&gt;](./SerpYahooOrganicLiveRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Yahoo SERP provides real-time data on up to 100 top search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/regular/?bash'

### **YahooOrganicLiveAdvancedAsync(IEnumerable&lt;SerpYahooOrganicLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpYahooOrganicLiveAdvancedResponseInfo> YahooOrganicLiveAdvancedAsync(IEnumerable<SerpYahooOrganicLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYahooOrganicLiveAdvancedRequestInfo&gt;](./SerpYahooOrganicLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpYahooOrganicLiveAdvancedResponseInfo&gt;](./SerpYahooOrganicLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP provides real-time data on top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/advanced/?bash'

### **YahooOrganicLiveAdvancedAsync(IEnumerable&lt;SerpYahooOrganicLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYahooOrganicLiveAdvancedResponseInfo> YahooOrganicLiveAdvancedAsync(IEnumerable<SerpYahooOrganicLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpYahooOrganicLiveAdvancedRequestInfo&gt;](./SerpYahooOrganicLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicLiveAdvancedResponseInfo&gt;](./SerpYahooOrganicLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP provides real-time data on top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/advanced/?bash'

### **YahooOrganicLiveHtmlAsync(IEnumerable&lt;SerpYahooOrganicLiveHtmlRequestInfo&gt;)**

```csharp
public Task<SerpYahooOrganicLiveHtmlResponseInfo> YahooOrganicLiveHtmlAsync(IEnumerable<SerpYahooOrganicLiveHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYahooOrganicLiveHtmlRequestInfo&gt;](./SerpYahooOrganicLiveHtmlRequestInfo.md)<br>

#### Returns

[Task&lt;SerpYahooOrganicLiveHtmlResponseInfo&gt;](./SerpYahooOrganicLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/html/?bash'

### **YahooOrganicLiveHtmlAsync(IEnumerable&lt;SerpYahooOrganicLiveHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYahooOrganicLiveHtmlResponseInfo> YahooOrganicLiveHtmlAsync(IEnumerable<SerpYahooOrganicLiveHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpYahooOrganicLiveHtmlRequestInfo&gt;](./SerpYahooOrganicLiveHtmlRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicLiveHtmlResponseInfo&gt;](./SerpYahooOrganicLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpBaiduLocationsResponseInfo&gt;](./SerpBaiduLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'

### **SerpBaiduLocationsAsync(CancellationToken)**

```csharp
public Task<SerpBaiduLocationsResponseInfo> SerpBaiduLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduLocationsResponseInfo&gt;](./SerpBaiduLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'

### **SerpBaiduLocationsCountryAsync(String)**

```csharp
public Task<SerpBaiduLocationsCountryResponseInfo> SerpBaiduLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpBaiduLocationsCountryResponseInfo&gt;](./SerpBaiduLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'

### **SerpBaiduLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpBaiduLocationsCountryResponseInfo> SerpBaiduLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduLocationsCountryResponseInfo&gt;](./SerpBaiduLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'

### **SerpBaiduLanguagesAsync()**

```csharp
public Task<SerpBaiduLanguagesResponseInfo> SerpBaiduLanguagesAsync()
```

#### Returns

[Task&lt;SerpBaiduLanguagesResponseInfo&gt;](./SerpBaiduLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API. You can also download the full list of supported languages in the CSV format (last updated 2023-05-02).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/languages/?bash'

### **SerpBaiduLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpBaiduLanguagesResponseInfo> SerpBaiduLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduLanguagesResponseInfo&gt;](./SerpBaiduLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API. You can also download the full list of supported languages in the CSV format (last updated 2023-05-02).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/languages/?bash'

### **BaiduOrganicTaskPostAsync(IEnumerable&lt;SerpBaiduOrganicTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpBaiduOrganicTaskPostResponseInfo> BaiduOrganicTaskPostAsync(IEnumerable<SerpBaiduOrganicTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpBaiduOrganicTaskPostRequestInfo&gt;](./SerpBaiduOrganicTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpBaiduOrganicTaskPostResponseInfo&gt;](./SerpBaiduOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpBaiduOrganicTaskPostRequestInfo&gt;](./SerpBaiduOrganicTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTaskPostResponseInfo&gt;](./SerpBaiduOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpBaiduOrganicTasksReadyResponseInfo&gt;](./SerpBaiduOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/tasks_ready/?bash'

### **BaiduOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpBaiduOrganicTasksReadyResponseInfo> BaiduOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTasksReadyResponseInfo&gt;](./SerpBaiduOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/tasks_ready/?bash'

### **BaiduOrganicTasksFixedAsync()**

```csharp
public Task<SerpBaiduOrganicTasksFixedResponseInfo> BaiduOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpBaiduOrganicTasksFixedResponseInfo&gt;](./SerpBaiduOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTasksFixedResponseInfo&gt;](./SerpBaiduOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetRegularResponseInfo&gt;](./SerpBaiduOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/regular/?bash'

### **BaiduOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpBaiduOrganicTaskGetRegularResponseInfo> BaiduOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetRegularResponseInfo&gt;](./SerpBaiduOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/regular/?bash'

### **BaiduOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpBaiduOrganicTaskGetAdvancedResponseInfo> BaiduOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetAdvancedResponseInfo&gt;](./SerpBaiduOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/advanced/?bash'

### **BaiduOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpBaiduOrganicTaskGetAdvancedResponseInfo> BaiduOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetAdvancedResponseInfo&gt;](./SerpBaiduOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/advanced/?bash'

### **BaiduOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpBaiduOrganicTaskGetHtmlResponseInfo> BaiduOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetHtmlResponseInfo&gt;](./SerpBaiduOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/html/?bash'

### **BaiduOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpBaiduOrganicTaskGetHtmlResponseInfo> BaiduOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBaiduOrganicTaskGetHtmlResponseInfo&gt;](./SerpBaiduOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/html/?bash'

### **NaverOrganicTaskPostAsync(IEnumerable&lt;SerpNaverOrganicTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpNaverOrganicTaskPostResponseInfo> NaverOrganicTaskPostAsync(IEnumerable<SerpNaverOrganicTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpNaverOrganicTaskPostRequestInfo&gt;](./SerpNaverOrganicTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpNaverOrganicTaskPostResponseInfo&gt;](./SerpNaverOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Naver SERP API provides top 100 search engine results. Naver search results do not vary by location and language, and the search parameters for this search engine do not contain language and location variables. However, you can specify a keyword in any language, and the search engine results may vary depending on the language you used for specifying the search query.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_post/?bash'

### **NaverOrganicTaskPostAsync(IEnumerable&lt;SerpNaverOrganicTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpNaverOrganicTaskPostResponseInfo> NaverOrganicTaskPostAsync(IEnumerable<SerpNaverOrganicTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpNaverOrganicTaskPostRequestInfo&gt;](./SerpNaverOrganicTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTaskPostResponseInfo&gt;](./SerpNaverOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpNaverOrganicTasksReadyResponseInfo&gt;](./SerpNaverOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/tasks_ready/?bash'

### **NaverOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpNaverOrganicTasksReadyResponseInfo> NaverOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTasksReadyResponseInfo&gt;](./SerpNaverOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/tasks_ready/?bash'

### **NaverOrganicTasksFixedAsync()**

```csharp
public Task<SerpNaverOrganicTasksFixedResponseInfo> NaverOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpNaverOrganicTasksFixedResponseInfo&gt;](./SerpNaverOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTasksFixedResponseInfo&gt;](./SerpNaverOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpNaverOrganicTaskGetRegularResponseInfo&gt;](./SerpNaverOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/regular/?bash'

### **NaverOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpNaverOrganicTaskGetRegularResponseInfo> NaverOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTaskGetRegularResponseInfo&gt;](./SerpNaverOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/regular/?bash'

### **NaverOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpNaverOrganicTaskGetAdvancedResponseInfo> NaverOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpNaverOrganicTaskGetAdvancedResponseInfo&gt;](./SerpNaverOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/advanced/?bash'

### **NaverOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpNaverOrganicTaskGetAdvancedResponseInfo> NaverOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTaskGetAdvancedResponseInfo&gt;](./SerpNaverOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/advanced/?bash'

### **NaverOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpNaverOrganicTaskGetHtmlResponseInfo> NaverOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpNaverOrganicTaskGetHtmlResponseInfo&gt;](./SerpNaverOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/html/?bash'

### **NaverOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpNaverOrganicTaskGetHtmlResponseInfo> NaverOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpNaverOrganicTaskGetHtmlResponseInfo&gt;](./SerpNaverOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/html/?bash'

### **SerpSeznamLocationsAsync()**

```csharp
public Task<SerpSeznamLocationsResponseInfo> SerpSeznamLocationsAsync()
```

#### Returns

[Task&lt;SerpSeznamLocationsResponseInfo&gt;](./SerpSeznamLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'

### **SerpSeznamLocationsAsync(CancellationToken)**

```csharp
public Task<SerpSeznamLocationsResponseInfo> SerpSeznamLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamLocationsResponseInfo&gt;](./SerpSeznamLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'

### **SerpSeznamLocationsCountryAsync(String)**

```csharp
public Task<SerpSeznamLocationsCountryResponseInfo> SerpSeznamLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpSeznamLocationsCountryResponseInfo&gt;](./SerpSeznamLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'

### **SerpSeznamLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpSeznamLocationsCountryResponseInfo> SerpSeznamLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamLocationsCountryResponseInfo&gt;](./SerpSeznamLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'

### **SerpSeznamLanguagesAsync()**

```csharp
public Task<SerpSeznamLanguagesResponseInfo> SerpSeznamLanguagesAsync()
```

#### Returns

[Task&lt;SerpSeznamLanguagesResponseInfo&gt;](./SerpSeznamLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/languages/?bash'

### **SerpSeznamLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpSeznamLanguagesResponseInfo> SerpSeznamLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamLanguagesResponseInfo&gt;](./SerpSeznamLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/languages/?bash'

### **SeznamOrganicTaskPostAsync(IEnumerable&lt;SerpSeznamOrganicTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpSeznamOrganicTaskPostResponseInfo> SeznamOrganicTaskPostAsync(IEnumerable<SerpSeznamOrganicTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpSeznamOrganicTaskPostRequestInfo&gt;](./SerpSeznamOrganicTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpSeznamOrganicTaskPostResponseInfo&gt;](./SerpSeznamOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Seznam SERP API provides top 10 search engine results from one of the most popular search engines in the Czech Republic. Seznam is focused on the local search market, and thus supports the Czech language only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_post/?bash'

### **SeznamOrganicTaskPostAsync(IEnumerable&lt;SerpSeznamOrganicTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpSeznamOrganicTaskPostResponseInfo> SeznamOrganicTaskPostAsync(IEnumerable<SerpSeznamOrganicTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpSeznamOrganicTaskPostRequestInfo&gt;](./SerpSeznamOrganicTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTaskPostResponseInfo&gt;](./SerpSeznamOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpSeznamOrganicTasksReadyResponseInfo&gt;](./SerpSeznamOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/tasks_ready/?bash'

### **SeznamOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpSeznamOrganicTasksReadyResponseInfo> SeznamOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTasksReadyResponseInfo&gt;](./SerpSeznamOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/tasks_ready/?bash'

### **SeznamOrganicTasksFixedAsync()**

```csharp
public Task<SerpSeznamOrganicTasksFixedResponseInfo> SeznamOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpSeznamOrganicTasksFixedResponseInfo&gt;](./SerpSeznamOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTasksFixedResponseInfo&gt;](./SerpSeznamOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetRegularResponseInfo&gt;](./SerpSeznamOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/regular/?bash'

### **SeznamOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpSeznamOrganicTaskGetRegularResponseInfo> SeznamOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetRegularResponseInfo&gt;](./SerpSeznamOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/regular/?bash'

### **SeznamOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpSeznamOrganicTaskGetAdvancedResponseInfo> SeznamOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetAdvancedResponseInfo&gt;](./SerpSeznamOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/advanced/?bash'

### **SeznamOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpSeznamOrganicTaskGetAdvancedResponseInfo> SeznamOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetAdvancedResponseInfo&gt;](./SerpSeznamOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/advanced/?bash'

### **SeznamOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpSeznamOrganicTaskGetHtmlResponseInfo> SeznamOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetHtmlResponseInfo&gt;](./SerpSeznamOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/html/?bash'

### **SeznamOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpSeznamOrganicTaskGetHtmlResponseInfo> SeznamOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpSeznamOrganicTaskGetHtmlResponseInfo&gt;](./SerpSeznamOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/html/?bash'

### **GoogleFinanceExploreTaskPostAsync(IEnumerable&lt;SerpGoogleFinanceExploreTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleFinanceExploreTaskPostResponseInfo> GoogleFinanceExploreTaskPostAsync(IEnumerable<SerpGoogleFinanceExploreTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceExploreTaskPostRequestInfo&gt;](./SerpGoogleFinanceExploreTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleFinanceExploreTaskPostResponseInfo&gt;](./SerpGoogleFinanceExploreTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Explore API provides real-time data from the ‘Explore’ tab of Google Finance. These results are specific to the parameters you specify in the request: location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/task_post/?bash'

### **GoogleFinanceExploreTaskPostAsync(IEnumerable&lt;SerpGoogleFinanceExploreTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceExploreTaskPostResponseInfo> GoogleFinanceExploreTaskPostAsync(IEnumerable<SerpGoogleFinanceExploreTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceExploreTaskPostRequestInfo&gt;](./SerpGoogleFinanceExploreTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceExploreTaskPostResponseInfo&gt;](./SerpGoogleFinanceExploreTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Explore API provides real-time data from the ‘Explore’ tab of Google Finance. These results are specific to the parameters you specify in the request: location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/task_post/?bash'

### **GoogleFinanceExploreTasksReadyAsync()**

```csharp
public Task<SerpGoogleFinanceExploreTasksReadyResponseInfo> GoogleFinanceExploreTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleFinanceExploreTasksReadyResponseInfo&gt;](./SerpGoogleFinanceExploreTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/tasks_ready/?bash'

### **GoogleFinanceExploreTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleFinanceExploreTasksReadyResponseInfo> GoogleFinanceExploreTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceExploreTasksReadyResponseInfo&gt;](./SerpGoogleFinanceExploreTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/tasks_ready/?bash'

### **GoogleFinanceExploreTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleFinanceExploreTaskGetAdvancedResponseInfo> GoogleFinanceExploreTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleFinanceExploreTaskGetAdvancedResponseInfo&gt;](./SerpGoogleFinanceExploreTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Explore provides real-time data from the ‘Explore’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/task_get/advanced/?bash'

### **GoogleFinanceExploreTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceExploreTaskGetAdvancedResponseInfo> GoogleFinanceExploreTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceExploreTaskGetAdvancedResponseInfo&gt;](./SerpGoogleFinanceExploreTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Explore provides real-time data from the ‘Explore’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/task_get/advanced/?bash'

### **GoogleFinanceExploreTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleFinanceExploreTaskGetHtmlResponseInfo> GoogleFinanceExploreTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleFinanceExploreTaskGetHtmlResponseInfo&gt;](./SerpGoogleFinanceExploreTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/task_get/html/?bash'

### **GoogleFinanceExploreTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceExploreTaskGetHtmlResponseInfo> GoogleFinanceExploreTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceExploreTaskGetHtmlResponseInfo&gt;](./SerpGoogleFinanceExploreTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/task_get/html/?bash'

### **GoogleFinanceExploreLiveAdvancedAsync(IEnumerable&lt;SerpGoogleFinanceExploreLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleFinanceExploreLiveAdvancedResponseInfo> GoogleFinanceExploreLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceExploreLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceExploreLiveAdvancedRequestInfo&gt;](./SerpGoogleFinanceExploreLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleFinanceExploreLiveAdvancedResponseInfo&gt;](./SerpGoogleFinanceExploreLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Explore provides real-time data from the ‘Explore’ tab of Google Finance. These results are specific to the parameters you specify in the request: location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/live/advanced/?bash'

### **GoogleFinanceExploreLiveAdvancedAsync(IEnumerable&lt;SerpGoogleFinanceExploreLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceExploreLiveAdvancedResponseInfo> GoogleFinanceExploreLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceExploreLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceExploreLiveAdvancedRequestInfo&gt;](./SerpGoogleFinanceExploreLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceExploreLiveAdvancedResponseInfo&gt;](./SerpGoogleFinanceExploreLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Explore provides real-time data from the ‘Explore’ tab of Google Finance. These results are specific to the parameters you specify in the request: location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/live/advanced/?bash'

### **GoogleFinanceExploreLiveHtmlAsync(IEnumerable&lt;SerpGoogleFinanceExploreLiveHtmlRequestInfo&gt;)**

```csharp
public Task<SerpGoogleFinanceExploreLiveHtmlResponseInfo> GoogleFinanceExploreLiveHtmlAsync(IEnumerable<SerpGoogleFinanceExploreLiveHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceExploreLiveHtmlRequestInfo&gt;](./SerpGoogleFinanceExploreLiveHtmlRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleFinanceExploreLiveHtmlResponseInfo&gt;](./SerpGoogleFinanceExploreLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides raw HTML page from the ‘Explore’ tab of Google Finance. These results are specific to the parameters you specify in the request: location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/live/html/?bash'

### **GoogleFinanceExploreLiveHtmlAsync(IEnumerable&lt;SerpGoogleFinanceExploreLiveHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceExploreLiveHtmlResponseInfo> GoogleFinanceExploreLiveHtmlAsync(IEnumerable<SerpGoogleFinanceExploreLiveHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceExploreLiveHtmlRequestInfo&gt;](./SerpGoogleFinanceExploreLiveHtmlRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceExploreLiveHtmlResponseInfo&gt;](./SerpGoogleFinanceExploreLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides raw HTML page from the ‘Explore’ tab of Google Finance. These results are specific to the parameters you specify in the request: location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_explore/live/html/?bash'

### **GoogleFinanceMarketsTaskPostAsync(IEnumerable&lt;SerpGoogleFinanceMarketsTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleFinanceMarketsTaskPostResponseInfo> GoogleFinanceMarketsTaskPostAsync(IEnumerable<SerpGoogleFinanceMarketsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceMarketsTaskPostRequestInfo&gt;](./SerpGoogleFinanceMarketsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleFinanceMarketsTaskPostResponseInfo&gt;](./SerpGoogleFinanceMarketsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Markets API provides real-time data from the ‘Markets’ tab of Google Finance. These results are specific to the parameters you specify in the request: location, language, and market_type.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/task_post/?bash'

### **GoogleFinanceMarketsTaskPostAsync(IEnumerable&lt;SerpGoogleFinanceMarketsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceMarketsTaskPostResponseInfo> GoogleFinanceMarketsTaskPostAsync(IEnumerable<SerpGoogleFinanceMarketsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceMarketsTaskPostRequestInfo&gt;](./SerpGoogleFinanceMarketsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceMarketsTaskPostResponseInfo&gt;](./SerpGoogleFinanceMarketsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Markets API provides real-time data from the ‘Markets’ tab of Google Finance. These results are specific to the parameters you specify in the request: location, language, and market_type.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/task_post/?bash'

### **GoogleFinanceMarketsTasksReadyAsync()**

```csharp
public Task<SerpGoogleFinanceMarketsTasksReadyResponseInfo> GoogleFinanceMarketsTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleFinanceMarketsTasksReadyResponseInfo&gt;](./SerpGoogleFinanceMarketsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/tasks_ready/?bash'

### **GoogleFinanceMarketsTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleFinanceMarketsTasksReadyResponseInfo> GoogleFinanceMarketsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceMarketsTasksReadyResponseInfo&gt;](./SerpGoogleFinanceMarketsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/tasks_ready/?bash'

### **GoogleFinanceMarketsTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleFinanceMarketsTaskGetAdvancedResponseInfo> GoogleFinanceMarketsTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleFinanceMarketsTaskGetAdvancedResponseInfo&gt;](./SerpGoogleFinanceMarketsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Markets API provides real-time data from the ‘Markets’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/task_get/advanced/?bash'

### **GoogleFinanceMarketsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceMarketsTaskGetAdvancedResponseInfo> GoogleFinanceMarketsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceMarketsTaskGetAdvancedResponseInfo&gt;](./SerpGoogleFinanceMarketsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Markets API provides real-time data from the ‘Markets’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/task_get/advanced/?bash'

### **GoogleFinanceMarketsTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleFinanceMarketsTaskGetHtmlResponseInfo> GoogleFinanceMarketsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleFinanceMarketsTaskGetHtmlResponseInfo&gt;](./SerpGoogleFinanceMarketsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/task_get/html/?bash'

### **GoogleFinanceMarketsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceMarketsTaskGetHtmlResponseInfo> GoogleFinanceMarketsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceMarketsTaskGetHtmlResponseInfo&gt;](./SerpGoogleFinanceMarketsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/task_get/html/?bash'

### **GoogleFinanceMarketsLiveAdvancedAsync(IEnumerable&lt;SerpGoogleFinanceMarketsLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleFinanceMarketsLiveAdvancedResponseInfo> GoogleFinanceMarketsLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceMarketsLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceMarketsLiveAdvancedRequestInfo&gt;](./SerpGoogleFinanceMarketsLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleFinanceMarketsLiveAdvancedResponseInfo&gt;](./SerpGoogleFinanceMarketsLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Markets provides real-time data from the ‘Markets’ tab of Google Finance. These results are specific to the parameters you specify in the request: location, language, and market_type.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/live/advanced/?bash'

### **GoogleFinanceMarketsLiveAdvancedAsync(IEnumerable&lt;SerpGoogleFinanceMarketsLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceMarketsLiveAdvancedResponseInfo> GoogleFinanceMarketsLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceMarketsLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceMarketsLiveAdvancedRequestInfo&gt;](./SerpGoogleFinanceMarketsLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceMarketsLiveAdvancedResponseInfo&gt;](./SerpGoogleFinanceMarketsLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Markets provides real-time data from the ‘Markets’ tab of Google Finance. These results are specific to the parameters you specify in the request: location, language, and market_type.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/live/advanced/?bash'

### **GoogleFinanceMarketsLiveHtmlAsync(IEnumerable&lt;SerpGoogleFinanceMarketsLiveHtmlRequestInfo&gt;)**

```csharp
public Task<SerpGoogleFinanceMarketsLiveHtmlResponseInfo> GoogleFinanceMarketsLiveHtmlAsync(IEnumerable<SerpGoogleFinanceMarketsLiveHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceMarketsLiveHtmlRequestInfo&gt;](./SerpGoogleFinanceMarketsLiveHtmlRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleFinanceMarketsLiveHtmlResponseInfo&gt;](./SerpGoogleFinanceMarketsLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides raw HTML from the ‘Markets’ tab of Google Finance. These results are specific to the parameters you specify in the request: location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/live/html/?bash'

### **GoogleFinanceMarketsLiveHtmlAsync(IEnumerable&lt;SerpGoogleFinanceMarketsLiveHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceMarketsLiveHtmlResponseInfo> GoogleFinanceMarketsLiveHtmlAsync(IEnumerable<SerpGoogleFinanceMarketsLiveHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceMarketsLiveHtmlRequestInfo&gt;](./SerpGoogleFinanceMarketsLiveHtmlRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceMarketsLiveHtmlResponseInfo&gt;](./SerpGoogleFinanceMarketsLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides raw HTML from the ‘Markets’ tab of Google Finance. These results are specific to the parameters you specify in the request: location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_markets/live/html/?bash'

### **GoogleFinanceQuoteTaskPostAsync(IEnumerable&lt;SerpGoogleFinanceQuoteTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleFinanceQuoteTaskPostResponseInfo> GoogleFinanceQuoteTaskPostAsync(IEnumerable<SerpGoogleFinanceQuoteTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceQuoteTaskPostRequestInfo&gt;](./SerpGoogleFinanceQuoteTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleFinanceQuoteTaskPostResponseInfo&gt;](./SerpGoogleFinanceQuoteTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Quote provides real-time data from the ‘Quote’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/task_post/?bash'

### **GoogleFinanceQuoteTaskPostAsync(IEnumerable&lt;SerpGoogleFinanceQuoteTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceQuoteTaskPostResponseInfo> GoogleFinanceQuoteTaskPostAsync(IEnumerable<SerpGoogleFinanceQuoteTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceQuoteTaskPostRequestInfo&gt;](./SerpGoogleFinanceQuoteTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceQuoteTaskPostResponseInfo&gt;](./SerpGoogleFinanceQuoteTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Quote provides real-time data from the ‘Quote’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/task_post/?bash'

### **GoogleFinanceQuoteTasksReadyAsync()**

```csharp
public Task<SerpGoogleFinanceQuoteTasksReadyResponseInfo> GoogleFinanceQuoteTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleFinanceQuoteTasksReadyResponseInfo&gt;](./SerpGoogleFinanceQuoteTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/tasks_ready/?bash'

### **GoogleFinanceQuoteTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleFinanceQuoteTasksReadyResponseInfo> GoogleFinanceQuoteTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceQuoteTasksReadyResponseInfo&gt;](./SerpGoogleFinanceQuoteTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/tasks_ready/?bash'

### **GoogleFinanceQuoteTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleFinanceQuoteTaskGetAdvancedResponseInfo> GoogleFinanceQuoteTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>

#### Returns

[Task&lt;SerpGoogleFinanceQuoteTaskGetAdvancedResponseInfo&gt;](./SerpGoogleFinanceQuoteTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Quote provides real-time data from the ‘Quote’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/task_get/advanced/?bash'

### **GoogleFinanceQuoteTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceQuoteTaskGetAdvancedResponseInfo> GoogleFinanceQuoteTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceQuoteTaskGetAdvancedResponseInfo&gt;](./SerpGoogleFinanceQuoteTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Quote provides real-time data from the ‘Quote’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/task_get/advanced/?bash'

### **GoogleFinanceQuoteTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleFinanceQuoteTaskGetHtmlResponseInfo> GoogleFinanceQuoteTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleFinanceQuoteTaskGetHtmlResponseInfo&gt;](./SerpGoogleFinanceQuoteTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/task_get/html/?bash'

### **GoogleFinanceQuoteTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceQuoteTaskGetHtmlResponseInfo> GoogleFinanceQuoteTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceQuoteTaskGetHtmlResponseInfo&gt;](./SerpGoogleFinanceQuoteTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/task_get/html/?bash'

### **GoogleFinanceQuoteLiveAdvancedAsync(IEnumerable&lt;SerpGoogleFinanceQuoteLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleFinanceQuoteLiveAdvancedResponseInfo> GoogleFinanceQuoteLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceQuoteLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceQuoteLiveAdvancedRequestInfo&gt;](./SerpGoogleFinanceQuoteLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleFinanceQuoteLiveAdvancedResponseInfo&gt;](./SerpGoogleFinanceQuoteLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Quote provides real-time data from the ‘Quote’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/live/advanced/?bash'

### **GoogleFinanceQuoteLiveAdvancedAsync(IEnumerable&lt;SerpGoogleFinanceQuoteLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceQuoteLiveAdvancedResponseInfo> GoogleFinanceQuoteLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceQuoteLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceQuoteLiveAdvancedRequestInfo&gt;](./SerpGoogleFinanceQuoteLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceQuoteLiveAdvancedResponseInfo&gt;](./SerpGoogleFinanceQuoteLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Quote provides real-time data from the ‘Quote’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/live/advanced/?bash'

### **GoogleFinanceQuoteLiveHtmlAsync(IEnumerable&lt;SerpGoogleFinanceQuoteLiveHtmlRequestInfo&gt;)**

```csharp
public Task<SerpGoogleFinanceQuoteLiveHtmlResponseInfo> GoogleFinanceQuoteLiveHtmlAsync(IEnumerable<SerpGoogleFinanceQuoteLiveHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceQuoteLiveHtmlRequestInfo&gt;](./SerpGoogleFinanceQuoteLiveHtmlRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleFinanceQuoteLiveHtmlResponseInfo&gt;](./SerpGoogleFinanceQuoteLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides raw HTML from the ‘Quote’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/live/html/?bash'

### **GoogleFinanceQuoteLiveHtmlAsync(IEnumerable&lt;SerpGoogleFinanceQuoteLiveHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceQuoteLiveHtmlResponseInfo> GoogleFinanceQuoteLiveHtmlAsync(IEnumerable<SerpGoogleFinanceQuoteLiveHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceQuoteLiveHtmlRequestInfo&gt;](./SerpGoogleFinanceQuoteLiveHtmlRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceQuoteLiveHtmlResponseInfo&gt;](./SerpGoogleFinanceQuoteLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides raw HTML from the ‘Quote’ tab of Google Finance. These results are specific to the parameters you specify in the request: ticker in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_quote/live/html/?bash'

### **GoogleFinanceTickerSearchTaskPostAsync(IEnumerable&lt;SerpGoogleFinanceTickerSearchTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleFinanceTickerSearchTaskPostResponseInfo> GoogleFinanceTickerSearchTaskPostAsync(IEnumerable<SerpGoogleFinanceTickerSearchTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceTickerSearchTaskPostRequestInfo&gt;](./SerpGoogleFinanceTickerSearchTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleFinanceTickerSearchTaskPostResponseInfo&gt;](./SerpGoogleFinanceTickerSearchTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Ticker Search allows you to search for financial instruments available on Google Finance along with additional information. The result is specific to the parameters you specify in the request: keyword (name of a company or financial instrument) in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_ticker_search/task_post/?bash'

### **GoogleFinanceTickerSearchTaskPostAsync(IEnumerable&lt;SerpGoogleFinanceTickerSearchTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceTickerSearchTaskPostResponseInfo> GoogleFinanceTickerSearchTaskPostAsync(IEnumerable<SerpGoogleFinanceTickerSearchTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceTickerSearchTaskPostRequestInfo&gt;](./SerpGoogleFinanceTickerSearchTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceTickerSearchTaskPostResponseInfo&gt;](./SerpGoogleFinanceTickerSearchTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Ticker Search allows you to search for financial instruments available on Google Finance along with additional information. The result is specific to the parameters you specify in the request: keyword (name of a company or financial instrument) in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_ticker_search/task_post/?bash'

### **GoogleFinanceTickerSearchTasksReadyAsync()**

```csharp
public Task<SerpGoogleFinanceTickerSearchTasksReadyResponseInfo> GoogleFinanceTickerSearchTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleFinanceTickerSearchTasksReadyResponseInfo&gt;](./SerpGoogleFinanceTickerSearchTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_ticker_search/tasks_ready/?bash'

### **GoogleFinanceTickerSearchTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleFinanceTickerSearchTasksReadyResponseInfo> GoogleFinanceTickerSearchTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceTickerSearchTasksReadyResponseInfo&gt;](./SerpGoogleFinanceTickerSearchTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_ticker_search/tasks_ready/?bash'

### **GoogleFinanceTickerSearchTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleFinanceTickerSearchTaskGetAdvancedResponseInfo> GoogleFinanceTickerSearchTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleFinanceTickerSearchTaskGetAdvancedResponseInfo&gt;](./SerpGoogleFinanceTickerSearchTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Ticker Search allows you to search for financial instruments available on Google Finance along with additional information. The result is specific to the parameters you specify in the request: keyword (name of a company or financial instrument) in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_ticker_search/task_get/advanced/?bash'

### **GoogleFinanceTickerSearchTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceTickerSearchTaskGetAdvancedResponseInfo> GoogleFinanceTickerSearchTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceTickerSearchTaskGetAdvancedResponseInfo&gt;](./SerpGoogleFinanceTickerSearchTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Google Finance Ticker Search allows you to search for financial instruments available on Google Finance along with additional information. The result is specific to the parameters you specify in the request: keyword (name of a company or financial instrument) in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_ticker_search/task_get/advanced/?bash'

### **GoogleFinanceTickerSearchLiveAdvancedAsync(IEnumerable&lt;SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleFinanceTickerSearchLiveAdvancedResponseInfo> GoogleFinanceTickerSearchLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo&gt;](./SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleFinanceTickerSearchLiveAdvancedResponseInfo&gt;](./SerpGoogleFinanceTickerSearchLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Ticker Search allows you to search for financial instruments available on Google Finance along with additional information. The result is specific to the parameters you specify in the request: keyword (name of a company or financial instrument) in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_ticker_search/live/advanced/?bash'

### **GoogleFinanceTickerSearchLiveAdvancedAsync(IEnumerable&lt;SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleFinanceTickerSearchLiveAdvancedResponseInfo> GoogleFinanceTickerSearchLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo&gt;](./SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleFinanceTickerSearchLiveAdvancedResponseInfo&gt;](./SerpGoogleFinanceTickerSearchLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Finance Ticker Search allows you to search for financial instruments available on Google Finance along with additional information. The result is specific to the parameters you specify in the request: keyword (name of a company or financial instrument) in the keyword field, location and language.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/finance_ticker_search/live/advanced/?bash'

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

### **GoogleAutocompleteTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleAutocompleteTaskGetAdvancedResponseInfo> GoogleAutocompleteTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleAutocompleteTaskGetAdvancedResponseInfo&gt;](./SerpGoogleAutocompleteTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/task_get/advanced/?bash'

### **GoogleAutocompleteTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleAutocompleteTaskGetAdvancedResponseInfo> GoogleAutocompleteTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAutocompleteTaskGetAdvancedResponseInfo&gt;](./SerpGoogleAutocompleteTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/task_get/advanced/?bash'

### **GoogleAutocompleteLiveAdvancedAsync(IEnumerable&lt;SerpGoogleAutocompleteLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleAutocompleteLiveAdvancedResponseInfo> GoogleAutocompleteLiveAdvancedAsync(IEnumerable<SerpGoogleAutocompleteLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleAutocompleteLiveAdvancedRequestInfo&gt;](./SerpGoogleAutocompleteLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleAutocompleteLiveAdvancedResponseInfo&gt;](./SerpGoogleAutocompleteLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Autocomplete is a feature within Google Search that improves the search experience by allowing users to complete searches they started to type. DataForSEO SERP API will provide you with all the suggestions Google Autocomplete offers for a particular keyword, the position of the cursor pointer, and the search client.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/live/advanced/?bash'

### **GoogleAutocompleteLiveAdvancedAsync(IEnumerable&lt;SerpGoogleAutocompleteLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleAutocompleteLiveAdvancedResponseInfo> GoogleAutocompleteLiveAdvancedAsync(IEnumerable<SerpGoogleAutocompleteLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleAutocompleteLiveAdvancedRequestInfo&gt;](./SerpGoogleAutocompleteLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAutocompleteLiveAdvancedResponseInfo&gt;](./SerpGoogleAutocompleteLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Autocomplete is a feature within Google Search that improves the search experience by allowing users to complete searches they started to type. DataForSEO SERP API will provide you with all the suggestions Google Autocomplete offers for a particular keyword, the position of the cursor pointer, and the search client.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/live/advanced/?bash'

### **GoogleDatasetSearchTaskPostAsync(IEnumerable&lt;SerpGoogleDatasetSearchTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleDatasetSearchTaskPostResponseInfo> GoogleDatasetSearchTaskPostAsync(IEnumerable<SerpGoogleDatasetSearchTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleDatasetSearchTaskPostRequestInfo&gt;](./SerpGoogleDatasetSearchTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleDatasetSearchTaskPostResponseInfo&gt;](./SerpGoogleDatasetSearchTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleDatasetSearchTaskPostRequestInfo&gt;](./SerpGoogleDatasetSearchTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetSearchTaskPostResponseInfo&gt;](./SerpGoogleDatasetSearchTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpGoogleDatasetSearchTasksReadyResponseInfo&gt;](./SerpGoogleDatasetSearchTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/tasks_ready/?bash'

### **GoogleDatasetSearchTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleDatasetSearchTasksReadyResponseInfo> GoogleDatasetSearchTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetSearchTasksReadyResponseInfo&gt;](./SerpGoogleDatasetSearchTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/tasks_ready/?bash'

### **GoogleDatasetSearchTasksFixedAsync()**

```csharp
public Task<SerpGoogleDatasetSearchTasksFixedResponseInfo> GoogleDatasetSearchTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleDatasetSearchTasksFixedResponseInfo&gt;](./SerpGoogleDatasetSearchTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetSearchTasksFixedResponseInfo&gt;](./SerpGoogleDatasetSearchTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo&gt;](./SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/task_get/advanced/?bash'

### **GoogleDatasetSearchTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo> GoogleDatasetSearchTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo&gt;](./SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/task_get/advanced/?bash'

### **GoogleDatasetSearchLiveAdvancedAsync(IEnumerable&lt;SerpGoogleDatasetSearchLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleDatasetSearchLiveAdvancedResponseInfo> GoogleDatasetSearchLiveAdvancedAsync(IEnumerable<SerpGoogleDatasetSearchLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleDatasetSearchLiveAdvancedRequestInfo&gt;](./SerpGoogleDatasetSearchLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleDatasetSearchLiveAdvancedResponseInfo&gt;](./SerpGoogleDatasetSearchLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleDatasetSearchLiveAdvancedRequestInfo&gt;](./SerpGoogleDatasetSearchLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetSearchLiveAdvancedResponseInfo&gt;](./SerpGoogleDatasetSearchLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleDatasetInfoTaskPostRequestInfo&gt;](./SerpGoogleDatasetInfoTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleDatasetInfoTaskPostResponseInfo&gt;](./SerpGoogleDatasetInfoTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleDatasetInfoTaskPostRequestInfo&gt;](./SerpGoogleDatasetInfoTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetInfoTaskPostResponseInfo&gt;](./SerpGoogleDatasetInfoTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpGoogleDatasetInfoTasksReadyResponseInfo&gt;](./SerpGoogleDatasetInfoTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/tasks_ready/?bash'

### **GoogleDatasetInfoTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleDatasetInfoTasksReadyResponseInfo> GoogleDatasetInfoTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetInfoTasksReadyResponseInfo&gt;](./SerpGoogleDatasetInfoTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/tasks_ready/?bash'

### **GoogleDatasetInfoTasksFixedAsync()**

```csharp
public Task<SerpGoogleDatasetInfoTasksFixedResponseInfo> GoogleDatasetInfoTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleDatasetInfoTasksFixedResponseInfo&gt;](./SerpGoogleDatasetInfoTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetInfoTasksFixedResponseInfo&gt;](./SerpGoogleDatasetInfoTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo&gt;](./SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/task_get/advanced/?bash'

### **GoogleDatasetInfoTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo> GoogleDatasetInfoTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo&gt;](./SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/task_get/advanced/?bash'

### **GoogleDatasetInfoLiveAdvancedAsync(IEnumerable&lt;SerpGoogleDatasetInfoLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleDatasetInfoLiveAdvancedResponseInfo> GoogleDatasetInfoLiveAdvancedAsync(IEnumerable<SerpGoogleDatasetInfoLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleDatasetInfoLiveAdvancedRequestInfo&gt;](./SerpGoogleDatasetInfoLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleDatasetInfoLiveAdvancedResponseInfo&gt;](./SerpGoogleDatasetInfoLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleDatasetInfoLiveAdvancedRequestInfo&gt;](./SerpGoogleDatasetInfoLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleDatasetInfoLiveAdvancedResponseInfo&gt;](./SerpGoogleDatasetInfoLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Dataset Info provides real-time data on the dataset you specify in the request. You will get data from a page of the dataset displayed separately from the SERP. It contains information about dataset content, authors, licenses, and description on the SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/live/advanced/?bash'

### **SerpGoogleAdsAdvertisersLocationsAsync()**

```csharp
public Task<SerpGoogleAdsAdvertisersLocationsResponseInfo> SerpGoogleAdsAdvertisersLocationsAsync()
```

#### Returns

[Task&lt;SerpGoogleAdsAdvertisersLocationsResponseInfo&gt;](./SerpGoogleAdsAdvertisersLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_advertisers/locations/?bash'

### **SerpGoogleAdsAdvertisersLocationsAsync(CancellationToken)**

```csharp
public Task<SerpGoogleAdsAdvertisersLocationsResponseInfo> SerpGoogleAdsAdvertisersLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAdsAdvertisersLocationsResponseInfo&gt;](./SerpGoogleAdsAdvertisersLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_advertisers/locations/?bash'

### **GoogleAdsAdvertisersTaskPostAsync(IEnumerable&lt;SerpGoogleAdsAdvertisersTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleAdsAdvertisersTaskPostResponseInfo> GoogleAdsAdvertisersTaskPostAsync(IEnumerable<SerpGoogleAdsAdvertisersTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleAdsAdvertisersTaskPostRequestInfo&gt;](./SerpGoogleAdsAdvertisersTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleAdsAdvertisersTaskPostResponseInfo&gt;](./SerpGoogleAdsAdvertisersTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Google Ads Advertisers provides information on advertisers that run campaigns on Google Ads based on the Ads Transparency platform. ‌‌
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_advertisers/task_post/?bash'

### **GoogleAdsAdvertisersTaskPostAsync(IEnumerable&lt;SerpGoogleAdsAdvertisersTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleAdsAdvertisersTaskPostResponseInfo> GoogleAdsAdvertisersTaskPostAsync(IEnumerable<SerpGoogleAdsAdvertisersTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleAdsAdvertisersTaskPostRequestInfo&gt;](./SerpGoogleAdsAdvertisersTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAdsAdvertisersTaskPostResponseInfo&gt;](./SerpGoogleAdsAdvertisersTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Google Ads Advertisers provides information on advertisers that run campaigns on Google Ads based on the Ads Transparency platform. ‌‌
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_advertisers/task_post/?bash'

### **GoogleAdsAdvertisersTasksReadyAsync()**

```csharp
public Task<SerpGoogleAdsAdvertisersTasksReadyResponseInfo> GoogleAdsAdvertisersTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleAdsAdvertisersTasksReadyResponseInfo&gt;](./SerpGoogleAdsAdvertisersTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_advertisers/tasks_ready/?bash'

### **GoogleAdsAdvertisersTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleAdsAdvertisersTasksReadyResponseInfo> GoogleAdsAdvertisersTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAdsAdvertisersTasksReadyResponseInfo&gt;](./SerpGoogleAdsAdvertisersTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_advertisers/tasks_ready/?bash'

### **GoogleAdsAdvertisersTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleAdsAdvertisersTaskGetAdvancedResponseInfo> GoogleAdsAdvertisersTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleAdsAdvertisersTaskGetAdvancedResponseInfo&gt;](./SerpGoogleAdsAdvertisersTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_advertisers/task_get/advanced/?bash'

### **GoogleAdsAdvertisersTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleAdsAdvertisersTaskGetAdvancedResponseInfo> GoogleAdsAdvertisersTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAdsAdvertisersTaskGetAdvancedResponseInfo&gt;](./SerpGoogleAdsAdvertisersTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_advertisers/task_get/advanced/?bash'

### **SerpGoogleAdsSearchLocationsAsync()**

```csharp
public Task<SerpGoogleAdsSearchLocationsResponseInfo> SerpGoogleAdsSearchLocationsAsync()
```

#### Returns

[Task&lt;SerpGoogleAdsSearchLocationsResponseInfo&gt;](./SerpGoogleAdsSearchLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_search/locations/?bash'

### **SerpGoogleAdsSearchLocationsAsync(CancellationToken)**

```csharp
public Task<SerpGoogleAdsSearchLocationsResponseInfo> SerpGoogleAdsSearchLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAdsSearchLocationsResponseInfo&gt;](./SerpGoogleAdsSearchLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_search/locations/?bash'

### **GoogleAdsSearchTaskPostAsync(IEnumerable&lt;SerpGoogleAdsSearchTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleAdsSearchTaskPostResponseInfo> GoogleAdsSearchTaskPostAsync(IEnumerable<SerpGoogleAdsSearchTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleAdsSearchTaskPostRequestInfo&gt;](./SerpGoogleAdsSearchTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleAdsSearchTaskPostResponseInfo&gt;](./SerpGoogleAdsSearchTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Google Ads Search provides information on ads that are run by advertisers on Google Ads. Information is based on the Ads Transparency platform and adapted for the convenience of DataForSEO users. ‌‌
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_search/task_post/?bash'

### **GoogleAdsSearchTaskPostAsync(IEnumerable&lt;SerpGoogleAdsSearchTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleAdsSearchTaskPostResponseInfo> GoogleAdsSearchTaskPostAsync(IEnumerable<SerpGoogleAdsSearchTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleAdsSearchTaskPostRequestInfo&gt;](./SerpGoogleAdsSearchTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAdsSearchTaskPostResponseInfo&gt;](./SerpGoogleAdsSearchTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Google Ads Search provides information on ads that are run by advertisers on Google Ads. Information is based on the Ads Transparency platform and adapted for the convenience of DataForSEO users. ‌‌
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_search/task_post/?bash'

### **GoogleAdsSearchTasksReadyAsync()**

```csharp
public Task<SerpGoogleAdsSearchTasksReadyResponseInfo> GoogleAdsSearchTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleAdsSearchTasksReadyResponseInfo&gt;](./SerpGoogleAdsSearchTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_search/tasks_ready/?bash'

### **GoogleAdsSearchTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleAdsSearchTasksReadyResponseInfo> GoogleAdsSearchTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAdsSearchTasksReadyResponseInfo&gt;](./SerpGoogleAdsSearchTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_search/tasks_ready/?bash'

### **GoogleAdsSearchTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleAdsSearchTaskGetAdvancedResponseInfo> GoogleAdsSearchTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleAdsSearchTaskGetAdvancedResponseInfo&gt;](./SerpGoogleAdsSearchTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_search/task_get/advanced/?bash'

### **GoogleAdsSearchTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleAdsSearchTaskGetAdvancedResponseInfo> GoogleAdsSearchTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAdsSearchTaskGetAdvancedResponseInfo&gt;](./SerpGoogleAdsSearchTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/serp/google/ads_search/task_get/advanced/?bash'

### **SerpBingLocationsAsync()**

```csharp
public Task<SerpBingLocationsResponseInfo> SerpBingLocationsAsync()
```

#### Returns

[Task&lt;SerpBingLocationsResponseInfo&gt;](./SerpBingLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'

### **SerpBingLocationsAsync(CancellationToken)**

```csharp
public Task<SerpBingLocationsResponseInfo> SerpBingLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocationsResponseInfo&gt;](./SerpBingLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'

### **SerpBingLocationsCountryAsync(String)**

```csharp
public Task<SerpBingLocationsCountryResponseInfo> SerpBingLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpBingLocationsCountryResponseInfo&gt;](./SerpBingLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'

### **SerpBingLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpBingLocationsCountryResponseInfo> SerpBingLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocationsCountryResponseInfo&gt;](./SerpBingLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'

### **SerpBingLanguagesAsync()**

```csharp
public Task<SerpBingLanguagesResponseInfo> SerpBingLanguagesAsync()
```

#### Returns

[Task&lt;SerpBingLanguagesResponseInfo&gt;](./SerpBingLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/languages/?bash'

### **SerpBingLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpBingLanguagesResponseInfo> SerpBingLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLanguagesResponseInfo&gt;](./SerpBingLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/languages/?bash'

### **BingOrganicTaskPostAsync(IEnumerable&lt;SerpBingOrganicTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpBingOrganicTaskPostResponseInfo> BingOrganicTaskPostAsync(IEnumerable<SerpBingOrganicTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingOrganicTaskPostRequestInfo&gt;](./SerpBingOrganicTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpBingOrganicTaskPostResponseInfo&gt;](./SerpBingOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_post/?bash'

### **BingOrganicTaskPostAsync(IEnumerable&lt;SerpBingOrganicTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingOrganicTaskPostResponseInfo> BingOrganicTaskPostAsync(IEnumerable<SerpBingOrganicTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingOrganicTaskPostRequestInfo&gt;](./SerpBingOrganicTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTaskPostResponseInfo&gt;](./SerpBingOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpBingOrganicTasksReadyResponseInfo&gt;](./SerpBingOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/tasks_ready/?bash'

### **BingOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpBingOrganicTasksReadyResponseInfo> BingOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTasksReadyResponseInfo&gt;](./SerpBingOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/tasks_ready/?bash'

### **BingOrganicTasksFixedAsync()**

```csharp
public Task<SerpBingOrganicTasksFixedResponseInfo> BingOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpBingOrganicTasksFixedResponseInfo&gt;](./SerpBingOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTasksFixedResponseInfo&gt;](./SerpBingOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBingOrganicTaskGetRegularResponseInfo&gt;](./SerpBingOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/regular/?bash'

### **BingOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpBingOrganicTaskGetRegularResponseInfo> BingOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTaskGetRegularResponseInfo&gt;](./SerpBingOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/regular/?bash'

### **BingOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpBingOrganicTaskGetAdvancedResponseInfo> BingOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBingOrganicTaskGetAdvancedResponseInfo&gt;](./SerpBingOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/advanced/?bash'

### **BingOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpBingOrganicTaskGetAdvancedResponseInfo> BingOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTaskGetAdvancedResponseInfo&gt;](./SerpBingOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/advanced/?bash'

### **BingOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpBingOrganicTaskGetHtmlResponseInfo> BingOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBingOrganicTaskGetHtmlResponseInfo&gt;](./SerpBingOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/html/?bash'

### **BingOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpBingOrganicTaskGetHtmlResponseInfo> BingOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicTaskGetHtmlResponseInfo&gt;](./SerpBingOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/html/?bash'

### **BingOrganicLiveRegularAsync(IEnumerable&lt;SerpBingOrganicLiveRegularRequestInfo&gt;)**

```csharp
public Task<SerpBingOrganicLiveRegularResponseInfo> BingOrganicLiveRegularAsync(IEnumerable<SerpBingOrganicLiveRegularRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingOrganicLiveRegularRequestInfo&gt;](./SerpBingOrganicLiveRegularRequestInfo.md)<br>

#### Returns

[Task&lt;SerpBingOrganicLiveRegularResponseInfo&gt;](./SerpBingOrganicLiveRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/regular/?bash'

### **BingOrganicLiveRegularAsync(IEnumerable&lt;SerpBingOrganicLiveRegularRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingOrganicLiveRegularResponseInfo> BingOrganicLiveRegularAsync(IEnumerable<SerpBingOrganicLiveRegularRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingOrganicLiveRegularRequestInfo&gt;](./SerpBingOrganicLiveRegularRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicLiveRegularResponseInfo&gt;](./SerpBingOrganicLiveRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/regular/?bash'

### **BingOrganicLiveAdvancedAsync(IEnumerable&lt;SerpBingOrganicLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpBingOrganicLiveAdvancedResponseInfo> BingOrganicLiveAdvancedAsync(IEnumerable<SerpBingOrganicLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingOrganicLiveAdvancedRequestInfo&gt;](./SerpBingOrganicLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpBingOrganicLiveAdvancedResponseInfo&gt;](./SerpBingOrganicLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/advanced/?bash'

### **BingOrganicLiveAdvancedAsync(IEnumerable&lt;SerpBingOrganicLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingOrganicLiveAdvancedResponseInfo> BingOrganicLiveAdvancedAsync(IEnumerable<SerpBingOrganicLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingOrganicLiveAdvancedRequestInfo&gt;](./SerpBingOrganicLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicLiveAdvancedResponseInfo&gt;](./SerpBingOrganicLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/advanced/?bash'

### **BingOrganicLiveHtmlAsync(IEnumerable&lt;SerpBingOrganicLiveHtmlRequestInfo&gt;)**

```csharp
public Task<SerpBingOrganicLiveHtmlResponseInfo> BingOrganicLiveHtmlAsync(IEnumerable<SerpBingOrganicLiveHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingOrganicLiveHtmlRequestInfo&gt;](./SerpBingOrganicLiveHtmlRequestInfo.md)<br>

#### Returns

[Task&lt;SerpBingOrganicLiveHtmlResponseInfo&gt;](./SerpBingOrganicLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/html/?bash'

### **BingOrganicLiveHtmlAsync(IEnumerable&lt;SerpBingOrganicLiveHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingOrganicLiveHtmlResponseInfo> BingOrganicLiveHtmlAsync(IEnumerable<SerpBingOrganicLiveHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingOrganicLiveHtmlRequestInfo&gt;](./SerpBingOrganicLiveHtmlRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingOrganicLiveHtmlResponseInfo&gt;](./SerpBingOrganicLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/html/?bash'

### **BingLocalPackTaskPostAsync(IEnumerable&lt;SerpBingLocalPackTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpBingLocalPackTaskPostResponseInfo> BingLocalPackTaskPostAsync(IEnumerable<SerpBingLocalPackTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingLocalPackTaskPostRequestInfo&gt;](./SerpBingLocalPackTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpBingLocalPackTaskPostResponseInfo&gt;](./SerpBingLocalPackTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_post/?bash'

### **BingLocalPackTaskPostAsync(IEnumerable&lt;SerpBingLocalPackTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingLocalPackTaskPostResponseInfo> BingLocalPackTaskPostAsync(IEnumerable<SerpBingLocalPackTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingLocalPackTaskPostRequestInfo&gt;](./SerpBingLocalPackTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackTaskPostResponseInfo&gt;](./SerpBingLocalPackTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpBingLocalPackTasksReadyResponseInfo&gt;](./SerpBingLocalPackTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/tasks_ready/?bash'

### **BingLocalPackTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpBingLocalPackTasksReadyResponseInfo> BingLocalPackTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackTasksReadyResponseInfo&gt;](./SerpBingLocalPackTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/tasks_ready/?bash'

### **BingLocalPackTasksFixedAsync()**

```csharp
public Task<SerpBingLocalPackTasksFixedResponseInfo> BingLocalPackTasksFixedAsync()
```

#### Returns

[Task&lt;SerpBingLocalPackTasksFixedResponseInfo&gt;](./SerpBingLocalPackTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackTasksFixedResponseInfo&gt;](./SerpBingLocalPackTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBingLocalPackTaskGetRegularResponseInfo&gt;](./SerpBingLocalPackTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/regular/?bash'

### **BingLocalPackTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpBingLocalPackTaskGetRegularResponseInfo> BingLocalPackTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackTaskGetRegularResponseInfo&gt;](./SerpBingLocalPackTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/regular/?bash'

### **BingLocalPackTaskGetHtmlAsync(String)**

```csharp
public Task<SerpBingLocalPackTaskGetHtmlResponseInfo> BingLocalPackTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpBingLocalPackTaskGetHtmlResponseInfo&gt;](./SerpBingLocalPackTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/html/?bash'

### **BingLocalPackTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpBingLocalPackTaskGetHtmlResponseInfo> BingLocalPackTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackTaskGetHtmlResponseInfo&gt;](./SerpBingLocalPackTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/html/?bash'

### **BingLocalPackLiveRegularAsync(IEnumerable&lt;SerpBingLocalPackLiveRegularRequestInfo&gt;)**

```csharp
public Task<SerpBingLocalPackLiveRegularResponseInfo> BingLocalPackLiveRegularAsync(IEnumerable<SerpBingLocalPackLiveRegularRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingLocalPackLiveRegularRequestInfo&gt;](./SerpBingLocalPackLiveRegularRequestInfo.md)<br>

#### Returns

[Task&lt;SerpBingLocalPackLiveRegularResponseInfo&gt;](./SerpBingLocalPackLiveRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Bing Local Pack SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/live/regular/?bash'

### **BingLocalPackLiveRegularAsync(IEnumerable&lt;SerpBingLocalPackLiveRegularRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingLocalPackLiveRegularResponseInfo> BingLocalPackLiveRegularAsync(IEnumerable<SerpBingLocalPackLiveRegularRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingLocalPackLiveRegularRequestInfo&gt;](./SerpBingLocalPackLiveRegularRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackLiveRegularResponseInfo&gt;](./SerpBingLocalPackLiveRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Bing Local Pack SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/live/regular/?bash'

### **BingLocalPackLiveHtmlAsync(IEnumerable&lt;SerpBingLocalPackLiveHtmlRequestInfo&gt;)**

```csharp
public Task<SerpBingLocalPackLiveHtmlResponseInfo> BingLocalPackLiveHtmlAsync(IEnumerable<SerpBingLocalPackLiveHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingLocalPackLiveHtmlRequestInfo&gt;](./SerpBingLocalPackLiveHtmlRequestInfo.md)<br>

#### Returns

[Task&lt;SerpBingLocalPackLiveHtmlResponseInfo&gt;](./SerpBingLocalPackLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/live/html/?bash'

### **BingLocalPackLiveHtmlAsync(IEnumerable&lt;SerpBingLocalPackLiveHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpBingLocalPackLiveHtmlResponseInfo> BingLocalPackLiveHtmlAsync(IEnumerable<SerpBingLocalPackLiveHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpBingLocalPackLiveHtmlRequestInfo&gt;](./SerpBingLocalPackLiveHtmlRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpBingLocalPackLiveHtmlResponseInfo&gt;](./SerpBingLocalPackLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpYoutubeLocationsResponseInfo&gt;](./SerpYoutubeLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'

### **SerpYoutubeLocationsAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeLocationsResponseInfo> SerpYoutubeLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeLocationsResponseInfo&gt;](./SerpYoutubeLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'

### **SerpYoutubeLocationsCountryAsync(String)**

```csharp
public Task<SerpYoutubeLocationsCountryResponseInfo> SerpYoutubeLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpYoutubeLocationsCountryResponseInfo&gt;](./SerpYoutubeLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'

### **SerpYoutubeLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpYoutubeLocationsCountryResponseInfo> SerpYoutubeLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeLocationsCountryResponseInfo&gt;](./SerpYoutubeLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'

### **SerpYoutubeLanguagesAsync()**

```csharp
public Task<SerpYoutubeLanguagesResponseInfo> SerpYoutubeLanguagesAsync()
```

#### Returns

[Task&lt;SerpYoutubeLanguagesResponseInfo&gt;](./SerpYoutubeLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/languages/?bash'

### **SerpYoutubeLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeLanguagesResponseInfo> SerpYoutubeLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeLanguagesResponseInfo&gt;](./SerpYoutubeLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/languages/?bash'

### **YoutubeVideoInfoTaskPostAsync(IEnumerable&lt;SerpYoutubeVideoInfoTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpYoutubeVideoInfoTaskPostResponseInfo> YoutubeVideoInfoTaskPostAsync(IEnumerable<SerpYoutubeVideoInfoTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoInfoTaskPostRequestInfo&gt;](./SerpYoutubeVideoInfoTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoInfoTaskPostResponseInfo&gt;](./SerpYoutubeVideoInfoTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpYoutubeVideoInfoTaskPostRequestInfo&gt;](./SerpYoutubeVideoInfoTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoInfoTaskPostResponseInfo&gt;](./SerpYoutubeVideoInfoTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpYoutubeVideoInfoTasksReadyResponseInfo&gt;](./SerpYoutubeVideoInfoTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/tasks_ready/?bash'

### **YoutubeVideoInfoTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeVideoInfoTasksReadyResponseInfo> YoutubeVideoInfoTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoInfoTasksReadyResponseInfo&gt;](./SerpYoutubeVideoInfoTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/tasks_ready/?bash'

### **YoutubeVideoInfoTasksFixedAsync()**

```csharp
public Task<SerpYoutubeVideoInfoTasksFixedResponseInfo> YoutubeVideoInfoTasksFixedAsync()
```

#### Returns

[Task&lt;SerpYoutubeVideoInfoTasksFixedResponseInfo&gt;](./SerpYoutubeVideoInfoTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoInfoTasksFixedResponseInfo&gt;](./SerpYoutubeVideoInfoTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo&gt;](./SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/task_get/advanced/?bash'

### **YoutubeVideoInfoTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo> YoutubeVideoInfoTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo&gt;](./SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/task_get/advanced/?bash'

### **YoutubeVideoInfoLiveAdvancedAsync(IEnumerable&lt;SerpYoutubeVideoInfoLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpYoutubeVideoInfoLiveAdvancedResponseInfo> YoutubeVideoInfoLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoInfoLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoInfoLiveAdvancedRequestInfo&gt;](./SerpYoutubeVideoInfoLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoInfoLiveAdvancedResponseInfo&gt;](./SerpYoutubeVideoInfoLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpYoutubeVideoInfoLiveAdvancedRequestInfo&gt;](./SerpYoutubeVideoInfoLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoInfoLiveAdvancedResponseInfo&gt;](./SerpYoutubeVideoInfoLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpYoutubeVideoSubtitlesTaskPostRequestInfo&gt;](./SerpYoutubeVideoSubtitlesTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTaskPostResponseInfo&gt;](./SerpYoutubeVideoSubtitlesTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpYoutubeVideoSubtitlesTaskPostRequestInfo&gt;](./SerpYoutubeVideoSubtitlesTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTaskPostResponseInfo&gt;](./SerpYoutubeVideoSubtitlesTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpYoutubeVideoSubtitlesTasksReadyResponseInfo&gt;](./SerpYoutubeVideoSubtitlesTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/tasks_ready/?bash'

### **YoutubeVideoSubtitlesTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeVideoSubtitlesTasksReadyResponseInfo> YoutubeVideoSubtitlesTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTasksReadyResponseInfo&gt;](./SerpYoutubeVideoSubtitlesTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/tasks_ready/?bash'

### **YoutubeVideoSubtitlesTasksFixedAsync()**

```csharp
public Task<SerpYoutubeVideoSubtitlesTasksFixedResponseInfo> YoutubeVideoSubtitlesTasksFixedAsync()
```

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTasksFixedResponseInfo&gt;](./SerpYoutubeVideoSubtitlesTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTasksFixedResponseInfo&gt;](./SerpYoutubeVideoSubtitlesTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo&gt;](./SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/task_get/advanced/?bash'

### **YoutubeVideoSubtitlesTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo> YoutubeVideoSubtitlesTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo&gt;](./SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/task_get/advanced/?bash'

### **YoutubeVideoSubtitlesLiveAdvancedAsync(IEnumerable&lt;SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo> YoutubeVideoSubtitlesLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo&gt;](./SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo&gt;](./SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo&gt;](./SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo&gt;](./SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpYoutubeVideoCommentsTaskPostRequestInfo&gt;](./SerpYoutubeVideoCommentsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTaskPostResponseInfo&gt;](./SerpYoutubeVideoCommentsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpYoutubeVideoCommentsTaskPostRequestInfo&gt;](./SerpYoutubeVideoCommentsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTaskPostResponseInfo&gt;](./SerpYoutubeVideoCommentsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpYoutubeVideoCommentsTasksReadyResponseInfo&gt;](./SerpYoutubeVideoCommentsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/tasks_ready/?bash'

### **YoutubeVideoCommentsTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpYoutubeVideoCommentsTasksReadyResponseInfo> YoutubeVideoCommentsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTasksReadyResponseInfo&gt;](./SerpYoutubeVideoCommentsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/tasks_ready/?bash'

### **YoutubeVideoCommentsTasksFixedAsync()**

```csharp
public Task<SerpYoutubeVideoCommentsTasksFixedResponseInfo> YoutubeVideoCommentsTasksFixedAsync()
```

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTasksFixedResponseInfo&gt;](./SerpYoutubeVideoCommentsTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTasksFixedResponseInfo&gt;](./SerpYoutubeVideoCommentsTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo&gt;](./SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/task_get/advanced/?bash'

### **YoutubeVideoCommentsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo> YoutubeVideoCommentsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo&gt;](./SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/task_get/advanced/?bash'

### **YoutubeVideoCommentsLiveAdvancedAsync(IEnumerable&lt;SerpYoutubeVideoCommentsLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpYoutubeVideoCommentsLiveAdvancedResponseInfo> YoutubeVideoCommentsLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoCommentsLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYoutubeVideoCommentsLiveAdvancedRequestInfo&gt;](./SerpYoutubeVideoCommentsLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpYoutubeVideoCommentsLiveAdvancedResponseInfo&gt;](./SerpYoutubeVideoCommentsLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpYoutubeVideoCommentsLiveAdvancedRequestInfo&gt;](./SerpYoutubeVideoCommentsLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYoutubeVideoCommentsLiveAdvancedResponseInfo&gt;](./SerpYoutubeVideoCommentsLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpYahooLocationsResponseInfo&gt;](./SerpYahooLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'

### **SerpYahooLocationsAsync(CancellationToken)**

```csharp
public Task<SerpYahooLocationsResponseInfo> SerpYahooLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooLocationsResponseInfo&gt;](./SerpYahooLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'

### **SerpYahooLocationsCountryAsync(String)**

```csharp
public Task<SerpYahooLocationsCountryResponseInfo> SerpYahooLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpYahooLocationsCountryResponseInfo&gt;](./SerpYahooLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'

### **SerpYahooLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpYahooLocationsCountryResponseInfo> SerpYahooLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooLocationsCountryResponseInfo&gt;](./SerpYahooLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'

### **SerpYahooLanguagesAsync()**

```csharp
public Task<SerpYahooLanguagesResponseInfo> SerpYahooLanguagesAsync()
```

#### Returns

[Task&lt;SerpYahooLanguagesResponseInfo&gt;](./SerpYahooLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/languages/?bash'

### **SerpYahooLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpYahooLanguagesResponseInfo> SerpYahooLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooLanguagesResponseInfo&gt;](./SerpYahooLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/languages/?bash'

### **YahooOrganicTaskPostAsync(IEnumerable&lt;SerpYahooOrganicTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpYahooOrganicTaskPostResponseInfo> YahooOrganicTaskPostAsync(IEnumerable<SerpYahooOrganicTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpYahooOrganicTaskPostRequestInfo&gt;](./SerpYahooOrganicTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpYahooOrganicTaskPostResponseInfo&gt;](./SerpYahooOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_post/?bash'

### **YahooOrganicTaskPostAsync(IEnumerable&lt;SerpYahooOrganicTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpYahooOrganicTaskPostResponseInfo> YahooOrganicTaskPostAsync(IEnumerable<SerpYahooOrganicTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpYahooOrganicTaskPostRequestInfo&gt;](./SerpYahooOrganicTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTaskPostResponseInfo&gt;](./SerpYahooOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpYahooOrganicTasksReadyResponseInfo&gt;](./SerpYahooOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/tasks_ready/?bash'

### **YahooOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpYahooOrganicTasksReadyResponseInfo> YahooOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTasksReadyResponseInfo&gt;](./SerpYahooOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/tasks_ready/?bash'

### **YahooOrganicTasksFixedAsync()**

```csharp
public Task<SerpYahooOrganicTasksFixedResponseInfo> YahooOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpYahooOrganicTasksFixedResponseInfo&gt;](./SerpYahooOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTasksFixedResponseInfo&gt;](./SerpYahooOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpYahooOrganicTaskGetRegularResponseInfo&gt;](./SerpYahooOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/regular/?bash'

### **YahooOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpYahooOrganicTaskGetRegularResponseInfo> YahooOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpYahooOrganicTaskGetRegularResponseInfo&gt;](./SerpYahooOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/regular/?bash'

### **SerpIdListAsync(IEnumerable&lt;SerpIdListRequestInfo&gt;)**

```csharp
public Task<SerpIdListResponseInfo> SerpIdListAsync(IEnumerable<SerpIdListRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpIdListRequestInfo&gt;](./SerpIdListRequestInfo.md)<br>

#### Returns

[Task&lt;SerpIdListResponseInfo&gt;](./SerpIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed SERP tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/id_list/?bash'

### **SerpIdListAsync(IEnumerable&lt;SerpIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpIdListResponseInfo> SerpIdListAsync(IEnumerable<SerpIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpIdListRequestInfo&gt;](./SerpIdListRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpIdListResponseInfo&gt;](./SerpIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed SERP tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/id_list/?bash'

### **SerpErrorsAsync(IEnumerable&lt;SerpErrorsRequestInfo&gt;)**

```csharp
public Task<SerpErrorsResponseInfo> SerpErrorsAsync(IEnumerable<SerpErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpErrorsRequestInfo&gt;](./SerpErrorsRequestInfo.md)<br>

#### Returns

[Task&lt;SerpErrorsResponseInfo&gt;](./SerpErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the SERP API tasks that returned an error within the past 7 days.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/errors/?bash'

### **SerpErrorsAsync(IEnumerable&lt;SerpErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpErrorsResponseInfo> SerpErrorsAsync(IEnumerable<SerpErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpErrorsRequestInfo&gt;](./SerpErrorsRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpErrorsResponseInfo&gt;](./SerpErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the SERP API tasks that returned an error within the past 7 days.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/errors/?bash'

### **ScreenshotAsync(IEnumerable&lt;SerpScreenshotRequestInfo&gt;)**

```csharp
public Task<SerpScreenshotResponseInfo> ScreenshotAsync(IEnumerable<SerpScreenshotRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpScreenshotRequestInfo&gt;](./SerpScreenshotRequestInfo.md)<br>

#### Returns

[Task&lt;SerpScreenshotResponseInfo&gt;](./SerpScreenshotResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpScreenshotRequestInfo&gt;](./SerpScreenshotRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpScreenshotResponseInfo&gt;](./SerpScreenshotResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpAiSummaryRequestInfo&gt;](./SerpAiSummaryRequestInfo.md)<br>

#### Returns

[Task&lt;SerpAiSummaryResponseInfo&gt;](./SerpAiSummaryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The purpose of the Live SERP API AI Summary endpoint is to provide a summary of the content found on any SERP and generate a response based on the user’s specified prompt.
 <br>To obtain results, you have to specify task_id, which you can find in the response to the POST request.
 <br>Learn more in our Help Center.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/ai_summary/?bash'

### **AiSummaryAsync(IEnumerable&lt;SerpAiSummaryRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpAiSummaryResponseInfo> AiSummaryAsync(IEnumerable<SerpAiSummaryRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpAiSummaryRequestInfo&gt;](./SerpAiSummaryRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpAiSummaryResponseInfo&gt;](./SerpAiSummaryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The purpose of the Live SERP API AI Summary endpoint is to provide a summary of the content found on any SERP and generate a response based on the user’s specified prompt.
 <br>To obtain results, you have to specify task_id, which you can find in the response to the POST request.
 <br>Learn more in our Help Center.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/ai_summary/?bash'

### **SerpGoogleLocationsAsync()**

```csharp
public Task<SerpGoogleLocationsResponseInfo> SerpGoogleLocationsAsync()
```

#### Returns

[Task&lt;SerpGoogleLocationsResponseInfo&gt;](./SerpGoogleLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'

### **SerpGoogleLocationsAsync(CancellationToken)**

```csharp
public Task<SerpGoogleLocationsResponseInfo> SerpGoogleLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocationsResponseInfo&gt;](./SerpGoogleLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'

### **SerpGoogleLocationsCountryAsync(String)**

```csharp
public Task<SerpGoogleLocationsCountryResponseInfo> SerpGoogleLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;SerpGoogleLocationsCountryResponseInfo&gt;](./SerpGoogleLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'

### **SerpGoogleLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleLocationsCountryResponseInfo> SerpGoogleLocationsCountryAsync(string country, CancellationToken cancellationToken)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocationsCountryResponseInfo&gt;](./SerpGoogleLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'

### **SerpGoogleLanguagesAsync()**

```csharp
public Task<SerpGoogleLanguagesResponseInfo> SerpGoogleLanguagesAsync()
```

#### Returns

[Task&lt;SerpGoogleLanguagesResponseInfo&gt;](./SerpGoogleLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/languages/?bash'

### **SerpGoogleLanguagesAsync(CancellationToken)**

```csharp
public Task<SerpGoogleLanguagesResponseInfo> SerpGoogleLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLanguagesResponseInfo&gt;](./SerpGoogleLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/languages/?bash'

### **GoogleOrganicTaskPostAsync(IEnumerable&lt;SerpGoogleOrganicTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleOrganicTaskPostResponseInfo> GoogleOrganicTaskPostAsync(IEnumerable<SerpGoogleOrganicTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleOrganicTaskPostRequestInfo&gt;](./SerpGoogleOrganicTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleOrganicTaskPostResponseInfo&gt;](./SerpGoogleOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_post/?bash'

### **GoogleOrganicTaskPostAsync(IEnumerable&lt;SerpGoogleOrganicTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicTaskPostResponseInfo> GoogleOrganicTaskPostAsync(IEnumerable<SerpGoogleOrganicTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleOrganicTaskPostRequestInfo&gt;](./SerpGoogleOrganicTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTaskPostResponseInfo&gt;](./SerpGoogleOrganicTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpGoogleOrganicTasksReadyResponseInfo&gt;](./SerpGoogleOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_ready/?bash'

### **GoogleOrganicTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleOrganicTasksReadyResponseInfo> GoogleOrganicTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTasksReadyResponseInfo&gt;](./SerpGoogleOrganicTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_ready/?bash'

### **TasksReadyAsync()**

```csharp
public Task<SerpTasksReadyResponseInfo> TasksReadyAsync()
```

#### Returns

[Task&lt;SerpTasksReadyResponseInfo&gt;](./SerpTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_ready/?bash'

### **TasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpTasksReadyResponseInfo> TasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpTasksReadyResponseInfo&gt;](./SerpTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_ready/?bash'

### **GoogleOrganicTasksFixedAsync()**

```csharp
public Task<SerpGoogleOrganicTasksFixedResponseInfo> GoogleOrganicTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleOrganicTasksFixedResponseInfo&gt;](./SerpGoogleOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTasksFixedResponseInfo&gt;](./SerpGoogleOrganicTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetRegularResponseInfo&gt;](./SerpGoogleOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/regular/?bash'

### **GoogleOrganicTaskGetRegularAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicTaskGetRegularResponseInfo> GoogleOrganicTaskGetRegularAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetRegularResponseInfo&gt;](./SerpGoogleOrganicTaskGetRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/regular/?bash'

### **GoogleOrganicTaskGetAdvancedAsync(String)**

```csharp
public Task<SerpGoogleOrganicTaskGetAdvancedResponseInfo> GoogleOrganicTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetAdvancedResponseInfo&gt;](./SerpGoogleOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/advanced/?bash'

### **GoogleOrganicTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicTaskGetAdvancedResponseInfo> GoogleOrganicTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetAdvancedResponseInfo&gt;](./SerpGoogleOrganicTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/advanced/?bash'

### **GoogleOrganicTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleOrganicTaskGetHtmlResponseInfo> GoogleOrganicTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetHtmlResponseInfo&gt;](./SerpGoogleOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/html/?bash'

### **GoogleOrganicTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicTaskGetHtmlResponseInfo> GoogleOrganicTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicTaskGetHtmlResponseInfo&gt;](./SerpGoogleOrganicTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/html/?bash'

### **GoogleOrganicLiveRegularAsync(IEnumerable&lt;SerpGoogleOrganicLiveRegularRequestInfo&gt;)**

```csharp
public Task<SerpGoogleOrganicLiveRegularResponseInfo> GoogleOrganicLiveRegularAsync(IEnumerable<SerpGoogleOrganicLiveRegularRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleOrganicLiveRegularRequestInfo&gt;](./SerpGoogleOrganicLiveRegularRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleOrganicLiveRegularResponseInfo&gt;](./SerpGoogleOrganicLiveRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/regular/?bash'

### **GoogleOrganicLiveRegularAsync(IEnumerable&lt;SerpGoogleOrganicLiveRegularRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicLiveRegularResponseInfo> GoogleOrganicLiveRegularAsync(IEnumerable<SerpGoogleOrganicLiveRegularRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleOrganicLiveRegularRequestInfo&gt;](./SerpGoogleOrganicLiveRegularRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicLiveRegularResponseInfo&gt;](./SerpGoogleOrganicLiveRegularResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/regular/?bash'

### **GoogleOrganicLiveAdvancedAsync(IEnumerable&lt;SerpGoogleOrganicLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleOrganicLiveAdvancedResponseInfo> GoogleOrganicLiveAdvancedAsync(IEnumerable<SerpGoogleOrganicLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleOrganicLiveAdvancedRequestInfo&gt;](./SerpGoogleOrganicLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleOrganicLiveAdvancedResponseInfo&gt;](./SerpGoogleOrganicLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/advanced/?bash'

### **GoogleOrganicLiveAdvancedAsync(IEnumerable&lt;SerpGoogleOrganicLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicLiveAdvancedResponseInfo> GoogleOrganicLiveAdvancedAsync(IEnumerable<SerpGoogleOrganicLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleOrganicLiveAdvancedRequestInfo&gt;](./SerpGoogleOrganicLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicLiveAdvancedResponseInfo&gt;](./SerpGoogleOrganicLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/advanced/?bash'

### **GoogleOrganicLiveHtmlAsync(IEnumerable&lt;SerpGoogleOrganicLiveHtmlRequestInfo&gt;)**

```csharp
public Task<SerpGoogleOrganicLiveHtmlResponseInfo> GoogleOrganicLiveHtmlAsync(IEnumerable<SerpGoogleOrganicLiveHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleOrganicLiveHtmlRequestInfo&gt;](./SerpGoogleOrganicLiveHtmlRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleOrganicLiveHtmlResponseInfo&gt;](./SerpGoogleOrganicLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/html/?bash'

### **GoogleOrganicLiveHtmlAsync(IEnumerable&lt;SerpGoogleOrganicLiveHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleOrganicLiveHtmlResponseInfo> GoogleOrganicLiveHtmlAsync(IEnumerable<SerpGoogleOrganicLiveHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleOrganicLiveHtmlRequestInfo&gt;](./SerpGoogleOrganicLiveHtmlRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleOrganicLiveHtmlResponseInfo&gt;](./SerpGoogleOrganicLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleMapsTaskPostRequestInfo&gt;](./SerpGoogleMapsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleMapsTaskPostResponseInfo&gt;](./SerpGoogleMapsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleMapsTaskPostRequestInfo&gt;](./SerpGoogleMapsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleMapsTaskPostResponseInfo&gt;](./SerpGoogleMapsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpGoogleMapsTasksReadyResponseInfo&gt;](./SerpGoogleMapsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/tasks_ready/?bash'

### **GoogleMapsTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleMapsTasksReadyResponseInfo> GoogleMapsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleMapsTasksReadyResponseInfo&gt;](./SerpGoogleMapsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/tasks_ready/?bash'

### **GoogleMapsTasksFixedAsync()**

```csharp
public Task<SerpGoogleMapsTasksFixedResponseInfo> GoogleMapsTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleMapsTasksFixedResponseInfo&gt;](./SerpGoogleMapsTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleMapsTasksFixedResponseInfo&gt;](./SerpGoogleMapsTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>a universally unique identifier (UUID)
 <br>unique task identifier in our system
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleMapsTaskGetAdvancedResponseInfo&gt;](./SerpGoogleMapsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/task_get/advanced/?bash'

### **GoogleMapsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleMapsTaskGetAdvancedResponseInfo> GoogleMapsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>a universally unique identifier (UUID)
 <br>unique task identifier in our system
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleMapsTaskGetAdvancedResponseInfo&gt;](./SerpGoogleMapsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/task_get/advanced/?bash'

### **GoogleMapsLiveAdvancedAsync(IEnumerable&lt;SerpGoogleMapsLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleMapsLiveAdvancedResponseInfo> GoogleMapsLiveAdvancedAsync(IEnumerable<SerpGoogleMapsLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleMapsLiveAdvancedRequestInfo&gt;](./SerpGoogleMapsLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleMapsLiveAdvancedResponseInfo&gt;](./SerpGoogleMapsLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleMapsLiveAdvancedRequestInfo&gt;](./SerpGoogleMapsLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleMapsLiveAdvancedResponseInfo&gt;](./SerpGoogleMapsLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleLocalFinderTaskPostRequestInfo&gt;](./SerpGoogleLocalFinderTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskPostResponseInfo&gt;](./SerpGoogleLocalFinderTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleLocalFinderTaskPostRequestInfo&gt;](./SerpGoogleLocalFinderTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskPostResponseInfo&gt;](./SerpGoogleLocalFinderTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpGoogleLocalFinderTasksReadyResponseInfo&gt;](./SerpGoogleLocalFinderTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/tasks_ready/?bash'

### **GoogleLocalFinderTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleLocalFinderTasksReadyResponseInfo> GoogleLocalFinderTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderTasksReadyResponseInfo&gt;](./SerpGoogleLocalFinderTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/tasks_ready/?bash'

### **GoogleLocalFinderTasksFixedAsync()**

```csharp
public Task<SerpGoogleLocalFinderTasksFixedResponseInfo> GoogleLocalFinderTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleLocalFinderTasksFixedResponseInfo&gt;](./SerpGoogleLocalFinderTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderTasksFixedResponseInfo&gt;](./SerpGoogleLocalFinderTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>a universally unique identifier (UUID)
 <br>unique task identifier in our system
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskGetAdvancedResponseInfo&gt;](./SerpGoogleLocalFinderTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/advanced/?bash'

### **GoogleLocalFinderTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleLocalFinderTaskGetAdvancedResponseInfo> GoogleLocalFinderTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>a universally unique identifier (UUID)
 <br>unique task identifier in our system
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskGetAdvancedResponseInfo&gt;](./SerpGoogleLocalFinderTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/advanced/?bash'

### **GoogleLocalFinderTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleLocalFinderTaskGetHtmlResponseInfo> GoogleLocalFinderTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskGetHtmlResponseInfo&gt;](./SerpGoogleLocalFinderTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/html/?bash'

### **GoogleLocalFinderTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleLocalFinderTaskGetHtmlResponseInfo> GoogleLocalFinderTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderTaskGetHtmlResponseInfo&gt;](./SerpGoogleLocalFinderTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/html/?bash'

### **GoogleLocalFinderLiveAdvancedAsync(IEnumerable&lt;SerpGoogleLocalFinderLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleLocalFinderLiveAdvancedResponseInfo> GoogleLocalFinderLiveAdvancedAsync(IEnumerable<SerpGoogleLocalFinderLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleLocalFinderLiveAdvancedRequestInfo&gt;](./SerpGoogleLocalFinderLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleLocalFinderLiveAdvancedResponseInfo&gt;](./SerpGoogleLocalFinderLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleLocalFinderLiveAdvancedRequestInfo&gt;](./SerpGoogleLocalFinderLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderLiveAdvancedResponseInfo&gt;](./SerpGoogleLocalFinderLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleLocalFinderLiveHtmlRequestInfo&gt;](./SerpGoogleLocalFinderLiveHtmlRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleLocalFinderLiveHtmlResponseInfo&gt;](./SerpGoogleLocalFinderLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleLocalFinderLiveHtmlRequestInfo&gt;](./SerpGoogleLocalFinderLiveHtmlRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleLocalFinderLiveHtmlResponseInfo&gt;](./SerpGoogleLocalFinderLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Local Finder SERP HTML provides a raw HTML page of the search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/live/html/?bash'

### **GoogleNewsTaskPostAsync(IEnumerable&lt;SerpGoogleNewsTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleNewsTaskPostResponseInfo> GoogleNewsTaskPostAsync(IEnumerable<SerpGoogleNewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleNewsTaskPostRequestInfo&gt;](./SerpGoogleNewsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleNewsTaskPostResponseInfo&gt;](./SerpGoogleNewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_post/?bash'

### **GoogleNewsTaskPostAsync(IEnumerable&lt;SerpGoogleNewsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleNewsTaskPostResponseInfo> GoogleNewsTaskPostAsync(IEnumerable<SerpGoogleNewsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleNewsTaskPostRequestInfo&gt;](./SerpGoogleNewsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsTaskPostResponseInfo&gt;](./SerpGoogleNewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpGoogleNewsTasksReadyResponseInfo&gt;](./SerpGoogleNewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/tasks_ready/?bash'

### **GoogleNewsTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleNewsTasksReadyResponseInfo> GoogleNewsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsTasksReadyResponseInfo&gt;](./SerpGoogleNewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/tasks_ready/?bash'

### **GoogleNewsTasksFixedAsync()**

```csharp
public Task<SerpGoogleNewsTasksFixedResponseInfo> GoogleNewsTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleNewsTasksFixedResponseInfo&gt;](./SerpGoogleNewsTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsTasksFixedResponseInfo&gt;](./SerpGoogleNewsTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleNewsTaskGetAdvancedResponseInfo&gt;](./SerpGoogleNewsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/advanced/?bash'

### **GoogleNewsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleNewsTaskGetAdvancedResponseInfo> GoogleNewsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsTaskGetAdvancedResponseInfo&gt;](./SerpGoogleNewsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/advanced/?bash'

### **GoogleNewsTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleNewsTaskGetHtmlResponseInfo> GoogleNewsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleNewsTaskGetHtmlResponseInfo&gt;](./SerpGoogleNewsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/html/?bash'

### **GoogleNewsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleNewsTaskGetHtmlResponseInfo> GoogleNewsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsTaskGetHtmlResponseInfo&gt;](./SerpGoogleNewsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/html/?bash'

### **GoogleNewsLiveAdvancedAsync(IEnumerable&lt;SerpGoogleNewsLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleNewsLiveAdvancedResponseInfo> GoogleNewsLiveAdvancedAsync(IEnumerable<SerpGoogleNewsLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleNewsLiveAdvancedRequestInfo&gt;](./SerpGoogleNewsLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleNewsLiveAdvancedResponseInfo&gt;](./SerpGoogleNewsLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Google News SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/live/advanced/?bash'

### **GoogleNewsLiveAdvancedAsync(IEnumerable&lt;SerpGoogleNewsLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleNewsLiveAdvancedResponseInfo> GoogleNewsLiveAdvancedAsync(IEnumerable<SerpGoogleNewsLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleNewsLiveAdvancedRequestInfo&gt;](./SerpGoogleNewsLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsLiveAdvancedResponseInfo&gt;](./SerpGoogleNewsLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Google News SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/live/advanced/?bash'

### **GoogleNewsLiveHtmlAsync(IEnumerable&lt;SerpGoogleNewsLiveHtmlRequestInfo&gt;)**

```csharp
public Task<SerpGoogleNewsLiveHtmlResponseInfo> GoogleNewsLiveHtmlAsync(IEnumerable<SerpGoogleNewsLiveHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleNewsLiveHtmlRequestInfo&gt;](./SerpGoogleNewsLiveHtmlRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleNewsLiveHtmlResponseInfo&gt;](./SerpGoogleNewsLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/live/html/?bash'

### **GoogleNewsLiveHtmlAsync(IEnumerable&lt;SerpGoogleNewsLiveHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleNewsLiveHtmlResponseInfo> GoogleNewsLiveHtmlAsync(IEnumerable<SerpGoogleNewsLiveHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleNewsLiveHtmlRequestInfo&gt;](./SerpGoogleNewsLiveHtmlRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleNewsLiveHtmlResponseInfo&gt;](./SerpGoogleNewsLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleEventsTaskPostRequestInfo&gt;](./SerpGoogleEventsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleEventsTaskPostResponseInfo&gt;](./SerpGoogleEventsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleEventsTaskPostRequestInfo&gt;](./SerpGoogleEventsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleEventsTaskPostResponseInfo&gt;](./SerpGoogleEventsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpGoogleEventsTasksReadyResponseInfo&gt;](./SerpGoogleEventsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/tasks_ready/?bash'

### **GoogleEventsTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleEventsTasksReadyResponseInfo> GoogleEventsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleEventsTasksReadyResponseInfo&gt;](./SerpGoogleEventsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/tasks_ready/?bash'

### **GoogleEventsTasksFixedAsync()**

```csharp
public Task<SerpGoogleEventsTasksFixedResponseInfo> GoogleEventsTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleEventsTasksFixedResponseInfo&gt;](./SerpGoogleEventsTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleEventsTasksFixedResponseInfo&gt;](./SerpGoogleEventsTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleEventsTaskGetAdvancedResponseInfo&gt;](./SerpGoogleEventsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/task_get/advanced/?bash'

### **GoogleEventsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleEventsTaskGetAdvancedResponseInfo> GoogleEventsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleEventsTaskGetAdvancedResponseInfo&gt;](./SerpGoogleEventsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/task_get/advanced/?bash'

### **GoogleEventsLiveAdvancedAsync(IEnumerable&lt;SerpGoogleEventsLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleEventsLiveAdvancedResponseInfo> GoogleEventsLiveAdvancedAsync(IEnumerable<SerpGoogleEventsLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleEventsLiveAdvancedRequestInfo&gt;](./SerpGoogleEventsLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleEventsLiveAdvancedResponseInfo&gt;](./SerpGoogleEventsLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleEventsLiveAdvancedRequestInfo&gt;](./SerpGoogleEventsLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleEventsLiveAdvancedResponseInfo&gt;](./SerpGoogleEventsLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Live Google Events SERP provides real-time data from Google Events Search for the specified keyword and location. Note that Google Events SERP API works for the English language only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/live/advanced/?bash'

### **GoogleImagesTaskPostAsync(IEnumerable&lt;SerpGoogleImagesTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleImagesTaskPostResponseInfo> GoogleImagesTaskPostAsync(IEnumerable<SerpGoogleImagesTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleImagesTaskPostRequestInfo&gt;](./SerpGoogleImagesTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleImagesTaskPostResponseInfo&gt;](./SerpGoogleImagesTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_post/?bash'

### **GoogleImagesTaskPostAsync(IEnumerable&lt;SerpGoogleImagesTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleImagesTaskPostResponseInfo> GoogleImagesTaskPostAsync(IEnumerable<SerpGoogleImagesTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleImagesTaskPostRequestInfo&gt;](./SerpGoogleImagesTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesTaskPostResponseInfo&gt;](./SerpGoogleImagesTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpGoogleImagesTasksReadyResponseInfo&gt;](./SerpGoogleImagesTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/tasks_ready/?bash'

### **GoogleImagesTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleImagesTasksReadyResponseInfo> GoogleImagesTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesTasksReadyResponseInfo&gt;](./SerpGoogleImagesTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/tasks_ready/?bash'

### **GoogleImagesTasksFixedAsync()**

```csharp
public Task<SerpGoogleImagesTasksFixedResponseInfo> GoogleImagesTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleImagesTasksFixedResponseInfo&gt;](./SerpGoogleImagesTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesTasksFixedResponseInfo&gt;](./SerpGoogleImagesTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleImagesTaskGetAdvancedResponseInfo&gt;](./SerpGoogleImagesTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/advanced/?bash'

### **GoogleImagesTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleImagesTaskGetAdvancedResponseInfo> GoogleImagesTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesTaskGetAdvancedResponseInfo&gt;](./SerpGoogleImagesTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/advanced/?bash'

### **GoogleImagesTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleImagesTaskGetHtmlResponseInfo> GoogleImagesTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleImagesTaskGetHtmlResponseInfo&gt;](./SerpGoogleImagesTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/html/?bash'

### **GoogleImagesTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleImagesTaskGetHtmlResponseInfo> GoogleImagesTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesTaskGetHtmlResponseInfo&gt;](./SerpGoogleImagesTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/html/?bash'

### **GoogleImagesLiveAdvancedAsync(IEnumerable&lt;SerpGoogleImagesLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<SerpGoogleImagesLiveAdvancedResponseInfo> GoogleImagesLiveAdvancedAsync(IEnumerable<SerpGoogleImagesLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleImagesLiveAdvancedRequestInfo&gt;](./SerpGoogleImagesLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleImagesLiveAdvancedResponseInfo&gt;](./SerpGoogleImagesLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Images SERP provides real-time data on top 100 images results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/live/advanced/?bash'

### **GoogleImagesLiveAdvancedAsync(IEnumerable&lt;SerpGoogleImagesLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleImagesLiveAdvancedResponseInfo> GoogleImagesLiveAdvancedAsync(IEnumerable<SerpGoogleImagesLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleImagesLiveAdvancedRequestInfo&gt;](./SerpGoogleImagesLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesLiveAdvancedResponseInfo&gt;](./SerpGoogleImagesLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live Google Images SERP provides real-time data on top 100 images results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/live/advanced/?bash'

### **GoogleImagesLiveHtmlAsync(IEnumerable&lt;SerpGoogleImagesLiveHtmlRequestInfo&gt;)**

```csharp
public Task<SerpGoogleImagesLiveHtmlResponseInfo> GoogleImagesLiveHtmlAsync(IEnumerable<SerpGoogleImagesLiveHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleImagesLiveHtmlRequestInfo&gt;](./SerpGoogleImagesLiveHtmlRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleImagesLiveHtmlResponseInfo&gt;](./SerpGoogleImagesLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/live/html/?bash'

### **GoogleImagesLiveHtmlAsync(IEnumerable&lt;SerpGoogleImagesLiveHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleImagesLiveHtmlResponseInfo> GoogleImagesLiveHtmlAsync(IEnumerable<SerpGoogleImagesLiveHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleImagesLiveHtmlRequestInfo&gt;](./SerpGoogleImagesLiveHtmlRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleImagesLiveHtmlResponseInfo&gt;](./SerpGoogleImagesLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleSearchByImageTaskPostRequestInfo&gt;](./SerpGoogleSearchByImageTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleSearchByImageTaskPostResponseInfo&gt;](./SerpGoogleSearchByImageTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleSearchByImageTaskPostRequestInfo&gt;](./SerpGoogleSearchByImageTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleSearchByImageTaskPostResponseInfo&gt;](./SerpGoogleSearchByImageTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpGoogleSearchByImageTasksReadyResponseInfo&gt;](./SerpGoogleSearchByImageTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleSearchByImageTasksReadyResponseInfo&gt;](./SerpGoogleSearchByImageTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpGoogleSearchByImageTasksFixedResponseInfo&gt;](./SerpGoogleSearchByImageTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleSearchByImageTasksFixedResponseInfo&gt;](./SerpGoogleSearchByImageTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleSearchByImageTaskGetAdvancedResponseInfo&gt;](./SerpGoogleSearchByImageTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/task_get/advanced/?bash'

### **GoogleSearchByImageTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleSearchByImageTaskGetAdvancedResponseInfo> GoogleSearchByImageTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleSearchByImageTaskGetAdvancedResponseInfo&gt;](./SerpGoogleSearchByImageTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/task_get/advanced/?bash'

### **GoogleJobsTaskPostAsync(IEnumerable&lt;SerpGoogleJobsTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleJobsTaskPostResponseInfo> GoogleJobsTaskPostAsync(IEnumerable<SerpGoogleJobsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleJobsTaskPostRequestInfo&gt;](./SerpGoogleJobsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleJobsTaskPostResponseInfo&gt;](./SerpGoogleJobsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`body` [IEnumerable&lt;SerpGoogleJobsTaskPostRequestInfo&gt;](./SerpGoogleJobsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleJobsTaskPostResponseInfo&gt;](./SerpGoogleJobsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

[Task&lt;SerpGoogleJobsTasksReadyResponseInfo&gt;](./SerpGoogleJobsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/tasks_ready/?bash'

### **GoogleJobsTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleJobsTasksReadyResponseInfo> GoogleJobsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleJobsTasksReadyResponseInfo&gt;](./SerpGoogleJobsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/tasks_ready/?bash'

### **GoogleJobsTasksFixedAsync()**

```csharp
public Task<SerpGoogleJobsTasksFixedResponseInfo> GoogleJobsTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleJobsTasksFixedResponseInfo&gt;](./SerpGoogleJobsTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleJobsTasksFixedResponseInfo&gt;](./SerpGoogleJobsTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleJobsTaskGetAdvancedResponseInfo&gt;](./SerpGoogleJobsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/advanced/?bash'

### **GoogleJobsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleJobsTaskGetAdvancedResponseInfo> GoogleJobsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleJobsTaskGetAdvancedResponseInfo&gt;](./SerpGoogleJobsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/advanced/?bash'

### **GoogleJobsTaskGetHtmlAsync(String)**

```csharp
public Task<SerpGoogleJobsTaskGetHtmlResponseInfo> GoogleJobsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;SerpGoogleJobsTaskGetHtmlResponseInfo&gt;](./SerpGoogleJobsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/html/?bash'

### **GoogleJobsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<SerpGoogleJobsTaskGetHtmlResponseInfo> GoogleJobsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleJobsTaskGetHtmlResponseInfo&gt;](./SerpGoogleJobsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/html/?bash'

### **GoogleAutocompleteTaskPostAsync(IEnumerable&lt;SerpGoogleAutocompleteTaskPostRequestInfo&gt;)**

```csharp
public Task<SerpGoogleAutocompleteTaskPostResponseInfo> GoogleAutocompleteTaskPostAsync(IEnumerable<SerpGoogleAutocompleteTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleAutocompleteTaskPostRequestInfo&gt;](./SerpGoogleAutocompleteTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;SerpGoogleAutocompleteTaskPostResponseInfo&gt;](./SerpGoogleAutocompleteTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Autocomplete is a feature within Google Search that improves the search experience by allowing users to complete searches they started to type. DataForSEO SERP API will provide you with all the suggestions Google Autocomplete offers for a particular keyword, the position of the cursor pointer, and the search client.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/task_post/?bash'

### **GoogleAutocompleteTaskPostAsync(IEnumerable&lt;SerpGoogleAutocompleteTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<SerpGoogleAutocompleteTaskPostResponseInfo> GoogleAutocompleteTaskPostAsync(IEnumerable<SerpGoogleAutocompleteTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;SerpGoogleAutocompleteTaskPostRequestInfo&gt;](./SerpGoogleAutocompleteTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAutocompleteTaskPostResponseInfo&gt;](./SerpGoogleAutocompleteTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Autocomplete is a feature within Google Search that improves the search experience by allowing users to complete searches they started to type. DataForSEO SERP API will provide you with all the suggestions Google Autocomplete offers for a particular keyword, the position of the cursor pointer, and the search client.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/task_post/?bash'

### **GoogleAutocompleteTasksReadyAsync()**

```csharp
public Task<SerpGoogleAutocompleteTasksReadyResponseInfo> GoogleAutocompleteTasksReadyAsync()
```

#### Returns

[Task&lt;SerpGoogleAutocompleteTasksReadyResponseInfo&gt;](./SerpGoogleAutocompleteTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/tasks_ready/?bash'

### **GoogleAutocompleteTasksReadyAsync(CancellationToken)**

```csharp
public Task<SerpGoogleAutocompleteTasksReadyResponseInfo> GoogleAutocompleteTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAutocompleteTasksReadyResponseInfo&gt;](./SerpGoogleAutocompleteTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>Learn more about task completion and obtaining a list of completed tasks in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/tasks_ready/?bash'

### **GoogleAutocompleteTasksFixedAsync()**

```csharp
public Task<SerpGoogleAutocompleteTasksFixedResponseInfo> GoogleAutocompleteTasksFixedAsync()
```

#### Returns

[Task&lt;SerpGoogleAutocompleteTasksFixedResponseInfo&gt;](./SerpGoogleAutocompleteTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/tasks_fixed/?bash'

### **GoogleAutocompleteTasksFixedAsync(CancellationToken)**

```csharp
public Task<SerpGoogleAutocompleteTasksFixedResponseInfo> GoogleAutocompleteTasksFixedAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;SerpGoogleAutocompleteTasksFixedResponseInfo&gt;](./SerpGoogleAutocompleteTasksFixedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/tasks_fixed/?bash'
