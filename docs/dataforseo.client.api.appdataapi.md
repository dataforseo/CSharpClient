[`< Back`](./)

---

# AppDataApi

Namespace: DataForSeo.Client.Api

```csharp
public class AppDataApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppDataApi](./dataforseo.client.api.appdataapi)

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

### **AppDataApi(HttpClient)**

```csharp
public AppDataApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **AppDataIdListAsync(IEnumerable&lt;AppDataIdListRequestInfo&gt;)**

```csharp
public Task<AppDataIdListResponseInfo> AppDataIdListAsync(IEnumerable<AppDataIdListRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataIdListRequestInfo&gt;](./dataforseo.client.models.requests.appdataidlistrequestinfo)<br>

#### Returns

[Task&lt;AppDataIdListResponseInfo&gt;](./dataforseo.client.models.responses.appdataidlistresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed App Data tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/id_list/?bash'

### **AppDataIdListAsync(IEnumerable&lt;AppDataIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataIdListResponseInfo> AppDataIdListAsync(IEnumerable<AppDataIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataIdListRequestInfo&gt;](./dataforseo.client.models.requests.appdataidlistrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataIdListResponseInfo&gt;](./dataforseo.client.models.responses.appdataidlistresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed App Data tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/id_list/?bash'

### **AppDataErrorsAsync(IEnumerable&lt;AppDataErrorsRequestInfo&gt;)**

```csharp
public Task<AppDataErrorsResponseInfo> AppDataErrorsAsync(IEnumerable<AppDataErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataErrorsRequestInfo&gt;](./dataforseo.client.models.requests.appdataerrorsrequestinfo)<br>

#### Returns

