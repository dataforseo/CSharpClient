[root](./../ "root") / [docs](./ "docs")

[[Back to README.md]](./../README.md "[Back to README.md]")

# ContentGenerationApi

Namespace: DataForSeo.Client.Api

```csharp
public class ContentGenerationApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/Object) → [ContentGenerationApi](./ContentGenerationApi.md)

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

### **ContentGenerationApi(HttpClient)**

```csharp
public ContentGenerationApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **GenerateLiveAsync(IEnumerable&lt;ContentGenerationGenerateLiveRequestInfo&gt;)**

```csharp
public Task<ContentGenerationGenerateLiveResponseInfo> GenerateLiveAsync(IEnumerable<ContentGenerationGenerateLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationGenerateLiveRequestInfo&gt;](./ContentGenerationGenerateLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentGenerationGenerateLiveResponseInfo&gt;](./ContentGenerationGenerateLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with a text generated based on the part of the text you define and other available parameters.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/generate/live/?bash'

### **GenerateLiveAsync(IEnumerable&lt;ContentGenerationGenerateLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentGenerationGenerateLiveResponseInfo> GenerateLiveAsync(IEnumerable<ContentGenerationGenerateLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationGenerateLiveRequestInfo&gt;](./ContentGenerationGenerateLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationGenerateLiveResponseInfo&gt;](./ContentGenerationGenerateLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with a text generated based on the part of the text you define and other available parameters.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/generate/live/?bash'

### **GenerateTextLiveAsync(IEnumerable&lt;ContentGenerationGenerateTextLiveRequestInfo&gt;)**

```csharp
public Task<ContentGenerationGenerateTextLiveResponseInfo> GenerateTextLiveAsync(IEnumerable<ContentGenerationGenerateTextLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationGenerateTextLiveRequestInfo&gt;](./ContentGenerationGenerateTextLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentGenerationGenerateTextLiveResponseInfo&gt;](./ContentGenerationGenerateTextLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with a text generated based on the topic and other parameters you specify.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/generate_text/live/?bash'

### **GenerateTextLiveAsync(IEnumerable&lt;ContentGenerationGenerateTextLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentGenerationGenerateTextLiveResponseInfo> GenerateTextLiveAsync(IEnumerable<ContentGenerationGenerateTextLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationGenerateTextLiveRequestInfo&gt;](./ContentGenerationGenerateTextLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationGenerateTextLiveResponseInfo&gt;](./ContentGenerationGenerateTextLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with a text generated based on the topic and other parameters you specify.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/generate_text/live/?bash'

### **GenerateMetaTagsLiveAsync(IEnumerable&lt;ContentGenerationGenerateMetaTagsLiveRequestInfo&gt;)**

```csharp
public Task<ContentGenerationGenerateMetaTagsLiveResponseInfo> GenerateMetaTagsLiveAsync(IEnumerable<ContentGenerationGenerateMetaTagsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationGenerateMetaTagsLiveRequestInfo&gt;](./ContentGenerationGenerateMetaTagsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentGenerationGenerateMetaTagsLiveResponseInfo&gt;](./ContentGenerationGenerateMetaTagsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint is designed to generate title and description meta tags for a text specified in the request.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/generate_meta_tags/live/?bash'

### **GenerateMetaTagsLiveAsync(IEnumerable&lt;ContentGenerationGenerateMetaTagsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentGenerationGenerateMetaTagsLiveResponseInfo> GenerateMetaTagsLiveAsync(IEnumerable<ContentGenerationGenerateMetaTagsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationGenerateMetaTagsLiveRequestInfo&gt;](./ContentGenerationGenerateMetaTagsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationGenerateMetaTagsLiveResponseInfo&gt;](./ContentGenerationGenerateMetaTagsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint is designed to generate title and description meta tags for a text specified in the request.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/generate_meta_tags/live/?bash'

### **GenerateSubTopicsLiveAsync(IEnumerable&lt;ContentGenerationGenerateSubTopicsLiveRequestInfo&gt;)**

```csharp
public Task<ContentGenerationGenerateSubTopicsLiveResponseInfo> GenerateSubTopicsLiveAsync(IEnumerable<ContentGenerationGenerateSubTopicsLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationGenerateSubTopicsLiveRequestInfo&gt;](./ContentGenerationGenerateSubTopicsLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentGenerationGenerateSubTopicsLiveResponseInfo&gt;](./ContentGenerationGenerateSubTopicsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with 10 subtopics generated based on the topic and other parameters you specify.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/generate_sub_topics/live/?bash'

### **GenerateSubTopicsLiveAsync(IEnumerable&lt;ContentGenerationGenerateSubTopicsLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentGenerationGenerateSubTopicsLiveResponseInfo> GenerateSubTopicsLiveAsync(IEnumerable<ContentGenerationGenerateSubTopicsLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationGenerateSubTopicsLiveRequestInfo&gt;](./ContentGenerationGenerateSubTopicsLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationGenerateSubTopicsLiveResponseInfo&gt;](./ContentGenerationGenerateSubTopicsLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with 10 subtopics generated based on the topic and other parameters you specify.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/generate_sub_topics/live/?bash'

### **ParaphraseLiveAsync(IEnumerable&lt;ContentGenerationParaphraseLiveRequestInfo&gt;)**

```csharp
public Task<ContentGenerationParaphraseLiveResponseInfo> ParaphraseLiveAsync(IEnumerable<ContentGenerationParaphraseLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationParaphraseLiveRequestInfo&gt;](./ContentGenerationParaphraseLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentGenerationParaphraseLiveResponseInfo&gt;](./ContentGenerationParaphraseLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with a paraphrased version of the text you specify.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/paraphrase/live/?bash'

### **ParaphraseLiveAsync(IEnumerable&lt;ContentGenerationParaphraseLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentGenerationParaphraseLiveResponseInfo> ParaphraseLiveAsync(IEnumerable<ContentGenerationParaphraseLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationParaphraseLiveRequestInfo&gt;](./ContentGenerationParaphraseLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationParaphraseLiveResponseInfo&gt;](./ContentGenerationParaphraseLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with a paraphrased version of the text you specify.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/paraphrase/live/?bash'

### **CheckGrammarLiveAsync(IEnumerable&lt;ContentGenerationCheckGrammarLiveRequestInfo&gt;)**

```csharp
public Task<ContentGenerationCheckGrammarLiveResponseInfo> CheckGrammarLiveAsync(IEnumerable<ContentGenerationCheckGrammarLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationCheckGrammarLiveRequestInfo&gt;](./ContentGenerationCheckGrammarLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentGenerationCheckGrammarLiveResponseInfo&gt;](./ContentGenerationCheckGrammarLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with grammar and spelling corrections for the text you specify.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/check_grammar/live/?bash'

### **CheckGrammarLiveAsync(IEnumerable&lt;ContentGenerationCheckGrammarLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentGenerationCheckGrammarLiveResponseInfo> CheckGrammarLiveAsync(IEnumerable<ContentGenerationCheckGrammarLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationCheckGrammarLiveRequestInfo&gt;](./ContentGenerationCheckGrammarLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationCheckGrammarLiveResponseInfo&gt;](./ContentGenerationCheckGrammarLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with grammar and spelling corrections for the text you specify.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/check_grammar/live/?bash'

### **ContentGenerationCheckGrammarLanguagesAsync()**

```csharp
public Task<ContentGenerationCheckGrammarLanguagesResponseInfo> ContentGenerationCheckGrammarLanguagesAsync()
```

#### Returns

[Task&lt;ContentGenerationCheckGrammarLanguagesResponseInfo&gt;](./ContentGenerationCheckGrammarLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
<br> 
<br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/check_grammar/languages/?bash'

### **ContentGenerationCheckGrammarLanguagesAsync(CancellationToken)**

```csharp
public Task<ContentGenerationCheckGrammarLanguagesResponseInfo> ContentGenerationCheckGrammarLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationCheckGrammarLanguagesResponseInfo&gt;](./ContentGenerationCheckGrammarLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
<br> 
<br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/check_grammar/languages/?bash'

### **GrammarRulesAsync()**

```csharp
public Task<ContentGenerationGrammarRulesResponseInfo> GrammarRulesAsync()
```

#### Returns

[Task&lt;ContentGenerationGrammarRulesResponseInfo&gt;](./ContentGenerationGrammarRulesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of grammar rules by calling this API.
<br> 
<br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/grammar_rules/?bash'

### **GrammarRulesAsync(CancellationToken)**

```csharp
public Task<ContentGenerationGrammarRulesResponseInfo> GrammarRulesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationGrammarRulesResponseInfo&gt;](./ContentGenerationGrammarRulesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of grammar rules by calling this API.
<br> 
<br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/grammar_rules/?bash'

### **TextSummaryLiveAsync(IEnumerable&lt;ContentGenerationTextSummaryLiveRequestInfo&gt;)**

```csharp
public Task<ContentGenerationTextSummaryLiveResponseInfo> TextSummaryLiveAsync(IEnumerable<ContentGenerationTextSummaryLiveRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationTextSummaryLiveRequestInfo&gt;](./ContentGenerationTextSummaryLiveRequestInfo.md)<br>

#### Returns

[Task&lt;ContentGenerationTextSummaryLiveResponseInfo&gt;](./ContentGenerationTextSummaryLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with statistical data based on the given text, such as the number of words and sentences, vocabulary density, and text readability.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/text_summary/live/?bash'

### **TextSummaryLiveAsync(IEnumerable&lt;ContentGenerationTextSummaryLiveRequestInfo&gt;, CancellationToken)**

```csharp
public Task<ContentGenerationTextSummaryLiveResponseInfo> TextSummaryLiveAsync(IEnumerable<ContentGenerationTextSummaryLiveRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;ContentGenerationTextSummaryLiveRequestInfo&gt;](./ContentGenerationTextSummaryLiveRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationTextSummaryLiveResponseInfo&gt;](./ContentGenerationTextSummaryLiveResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

‌
<br>This endpoint will provide you with statistical data based on the given text, such as the number of words and sentences, vocabulary density, and text readability.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/text_summary/live/?bash'

### **ContentGenerationTextSummaryLanguagesAsync()**

```csharp
public Task<ContentGenerationTextSummaryLanguagesResponseInfo> ContentGenerationTextSummaryLanguagesAsync()
```

#### Returns

[Task&lt;ContentGenerationTextSummaryLanguagesResponseInfo&gt;](./ContentGenerationTextSummaryLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
<br> 
<br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/text_summary/languages/?bash'

### **ContentGenerationTextSummaryLanguagesAsync(CancellationToken)**

```csharp
public Task<ContentGenerationTextSummaryLanguagesResponseInfo> ContentGenerationTextSummaryLanguagesAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationTextSummaryLanguagesResponseInfo&gt;](./ContentGenerationTextSummaryLanguagesResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive the list of languages by calling this API.
<br> 
<br>As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information specific to the set tasks.
<br>for more info please visit 'https://docs.dataforseo.com/v3/content_generation/text_summary/languages/?bash'

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

[root](./../ "root") / [docs](./ "docs")

[[Back to README.md]](./../README.md "[Back to README.md]")