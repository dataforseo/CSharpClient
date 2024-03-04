# BusinessDataApi

Namespace: DataForSeo.Client.Api

```csharp
public class BusinessDataApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataApi](./dataforseo.client.api.businessdataapi.md)

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

`body` [IEnumerable&lt;BusinessDataIdListRequestInfo&gt;](./dataforseo.client.models.requests.businessdataidlistrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataIdListResponseInfo&gt;](./dataforseo.client.models.responses.businessdataidlistresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Business Data tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/id_list/?bash'

### **BusinessDataIdListAsync(IEnumerable&lt;BusinessDataIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataIdListResponseInfo> BusinessDataIdListAsync(IEnumerable<BusinessDataIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataIdListRequestInfo&gt;](./dataforseo.client.models.requests.businessdataidlistrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataIdListResponseInfo&gt;](./dataforseo.client.models.responses.businessdataidlistresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Business Data tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/id_list/?bash'

### **BusinessDataErrorsAsync(IEnumerable&lt;BusinessDataErrorsRequestInfo&gt;)**

```csharp
public Task<BusinessDataErrorsResponseInfo> BusinessDataErrorsAsync(IEnumerable<BusinessDataErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataErrorsRequestInfo&gt;](./dataforseo.client.models.requests.businessdataerrorsrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataErrorsResponseInfo&gt;](./dataforseo.client.models.responses.businessdataerrorsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Business Data API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/errors/?bash'

### **BusinessDataErrorsAsync(IEnumerable&lt;BusinessDataErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataErrorsResponseInfo> BusinessDataErrorsAsync(IEnumerable<BusinessDataErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataErrorsRequestInfo&gt;](./dataforseo.client.models.requests.businessdataerrorsrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataErrorsResponseInfo&gt;](./dataforseo.client.models.responses.businessdataerrorsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Business Data API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/errors/?bash'

### **BusinessDataBusinessListingsLocationsAsync()**

```csharp
public Task<BusinessDataBusinessListingsLocationsResponseInfo> BusinessDataBusinessListingsLocationsAsync()
```

#### Returns

[Task&lt;BusinessDataBusinessListingsLocationsResponseInfo&gt;](./dataforseo.client.models.responses.businessdatabusinesslistingslocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can also download the full list of supported locations in the CSV format (last updated 2023-12-29).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/locations/?bash'

### **BusinessDataBusinessListingsLocationsAsync(CancellationToken)**

```csharp
public Task<BusinessDataBusinessListingsLocationsResponseInfo> BusinessDataBusinessListingsLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataBusinessListingsLocationsResponseInfo&gt;](./dataforseo.client.models.responses.businessdatabusinesslistingslocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can also download the full list of supported locations in the CSV format (last updated 2023-12-29).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/locations/?bash'

### **BusinessListingsCategoriesAsync()**

```csharp
public Task<BusinessDataBusinessListingsCategoriesResponseInfo> BusinessListingsCategoriesAsync()
```

#### Returns

[Task&lt;BusinessDataBusinessListingsCategoriesResponseInfo&gt;](./dataforseo.client.models.responses.businessdatabusinesslistingscategoriesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the list of top categories by business count.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/categories/?bash'

### **BusinessListingsCategoriesAsync(CancellationToken)**

```csharp
public Task<BusinessDataBusinessListingsCategoriesResponseInfo> BusinessListingsCategoriesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataBusinessListingsCategoriesResponseInfo&gt;](./dataforseo.client.models.responses.businessdatabusinesslistingscategoriesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the list of top categories by business count.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/business_listings/categories/?bash'

### **BusinessListingsAvailableFiltersAsync()**

```csharp
public Task<BusinessDataBusinessListingsAvailableFiltersResponseInfo> BusinessListingsAvailableFiltersAsync()
```

#### Returns

[Task&lt;BusinessDataBusinessListingsAvailableFiltersResponseInfo&gt;](./dataforseo.client.models.responses.businessdatabusinesslistingsavailablefiltersresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataBusinessListingsAvailableFiltersResponseInfo&gt;](./dataforseo.client.models.responses.businessdatabusinesslistingsavailablefiltersresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataBusinessListingsSearchLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatabusinesslistingssearchliverequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataBusinessListingsSearchLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatabusinesslistingssearchliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataBusinessListingsSearchLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatabusinesslistingssearchliverequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataBusinessListingsSearchLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatabusinesslistingssearchliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatabusinesslistingscategoriesaggregationliverequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataBusinessListingsCategoriesAggregationLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatabusinesslistingscategoriesaggregationliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataBusinessListingsCategoriesAggregationLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatabusinesslistingscategoriesaggregationliverequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataBusinessListingsCategoriesAggregationLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatabusinesslistingscategoriesaggregationliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

[Task&lt;BusinessDataGoogleLocationsResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglelocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/locations/?bash'

### **BusinessDataGoogleLocationsAsync(CancellationToken)**

```csharp
public Task<BusinessDataGoogleLocationsResponseInfo> BusinessDataGoogleLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleLocationsResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglelocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/locations/?bash'

### **BusinessDataGoogleLocationsCountryAsync(String)**

```csharp
public Task<BusinessDataGoogleLocationsCountryResponseInfo> BusinessDataGoogleLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;BusinessDataGoogleLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglelocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/locations/?bash'

### **BusinessDataGoogleLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleLocationsCountryResponseInfo> BusinessDataGoogleLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;BusinessDataGoogleLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglelocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/locations/?bash'

### **BusinessDataGoogleLanguagesAsync()**

```csharp
public Task<BusinessDataGoogleLanguagesResponseInfo> BusinessDataGoogleLanguagesAsync()
```

#### Returns

[Task&lt;BusinessDataGoogleLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglelanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/languages/?bash'

### **BusinessDataGoogleLanguagesAsync(CancellationToken)**

```csharp
public Task<BusinessDataGoogleLanguagesResponseInfo> BusinessDataGoogleLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglelanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/languages/?bash'

### **GoogleMyBusinessInfoTaskPostAsync(IEnumerable&lt;BusinessDataTaskRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo> GoogleMyBusinessInfoTaskPostAsync(IEnumerable<BusinessDataTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTaskRequestInfo&gt;](./dataforseo.client.models.requests.businessdatataskrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessinfotaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Business Data API provides results containing information about specific business entity from Google. The provided results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/task_post/?bash'

### **GoogleMyBusinessInfoTaskPostAsync(IEnumerable&lt;BusinessDataTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo> GoogleMyBusinessInfoTaskPostAsync(IEnumerable<BusinessDataTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTaskRequestInfo&gt;](./dataforseo.client.models.requests.businessdatataskrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessinfotaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

[Task&lt;BusinessDataGoogleMyBusinessInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessinfotasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessinfotasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessinfotaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/task_get/?bash'

### **GoogleMyBusinessInfoTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo> GoogleMyBusinessInfoTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessInfoTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessinfotaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_info/task_get/?bash'

### **GoogleMyBusinessUpdatesTaskPostAsync(IEnumerable&lt;BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo> GoogleMyBusinessUpdatesTaskPostAsync(IEnumerable<BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglemybusinessupdatestaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessupdatestaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglemybusinessupdatestaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessupdatestaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessupdatestasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessupdatestasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessupdatestaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_updates/task_get/?bash'

### **GoogleMyBusinessUpdatesTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo> GoogleMyBusinessUpdatesTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleMyBusinessUpdatesTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglemybusinessupdatestaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/my_business_updates/task_get/?bash'

### **GoogleHotelSearchesTaskPostAsync(IEnumerable&lt;BusinessDataGoogleHotelSearchesTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleHotelSearchesTaskPostResponseInfo> GoogleHotelSearchesTaskPostAsync(IEnumerable<BusinessDataGoogleHotelSearchesTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelSearchesTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglehotelsearchestaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelsearchestaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataGoogleHotelSearchesTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglehotelsearchestaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelsearchestaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

[Task&lt;BusinessDataGoogleHotelSearchesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelsearchestasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelsearchestasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelsearchestaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_searches/task_get/?bash'

### **GoogleHotelSearchesTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelSearchesTaskGetResponseInfo> GoogleHotelSearchesTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelsearchestaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_searches/task_get/?bash'

### **GoogleHotelSearchesLiveAsync(IEnumerable&lt;BusinessDataGoogleHotelSearchesLiveRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleHotelSearchesLiveResponseInfo> GoogleHotelSearchesLiveAsync(IEnumerable<BusinessDataGoogleHotelSearchesLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelSearchesLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglehotelsearchesliverequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelsearchesliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataGoogleHotelSearchesLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglehotelsearchesliverequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelSearchesLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelsearchesliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglehotelinfotaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfotaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglehotelinfotaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfotaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

[Task&lt;BusinessDataGoogleHotelInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfotasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfotasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfotaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/task_get/advanced/?bash'

### **GoogleHotelInfoTaskGetAdvancedAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo> GoogleHotelInfoTaskGetAdvancedAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskGetAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfotaskgetadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/task_get/advanced/?bash'

### **GoogleHotelInfoTaskGetHtmlAsync(String)**

```csharp
public Task<BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo> GoogleHotelInfoTaskGetHtmlAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfotaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/task_get/html/?bash'

### **GoogleHotelInfoTaskGetHtmlAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo> GoogleHotelInfoTaskGetHtmlAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoTaskGetHtmlResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfotaskgethtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/hotel_info/task_get/html/?bash'

### **GoogleHotelInfoLiveAdvancedAsync(IEnumerable&lt;BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo&gt;)**

```csharp
public Task<BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo> GoogleHotelInfoLiveAdvancedAsync(IEnumerable<BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglehotelinfoliveadvancedrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfoliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoLiveAdvancedRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglehotelinfoliveadvancedrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoLiveAdvancedResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfoliveadvancedresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoLiveHtmlRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglehotelinfolivehtmlrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfolivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataGoogleHotelInfoLiveHtmlRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglehotelinfolivehtmlrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleHotelInfoLiveHtmlResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglehotelinfolivehtmlresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataGoogleReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglereviewstaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataGoogleReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglereviewstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataGoogleReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatagooglereviewstaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglereviewstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

[Task&lt;BusinessDataGoogleReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglereviewstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglereviewstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataGoogleReviewsTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglereviewstaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

The returned results are specific to the indicated local establishment name, search engine, location and language parameters. We emulate set location and search engine with the highest accuracy so that the results you receive will match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus would not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/reviews/task_get/?bash'

### **GoogleReviewsTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataGoogleReviewsTaskGetResponseInfo> GoogleReviewsTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataGoogleReviewsTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatagooglereviewstaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

The returned results are specific to the indicated local establishment name, search engine, location and language parameters. We emulate set location and search engine with the highest accuracy so that the results you receive will match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus would not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/google/reviews/task_get/?bash'

### **TrustpilotSearchTaskPostAsync(IEnumerable&lt;BusinessDataTrustpilotSearchTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataTrustpilotSearchTaskPostResponseInfo> TrustpilotSearchTaskPostAsync(IEnumerable<BusinessDataTrustpilotSearchTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTrustpilotSearchTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatatrustpilotsearchtaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataTrustpilotSearchTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotsearchtaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataTrustpilotSearchTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatatrustpilotsearchtaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotSearchTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotsearchtaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

[Task&lt;BusinessDataTrustpilotSearchTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotsearchtasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotSearchTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotsearchtasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataTrustpilotSearchTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotsearchtaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides a list of business profiles listed on the Trustpilot platform. The returned results are relevant to the keyword specified in a POST request. We emulate set parameters with the highest accuracy so that the results you receive match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus will not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/search/task_get/?bash'

### **TrustpilotSearchTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataTrustpilotSearchTaskGetResponseInfo> TrustpilotSearchTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotSearchTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotsearchtaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides a list of business profiles listed on the Trustpilot platform. The returned results are relevant to the keyword specified in a POST request. We emulate set parameters with the highest accuracy so that the results you receive match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus will not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/search/task_get/?bash'

### **TrustpilotReviewsTaskPostAsync(IEnumerable&lt;BusinessDataTrustpilotReviewsTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataTrustpilotReviewsTaskPostResponseInfo> TrustpilotReviewsTaskPostAsync(IEnumerable<BusinessDataTrustpilotReviewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTrustpilotReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatatrustpilotreviewstaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataTrustpilotReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotreviewstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataTrustpilotReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatatrustpilotreviewstaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotreviewstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

[Task&lt;BusinessDataTrustpilotReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotreviewstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotreviewstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataTrustpilotReviewsTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotreviewstaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides reviews published on the Trustpilot platform The returned results are specific to the indicated business entity. We emulate set parameters with the highest accuracy so that the results you receive will match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus would not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/reviews/task_get/?bash'

### **TrustpilotReviewsTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataTrustpilotReviewsTaskGetResponseInfo> TrustpilotReviewsTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTrustpilotReviewsTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatrustpilotreviewstaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides reviews published on the Trustpilot platform The returned results are specific to the indicated business entity. We emulate set parameters with the highest accuracy so that the results you receive will match the actual search results for the specified parameters at the time of task setting. You can always check the returned results accessing the check_url in the Incognito mode to make sure the received data is entirely relevant. Note that user preferences, search history, and other personalized search factors are ignored by our system and thus would not be reflected in the returned results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/trustpilot/reviews/task_get/?bash'

### **BusinessDataTripadvisorLocationsAsync()**

```csharp
public Task<BusinessDataTripadvisorLocationsResponseInfo> BusinessDataTripadvisorLocationsAsync()
```

#### Returns

[Task&lt;BusinessDataTripadvisorLocationsResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorlocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task. Note that supported location types in Tripadvisor Business Data API are City and Region only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/locations/?bash'

### **BusinessDataTripadvisorLocationsAsync(CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorLocationsResponseInfo> BusinessDataTripadvisorLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorLocationsResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorlocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task. Note that supported location types in Tripadvisor Business Data API are City and Region only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/locations/?bash'

### **BusinessDataTripadvisorLocationsCountryAsync(String)**

```csharp
public Task<BusinessDataTripadvisorLocationsCountryResponseInfo> BusinessDataTripadvisorLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;BusinessDataTripadvisorLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorlocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task. Note that supported location types in Tripadvisor Business Data API are City and Region only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/locations/?bash'

### **BusinessDataTripadvisorLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorLocationsCountryResponseInfo> BusinessDataTripadvisorLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;BusinessDataTripadvisorLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorlocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task. Note that supported location types in Tripadvisor Business Data API are City and Region only.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/locations/?bash'

### **BusinessDataTripadvisorLanguagesAsync()**

```csharp
public Task<BusinessDataTripadvisorLanguagesResponseInfo> BusinessDataTripadvisorLanguagesAsync()
```

#### Returns

[Task&lt;BusinessDataTripadvisorLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorlanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/languages/?bash'

### **BusinessDataTripadvisorLanguagesAsync(CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorLanguagesResponseInfo> BusinessDataTripadvisorLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorlanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/languages/?bash'

### **TripadvisorSearchTaskPostAsync(IEnumerable&lt;BusinessDataTripadvisorSearchTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataTripadvisorSearchTaskPostResponseInfo> TripadvisorSearchTaskPostAsync(IEnumerable<BusinessDataTripadvisorSearchTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTripadvisorSearchTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatatripadvisorsearchtaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataTripadvisorSearchTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorsearchtaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataTripadvisorSearchTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatatripadvisorsearchtaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorSearchTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorsearchtaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

[Task&lt;BusinessDataTripadvisorSearchTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorsearchtasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorSearchTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorsearchtasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataTripadvisorSearchTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorsearchtaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with data on businesses listed on the Tripadvisor platform. The results obtained through this endpoint are specific to the location (see the List of Tripadvisor Locations) and keyword parameters used in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/search/task_get/?bash'

### **TripadvisorSearchTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorSearchTaskGetResponseInfo> TripadvisorSearchTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorSearchTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorsearchtaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with data on businesses listed on the Tripadvisor platform. The results obtained through this endpoint are specific to the location (see the List of Tripadvisor Locations) and keyword parameters used in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/search/task_get/?bash'

### **TripadvisorReviewsTaskPostAsync(IEnumerable&lt;BusinessDataTripadvisorReviewsTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataTripadvisorReviewsTaskPostResponseInfo> TripadvisorReviewsTaskPostAsync(IEnumerable<BusinessDataTripadvisorReviewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataTripadvisorReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatatripadvisorreviewstaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataTripadvisorReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorreviewstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataTripadvisorReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatatripadvisorreviewstaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorreviewstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

[Task&lt;BusinessDataTripadvisorReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorreviewstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorreviewstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataTripadvisorReviewsTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorreviewstaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides feedback data on businesses listed on the Tripadvisor platform, including their locations, ratings, review content and count. The results are specific to the URL path indicated in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/reviews/task_get/?bash'

### **TripadvisorReviewsTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataTripadvisorReviewsTaskGetResponseInfo> TripadvisorReviewsTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataTripadvisorReviewsTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatatripadvisorreviewstaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides feedback data on businesses listed on the Tripadvisor platform, including their locations, ratings, review content and count. The results are specific to the URL path indicated in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/tripadvisor/reviews/task_get/?bash'

### **BusinessDataYelpLocationsAsync()**

```csharp
public Task<BusinessDataYelpLocationsResponseInfo> BusinessDataYelpLocationsAsync()
```

#### Returns

[Task&lt;BusinessDataYelpLocationsResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelplocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/locations/?bash'

### **BusinessDataYelpLocationsAsync(CancellationToken)**

```csharp
public Task<BusinessDataYelpLocationsResponseInfo> BusinessDataYelpLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataYelpLocationsResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelplocationsresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/locations/?bash'

### **BusinessDataYelpLocationsCountryAsync(String)**

```csharp
public Task<BusinessDataYelpLocationsCountryResponseInfo> BusinessDataYelpLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;BusinessDataYelpLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelplocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/locations/?bash'

### **BusinessDataYelpLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataYelpLocationsCountryResponseInfo> BusinessDataYelpLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;BusinessDataYelpLocationsCountryResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelplocationscountryresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/locations/?bash'

### **BusinessDataYelpLanguagesAsync()**

```csharp
public Task<BusinessDataYelpLanguagesResponseInfo> BusinessDataYelpLanguagesAsync()
```

#### Returns

[Task&lt;BusinessDataYelpLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelplanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/languages/?bash'

### **BusinessDataYelpLanguagesAsync(CancellationToken)**

```csharp
public Task<BusinessDataYelpLanguagesResponseInfo> BusinessDataYelpLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataYelpLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelplanguagesresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/languages/?bash'

### **YelpSearchTaskPostAsync(IEnumerable&lt;BusinessDataYelpSearchTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataYelpSearchTaskPostResponseInfo> YelpSearchTaskPostAsync(IEnumerable<BusinessDataYelpSearchTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataYelpSearchTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatayelpsearchtaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataYelpSearchTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpsearchtaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>By using this endpoint you can request data on businesses listed on the Yelp platform. The results will be specific to the location (see the List of Yelp Locations) and keyword parameters used in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/search/task_post/?bash'

### **YelpSearchTaskPostAsync(IEnumerable&lt;BusinessDataYelpSearchTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataYelpSearchTaskPostResponseInfo> YelpSearchTaskPostAsync(IEnumerable<BusinessDataYelpSearchTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataYelpSearchTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatayelpsearchtaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataYelpSearchTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpsearchtaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>By using this endpoint you can request data on businesses listed on the Yelp platform. The results will be specific to the location (see the List of Yelp Locations) and keyword parameters used in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/search/task_post/?bash'

### **YelpSearchTasksReadyAsync()**

```csharp
public Task<BusinessDataYelpSearchTasksReadyResponseInfo> YelpSearchTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataYelpSearchTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpsearchtasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/search/tasks_ready/?bash'

### **YelpSearchTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataYelpSearchTasksReadyResponseInfo> YelpSearchTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataYelpSearchTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpsearchtasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/search/tasks_ready/?bash'

### **YelpSearchTaskGetAsync(String)**

```csharp
public Task<BusinessDataYelpSearchTaskGetResponseInfo> YelpSearchTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataYelpSearchTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpsearchtaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with data on businesses listed on the Yelp platform. The results obtained through this endpoint are specific to the location (see the List of Yelp Locations) and keyword parameters used in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/search/task_get/?bash'

### **YelpSearchTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataYelpSearchTaskGetResponseInfo> YelpSearchTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataYelpSearchTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpsearchtaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with data on businesses listed on the Yelp platform. The results obtained through this endpoint are specific to the location (see the List of Yelp Locations) and keyword parameters used in the POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/search/task_get/?bash'

### **YelpReviewsTaskPostAsync(IEnumerable&lt;BusinessDataYelpReviewsTaskPostRequestInfo&gt;)**

```csharp
public Task<BusinessDataYelpReviewsTaskPostResponseInfo> YelpReviewsTaskPostAsync(IEnumerable<BusinessDataYelpReviewsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataYelpReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatayelpreviewstaskpostrequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataYelpReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpreviewstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides reviews published on the Yelp platform. The results are specific to the selected alias and language (see the List of Languages) parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/reviews/task_post/?bash'

### **YelpReviewsTaskPostAsync(IEnumerable&lt;BusinessDataYelpReviewsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataYelpReviewsTaskPostResponseInfo> YelpReviewsTaskPostAsync(IEnumerable<BusinessDataYelpReviewsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataYelpReviewsTaskPostRequestInfo&gt;](./dataforseo.client.models.requests.businessdatayelpreviewstaskpostrequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataYelpReviewsTaskPostResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpreviewstaskpostresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint provides reviews published on the Yelp platform. The results are specific to the selected alias and language (see the List of Languages) parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/reviews/task_post/?bash'

### **YelpReviewsTasksReadyAsync()**

```csharp
public Task<BusinessDataYelpReviewsTasksReadyResponseInfo> YelpReviewsTasksReadyAsync()
```

#### Returns

[Task&lt;BusinessDataYelpReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpreviewstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/reviews/tasks_ready/?bash'

### **YelpReviewsTasksReadyAsync(CancellationToken)**

```csharp
public Task<BusinessDataYelpReviewsTasksReadyResponseInfo> YelpReviewsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataYelpReviewsTasksReadyResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpreviewstasksreadyresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you don’t use the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/reviews/tasks_ready/?bash'

### **YelpReviewsTaskGetAsync(String)**

```csharp
public Task<BusinessDataYelpReviewsTaskGetResponseInfo> YelpReviewsTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;BusinessDataYelpReviewsTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpreviewstaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides reviews published on the Yelp platform. The results are specific to the selected alias and language parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/reviews/task_get/?bash'

### **YelpReviewsTaskGetAsync(String, CancellationToken)**

```csharp
public Task<BusinessDataYelpReviewsTaskGetResponseInfo> YelpReviewsTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataYelpReviewsTaskGetResponseInfo&gt;](./dataforseo.client.models.responses.businessdatayelpreviewstaskgetresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

This endpoint provides reviews published on the Yelp platform. The results are specific to the selected alias and language parameters.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/yelp/reviews/task_get/?bash'

### **SocialMediaPinterestLiveAsync(IEnumerable&lt;BusinessDataSocialMediaPinterestLiveRequestInfo&gt;)**

```csharp
public Task<BusinessDataSocialMediaPinterestLiveResponseInfo> SocialMediaPinterestLiveAsync(IEnumerable<BusinessDataSocialMediaPinterestLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataSocialMediaPinterestLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatasocialmediapinterestliverequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataSocialMediaPinterestLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatasocialmediapinterestliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataSocialMediaPinterestLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatasocialmediapinterestliverequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataSocialMediaPinterestLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatasocialmediapinterestliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataSocialMediaFacebookLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatasocialmediafacebookliverequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataSocialMediaFacebookLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatasocialmediafacebookliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataSocialMediaFacebookLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatasocialmediafacebookliverequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataSocialMediaFacebookLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatasocialmediafacebookliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`body` [IEnumerable&lt;BusinessDataSocialMediaRedditLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatasocialmediaredditliverequestinfo.md)<br>

#### Returns

[Task&lt;BusinessDataSocialMediaRedditLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatasocialmediaredditliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
A server side error occurred.

**Remarks:**

Social Media Reddit API provides information for each share of the target webpage on Reddit. For each specified Reddit URL, you will get subreddit and author names, permalink, title, and the number of subreddit members.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/business_data/social_media/reddit/live/?bash'

### **SocialMediaRedditLiveAsync(IEnumerable&lt;BusinessDataSocialMediaRedditLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<BusinessDataSocialMediaRedditLiveResponseInfo> SocialMediaRedditLiveAsync(IEnumerable<BusinessDataSocialMediaRedditLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;BusinessDataSocialMediaRedditLiveRequestInfo&gt;](./dataforseo.client.models.requests.businessdatasocialmediaredditliverequestinfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;BusinessDataSocialMediaRedditLiveResponseInfo&gt;](./dataforseo.client.models.responses.businessdatasocialmediaredditliveresponseinfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception.md)<br>
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

`headers` [IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

Task&lt;ObjectResponseResult&lt;T&gt;&gt;<br>
