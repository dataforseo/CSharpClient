# DataforseoLabsApi

Namespace: DataForSeo.Client.Api

```csharp
public class DataforseoLabsApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/Object) → [DataforseoLabsApi](./DataforseoLabsApi.md)

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

### **DataforseoLabsApi(HttpClient)**

```csharp
public DataforseoLabsApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

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

### **DataforseoLabsIdListAsync(IEnumerable&lt;DataforseoLabsIdListRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsIdListResponseInfo> DataforseoLabsIdListAsync(IEnumerable<DataforseoLabsIdListRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsIdListRequestInfo&gt;](./DataforseoLabsIdListRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsIdListResponseInfo&gt;](./DataforseoLabsIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed DataForSEO Labs tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/id_list/?bash'

### **DataforseoLabsIdListAsync(IEnumerable&lt;DataforseoLabsIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsIdListResponseInfo> DataforseoLabsIdListAsync(IEnumerable<DataforseoLabsIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsIdListRequestInfo&gt;](./DataforseoLabsIdListRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsIdListResponseInfo&gt;](./DataforseoLabsIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed DataForSEO Labs tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/id_list/?bash'

### **DataforseoLabsStatusAsync()**

```csharp
public Task<DataforseoLabsStatusResponseInfo> DataforseoLabsStatusAsync()
```

#### Returns

