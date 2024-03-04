# ContentGenerationGenerateTextLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class ContentGenerationGenerateTextLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentGenerationGenerateTextLiveResultInfo](./dataforseo.client.models.responses.contentgenerationgeneratetextliveresultinfo.md)

## Properties

### **InputTokens**

number of input tokens

```csharp
public Nullable<int> InputTokens { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OutputTokens**

number of output tokens

```csharp
public Nullable<int> OutputTokens { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **NewTokens**

number of new tokens

```csharp
public Nullable<int> NewTokens { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **GeneratedText**

resulting text

```csharp
public string GeneratedText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SupplementToken**

token for generating subsequent results
 <br>you can use this parameter to continue the generation from the end of the current result;
 <br>supplement_token values are unique for each subsequent task

```csharp
public string SupplementToken { get; set; }
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

### **ContentGenerationGenerateTextLiveResultInfo()**

```csharp
public ContentGenerationGenerateTextLiveResultInfo()
```
