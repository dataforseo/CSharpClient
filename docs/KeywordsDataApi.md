# KeywordsDataApi

Namespace: DataForSeo.Client.Api

```csharp
public class KeywordsDataApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/Object) → [KeywordsDataApi](./KeywordsDataApi.md)

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

### **KeywordsDataApi(HttpClient)**

```csharp
public KeywordsDataApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **KeywordsDataClickstreamDataLocationsAndLanguagesAsync()**

```csharp
public Task<KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo> KeywordsDataClickstreamDataLocationsAndLanguagesAsync()
```

#### Returns

[Task&lt;KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo&gt;](./KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Using this endpoint you can get the full list of locations and languages supported in DataForSEO Clickstream Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/locations_and_languages/?bash'

### **KeywordsDataClickstreamDataLocationsAndLanguagesAsync(CancellationToken)**

```csharp
public Task<KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo> KeywordsDataClickstreamDataLocationsAndLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo&gt;](./KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Using this endpoint you can get the full list of locations and languages supported in DataForSEO Clickstream Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/locations_and_languages/?bash'

### **ClickstreamDataDataforseoSearchVolumeLiveAsync(IEnumerable&lt;KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo> ClickstreamDataDataforseoSearchVolumeLiveAsync(IEnumerable<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo&gt;](./KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo&gt;](./KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/dataforseo_search_volume/live/?bash'

### **ClickstreamDataDataforseoSearchVolumeLiveAsync(IEnumerable&lt;KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo> ClickstreamDataDataforseoSearchVolumeLiveAsync(IEnumerable<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo&gt;](./KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo&gt;](./KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/dataforseo_search_volume/live/?bash'

### **ClickstreamDataGlobalSearchVolumeLiveAsync(IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;)**

```csharp
public Task<KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo> ClickstreamDataGlobalSearchVolumeLiveAsync(IEnumerable<KeywordsDataTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;](./KeywordsDataTaskRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo&gt;](./KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌ 
 <br>The Clickstream Global Search Volume endpoint of DataForSEO Keywords Data API is designed to provide clickstream-based search volume data for up to 1000 keywords in a single Live request. What’s more, it offers geographical distribution of clickstream search volume values across all available locations.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/global_search_volume/live/?bash'

### **ClickstreamDataGlobalSearchVolumeLiveAsync(IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo> ClickstreamDataGlobalSearchVolumeLiveAsync(IEnumerable<KeywordsDataTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;](./KeywordsDataTaskRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo&gt;](./KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌ 
 <br>The Clickstream Global Search Volume endpoint of DataForSEO Keywords Data API is designed to provide clickstream-based search volume data for up to 1000 keywords in a single Live request. What’s more, it offers geographical distribution of clickstream search volume values across all available locations.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/global_search_volume/live/?bash'

### **ClickstreamDataBulkSearchVolumeLiveAsync(IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;)**

```csharp
public Task<KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo> ClickstreamDataBulkSearchVolumeLiveAsync(IEnumerable<KeywordsDataTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;](./KeywordsDataTaskRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo&gt;](./KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌ 
 <br>The Bulk Clickstream Search Volume endpoint of DataForSEO Keywords Data API is designed to provide clickstream-based search volume data for up to 1000 keywords in a single Live request. What’s more, it offers historical search volume values for up to 12 months (depending on keywords, location, and language parameters).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/bulk_search_volume/live/?bash'

### **ClickstreamDataBulkSearchVolumeLiveAsync(IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo> ClickstreamDataBulkSearchVolumeLiveAsync(IEnumerable<KeywordsDataTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;](./KeywordsDataTaskRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo&gt;](./KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌ 
 <br>The Bulk Clickstream Search Volume endpoint of DataForSEO Keywords Data API is designed to provide clickstream-based search volume data for up to 1000 keywords in a single Live request. What’s more, it offers historical search volume values for up to 12 months (depending on keywords, location, and language parameters).
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/bulk_search_volume/live/?bash'

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

### **KeywordsDataIdListAsync(IEnumerable&lt;KeywordsDataIdListRequestInfo&gt;)**

```csharp
public Task<KeywordsDataIdListResponseInfo> KeywordsDataIdListAsync(IEnumerable<KeywordsDataIdListRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataIdListRequestInfo&gt;](./KeywordsDataIdListRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataIdListResponseInfo&gt;](./KeywordsDataIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Keywords Data tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/id_list/?bash'

### **KeywordsDataIdListAsync(IEnumerable&lt;KeywordsDataIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataIdListResponseInfo> KeywordsDataIdListAsync(IEnumerable<KeywordsDataIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataIdListRequestInfo&gt;](./KeywordsDataIdListRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataIdListResponseInfo&gt;](./KeywordsDataIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Keywords Data tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/id_list/?bash'

### **KeywordsDataErrorsAsync(IEnumerable&lt;KeywordsDataErrorsRequestInfo&gt;)**

```csharp
public Task<KeywordsDataErrorsResponseInfo> KeywordsDataErrorsAsync(IEnumerable<KeywordsDataErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataErrorsRequestInfo&gt;](./KeywordsDataErrorsRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataErrorsResponseInfo&gt;](./KeywordsDataErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Keywords Data API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/errors/?bash'

### **KeywordsDataErrorsAsync(IEnumerable&lt;KeywordsDataErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataErrorsResponseInfo> KeywordsDataErrorsAsync(IEnumerable<KeywordsDataErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataErrorsRequestInfo&gt;](./KeywordsDataErrorsRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataErrorsResponseInfo&gt;](./KeywordsDataErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the Keywords Data API tasks that returned an error within the past 24 hours.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/errors/?bash'

### **GoogleAdsStatusAsync()**

```csharp
public Task<KeywordsDataGoogleAdsStatusResponseInfo> GoogleAdsStatusAsync()
```

#### Returns

[Task&lt;KeywordsDataGoogleAdsStatusResponseInfo&gt;](./KeywordsDataGoogleAdsStatusResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>By calling this endpoint, you will know if Google updated keyword data for the previous month. Generally, Google updates keyword data in the middle of the month. So, if Google updated its data in October, you would be able to see the actual search volume, cost-per-click, competition, and other metrics for September. If Google didn’t update its data in October, the latest information would be available for August.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/status/?bash'

### **GoogleAdsStatusAsync(CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsStatusResponseInfo> GoogleAdsStatusAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsStatusResponseInfo&gt;](./KeywordsDataGoogleAdsStatusResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>By calling this endpoint, you will know if Google updated keyword data for the previous month. Generally, Google updates keyword data in the middle of the month. So, if Google updated its data in October, you would be able to see the actual search volume, cost-per-click, competition, and other metrics for September. If Google didn’t update its data in October, the latest information would be available for August.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/status/?bash'

### **KeywordsDataGoogleAdsLocationsAsync()**

```csharp
public Task<KeywordsDataGoogleAdsLocationsResponseInfo> KeywordsDataGoogleAdsLocationsAsync()
```

#### Returns

[Task&lt;KeywordsDataGoogleAdsLocationsResponseInfo&gt;](./KeywordsDataGoogleAdsLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>We use Google Geographical Targeting. You can refer to Google Ads Target Types page to review the full list of possible location types. With Keywords Data API, you can select any location type supported by Google, except for “Okrug”.
 <br>Postal Codes can be used to set a task, albeit API response will not return data for such tasks.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/locations/?bash'

### **KeywordsDataGoogleAdsLocationsAsync(CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsLocationsResponseInfo> KeywordsDataGoogleAdsLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsLocationsResponseInfo&gt;](./KeywordsDataGoogleAdsLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>We use Google Geographical Targeting. You can refer to Google Ads Target Types page to review the full list of possible location types. With Keywords Data API, you can select any location type supported by Google, except for “Okrug”.
 <br>Postal Codes can be used to set a task, albeit API response will not return data for such tasks.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/locations/?bash'

### **KeywordsDataGoogleAdsLocationsCountryAsync(String)**

```csharp
public Task<KeywordsDataGoogleAdsLocationsCountryResponseInfo> KeywordsDataGoogleAdsLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;KeywordsDataGoogleAdsLocationsCountryResponseInfo&gt;](./KeywordsDataGoogleAdsLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>We use Google Geographical Targeting. You can refer to Google Ads Target Types page to review the full list of possible location types. With Keywords Data API, you can select any location type supported by Google, except for “Okrug”.
 <br>Postal Codes can be used to set a task, albeit API response will not return data for such tasks.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/locations/?bash'

### **KeywordsDataGoogleAdsLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsLocationsCountryResponseInfo> KeywordsDataGoogleAdsLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;KeywordsDataGoogleAdsLocationsCountryResponseInfo&gt;](./KeywordsDataGoogleAdsLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>We use Google Geographical Targeting. You can refer to Google Ads Target Types page to review the full list of possible location types. With Keywords Data API, you can select any location type supported by Google, except for “Okrug”.
 <br>Postal Codes can be used to set a task, albeit API response will not return data for such tasks.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/locations/?bash'

### **KeywordsDataGoogleAdsLanguagesAsync()**

```csharp
public Task<KeywordsDataGoogleAdsLanguagesResponseInfo> KeywordsDataGoogleAdsLanguagesAsync()
```

#### Returns

[Task&lt;KeywordsDataGoogleAdsLanguagesResponseInfo&gt;](./KeywordsDataGoogleAdsLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of languages supported by Keywords Data API.
 <br>‌
 <br>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available languages.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/languages/?bash'

### **KeywordsDataGoogleAdsLanguagesAsync(CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsLanguagesResponseInfo> KeywordsDataGoogleAdsLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsLanguagesResponseInfo&gt;](./KeywordsDataGoogleAdsLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of languages supported by Keywords Data API.
 <br>‌
 <br>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available languages.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/languages/?bash'

### **GoogleAdsSearchVolumeTaskPostAsync(IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;)**

```csharp
public Task<KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo> GoogleAdsSearchVolumeTaskPostAsync(IEnumerable<KeywordsDataTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;](./KeywordsDataTaskRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo&gt;](./KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/task_post/?bash'

### **GoogleAdsSearchVolumeTaskPostAsync(IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo> GoogleAdsSearchVolumeTaskPostAsync(IEnumerable<KeywordsDataTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;](./KeywordsDataTaskRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo&gt;](./KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/task_post/?bash'

### **GoogleAdsSearchVolumeTasksReadyAsync()**

```csharp
public Task<KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo> GoogleAdsSearchVolumeTasksReadyAsync()
```

#### Returns

[Task&lt;KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo&gt;](./KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/tasks_ready/?bash'

### **GoogleAdsSearchVolumeTasksReadyAsync(CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo> GoogleAdsSearchVolumeTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo&gt;](./KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/tasks_ready/?bash'

### **GoogleAdsSearchVolumeTaskGetAsync(String)**

```csharp
public Task<KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo> GoogleAdsSearchVolumeTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo&gt;](./KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/task_get/?bash'

### **GoogleAdsSearchVolumeTaskGetAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo> GoogleAdsSearchVolumeTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo&gt;](./KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/task_get/?bash'

### **GoogleAdsSearchVolumeLiveAsync(IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;)**

```csharp
public Task<KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo> GoogleAdsSearchVolumeLiveAsync(IEnumerable<KeywordsDataTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;](./KeywordsDataTaskRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo&gt;](./KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/live/?bash'

### **GoogleAdsSearchVolumeLiveAsync(IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo> GoogleAdsSearchVolumeLiveAsync(IEnumerable<KeywordsDataTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;](./KeywordsDataTaskRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo&gt;](./KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/live/?bash'

### **GoogleAdsKeywordsForSiteTaskPostAsync(IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo&gt;)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo> GoogleAdsKeywordsForSiteTaskPostAsync(IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/task_post/?bash'

### **GoogleAdsKeywordsForSiteTaskPostAsync(IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo> GoogleAdsKeywordsForSiteTaskPostAsync(IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/task_post/?bash'

### **GoogleAdsKeywordsForSiteTasksReadyAsync()**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo> GoogleAdsKeywordsForSiteTasksReadyAsync()
```

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/tasks_ready/?bash'

### **GoogleAdsKeywordsForSiteTasksReadyAsync(CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo> GoogleAdsKeywordsForSiteTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/tasks_ready/?bash'

### **GoogleAdsKeywordsForSiteTaskGetAsync(String)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo> GoogleAdsKeywordsForSiteTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>‌‌
 <br>This endpoint will provide you with a list of keywords relevant to the specified domain along with their bids, search volumes for the last month, search volume trends for the last year (for estimating search volume dynamics), and competition levels.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/task_get/?bash'

### **GoogleAdsKeywordsForSiteTaskGetAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo> GoogleAdsKeywordsForSiteTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>‌‌
 <br>This endpoint will provide you with a list of keywords relevant to the specified domain along with their bids, search volumes for the last month, search volume trends for the last year (for estimating search volume dynamics), and competition levels.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/task_get/?bash'

### **GoogleAdsKeywordsForSiteLiveAsync(IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo> GoogleAdsKeywordsForSiteLiveAsync(IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>‌‌
 <br>This endpoint will provide you with a list of keywords relevant to the specified domain along with their bids, search volumes for the last month, search volume trends for the last year (for estimating search volume dynamics), and competition levels.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/live/?bash'

### **GoogleAdsKeywordsForSiteLiveAsync(IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo> GoogleAdsKeywordsForSiteLiveAsync(IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>‌‌
 <br>This endpoint will provide you with a list of keywords relevant to the specified domain along with their bids, search volumes for the last month, search volume trends for the last year (for estimating search volume dynamics), and competition levels.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/live/?bash'

### **GoogleAdsKeywordsForKeywordsTaskPostAsync(IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo&gt;)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo> GoogleAdsKeywordsForKeywordsTaskPostAsync(IEnumerable<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo&gt;](./KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>‌‌
 <br>This endpoint will provide relevant keywords for the specified terms. Set up to 20 keywords in the keywords array and get keyword suggestions from Google Ads.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/task_post/?bash'

### **GoogleAdsKeywordsForKeywordsTaskPostAsync(IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo> GoogleAdsKeywordsForKeywordsTaskPostAsync(IEnumerable<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo&gt;](./KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>‌‌
 <br>This endpoint will provide relevant keywords for the specified terms. Set up to 20 keywords in the keywords array and get keyword suggestions from Google Ads.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/task_post/?bash'

### **GoogleAdsKeywordsForKeywordsTasksReadyAsync()**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo> GoogleAdsKeywordsForKeywordsTasksReadyAsync()
```

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/tasks_ready/?bash'

### **GoogleAdsKeywordsForKeywordsTasksReadyAsync(CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo> GoogleAdsKeywordsForKeywordsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/tasks_ready/?bash'

### **GoogleAdsKeywordsForKeywordsTaskGetAsync(String)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo> GoogleAdsKeywordsForKeywordsTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>‌
 <br>This endpoint will select relevant keywords for the specified terms. Set up to 20 keywords and get the results, which are suggested by Google Ads for your query.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/task_get/?bash'

### **GoogleAdsKeywordsForKeywordsTaskGetAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo> GoogleAdsKeywordsForKeywordsTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>‌
 <br>This endpoint will select relevant keywords for the specified terms. Set up to 20 keywords and get the results, which are suggested by Google Ads for your query.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/task_get/?bash'

### **GoogleAdsKeywordsForKeywordsLiveAsync(IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo> GoogleAdsKeywordsForKeywordsLiveAsync(IEnumerable<KeywordsDataTaskRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;](./KeywordsDataTaskRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>‌‌
 <br>This endpoint will provide relevant keywords for the specified terms. Set up to 20 keywords in the keywords array and get keyword suggestions from Google Ads.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/live/?bash'

### **GoogleAdsKeywordsForKeywordsLiveAsync(IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo> GoogleAdsKeywordsForKeywordsLiveAsync(IEnumerable<KeywordsDataTaskRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataTaskRequestInfo&gt;](./KeywordsDataTaskRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo&gt;](./KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
 <br>‌‌
 <br>This endpoint will provide relevant keywords for the specified terms. Set up to 20 keywords in the keywords array and get keyword suggestions from Google Ads.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/live/?bash'

### **GoogleAdsAdTrafficByKeywordsTaskPostAsync(IEnumerable&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo&gt;)**

```csharp
public Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo> GoogleAdsAdTrafficByKeywordsTaskPostAsync(IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/task_post/?bash'

### **GoogleAdsAdTrafficByKeywordsTaskPostAsync(IEnumerable&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo> GoogleAdsAdTrafficByKeywordsTaskPostAsync(IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/task_post/?bash'

### **GoogleAdsAdTrafficByKeywordsTasksReadyAsync()**

```csharp
public Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo> GoogleAdsAdTrafficByKeywordsTasksReadyAsync()
```

#### Returns

[Task&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/tasks_ready/?bash'

### **GoogleAdsAdTrafficByKeywordsTasksReadyAsync(CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo> GoogleAdsAdTrafficByKeywordsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/tasks_ready/?bash'

### **GoogleAdsAdTrafficByKeywordsTaskGetAsync(String)**

```csharp
public Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo> GoogleAdsAdTrafficByKeywordsTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/task_get/?bash'

### **GoogleAdsAdTrafficByKeywordsTaskGetAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo> GoogleAdsAdTrafficByKeywordsTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/task_get/?bash'

### **GoogleAdsAdTrafficByKeywordsLiveAsync(IEnumerable&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo> GoogleAdsAdTrafficByKeywordsLiveAsync(IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/live/?bash'

### **GoogleAdsAdTrafficByKeywordsLiveAsync(IEnumerable&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo> GoogleAdsAdTrafficByKeywordsLiveAsync(IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo&gt;](./KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/live/?bash'

### **KeywordsDataGoogleTrendsLocationsAsync()**

```csharp
public Task<KeywordsDataGoogleTrendsLocationsResponseInfo> KeywordsDataGoogleTrendsLocationsAsync()
```

#### Returns

[Task&lt;KeywordsDataGoogleTrendsLocationsResponseInfo&gt;](./KeywordsDataGoogleTrendsLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/locations/?bash'

### **KeywordsDataGoogleTrendsLocationsAsync(CancellationToken)**

```csharp
public Task<KeywordsDataGoogleTrendsLocationsResponseInfo> KeywordsDataGoogleTrendsLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleTrendsLocationsResponseInfo&gt;](./KeywordsDataGoogleTrendsLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/locations/?bash'

### **KeywordsDataGoogleTrendsLocationsCountryAsync(String)**

```csharp
public Task<KeywordsDataGoogleTrendsLocationsCountryResponseInfo> KeywordsDataGoogleTrendsLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;KeywordsDataGoogleTrendsLocationsCountryResponseInfo&gt;](./KeywordsDataGoogleTrendsLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/locations/?bash'

### **KeywordsDataGoogleTrendsLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleTrendsLocationsCountryResponseInfo> KeywordsDataGoogleTrendsLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;KeywordsDataGoogleTrendsLocationsCountryResponseInfo&gt;](./KeywordsDataGoogleTrendsLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/locations/?bash'

### **KeywordsDataGoogleTrendsLanguagesAsync()**

```csharp
public Task<KeywordsDataGoogleTrendsLanguagesResponseInfo> KeywordsDataGoogleTrendsLanguagesAsync()
```

#### Returns

[Task&lt;KeywordsDataGoogleTrendsLanguagesResponseInfo&gt;](./KeywordsDataGoogleTrendsLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of languages supported by Google Trends API.
 <br>‌
 <br>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available languages.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/languages/?bash'

### **KeywordsDataGoogleTrendsLanguagesAsync(CancellationToken)**

```csharp
public Task<KeywordsDataGoogleTrendsLanguagesResponseInfo> KeywordsDataGoogleTrendsLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleTrendsLanguagesResponseInfo&gt;](./KeywordsDataGoogleTrendsLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of languages supported by Google Trends API.
 <br>‌
 <br>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available languages.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/languages/?bash'

### **GoogleTrendsCategoriesAsync()**

```csharp
public Task<KeywordsDataGoogleTrendsCategoriesResponseInfo> GoogleTrendsCategoriesAsync()
```

#### Returns

[Task&lt;KeywordsDataGoogleTrendsCategoriesResponseInfo&gt;](./KeywordsDataGoogleTrendsCategoriesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of categories supported by Google Trends API.
 <br>‌
 <br>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available categories.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/categories/?bash'

### **GoogleTrendsCategoriesAsync(CancellationToken)**

```csharp
public Task<KeywordsDataGoogleTrendsCategoriesResponseInfo> GoogleTrendsCategoriesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleTrendsCategoriesResponseInfo&gt;](./KeywordsDataGoogleTrendsCategoriesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of categories supported by Google Trends API.
 <br>‌
 <br>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available categories.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/categories/?bash'

### **GoogleTrendsExploreTaskPostAsync(IEnumerable&lt;KeywordsDataGoogleTrendsExploreTaskPostRequestInfo&gt;)**

```csharp
public Task<KeywordsDataGoogleTrendsExploreTaskPostResponseInfo> GoogleTrendsExploreTaskPostAsync(IEnumerable<KeywordsDataGoogleTrendsExploreTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleTrendsExploreTaskPostRequestInfo&gt;](./KeywordsDataGoogleTrendsExploreTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataGoogleTrendsExploreTaskPostResponseInfo&gt;](./KeywordsDataGoogleTrendsExploreTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the keyword popularity data from the ‘Explore’ feature of Google Trends. You can check keyword trends for Google Search, Google News, Google Images, Google Shopping, and YouTube.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/task_post/?bash'

### **GoogleTrendsExploreTaskPostAsync(IEnumerable&lt;KeywordsDataGoogleTrendsExploreTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleTrendsExploreTaskPostResponseInfo> GoogleTrendsExploreTaskPostAsync(IEnumerable<KeywordsDataGoogleTrendsExploreTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleTrendsExploreTaskPostRequestInfo&gt;](./KeywordsDataGoogleTrendsExploreTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleTrendsExploreTaskPostResponseInfo&gt;](./KeywordsDataGoogleTrendsExploreTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the keyword popularity data from the ‘Explore’ feature of Google Trends. You can check keyword trends for Google Search, Google News, Google Images, Google Shopping, and YouTube.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/task_post/?bash'

### **GoogleTrendsExploreTasksReadyAsync()**

```csharp
public Task<KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo> GoogleTrendsExploreTasksReadyAsync()
```

#### Returns

[Task&lt;KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo&gt;](./KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/tasks_ready/?bash'

### **GoogleTrendsExploreTasksReadyAsync(CancellationToken)**

```csharp
public Task<KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo> GoogleTrendsExploreTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo&gt;](./KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/tasks_ready/?bash'

### **GoogleTrendsExploreTaskGetAsync(String)**

```csharp
public Task<KeywordsDataGoogleTrendsExploreTaskGetResponseInfo> GoogleTrendsExploreTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;KeywordsDataGoogleTrendsExploreTaskGetResponseInfo&gt;](./KeywordsDataGoogleTrendsExploreTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/task_get/?bash'

### **GoogleTrendsExploreTaskGetAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleTrendsExploreTaskGetResponseInfo> GoogleTrendsExploreTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleTrendsExploreTaskGetResponseInfo&gt;](./KeywordsDataGoogleTrendsExploreTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/task_get/?bash'

### **GoogleTrendsExploreLiveAsync(IEnumerable&lt;KeywordsDataGoogleTrendsExploreLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataGoogleTrendsExploreLiveResponseInfo> GoogleTrendsExploreLiveAsync(IEnumerable<KeywordsDataGoogleTrendsExploreLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleTrendsExploreLiveRequestInfo&gt;](./KeywordsDataGoogleTrendsExploreLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataGoogleTrendsExploreLiveResponseInfo&gt;](./KeywordsDataGoogleTrendsExploreLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the keyword popularity data from the ‘Explore’ feature of Google Trends. You can check keyword trends for Google Search, Google News, Google Images, Google Shopping, and YouTube.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/live/?bash'

### **GoogleTrendsExploreLiveAsync(IEnumerable&lt;KeywordsDataGoogleTrendsExploreLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataGoogleTrendsExploreLiveResponseInfo> GoogleTrendsExploreLiveAsync(IEnumerable<KeywordsDataGoogleTrendsExploreLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataGoogleTrendsExploreLiveRequestInfo&gt;](./KeywordsDataGoogleTrendsExploreLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataGoogleTrendsExploreLiveResponseInfo&gt;](./KeywordsDataGoogleTrendsExploreLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the keyword popularity data from the ‘Explore’ feature of Google Trends. You can check keyword trends for Google Search, Google News, Google Images, Google Shopping, and YouTube.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/live/?bash'

### **KeywordsDataDataforseoTrendsLocationsAsync()**

```csharp
public Task<KeywordsDataDataforseoTrendsLocationsResponseInfo> KeywordsDataDataforseoTrendsLocationsAsync()
```

#### Returns

[Task&lt;KeywordsDataDataforseoTrendsLocationsResponseInfo&gt;](./KeywordsDataDataforseoTrendsLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of DataForSEO Trends locations by calling this API. You can filter the list of locations by country when setting a task. Please note that the minimum geographic scope supported for the DataForSEO Trends API is country level.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/locations/?bash'

### **KeywordsDataDataforseoTrendsLocationsAsync(CancellationToken)**

```csharp
public Task<KeywordsDataDataforseoTrendsLocationsResponseInfo> KeywordsDataDataforseoTrendsLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataDataforseoTrendsLocationsResponseInfo&gt;](./KeywordsDataDataforseoTrendsLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of DataForSEO Trends locations by calling this API. You can filter the list of locations by country when setting a task. Please note that the minimum geographic scope supported for the DataForSEO Trends API is country level.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/locations/?bash'

### **KeywordsDataDataforseoTrendsLocationsCountryAsync(String)**

```csharp
public Task<KeywordsDataDataforseoTrendsLocationsCountryResponseInfo> KeywordsDataDataforseoTrendsLocationsCountryAsync(string country)
```

#### Parameters

`country` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
country ISO code
 <br>optional field
 <br>specify the ISO code if you want to filter the list of locations by country
 <br>example:
 <br>us

#### Returns

[Task&lt;KeywordsDataDataforseoTrendsLocationsCountryResponseInfo&gt;](./KeywordsDataDataforseoTrendsLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of DataForSEO Trends locations by calling this API. You can filter the list of locations by country when setting a task. Please note that the minimum geographic scope supported for the DataForSEO Trends API is country level.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/locations/?bash'

### **KeywordsDataDataforseoTrendsLocationsCountryAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataDataforseoTrendsLocationsCountryResponseInfo> KeywordsDataDataforseoTrendsLocationsCountryAsync(string country, CancellationToken cancellationToken)
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

[Task&lt;KeywordsDataDataforseoTrendsLocationsCountryResponseInfo&gt;](./KeywordsDataDataforseoTrendsLocationsCountryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of DataForSEO Trends locations by calling this API. You can filter the list of locations by country when setting a task. Please note that the minimum geographic scope supported for the DataForSEO Trends API is country level.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/locations/?bash'

### **DataforseoTrendsExploreLiveAsync(IEnumerable&lt;KeywordsDataDataforseoTrendsExploreLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataDataforseoTrendsExploreLiveResponseInfo> DataforseoTrendsExploreLiveAsync(IEnumerable<KeywordsDataDataforseoTrendsExploreLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataDataforseoTrendsExploreLiveRequestInfo&gt;](./KeywordsDataDataforseoTrendsExploreLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataDataforseoTrendsExploreLiveResponseInfo&gt;](./KeywordsDataDataforseoTrendsExploreLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the keyword popularity data from DataForSEO Trends. You can check keyword trends for Google Search, Google News, and Google Shopping.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/explore/live/?bash'

### **DataforseoTrendsExploreLiveAsync(IEnumerable&lt;KeywordsDataDataforseoTrendsExploreLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataDataforseoTrendsExploreLiveResponseInfo> DataforseoTrendsExploreLiveAsync(IEnumerable<KeywordsDataDataforseoTrendsExploreLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataDataforseoTrendsExploreLiveRequestInfo&gt;](./KeywordsDataDataforseoTrendsExploreLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataDataforseoTrendsExploreLiveResponseInfo&gt;](./KeywordsDataDataforseoTrendsExploreLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the keyword popularity data from DataForSEO Trends. You can check keyword trends for Google Search, Google News, and Google Shopping.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/explore/live/?bash'

### **DataforseoTrendsSubregionInterestsLiveAsync(IEnumerable&lt;KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo> DataforseoTrendsSubregionInterestsLiveAsync(IEnumerable<KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo&gt;](./KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo&gt;](./KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with location-specific keyword popularity data from DataForSEO Trends. You can check keyword trends for Google Search, Google News, and Google Shopping.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/subregion_interests/live/?bash'

### **DataforseoTrendsSubregionInterestsLiveAsync(IEnumerable&lt;KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo> DataforseoTrendsSubregionInterestsLiveAsync(IEnumerable<KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo&gt;](./KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo&gt;](./KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with location-specific keyword popularity data from DataForSEO Trends. You can check keyword trends for Google Search, Google News, and Google Shopping.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/subregion_interests/live/?bash'

### **DataforseoTrendsDemographyLiveAsync(IEnumerable&lt;KeywordsDataDataforseoTrendsDemographyLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataDataforseoTrendsDemographyLiveResponseInfo> DataforseoTrendsDemographyLiveAsync(IEnumerable<KeywordsDataDataforseoTrendsDemographyLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataDataforseoTrendsDemographyLiveRequestInfo&gt;](./KeywordsDataDataforseoTrendsDemographyLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataDataforseoTrendsDemographyLiveResponseInfo&gt;](./KeywordsDataDataforseoTrendsDemographyLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the demographic breakdown (by age and gender) of keyword popularity per each specified term based on DataForSEO Trends data. You can check keyword trends for Google Search, Google News, and Google Shopping.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/demography/live/?bash'

### **DataforseoTrendsDemographyLiveAsync(IEnumerable&lt;KeywordsDataDataforseoTrendsDemographyLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataDataforseoTrendsDemographyLiveResponseInfo> DataforseoTrendsDemographyLiveAsync(IEnumerable<KeywordsDataDataforseoTrendsDemographyLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataDataforseoTrendsDemographyLiveRequestInfo&gt;](./KeywordsDataDataforseoTrendsDemographyLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataDataforseoTrendsDemographyLiveResponseInfo&gt;](./KeywordsDataDataforseoTrendsDemographyLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the demographic breakdown (by age and gender) of keyword popularity per each specified term based on DataForSEO Trends data. You can check keyword trends for Google Search, Google News, and Google Shopping.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/demography/live/?bash'

### **DataforseoTrendsMergedDataLiveAsync(IEnumerable&lt;KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo> DataforseoTrendsMergedDataLiveAsync(IEnumerable<KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo&gt;](./KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo&gt;](./KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the keyword popularity data from DataForSEO Trends. In addition to keyword popularity rate over the given time range, you will get location-specific keyword popularity data, and a demographic breakdown of keyword popularity per each specified term along with comparative values.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/merged_data/live/?bash'

### **DataforseoTrendsMergedDataLiveAsync(IEnumerable&lt;KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo> DataforseoTrendsMergedDataLiveAsync(IEnumerable<KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo&gt;](./KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo&gt;](./KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the keyword popularity data from DataForSEO Trends. In addition to keyword popularity rate over the given time range, you will get location-specific keyword popularity data, and a demographic breakdown of keyword popularity per each specified term along with comparative values.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/merged_data/live/?bash'

### **KeywordsDataBingLocationsAsync()**

```csharp
public Task<KeywordsDataBingLocationsResponseInfo> KeywordsDataBingLocationsAsync()
```

#### Returns

[Task&lt;KeywordsDataBingLocationsResponseInfo&gt;](./KeywordsDataBingLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of locations supported in Bing Ads API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/locations/?bash'

### **KeywordsDataBingLocationsAsync(CancellationToken)**

```csharp
public Task<KeywordsDataBingLocationsResponseInfo> KeywordsDataBingLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingLocationsResponseInfo&gt;](./KeywordsDataBingLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of locations supported in Bing Ads API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/locations/?bash'

### **KeywordsDataBingLanguagesAsync()**

```csharp
public Task<KeywordsDataBingLanguagesResponseInfo> KeywordsDataBingLanguagesAsync()
```

#### Returns

[Task&lt;KeywordsDataBingLanguagesResponseInfo&gt;](./KeywordsDataBingLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of languages supported by Bing Ads API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/languages/?bash'

### **KeywordsDataBingLanguagesAsync(CancellationToken)**

```csharp
public Task<KeywordsDataBingLanguagesResponseInfo> KeywordsDataBingLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingLanguagesResponseInfo&gt;](./KeywordsDataBingLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of languages supported by Bing Ads API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/languages/?bash'

### **BingSearchVolumeTaskPostAsync(IEnumerable&lt;KeywordsDataBingSearchVolumeTaskPostRequestInfo&gt;)**

```csharp
public Task<KeywordsDataBingSearchVolumeTaskPostResponseInfo> BingSearchVolumeTaskPostAsync(IEnumerable<KeywordsDataBingSearchVolumeTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingSearchVolumeTaskPostRequestInfo&gt;](./KeywordsDataBingSearchVolumeTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeTaskPostResponseInfo&gt;](./KeywordsDataBingSearchVolumeTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with search volume data for the last month, search volume trend for up to 24 past months (that will let you estimate search volume dynamics), current cost-per-click and competition values for paid search.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/task_post/?bash'

### **BingSearchVolumeTaskPostAsync(IEnumerable&lt;KeywordsDataBingSearchVolumeTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataBingSearchVolumeTaskPostResponseInfo> BingSearchVolumeTaskPostAsync(IEnumerable<KeywordsDataBingSearchVolumeTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingSearchVolumeTaskPostRequestInfo&gt;](./KeywordsDataBingSearchVolumeTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeTaskPostResponseInfo&gt;](./KeywordsDataBingSearchVolumeTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with search volume data for the last month, search volume trend for up to 24 past months (that will let you estimate search volume dynamics), current cost-per-click and competition values for paid search.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/task_post/?bash'

### **BingSearchVolumeTasksReadyAsync()**

```csharp
public Task<KeywordsDataBingSearchVolumeTasksReadyResponseInfo> BingSearchVolumeTasksReadyAsync()
```

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeTasksReadyResponseInfo&gt;](./KeywordsDataBingSearchVolumeTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/tasks_ready/?bash'

### **BingSearchVolumeTasksReadyAsync(CancellationToken)**

```csharp
public Task<KeywordsDataBingSearchVolumeTasksReadyResponseInfo> BingSearchVolumeTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeTasksReadyResponseInfo&gt;](./KeywordsDataBingSearchVolumeTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/tasks_ready/?bash'

### **BingSearchVolumeTaskGetAsync(String)**

```csharp
public Task<KeywordsDataBingSearchVolumeTaskGetResponseInfo> BingSearchVolumeTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeTaskGetResponseInfo&gt;](./KeywordsDataBingSearchVolumeTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/task_get/?bash'

### **BingSearchVolumeTaskGetAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataBingSearchVolumeTaskGetResponseInfo> BingSearchVolumeTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeTaskGetResponseInfo&gt;](./KeywordsDataBingSearchVolumeTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/task_get/?bash'

### **BingSearchVolumeLiveAsync(IEnumerable&lt;KeywordsDataBingSearchVolumeLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataBingSearchVolumeLiveResponseInfo> BingSearchVolumeLiveAsync(IEnumerable<KeywordsDataBingSearchVolumeLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingSearchVolumeLiveRequestInfo&gt;](./KeywordsDataBingSearchVolumeLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeLiveResponseInfo&gt;](./KeywordsDataBingSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌This endpoint will provide you with search volume data for the last month, search volume trend for up to 24 past months (that will let you estimate search volume dynamics), current cost-per-click and competition values for paid search.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/live/?bash'

### **BingSearchVolumeLiveAsync(IEnumerable&lt;KeywordsDataBingSearchVolumeLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataBingSearchVolumeLiveResponseInfo> BingSearchVolumeLiveAsync(IEnumerable<KeywordsDataBingSearchVolumeLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingSearchVolumeLiveRequestInfo&gt;](./KeywordsDataBingSearchVolumeLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeLiveResponseInfo&gt;](./KeywordsDataBingSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌This endpoint will provide you with search volume data for the last month, search volume trend for up to 24 past months (that will let you estimate search volume dynamics), current cost-per-click and competition values for paid search.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/live/?bash'

### **BingKeywordsForSiteTaskPostAsync(IEnumerable&lt;KeywordsDataBingKeywordsForSiteTaskPostRequestInfo&gt;)**

```csharp
public Task<KeywordsDataBingKeywordsForSiteTaskPostResponseInfo> BingKeywordsForSiteTaskPostAsync(IEnumerable<KeywordsDataBingKeywordsForSiteTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordsForSiteTaskPostRequestInfo&gt;](./KeywordsDataBingKeywordsForSiteTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataBingKeywordsForSiteTaskPostResponseInfo&gt;](./KeywordsDataBingKeywordsForSiteTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌This endpoint will provide you with a list of keywords relevant to the specified website along with their search volume for the last month, search volume trend for up to 24 past months (for estimating search volume dynamics), current cost-per-click and competition level for paid search. The maximum number of returned keywords is 3000.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/task_post/?bash'

### **BingKeywordsForSiteTaskPostAsync(IEnumerable&lt;KeywordsDataBingKeywordsForSiteTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordsForSiteTaskPostResponseInfo> BingKeywordsForSiteTaskPostAsync(IEnumerable<KeywordsDataBingKeywordsForSiteTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordsForSiteTaskPostRequestInfo&gt;](./KeywordsDataBingKeywordsForSiteTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordsForSiteTaskPostResponseInfo&gt;](./KeywordsDataBingKeywordsForSiteTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌This endpoint will provide you with a list of keywords relevant to the specified website along with their search volume for the last month, search volume trend for up to 24 past months (for estimating search volume dynamics), current cost-per-click and competition level for paid search. The maximum number of returned keywords is 3000.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/task_post/?bash'

### **BingKeywordsForSiteTasksReadyAsync()**

```csharp
public Task<KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo> BingKeywordsForSiteTasksReadyAsync()
```

#### Returns

[Task&lt;KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo&gt;](./KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/tasks_ready/?bash'

### **BingKeywordsForSiteTasksReadyAsync(CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo> BingKeywordsForSiteTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo&gt;](./KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/tasks_ready/?bash'

### **BingKeywordsForSiteTaskGetAsync(String)**

```csharp
public Task<KeywordsDataBingKeywordsForSiteTaskGetResponseInfo> BingKeywordsForSiteTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;KeywordsDataBingKeywordsForSiteTaskGetResponseInfo&gt;](./KeywordsDataBingKeywordsForSiteTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords relevant to the specified website along with their search volume for the last month, search volume trend for the last year (for estimating search volume dynamics), current cost-per-click and competition level for paid search. The maximum number of returned keywords is 3000.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/task_get/?bash'

### **BingKeywordsForSiteTaskGetAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordsForSiteTaskGetResponseInfo> BingKeywordsForSiteTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordsForSiteTaskGetResponseInfo&gt;](./KeywordsDataBingKeywordsForSiteTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords relevant to the specified website along with their search volume for the last month, search volume trend for the last year (for estimating search volume dynamics), current cost-per-click and competition level for paid search. The maximum number of returned keywords is 3000.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/task_get/?bash'

### **BingKeywordsForSiteLiveAsync(IEnumerable&lt;KeywordsDataBingKeywordsForSiteLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataBingKeywordsForSiteLiveResponseInfo> BingKeywordsForSiteLiveAsync(IEnumerable<KeywordsDataBingKeywordsForSiteLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordsForSiteLiveRequestInfo&gt;](./KeywordsDataBingKeywordsForSiteLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataBingKeywordsForSiteLiveResponseInfo&gt;](./KeywordsDataBingKeywordsForSiteLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌This endpoint will provide you with a list of keywords relevant to the specified URL along with their search volume for the last month, search volume trend for up to 24 past months (for estimating search volume dynamics), current cost-per-click and competition values for paid search. The maximum number of returned keywords is 3000.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/live/?bash'

### **BingKeywordsForSiteLiveAsync(IEnumerable&lt;KeywordsDataBingKeywordsForSiteLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordsForSiteLiveResponseInfo> BingKeywordsForSiteLiveAsync(IEnumerable<KeywordsDataBingKeywordsForSiteLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordsForSiteLiveRequestInfo&gt;](./KeywordsDataBingKeywordsForSiteLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordsForSiteLiveResponseInfo&gt;](./KeywordsDataBingKeywordsForSiteLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌This endpoint will provide you with a list of keywords relevant to the specified URL along with their search volume for the last month, search volume trend for up to 24 past months (for estimating search volume dynamics), current cost-per-click and competition values for paid search. The maximum number of returned keywords is 3000.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/live/?bash'

### **BingKeywordsForKeywordsTaskPostAsync(IEnumerable&lt;KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo&gt;)**

```csharp
public Task<KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo> BingKeywordsForKeywordsTaskPostAsync(IEnumerable<KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo&gt;](./KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo&gt;](./KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will select relevant keywords for the specified terms. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/task_post/?bash'

### **BingKeywordsForKeywordsTaskPostAsync(IEnumerable&lt;KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo> BingKeywordsForKeywordsTaskPostAsync(IEnumerable<KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo&gt;](./KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo&gt;](./KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will select relevant keywords for the specified terms. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/task_post/?bash'

### **BingKeywordsForKeywordsTasksReadyAsync()**

```csharp
public Task<KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo> BingKeywordsForKeywordsTasksReadyAsync()
```

#### Returns

[Task&lt;KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo&gt;](./KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/tasks_ready/?bash'

### **BingKeywordsForKeywordsTasksReadyAsync(CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo> BingKeywordsForKeywordsTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo&gt;](./KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/tasks_ready/?bash'

### **BingKeywordsForKeywordsTaskGetAsync(String)**

```csharp
public Task<KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo> BingKeywordsForKeywordsTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo&gt;](./KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will select relevant keywords for the specified terms. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/task_get/?bash'

### **BingKeywordsForKeywordsTaskGetAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo> BingKeywordsForKeywordsTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo&gt;](./KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will select relevant keywords for the specified terms. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/task_get/?bash'

### **BingKeywordsForKeywordsLiveAsync(IEnumerable&lt;KeywordsDataBingKeywordsForKeywordsLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataBingKeywordsForKeywordsLiveResponseInfo> BingKeywordsForKeywordsLiveAsync(IEnumerable<KeywordsDataBingKeywordsForKeywordsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordsForKeywordsLiveRequestInfo&gt;](./KeywordsDataBingKeywordsForKeywordsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataBingKeywordsForKeywordsLiveResponseInfo&gt;](./KeywordsDataBingKeywordsForKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will select the relevant keywords for the specified ones. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/live/?bash'

### **BingKeywordsForKeywordsLiveAsync(IEnumerable&lt;KeywordsDataBingKeywordsForKeywordsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordsForKeywordsLiveResponseInfo> BingKeywordsForKeywordsLiveAsync(IEnumerable<KeywordsDataBingKeywordsForKeywordsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordsForKeywordsLiveRequestInfo&gt;](./KeywordsDataBingKeywordsForKeywordsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordsForKeywordsLiveResponseInfo&gt;](./KeywordsDataBingKeywordsForKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will select the relevant keywords for the specified ones. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/live/?bash'

### **KeywordsDataBingKeywordPerformanceLocationsAndLanguagesAsync()**

```csharp
public Task<KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo> KeywordsDataBingKeywordPerformanceLocationsAndLanguagesAsync()
```

#### Returns

[Task&lt;KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo&gt;](./KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Using this endpoint you can get the full list of locations and languages supported in Keyword Performance endpoints of Bing Keywords Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages/?bash'

### **KeywordsDataBingKeywordPerformanceLocationsAndLanguagesAsync(CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo> KeywordsDataBingKeywordPerformanceLocationsAndLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo&gt;](./KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Using this endpoint you can get the full list of locations and languages supported in Keyword Performance endpoints of Bing Keywords Data API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages/?bash'

### **BingKeywordPerformanceTaskPostAsync(IEnumerable&lt;KeywordsDataBingKeywordPerformanceTaskPostRequestInfo&gt;)**

```csharp
public Task<KeywordsDataBingKeywordPerformanceTaskPostResponseInfo> BingKeywordPerformanceTaskPostAsync(IEnumerable<KeywordsDataBingKeywordPerformanceTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordPerformanceTaskPostRequestInfo&gt;](./KeywordsDataBingKeywordPerformanceTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataBingKeywordPerformanceTaskPostResponseInfo&gt;](./KeywordsDataBingKeywordPerformanceTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/task_post/?bash'

### **BingKeywordPerformanceTaskPostAsync(IEnumerable&lt;KeywordsDataBingKeywordPerformanceTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordPerformanceTaskPostResponseInfo> BingKeywordPerformanceTaskPostAsync(IEnumerable<KeywordsDataBingKeywordPerformanceTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordPerformanceTaskPostRequestInfo&gt;](./KeywordsDataBingKeywordPerformanceTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordPerformanceTaskPostResponseInfo&gt;](./KeywordsDataBingKeywordPerformanceTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/task_post/?bash'

### **BingKeywordPerformanceTasksReadyAsync()**

```csharp
public Task<KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo> BingKeywordPerformanceTasksReadyAsync()
```

#### Returns

[Task&lt;KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo&gt;](./KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/tasks_ready/?bash'

### **BingKeywordPerformanceTasksReadyAsync(CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo> BingKeywordPerformanceTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo&gt;](./KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/tasks_ready/?bash'

### **BingKeywordPerformanceTaskGetAsync(String)**

```csharp
public Task<KeywordsDataBingKeywordPerformanceTaskGetResponseInfo> BingKeywordPerformanceTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;KeywordsDataBingKeywordPerformanceTaskGetResponseInfo&gt;](./KeywordsDataBingKeywordPerformanceTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/task_get/?bash'

### **BingKeywordPerformanceTaskGetAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordPerformanceTaskGetResponseInfo> BingKeywordPerformanceTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordPerformanceTaskGetResponseInfo&gt;](./KeywordsDataBingKeywordPerformanceTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/task_get/?bash'

### **BingKeywordPerformanceLiveAsync(IEnumerable&lt;KeywordsDataBingKeywordPerformanceLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataBingKeywordPerformanceLiveResponseInfo> BingKeywordPerformanceLiveAsync(IEnumerable<KeywordsDataBingKeywordPerformanceLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordPerformanceLiveRequestInfo&gt;](./KeywordsDataBingKeywordPerformanceLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataBingKeywordPerformanceLiveResponseInfo&gt;](./KeywordsDataBingKeywordPerformanceLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/live/?bash'

### **BingKeywordPerformanceLiveAsync(IEnumerable&lt;KeywordsDataBingKeywordPerformanceLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataBingKeywordPerformanceLiveResponseInfo> BingKeywordPerformanceLiveAsync(IEnumerable<KeywordsDataBingKeywordPerformanceLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingKeywordPerformanceLiveRequestInfo&gt;](./KeywordsDataBingKeywordPerformanceLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingKeywordPerformanceLiveResponseInfo&gt;](./KeywordsDataBingKeywordPerformanceLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/live/?bash'

### **KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesAsync()**

```csharp
public Task<KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo> KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesAsync()
```

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo&gt;](./KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of locations and languages supported by Bing ‘Search Volume History’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/locations_and_languages/?bash'

### **KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesAsync(CancellationToken)**

```csharp
public Task<KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo> KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo&gt;](./KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive the list of locations and languages supported by Bing ‘Search Volume History’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/locations_and_languages/?bash'

### **BingSearchVolumeHistoryTaskPostAsync(IEnumerable&lt;KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo&gt;)**

```csharp
public Task<KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo> BingSearchVolumeHistoryTaskPostAsync(IEnumerable<KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo&gt;](./KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo&gt;](./KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with historical search volume data for up to 1000 keywords in one request. You can get search volume for keywords in monthly, weekly, or daily format and specify the device type.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/task_post/?bash'

### **BingSearchVolumeHistoryTaskPostAsync(IEnumerable&lt;KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo> BingSearchVolumeHistoryTaskPostAsync(IEnumerable<KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo&gt;](./KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo&gt;](./KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with historical search volume data for up to 1000 keywords in one request. You can get search volume for keywords in monthly, weekly, or daily format and specify the device type.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/task_post/?bash'

### **BingSearchVolumeHistoryTasksReadyAsync()**

```csharp
public Task<KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo> BingSearchVolumeHistoryTasksReadyAsync()
```

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo&gt;](./KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/tasks_ready/?bash'

### **BingSearchVolumeHistoryTasksReadyAsync(CancellationToken)**

```csharp
public Task<KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo> BingSearchVolumeHistoryTasksReadyAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo&gt;](./KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/tasks_ready/?bash'

### **BingSearchVolumeHistoryTaskGetAsync(String)**

```csharp
public Task<KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo> BingSearchVolumeHistoryTaskGetAsync(string id)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo&gt;](./KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/task_get/?bash'

### **BingSearchVolumeHistoryTaskGetAsync(String, CancellationToken)**

```csharp
public Task<KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo> BingSearchVolumeHistoryTaskGetAsync(string id, CancellationToken cancellationToken)
```

#### Parameters

`id` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>
task identifier
 <br>unique task identifier in our system in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo&gt;](./KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/task_get/?bash'

### **BingSearchVolumeHistoryLiveAsync(IEnumerable&lt;KeywordsDataBingSearchVolumeHistoryLiveRequestInfo&gt;)**

```csharp
public Task<KeywordsDataBingSearchVolumeHistoryLiveResponseInfo> BingSearchVolumeHistoryLiveAsync(IEnumerable<KeywordsDataBingSearchVolumeHistoryLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingSearchVolumeHistoryLiveRequestInfo&gt;](./KeywordsDataBingSearchVolumeHistoryLiveRequestInfo.md)<br>

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeHistoryLiveResponseInfo&gt;](./KeywordsDataBingSearchVolumeHistoryLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌This endpoint will provide you with historical search volume data for up to 1000 keywords in one request. You can get search volume for keywords in monthly, weekly, or daily format and specify the device type.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/live/?bash'

### **BingSearchVolumeHistoryLiveAsync(IEnumerable&lt;KeywordsDataBingSearchVolumeHistoryLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<KeywordsDataBingSearchVolumeHistoryLiveResponseInfo> BingSearchVolumeHistoryLiveAsync(IEnumerable<KeywordsDataBingSearchVolumeHistoryLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;KeywordsDataBingSearchVolumeHistoryLiveRequestInfo&gt;](./KeywordsDataBingSearchVolumeHistoryLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;KeywordsDataBingSearchVolumeHistoryLiveResponseInfo&gt;](./KeywordsDataBingSearchVolumeHistoryLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌This endpoint will provide you with historical search volume data for up to 1000 keywords in one request. You can get search volume for keywords in monthly, weekly, or daily format and specify the device type.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/live/?bash'
