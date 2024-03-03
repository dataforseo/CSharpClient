# KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResultInfo](./dataforseo.client.models.responses.keywordsdatagoogleadskeywordsforsitetasksreadyresultinfo.md)

## Properties

### **Id**

task identifier of the completed task
 <br>unique task identifier in our system in the UUID format

```csharp
public string Id { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Se**

search engine specified when setting the task

```csharp
public string Se { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Function**

type of the task

```csharp
public string Function { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DatePosted**

date when the task was posted (in the UTC format)

```csharp
public string DatePosted { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Tag**

user-defined task identifier

```csharp
public string Tag { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Endpoint**

URL for collecting the results of the task

```csharp
public string Endpoint { get; set; }
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

### **KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResultInfo()**

```csharp
public KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResultInfo()
```