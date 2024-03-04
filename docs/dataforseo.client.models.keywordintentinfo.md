# KeywordIntentInfo

Namespace: DataForSeo.Client.Models

```csharp
public class KeywordIntentInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordIntentInfo](./dataforseo.client.models.keywordintentinfo.md)

## Properties

### **Label**

search intent name
 <br>possible values: informational, navigational, commercial, transactional

```csharp
public string Label { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Probability**

search intent probability
 <br>1 indicates the highest probability

```csharp
public Nullable<float> Probability { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KeywordIntentInfo()**

```csharp
public KeywordIntentInfo()
```
