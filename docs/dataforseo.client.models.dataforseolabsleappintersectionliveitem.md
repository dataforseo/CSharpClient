# DataforseoLabsleAppIntersectionLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsleAppIntersectionLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsleAppIntersectionLiveItem](./dataforseo.client.models.dataforseolabsleappintersectionliveitem.md)

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

contains SERP data for the returned keyword
 <br>data will be provided in separate arrays for each app ID you specified in the app_ids object when setting a task;
 <br>depending on the number of specified app IDs, it can contain from 1 to 20 arrays named respectively

```csharp
public IDictionary<string, BaseAppDataSerpElementItem> IntersectionResult { get; set; }
```

#### Property Value

[IDictionary&lt;String, BaseAppDataSerpElementItem&gt;](./dataforseo.client.models.baseappdataserpelementitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsleAppIntersectionLiveItem()**

```csharp
public DataforseoLabsleAppIntersectionLiveItem()
```
