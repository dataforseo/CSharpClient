# QueriesListDataInfo

Namespace: DataForSeo.Client.Models

```csharp
public class QueriesListDataInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [QueriesListDataInfo](./dataforseo.client.models.querieslistdatainfo.md)

## Properties

### **Top**

the most popular related topics
 <br>represents the list of the most popular related topics

```csharp
public ICollection<QueriesListDataItemInfo> Top { get; set; }
```

#### Property Value

[ICollection&lt;QueriesListDataItemInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Rising**

emerging related topics
 <br>represents the list of related topics with the biggest increase in search frequency since the last time period

```csharp
public ICollection<QueriesListDataItemInfo> Rising { get; set; }
```

#### Property Value

[ICollection&lt;QueriesListDataItemInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **QueriesListDataInfo()**

```csharp
public QueriesListDataInfo()
```
