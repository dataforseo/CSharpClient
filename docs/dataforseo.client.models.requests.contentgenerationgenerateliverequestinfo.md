[`< Back`](./)

---

# ContentGenerationGenerateLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class ContentGenerationGenerateLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentGenerationGenerateLiveRequestInfo](./dataforseo.client.models.requests.contentgenerationgenerateliverequestinfo)

## Properties

### **Text**

initial target text
 <br>required field
 <br>text input for content generation;
 <br>can contain from 1 to 500 tokens
 <br>learn more about tokens on our help center

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MaxNewTokens**

generation limit for new tokens
 <br>required field if max_tokens is not specified
 <br>the maximum number of new tokens for generated content;
 <br>maximum value: 300;
 <br>Note: the number does not include tokens specified in the text field;
 <br>learn more about this parameter on our help center

```csharp
public Nullable<int> MaxNewTokens { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MaxTokens**

generation limit for all tokens
 <br>required field if max_new_tokens is not specified
 <br>the maximum total number of tokens for generated content;
 <br>maximum value: 1024;
 <br>Note: the number includes tokens specified in the text field
 <br>learn more about this parameter on our help center

```csharp
public Nullable<int> MaxTokens { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CreativityIndex**

creativity of content generation
 <br>optional field
 <br>if you use this field, you don’t need to use top_k / top_p / temperature
 <br>the randomness of the selection of equally probable subsequent tokens;
 <br>can take values from 0 to 1
 <br>default value: 0.8
 <br>learn more about this parameter on our help center

```csharp
public Nullable<float> CreativityIndex { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TokenRepetitionPenalty**

token repetition
 <br>optional field
 <br>limits the repetition of the same tokens in the generated content;
 <br>can take values from 0.5 to 2;
 <br>default value: 1

```csharp
public Nullable<float> TokenRepetitionPenalty { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TopK**

the number of initial tokens in each iteration for choosing a subsequent word
 <br>optional field
 <br>if you use creativity_index, this field will be ignored
 <br>the higher the number, the more high-probability tokens will be shortlisted for generation;
 <br>can take values from 1 to 100;
 <br>default value: 40
 <br>learn more about this parameter on our help center

```csharp
public Nullable<int> TopK { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TopP**

excludes initial tokens with probability lower than one
 <br>optional field
 <br>if you use creativity_index, this field will be ignored
 <br>the higher the value, the less low-probability tokens may be shortlisted for generation;
 <br>can take values from 0 to 1
 <br>default value: 0.9
 <br>Note:if both top_k and top_p are used, top_k acts first;
 <br>learn more about this parameter on our help center

```csharp
public Nullable<float> TopP { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Temperature**

controls the randomness in the output
 <br>optional field
 <br>if you use creativity_index, this field will be ignored
 <br>the lower the temperature, the more likely the model will choose words with a higher probability of occurrence;
 <br>can take values from 0 to 1;
 <br>default value: 0.7
 <br>learn more about this parameter on our help center

```csharp
public Nullable<float> Temperature { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AvoidWords**

words or phrases to avoid when generating a text
 <br>optional field
 <br>you can specify up to 50 terms;
 <br>example:
 <br>["term", "optimization"]

```csharp
public ICollection<string> AvoidWords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AvoidStartingWords**

words or phrases to avoid in the beginning of the generated text
 <br>optional field
 <br>you can specify up to 50 terms;
 <br>example:
 <br>["SEO", "search engine optimization"]

```csharp
public ICollection<string> AvoidStartingWords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **StopWords**

words or phrases to end the text
 <br>optional field
 <br>you can specify up to 50 terms;
 <br>example:
 <br>["now","subscribe"]

```csharp
public ICollection<string> StopWords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **SupplementToken**

token for generating subsequent results
 <br>optional field
 <br>provided in the identical filed of the response to each request;
 <br>you can use this parameter to continue the generation of text from the initial response
 <br>supplement_token values are unique for each subsequent task

```csharp
public string SupplementToken { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Tag**

user-defined task identifier
 <br>optional field
 <br>the character limit is 255
 <br>you can use this parameter to identify the task and match it with the result
 <br>you will find the specified tag value in the data object of the response

```csharp
public string Tag { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ContentGenerationGenerateLiveRequestInfo()**

```csharp
public ContentGenerationGenerateLiveRequestInfo()
```

---

[`< Back`](./)
