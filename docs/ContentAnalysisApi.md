# ContentAnalysisApi

Namespace: DataForSeo.Client.Api

```csharp
public class ContentAnalysisApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/Object) → [ContentAnalysisApi](./ContentAnalysisApi.md)

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

### **ContentAnalysisApi(HttpClient)**

```csharp
public ContentAnalysisApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **ContentAnalysisIdListAsync(IEnumerable&lt;ContentAnalysisIdListRequestInfo&gt;)**

```csharp
public Task<ContentAnalysisIdListResponseInfo> ContentAnalysisIdListAsync(IEnumerable<ContentAnalysisIdListRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisIdListRequestInfo&gt;](./ContentAnalysisIdListRequestInfo.md)<br>

#### Returns

[Task&lt;ContentAnalysisIdListResponseInfo&gt;](./ContentAnalysisIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Content Analysis tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/id_list/?bash'

### **ContentAnalysisIdListAsync(IEnumerable&lt;ContentAnalysisIdListRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentAnalysisIdListResponseInfo> ContentAnalysisIdListAsync(IEnumerable<ContentAnalysisIdListRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisIdListRequestInfo&gt;](./ContentAnalysisIdListRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentAnalysisIdListResponseInfo&gt;](./ContentAnalysisIdListResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint is designed to provide you with the list of IDs and metadata of the completed Content Analysis tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/id_list/?bash'

### **ContentAnalysisAvailableFiltersAsync()**

```csharp
public Task<ContentAnalysisAvailableFiltersResponseInfo> ContentAnalysisAvailableFiltersAsync()
```

#### Returns

[Task&lt;ContentAnalysisAvailableFiltersResponseInfo&gt;](./ContentAnalysisAvailableFiltersResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Here you will find all the necessary information about filters that can be used with Content Analysis API endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/filters/?bash'

### **ContentAnalysisAvailableFiltersAsync(CancellationToken)**

```csharp
public Task<ContentAnalysisAvailableFiltersResponseInfo> ContentAnalysisAvailableFiltersAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentAnalysisAvailableFiltersResponseInfo&gt;](./ContentAnalysisAvailableFiltersResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌‌
 <br>Here you will find all the necessary information about filters that can be used with Content Analysis API endpoints.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/filters/?bash'

### **ContentAnalysisLocationsAsync()**

```csharp
public Task<ContentAnalysisLocationsResponseInfo> ContentAnalysisLocationsAsync()
```

#### Returns

[Task&lt;ContentAnalysisLocationsResponseInfo&gt;](./ContentAnalysisLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/locations/?bash'

### **ContentAnalysisLocationsAsync(CancellationToken)**

```csharp
public Task<ContentAnalysisLocationsResponseInfo> ContentAnalysisLocationsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentAnalysisLocationsResponseInfo&gt;](./ContentAnalysisLocationsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of locations by this API call.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/locations/?bash'

### **ContentAnalysisLanguagesAsync()**

```csharp
public Task<ContentAnalysisLanguagesResponseInfo> ContentAnalysisLanguagesAsync()
```

#### Returns

[Task&lt;ContentAnalysisLanguagesResponseInfo&gt;](./ContentAnalysisLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br> 
 <br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/languages/?bash'

### **ContentAnalysisLanguagesAsync(CancellationToken)**

```csharp
public Task<ContentAnalysisLanguagesResponseInfo> ContentAnalysisLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentAnalysisLanguagesResponseInfo&gt;](./ContentAnalysisLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
 <br> 
 <br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/languages/?bash'

### **ContentAnalysisCategoriesAsync()**

```csharp
public Task<ContentAnalysisCategoriesResponseInfo> ContentAnalysisCategoriesAsync()
```

#### Returns

[Task&lt;ContentAnalysisCategoriesResponseInfo&gt;](./ContentAnalysisCategoriesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

We use Google product and service categories. This endpoint will provide you with the full list of available categories.
 <br>You can also download the CSV file by this link.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/categories/?bash'

### **ContentAnalysisCategoriesAsync(CancellationToken)**

```csharp
public Task<ContentAnalysisCategoriesResponseInfo> ContentAnalysisCategoriesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentAnalysisCategoriesResponseInfo&gt;](./ContentAnalysisCategoriesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

We use Google product and service categories. This endpoint will provide you with the full list of available categories.
 <br>You can also download the CSV file by this link.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/categories/?bash'

### **SearchLiveAsync(IEnumerable&lt;ContentAnalysisSearchLiveRequestInfo&gt;)**

```csharp
public Task<ContentAnalysisSearchLiveResponseInfo> SearchLiveAsync(IEnumerable<ContentAnalysisSearchLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisSearchLiveRequestInfo&gt;](./ContentAnalysisSearchLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentAnalysisSearchLiveResponseInfo&gt;](./ContentAnalysisSearchLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with detailed citation data available for the target keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/search/live/?bash'

### **SearchLiveAsync(IEnumerable&lt;ContentAnalysisSearchLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentAnalysisSearchLiveResponseInfo> SearchLiveAsync(IEnumerable<ContentAnalysisSearchLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisSearchLiveRequestInfo&gt;](./ContentAnalysisSearchLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentAnalysisSearchLiveResponseInfo&gt;](./ContentAnalysisSearchLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with detailed citation data available for the target keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/search/live/?bash'

### **ContentAnalysisSummaryLiveAsync(IEnumerable&lt;ContentAnalysisSummaryLiveRequestInfo&gt;)**

```csharp
public Task<ContentAnalysisSummaryLiveResponseInfo> ContentAnalysisSummaryLiveAsync(IEnumerable<ContentAnalysisSummaryLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisSummaryLiveRequestInfo&gt;](./ContentAnalysisSummaryLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentAnalysisSummaryLiveResponseInfo&gt;](./ContentAnalysisSummaryLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with an overview of citation data available for the target keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/summary/live/?bash'

### **ContentAnalysisSummaryLiveAsync(IEnumerable&lt;ContentAnalysisSummaryLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentAnalysisSummaryLiveResponseInfo> ContentAnalysisSummaryLiveAsync(IEnumerable<ContentAnalysisSummaryLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisSummaryLiveRequestInfo&gt;](./ContentAnalysisSummaryLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentAnalysisSummaryLiveResponseInfo&gt;](./ContentAnalysisSummaryLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with an overview of citation data available for the target keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/summary/live/?bash'

### **SentimentAnalysisLiveAsync(IEnumerable&lt;ContentAnalysisSentimentAnalysisLiveRequestInfo&gt;)**

```csharp
public Task<ContentAnalysisSentimentAnalysisLiveResponseInfo> SentimentAnalysisLiveAsync(IEnumerable<ContentAnalysisSentimentAnalysisLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisSentimentAnalysisLiveRequestInfo&gt;](./ContentAnalysisSentimentAnalysisLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentAnalysisSentimentAnalysisLiveResponseInfo&gt;](./ContentAnalysisSentimentAnalysisLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with sentiment analysis data for the citations available for the target keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/sentiment_analysis/live/?bash'

### **SentimentAnalysisLiveAsync(IEnumerable&lt;ContentAnalysisSentimentAnalysisLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentAnalysisSentimentAnalysisLiveResponseInfo> SentimentAnalysisLiveAsync(IEnumerable<ContentAnalysisSentimentAnalysisLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisSentimentAnalysisLiveRequestInfo&gt;](./ContentAnalysisSentimentAnalysisLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentAnalysisSentimentAnalysisLiveResponseInfo&gt;](./ContentAnalysisSentimentAnalysisLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with sentiment analysis data for the citations available for the target keyword.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/sentiment_analysis/live/?bash'

### **RatingDistributionLiveAsync(IEnumerable&lt;ContentAnalysisRatingDistributionLiveRequestInfo&gt;)**

```csharp
public Task<ContentAnalysisRatingDistributionLiveResponseInfo> RatingDistributionLiveAsync(IEnumerable<ContentAnalysisRatingDistributionLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisRatingDistributionLiveRequestInfo&gt;](./ContentAnalysisRatingDistributionLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentAnalysisRatingDistributionLiveResponseInfo&gt;](./ContentAnalysisRatingDistributionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with rating distribution data for the keyword and other parameters specified in the request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/rating_distribution/live/?bash'

### **RatingDistributionLiveAsync(IEnumerable&lt;ContentAnalysisRatingDistributionLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentAnalysisRatingDistributionLiveResponseInfo> RatingDistributionLiveAsync(IEnumerable<ContentAnalysisRatingDistributionLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisRatingDistributionLiveRequestInfo&gt;](./ContentAnalysisRatingDistributionLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentAnalysisRatingDistributionLiveResponseInfo&gt;](./ContentAnalysisRatingDistributionLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with rating distribution data for the keyword and other parameters specified in the request.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/rating_distribution/live/?bash'

### **PhraseTrendsLiveAsync(IEnumerable&lt;ContentAnalysisPhraseTrendsLiveRequestInfo&gt;)**

```csharp
public Task<ContentAnalysisPhraseTrendsLiveResponseInfo> PhraseTrendsLiveAsync(IEnumerable<ContentAnalysisPhraseTrendsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisPhraseTrendsLiveRequestInfo&gt;](./ContentAnalysisPhraseTrendsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentAnalysisPhraseTrendsLiveResponseInfo&gt;](./ContentAnalysisPhraseTrendsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with data on all citations of the target keyword for the indicated date range.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/phrase_trends/live/?bash'

### **PhraseTrendsLiveAsync(IEnumerable&lt;ContentAnalysisPhraseTrendsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentAnalysisPhraseTrendsLiveResponseInfo> PhraseTrendsLiveAsync(IEnumerable<ContentAnalysisPhraseTrendsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisPhraseTrendsLiveRequestInfo&gt;](./ContentAnalysisPhraseTrendsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentAnalysisPhraseTrendsLiveResponseInfo&gt;](./ContentAnalysisPhraseTrendsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with data on all citations of the target keyword for the indicated date range.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/phrase_trends/live/?bash'

### **CategoryTrendsLiveAsync(IEnumerable&lt;ContentAnalysisCategoryTrendsLiveRequestInfo&gt;)**

```csharp
public Task<ContentAnalysisCategoryTrendsLiveResponseInfo> CategoryTrendsLiveAsync(IEnumerable<ContentAnalysisCategoryTrendsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisCategoryTrendsLiveRequestInfo&gt;](./ContentAnalysisCategoryTrendsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentAnalysisCategoryTrendsLiveResponseInfo&gt;](./ContentAnalysisCategoryTrendsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with data on all citations in the target category for the indicated date range.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/category_trends/live/?bash'

### **CategoryTrendsLiveAsync(IEnumerable&lt;ContentAnalysisCategoryTrendsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentAnalysisCategoryTrendsLiveResponseInfo> CategoryTrendsLiveAsync(IEnumerable<ContentAnalysisCategoryTrendsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentAnalysisCategoryTrendsLiveRequestInfo&gt;](./ContentAnalysisCategoryTrendsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentAnalysisCategoryTrendsLiveResponseInfo&gt;](./ContentAnalysisCategoryTrendsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
 <br>This endpoint will provide you with data on all citations in the target category for the indicated date range.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/category_trends/live/?bash'

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
