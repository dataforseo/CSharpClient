[`< Back`](./)

---

# MerchantApi

Namespace: DataForSeo.Client.Api

```csharp
public class MerchantApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MerchantApi](./dataforseo.client.api.merchantapi)

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

`body` [IEnumerable&lt;MerchantIdListRequestInfo&gt;](./dataforseo.client.models.requests.merchantidlistrequestinfo)<br>

#### Returns

[Task&lt;MerchantIdListResponseInfo&gt;](./dataforseo.client.models.responses.merchantidlistresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Merchant tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/id_list/?bash'

### **MerchantIdListAsync(IEnumerable&lt;MerchantIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantIdListResponseInfo> MerchantIdListAsync(IEnumerable<MerchantIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantIdListRequestInfo&gt;](./dataforseo.client.models.requests.merchantidlistrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantIdListResponseInfo&gt;](./dataforseo.client.models.responses.merchantidlistresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Merchant tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/id_list/?bash'

### **MerchantErrorsAsync(IEnumerable&lt;MerchantErrorsRequestInfo&gt;)**

```csharp
public Task<MerchantErrorsResponseInfo> MerchantErrorsAsync(IEnumerable<MerchantErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantErrorsRequestInfo&gt;](./dataforseo.client.models.requests.merchanterrorsrequestinfo)<br>

#### Returns

