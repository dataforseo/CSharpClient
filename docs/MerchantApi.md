# MerchantApi

Namespace: DataForSeo.Client.Api

```csharp
public class MerchantApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/Object) → [MerchantApi](./MerchantApi.md)

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

### **MerchantApi(HttpClient)**

```csharp
public MerchantApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **MerchantIdListAsync(IEnumerable&lt;MerchantIdListRequestInfo&gt;)**

```csharp
public Task<MerchantIdListResponseInfo> MerchantIdListAsync(IEnumerable<MerchantIdListRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantIdListRequestInfo&gt;](./MerchantIdListRequestInfo.md)<br>

#### Returns

[Task&lt;MerchantIdListResponseInfo&gt;](./MerchantIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Merchant tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/id_list/?bash'

### **MerchantIdListAsync(IEnumerable&lt;MerchantIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantIdListResponseInfo> MerchantIdListAsync(IEnumerable<MerchantIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantIdListRequestInfo&gt;](./MerchantIdListRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantIdListResponseInfo&gt;](./MerchantIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Merchant tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/id_list/?bash'

### **MerchantErrorsAsync(IEnumerable&lt;MerchantErrorsRequestInfo&gt;)**

```csharp
public Task<MerchantErrorsResponseInfo> MerchantErrorsAsync(IEnumerable<MerchantErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantErrorsRequestInfo&gt;](./MerchantErrorsRequestInfo.md)<br>

#### Returns

