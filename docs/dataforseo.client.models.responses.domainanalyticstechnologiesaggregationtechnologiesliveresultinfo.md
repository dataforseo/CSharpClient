# DomainAnalyticsTechnologiesAggregationTechnologiesLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DomainAnalyticsTechnologiesAggregationTechnologiesLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainAnalyticsTechnologiesAggregationTechnologiesLiveResultInfo](./dataforseo.client.models.responses.domainanalyticstechnologiesaggregationtechnologiesliveresultinfo.md)

## Properties

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

### **Offset**

offset in the results array of returned domains

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

items array

```csharp
public ICollection<DomainAnalyticsTechnologiesAggregationTechnologiesLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;DomainAnalyticsTechnologiesAggregationTechnologiesLiveItem&gt;](./dataforseo.client.models.domainanalyticstechnologiesaggregationtechnologiesliveitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DomainAnalyticsTechnologiesAggregationTechnologiesLiveResultInfo()**

```csharp
public DomainAnalyticsTechnologiesAggregationTechnologiesLiveResultInfo()
```
