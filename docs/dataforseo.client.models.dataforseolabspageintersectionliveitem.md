# DataforseoLabsPageIntersectionLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsPageIntersectionLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsPageIntersectionLiveItem](./dataforseo.client.models.dataforseolabspageintersectionliveitem.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **KeywordData**

keyword data for the returned keyword

```csharp
public KeywordData KeywordData { get; set; }
```

#### Property Value

[KeywordData](./dataforseo.client.models.keyworddata.md)<br>

### **IntersectionResult**

contains data on the SERP elements found for the returned keyword
 <br>data will be provided in separate arrays for each URL you specified in the pages object when setting a task;
 <br>depending on the number of specified URLs, it can contain from 1 to 20 arrays named respectively

```csharp
public IDictionary<string, BaseDataforseoLabsSerpElementItem> IntersectionResult { get; set; }
```

#### Property Value

[IDictionary&lt;String, BaseDataforseoLabsSerpElementItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsPageIntersectionLiveItem()**

```csharp
public DataforseoLabsPageIntersectionLiveItem()
```