[Task&lt;AppDataErrorsResponseInfo&gt;](./dataforseo.client.models.responses.appdataerrorsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the App Data API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/errors/?bash'

### **AppDataErrorsAsync(IEnumerable&lt;AppDataErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataErrorsResponseInfo> AppDataErrorsAsync(IEnumerable<AppDataErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataErrorsRequestInfo&gt;](./dataforseo.client.models.requests.appdataerrorsrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataErrorsResponseInfo&gt;](./dataforseo.client.models.responses.appdataerrorsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the App Data API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/errors/?bash'

### **GoogleCategoriesAsync()**

```csharp
public Task<AppDataGoogleCategoriesResponseInfo> GoogleCategoriesAsync()
```

#### Returns

[Task&lt;AppDataGoogleCategoriesResponseInfo&gt;](./dataforseo.client.models.responses.appdatagooglecategoriesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a full list of app categories available on Google Play.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/categories/?bash'

### **GoogleCategoriesAsync(CancellationToken)**

```csharp
public Task<AppDataGoogleCategoriesResponseInfo> GoogleCategoriesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleCategoriesResponseInfo&gt;](./dataforseo.client.models.responses.appdatagooglecategoriesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a full list of app categories available on Google Play.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/categories/?bash'

### **AppDataGoogleLocationsAsync()**

```csharp
public Task<AppDataGoogleLocationsResponseInfo> AppDataGoogleLocationsAsync()
```

#### Returns

[Task&lt;AppDataGoogleLocationsResponseInfo&gt;](./dataforseo.client.models.responses.appdatagooglelocationsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive the list of Google locations supported in App Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/locations/?bash'

### **AppDataGoogleLocationsAsync(CancellationToken)**

```csharp
public Task<AppDataGoogleLocationsResponseInfo> AppDataGoogleLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleLocationsResponseInfo&gt;](./dataforseo.client.models.responses.appdatagooglelocationsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive the list of Google locations supported in App Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/locations/?bash'

### **AppDataGoogleLanguagesAsync()**

```csharp
public Task<AppDataGoogleLanguagesResponseInfo> AppDataGoogleLanguagesAsync()
```

#### Returns

[Task&lt;AppDataGoogleLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.appdatagooglelanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive the list of Google languages supported in App Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/languages/?bash'

### **AppDataGoogleLanguagesAsync(CancellationToken)**

```csharp
public Task<AppDataGoogleLanguagesResponseInfo> AppDataGoogleLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.appdatagooglelanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive the list of Google languages supported in App Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/languages/?bash'

### **GoogleAppSearchesTaskPostAsync(IEnumerable&lt;AppDataTaskRequestInfo&gt;)**

```csharp
public Task<AppDataGoogleAppSearchesTaskPostResponseInfo> GoogleAppSearchesTaskPostAsync(IEnumerable<AppDataTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataTaskRequestInfo&gt;](./dataforseo.client.models.requests.appdatataskrequestinfo)<br>

#### Returns

[Task&lt;AppDataGoogleAppSearchesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappsearchestaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of apps ranking on Google Play for the specified keyword. The returned results are specific to the indicated keyword, as well as the language and location parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_searches/task_post/?bash'

### **GoogleAppSearchesTaskPostAsync(IEnumerable&lt;AppDataTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataGoogleAppSearchesTaskPostResponseInfo> GoogleAppSearchesTaskPostAsync(IEnumerable<AppDataTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataTaskRequestInfo&gt;](./dataforseo.client.models.requests.appdatataskrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppSearchesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappsearchestaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of apps ranking on Google Play for the specified keyword. The returned results are specific to the indicated keyword, as well as the language and location parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_searches/task_post/?bash'

### **GoogleAppSearchesTasksReadyAsync()**

```csharp
public Task<AppDataGoogleAppSearchesTasksReadyResponseInfo> GoogleAppSearchesTasksReadyAsync()
```

#### Returns

[Task&lt;AppDataGoogleAppSearchesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappsearchestasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_searches/tasks_ready/?bash'

### **GoogleAppSearchesTasksReadyAsync(CancellationToken)**

```csharp
public Task<AppDataGoogleAppSearchesTasksReadyResponseInfo> GoogleAppSearchesTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppSearchesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappsearchestasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_searches/tasks_ready/?bash'

### **GoogleAppSearchesTaskGetAdvancedAsync(String)**

```csharp
public Task<AppDataGoogleAppSearchesTaskGetAdvancedResponseInfo> GoogleAppSearchesTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataGoogleAppSearchesTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappsearchestaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of apps ranking on Google Play for the keyword specified in a POST request. You will also receive additional information about each application: its ID, icon, reviews count, rating, price, and other data. The results are specific to the keyword as well as location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_searches/task_get/advanced/?bash'

### **GoogleAppSearchesTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<AppDataGoogleAppSearchesTaskGetAdvancedResponseInfo> GoogleAppSearchesTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppSearchesTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappsearchestaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of apps ranking on Google Play for the keyword specified in a POST request. You will also receive additional information about each application: its ID, icon, reviews count, rating, price, and other data. The results are specific to the keyword as well as location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_searches/task_get/advanced/?bash'

### **GoogleAppSearchesTaskGetHtmlAsync(String)**

```csharp
public Task<AppDataGoogleAppSearchesTaskGetHtmlResponseInfo> GoogleAppSearchesTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataGoogleAppSearchesTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappsearchestaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_searches/task_get/html/?bash'

### **GoogleAppSearchesTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<AppDataGoogleAppSearchesTaskGetHtmlResponseInfo> GoogleAppSearchesTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppSearchesTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappsearchestaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_searches/task_get/html/?bash'

### **GoogleAppListTaskPostAsync(IEnumerable&lt;AppDataGoogleAppListTaskPostRequestInfo&gt;)**

```csharp
public Task<AppDataGoogleAppListTaskPostResponseInfo> GoogleAppListTaskPostAsync(IEnumerable<AppDataGoogleAppListTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataGoogleAppListTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdatagoogleapplisttaskpostrequestinfo)<br>

#### Returns

[Task&lt;AppDataGoogleAppListTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplisttaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of mobile applications published in the top charts on the Google Play platform. The returned results are specific to the app collection as well as the the language and location parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_list/task_post/?bash'

### **GoogleAppListTaskPostAsync(IEnumerable&lt;AppDataGoogleAppListTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataGoogleAppListTaskPostResponseInfo> GoogleAppListTaskPostAsync(IEnumerable<AppDataGoogleAppListTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataGoogleAppListTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdatagoogleapplisttaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppListTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplisttaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of mobile applications published in the top charts on the Google Play platform. The returned results are specific to the app collection as well as the the language and location parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_list/task_post/?bash'

### **GoogleAppListTasksReadyAsync()**

```csharp
public Task<AppDataGoogleAppListTasksReadyResponseInfo> GoogleAppListTasksReadyAsync()
```

#### Returns

[Task&lt;AppDataGoogleAppListTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplisttasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_list/tasks_ready/?bash'

### **GoogleAppListTasksReadyAsync(CancellationToken)**

```csharp
public Task<AppDataGoogleAppListTasksReadyResponseInfo> GoogleAppListTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppListTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplisttasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_list/tasks_ready/?bash'

### **GoogleAppListTaskGetAdvancedAsync(String)**

```csharp
public Task<AppDataGoogleAppListTaskGetAdvancedResponseInfo> GoogleAppListTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataGoogleAppListTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplisttaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of applications published in the top charts on the Google Play platform, including app IDs, ratings, prices, titles, and more. The results are specific to the app_collection as well as the location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_list/task_get/advanced/?bash'

### **GoogleAppListTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<AppDataGoogleAppListTaskGetAdvancedResponseInfo> GoogleAppListTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppListTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplisttaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of applications published in the top charts on the Google Play platform, including app IDs, ratings, prices, titles, and more. The results are specific to the app_collection as well as the location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_list/task_get/advanced/?bash'

### **GoogleAppListTaskGetHtmlAsync(String)**

```csharp
public Task<AppDataGoogleAppListTaskGetHtmlResponseInfo> GoogleAppListTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataGoogleAppListTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplisttaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_list/task_get/html/?bash'

### **GoogleAppListTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<AppDataGoogleAppListTaskGetHtmlResponseInfo> GoogleAppListTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppListTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplisttaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_list/task_get/html/?bash'

### **GoogleAppInfoTaskPostAsync(IEnumerable&lt;AppDataGoogleAppInfoTaskPostRequestInfo&gt;)**

```csharp
public Task<AppDataGoogleAppInfoTaskPostResponseInfo> GoogleAppInfoTaskPostAsync(IEnumerable<AppDataGoogleAppInfoTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataGoogleAppInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdatagoogleappinfotaskpostrequestinfo)<br>

#### Returns

[Task&lt;AppDataGoogleAppInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappinfotaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with information about the Google Play application specified in the app_id field of the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_info/task_post/?bash'

### **GoogleAppInfoTaskPostAsync(IEnumerable&lt;AppDataGoogleAppInfoTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataGoogleAppInfoTaskPostResponseInfo> GoogleAppInfoTaskPostAsync(IEnumerable<AppDataGoogleAppInfoTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataGoogleAppInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdatagoogleappinfotaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappinfotaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with information about the Google Play application specified in the app_id field of the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_info/task_post/?bash'

### **GoogleAppInfoTasksReadyAsync()**

```csharp
public Task<AppDataGoogleAppInfoTasksReadyResponseInfo> GoogleAppInfoTasksReadyAsync()
```

#### Returns

[Task&lt;AppDataGoogleAppInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappinfotasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_info/tasks_ready/?bash'

### **GoogleAppInfoTasksReadyAsync(CancellationToken)**

```csharp
public Task<AppDataGoogleAppInfoTasksReadyResponseInfo> GoogleAppInfoTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappinfotasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_info/tasks_ready/?bash'

### **GoogleAppInfoTaskGetAdvancedAsync(String)**

```csharp
public Task<AppDataGoogleAppInfoTaskGetAdvancedResponseInfo> GoogleAppInfoTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataGoogleAppInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappinfotaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with information about the mobile application specified in a POST request. You will receive its ID, icon, description, reviews count, rating, number of installs, images, and other data. The results are specific to the app_id parameter specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_info/task_get/advanced/?bash'

### **GoogleAppInfoTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<AppDataGoogleAppInfoTaskGetAdvancedResponseInfo> GoogleAppInfoTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappinfotaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with information about the mobile application specified in a POST request. You will receive its ID, icon, description, reviews count, rating, number of installs, images, and other data. The results are specific to the app_id parameter specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_info/task_get/advanced/?bash'

### **GoogleAppInfoTaskGetHtmlAsync(String)**

```csharp
public Task<AppDataGoogleAppInfoTaskGetHtmlResponseInfo> GoogleAppInfoTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataGoogleAppInfoTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappinfotaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_info/task_get/html/?bash'

### **GoogleAppInfoTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<AppDataGoogleAppInfoTaskGetHtmlResponseInfo> GoogleAppInfoTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppInfoTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappinfotaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_info/task_get/html/?bash'

### **GoogleAppReviewsTaskPostAsync(IEnumerable&lt;AppDataGoogleAppReviewsTaskPostRequestInfo&gt;)**

```csharp
public Task<AppDataGoogleAppReviewsTaskPostResponseInfo> GoogleAppReviewsTaskPostAsync(IEnumerable<AppDataGoogleAppReviewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataGoogleAppReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdatagoogleappreviewstaskpostrequestinfo)<br>

#### Returns

[Task&lt;AppDataGoogleAppReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappreviewstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with reviews published on the Google Play platform for the app specified in the app_id field. The returned results are specific to the indicated language and location parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_reviews/task_post/?bash'

### **GoogleAppReviewsTaskPostAsync(IEnumerable&lt;AppDataGoogleAppReviewsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataGoogleAppReviewsTaskPostResponseInfo> GoogleAppReviewsTaskPostAsync(IEnumerable<AppDataGoogleAppReviewsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataGoogleAppReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdatagoogleappreviewstaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappreviewstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with reviews published on the Google Play platform for the app specified in the app_id field. The returned results are specific to the indicated language and location parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_reviews/task_post/?bash'

### **GoogleAppReviewsTasksReadyAsync()**

```csharp
public Task<AppDataGoogleAppReviewsTasksReadyResponseInfo> GoogleAppReviewsTasksReadyAsync()
```

#### Returns

[Task&lt;AppDataGoogleAppReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappreviewstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_reviews/tasks_ready/?bash'

### **GoogleAppReviewsTasksReadyAsync(CancellationToken)**

```csharp
public Task<AppDataGoogleAppReviewsTasksReadyResponseInfo> GoogleAppReviewsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappreviewstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_reviews/tasks_ready/?bash'

### **GoogleAppReviewsTaskGetAdvancedAsync(String)**

```csharp
public Task<AppDataGoogleAppReviewsTaskGetAdvancedResponseInfo> GoogleAppReviewsTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataGoogleAppReviewsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappreviewstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with feedback data on applications listed on the Google Play platform, including review ratings, review content, user profile info of each reviewer, review publication dates, and more. The results are specific to the app_id as well as the location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_reviews/task_get/advanced/?bash'

### **GoogleAppReviewsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<AppDataGoogleAppReviewsTaskGetAdvancedResponseInfo> GoogleAppReviewsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppReviewsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappreviewstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with feedback data on applications listed on the Google Play platform, including review ratings, review content, user profile info of each reviewer, review publication dates, and more. The results are specific to the app_id as well as the location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_reviews/task_get/advanced/?bash'

### **GoogleAppReviewsTaskGetHtmlAsync(String)**

```csharp
public Task<AppDataGoogleAppReviewsTaskGetHtmlResponseInfo> GoogleAppReviewsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataGoogleAppReviewsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappreviewstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_reviews/task_get/html/?bash'

### **GoogleAppReviewsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<AppDataGoogleAppReviewsTaskGetHtmlResponseInfo> GoogleAppReviewsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppReviewsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleappreviewstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_reviews/task_get/html/?bash'

### **GoogleAppListingsCategoriesAsync()**

```csharp
public Task<AppDataGoogleAppListingsCategoriesResponseInfo> GoogleAppListingsCategoriesAsync()
```

#### Returns

[Task&lt;AppDataGoogleAppListingsCategoriesResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplistingscategoriesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a full list of app categories available on Google Play.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_listings/categories/?bash'

### **GoogleAppListingsCategoriesAsync(CancellationToken)**

```csharp
public Task<AppDataGoogleAppListingsCategoriesResponseInfo> GoogleAppListingsCategoriesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppListingsCategoriesResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplistingscategoriesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a full list of app categories available on Google Play.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_listings/categories/?bash'

### **GoogleAppListingsSearchLiveAsync(IEnumerable&lt;AppDataGoogleAppListingsSearchLiveRequestInfo&gt;)**

```csharp
public Task<AppDataGoogleAppListingsSearchLiveResponseInfo> GoogleAppListingsSearchLiveAsync(IEnumerable<AppDataGoogleAppListingsSearchLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataGoogleAppListingsSearchLiveRequestInfo&gt;](./dataforseo.client.models.requests.appdatagoogleapplistingssearchliverequestinfo)<br>

#### Returns

[Task&lt;AppDataGoogleAppListingsSearchLiveResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplistingssearchliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of apps published on Google Play along with additional information: its ID, icon, reviews count, rating, price, and other data. The results are specific to the title, description, and categories parameters specified in the API request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_listings/search/live/?bash'

### **GoogleAppListingsSearchLiveAsync(IEnumerable&lt;AppDataGoogleAppListingsSearchLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataGoogleAppListingsSearchLiveResponseInfo> GoogleAppListingsSearchLiveAsync(IEnumerable<AppDataGoogleAppListingsSearchLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataGoogleAppListingsSearchLiveRequestInfo&gt;](./dataforseo.client.models.requests.appdatagoogleapplistingssearchliverequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataGoogleAppListingsSearchLiveResponseInfo&gt;](./dataforseo.client.models.responses.appdatagoogleapplistingssearchliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of apps published on Google Play along with additional information: its ID, icon, reviews count, rating, price, and other data. The results are specific to the title, description, and categories parameters specified in the API request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/google/app_listings/search/live/?bash'

### **AppleCategoriesAsync()**

```csharp
public Task<AppDataAppleCategoriesResponseInfo> AppleCategoriesAsync()
```

#### Returns

[Task&lt;AppDataAppleCategoriesResponseInfo&gt;](./dataforseo.client.models.responses.appdataapplecategoriesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a full list of app categories available on App Store.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/categories/?bash'

### **AppleCategoriesAsync(CancellationToken)**

```csharp
public Task<AppDataAppleCategoriesResponseInfo> AppleCategoriesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleCategoriesResponseInfo&gt;](./dataforseo.client.models.responses.appdataapplecategoriesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a full list of app categories available on App Store.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/categories/?bash'

### **AppDataAppleLocationsAsync()**

```csharp
public Task<AppDataAppleLocationsResponseInfo> AppDataAppleLocationsAsync()
```

#### Returns

[Task&lt;AppDataAppleLocationsResponseInfo&gt;](./dataforseo.client.models.responses.appdataapplelocationsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive the list of Apple locations supported in App Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/locations/?bash'

### **AppDataAppleLocationsAsync(CancellationToken)**

```csharp
public Task<AppDataAppleLocationsResponseInfo> AppDataAppleLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleLocationsResponseInfo&gt;](./dataforseo.client.models.responses.appdataapplelocationsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive the list of Apple locations supported in App Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/locations/?bash'

### **AppDataAppleLanguagesAsync()**

```csharp
public Task<AppDataAppleLanguagesResponseInfo> AppDataAppleLanguagesAsync()
```

#### Returns

[Task&lt;AppDataAppleLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.appdataapplelanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive the list of Apple languages supported in App Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/languages/?bash'

### **AppDataAppleLanguagesAsync(CancellationToken)**

```csharp
public Task<AppDataAppleLanguagesResponseInfo> AppDataAppleLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.appdataapplelanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive the list of Apple languages supported in App Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/languages/?bash'

### **AppleAppSearchesTaskPostAsync(IEnumerable&lt;AppDataTaskRequestInfo&gt;)**

```csharp
public Task<AppDataAppleAppSearchesTaskPostResponseInfo> AppleAppSearchesTaskPostAsync(IEnumerable<AppDataTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataTaskRequestInfo&gt;](./dataforseo.client.models.requests.appdatataskrequestinfo)<br>

#### Returns

[Task&lt;AppDataAppleAppSearchesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappsearchestaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of apps ranking on the App Store for the specified keyword. The returned results are specific to the indicated keyword, as well as the location and language parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_searches/task_post/?bash'

### **AppleAppSearchesTaskPostAsync(IEnumerable&lt;AppDataTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataAppleAppSearchesTaskPostResponseInfo> AppleAppSearchesTaskPostAsync(IEnumerable<AppDataTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataTaskRequestInfo&gt;](./dataforseo.client.models.requests.appdatataskrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppSearchesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappsearchestaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of apps ranking on the App Store for the specified keyword. The returned results are specific to the indicated keyword, as well as the location and language parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_searches/task_post/?bash'

### **AppleAppSearchesTasksReadyAsync()**

```csharp
public Task<AppDataAppleAppSearchesTasksReadyResponseInfo> AppleAppSearchesTasksReadyAsync()
```

#### Returns

[Task&lt;AppDataAppleAppSearchesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappsearchestasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_searches/tasks_ready/?bash'

### **AppleAppSearchesTasksReadyAsync(CancellationToken)**

```csharp
public Task<AppDataAppleAppSearchesTasksReadyResponseInfo> AppleAppSearchesTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppSearchesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappsearchestasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_searches/tasks_ready/?bash'

### **AppleAppSearchesTaskGetAdvancedAsync(String)**

```csharp
public Task<AppDataAppleAppSearchesTaskGetAdvancedResponseInfo> AppleAppSearchesTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataAppleAppSearchesTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappsearchestaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of apps ranking on the App Store for the keyword specified in a POST request. You will also receive additional information about each application: its ID, icon, reviews count, rating, price, and other data. The results are specific to the keyword as well as location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_searches/task_get/advanced/?bash'

### **AppleAppSearchesTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<AppDataAppleAppSearchesTaskGetAdvancedResponseInfo> AppleAppSearchesTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppSearchesTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappsearchestaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of apps ranking on the App Store for the keyword specified in a POST request. You will also receive additional information about each application: its ID, icon, reviews count, rating, price, and other data. The results are specific to the keyword as well as location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_searches/task_get/advanced/?bash'

### **AppleAppInfoTaskPostAsync(IEnumerable&lt;AppDataAppleAppInfoTaskPostRequestInfo&gt;)**

```csharp
public Task<AppDataAppleAppInfoTaskPostResponseInfo> AppleAppInfoTaskPostAsync(IEnumerable<AppDataAppleAppInfoTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataAppleAppInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdataappleappinfotaskpostrequestinfo)<br>

#### Returns

[Task&lt;AppDataAppleAppInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappinfotaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with information about the App Store application specified in the app_id field of the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_info/task_post/?bash'

### **AppleAppInfoTaskPostAsync(IEnumerable&lt;AppDataAppleAppInfoTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataAppleAppInfoTaskPostResponseInfo> AppleAppInfoTaskPostAsync(IEnumerable<AppDataAppleAppInfoTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataAppleAppInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdataappleappinfotaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappinfotaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with information about the App Store application specified in the app_id field of the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_info/task_post/?bash'

### **AppleAppInfoTasksReadyAsync()**

```csharp
public Task<AppDataAppleAppInfoTasksReadyResponseInfo> AppleAppInfoTasksReadyAsync()
```

#### Returns

[Task&lt;AppDataAppleAppInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappinfotasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_info/tasks_ready/?bash'

### **AppleAppInfoTasksReadyAsync(CancellationToken)**

```csharp
public Task<AppDataAppleAppInfoTasksReadyResponseInfo> AppleAppInfoTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappinfotasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_info/tasks_ready/?bash'

### **AppleAppInfoTaskGetAdvancedAsync(String)**

```csharp
public Task<AppDataAppleAppInfoTaskGetAdvancedResponseInfo> AppleAppInfoTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataAppleAppInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappinfotaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with information about the mobile application specified in a POST request. You will receive its ID, icon, description, reviews count, rating, images, and other data. The results are specific to the app_id parameter specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_info/task_get/advanced/?bash'

### **AppleAppInfoTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<AppDataAppleAppInfoTaskGetAdvancedResponseInfo> AppleAppInfoTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappinfotaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with information about the mobile application specified in a POST request. You will receive its ID, icon, description, reviews count, rating, images, and other data. The results are specific to the app_id parameter specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_info/task_get/advanced/?bash'

### **AppleAppListTaskPostAsync(IEnumerable&lt;AppDataAppleAppListTaskPostRequestInfo&gt;)**

```csharp
public Task<AppDataAppleAppListTaskPostResponseInfo> AppleAppListTaskPostAsync(IEnumerable<AppDataAppleAppListTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataAppleAppListTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdataappleapplisttaskpostrequestinfo)<br>

#### Returns

[Task&lt;AppDataAppleAppListTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleapplisttaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of mobile applications published in the top app charts on the App Store platform. The returned results are specific to the app collection as well as the language and location parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_list/task_post/?bash'

### **AppleAppListTaskPostAsync(IEnumerable&lt;AppDataAppleAppListTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataAppleAppListTaskPostResponseInfo> AppleAppListTaskPostAsync(IEnumerable<AppDataAppleAppListTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataAppleAppListTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdataappleapplisttaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppListTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleapplisttaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of mobile applications published in the top app charts on the App Store platform. The returned results are specific to the app collection as well as the language and location parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_list/task_post/?bash'

### **AppleAppListTasksReadyAsync()**

```csharp
public Task<AppDataAppleAppListTasksReadyResponseInfo> AppleAppListTasksReadyAsync()
```

#### Returns

[Task&lt;AppDataAppleAppListTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleapplisttasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_list/tasks_ready/?bash'

### **AppleAppListTasksReadyAsync(CancellationToken)**

```csharp
public Task<AppDataAppleAppListTasksReadyResponseInfo> AppleAppListTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppListTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleapplisttasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_list/tasks_ready/?bash'

### **AppleAppListTaskGetAdvancedAsync(String)**

```csharp
public Task<AppDataAppleAppListTaskGetAdvancedResponseInfo> AppleAppListTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataAppleAppListTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleapplisttaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of applications published in the top app charts on the App Store platform, including app IDs, ratings, prices, titles, and more. The results are specific to the app_collection as well as the location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_list/task_get/advanced/?bash'

### **AppleAppListTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<AppDataAppleAppListTaskGetAdvancedResponseInfo> AppleAppListTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppListTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleapplisttaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of applications published in the top app charts on the App Store platform, including app IDs, ratings, prices, titles, and more. The results are specific to the app_collection as well as the location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_list/task_get/advanced/?bash'

### **AppleAppReviewsTaskPostAsync(IEnumerable&lt;AppDataAppleAppReviewsTaskPostRequestInfo&gt;)**

```csharp
public Task<AppDataAppleAppReviewsTaskPostResponseInfo> AppleAppReviewsTaskPostAsync(IEnumerable<AppDataAppleAppReviewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataAppleAppReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdataappleappreviewstaskpostrequestinfo)<br>

#### Returns

[Task&lt;AppDataAppleAppReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappreviewstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with reviews published on the App Store platform for the app specified in the app_id field. The returned results are specific to the indicated language and location parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_reviews/task_post/?bash'

### **AppleAppReviewsTaskPostAsync(IEnumerable&lt;AppDataAppleAppReviewsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataAppleAppReviewsTaskPostResponseInfo> AppleAppReviewsTaskPostAsync(IEnumerable<AppDataAppleAppReviewsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataAppleAppReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.appdataappleappreviewstaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappreviewstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with reviews published on the App Store platform for the app specified in the app_id field. The returned results are specific to the indicated language and location parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_reviews/task_post/?bash'

### **AppleAppReviewsTasksReadyAsync()**

```csharp
public Task<AppDataAppleAppReviewsTasksReadyResponseInfo> AppleAppReviewsTasksReadyAsync()
```

#### Returns

[Task&lt;AppDataAppleAppReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappreviewstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_reviews/tasks_ready/?bash'

### **AppleAppReviewsTasksReadyAsync(CancellationToken)**

```csharp
public Task<AppDataAppleAppReviewsTasksReadyResponseInfo> AppleAppReviewsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappreviewstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_reviews/tasks_ready/?bash'

### **AppleAppReviewsTaskGetAdvancedAsync(String)**

```csharp
public Task<AppDataAppleAppReviewsTaskGetAdvancedResponseInfo> AppleAppReviewsTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;AppDataAppleAppReviewsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappreviewstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with feedback data on applications listed on the App Store platform, including review ratings, review content, user profile info of each reviewer, review publication dates, and more. The results are specific to the app_id as well as the location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_reviews/task_get/advanced/?bash'

### **AppleAppReviewsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<AppDataAppleAppReviewsTaskGetAdvancedResponseInfo> AppleAppReviewsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppReviewsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleappreviewstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with feedback data on applications listed on the App Store platform, including review ratings, review content, user profile info of each reviewer, review publication dates, and more. The results are specific to the app_id as well as the location and language parameters specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_reviews/task_get/advanced/?bash'

### **AppleAppListingsCategoriesAsync()**

```csharp
public Task<AppDataAppleAppListingsCategoriesResponseInfo> AppleAppListingsCategoriesAsync()
```

#### Returns

[Task&lt;AppDataAppleAppListingsCategoriesResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleapplistingscategoriesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a full list of app categories available on Apple App Store.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_listings/categories/?bash'

### **AppleAppListingsCategoriesAsync(CancellationToken)**

```csharp
public Task<AppDataAppleAppListingsCategoriesResponseInfo> AppleAppListingsCategoriesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppListingsCategoriesResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleapplistingscategoriesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a full list of app categories available on Apple App Store.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_listings/categories/?bash'

### **AppleAppListingsSearchLiveAsync(IEnumerable&lt;AppDataAppleAppListingsSearchLiveRequestInfo&gt;)**

```csharp
public Task<AppDataAppleAppListingsSearchLiveResponseInfo> AppleAppListingsSearchLiveAsync(IEnumerable<AppDataAppleAppListingsSearchLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppDataAppleAppListingsSearchLiveRequestInfo&gt;](./dataforseo.client.models.requests.appdataappleapplistingssearchliverequestinfo)<br>

#### Returns

[Task&lt;AppDataAppleAppListingsSearchLiveResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleapplistingssearchliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of apps published on App Store along with additional information: its ID, icon, reviews count, rating, price, and other data. The results are specific to the title, description, and categories parameters specified in the API request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_listings/search/live/?bash'

### **AppleAppListingsSearchLiveAsync(IEnumerable&lt;AppDataAppleAppListingsSearchLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppDataAppleAppListingsSearchLiveResponseInfo> AppleAppListingsSearchLiveAsync(IEnumerable<AppDataAppleAppListingsSearchLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppDataAppleAppListingsSearchLiveRequestInfo&gt;](./dataforseo.client.models.requests.appdataappleapplistingssearchliverequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppDataAppleAppListingsSearchLiveResponseInfo&gt;](./dataforseo.client.models.responses.appdataappleapplistingssearchliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with a list of apps published on App Store along with additional information: its ID, icon, reviews count, rating, price, and other data. The results are specific to the title, description, and categories parameters specified in the API request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/app_data/apple/app_listings/search/live/?bash'

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
