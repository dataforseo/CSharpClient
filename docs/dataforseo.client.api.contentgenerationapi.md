[`< Back`](./)

---

# ContentGenerationApi

Namespace: DataForSeo.Client.Api

```csharp
public class ContentGenerationApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentGenerationApi](./dataforseo.client.api.contentgenerationapi)

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

`body` [IEnumerable&lt;ContentGenerationGenerateLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationgenerateliverequestinfo)<br>

#### Returns

[Task&lt;ContentGenerationGenerateLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationgenerateliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationGenerateLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationgenerateliverequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationGenerateLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationgenerateliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationGenerateTextLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationgeneratetextliverequestinfo)<br>

#### Returns

[Task&lt;ContentGenerationGenerateTextLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationgeneratetextliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationGenerateTextLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationgeneratetextliverequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationGenerateTextLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationgeneratetextliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationGenerateMetaTagsLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationgeneratemetatagsliverequestinfo)<br>

#### Returns

[Task&lt;ContentGenerationGenerateMetaTagsLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationgeneratemetatagsliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationGenerateMetaTagsLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationgeneratemetatagsliverequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationGenerateMetaTagsLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationgeneratemetatagsliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationGenerateSubTopicsLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationgeneratesubtopicsliverequestinfo)<br>

#### Returns

[Task&lt;ContentGenerationGenerateSubTopicsLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationgeneratesubtopicsliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationGenerateSubTopicsLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationgeneratesubtopicsliverequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationGenerateSubTopicsLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationgeneratesubtopicsliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationParaphraseLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationparaphraseliverequestinfo)<br>

#### Returns

[Task&lt;ContentGenerationParaphraseLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationparaphraseliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationParaphraseLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationparaphraseliverequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationParaphraseLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationparaphraseliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationCheckGrammarLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationcheckgrammarliverequestinfo)<br>

#### Returns

[Task&lt;ContentGenerationCheckGrammarLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationcheckgrammarliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationCheckGrammarLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationcheckgrammarliverequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationCheckGrammarLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationcheckgrammarliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

[Task&lt;ContentGenerationCheckGrammarLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationcheckgrammarlanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationCheckGrammarLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationcheckgrammarlanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

[Task&lt;ContentGenerationGrammarRulesResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationgrammarrulesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationGrammarRulesResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationgrammarrulesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationTextSummaryLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationtextsummaryliverequestinfo)<br>

#### Returns

[Task&lt;ContentGenerationTextSummaryLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationtextsummaryliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`body` [IEnumerable&lt;ContentGenerationTextSummaryLiveRequestInfo&gt;](./dataforseo.client.models.requests.contentgenerationtextsummaryliverequestinfo)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationTextSummaryLiveResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationtextsummaryliveresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

[Task&lt;ContentGenerationTextSummaryLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationtextsummarylanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;ContentGenerationTextSummaryLanguagesResponseInfo&gt;](./dataforseo.client.models.responses.contentgenerationtextsummarylanguagesresponseinfo)<br>
Successful operation

#### Exceptions

[ApiException](./dataforseo.client.models.apiexception)<br>
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

`headers` [IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

Task&lt;ObjectResponseResult&lt;T&gt;&gt;<br>

---

[`< Back`](./)