[Task&lt;DataforseoLabsStatusResponseInfo&gt;](./DataforseoLabsStatusResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>By calling this endpoint, you will find out when the DataForSEO Labs data was last updated. The API response will provide separate update dates for the Google, Bing, and Amazon endpoints of DataForSEO Labs API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/status/?bash'

### **DataforseoLabsStatusAsync(CancellationToken)**

```csharp
public Task<DataforseoLabsStatusResponseInfo> DataforseoLabsStatusAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsStatusResponseInfo&gt;](./DataforseoLabsStatusResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>By calling this endpoint, you will find out when the DataForSEO Labs data was last updated. The API response will provide separate update dates for the Google, Bing, and Amazon endpoints of DataForSEO Labs API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/status/?bash'

### **DataforseoLabsErrorsAsync(IEnumerable&lt;DataforseoLabsErrorsRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsErrorsResponseInfo> DataforseoLabsErrorsAsync(IEnumerable<DataforseoLabsErrorsRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsErrorsRequestInfo&gt;](./DataforseoLabsErrorsRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsErrorsResponseInfo&gt;](./DataforseoLabsErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the DataForSEO Labs API tasks that returned an error within the past 7 days.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/errors/?bash'

### **DataforseoLabsErrorsAsync(IEnumerable&lt;DataforseoLabsErrorsRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsErrorsResponseInfo> DataforseoLabsErrorsAsync(IEnumerable<DataforseoLabsErrorsRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsErrorsRequestInfo&gt;](./DataforseoLabsErrorsRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsErrorsResponseInfo&gt;](./DataforseoLabsErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this endpoint you will receive information about the DataForSEO Labs API tasks that returned an error within the past 7 days.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/errors/?bash'

### **AvailableFiltersAsync()**

```csharp
public Task<DataforseoLabsAvailableFiltersResponseInfo> AvailableFiltersAsync()
```

#### Returns

[Task&lt;DataforseoLabsAvailableFiltersResponseInfo&gt;](./DataforseoLabsAvailableFiltersResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Here you will find all the necessary information about filters that can be used with DataForSEO Labs API endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/filters/?bash'

### **AvailableFiltersAsync(CancellationToken)**

```csharp
public Task<DataforseoLabsAvailableFiltersResponseInfo> AvailableFiltersAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsAvailableFiltersResponseInfo&gt;](./DataforseoLabsAvailableFiltersResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Here you will find all the necessary information about filters that can be used with DataForSEO Labs API endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/filters/?bash'

### **DataforseoLabsLocationsAndLanguagesAsync()**

```csharp
public Task<DataforseoLabsLocationsAndLanguagesResponseInfo> DataforseoLabsLocationsAndLanguagesAsync()
```

#### Returns

[Task&lt;DataforseoLabsLocationsAndLanguagesResponseInfo&gt;](./DataforseoLabsLocationsAndLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Using this endpoint you can get the full list of locations and languages supported in DataForSEO Labs API. Available sources currently include Google, Bing, and Amazon search engines. However, you should note that Amazon and Bing locations and languages are currently limited to the US/English.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/locations_and_languages/?bash'

### **DataforseoLabsLocationsAndLanguagesAsync(CancellationToken)**

```csharp
public Task<DataforseoLabsLocationsAndLanguagesResponseInfo> DataforseoLabsLocationsAndLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsLocationsAndLanguagesResponseInfo&gt;](./DataforseoLabsLocationsAndLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Using this endpoint you can get the full list of locations and languages supported in DataForSEO Labs API. Available sources currently include Google, Bing, and Amazon search engines. However, you should note that Amazon and Bing locations and languages are currently limited to the US/English.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/locations_and_languages/?bash'

### **CategoriesAsync()**

```csharp
public Task<DataforseoLabsCategoriesResponseInfo> CategoriesAsync()
```

#### Returns

[Task&lt;DataforseoLabsCategoriesResponseInfo&gt;](./DataforseoLabsCategoriesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

We use Google product and service categories. This endpoint will provide you with the full list of available categories.
 <br>You can also download the CSV file by this link.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/categories_list/?bash'

### **CategoriesAsync(CancellationToken)**

```csharp
public Task<DataforseoLabsCategoriesResponseInfo> CategoriesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsCategoriesResponseInfo&gt;](./DataforseoLabsCategoriesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

We use Google product and service categories. This endpoint will provide you with the full list of available categories.
 <br>You can also download the CSV file by this link.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/categories_list/?bash'

### **GoogleAvailableHistoryAsync()**

```csharp
public Task<DataforseoLabsGoogleAvailableHistoryResponseInfo> GoogleAvailableHistoryAsync()
```

#### Returns

[Task&lt;DataforseoLabsGoogleAvailableHistoryResponseInfo&gt;](./DataforseoLabsGoogleAvailableHistoryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>By calling this endpoint, you will find obtain a list of dates available for setting in the first_date and second_date fields of the Domain Metrics by Categories endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/available_history/live/?bash'

### **GoogleAvailableHistoryAsync(CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleAvailableHistoryResponseInfo> GoogleAvailableHistoryAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleAvailableHistoryResponseInfo&gt;](./DataforseoLabsGoogleAvailableHistoryResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>By calling this endpoint, you will find obtain a list of dates available for setting in the first_date and second_date fields of the Domain Metrics by Categories endpoint.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/available_history/live/?bash'

### **GoogleKeywordsForSiteLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo> GoogleKeywordsForSiteLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The Keywords For Site endpoint will provide you with a list of keywords relevant to the target domain. Each keyword is supplied with relevant categories, search volume data for the last month, cost-per-click, competition, and search volume trend values for the past 12 months.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_site/live/?bash'

### **GoogleKeywordsForSiteLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo> GoogleKeywordsForSiteLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The Keywords For Site endpoint will provide you with a list of keywords relevant to the target domain. Each keyword is supplied with relevant categories, search volume data for the last month, cost-per-click, competition, and search volume trend values for the past 12 months.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_site/live/?bash'

### **GoogleRelatedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo> GoogleRelatedKeywordsLiveAsync(IEnumerable<DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo&gt;](./DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo&gt;](./DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

The Related Keywords endpoint provides keywords appearing in the
 <br>  "searches related to" SERP element
 <br>You can get up to 4680 keyword ideas by specifying the search depth. Each related keyword comes with the list of relevant product categories, search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values. Moreover, this endpoint supplies minimum, maximum and average values of daily impressions, clicks and CPC for each result.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/related_keywords/live/?bash'

### **GoogleRelatedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo> GoogleRelatedKeywordsLiveAsync(IEnumerable<DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo&gt;](./DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo&gt;](./DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

The Related Keywords endpoint provides keywords appearing in the
 <br>  "searches related to" SERP element
 <br>You can get up to 4680 keyword ideas by specifying the search depth. Each related keyword comes with the list of relevant product categories, search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values. Moreover, this endpoint supplies minimum, maximum and average values of daily impressions, clicks and CPC for each result.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/related_keywords/live/?bash'

### **GoogleKeywordSuggestionsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo> GoogleKeywordSuggestionsLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Keyword Suggestions endpoint provides search queries that include the specified seed keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keyword_suggestions/live/?bash'

### **GoogleKeywordSuggestionsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo> GoogleKeywordSuggestionsLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Keyword Suggestions endpoint provides search queries that include the specified seed keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keyword_suggestions/live/?bash'

### **GoogleKeywordIdeasLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordIdeasLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleKeywordIdeasLiveResponseInfo> GoogleKeywordIdeasLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordIdeasLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordIdeasLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordIdeasLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordIdeasLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordIdeasLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The Keyword Ideas endpoint provides search terms that are relevant to the product or service categories of the specified keywords. The algorithm selects the keywords which fall into the same categories as the seed keywords specified in a POST array.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keyword_ideas/live/?bash'

### **GoogleKeywordIdeasLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordIdeasLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleKeywordIdeasLiveResponseInfo> GoogleKeywordIdeasLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordIdeasLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordIdeasLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordIdeasLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordIdeasLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordIdeasLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>The Keyword Ideas endpoint provides search terms that are relevant to the product or service categories of the specified keywords. The algorithm selects the keywords which fall into the same categories as the seed keywords specified in a POST array.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keyword_ideas/live/?bash'

### **GoogleBulkKeywordDifficultyLiveAsync(IEnumerable&lt;DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo> GoogleBulkKeywordDifficultyLiveAsync(IEnumerable<DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo&gt;](./DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo&gt;](./DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the Keyword Difficulty metric for a maximum of 1,000 keywords in one API request. Keyword Difficulty stands for the relative difficulty of ranking in the first top-10 organic results for the related keyword. Keyword Difficulty in DataForSEO API responses indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_keyword_difficulty/live/?bash'

### **GoogleBulkKeywordDifficultyLiveAsync(IEnumerable&lt;DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo> GoogleBulkKeywordDifficultyLiveAsync(IEnumerable<DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo&gt;](./DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo&gt;](./DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with the Keyword Difficulty metric for a maximum of 1,000 keywords in one API request. Keyword Difficulty stands for the relative difficulty of ranking in the first top-10 organic results for the related keyword. Keyword Difficulty in DataForSEO API responses indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_keyword_difficulty/live/?bash'

### **GoogleSearchIntentLiveAsync(IEnumerable&lt;DataforseoLabsGoogleSearchIntentLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleSearchIntentLiveResponseInfo> GoogleSearchIntentLiveAsync(IEnumerable<DataforseoLabsGoogleSearchIntentLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleSearchIntentLiveRequestInfo&gt;](./DataforseoLabsGoogleSearchIntentLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleSearchIntentLiveResponseInfo&gt;](./DataforseoLabsGoogleSearchIntentLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with search intent data for up to 1,000 keywords. For each keyword that you specify when setting a task, the API will return the keyword’s search intent and intent probability. Besides the highest probable search intent, the results will also provide you with other likely search intent(s) and their probability.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/search_intent/live/?bash'

### **GoogleSearchIntentLiveAsync(IEnumerable&lt;DataforseoLabsGoogleSearchIntentLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleSearchIntentLiveResponseInfo> GoogleSearchIntentLiveAsync(IEnumerable<DataforseoLabsGoogleSearchIntentLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleSearchIntentLiveRequestInfo&gt;](./DataforseoLabsGoogleSearchIntentLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleSearchIntentLiveResponseInfo&gt;](./DataforseoLabsGoogleSearchIntentLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with search intent data for up to 1,000 keywords. For each keyword that you specify when setting a task, the API will return the keyword’s search intent and intent probability. Besides the highest probable search intent, the results will also provide you with other likely search intent(s) and their probability.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/search_intent/live/?bash'

### **DataforseoLabsGoogleCategoriesForKeywordsLanguagesAsync()**

```csharp
public Task<DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo> DataforseoLabsGoogleCategoriesForKeywordsLanguagesAsync()
```

#### Returns

[Task&lt;DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo&gt;](./DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Using this endpoint you can get the full list of languages supported for the Google Categories for Keywords endpoint of DataForSEO Labs API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_keywords/languages/?bash'

### **DataforseoLabsGoogleCategoriesForKeywordsLanguagesAsync(CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo> DataforseoLabsGoogleCategoriesForKeywordsLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo&gt;](./DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>Using this endpoint you can get the full list of languages supported for the Google Categories for Keywords endpoint of DataForSEO Labs API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_keywords/languages/?bash'

### **GoogleCategoriesForDomainLiveAsync(IEnumerable&lt;DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo> GoogleCategoriesForDomainLiveAsync(IEnumerable<DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo&gt;](./DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo&gt;](./DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with Google product or service categories that include keywords the domain ranks for in search. Furthermore, you will obtain general rankings and traffic data for the keywords under a certain category.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_domain/live/?bash'

### **GoogleCategoriesForDomainLiveAsync(IEnumerable&lt;DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo> GoogleCategoriesForDomainLiveAsync(IEnumerable<DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo&gt;](./DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo&gt;](./DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with Google product or service categories that include keywords the domain ranks for in search. Furthermore, you will obtain general rankings and traffic data for the keywords under a certain category.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_domain/live/?bash'

### **GoogleCategoriesForKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo> GoogleCategoriesForKeywordsLiveAsync(IEnumerable<DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo&gt;](./DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo&gt;](./DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with Google product and service categories related for each specified keyword. You can indicate a maximum of 1,000 keywords in one API request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_keywords/live/?bash'

### **GoogleCategoriesForKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo> GoogleCategoriesForKeywordsLiveAsync(IEnumerable<DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo&gt;](./DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo&gt;](./DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint will provide you with Google product and service categories related for each specified keyword. You can indicate a maximum of 1,000 keywords in one API request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_keywords/live/?bash'

### **GoogleKeywordsForCategoriesLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo> GoogleKeywordsForCategoriesLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords relevant to the specified product categories. You will get the search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values for each keyword. Moreover, this endpoint supplies minimum, maximum, and average values of daily impressions, clicks, and CPC for each result.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_categories/live/?bash'

### **GoogleKeywordsForCategoriesLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo> GoogleKeywordsForCategoriesLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords relevant to the specified product categories. You will get the search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values for each keyword. Moreover, this endpoint supplies minimum, maximum, and average values of daily impressions, clicks, and CPC for each result.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_categories/live/?bash'

### **GoogleDomainMetricsByCategoriesLiveAsync(IEnumerable&lt;DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo> GoogleDomainMetricsByCategoriesLiveAsync(IEnumerable<DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo&gt;](./DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo&gt;](./DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with dynamics of change in metrics of domains relevant to the specified product and service categories. You will receive historical ranking data from Google SERPs, along with valuable current and historical domain metrics, such as ETV, impressions ETV, estimated paid traffic cost, the total count of SERPs that contain domains, and more.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_metrics_by_categories/live/?bash'

### **GoogleDomainMetricsByCategoriesLiveAsync(IEnumerable&lt;DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo> GoogleDomainMetricsByCategoriesLiveAsync(IEnumerable<DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo&gt;](./DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo&gt;](./DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with dynamics of change in metrics of domains relevant to the specified product and service categories. You will receive historical ranking data from Google SERPs, along with valuable current and historical domain metrics, such as ETV, impressions ETV, estimated paid traffic cost, the total count of SERPs that contain domains, and more.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_metrics_by_categories/live/?bash'

### **GoogleTopSearchesLiveAsync(IEnumerable&lt;DataforseoLabsGoogleTopSearchesLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleTopSearchesLiveResponseInfo> GoogleTopSearchesLiveAsync(IEnumerable<DataforseoLabsGoogleTopSearchesLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleTopSearchesLiveRequestInfo&gt;](./DataforseoLabsGoogleTopSearchesLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleTopSearchesLiveResponseInfo&gt;](./DataforseoLabsGoogleTopSearchesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Top Searches endpoint of DataForSEO Labs API can provide you with over 7 billion keywords from the DataForSEO Keyword Database. Each keyword in the API response is provided with a set of relevant keyword data with Google Ads metrics, product categories, and Google SERP data.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/top_searches/live/?bash'

### **GoogleTopSearchesLiveAsync(IEnumerable&lt;DataforseoLabsGoogleTopSearchesLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleTopSearchesLiveResponseInfo> GoogleTopSearchesLiveAsync(IEnumerable<DataforseoLabsGoogleTopSearchesLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleTopSearchesLiveRequestInfo&gt;](./DataforseoLabsGoogleTopSearchesLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleTopSearchesLiveResponseInfo&gt;](./DataforseoLabsGoogleTopSearchesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Top Searches endpoint of DataForSEO Labs API can provide you with over 7 billion keywords from the DataForSEO Keyword Database. Each keyword in the API response is provided with a set of relevant keyword data with Google Ads metrics, product categories, and Google SERP data.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/top_searches/live/?bash'

### **GoogleDomainWhoisOverviewLiveAsync(IEnumerable&lt;DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo> GoogleDomainWhoisOverviewLiveAsync(IEnumerable<DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo&gt;](./DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo&gt;](./DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with Whois data enriched with ranking and traffic info from organic and paid search results. Using this endpoint you will be able to get all these data for the domains matching the parameters you specify in the request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_whois_overview/live/?bash'

### **GoogleDomainWhoisOverviewLiveAsync(IEnumerable&lt;DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo> GoogleDomainWhoisOverviewLiveAsync(IEnumerable<DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo&gt;](./DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo&gt;](./DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with Whois data enriched with ranking and traffic info from organic and paid search results. Using this endpoint you will be able to get all these data for the domains matching the parameters you specify in the request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_whois_overview/live/?bash'

### **GoogleRankedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleRankedKeywordsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleRankedKeywordsLiveResponseInfo> GoogleRankedKeywordsLiveAsync(IEnumerable<DataforseoLabsGoogleRankedKeywordsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleRankedKeywordsLiveRequestInfo&gt;](./DataforseoLabsGoogleRankedKeywordsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleRankedKeywordsLiveResponseInfo&gt;](./DataforseoLabsGoogleRankedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the list of keywords that any domain or webpage is ranking for. You will also get SERP elements related to the keyword position, as well as impressions, monthly searches and other data relevant to the returned keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/ranked_keywords/live/?bash'

### **GoogleRankedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleRankedKeywordsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleRankedKeywordsLiveResponseInfo> GoogleRankedKeywordsLiveAsync(IEnumerable<DataforseoLabsGoogleRankedKeywordsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleRankedKeywordsLiveRequestInfo&gt;](./DataforseoLabsGoogleRankedKeywordsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleRankedKeywordsLiveResponseInfo&gt;](./DataforseoLabsGoogleRankedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the list of keywords that any domain or webpage is ranking for. You will also get SERP elements related to the keyword position, as well as impressions, monthly searches and other data relevant to the returned keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/ranked_keywords/live/?bash'

### **GoogleSerpCompetitorsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo> GoogleSerpCompetitorsLiveAsync(IEnumerable<DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo&gt;](./DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo&gt;](./DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of domains ranking for the keywords you specify. You will also get SERP rankings, rating, estimated traffic volume, and visibility values the provided domains gain from the specified keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/serp_competitors/live/?bash'

### **GoogleSerpCompetitorsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo> GoogleSerpCompetitorsLiveAsync(IEnumerable<DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo&gt;](./DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo&gt;](./DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of domains ranking for the keywords you specify. You will also get SERP rankings, rating, estimated traffic volume, and visibility values the provided domains gain from the specified keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/serp_competitors/live/?bash'

### **GoogleCompetitorsDomainLiveAsync(IEnumerable&lt;DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo> GoogleCompetitorsDomainLiveAsync(IEnumerable<DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo&gt;](./DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo&gt;](./DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a full overview of ranking and traffic data of the competitor domains from organic and paid search. In addition to that, you will get the metrics specific to the keywords both competitor domains and your domain rank for within the same SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/competitors_domain/live/?bash'

### **GoogleCompetitorsDomainLiveAsync(IEnumerable&lt;DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo> GoogleCompetitorsDomainLiveAsync(IEnumerable<DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo&gt;](./DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo&gt;](./DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a full overview of ranking and traffic data of the competitor domains from organic and paid search. In addition to that, you will get the metrics specific to the keywords both competitor domains and your domain rank for within the same SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/competitors_domain/live/?bash'

### **GoogleDomainIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsGoogleDomainIntersectionLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleDomainIntersectionLiveResponseInfo> GoogleDomainIntersectionLiveAsync(IEnumerable<DataforseoLabsGoogleDomainIntersectionLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleDomainIntersectionLiveRequestInfo&gt;](./DataforseoLabsGoogleDomainIntersectionLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleDomainIntersectionLiveResponseInfo&gt;](./DataforseoLabsGoogleDomainIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the keywords for which both specified domains rank within the same SERP. You will get search volume, competition, cost-per-click and impressions data on each intersecting keyword. Along with that, you will get data on the first and second domain’s SERP element discovered for this keyword, as well as the estimated traffic volume and cost of ad traffic. Domain Intersection endpoint supports organic, paid, local pack, and featured snippet results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_intersection/live/?bash'

### **GoogleDomainIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsGoogleDomainIntersectionLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleDomainIntersectionLiveResponseInfo> GoogleDomainIntersectionLiveAsync(IEnumerable<DataforseoLabsGoogleDomainIntersectionLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleDomainIntersectionLiveRequestInfo&gt;](./DataforseoLabsGoogleDomainIntersectionLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleDomainIntersectionLiveResponseInfo&gt;](./DataforseoLabsGoogleDomainIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the keywords for which both specified domains rank within the same SERP. You will get search volume, competition, cost-per-click and impressions data on each intersecting keyword. Along with that, you will get data on the first and second domain’s SERP element discovered for this keyword, as well as the estimated traffic volume and cost of ad traffic. Domain Intersection endpoint supports organic, paid, local pack, and featured snippet results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_intersection/live/?bash'

### **GoogleSubdomainsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleSubdomainsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleSubdomainsLiveResponseInfo> GoogleSubdomainsLiveAsync(IEnumerable<DataforseoLabsGoogleSubdomainsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleSubdomainsLiveRequestInfo&gt;](./DataforseoLabsGoogleSubdomainsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleSubdomainsLiveResponseInfo&gt;](./DataforseoLabsGoogleSubdomainsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of subdomains of the specified domain, along with the ranking distribution across organic and paid search. In addition to that, you will also get the estimated traffic volume of subdomains based on search volume and impressions.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/subdomains/live/?bash'

### **GoogleSubdomainsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleSubdomainsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleSubdomainsLiveResponseInfo> GoogleSubdomainsLiveAsync(IEnumerable<DataforseoLabsGoogleSubdomainsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleSubdomainsLiveRequestInfo&gt;](./DataforseoLabsGoogleSubdomainsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleSubdomainsLiveResponseInfo&gt;](./DataforseoLabsGoogleSubdomainsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of subdomains of the specified domain, along with the ranking distribution across organic and paid search. In addition to that, you will also get the estimated traffic volume of subdomains based on search volume and impressions.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/subdomains/live/?bash'

### **GoogleRelevantPagesLiveAsync(IEnumerable&lt;DataforseoLabsGoogleRelevantPagesLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleRelevantPagesLiveResponseInfo> GoogleRelevantPagesLiveAsync(IEnumerable<DataforseoLabsGoogleRelevantPagesLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleRelevantPagesLiveRequestInfo&gt;](./DataforseoLabsGoogleRelevantPagesLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleRelevantPagesLiveResponseInfo&gt;](./DataforseoLabsGoogleRelevantPagesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/relevant_pages/live/?bash'

### **GoogleRelevantPagesLiveAsync(IEnumerable&lt;DataforseoLabsGoogleRelevantPagesLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleRelevantPagesLiveResponseInfo> GoogleRelevantPagesLiveAsync(IEnumerable<DataforseoLabsGoogleRelevantPagesLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleRelevantPagesLiveRequestInfo&gt;](./DataforseoLabsGoogleRelevantPagesLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleRelevantPagesLiveResponseInfo&gt;](./DataforseoLabsGoogleRelevantPagesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/relevant_pages/live/?bash'

### **GoogleDomainRankOverviewLiveAsync(IEnumerable&lt;DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo> GoogleDomainRankOverviewLiveAsync(IEnumerable<DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo&gt;](./DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo&gt;](./DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with ranking and traffic data from organic and paid search for the specified domain. You will be able to review the domain ranking distribution in SERPs as well as estimated monthly traffic volume for both organic and paid results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_rank_overview/live/?bash'

### **GoogleDomainRankOverviewLiveAsync(IEnumerable&lt;DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo> GoogleDomainRankOverviewLiveAsync(IEnumerable<DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo&gt;](./DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo&gt;](./DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with ranking and traffic data from organic and paid search for the specified domain. You will be able to review the domain ranking distribution in SERPs as well as estimated monthly traffic volume for both organic and paid results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_rank_overview/live/?bash'

### **GoogleHistoricalSerpsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo> GoogleHistoricalSerpsLiveAsync(IEnumerable<DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo&gt;](./DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo&gt;](./DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with Google SERPs collected within the specified time frame. You will also receive a complete overview of featured snippets and other extra elements that were present within the specified dates. The data will allow you to analyze the dynamics of keyword rankings over time for the specified keyword and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_serps/live/?bash'

### **GoogleHistoricalSerpsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo> GoogleHistoricalSerpsLiveAsync(IEnumerable<DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo&gt;](./DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo&gt;](./DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with Google SERPs collected within the specified time frame. You will also receive a complete overview of featured snippets and other extra elements that were present within the specified dates. The data will allow you to analyze the dynamics of keyword rankings over time for the specified keyword and location.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_serps/live/?bash'

### **GoogleHistoricalRankOverviewLiveAsync(IEnumerable&lt;DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo> GoogleHistoricalRankOverviewLiveAsync(IEnumerable<DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo&gt;](./DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo&gt;](./DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with historical data on rankings and traffic of the specified domain, such as domain ranking distribution in SERPs and estimated monthly traffic volume for both organic and paid results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_rank_overview/live/?bash'

### **GoogleHistoricalRankOverviewLiveAsync(IEnumerable&lt;DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo> GoogleHistoricalRankOverviewLiveAsync(IEnumerable<DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo&gt;](./DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo&gt;](./DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with historical data on rankings and traffic of the specified domain, such as domain ranking distribution in SERPs and estimated monthly traffic volume for both organic and paid results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_rank_overview/live/?bash'

### **GooglePageIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsGooglePageIntersectionLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGooglePageIntersectionLiveResponseInfo> GooglePageIntersectionLiveAsync(IEnumerable<DataforseoLabsGooglePageIntersectionLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGooglePageIntersectionLiveRequestInfo&gt;](./DataforseoLabsGooglePageIntersectionLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGooglePageIntersectionLiveResponseInfo&gt;](./DataforseoLabsGooglePageIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the keywords for which specified pages rank within the same SERP. You will get search volume, competition, cost-per-click and impressions data on each intersecting keyword. Along with that, you will get data on SERP elements that specified pages rank for in search results, as well as the estimated traffic volume and cost of ad traffic. Page Intersection endpoint supports organic, paid, local pack and featured snippet results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/page_intersection/live/?bash'

### **GooglePageIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsGooglePageIntersectionLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGooglePageIntersectionLiveResponseInfo> GooglePageIntersectionLiveAsync(IEnumerable<DataforseoLabsGooglePageIntersectionLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGooglePageIntersectionLiveRequestInfo&gt;](./DataforseoLabsGooglePageIntersectionLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGooglePageIntersectionLiveResponseInfo&gt;](./DataforseoLabsGooglePageIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the keywords for which specified pages rank within the same SERP. You will get search volume, competition, cost-per-click and impressions data on each intersecting keyword. Along with that, you will get data on SERP elements that specified pages rank for in search results, as well as the estimated traffic volume and cost of ad traffic. Page Intersection endpoint supports organic, paid, local pack and featured snippet results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/page_intersection/live/?bash'

### **GoogleBulkTrafficEstimationLiveAsync(IEnumerable&lt;DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo> GoogleBulkTrafficEstimationLiveAsync(IEnumerable<DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo&gt;](./DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo&gt;](./DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with estimated monthly traffic volumes for up to 1,000 domains, subdomains, or webpages. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_traffic_estimation/live/?bash'

### **GoogleBulkTrafficEstimationLiveAsync(IEnumerable&lt;DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo> GoogleBulkTrafficEstimationLiveAsync(IEnumerable<DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo&gt;](./DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo&gt;](./DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with estimated monthly traffic volumes for up to 1,000 domains, subdomains, or webpages. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_traffic_estimation/live/?bash'

### **GoogleHistoricalBulkTrafficEstimationLiveAsync(IEnumerable&lt;DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo> GoogleHistoricalBulkTrafficEstimationLiveAsync(IEnumerable<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo&gt;](./DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo&gt;](./DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with historical monthly traffic volumes for up to 1,000 domains collected within the specified time range through October 2020. If you do not specify the range, data will be returned for the previous 12 months. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_bulk_traffic_estimation/live/?bash'

### **GoogleHistoricalBulkTrafficEstimationLiveAsync(IEnumerable&lt;DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo> GoogleHistoricalBulkTrafficEstimationLiveAsync(IEnumerable<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo&gt;](./DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo&gt;](./DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with historical monthly traffic volumes for up to 1,000 domains collected within the specified time range through October 2020. If you do not specify the range, data will be returned for the previous 12 months. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_bulk_traffic_estimation/live/?bash'

### **GoogleHistoricalKeywordDataLiveAsync(IEnumerable&lt;DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleHistoricalKeywordDataLiveResponseInfo> GoogleHistoricalKeywordDataLiveAsync(IEnumerable<DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo&gt;](./DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleHistoricalKeywordDataLiveResponseInfo&gt;](./DataforseoLabsGoogleHistoricalKeywordDataLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌ 
 <br>This endpoint provides Google historical keyword data for specified keywords, including search volume, cost-per-click, competition values for paid search, monthly searches, and search volume trends. You can get historical keyword data since the beginning of 2019, depending on keywords along with location and language combination. You can find the list of supported locations and languages here.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_keyword_data/live/?bash'

### **GoogleHistoricalKeywordDataLiveAsync(IEnumerable&lt;DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleHistoricalKeywordDataLiveResponseInfo> GoogleHistoricalKeywordDataLiveAsync(IEnumerable<DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo&gt;](./DataforseoLabsGoogleHistoricalKeywordDataLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleHistoricalKeywordDataLiveResponseInfo&gt;](./DataforseoLabsGoogleHistoricalKeywordDataLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌ 
 <br>This endpoint provides Google historical keyword data for specified keywords, including search volume, cost-per-click, competition values for paid search, monthly searches, and search volume trends. You can get historical keyword data since the beginning of 2019, depending on keywords along with location and language combination. You can find the list of supported locations and languages here.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_keyword_data/live/?bash'

### **GoogleKeywordOverviewLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordOverviewLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleKeywordOverviewLiveResponseInfo> GoogleKeywordOverviewLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordOverviewLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordOverviewLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordOverviewLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordOverviewLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌ 
 <br>This endpoint provides Google keyword data for specified keywords. For each keyword, you will receive current cost-per-click, competition values for paid search, search volume, search intent, monthly searches, as well as SERP and backlink information. Additionally, you can obtain clickstream data, such as clickstream search volume, by specifying the include_clickstream_data parameter.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keyword_overview/live/?bash'

### **GoogleKeywordOverviewLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordOverviewLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleKeywordOverviewLiveResponseInfo> GoogleKeywordOverviewLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordOverviewLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordOverviewLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordOverviewLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordOverviewLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌ 
 <br>This endpoint provides Google keyword data for specified keywords. For each keyword, you will receive current cost-per-click, competition values for paid search, search volume, search intent, monthly searches, as well as SERP and backlink information. Additionally, you can obtain clickstream data, such as clickstream search volume, by specifying the include_clickstream_data parameter.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keyword_overview/live/?bash'

### **AmazonBulkSearchVolumeLiveAsync(IEnumerable&lt;DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo> AmazonBulkSearchVolumeLiveAsync(IEnumerable<DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo&gt;](./DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo&gt;](./DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with search volume values for a maximum of 1,000 keywords in one API request. Here search volume represents the approximate number of monthly searches for a keyword on Amazon. The returned results are specific to the keywords, location, and language parameters specified in a POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/bulk_search_volume/live/?bash'

### **AmazonBulkSearchVolumeLiveAsync(IEnumerable&lt;DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo> AmazonBulkSearchVolumeLiveAsync(IEnumerable<DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo&gt;](./DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo&gt;](./DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with search volume values for a maximum of 1,000 keywords in one API request. Here search volume represents the approximate number of monthly searches for a keyword on Amazon. The returned results are specific to the keywords, location, and language parameters specified in a POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/bulk_search_volume/live/?bash'

### **AmazonRelatedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo> AmazonRelatedKeywordsLiveAsync(IEnumerable<DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo&gt;](./DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo&gt;](./DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Related Keywords endpoint provides keywords appearing in the  "Related Searches" section on Amazon.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/related_keywords/live/?bash'

### **AmazonRelatedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo> AmazonRelatedKeywordsLiveAsync(IEnumerable<DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo&gt;](./DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo&gt;](./DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Related Keywords endpoint provides keywords appearing in the  "Related Searches" section on Amazon.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/related_keywords/live/?bash'

### **AmazonRankedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsAmazonRankedKeywordsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsAmazonRankedKeywordsLiveResponseInfo> AmazonRankedKeywordsLiveAsync(IEnumerable<DataforseoLabsAmazonRankedKeywordsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonRankedKeywordsLiveRequestInfo&gt;](./DataforseoLabsAmazonRankedKeywordsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsAmazonRankedKeywordsLiveResponseInfo&gt;](./DataforseoLabsAmazonRankedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords the target product ranks for on Amazon. The returned results are specific to the asin specified in a POST request. Learn more about ASIN in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/ranked_keywords/live/?bash'

### **AmazonRankedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsAmazonRankedKeywordsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsAmazonRankedKeywordsLiveResponseInfo> AmazonRankedKeywordsLiveAsync(IEnumerable<DataforseoLabsAmazonRankedKeywordsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonRankedKeywordsLiveRequestInfo&gt;](./DataforseoLabsAmazonRankedKeywordsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsAmazonRankedKeywordsLiveResponseInfo&gt;](./DataforseoLabsAmazonRankedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords the target product ranks for on Amazon. The returned results are specific to the asin specified in a POST request. Learn more about ASIN in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/ranked_keywords/live/?bash'

### **AmazonProductRankOverviewLiveAsync(IEnumerable&lt;DataforseoLabsAmazonProductRankOverviewLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsAmazonProductRankOverviewLiveResponseInfo> AmazonProductRankOverviewLiveAsync(IEnumerable<DataforseoLabsAmazonProductRankOverviewLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonProductRankOverviewLiveRequestInfo&gt;](./DataforseoLabsAmazonProductRankOverviewLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsAmazonProductRankOverviewLiveResponseInfo&gt;](./DataforseoLabsAmazonProductRankOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with ranking data from organic and paid Amazon SERPs for the target products. The returned results are specific to the asins specified in a POST request. Learn more about ASIN in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_rank_overview/live/?bash'

### **AmazonProductRankOverviewLiveAsync(IEnumerable&lt;DataforseoLabsAmazonProductRankOverviewLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsAmazonProductRankOverviewLiveResponseInfo> AmazonProductRankOverviewLiveAsync(IEnumerable<DataforseoLabsAmazonProductRankOverviewLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonProductRankOverviewLiveRequestInfo&gt;](./DataforseoLabsAmazonProductRankOverviewLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsAmazonProductRankOverviewLiveResponseInfo&gt;](./DataforseoLabsAmazonProductRankOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with ranking data from organic and paid Amazon SERPs for the target products. The returned results are specific to the asins specified in a POST request. Learn more about ASIN in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_rank_overview/live/?bash'

### **AmazonProductCompetitorsLiveAsync(IEnumerable&lt;DataforseoLabsAmazonProductCompetitorsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsAmazonProductCompetitorsLiveResponseInfo> AmazonProductCompetitorsLiveAsync(IEnumerable<DataforseoLabsAmazonProductCompetitorsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonProductCompetitorsLiveRequestInfo&gt;](./DataforseoLabsAmazonProductCompetitorsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsAmazonProductCompetitorsLiveResponseInfo&gt;](./DataforseoLabsAmazonProductCompetitorsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of products that intersect with a target asin in Amazon SERPs. The data can help you identify product competitors for any listing published on Amazon. The returned results are specific to the asin as well as the location and language parameters specified in a POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_competitors/live/?bash'

### **AmazonProductCompetitorsLiveAsync(IEnumerable&lt;DataforseoLabsAmazonProductCompetitorsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsAmazonProductCompetitorsLiveResponseInfo> AmazonProductCompetitorsLiveAsync(IEnumerable<DataforseoLabsAmazonProductCompetitorsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonProductCompetitorsLiveRequestInfo&gt;](./DataforseoLabsAmazonProductCompetitorsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsAmazonProductCompetitorsLiveResponseInfo&gt;](./DataforseoLabsAmazonProductCompetitorsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of products that intersect with a target asin in Amazon SERPs. The data can help you identify product competitors for any listing published on Amazon. The returned results are specific to the asin as well as the location and language parameters specified in a POST request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_competitors/live/?bash'

### **AmazonProductKeywordIntersectionsLiveAsync(IEnumerable&lt;DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo> AmazonProductKeywordIntersectionsLiveAsync(IEnumerable<DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo&gt;](./DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo&gt;](./DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords for which the target products intersect in Amazon SERP. The returned results are specific to the asins specified in a POST request. Learn more about ASIN in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_keyword_intersections/live/?bash'

### **AmazonProductKeywordIntersectionsLiveAsync(IEnumerable&lt;DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo> AmazonProductKeywordIntersectionsLiveAsync(IEnumerable<DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo&gt;](./DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo&gt;](./DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords for which the target products intersect in Amazon SERP. The returned results are specific to the asins specified in a POST request. Learn more about ASIN in this help center article.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_keyword_intersections/live/?bash'

### **BingBulkKeywordDifficultyLiveAsync(IEnumerable&lt;DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo> BingBulkKeywordDifficultyLiveAsync(IEnumerable<DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo&gt;](./DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo&gt;](./DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the Keyword Difficulty metric for a maximum of 1,000 keywords in one API request. Keyword Difficulty stands for the relative difficulty of ranking in the first top-10 organic results for the related keyword. Keyword Difficulty in DataForSEO API responses indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/bulk_keyword_difficulty/live/?bash'

### **BingBulkKeywordDifficultyLiveAsync(IEnumerable&lt;DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo> BingBulkKeywordDifficultyLiveAsync(IEnumerable<DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo&gt;](./DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo&gt;](./DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the Keyword Difficulty metric for a maximum of 1,000 keywords in one API request. Keyword Difficulty stands for the relative difficulty of ranking in the first top-10 organic results for the related keyword. Keyword Difficulty in DataForSEO API responses indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/bulk_keyword_difficulty/live/?bash'

### **BingBulkTrafficEstimationLiveAsync(IEnumerable&lt;DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo> BingBulkTrafficEstimationLiveAsync(IEnumerable<DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo&gt;](./DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo&gt;](./DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with estimated monthly traffic volumes for up to 1,000 domains, subdomains, and pages. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/bulk_traffic_estimation/live/?bash'

### **BingBulkTrafficEstimationLiveAsync(IEnumerable&lt;DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo> BingBulkTrafficEstimationLiveAsync(IEnumerable<DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo&gt;](./DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo&gt;](./DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with estimated monthly traffic volumes for up to 1,000 domains, subdomains, and pages. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/bulk_traffic_estimation/live/?bash'

### **BingCompetitorsDomainLiveAsync(IEnumerable&lt;DataforseoLabsBingCompetitorsDomainLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsBingCompetitorsDomainLiveResponseInfo> BingCompetitorsDomainLiveAsync(IEnumerable<DataforseoLabsBingCompetitorsDomainLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingCompetitorsDomainLiveRequestInfo&gt;](./DataforseoLabsBingCompetitorsDomainLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsBingCompetitorsDomainLiveResponseInfo&gt;](./DataforseoLabsBingCompetitorsDomainLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a full overview of ranking and traffic data of the competitor domains from organic and paid search. In addition to that, you will get the metrics specific to the keywords both competitor domains and your domain rank for within the same SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/competitors_domain/live/?bash'

### **BingCompetitorsDomainLiveAsync(IEnumerable&lt;DataforseoLabsBingCompetitorsDomainLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsBingCompetitorsDomainLiveResponseInfo> BingCompetitorsDomainLiveAsync(IEnumerable<DataforseoLabsBingCompetitorsDomainLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingCompetitorsDomainLiveRequestInfo&gt;](./DataforseoLabsBingCompetitorsDomainLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsBingCompetitorsDomainLiveResponseInfo&gt;](./DataforseoLabsBingCompetitorsDomainLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a full overview of ranking and traffic data of the competitor domains from organic and paid search. In addition to that, you will get the metrics specific to the keywords both competitor domains and your domain rank for within the same SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/competitors_domain/live/?bash'

### **BingDomainIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsBingDomainIntersectionLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsBingDomainIntersectionLiveResponseInfo> BingDomainIntersectionLiveAsync(IEnumerable<DataforseoLabsBingDomainIntersectionLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingDomainIntersectionLiveRequestInfo&gt;](./DataforseoLabsBingDomainIntersectionLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsBingDomainIntersectionLiveResponseInfo&gt;](./DataforseoLabsBingDomainIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the keywords for which both specified domains rank within the same SERP. You will get data on each intersecting keyword. Along with that, you will get data on the first and second domain’s SERP element discovered for this keyword, as well as the estimated traffic volume and cost of ad traffic. Domain Intersection endpoint supports organic, paid, local pack, and featured snippet results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/domain_intersection/live/?bash'

### **BingDomainIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsBingDomainIntersectionLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsBingDomainIntersectionLiveResponseInfo> BingDomainIntersectionLiveAsync(IEnumerable<DataforseoLabsBingDomainIntersectionLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingDomainIntersectionLiveRequestInfo&gt;](./DataforseoLabsBingDomainIntersectionLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsBingDomainIntersectionLiveResponseInfo&gt;](./DataforseoLabsBingDomainIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the keywords for which both specified domains rank within the same SERP. You will get data on each intersecting keyword. Along with that, you will get data on the first and second domain’s SERP element discovered for this keyword, as well as the estimated traffic volume and cost of ad traffic. Domain Intersection endpoint supports organic, paid, local pack, and featured snippet results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/domain_intersection/live/?bash'

### **BingDomainRankOverviewLiveAsync(IEnumerable&lt;DataforseoLabsBingDomainRankOverviewLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsBingDomainRankOverviewLiveResponseInfo> BingDomainRankOverviewLiveAsync(IEnumerable<DataforseoLabsBingDomainRankOverviewLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingDomainRankOverviewLiveRequestInfo&gt;](./DataforseoLabsBingDomainRankOverviewLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsBingDomainRankOverviewLiveResponseInfo&gt;](./DataforseoLabsBingDomainRankOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with ranking and traffic data from Bing’s organic and paid search for the specified domain. You will be able to review the domain ranking distribution in SERPs as well as estimated monthly traffic volume for both organic and paid results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/domain_rank_overview/live/?bash'

### **BingDomainRankOverviewLiveAsync(IEnumerable&lt;DataforseoLabsBingDomainRankOverviewLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsBingDomainRankOverviewLiveResponseInfo> BingDomainRankOverviewLiveAsync(IEnumerable<DataforseoLabsBingDomainRankOverviewLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingDomainRankOverviewLiveRequestInfo&gt;](./DataforseoLabsBingDomainRankOverviewLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsBingDomainRankOverviewLiveResponseInfo&gt;](./DataforseoLabsBingDomainRankOverviewLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with ranking and traffic data from Bing’s organic and paid search for the specified domain. You will be able to review the domain ranking distribution in SERPs as well as estimated monthly traffic volume for both organic and paid results.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/domain_rank_overview/live/?bash'

### **BingPageIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsBingPageIntersectionLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsBingPageIntersectionLiveResponseInfo> BingPageIntersectionLiveAsync(IEnumerable<DataforseoLabsBingPageIntersectionLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingPageIntersectionLiveRequestInfo&gt;](./DataforseoLabsBingPageIntersectionLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsBingPageIntersectionLiveResponseInfo&gt;](./DataforseoLabsBingPageIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the keywords for which specified pages rank within the same Bing SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/page_intersection/live/?bash'

### **BingPageIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsBingPageIntersectionLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsBingPageIntersectionLiveResponseInfo> BingPageIntersectionLiveAsync(IEnumerable<DataforseoLabsBingPageIntersectionLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingPageIntersectionLiveRequestInfo&gt;](./DataforseoLabsBingPageIntersectionLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsBingPageIntersectionLiveResponseInfo&gt;](./DataforseoLabsBingPageIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the keywords for which specified pages rank within the same Bing SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/page_intersection/live/?bash'

### **BingRankedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsBingRankedKeywordsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsBingRankedKeywordsLiveResponseInfo> BingRankedKeywordsLiveAsync(IEnumerable<DataforseoLabsBingRankedKeywordsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingRankedKeywordsLiveRequestInfo&gt;](./DataforseoLabsBingRankedKeywordsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsBingRankedKeywordsLiveResponseInfo&gt;](./DataforseoLabsBingRankedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the list of keywords that any domain or webpage is ranking for. You will also get SERP elements related to the keyword position, as well as monthly searches and other data relevant to the returned keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/ranked_keywords/live/?bash'

### **BingRankedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsBingRankedKeywordsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsBingRankedKeywordsLiveResponseInfo> BingRankedKeywordsLiveAsync(IEnumerable<DataforseoLabsBingRankedKeywordsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingRankedKeywordsLiveRequestInfo&gt;](./DataforseoLabsBingRankedKeywordsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsBingRankedKeywordsLiveResponseInfo&gt;](./DataforseoLabsBingRankedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with the list of keywords that any domain or webpage is ranking for. You will also get SERP elements related to the keyword position, as well as monthly searches and other data relevant to the returned keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/ranked_keywords/live/?bash'

### **BingRelatedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsBingRelatedKeywordsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsBingRelatedKeywordsLiveResponseInfo> BingRelatedKeywordsLiveAsync(IEnumerable<DataforseoLabsBingRelatedKeywordsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingRelatedKeywordsLiveRequestInfo&gt;](./DataforseoLabsBingRelatedKeywordsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsBingRelatedKeywordsLiveResponseInfo&gt;](./DataforseoLabsBingRelatedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Related Keywords endpoint provides keywords appearing in the “searches related to” SERP element.
 <br>You can get up to 4680 keyword ideas by specifying the search depth. Each related keyword comes with search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/related_keywords/live/?bash'

### **BingRelatedKeywordsLiveAsync(IEnumerable&lt;DataforseoLabsBingRelatedKeywordsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsBingRelatedKeywordsLiveResponseInfo> BingRelatedKeywordsLiveAsync(IEnumerable<DataforseoLabsBingRelatedKeywordsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingRelatedKeywordsLiveRequestInfo&gt;](./DataforseoLabsBingRelatedKeywordsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsBingRelatedKeywordsLiveResponseInfo&gt;](./DataforseoLabsBingRelatedKeywordsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>The Related Keywords endpoint provides keywords appearing in the “searches related to” SERP element.
 <br>You can get up to 4680 keyword ideas by specifying the search depth. Each related keyword comes with search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/related_keywords/live/?bash'

### **BingRelevantPagesLiveAsync(IEnumerable&lt;DataforseoLabsBingRelevantPagesLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsBingRelevantPagesLiveResponseInfo> BingRelevantPagesLiveAsync(IEnumerable<DataforseoLabsBingRelevantPagesLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingRelevantPagesLiveRequestInfo&gt;](./DataforseoLabsBingRelevantPagesLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsBingRelevantPagesLiveResponseInfo&gt;](./DataforseoLabsBingRelevantPagesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with rankings and traffic data for the web pages of the specified domain. You will be able to review each page’s ranking distribution and estimated monthly traffic volume from both organic and paid searches.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/relevant_pages/live/?bash'

### **BingRelevantPagesLiveAsync(IEnumerable&lt;DataforseoLabsBingRelevantPagesLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsBingRelevantPagesLiveResponseInfo> BingRelevantPagesLiveAsync(IEnumerable<DataforseoLabsBingRelevantPagesLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingRelevantPagesLiveRequestInfo&gt;](./DataforseoLabsBingRelevantPagesLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsBingRelevantPagesLiveResponseInfo&gt;](./DataforseoLabsBingRelevantPagesLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with rankings and traffic data for the web pages of the specified domain. You will be able to review each page’s ranking distribution and estimated monthly traffic volume from both organic and paid searches.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/relevant_pages/live/?bash'

### **BingSerpCompetitorsLiveAsync(IEnumerable&lt;DataforseoLabsBingSerpCompetitorsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsBingSerpCompetitorsLiveResponseInfo> BingSerpCompetitorsLiveAsync(IEnumerable<DataforseoLabsBingSerpCompetitorsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingSerpCompetitorsLiveRequestInfo&gt;](./DataforseoLabsBingSerpCompetitorsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsBingSerpCompetitorsLiveResponseInfo&gt;](./DataforseoLabsBingSerpCompetitorsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of domain rankings for the keywords you specify. You will also get SERP rankings, rating, estimated traffic volume, and visibility values the provided domains gain from the specified keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/serp_competitors/live/?bash'

### **BingSerpCompetitorsLiveAsync(IEnumerable&lt;DataforseoLabsBingSerpCompetitorsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsBingSerpCompetitorsLiveResponseInfo> BingSerpCompetitorsLiveAsync(IEnumerable<DataforseoLabsBingSerpCompetitorsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingSerpCompetitorsLiveRequestInfo&gt;](./DataforseoLabsBingSerpCompetitorsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsBingSerpCompetitorsLiveResponseInfo&gt;](./DataforseoLabsBingSerpCompetitorsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of domain rankings for the keywords you specify. You will also get SERP rankings, rating, estimated traffic volume, and visibility values the provided domains gain from the specified keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/serp_competitors/live/?bash'

### **BingSubdomainsLiveAsync(IEnumerable&lt;DataforseoLabsBingSubdomainsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsBingSubdomainsLiveResponseInfo> BingSubdomainsLiveAsync(IEnumerable<DataforseoLabsBingSubdomainsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingSubdomainsLiveRequestInfo&gt;](./DataforseoLabsBingSubdomainsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsBingSubdomainsLiveResponseInfo&gt;](./DataforseoLabsBingSubdomainsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of subdomains of the specified domain, along with the ranking distribution across organic and paid search. In addition to that, you will also get the estimated traffic volume of subdomains based on search volume.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/subdomains/live/?bash'

### **BingSubdomainsLiveAsync(IEnumerable&lt;DataforseoLabsBingSubdomainsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsBingSubdomainsLiveResponseInfo> BingSubdomainsLiveAsync(IEnumerable<DataforseoLabsBingSubdomainsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsBingSubdomainsLiveRequestInfo&gt;](./DataforseoLabsBingSubdomainsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsBingSubdomainsLiveResponseInfo&gt;](./DataforseoLabsBingSubdomainsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>This endpoint will provide you with a list of subdomains of the specified domain, along with the ranking distribution across organic and paid search. In addition to that, you will also get the estimated traffic volume of subdomains based on search volume.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/subdomains/live/?bash'

### **GoogleBulkAppMetricsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo> GoogleBulkAppMetricsLiveAsync(IEnumerable<DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo&gt;](./DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo&gt;](./DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with ranking metrics for up to 1000 Google Play applications.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_app_metrics/live/?bash'

### **GoogleBulkAppMetricsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo> GoogleBulkAppMetricsLiveAsync(IEnumerable<DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo&gt;](./DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo&gt;](./DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with ranking metrics for up to 1000 Google Play applications.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_app_metrics/live/?bash'

### **GoogleKeywordsForAppLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordsForAppLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleKeywordsForAppLiveResponseInfo> GoogleKeywordsForAppLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordsForAppLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordsForAppLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordsForAppLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordsForAppLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordsForAppLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords for which the target app ranks on Google Play. You will obtain keyword data and discover the app’s ranking position for each returned keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_app/live/?bash'

### **GoogleKeywordsForAppLiveAsync(IEnumerable&lt;DataforseoLabsGoogleKeywordsForAppLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleKeywordsForAppLiveResponseInfo> GoogleKeywordsForAppLiveAsync(IEnumerable<DataforseoLabsGoogleKeywordsForAppLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleKeywordsForAppLiveRequestInfo&gt;](./DataforseoLabsGoogleKeywordsForAppLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleKeywordsForAppLiveResponseInfo&gt;](./DataforseoLabsGoogleKeywordsForAppLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords for which the target app ranks on Google Play. You will obtain keyword data and discover the app’s ranking position for each returned keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_app/live/?bash'

### **GoogleAppCompetitorsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleAppCompetitorsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleAppCompetitorsLiveResponseInfo> GoogleAppCompetitorsLiveAsync(IEnumerable<DataforseoLabsGoogleAppCompetitorsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleAppCompetitorsLiveRequestInfo&gt;](./DataforseoLabsGoogleAppCompetitorsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleAppCompetitorsLiveResponseInfo&gt;](./DataforseoLabsGoogleAppCompetitorsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of mobile applications that intersect with the target app for its ranking keywords on Google Play. You will obtain the IDs of competitor apps along with search volume and ranking data on competitor ranking keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/app_competitors/live/?bash'

### **GoogleAppCompetitorsLiveAsync(IEnumerable&lt;DataforseoLabsGoogleAppCompetitorsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleAppCompetitorsLiveResponseInfo> GoogleAppCompetitorsLiveAsync(IEnumerable<DataforseoLabsGoogleAppCompetitorsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleAppCompetitorsLiveRequestInfo&gt;](./DataforseoLabsGoogleAppCompetitorsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleAppCompetitorsLiveResponseInfo&gt;](./DataforseoLabsGoogleAppCompetitorsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of mobile applications that intersect with the target app for its ranking keywords on Google Play. You will obtain the IDs of competitor apps along with search volume and ranking data on competitor ranking keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/app_competitors/live/?bash'

### **GoogleAppIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsGoogleAppIntersectionLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsGoogleAppIntersectionLiveResponseInfo> GoogleAppIntersectionLiveAsync(IEnumerable<DataforseoLabsGoogleAppIntersectionLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleAppIntersectionLiveRequestInfo&gt;](./DataforseoLabsGoogleAppIntersectionLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsGoogleAppIntersectionLiveResponseInfo&gt;](./DataforseoLabsGoogleAppIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords for which the mobile applications specified in the app_ids object rank within the same Google Play SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/app_intersection/live/?bash'

### **GoogleAppIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsGoogleAppIntersectionLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsGoogleAppIntersectionLiveResponseInfo> GoogleAppIntersectionLiveAsync(IEnumerable<DataforseoLabsGoogleAppIntersectionLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsGoogleAppIntersectionLiveRequestInfo&gt;](./DataforseoLabsGoogleAppIntersectionLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsGoogleAppIntersectionLiveResponseInfo&gt;](./DataforseoLabsGoogleAppIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords for which the mobile applications specified in the app_ids object rank within the same Google Play SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/app_intersection/live/?bash'

### **AppleBulkAppMetricsLiveAsync(IEnumerable&lt;DataforseoLabsAppleBulkAppMetricsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsAppleBulkAppMetricsLiveResponseInfo> AppleBulkAppMetricsLiveAsync(IEnumerable<DataforseoLabsAppleBulkAppMetricsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAppleBulkAppMetricsLiveRequestInfo&gt;](./DataforseoLabsAppleBulkAppMetricsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsAppleBulkAppMetricsLiveResponseInfo&gt;](./DataforseoLabsAppleBulkAppMetricsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with ranking metrics for up to 1000 App Store applications.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/bulk_app_metrics/live/?bash'

### **AppleBulkAppMetricsLiveAsync(IEnumerable&lt;DataforseoLabsAppleBulkAppMetricsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsAppleBulkAppMetricsLiveResponseInfo> AppleBulkAppMetricsLiveAsync(IEnumerable<DataforseoLabsAppleBulkAppMetricsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAppleBulkAppMetricsLiveRequestInfo&gt;](./DataforseoLabsAppleBulkAppMetricsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsAppleBulkAppMetricsLiveResponseInfo&gt;](./DataforseoLabsAppleBulkAppMetricsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with ranking metrics for up to 1000 App Store applications.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/bulk_app_metrics/live/?bash'

### **AppleKeywordsForAppLiveAsync(IEnumerable&lt;DataforseoLabsAppleKeywordsForAppLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsAppleKeywordsForAppLiveResponseInfo> AppleKeywordsForAppLiveAsync(IEnumerable<DataforseoLabsAppleKeywordsForAppLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAppleKeywordsForAppLiveRequestInfo&gt;](./DataforseoLabsAppleKeywordsForAppLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsAppleKeywordsForAppLiveResponseInfo&gt;](./DataforseoLabsAppleKeywordsForAppLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords for which the target app ranks on App Store. You will obtain keyword data and discover the app’s ranking position for each returned keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/keywords_for_app/live/?bash'

### **AppleKeywordsForAppLiveAsync(IEnumerable&lt;DataforseoLabsAppleKeywordsForAppLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsAppleKeywordsForAppLiveResponseInfo> AppleKeywordsForAppLiveAsync(IEnumerable<DataforseoLabsAppleKeywordsForAppLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAppleKeywordsForAppLiveRequestInfo&gt;](./DataforseoLabsAppleKeywordsForAppLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsAppleKeywordsForAppLiveResponseInfo&gt;](./DataforseoLabsAppleKeywordsForAppLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords for which the target app ranks on App Store. You will obtain keyword data and discover the app’s ranking position for each returned keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/keywords_for_app/live/?bash'

### **AppleAppCompetitorsLiveAsync(IEnumerable&lt;DataforseoLabsAppleAppCompetitorsLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsAppleAppCompetitorsLiveResponseInfo> AppleAppCompetitorsLiveAsync(IEnumerable<DataforseoLabsAppleAppCompetitorsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAppleAppCompetitorsLiveRequestInfo&gt;](./DataforseoLabsAppleAppCompetitorsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsAppleAppCompetitorsLiveResponseInfo&gt;](./DataforseoLabsAppleAppCompetitorsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of mobile applications that intersect with the target app for its ranking keywords on App Store. You will obtain the IDs of competitor apps along with search volume and ranking data on competitor ranking keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/app_competitors/live/?bash'

### **AppleAppCompetitorsLiveAsync(IEnumerable&lt;DataforseoLabsAppleAppCompetitorsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsAppleAppCompetitorsLiveResponseInfo> AppleAppCompetitorsLiveAsync(IEnumerable<DataforseoLabsAppleAppCompetitorsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAppleAppCompetitorsLiveRequestInfo&gt;](./DataforseoLabsAppleAppCompetitorsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsAppleAppCompetitorsLiveResponseInfo&gt;](./DataforseoLabsAppleAppCompetitorsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of mobile applications that intersect with the target app for its ranking keywords on App Store. You will obtain the IDs of competitor apps along with search volume and ranking data on competitor ranking keywords.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/app_competitors/live/?bash'

### **AppleAppIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsAppleAppIntersectionLiveRequestInfo&gt;)**

```csharp
public Task<DataforseoLabsAppleAppIntersectionLiveResponseInfo> AppleAppIntersectionLiveAsync(IEnumerable<DataforseoLabsAppleAppIntersectionLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAppleAppIntersectionLiveRequestInfo&gt;](./DataforseoLabsAppleAppIntersectionLiveRequestInfo.md)<br>

#### Returns

[Task&lt;DataforseoLabsAppleAppIntersectionLiveResponseInfo&gt;](./DataforseoLabsAppleAppIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords for which the mobile applications specified in the app_ids object rank within the same App Store SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/app_intersection/live/?bash'

### **AppleAppIntersectionLiveAsync(IEnumerable&lt;DataforseoLabsAppleAppIntersectionLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<DataforseoLabsAppleAppIntersectionLiveResponseInfo> AppleAppIntersectionLiveAsync(IEnumerable<DataforseoLabsAppleAppIntersectionLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;DataforseoLabsAppleAppIntersectionLiveRequestInfo&gt;](./DataforseoLabsAppleAppIntersectionLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;DataforseoLabsAppleAppIntersectionLiveResponseInfo&gt;](./DataforseoLabsAppleAppIntersectionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with a list of keywords for which the mobile applications specified in the app_ids object rank within the same App Store SERP.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/app_intersection/live/?bash'