[Task&lt;MerchantErrorsResponseInfo&gt;](./dataforseo.client.models.responses.merchanterrorsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Merchant API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/errors/?bash'

### **MerchantErrorsAsync(IEnumerable&lt;MerchantErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantErrorsResponseInfo> MerchantErrorsAsync(IEnumerable<MerchantErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantErrorsRequestInfo&gt;](./dataforseo.client.models.requests.merchanterrorsrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantErrorsResponseInfo&gt;](./dataforseo.client.models.responses.merchanterrorsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Merchant API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/errors/?bash'

### **MerchantGoogleLanguagesAsync()**

```csharp
public Task<MerchantGoogleLanguagesResponseInfo> MerchantGoogleLanguagesAsync()
```

#### Returns

[Task&lt;MerchantGoogleLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglelanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Google Shopping languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/languages/?bash'

### **MerchantGoogleLanguagesAsync(CancellationToken)**

```csharp
public Task<MerchantGoogleLanguagesResponseInfo> MerchantGoogleLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglelanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Google Shopping languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/languages/?bash'

### **MerchantGoogleLocationsAsync()**

```csharp
public Task<MerchantGoogleLocationsResponseInfo> MerchantGoogleLocationsAsync()
```

#### Returns

[Task&lt;MerchantGoogleLocationsResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglelocationsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'

### **MerchantGoogleLocationsAsync(CancellationToken)**

```csharp
public Task<MerchantGoogleLocationsResponseInfo> MerchantGoogleLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleLocationsResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglelocationsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'

### **MerchantGoogleLocationsCountryAsync(String)**

```csharp
public Task<MerchantGoogleLocationsCountryResponseInfo> MerchantGoogleLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;MerchantGoogleLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglelocationscountryresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'

### **MerchantGoogleLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleLocationsCountryResponseInfo> MerchantGoogleLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;MerchantGoogleLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglelocationscountryresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'

### **GoogleProductsTaskPostAsync(IEnumerable&lt;MerchantTaskRequestInfo&gt;)**

```csharp
public Task<MerchantGoogleProductsTaskPostResponseInfo> GoogleProductsTaskPostAsync(IEnumerable<MerchantTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantTaskRequestInfo&gt;](./dataforseo.client.models.requests.merchanttaskrequestinfo)<br>

#### Returns

[Task&lt;MerchantGoogleProductsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Shopping Products endpoint will provide you with the list of products found on Google Shopping for the specified query. The results include product title, description in Google Shopping SERP, product rank, price, reviews and rating as well as the related domain.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_post/?bash'

### **GoogleProductsTaskPostAsync(IEnumerable&lt;MerchantTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantGoogleProductsTaskPostResponseInfo> GoogleProductsTaskPostAsync(IEnumerable<MerchantTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantTaskRequestInfo&gt;](./dataforseo.client.models.requests.merchanttaskrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

[Task&lt;MerchantGoogleProductsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleProductsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/advanced/?bash'

### **GoogleProductsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleProductsTaskGetAdvancedResponseInfo> GoogleProductsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/advanced/?bash'

### **GoogleProductsTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantGoogleProductsTaskGetHtmlResponseInfo> GoogleProductsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleProductsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/html/?bash'

### **GoogleProductsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleProductsTaskGetHtmlResponseInfo> GoogleProductsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/html/?bash'

### **GoogleSellersTaskPostAsync(IEnumerable&lt;MerchantGoogleSellersTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantGoogleSellersTaskPostResponseInfo> GoogleSellersTaskPostAsync(IEnumerable<MerchantGoogleSellersTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantGoogleSellersTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantgooglesellerstaskpostrequestinfo)<br>

#### Returns

[Task&lt;MerchantGoogleSellersTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglesellerstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;MerchantGoogleSellersTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantgooglesellerstaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleSellersTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglesellerstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

[Task&lt;MerchantGoogleSellersTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglesellerstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleSellersTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglesellerstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleSellersTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglesellerstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/advanced/?bash'

### **GoogleSellersTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleSellersTaskGetAdvancedResponseInfo> GoogleSellersTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleSellersTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglesellerstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/advanced/?bash'

### **GoogleSellersTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantGoogleSellersTaskGetHtmlResponseInfo> GoogleSellersTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleSellersTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglesellerstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/html/?bash'

### **GoogleSellersTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleSellersTaskGetHtmlResponseInfo> GoogleSellersTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleSellersTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglesellerstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/html/?bash'

### **GoogleProductSpecTaskPostAsync(IEnumerable&lt;MerchantGoogleProductSpecTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantGoogleProductSpecTaskPostResponseInfo> GoogleProductSpecTaskPostAsync(IEnumerable<MerchantGoogleProductSpecTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantGoogleProductSpecTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantgoogleproductspectaskpostrequestinfo)<br>

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductspectaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;MerchantGoogleProductSpecTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantgoogleproductspectaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductspectaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

[Task&lt;MerchantGoogleProductSpecTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductspectasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductSpecTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductspectasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductspectaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/advanced/?bash'

### **GoogleProductSpecTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleProductSpecTaskGetAdvancedResponseInfo> GoogleProductSpecTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductspectaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/advanced/?bash'

### **GoogleProductSpecTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantGoogleProductSpecTaskGetHtmlResponseInfo> GoogleProductSpecTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductspectaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/html/?bash'

### **GoogleProductSpecTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleProductSpecTaskGetHtmlResponseInfo> GoogleProductSpecTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductSpecTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductspectaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/html/?bash'

### **GoogleProductInfoTaskPostAsync(IEnumerable&lt;MerchantGoogleProductInfoTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantGoogleProductInfoTaskPostResponseInfo> GoogleProductInfoTaskPostAsync(IEnumerable<MerchantGoogleProductInfoTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantGoogleProductInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantgoogleproductinfotaskpostrequestinfo)<br>

#### Returns

[Task&lt;MerchantGoogleProductInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductinfotaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;MerchantGoogleProductInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantgoogleproductinfotaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductinfotaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

[Task&lt;MerchantGoogleProductInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductinfotasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductinfotasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantGoogleProductInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductinfotaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/task_get/advanced/?bash'

### **GoogleProductInfoTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleProductInfoTaskGetAdvancedResponseInfo> GoogleProductInfoTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleProductInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantgoogleproductinfotaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/task_get/advanced/?bash'

### **GoogleSellersAdUrlAsync(String)**

```csharp
public Task<MerchantGoogleSellersAdUrlResponseInfo> GoogleSellersAdUrlAsync(string shop_ad_aclk)
```

#### Parameters

`shop_ad_aclk` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
unique ad click referral parameter
 <br>you can obtain this parameter with Google Shopping Products or Google Shopping Sellers

#### Returns

[Task&lt;MerchantGoogleSellersAdUrlResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglesellersadurlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Google Shopping Sellers Ad URL is designed to provide you with a full URL of the advertisement containing all additional parameters set by the seller.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/ad_url/?bash'

### **GoogleSellersAdUrlAsync(String, CancellationToken)**

```csharp
public Task<MerchantGoogleSellersAdUrlResponseInfo> GoogleSellersAdUrlAsync(string shop_ad_aclk, CancellationToken cancellationToken)
```

#### Parameters

`shop_ad_aclk` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
unique ad click referral parameter
 <br>you can obtain this parameter with Google Shopping Products or Google Shopping Sellers

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantGoogleSellersAdUrlResponseInfo&gt;](./dataforseo.client.models.responses.merchantgooglesellersadurlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Google Shopping Sellers Ad URL is designed to provide you with a full URL of the advertisement containing all additional parameters set by the seller.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/ad_url/?bash'

### **MerchantAmazonLocationsAsync()**

```csharp
public Task<MerchantAmazonLocationsResponseInfo> MerchantAmazonLocationsAsync()
```

#### Returns

[Task&lt;MerchantAmazonLocationsResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonlocationsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'

### **MerchantAmazonLocationsAsync(CancellationToken)**

```csharp
public Task<MerchantAmazonLocationsResponseInfo> MerchantAmazonLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonLocationsResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonlocationsresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'

### **MerchantAmazonLocationsCountryAsync(String)**

```csharp
public Task<MerchantAmazonLocationsCountryResponseInfo> MerchantAmazonLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;MerchantAmazonLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonlocationscountryresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'

### **MerchantAmazonLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonLocationsCountryResponseInfo> MerchantAmazonLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;MerchantAmazonLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonlocationscountryresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'

### **MerchantAmazonLanguagesAsync()**

```csharp
public Task<MerchantAmazonLanguagesResponseInfo> MerchantAmazonLanguagesAsync()
```

#### Returns

[Task&lt;MerchantAmazonLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonlanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/languages/?bash'

### **MerchantAmazonLanguagesAsync(CancellationToken)**

```csharp
public Task<MerchantAmazonLanguagesResponseInfo> MerchantAmazonLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonlanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

You will receive the list of supported Amazon languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/languages/?bash'

### **AmazonProductsTaskPostAsync(IEnumerable&lt;MerchantAmazonProductsTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantAmazonProductsTaskPostResponseInfo> AmazonProductsTaskPostAsync(IEnumerable<MerchantAmazonProductsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonProductsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantamazonproductstaskpostrequestinfo)<br>

#### Returns

[Task&lt;MerchantAmazonProductsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonproductstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;MerchantAmazonProductsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantamazonproductstaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonProductsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonproductstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

[Task&lt;MerchantAmazonProductsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonproductstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonProductsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonproductstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonProductsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonproductstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/advanced/?bash'

### **AmazonProductsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonProductsTaskGetAdvancedResponseInfo> AmazonProductsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonProductsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonproductstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/advanced/?bash'

### **AmazonProductsTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantAmazonProductsTaskGetHtmlResponseInfo> AmazonProductsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonProductsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonproductstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/html/?bash'

### **AmazonProductsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonProductsTaskGetHtmlResponseInfo> AmazonProductsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonProductsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonproductstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/html/?bash'

### **AmazonAsinTaskPostAsync(IEnumerable&lt;MerchantAmazonAsinTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantAmazonAsinTaskPostResponseInfo> AmazonAsinTaskPostAsync(IEnumerable<MerchantAmazonAsinTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonAsinTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantamazonasintaskpostrequestinfo)<br>

#### Returns

[Task&lt;MerchantAmazonAsinTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonasintaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;MerchantAmazonAsinTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantamazonasintaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonAsinTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonasintaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

[Task&lt;MerchantAmazonAsinTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonasintasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonAsinTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonasintasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonAsinTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonasintaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with information about the product and ASINs of all its modifications listed on Amazon.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/advanced/?bash'

### **AmazonAsinTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonAsinTaskGetAdvancedResponseInfo> AmazonAsinTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonAsinTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonasintaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with information about the product and ASINs of all its modifications listed on Amazon.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/advanced/?bash'

### **AmazonAsinTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantAmazonAsinTaskGetHtmlResponseInfo> AmazonAsinTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonAsinTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonasintaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/html/?bash'

### **AmazonAsinTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonAsinTaskGetHtmlResponseInfo> AmazonAsinTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonAsinTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonasintaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/html/?bash'

### **AmazonSellersTaskPostAsync(IEnumerable&lt;MerchantAmazonSellersTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantAmazonSellersTaskPostResponseInfo> AmazonSellersTaskPostAsync(IEnumerable<MerchantAmazonSellersTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonSellersTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantamazonsellerstaskpostrequestinfo)<br>

#### Returns

[Task&lt;MerchantAmazonSellersTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonsellerstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;MerchantAmazonSellersTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantamazonsellerstaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonSellersTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonsellerstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

[Task&lt;MerchantAmazonSellersTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonsellerstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonSellersTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonsellerstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonSellersTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonsellerstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint provides a list of sellers of the specified product on Amazon. The data provided for each seller includes related product condition, pricing, shipment, and rating details.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/advanced/?bash'

### **AmazonSellersTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonSellersTaskGetAdvancedResponseInfo> AmazonSellersTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonSellersTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonsellerstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint provides a list of sellers of the specified product on Amazon. The data provided for each seller includes related product condition, pricing, shipment, and rating details.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/advanced/?bash'

### **AmazonSellersTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantAmazonSellersTaskGetHtmlResponseInfo> AmazonSellersTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonSellersTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonsellerstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/html/?bash'

### **AmazonSellersTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonSellersTaskGetHtmlResponseInfo> AmazonSellersTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonSellersTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonsellerstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/html/?bash'

### **AmazonReviewsTaskPostAsync(IEnumerable&lt;MerchantAmazonReviewsTaskPostRequestInfo&gt;)**

```csharp
public Task<MerchantAmazonReviewsTaskPostResponseInfo> AmazonReviewsTaskPostAsync(IEnumerable<MerchantAmazonReviewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantamazonreviewstaskpostrequestinfo)<br>

#### Returns

[Task&lt;MerchantAmazonReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonreviewstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of reviews for the target Amazon product.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_post/?bash'

### **AmazonReviewsTaskPostAsync(IEnumerable&lt;MerchantAmazonReviewsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<MerchantAmazonReviewsTaskPostResponseInfo> AmazonReviewsTaskPostAsync(IEnumerable<MerchantAmazonReviewsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;MerchantAmazonReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.merchantamazonreviewstaskpostrequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonreviewstaskpostresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of reviews for the target Amazon product.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_post/?bash'

### **AmazonReviewsTasksReadyAsync()**

```csharp
public Task<MerchantAmazonReviewsTasksReadyResponseInfo> AmazonReviewsTasksReadyAsync()
```

#### Returns

[Task&lt;MerchantAmazonReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonreviewstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonreviewstasksreadyresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonReviewsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonreviewstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint provides feedback data on products listed on the Amazon marketplace, including their titles, images, ratings, review content, user profile info, review publication dates, and more. The results are specific to the asin specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_get/advanced/?bash'

### **AmazonReviewsTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonReviewsTaskGetAdvancedResponseInfo> AmazonReviewsTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonReviewsTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonreviewstaskgetadvancedresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

This endpoint provides feedback data on products listed on the Amazon marketplace, including their titles, images, ratings, review content, user profile info, review publication dates, and more. The results are specific to the asin specified in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_get/advanced/?bash'

### **AmazonReviewsTaskGetHtmlAsync(String)**

```csharp
public Task<MerchantAmazonReviewsTaskGetHtmlResponseInfo> AmazonReviewsTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;MerchantAmazonReviewsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonreviewstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
A server side error occurred.

**Remarks:**

Description of the fields for sending a request:
 <br>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_get/html/?bash'

### **AmazonReviewsTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<MerchantAmazonReviewsTaskGetHtmlResponseInfo> AmazonReviewsTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;MerchantAmazonReviewsTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.merchantamazonreviewstaskgethtmlresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`headers` [IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

Task&lt;ObjectResponseResult&lt;T&gt;&gt;<br>

---

[`< Back`](./)
