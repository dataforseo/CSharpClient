[`< Back`](./)

---

# ContentGenerationCheckGrammarLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class ContentGenerationCheckGrammarLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentGenerationCheckGrammarLiveResultInfo](./dataforseo.client.models.responses.contentgenerationcheckgrammarliveresultinfo)

## Properties

### **InputTokens**

number of input tokens in the POST request

```csharp
public Nullable<int> InputTokens { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OutputTokens**

number of output tokens in the response

```csharp
public Nullable<int> OutputTokens { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **NewTokens**

number of new tokens in the response

```csharp
public Nullable<int> NewTokens { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **InitialText**

initial text in the POST request

```csharp
public string InitialText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

language code in the POST request

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ItemsCount**

the number of results returned in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

contains grammar or spelling errors and related data

```csharp
public ICollection<ContentGenerationCheckGrammarLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;ContentGenerationCheckGrammarLiveItem&gt;](./dataforseo.client.models.contentgenerationcheckgrammarliveitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ContentGenerationCheckGrammarLiveResultInfo()**

```csharp
public ContentGenerationCheckGrammarLiveResultInfo()
```

---

[`< Back`](./)