[Task&lt;MerchantErrorsResponseInfo&gt;](./MerchantErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Merchant API tasks that returned an error within the past 7 days.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/errors/?bash'

### **MerchantErrorsAsync(IEnumerable&lt;MerchantErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantErrorsResponseInfo> MerchantErrorsAsync(IEnumerable<MerchantErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantErrorsRequestInfo&gt;](./MerchantErrorsRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantErrorsResponseInfo&gt;](./MerchantErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Merchant API tasks that returned an error within the past 7 days.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/errors/?bash'

### **MerchantGoogleLanguagesAsync()**

```csharp
public Task<MerchantGoogleLanguagesResponseInfo> MerchantGoogleLanguagesAsync()
```

#### Returns

[Task&lt;MerchantGoogleLanguagesResponseInfo&gt;](./MerchantGoogleLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Google Shopping languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/languages/?bash'

### **MerchantGoogleLanguagesAsync(CancellationToken)**

```csharp
public Task<MerchantGoogleLanguagesResponseInfo> MerchantGoogleLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleLanguagesResponseInfo&gt;](./MerchantGoogleLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Google Shopping languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/languages/?bash'

### **MerchantGoogleLocationsAsync()**

```csharp
public Task<MerchantGoogleLocationsResponseInfo> MerchantGoogleLocationsAsync()
```

#### Returns

[Task&lt;MerchantGoogleLocationsResponseInfo&gt;](./MerchantGoogleLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'

### **MerchantGoogleLocationsAsync(CancellationToken)**

```csharp
public Task<MerchantGoogleLocationsResponseInfo> MerchantGoogleLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleLocationsResponseInfo&gt;](./MerchantGoogleLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'

### **MerchantGoogleLocationsCountryAsync(String)**

```csharp
public Task<MerchantGoogleLocationsCountryResponseInfo> MerchantGoogleLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;MerchantGoogleLocationsCountryResponseInfo&gt;](./MerchantGoogleLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'

### **MerchantGoogleLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleLocationsCountryResponseInfo> MerchantGoogleLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;MerchantGoogleLocationsCountryResponseInfo&gt;](./MerchantGoogleLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'

### **GoogleProductsTaskPostAsync(IEnumerable&lt;MerchantGoogleProductsTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantGoogleProductsTaskPostResponseInfo> GoogleProductsTaskPostAsync(IEnumerable<MerchantGoogleProductsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantGoogleProductsTaskPostRequestInfo&gt;](./MerchantGoogleProductsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;MerchantGoogleProductsTaskPostResponseInfo&gt;](./MerchantGoogleProductsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Shopping Products endpoint will provide you with the list of products found on Google Shopping for the specified query. The results include product title, description in Google Shopping SERP, product rank, price, reviews and rating as well as the related domain.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_post/?bash'

### **GoogleProductsTaskPostAsync(IEnumerable&lt;MerchantGoogleProductsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantGoogleProductsTaskPostResponseInfo> GoogleProductsTaskPostAsync(IEnumerable<MerchantGoogleProductsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantGoogleProductsTaskPostRequestInfo&gt;](./MerchantGoogleProductsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductsTaskPostResponseInfo&gt;](./MerchantGoogleProductsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Shopping Products endpoint will provide you with the list of products found on Google Shopping for the specified query. The results include product title, description in Google Shopping SERP, product rank, price, reviews and rating as well as the related domain.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_post/?bash'

### **GoogleProductsTasksReadyAsync()**

```csharp
public Task<MerchantGoogleProductsTasksReadyResponseInfo> GoogleProductsTasksReadyAsync()
```

#### Returns

[Task&lt;MerchantGoogleProductsTasksReadyResponseInfo&gt;](./MerchantGoogleProductsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/tasks_ready/?bash'

### **GoogleProductsTasksReadyAsync(CancellationToken)**

```csharp
public Task<MerchantGoogleProductsTasksReadyResponseInfo> GoogleProductsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductsTasksReadyResponseInfo&gt;](./MerchantGoogleProductsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/tasks_ready/?bash'

### **MerchantTasksReadyAsync()**

```csharp
public Task<MerchantTasksReadyResponseInfo> MerchantTasksReadyAsync()
```

#### Returns

[Task&lt;MerchantTasksReadyResponseInfo&gt;](./MerchantTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/tasks_ready/?bash'

### **MerchantTasksReadyAsync(CancellationToken)**

```csharp
public Task<MerchantTasksReadyResponseInfo> MerchantTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantTasksReadyResponseInfo&gt;](./MerchantTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/tasks_ready/?bash'

### **GoogleProductsTaskGetAdvancedAsync(String)**

```csharp
public Task<MerchantGoogleProductsTaskGetAdvancedResponseInfo> GoogleProductsTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleProductsTaskGetAdvancedResponseInfo&gt;](./MerchantGoogleProductsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/advanced/?bash'

### **GoogleProductsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleProductsTaskGetAdvancedResponseInfo> GoogleProductsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductsTaskGetAdvancedResponseInfo&gt;](./MerchantGoogleProductsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/advanced/?bash'

### **GoogleProductsTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantGoogleProductsTaskGetHtmlResponseInfo> GoogleProductsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleProductsTaskGetHtmlResponseInfo&gt;](./MerchantGoogleProductsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/html/?bash'

### **GoogleProductsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleProductsTaskGetHtmlResponseInfo> GoogleProductsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductsTaskGetHtmlResponseInfo&gt;](./MerchantGoogleProductsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/html/?bash'

### **GoogleSellersTaskPostAsync(IEnumerable&lt;MerchantGoogleSellersTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantGoogleSellersTaskPostResponseInfo> GoogleSellersTaskPostAsync(IEnumerable<MerchantGoogleSellersTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantGoogleSellersTaskPostRequestInfo&gt;](./MerchantGoogleSellersTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;MerchantGoogleSellersTaskPostResponseInfo&gt;](./MerchantGoogleSellersTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Shopping Sellers endpoint will provide you with the list of sellers that listed the specified product on Google Shopping. The provided data for each seller includes related product base and total price, shipment and purchase details and special offers. The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_post/?bash'

### **GoogleSellersTaskPostAsync(IEnumerable&lt;MerchantGoogleSellersTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantGoogleSellersTaskPostResponseInfo> GoogleSellersTaskPostAsync(IEnumerable<MerchantGoogleSellersTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantGoogleSellersTaskPostRequestInfo&gt;](./MerchantGoogleSellersTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleSellersTaskPostResponseInfo&gt;](./MerchantGoogleSellersTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Shopping Sellers endpoint will provide you with the list of sellers that listed the specified product on Google Shopping. The provided data for each seller includes related product base and total price, shipment and purchase details and special offers. The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_post/?bash'

### **GoogleSellersTasksReadyAsync()**

```csharp
public Task<MerchantGoogleSellersTasksReadyResponseInfo> GoogleSellersTasksReadyAsync()
```

#### Returns

[Task&lt;MerchantGoogleSellersTasksReadyResponseInfo&gt;](./MerchantGoogleSellersTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/tasks_ready/?bash'

### **GoogleSellersTasksReadyAsync(CancellationToken)**

```csharp
public Task<MerchantGoogleSellersTasksReadyResponseInfo> GoogleSellersTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleSellersTasksReadyResponseInfo&gt;](./MerchantGoogleSellersTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/tasks_ready/?bash'

### **GoogleSellersTaskGetAdvancedAsync(String)**

```csharp
public Task<MerchantGoogleSellersTaskGetAdvancedResponseInfo> GoogleSellersTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleSellersTaskGetAdvancedResponseInfo&gt;](./MerchantGoogleSellersTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/advanced/?bash'

### **GoogleSellersTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleSellersTaskGetAdvancedResponseInfo> GoogleSellersTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleSellersTaskGetAdvancedResponseInfo&gt;](./MerchantGoogleSellersTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/advanced/?bash'

### **GoogleSellersTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantGoogleSellersTaskGetHtmlResponseInfo> GoogleSellersTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleSellersTaskGetHtmlResponseInfo&gt;](./MerchantGoogleSellersTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/html/?bash'

### **GoogleSellersTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleSellersTaskGetHtmlResponseInfo> GoogleSellersTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleSellersTaskGetHtmlResponseInfo&gt;](./MerchantGoogleSellersTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/html/?bash'

### **GoogleProductSpecTaskPostAsync(IEnumerable&lt;MerchantGoogleProductSpecTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantGoogleProductSpecTaskPostResponseInfo> GoogleProductSpecTaskPostAsync(IEnumerable<MerchantGoogleProductSpecTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantGoogleProductSpecTaskPostRequestInfo&gt;](./MerchantGoogleProductSpecTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskPostResponseInfo&gt;](./MerchantGoogleProductSpecTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides product data from Google Shopping based on the specified product_id. You will get a full detailed product description as it is given on the Google Shopping product specification page. Product data can include parameters of the product, brand name, part numbers, GTIN, etc.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_post/?bash'

### **GoogleProductSpecTaskPostAsync(IEnumerable&lt;MerchantGoogleProductSpecTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantGoogleProductSpecTaskPostResponseInfo> GoogleProductSpecTaskPostAsync(IEnumerable<MerchantGoogleProductSpecTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantGoogleProductSpecTaskPostRequestInfo&gt;](./MerchantGoogleProductSpecTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskPostResponseInfo&gt;](./MerchantGoogleProductSpecTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides product data from Google Shopping based on the specified product_id. You will get a full detailed product description as it is given on the Google Shopping product specification page. Product data can include parameters of the product, brand name, part numbers, GTIN, etc.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_post/?bash'

### **GoogleProductSpecTasksReadyAsync()**

```csharp
public Task<MerchantGoogleProductSpecTasksReadyResponseInfo> GoogleProductSpecTasksReadyAsync()
```

#### Returns

[Task&lt;MerchantGoogleProductSpecTasksReadyResponseInfo&gt;](./MerchantGoogleProductSpecTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/tasks_ready/?bash'

### **GoogleProductSpecTasksReadyAsync(CancellationToken)**

```csharp
public Task<MerchantGoogleProductSpecTasksReadyResponseInfo> GoogleProductSpecTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductSpecTasksReadyResponseInfo&gt;](./MerchantGoogleProductSpecTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/tasks_ready/?bash'

### **GoogleProductSpecTaskGetAdvancedAsync(String)**

```csharp
public Task<MerchantGoogleProductSpecTaskGetAdvancedResponseInfo> GoogleProductSpecTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskGetAdvancedResponseInfo&gt;](./MerchantGoogleProductSpecTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/advanced/?bash'

### **GoogleProductSpecTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleProductSpecTaskGetAdvancedResponseInfo> GoogleProductSpecTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskGetAdvancedResponseInfo&gt;](./MerchantGoogleProductSpecTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/advanced/?bash'

### **GoogleProductSpecTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantGoogleProductSpecTaskGetHtmlResponseInfo> GoogleProductSpecTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskGetHtmlResponseInfo&gt;](./MerchantGoogleProductSpecTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/html/?bash'

### **GoogleProductSpecTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleProductSpecTaskGetHtmlResponseInfo> GoogleProductSpecTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskGetHtmlResponseInfo&gt;](./MerchantGoogleProductSpecTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/html/?bash'

### **GoogleProductInfoTaskPostAsync(IEnumerable&lt;MerchantGoogleProductInfoTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantGoogleProductInfoTaskPostResponseInfo> GoogleProductInfoTaskPostAsync(IEnumerable<MerchantGoogleProductInfoTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantGoogleProductInfoTaskPostRequestInfo&gt;](./MerchantGoogleProductInfoTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;MerchantGoogleProductInfoTaskPostResponseInfo&gt;](./MerchantGoogleProductInfoTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides data on a product listed on Google Shopping, including product description, images, rating, variations, and sellers. In order to set a task, you have to specify the product_id.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/task_post/?bash'

### **GoogleProductInfoTaskPostAsync(IEnumerable&lt;MerchantGoogleProductInfoTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantGoogleProductInfoTaskPostResponseInfo> GoogleProductInfoTaskPostAsync(IEnumerable<MerchantGoogleProductInfoTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantGoogleProductInfoTaskPostRequestInfo&gt;](./MerchantGoogleProductInfoTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductInfoTaskPostResponseInfo&gt;](./MerchantGoogleProductInfoTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides data on a product listed on Google Shopping, including product description, images, rating, variations, and sellers. In order to set a task, you have to specify the product_id.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/task_post/?bash'

### **GoogleProductInfoTasksReadyAsync()**

```csharp
public Task<MerchantGoogleProductInfoTasksReadyResponseInfo> GoogleProductInfoTasksReadyAsync()
```

#### Returns

[Task&lt;MerchantGoogleProductInfoTasksReadyResponseInfo&gt;](./MerchantGoogleProductInfoTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/tasks_ready/?bash'

### **GoogleProductInfoTasksReadyAsync(CancellationToken)**

```csharp
public Task<MerchantGoogleProductInfoTasksReadyResponseInfo> GoogleProductInfoTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductInfoTasksReadyResponseInfo&gt;](./MerchantGoogleProductInfoTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/tasks_ready/?bash'

### **GoogleProductInfoTaskGetAdvancedAsync(String)**

```csharp
public Task<MerchantGoogleProductInfoTaskGetAdvancedResponseInfo> GoogleProductInfoTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleProductInfoTaskGetAdvancedResponseInfo&gt;](./MerchantGoogleProductInfoTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/task_get/advanced/?bash'

### **GoogleProductInfoTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleProductInfoTaskGetAdvancedResponseInfo> GoogleProductInfoTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductInfoTaskGetAdvancedResponseInfo&gt;](./MerchantGoogleProductInfoTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/task_get/advanced/?bash'

### **GoogleSellersAdUrlAsync(String)**

```csharp
public Task<MerchantGoogleSellersAdUrlResponseInfo> GoogleSellersAdUrlAsync(string shop_ad_aclk)
```

#### Parameters

`shop_ad_aclk` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
unique ad click referral parameter
 <br>you can obtain this parameter with Google Shopping Products or Google Shopping Sellers

#### Returns

[Task&lt;MerchantGoogleSellersAdUrlResponseInfo&gt;](./MerchantGoogleSellersAdUrlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Google Shopping Sellers Ad URL is designed to provide you with a full URL of the advertisement containing all additional parameters set by the seller.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/ad_url/?bash'

### **GoogleSellersAdUrlAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleSellersAdUrlResponseInfo> GoogleSellersAdUrlAsync(string shop_ad_aclk, CancellationToken cancellationToken)
```

#### Parameters

`shop_ad_aclk` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
unique ad click referral parameter
 <br>you can obtain this parameter with Google Shopping Products or Google Shopping Sellers

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleSellersAdUrlResponseInfo&gt;](./MerchantGoogleSellersAdUrlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Google Shopping Sellers Ad URL is designed to provide you with a full URL of the advertisement containing all additional parameters set by the seller.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/ad_url/?bash'

### **MerchantAmazonLocationsAsync()**

```csharp
public Task<MerchantAmazonLocationsResponseInfo> MerchantAmazonLocationsAsync()
```

#### Returns

[Task&lt;MerchantAmazonLocationsResponseInfo&gt;](./MerchantAmazonLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'

### **MerchantAmazonLocationsAsync(CancellationToken)**

```csharp
public Task<MerchantAmazonLocationsResponseInfo> MerchantAmazonLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonLocationsResponseInfo&gt;](./MerchantAmazonLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'

### **MerchantAmazonLocationsCountryAsync(String)**

```csharp
public Task<MerchantAmazonLocationsCountryResponseInfo> MerchantAmazonLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;MerchantAmazonLocationsCountryResponseInfo&gt;](./MerchantAmazonLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'

### **MerchantAmazonLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonLocationsCountryResponseInfo> MerchantAmazonLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;MerchantAmazonLocationsCountryResponseInfo&gt;](./MerchantAmazonLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'

### **MerchantAmazonLanguagesAsync()**

```csharp
public Task<MerchantAmazonLanguagesResponseInfo> MerchantAmazonLanguagesAsync()
```

#### Returns

[Task&lt;MerchantAmazonLanguagesResponseInfo&gt;](./MerchantAmazonLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/languages/?bash'

### **MerchantAmazonLanguagesAsync(CancellationToken)**

```csharp
public Task<MerchantAmazonLanguagesResponseInfo> MerchantAmazonLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonLanguagesResponseInfo&gt;](./MerchantAmazonLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/languages/?bash'

### **AmazonProductsTaskPostAsync(IEnumerable&lt;MerchantAmazonProductsTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantAmazonProductsTaskPostResponseInfo> AmazonProductsTaskPostAsync(IEnumerable<MerchantAmazonProductsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonProductsTaskPostRequestInfo&gt;](./MerchantAmazonProductsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;MerchantAmazonProductsTaskPostResponseInfo&gt;](./MerchantAmazonProductsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides results from Amazon product listings according to the specified keyword (product name), location, and language parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_post/?bash'

### **AmazonProductsTaskPostAsync(IEnumerable&lt;MerchantAmazonProductsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantAmazonProductsTaskPostResponseInfo> AmazonProductsTaskPostAsync(IEnumerable<MerchantAmazonProductsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonProductsTaskPostRequestInfo&gt;](./MerchantAmazonProductsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonProductsTaskPostResponseInfo&gt;](./MerchantAmazonProductsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides results from Amazon product listings according to the specified keyword (product name), location, and language parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_post/?bash'

### **AmazonProductsTasksReadyAsync()**

```csharp
public Task<MerchantAmazonProductsTasksReadyResponseInfo> AmazonProductsTasksReadyAsync()
```

#### Returns

[Task&lt;MerchantAmazonProductsTasksReadyResponseInfo&gt;](./MerchantAmazonProductsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/tasks_ready/?bash'

### **AmazonProductsTasksReadyAsync(CancellationToken)**

```csharp
public Task<MerchantAmazonProductsTasksReadyResponseInfo> AmazonProductsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonProductsTasksReadyResponseInfo&gt;](./MerchantAmazonProductsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/tasks_ready/?bash'

### **AmazonProductsTaskGetAdvancedAsync(String)**

```csharp
public Task<MerchantAmazonProductsTaskGetAdvancedResponseInfo> AmazonProductsTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonProductsTaskGetAdvancedResponseInfo&gt;](./MerchantAmazonProductsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/advanced/?bash'

### **AmazonProductsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonProductsTaskGetAdvancedResponseInfo> AmazonProductsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonProductsTaskGetAdvancedResponseInfo&gt;](./MerchantAmazonProductsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/advanced/?bash'

### **AmazonProductsTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantAmazonProductsTaskGetHtmlResponseInfo> AmazonProductsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonProductsTaskGetHtmlResponseInfo&gt;](./MerchantAmazonProductsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/html/?bash'

### **AmazonProductsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonProductsTaskGetHtmlResponseInfo> AmazonProductsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonProductsTaskGetHtmlResponseInfo&gt;](./MerchantAmazonProductsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/html/?bash'

### **AmazonAsinTaskPostAsync(IEnumerable&lt;MerchantAmazonAsinTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantAmazonAsinTaskPostResponseInfo> AmazonAsinTaskPostAsync(IEnumerable<MerchantAmazonAsinTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonAsinTaskPostRequestInfo&gt;](./MerchantAmazonAsinTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;MerchantAmazonAsinTaskPostResponseInfo&gt;](./MerchantAmazonAsinTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a full list of ASINs assigned to different modifications of a product.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_post/?bash'

### **AmazonAsinTaskPostAsync(IEnumerable&lt;MerchantAmazonAsinTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantAmazonAsinTaskPostResponseInfo> AmazonAsinTaskPostAsync(IEnumerable<MerchantAmazonAsinTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonAsinTaskPostRequestInfo&gt;](./MerchantAmazonAsinTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonAsinTaskPostResponseInfo&gt;](./MerchantAmazonAsinTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a full list of ASINs assigned to different modifications of a product.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_post/?bash'

### **AmazonAsinTasksReadyAsync()**

```csharp
public Task<MerchantAmazonAsinTasksReadyResponseInfo> AmazonAsinTasksReadyAsync()
```

#### Returns

[Task&lt;MerchantAmazonAsinTasksReadyResponseInfo&gt;](./MerchantAmazonAsinTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/tasks_ready/?bash'

### **AmazonAsinTasksReadyAsync(CancellationToken)**

```csharp
public Task<MerchantAmazonAsinTasksReadyResponseInfo> AmazonAsinTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonAsinTasksReadyResponseInfo&gt;](./MerchantAmazonAsinTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/tasks_ready/?bash'

### **AmazonAsinTaskGetAdvancedAsync(String)**

```csharp
public Task<MerchantAmazonAsinTaskGetAdvancedResponseInfo> AmazonAsinTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonAsinTaskGetAdvancedResponseInfo&gt;](./MerchantAmazonAsinTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with information about the product and ASINs of all its modifications listed on Amazon.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/advanced/?bash'

### **AmazonAsinTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonAsinTaskGetAdvancedResponseInfo> AmazonAsinTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonAsinTaskGetAdvancedResponseInfo&gt;](./MerchantAmazonAsinTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with information about the product and ASINs of all its modifications listed on Amazon.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/advanced/?bash'

### **AmazonAsinTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantAmazonAsinTaskGetHtmlResponseInfo> AmazonAsinTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonAsinTaskGetHtmlResponseInfo&gt;](./MerchantAmazonAsinTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/html/?bash'

### **AmazonAsinTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonAsinTaskGetHtmlResponseInfo> AmazonAsinTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonAsinTaskGetHtmlResponseInfo&gt;](./MerchantAmazonAsinTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/html/?bash'

### **AmazonSellersTaskPostAsync(IEnumerable&lt;MerchantAmazonSellersTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantAmazonSellersTaskPostResponseInfo> AmazonSellersTaskPostAsync(IEnumerable<MerchantAmazonSellersTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonSellersTaskPostRequestInfo&gt;](./MerchantAmazonSellersTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;MerchantAmazonSellersTaskPostResponseInfo&gt;](./MerchantAmazonSellersTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides a list of sellers of the specified product on Amazon. The data provided for each seller includes related product condition, pricing, shipment, and rating details.
 <br>The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_post/?bash'

### **AmazonSellersTaskPostAsync(IEnumerable&lt;MerchantAmazonSellersTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantAmazonSellersTaskPostResponseInfo> AmazonSellersTaskPostAsync(IEnumerable<MerchantAmazonSellersTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonSellersTaskPostRequestInfo&gt;](./MerchantAmazonSellersTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonSellersTaskPostResponseInfo&gt;](./MerchantAmazonSellersTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides a list of sellers of the specified product on Amazon. The data provided for each seller includes related product condition, pricing, shipment, and rating details.
 <br>The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_post/?bash'

### **AmazonSellersTasksReadyAsync()**

```csharp
public Task<MerchantAmazonSellersTasksReadyResponseInfo> AmazonSellersTasksReadyAsync()
```

#### Returns

[Task&lt;MerchantAmazonSellersTasksReadyResponseInfo&gt;](./MerchantAmazonSellersTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/tasks_ready/?bash'

### **AmazonSellersTasksReadyAsync(CancellationToken)**

```csharp
public Task<MerchantAmazonSellersTasksReadyResponseInfo> AmazonSellersTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonSellersTasksReadyResponseInfo&gt;](./MerchantAmazonSellersTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/tasks_ready/?bash'

### **AmazonSellersTaskGetAdvancedAsync(String)**

```csharp
public Task<MerchantAmazonSellersTaskGetAdvancedResponseInfo> AmazonSellersTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonSellersTaskGetAdvancedResponseInfo&gt;](./MerchantAmazonSellersTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides a list of sellers of the specified product on Amazon. The data provided for each seller includes related product condition, pricing, shipment, and rating details.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/advanced/?bash'

### **AmazonSellersTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonSellersTaskGetAdvancedResponseInfo> AmazonSellersTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonSellersTaskGetAdvancedResponseInfo&gt;](./MerchantAmazonSellersTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides a list of sellers of the specified product on Amazon. The data provided for each seller includes related product condition, pricing, shipment, and rating details.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/advanced/?bash'

### **AmazonSellersTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantAmazonSellersTaskGetHtmlResponseInfo> AmazonSellersTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonSellersTaskGetHtmlResponseInfo&gt;](./MerchantAmazonSellersTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/html/?bash'

### **AmazonSellersTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonSellersTaskGetHtmlResponseInfo> AmazonSellersTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonSellersTaskGetHtmlResponseInfo&gt;](./MerchantAmazonSellersTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/html/?bash'

### **AmazonReviewsTaskPostAsync(IEnumerable&lt;MerchantAmazonReviewsTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantAmazonReviewsTaskPostResponseInfo> AmazonReviewsTaskPostAsync(IEnumerable<MerchantAmazonReviewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonReviewsTaskPostRequestInfo&gt;](./MerchantAmazonReviewsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;MerchantAmazonReviewsTaskPostResponseInfo&gt;](./MerchantAmazonReviewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_post/?bash'

### **AmazonReviewsTaskPostAsync(IEnumerable&lt;MerchantAmazonReviewsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantAmazonReviewsTaskPostResponseInfo> AmazonReviewsTaskPostAsync(IEnumerable<MerchantAmazonReviewsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonReviewsTaskPostRequestInfo&gt;](./MerchantAmazonReviewsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonReviewsTaskPostResponseInfo&gt;](./MerchantAmazonReviewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_post/?bash'

### **AmazonReviewsTasksReadyAsync()**

```csharp
public Task<MerchantAmazonReviewsTasksReadyResponseInfo> AmazonReviewsTasksReadyAsync()
```

#### Returns

[Task&lt;MerchantAmazonReviewsTasksReadyResponseInfo&gt;](./MerchantAmazonReviewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/tasks_ready/?bash'

### **AmazonReviewsTasksReadyAsync(CancellationToken)**

```csharp
public Task<MerchantAmazonReviewsTasksReadyResponseInfo> AmazonReviewsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonReviewsTasksReadyResponseInfo&gt;](./MerchantAmazonReviewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/tasks_ready/?bash'

### **AmazonReviewsTaskGetAdvancedAsync(String)**

```csharp
public Task<MerchantAmazonReviewsTaskGetAdvancedResponseInfo> AmazonReviewsTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonReviewsTaskGetAdvancedResponseInfo&gt;](./MerchantAmazonReviewsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides feedback data on products listed on the Amazon marketplace, including their titles, images, ratings, review content, user profile info, review publication dates, and more. The results are specific to the asin specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_get/advanced/?bash'

### **AmazonReviewsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonReviewsTaskGetAdvancedResponseInfo> AmazonReviewsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonReviewsTaskGetAdvancedResponseInfo&gt;](./MerchantAmazonReviewsTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides feedback data on products listed on the Amazon marketplace, including their titles, images, ratings, review content, user profile info, review publication dates, and more. The results are specific to the asin specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_get/advanced/?bash'

### **AmazonReviewsTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantAmazonReviewsTaskGetHtmlResponseInfo> AmazonReviewsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonReviewsTaskGetHtmlResponseInfo&gt;](./MerchantAmazonReviewsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_get/html/?bash'

### **AmazonReviewsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonReviewsTaskGetHtmlResponseInfo> AmazonReviewsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonReviewsTaskGetHtmlResponseInfo&gt;](./MerchantAmazonReviewsTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_get/html/?bash'

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
