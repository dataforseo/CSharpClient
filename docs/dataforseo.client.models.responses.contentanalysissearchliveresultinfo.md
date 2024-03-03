# ContentAnalysisSearchLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class ContentAnalysisSearchLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentAnalysisSearchLiveResultInfo](./dataforseo.client.models.responses.contentanalysissearchliveresultinfo.md)

## Properties

### **OffsetToken**

offset token for subsequent requests
 <br>you can use the string provided in this field to get the subsequent results of the initial task;
 <br>note: offset_token values are unique for each subsequent task

```csharp
public string OffsetToken { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TotalCount**

total amount of results in our database relevant to your request

```csharp
public Nullable<long> TotalCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ItemsCount**

the number of results returned in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

contains citations and related data

```csharp
public ICollection<ContentAnalysisSearchLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;ContentAnalysisSearchLiveItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ContentAnalysisSearchLiveResultInfo()**

```csharp
public ContentAnalysisSearchLiveResultInfo()
```
