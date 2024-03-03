# TrendsTopicListDataInfo

Namespace: DataForSeo.Client.Models

```csharp
public class TrendsTopicListDataInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TrendsTopicListDataInfo](./dataforseo.client.models.trendstopiclistdatainfo.md)

## Properties

### **Top**

the most popular related topics
 <br>represents the list of the most popular related topics

```csharp
public ICollection<TopicListDataItemInfo> Top { get; set; }
```

#### Property Value

[ICollection&lt;TopicListDataItemInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Rising**

emerging related topics
 <br>represents the list of related topics with the biggest increase in search frequency since the last time period

```csharp
public ICollection<TopicListDataItemInfo> Rising { get; set; }
```

#### Property Value

[ICollection&lt;TopicListDataItemInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **TrendsTopicListDataInfo()**

```csharp
public TrendsTopicListDataInfo()
```
