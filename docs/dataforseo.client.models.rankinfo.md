# RankInfo

Namespace: DataForSeo.Client.Models

```csharp
public class RankInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RankInfo](./dataforseo.client.models.rankinfo.md)

## Properties

### **PageRank**

page rank
 <br>page_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm;
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public Nullable<int> PageRank { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MainDomainRank**

main domain rank
 <br>main_domain_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public Nullable<int> MainDomainRank { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **RankInfo()**

```csharp
public RankInfo()
```
