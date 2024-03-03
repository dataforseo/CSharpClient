# DataforseoLabsCompetitorsDomainLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsCompetitorsDomainLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsCompetitorsDomainLiveItem](./dataforseo.client.models.dataforseolabscompetitorsdomainliveitem.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

domain name

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AvgPosition**

average position of the domain in SERP
 <br>Note: average position is calculated for intersected keywords only;
 <br>the value for a given domain may differ when combined with different target websites

```csharp
public Nullable<float> AvgPosition { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SumPosition**

sum of all domain positions in SERP
 <br>Note: average position is calculated for intersected keywords only;
 <br>the value for a given domain may differ when combined with different target websites

```csharp
public Nullable<int> SumPosition { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Intersections**

number of intersecting keywords

```csharp
public Nullable<int> Intersections { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FullDomainMetrics**

metrics for all keywords of the domain
 <br>full overview of ranking and traffic data relevant to all keywords that the provided domain is ranking for

```csharp
public IDictionary<string, MetricsInfo> FullDomainMetrics { get; set; }
```

#### Property Value

[IDictionary&lt;String, MetricsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **Metrics**

metrics for intersecting keywords
 <br>ranking and traffic data relevant to the keywords that the provided domain shares with the target domain
 <br>note: in this array ranking and traffic data is provided for the target considering the keywords target shares in search with the competitor’s domain

```csharp
public IDictionary<string, MetricsInfo> Metrics { get; set; }
```

#### Property Value

[IDictionary&lt;String, MetricsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **CompetitorMetrics**

metrics for intersecting keywords
 <br>ranking and traffic data relevant to the keywords that the provided domain shares with the target domain
 <br>note: in this array ranking and traffic data is provided for the returned competitor’s domain

```csharp
public IDictionary<string, MetricsInfo> CompetitorMetrics { get; set; }
```

#### Property Value

[IDictionary&lt;String, MetricsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsCompetitorsDomainLiveItem()**

```csharp
public DataforseoLabsCompetitorsDomainLiveItem()
```
