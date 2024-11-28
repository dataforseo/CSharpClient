# BusinessDataApi

Namespace: DataForSeo.Client.Api

```csharp
public class BusinessDataApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/Object) → [BusinessDataApi](./BusinessDataApi.md)

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

### **BusinessDataApi(HttpClient)**

```csharp
public BusinessDataApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **BusinessDataIdListAsync(IEnumerable&lt;BusinessDataIdListRequestInfo&gt;)**

```csharp
public Task<BusinessDataIdListResponseInfo> BusinessDataIdListAsync(IEnumerable<BusinessDataIdListRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataIdListRequestInfo&gt;](./BusinessDataIdListRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataIdListResponseInfo&gt;](./BusinessDataIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Business Data tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/id_list/?bash'

### **BusinessDataIdListAsync(IEnumerable&lt;BusinessDataIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataIdListResponseInfo> BusinessDataIdListAsync(IEnumerable<BusinessDataIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataIdListRequestInfo&gt;](./BusinessDataIdListRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataIdListResponseInfo&gt;](./BusinessDataIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Business Data tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/id_list/?bash'

### **BusinessDataErrorsAsync(IEnumerable&lt;BusinessDataErrorsRequestInfo&gt;)**

```csharp
public Task<BusinessDataErrorsResponseInfo> BusinessDataErrorsAsync(IEnumerable<BusinessDataErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataErrorsRequestInfo&gt;](./BusinessDataErrorsRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataErrorsResponseInfo&gt;](./BusinessDataErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Business Data API tasks that returned an error within the past 7 days.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/errors/?bash'

### **BusinessDataErrorsAsync(IEnumerable&lt;BusinessDataErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataErrorsResponseInfo> BusinessDataErrorsAsync(IEnumerable<BusinessDataErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataErrorsRequestInfo&gt;](./BusinessDataErrorsRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataErrorsResponseInfo&gt;](./BusinessDataErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Business Data API tasks that returned an error within the past 7 days.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/errors/?bash'

### **BusinessDataBusinessListingsLocationsAsync()**

```csharp
public Task<BusinessDataBusinessListingsLocationsResponseInfo> BusinessDataBusinessListingsLocationsAsync()
```

#### Returns

[Task&lt;BusinessDataBusinessListingsLocationsResponseInfo&gt;](./BusinessDataBusinessListingsLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can also download the full list of supported locations in the CSV format (last updated 2024-11-05).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/locations/?bash'

### **BusinessDataBusinessListingsLocationsAsync(CancellationToken)**

```csharp
public Task<BusinessDataBusinessListingsLocationsResponseInfo> BusinessDataBusinessListingsLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataBusinessListingsLocationsResponseInfo&gt;](./BusinessDataBusinessListingsLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can also download the full list of supported locations in the CSV format (last updated 2024-11-05).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/locations/?bash'

### **BusinessListingsCategoriesAsync()**

```csharp
public Task<BusinessDataBusinessListingsCategoriesResponseInfo> BusinessListingsCategoriesAsync()
```

#### Returns

[Task&lt;BusinessDataBusinessListingsCategoriesResponseInfo&gt;](./BusinessDataBusinessListingsCategoriesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the list of top categories by business count.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/categories/?bash'

### **BusinessListingsCategoriesAsync(CancellationToken)**

```csharp
public Task<BusinessDataBusinessListingsCategoriesResponseInfo> BusinessListingsCategoriesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataBusinessListingsCategoriesResponseInfo&gt;](./BusinessDataBusinessListingsCategoriesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the list of top categories by business count.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/categories/?bash'

### **BusinessListingsAvailableFiltersAsync()**

```csharp
public Task<BusinessDataBusinessListingsAvailableFiltersResponseInfo> BusinessListingsAvailableFiltersAsync()
```

#### Returns

[Task&lt;BusinessDataBusinessListingsAvailableFiltersResponseInfo&gt;](./BusinessDataBusinessListingsAvailableFiltersResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Here you will find all the necessary information about filters that can be used with Business Listings API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/filters/?bash'

### **BusinessListingsAvailableFiltersAsync(CancellationToken)**

```csharp
public Task<BusinessDataBusinessListingsAvailableFiltersResponseInfo> BusinessListingsAvailableFiltersAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataBusinessListingsAvailableFiltersResponseInfo&gt;](./BusinessDataBusinessListingsAvailableFiltersResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Here you will find all the necessary information about filters that can be used with Business Listings API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/filters/?bash'

### **BusinessListingsSearchLiveAsync(IEnumerable&lt;BusinessDataBusinessListingsSearchLiveRequestInfo&gt;)**

```csharp
public Task<BusinessDataBusinessListingsSearchLiveResponseInfo> BusinessListingsSearchLiveAsync(IEnumerable<BusinessDataBusinessListingsSearchLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataBusinessListingsSearchLiveRequestInfo&gt;](./BusinessDataBusinessListingsSearchLiveRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataBusinessListingsSearchLiveResponseInfo&gt;](./BusinessDataBusinessListingsSearchLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Business Listings Search API provides results containing information about business entities listed on Google Maps in the specified categories. You will receive the address, contacts, rating, working hours, and other relevant data. The provided results are specific to the selected location (see the List of Locations) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/search/live/?bash'

### **BusinessListingsSearchLiveAsync(IEnumerable&lt;BusinessDataBusinessListingsSearchLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataBusinessListingsSearchLiveResponseInfo> BusinessListingsSearchLiveAsync(IEnumerable<BusinessDataBusinessListingsSearchLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataBusinessListingsSearchLiveRequestInfo&gt;](./BusinessDataBusinessListingsSearchLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataBusinessListingsSearchLiveResponseInfo&gt;](./BusinessDataBusinessListingsSearchLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Business Listings Search API provides results containing information about business entities listed on Google Maps in the specified categories. You will receive the address, contacts, rating, working hours, and other relevant data. The provided results are specific to the selected location (see the List of Locations) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/search/live/?bash'

### **BusinessListingsCategoriesAggregationLiveAsync(IEnumerable&lt;BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo&gt;)**

```csharp
public Task<BusinessDataBusinessListingsCategoriesAggregationLiveResponseInfo> BusinessListingsCategoriesAggregationLiveAsync(IEnumerable<BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo&gt;](./BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataBusinessListingsCategoriesAggregationLiveResponseInfo&gt;](./BusinessDataBusinessListingsCategoriesAggregationLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Business Listings Categories Aggregation endpoint provides results containing information about groups of related categories along with the number of entities in each category. The provided results are specific to the specified parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/categories_aggregation/live/?bash'

### **BusinessListingsCategoriesAggregationLiveAsync(IEnumerable&lt;BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataBusinessListingsCategoriesAggregationLiveResponseInfo> BusinessListingsCategoriesAggregationLiveAsync(IEnumerable<BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo&gt;](./BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataBusinessListingsCategoriesAggregationLiveResponseInfo&gt;](./BusinessDataBusinessListingsCategoriesAggregationLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Business Listings Categories Aggregation endpoint provides results containing information about groups of related categories along with the number of entities in each category. The provided results are specific to the specified parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/categories_aggregation/live/?bash'

### **BusinessDataGoogleLocationsAsync()**

```csharp
public Task<BusinessDataGoogleLocationsResponseInfo> BusinessDataGoogleLocationsAsync()
```

#### Returns

[Task&lt;BusinessDataGoogleLocationsResponseInfo&gt;](./BusinessDataGoogleLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/locations/?bash'

### **BusinessDataGoogleLocationsAsync(CancellationToken)**

```csharp
public Task<BusinessDataGoogleLocationsResponseInfo> BusinessDataGoogleLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleLocationsResponseInfo&gt;](./BusinessDataGoogleLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/locations/?bash'

### **BusinessDataGoogleLocationsCountryAsync(String)**

```csharp
public Task<BusinessDataGoogleLocationsCountryResponseInfo> BusinessDataGoogleLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;BusinessDataGoogleLocationsCountryResponseInfo&gt;](./BusinessDataGoogleLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/locations/?bash'

### **BusinessDataGoogleLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleLocationsCountryResponseInfo> BusinessDataGoogleLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;BusinessDataGoogleLocationsCountryResponseInfo&gt;](./BusinessDataGoogleLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/locations/?bash'

### **BusinessDataGoogleLanguagesAsync()**

```csharp
public Task<BusinessDataGoogleLanguagesResponseInfo> BusinessDataGoogleLanguagesAsync()
```

#### Returns

[Task&lt;BusinessDataGoogleLanguagesResponseInfo&gt;](./BusinessDataGoogleLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/languages/?bash'

### **BusinessDataGoogleLanguagesAsync(CancellationToken)**

```csharp
public Task<BusinessDataGoogleLanguagesResponseInfo> BusinessDataGoogleLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleLanguagesResponseInfo&gt;](./BusinessDataGoogleLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/languages/?bash'

### **GoogleMyBusinessInfoTaskPostAsync(IEnumerable&lt;BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo> GoogleMyBusinessInfoTaskPostAsync(IEnumerable<BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo&gt;](./BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo&gt;](./BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Business Data API provides results containing information about specific business entity from Google. The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/task_post/?bash'

### **GoogleMyBusinessInfoTaskPostAsync(IEnumerable&lt;BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo> GoogleMyBusinessInfoTaskPostAsync(IEnumerable<BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo&gt;](./BusinessDataGoogleMyBusinessInfoTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo&gt;](./BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Business Data API provides results containing information about specific business entity from Google. The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/task_post/?bash'

### **GoogleMyBusinessInfoTasksReadyAsync()**

```csharp
public Task<BusinessDataGoogleMyBusinessInfoTasksReadyResponseInfo> GoogleMyBusinessInfoTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoTasksReadyResponseInfo&gt;](./BusinessDataGoogleMyBusinessInfoTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/tasks_ready/?bash'

### **GoogleMyBusinessInfoTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataGoogleMyBusinessInfoTasksReadyResponseInfo> GoogleMyBusinessInfoTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoTasksReadyResponseInfo&gt;](./BusinessDataGoogleMyBusinessInfoTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/tasks_ready/?bash'

### **BusinessDataTasksReadyAsync()**

```csharp
public Task<BusinessDataTasksReadyResponseInfo> BusinessDataTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataTasksReadyResponseInfo&gt;](./BusinessDataTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/tasks_ready/?bash'

### **BusinessDataTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataTasksReadyResponseInfo> BusinessDataTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTasksReadyResponseInfo&gt;](./BusinessDataTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/tasks_ready/?bash'

### **GoogleMyBusinessInfoTaskGetAsync(String)**

```csharp
public Task<BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo> GoogleMyBusinessInfoTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo&gt;](./BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/task_get/?bash'

### **GoogleMyBusinessInfoTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo> GoogleMyBusinessInfoTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo&gt;](./BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/task_get/?bash'

### **GoogleMyBusinessInfoLiveAsync(IEnumerable&lt;BusinessDataGoogleMyBusinessInfoLiveRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleMyBusinessInfoLiveResponseInfo> GoogleMyBusinessInfoLiveAsync(IEnumerable<BusinessDataGoogleMyBusinessInfoLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleMyBusinessInfoLiveRequestInfo&gt;](./BusinessDataGoogleMyBusinessInfoLiveRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoLiveResponseInfo&gt;](./BusinessDataGoogleMyBusinessInfoLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Business Data API provides results containing information about specific business entity from Google. The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/live/?bash'

### **GoogleMyBusinessInfoLiveAsync(IEnumerable&lt;BusinessDataGoogleMyBusinessInfoLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleMyBusinessInfoLiveResponseInfo> GoogleMyBusinessInfoLiveAsync(IEnumerable<BusinessDataGoogleMyBusinessInfoLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleMyBusinessInfoLiveRequestInfo&gt;](./BusinessDataGoogleMyBusinessInfoLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoLiveResponseInfo&gt;](./BusinessDataGoogleMyBusinessInfoLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Business Data API provides results containing information about specific business entity from Google. The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/live/?bash'

### **GoogleMyBusinessUpdatesTaskPostAsync(IEnumerable&lt;BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo> GoogleMyBusinessUpdatesTaskPostAsync(IEnumerable<BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo&gt;](./BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo&gt;](./BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoints provides the latest updates of a specific business entity from Google SERP. The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_updates/task_post/?bash'

### **GoogleMyBusinessUpdatesTaskPostAsync(IEnumerable&lt;BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo> GoogleMyBusinessUpdatesTaskPostAsync(IEnumerable<BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo&gt;](./BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo&gt;](./BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoints provides the latest updates of a specific business entity from Google SERP. The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_updates/task_post/?bash'

### **GoogleMyBusinessUpdatesTasksReadyAsync()**

```csharp
public Task<BusinessDataGoogleMyBusinessUpdatesTasksReadyResponseInfo> GoogleMyBusinessUpdatesTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTasksReadyResponseInfo&gt;](./BusinessDataGoogleMyBusinessUpdatesTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_updates/tasks_ready/?bash'

### **GoogleMyBusinessUpdatesTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataGoogleMyBusinessUpdatesTasksReadyResponseInfo> GoogleMyBusinessUpdatesTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTasksReadyResponseInfo&gt;](./BusinessDataGoogleMyBusinessUpdatesTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_updates/tasks_ready/?bash'

### **GoogleMyBusinessUpdatesTaskGetAsync(String)**

```csharp
public Task<BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo> GoogleMyBusinessUpdatesTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo&gt;](./BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_updates/task_get/?bash'

### **GoogleMyBusinessUpdatesTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo> GoogleMyBusinessUpdatesTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo&gt;](./BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_updates/task_get/?bash'

### **GoogleHotelSearchesTaskPostAsync(IEnumerable&lt;BusinessDataGoogleHotelSearchesTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleHotelSearchesTaskPostResponseInfo> GoogleHotelSearchesTaskPostAsync(IEnumerable<BusinessDataGoogleHotelSearchesTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelSearchesTaskPostRequestInfo&gt;](./BusinessDataGoogleHotelSearchesTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesTaskPostResponseInfo&gt;](./BusinessDataGoogleHotelSearchesTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Hotel Searches API provides results containing information about different hotels listed on Google. The provided results are specific to the keyword, selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_searches/task_post/?bash'

### **GoogleHotelSearchesTaskPostAsync(IEnumerable&lt;BusinessDataGoogleHotelSearchesTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelSearchesTaskPostResponseInfo> GoogleHotelSearchesTaskPostAsync(IEnumerable<BusinessDataGoogleHotelSearchesTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelSearchesTaskPostRequestInfo&gt;](./BusinessDataGoogleHotelSearchesTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesTaskPostResponseInfo&gt;](./BusinessDataGoogleHotelSearchesTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Hotel Searches API provides results containing information about different hotels listed on Google. The provided results are specific to the keyword, selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_searches/task_post/?bash'

### **GoogleHotelSearchesTasksReadyAsync()**

```csharp
public Task<BusinessDataGoogleHotelSearchesTasksReadyResponseInfo> GoogleHotelSearchesTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesTasksReadyResponseInfo&gt;](./BusinessDataGoogleHotelSearchesTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_searches/tasks_ready/?bash'

### **GoogleHotelSearchesTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelSearchesTasksReadyResponseInfo> GoogleHotelSearchesTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesTasksReadyResponseInfo&gt;](./BusinessDataGoogleHotelSearchesTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_searches/tasks_ready/?bash'

### **GoogleHotelSearchesTaskGetAsync(String)**

```csharp
public Task<BusinessDataGoogleHotelSearchesTaskGetResponseInfo> GoogleHotelSearchesTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesTaskGetResponseInfo&gt;](./BusinessDataGoogleHotelSearchesTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_searches/task_get/?bash'

### **GoogleHotelSearchesTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelSearchesTaskGetResponseInfo> GoogleHotelSearchesTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesTaskGetResponseInfo&gt;](./BusinessDataGoogleHotelSearchesTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_searches/task_get/?bash'

### **GoogleHotelSearchesLiveAsync(IEnumerable&lt;BusinessDataGoogleHotelSearchesLiveRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleHotelSearchesLiveResponseInfo> GoogleHotelSearchesLiveAsync(IEnumerable<BusinessDataGoogleHotelSearchesLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelSearchesLiveRequestInfo&gt;](./BusinessDataGoogleHotelSearchesLiveRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesLiveResponseInfo&gt;](./BusinessDataGoogleHotelSearchesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Hotel Searches API provides results containing information about different hotels listed on Google Hotels. The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_searches/live/?bash'

### **GoogleHotelSearchesLiveAsync(IEnumerable&lt;BusinessDataGoogleHotelSearchesLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelSearchesLiveResponseInfo> GoogleHotelSearchesLiveAsync(IEnumerable<BusinessDataGoogleHotelSearchesLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelSearchesLiveRequestInfo&gt;](./BusinessDataGoogleHotelSearchesLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesLiveResponseInfo&gt;](./BusinessDataGoogleHotelSearchesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Hotel Searches API provides results containing information about different hotels listed on Google Hotels. The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_searches/live/?bash'

### **GoogleHotelInfoTaskPostAsync(IEnumerable&lt;BusinessDataGoogleHotelInfoTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleHotelInfoTaskPostResponseInfo> GoogleHotelInfoTaskPostAsync(IEnumerable<BusinessDataGoogleHotelInfoTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoTaskPostRequestInfo&gt;](./BusinessDataGoogleHotelInfoTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskPostResponseInfo&gt;](./BusinessDataGoogleHotelInfoTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Hotel Info will provide you with structured data available for a specific hotel entity on the Google Hotels platform: such as service description, location details, rating, amenities, reviews, images, prices, and more.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/task_post/?bash'

### **GoogleHotelInfoTaskPostAsync(IEnumerable&lt;BusinessDataGoogleHotelInfoTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelInfoTaskPostResponseInfo> GoogleHotelInfoTaskPostAsync(IEnumerable<BusinessDataGoogleHotelInfoTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoTaskPostRequestInfo&gt;](./BusinessDataGoogleHotelInfoTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskPostResponseInfo&gt;](./BusinessDataGoogleHotelInfoTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Hotel Info will provide you with structured data available for a specific hotel entity on the Google Hotels platform: such as service description, location details, rating, amenities, reviews, images, prices, and more.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/task_post/?bash'

### **GoogleHotelInfoTasksReadyAsync()**

```csharp
public Task<BusinessDataGoogleHotelInfoTasksReadyResponseInfo> GoogleHotelInfoTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTasksReadyResponseInfo&gt;](./BusinessDataGoogleHotelInfoTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/tasks_ready/?bash'

### **GoogleHotelInfoTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelInfoTasksReadyResponseInfo> GoogleHotelInfoTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTasksReadyResponseInfo&gt;](./BusinessDataGoogleHotelInfoTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/tasks_ready/?bash'

### **GoogleHotelInfoTaskGetAdvancedAsync(String)**

```csharp
public Task<BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo> GoogleHotelInfoTaskGetAdvancedAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo&gt;](./BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/task_get/advanced/?bash'

### **GoogleHotelInfoTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo> GoogleHotelInfoTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo&gt;](./BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/task_get/advanced/?bash'

### **GoogleHotelInfoTaskGetHtmlAsync(String)**

```csharp
public Task<BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo> GoogleHotelInfoTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo&gt;](./BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/task_get/html/?bash'

### **GoogleHotelInfoTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo> GoogleHotelInfoTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo&gt;](./BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/task_get/html/?bash'

### **GoogleHotelInfoLiveAdvancedAsync(IEnumerable&lt;BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo> GoogleHotelInfoLiveAdvancedAsync(IEnumerable<BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo&gt;](./BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo&gt;](./BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Hotel Info will provide you with structured data available for a specific hotel entity on the Google Hotels platform: such as service description, location details, rating, amenities, reviews, images, prices, and more.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/live/advanced/?bash'

### **GoogleHotelInfoLiveAdvancedAsync(IEnumerable&lt;BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo> GoogleHotelInfoLiveAdvancedAsync(IEnumerable<BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo&gt;](./BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo&gt;](./BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Hotel Info will provide you with structured data available for a specific hotel entity on the Google Hotels platform: such as service description, location details, rating, amenities, reviews, images, prices, and more.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/live/advanced/?bash'

### **GoogleHotelInfoLiveHtmlAsync(IEnumerable&lt;BusinessDataGoogleHotelInfoLiveHtmlRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleHotelInfoLiveHtmlResponseInfo> GoogleHotelInfoLiveHtmlAsync(IEnumerable<BusinessDataGoogleHotelInfoLiveHtmlRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoLiveHtmlRequestInfo&gt;](./BusinessDataGoogleHotelInfoLiveHtmlRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoLiveHtmlResponseInfo&gt;](./BusinessDataGoogleHotelInfoLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Hotel Info will provide you with unstructured HTML data available for a specific hotel entity on the Google Hotels platform: such as service description, location details, rating, amenities, reviews, images, prices, and more.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/live/html/?bash'

### **GoogleHotelInfoLiveHtmlAsync(IEnumerable&lt;BusinessDataGoogleHotelInfoLiveHtmlRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelInfoLiveHtmlResponseInfo> GoogleHotelInfoLiveHtmlAsync(IEnumerable<BusinessDataGoogleHotelInfoLiveHtmlRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoLiveHtmlRequestInfo&gt;](./BusinessDataGoogleHotelInfoLiveHtmlRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoLiveHtmlResponseInfo&gt;](./BusinessDataGoogleHotelInfoLiveHtmlResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Google Hotel Info will provide you with unstructured HTML data available for a specific hotel entity on the Google Hotels platform: such as service description, location details, rating, amenities, reviews, images, prices, and more.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/live/html/?bash'

### **GoogleReviewsTaskPostAsync(IEnumerable&lt;BusinessDataGoogleReviewsTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleReviewsTaskPostResponseInfo> GoogleReviewsTaskPostAsync(IEnumerable<BusinessDataGoogleReviewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleReviewsTaskPostRequestInfo&gt;](./BusinessDataGoogleReviewsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleReviewsTaskPostResponseInfo&gt;](./BusinessDataGoogleReviewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides results from the “Reviews” element of Google SERPs. The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/reviews/task_post/?bash'

### **GoogleReviewsTaskPostAsync(IEnumerable&lt;BusinessDataGoogleReviewsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleReviewsTaskPostResponseInfo> GoogleReviewsTaskPostAsync(IEnumerable<BusinessDataGoogleReviewsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleReviewsTaskPostRequestInfo&gt;](./BusinessDataGoogleReviewsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleReviewsTaskPostResponseInfo&gt;](./BusinessDataGoogleReviewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides results from the “Reviews” element of Google SERPs. The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/reviews/task_post/?bash'

### **GoogleReviewsTasksReadyAsync()**

```csharp
public Task<BusinessDataGoogleReviewsTasksReadyResponseInfo> GoogleReviewsTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataGoogleReviewsTasksReadyResponseInfo&gt;](./BusinessDataGoogleReviewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/reviews/tasks_ready/?bash'

### **GoogleReviewsTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataGoogleReviewsTasksReadyResponseInfo> GoogleReviewsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleReviewsTasksReadyResponseInfo&gt;](./BusinessDataGoogleReviewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/reviews/tasks_ready/?bash'

### **GoogleReviewsTaskGetAsync(String)**

```csharp
public Task<BusinessDataGoogleReviewsTaskGetResponseInfo> GoogleReviewsTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleReviewsTaskGetResponseInfo&gt;](./BusinessDataGoogleReviewsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

The returned results are specific to the indicated local establishment name, search engine, location and language parameters. We emulate set location and search engine with the highest accuracy so that the results you receive will match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus would not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/reviews/task_get/?bash'

### **GoogleReviewsTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleReviewsTaskGetResponseInfo> GoogleReviewsTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleReviewsTaskGetResponseInfo&gt;](./BusinessDataGoogleReviewsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

The returned results are specific to the indicated local establishment name, search engine, location and language parameters. We emulate set location and search engine with the highest accuracy so that the results you receive will match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus would not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/reviews/task_get/?bash'

### **GoogleExtendedReviewsTaskPostAsync(IEnumerable&lt;BusinessDataGoogleExtendedReviewsTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleExtendedReviewsTaskPostResponseInfo> GoogleExtendedReviewsTaskPostAsync(IEnumerable<BusinessDataGoogleExtendedReviewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleExtendedReviewsTaskPostRequestInfo&gt;](./BusinessDataGoogleExtendedReviewsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleExtendedReviewsTaskPostResponseInfo&gt;](./BusinessDataGoogleExtendedReviewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides results from the “Reviews” element of Google SERPs, including not only Google user reviews but also reviews from other reputable sources (e.g., TripAdvisor, Yelp, Trustpilot). The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) parameters.
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/business_data/google/extended_reviews/task_post/?bash'

### **GoogleExtendedReviewsTaskPostAsync(IEnumerable&lt;BusinessDataGoogleExtendedReviewsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleExtendedReviewsTaskPostResponseInfo> GoogleExtendedReviewsTaskPostAsync(IEnumerable<BusinessDataGoogleExtendedReviewsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleExtendedReviewsTaskPostRequestInfo&gt;](./BusinessDataGoogleExtendedReviewsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleExtendedReviewsTaskPostResponseInfo&gt;](./BusinessDataGoogleExtendedReviewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides results from the “Reviews” element of Google SERPs, including not only Google user reviews but also reviews from other reputable sources (e.g., TripAdvisor, Yelp, Trustpilot). The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) parameters.
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/business_data/google/extended_reviews/task_post/?bash'

### **GoogleExtendedReviewsTasksReadyAsync()**

```csharp
public Task<BusinessDataGoogleExtendedReviewsTasksReadyResponseInfo> GoogleExtendedReviewsTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataGoogleExtendedReviewsTasksReadyResponseInfo&gt;](./BusinessDataGoogleExtendedReviewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/business_data/google/extended_reviews/tasks_ready/?bash'

### **GoogleExtendedReviewsTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataGoogleExtendedReviewsTasksReadyResponseInfo> GoogleExtendedReviewsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleExtendedReviewsTasksReadyResponseInfo&gt;](./BusinessDataGoogleExtendedReviewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/business_data/google/extended_reviews/tasks_ready/?bash'

### **GoogleExtendedReviewsTaskGetAsync(String)**

```csharp
public Task<BusinessDataGoogleExtendedReviewsTaskGetResponseInfo> GoogleExtendedReviewsTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleExtendedReviewsTaskGetResponseInfo&gt;](./BusinessDataGoogleExtendedReviewsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

The returned results are specific to the indicated local establishment name, search engine, location and language parameters. We emulate set location and search engine with the highest accuracy so that the results you receive will match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus would not be reflected in the returned results.
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/business_data/google/extended_reviews/task_get/?bash'

### **GoogleExtendedReviewsTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleExtendedReviewsTaskGetResponseInfo> GoogleExtendedReviewsTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleExtendedReviewsTaskGetResponseInfo&gt;](./BusinessDataGoogleExtendedReviewsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

The returned results are specific to the indicated local establishment name, search engine, location and language parameters. We emulate set location and search engine with the highest accuracy so that the results you receive will match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus would not be reflected in the returned results.
 <br>for more info please visit 'https://docs_v3.dataforseo.com/v3/business_data/google/extended_reviews/task_get/?bash'

### **GoogleQuestionsAndAnswersTaskPostAsync(IEnumerable&lt;BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleQuestionsAndAnswersTaskPostResponseInfo> GoogleQuestionsAndAnswersTaskPostAsync(IEnumerable<BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleQuestionsAndAnswersTaskPostResponseInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of questions and answers associated with a specific business entity listed on Google My Business. By submitting a request to this endpoint, you can access comprehensive data on the inquiries and responses related to a particular business, including the full text of the questions and answers, as well as metadata such as timestamps, user information.
 <br> 
 <br>The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br> 
 <br>Your account will be billed for every 20 questions, the maximum number of answers returned for each question is 5.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/questions_and_answers/task_post/?bash'

### **GoogleQuestionsAndAnswersTaskPostAsync(IEnumerable&lt;BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleQuestionsAndAnswersTaskPostResponseInfo> GoogleQuestionsAndAnswersTaskPostAsync(IEnumerable<BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleQuestionsAndAnswersTaskPostResponseInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of questions and answers associated with a specific business entity listed on Google My Business. By submitting a request to this endpoint, you can access comprehensive data on the inquiries and responses related to a particular business, including the full text of the questions and answers, as well as metadata such as timestamps, user information.
 <br> 
 <br>The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br> 
 <br>Your account will be billed for every 20 questions, the maximum number of answers returned for each question is 5.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/questions_and_answers/task_post/?bash'

### **GoogleQuestionsAndAnswersTasksReadyAsync()**

```csharp
public Task<BusinessDataGoogleQuestionsAndAnswersTasksReadyResponseInfo> GoogleQuestionsAndAnswersTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataGoogleQuestionsAndAnswersTasksReadyResponseInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/questions_and_answers/tasks_ready/?bash'

### **GoogleQuestionsAndAnswersTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataGoogleQuestionsAndAnswersTasksReadyResponseInfo> GoogleQuestionsAndAnswersTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleQuestionsAndAnswersTasksReadyResponseInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/questions_and_answers/tasks_ready/?bash'

### **GoogleQuestionsAndAnswersTaskGetAsync(String)**

```csharp
public Task<BusinessDataGoogleQuestionsAndAnswersTaskGetResponseInfo> GoogleQuestionsAndAnswersTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleQuestionsAndAnswersTaskGetResponseInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/questions_and_answers/task_get/?bash'

### **GoogleQuestionsAndAnswersTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleQuestionsAndAnswersTaskGetResponseInfo> GoogleQuestionsAndAnswersTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleQuestionsAndAnswersTaskGetResponseInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/questions_and_answers/task_get/?bash'

### **GoogleQuestionsAndAnswersLiveAsync(IEnumerable&lt;BusinessDataGoogleQuestionsAndAnswersLiveRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleQuestionsAndAnswersLiveResponseInfo> GoogleQuestionsAndAnswersLiveAsync(IEnumerable<BusinessDataGoogleQuestionsAndAnswersLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleQuestionsAndAnswersLiveRequestInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersLiveRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleQuestionsAndAnswersLiveResponseInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of questions and answers associated with a specific business entity listed on Google My Business. By submitting a request to this endpoint, you can access comprehensive data on the inquiries and responses related to a particular business, including the full text of the questions and answers, as well as metadata such as timestamps, user information.
 <br> 
 <br>The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br> 
 <br>Your account will be billed for every 20 questions, the maximum number of answers returned for each question is 5.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/questions_and_answers/live/?bash'

### **GoogleQuestionsAndAnswersLiveAsync(IEnumerable&lt;BusinessDataGoogleQuestionsAndAnswersLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleQuestionsAndAnswersLiveResponseInfo> GoogleQuestionsAndAnswersLiveAsync(IEnumerable<BusinessDataGoogleQuestionsAndAnswersLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleQuestionsAndAnswersLiveRequestInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleQuestionsAndAnswersLiveResponseInfo&gt;](./BusinessDataGoogleQuestionsAndAnswersLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a detailed overview of questions and answers associated with a specific business entity listed on Google My Business. By submitting a request to this endpoint, you can access comprehensive data on the inquiries and responses related to a particular business, including the full text of the questions and answers, as well as metadata such as timestamps, user information.
 <br> 
 <br>The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br> 
 <br>Your account will be billed for every 20 questions, the maximum number of answers returned for each question is 5.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/questions_and_answers/live/?bash'

### **TrustpilotSearchTaskPostAsync(IEnumerable&lt;BusinessDataTrustpilotSearchTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataTrustpilotSearchTaskPostResponseInfo> TrustpilotSearchTaskPostAsync(IEnumerable<BusinessDataTrustpilotSearchTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTrustpilotSearchTaskPostRequestInfo&gt;](./BusinessDataTrustpilotSearchTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataTrustpilotSearchTaskPostResponseInfo&gt;](./BusinessDataTrustpilotSearchTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides a list of business profiles listed on the Trustpilot platform. The returned results are relevant to the specified keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/search/task_post/?bash'

### **TrustpilotSearchTaskPostAsync(IEnumerable&lt;BusinessDataTrustpilotSearchTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataTrustpilotSearchTaskPostResponseInfo> TrustpilotSearchTaskPostAsync(IEnumerable<BusinessDataTrustpilotSearchTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTrustpilotSearchTaskPostRequestInfo&gt;](./BusinessDataTrustpilotSearchTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotSearchTaskPostResponseInfo&gt;](./BusinessDataTrustpilotSearchTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides a list of business profiles listed on the Trustpilot platform. The returned results are relevant to the specified keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/search/task_post/?bash'

### **TrustpilotSearchTasksReadyAsync()**

```csharp
public Task<BusinessDataTrustpilotSearchTasksReadyResponseInfo> TrustpilotSearchTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataTrustpilotSearchTasksReadyResponseInfo&gt;](./BusinessDataTrustpilotSearchTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/search/tasks_ready/?bash'

### **TrustpilotSearchTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataTrustpilotSearchTasksReadyResponseInfo> TrustpilotSearchTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotSearchTasksReadyResponseInfo&gt;](./BusinessDataTrustpilotSearchTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/search/tasks_ready/?bash'

### **TrustpilotSearchTaskGetAsync(String)**

```csharp
public Task<BusinessDataTrustpilotSearchTaskGetResponseInfo> TrustpilotSearchTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataTrustpilotSearchTaskGetResponseInfo&gt;](./BusinessDataTrustpilotSearchTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides a list of business profiles listed on the Trustpilot platform. The returned results are relevant to the keyword specified in a POST request. We emulate set parameters with the highest accuracy so that the results you receive match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus will not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/search/task_get/?bash'

### **TrustpilotSearchTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataTrustpilotSearchTaskGetResponseInfo> TrustpilotSearchTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotSearchTaskGetResponseInfo&gt;](./BusinessDataTrustpilotSearchTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides a list of business profiles listed on the Trustpilot platform. The returned results are relevant to the keyword specified in a POST request. We emulate set parameters with the highest accuracy so that the results you receive match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus will not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/search/task_get/?bash'

### **TrustpilotReviewsTaskPostAsync(IEnumerable&lt;BusinessDataTrustpilotReviewsTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataTrustpilotReviewsTaskPostResponseInfo> TrustpilotReviewsTaskPostAsync(IEnumerable<BusinessDataTrustpilotReviewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTrustpilotReviewsTaskPostRequestInfo&gt;](./BusinessDataTrustpilotReviewsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataTrustpilotReviewsTaskPostResponseInfo&gt;](./BusinessDataTrustpilotReviewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides reviews published on the Trustpilot platform for the local establishment specified in the domain field.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/reviews/task_post/?bash'

### **TrustpilotReviewsTaskPostAsync(IEnumerable&lt;BusinessDataTrustpilotReviewsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataTrustpilotReviewsTaskPostResponseInfo> TrustpilotReviewsTaskPostAsync(IEnumerable<BusinessDataTrustpilotReviewsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTrustpilotReviewsTaskPostRequestInfo&gt;](./BusinessDataTrustpilotReviewsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotReviewsTaskPostResponseInfo&gt;](./BusinessDataTrustpilotReviewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides reviews published on the Trustpilot platform for the local establishment specified in the domain field.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/reviews/task_post/?bash'

### **TrustpilotReviewsTasksReadyAsync()**

```csharp
public Task<BusinessDataTrustpilotReviewsTasksReadyResponseInfo> TrustpilotReviewsTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataTrustpilotReviewsTasksReadyResponseInfo&gt;](./BusinessDataTrustpilotReviewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/reviews/tasks_ready/?bash'

### **TrustpilotReviewsTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataTrustpilotReviewsTasksReadyResponseInfo> TrustpilotReviewsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotReviewsTasksReadyResponseInfo&gt;](./BusinessDataTrustpilotReviewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/reviews/tasks_ready/?bash'

### **TrustpilotReviewsTaskGetAsync(String)**

```csharp
public Task<BusinessDataTrustpilotReviewsTaskGetResponseInfo> TrustpilotReviewsTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataTrustpilotReviewsTaskGetResponseInfo&gt;](./BusinessDataTrustpilotReviewsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides reviews published on the Trustpilot platform The returned results are specific to the indicated business entity. We emulate set parameters with the highest accuracy so that the results you receive will match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus would not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/reviews/task_get/?bash'

### **TrustpilotReviewsTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataTrustpilotReviewsTaskGetResponseInfo> TrustpilotReviewsTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotReviewsTaskGetResponseInfo&gt;](./BusinessDataTrustpilotReviewsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides reviews published on the Trustpilot platform The returned results are specific to the indicated business entity. We emulate set parameters with the highest accuracy so that the results you receive will match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus would not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/reviews/task_get/?bash'

### **BusinessDataTripadvisorLocationsAsync()**

```csharp
public Task<BusinessDataTripadvisorLocationsResponseInfo> BusinessDataTripadvisorLocationsAsync()
```

#### Returns

[Task&lt;BusinessDataTripadvisorLocationsResponseInfo&gt;](./BusinessDataTripadvisorLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task. Note that supported location types in Tripadvisor Business Data API are City and Region only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/locations/?bash'

### **BusinessDataTripadvisorLocationsAsync(CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorLocationsResponseInfo> BusinessDataTripadvisorLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorLocationsResponseInfo&gt;](./BusinessDataTripadvisorLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task. Note that supported location types in Tripadvisor Business Data API are City and Region only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/locations/?bash'

### **BusinessDataTripadvisorLocationsCountryAsync(String)**

```csharp
public Task<BusinessDataTripadvisorLocationsCountryResponseInfo> BusinessDataTripadvisorLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;BusinessDataTripadvisorLocationsCountryResponseInfo&gt;](./BusinessDataTripadvisorLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task. Note that supported location types in Tripadvisor Business Data API are City and Region only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/locations/?bash'

### **BusinessDataTripadvisorLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorLocationsCountryResponseInfo> BusinessDataTripadvisorLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;BusinessDataTripadvisorLocationsCountryResponseInfo&gt;](./BusinessDataTripadvisorLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task. Note that supported location types in Tripadvisor Business Data API are City and Region only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/locations/?bash'

### **BusinessDataTripadvisorLanguagesAsync()**

```csharp
public Task<BusinessDataTripadvisorLanguagesResponseInfo> BusinessDataTripadvisorLanguagesAsync()
```

#### Returns

[Task&lt;BusinessDataTripadvisorLanguagesResponseInfo&gt;](./BusinessDataTripadvisorLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/languages/?bash'

### **BusinessDataTripadvisorLanguagesAsync(CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorLanguagesResponseInfo> BusinessDataTripadvisorLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorLanguagesResponseInfo&gt;](./BusinessDataTripadvisorLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/languages/?bash'

### **TripadvisorSearchTaskPostAsync(IEnumerable&lt;BusinessDataTripadvisorSearchTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataTripadvisorSearchTaskPostResponseInfo> TripadvisorSearchTaskPostAsync(IEnumerable<BusinessDataTripadvisorSearchTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTripadvisorSearchTaskPostRequestInfo&gt;](./BusinessDataTripadvisorSearchTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataTripadvisorSearchTaskPostResponseInfo&gt;](./BusinessDataTripadvisorSearchTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides a list of business profiles listed on the Tripadvisor platform. The returned results are relevant to the specified keyword and the selected location (see the List of Locations).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/search/task_post/?bash'

### **TripadvisorSearchTaskPostAsync(IEnumerable&lt;BusinessDataTripadvisorSearchTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorSearchTaskPostResponseInfo> TripadvisorSearchTaskPostAsync(IEnumerable<BusinessDataTripadvisorSearchTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTripadvisorSearchTaskPostRequestInfo&gt;](./BusinessDataTripadvisorSearchTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorSearchTaskPostResponseInfo&gt;](./BusinessDataTripadvisorSearchTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides a list of business profiles listed on the Tripadvisor platform. The returned results are relevant to the specified keyword and the selected location (see the List of Locations).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/search/task_post/?bash'

### **TripadvisorSearchTasksReadyAsync()**

```csharp
public Task<BusinessDataTripadvisorSearchTasksReadyResponseInfo> TripadvisorSearchTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataTripadvisorSearchTasksReadyResponseInfo&gt;](./BusinessDataTripadvisorSearchTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/search/tasks_ready/?bash'

### **TripadvisorSearchTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorSearchTasksReadyResponseInfo> TripadvisorSearchTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorSearchTasksReadyResponseInfo&gt;](./BusinessDataTripadvisorSearchTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/search/tasks_ready/?bash'

### **TripadvisorSearchTaskGetAsync(String)**

```csharp
public Task<BusinessDataTripadvisorSearchTaskGetResponseInfo> TripadvisorSearchTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataTripadvisorSearchTaskGetResponseInfo&gt;](./BusinessDataTripadvisorSearchTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with data on businesses listed on the Tripadvisor platform. The results obtained through this endpoint are specific to the location (see the List of Tripadvisor Locations) and keyword parameters used in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/search/task_get/?bash'

### **TripadvisorSearchTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorSearchTaskGetResponseInfo> TripadvisorSearchTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorSearchTaskGetResponseInfo&gt;](./BusinessDataTripadvisorSearchTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with data on businesses listed on the Tripadvisor platform. The results obtained through this endpoint are specific to the location (see the List of Tripadvisor Locations) and keyword parameters used in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/search/task_get/?bash'

### **TripadvisorReviewsTaskPostAsync(IEnumerable&lt;BusinessDataTripadvisorReviewsTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataTripadvisorReviewsTaskPostResponseInfo> TripadvisorReviewsTaskPostAsync(IEnumerable<BusinessDataTripadvisorReviewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTripadvisorReviewsTaskPostRequestInfo&gt;](./BusinessDataTripadvisorReviewsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataTripadvisorReviewsTaskPostResponseInfo&gt;](./BusinessDataTripadvisorReviewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides results from the “Reviews” element on the Tripadvisor platform. The results are specific to the URL path or keyword you indicate, and and the selected location (see the List of Locations).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/reviews/task_post/?bash'

### **TripadvisorReviewsTaskPostAsync(IEnumerable&lt;BusinessDataTripadvisorReviewsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorReviewsTaskPostResponseInfo> TripadvisorReviewsTaskPostAsync(IEnumerable<BusinessDataTripadvisorReviewsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTripadvisorReviewsTaskPostRequestInfo&gt;](./BusinessDataTripadvisorReviewsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorReviewsTaskPostResponseInfo&gt;](./BusinessDataTripadvisorReviewsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides results from the “Reviews” element on the Tripadvisor platform. The results are specific to the URL path or keyword you indicate, and and the selected location (see the List of Locations).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/reviews/task_post/?bash'

### **TripadvisorReviewsTasksReadyAsync()**

```csharp
public Task<BusinessDataTripadvisorReviewsTasksReadyResponseInfo> TripadvisorReviewsTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataTripadvisorReviewsTasksReadyResponseInfo&gt;](./BusinessDataTripadvisorReviewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/reviews/tasks_ready/?bash'

### **TripadvisorReviewsTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorReviewsTasksReadyResponseInfo> TripadvisorReviewsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorReviewsTasksReadyResponseInfo&gt;](./BusinessDataTripadvisorReviewsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/reviews/tasks_ready/?bash'

### **TripadvisorReviewsTaskGetAsync(String)**

```csharp
public Task<BusinessDataTripadvisorReviewsTaskGetResponseInfo> TripadvisorReviewsTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataTripadvisorReviewsTaskGetResponseInfo&gt;](./BusinessDataTripadvisorReviewsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides feedback data on businesses listed on the Tripadvisor platform, including their locations, ratings, review content and count. The results are specific to the URL path indicated in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/reviews/task_get/?bash'

### **TripadvisorReviewsTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorReviewsTaskGetResponseInfo> TripadvisorReviewsTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorReviewsTaskGetResponseInfo&gt;](./BusinessDataTripadvisorReviewsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides feedback data on businesses listed on the Tripadvisor platform, including their locations, ratings, review content and count. The results are specific to the URL path indicated in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/reviews/task_get/?bash'

### **SocialMediaPinterestLiveAsync(IEnumerable&lt;BusinessDataSocialMediaPinterestLiveRequestInfo&gt;)**

```csharp
public Task<BusinessDataSocialMediaPinterestLiveResponseInfo> SocialMediaPinterestLiveAsync(IEnumerable<BusinessDataSocialMediaPinterestLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataSocialMediaPinterestLiveRequestInfo&gt;](./BusinessDataSocialMediaPinterestLiveRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataSocialMediaPinterestLiveResponseInfo&gt;](./BusinessDataSocialMediaPinterestLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Social Media Pinterest API will provide you with data on pins made from the specified URLs. Pins on Pinterest correspond to content saves. For each specified page URL, you will get the number of content saves to Pinterest made using the Pinterest Save Button placed on that page.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/social_media/pinterest/live/?bash'

### **SocialMediaPinterestLiveAsync(IEnumerable&lt;BusinessDataSocialMediaPinterestLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataSocialMediaPinterestLiveResponseInfo> SocialMediaPinterestLiveAsync(IEnumerable<BusinessDataSocialMediaPinterestLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataSocialMediaPinterestLiveRequestInfo&gt;](./BusinessDataSocialMediaPinterestLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataSocialMediaPinterestLiveResponseInfo&gt;](./BusinessDataSocialMediaPinterestLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Social Media Pinterest API will provide you with data on pins made from the specified URLs. Pins on Pinterest correspond to content saves. For each specified page URL, you will get the number of content saves to Pinterest made using the Pinterest Save Button placed on that page.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/social_media/pinterest/live/?bash'

### **SocialMediaFacebookLiveAsync(IEnumerable&lt;BusinessDataSocialMediaFacebookLiveRequestInfo&gt;)**

```csharp
public Task<BusinessDataSocialMediaFacebookLiveResponseInfo> SocialMediaFacebookLiveAsync(IEnumerable<BusinessDataSocialMediaFacebookLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataSocialMediaFacebookLiveRequestInfo&gt;](./BusinessDataSocialMediaFacebookLiveRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataSocialMediaFacebookLiveResponseInfo&gt;](./BusinessDataSocialMediaFacebookLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Social Media Facebook API will provide you with the number of likes a certain page received through the Facebook Like button embed.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/social_media/facebook/live/?bash'

### **SocialMediaFacebookLiveAsync(IEnumerable&lt;BusinessDataSocialMediaFacebookLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataSocialMediaFacebookLiveResponseInfo> SocialMediaFacebookLiveAsync(IEnumerable<BusinessDataSocialMediaFacebookLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataSocialMediaFacebookLiveRequestInfo&gt;](./BusinessDataSocialMediaFacebookLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataSocialMediaFacebookLiveResponseInfo&gt;](./BusinessDataSocialMediaFacebookLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Social Media Facebook API will provide you with the number of likes a certain page received through the Facebook Like button embed.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/social_media/facebook/live/?bash'

### **SocialMediaRedditLiveAsync(IEnumerable&lt;BusinessDataSocialMediaRedditLiveRequestInfo&gt;)**

```csharp
public Task<BusinessDataSocialMediaRedditLiveResponseInfo> SocialMediaRedditLiveAsync(IEnumerable<BusinessDataSocialMediaRedditLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataSocialMediaRedditLiveRequestInfo&gt;](./BusinessDataSocialMediaRedditLiveRequestInfo.md)<br>

#### Returns

[Task&lt;BusinessDataSocialMediaRedditLiveResponseInfo&gt;](./BusinessDataSocialMediaRedditLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Social Media Reddit API provides information for each share of the target webpage on Reddit. For each specified Reddit URL, you will get subreddit and author names, permalink, title, and the number of subreddit members.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/social_media/reddit/live/?bash'

### **SocialMediaRedditLiveAsync(IEnumerable&lt;BusinessDataSocialMediaRedditLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataSocialMediaRedditLiveResponseInfo> SocialMediaRedditLiveAsync(IEnumerable<BusinessDataSocialMediaRedditLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataSocialMediaRedditLiveRequestInfo&gt;](./BusinessDataSocialMediaRedditLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataSocialMediaRedditLiveResponseInfo&gt;](./BusinessDataSocialMediaRedditLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Social Media Reddit API provides information for each share of the target webpage on Reddit. For each specified Reddit URL, you will get subreddit and author names, permalink, title, and the number of subreddit members.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/social_media/reddit/live/?bash'

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
