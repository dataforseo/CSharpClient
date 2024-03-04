[`< Back`](./)

---

# DataforseoLabsAmazonProductCompetitorsLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsAmazonProductCompetitorsLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsAmazonProductCompetitorsLiveItem](./dataforseo.client.models.dataforseolabsamazonproductcompetitorsliveitem)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Asin**

ASIN of the product
 <br>unique product identifier on Amazon;
 <br>for more information, refer to this help center guide

```csharp
public string Asin { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AvgPosition**

average position of the product in Amazon SERP
 <br>Note: average position is calculated for intersected keywords only;
 <br>the value for a given product may differ when combined with different target products

```csharp
public Nullable<float> AvgPosition { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SumPosition**

sum of all product positions in Amazon SERP
 <br>Note: average position is calculated for intersected keywords only;
 <br>the value for a given product may differ when combined with different target products

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

### **CompetitorMetrics**

metrics for intersecting keywords
 <br>ranking data relevant to the keywords that the provided asin shares with the target asin;
 <br>Note: in this object ranking data is provided for the returned competitor’s asin

```csharp
public AmazonMetricsBundleInfo CompetitorMetrics { get; set; }
```

#### Property Value

[AmazonMetricsBundleInfo](./dataforseo.client.models.amazonmetricsbundleinfo)<br>

### **FullMetrics**

metrics for all keywords of the product
 <br>full overview of ranking data relevant to all keywords that the provided asin is ranking for

```csharp
public AmazonMetricsBundleInfo FullMetrics { get; set; }
```

#### Property Value

[AmazonMetricsBundleInfo](./dataforseo.client.models.amazonmetricsbundleinfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsAmazonProductCompetitorsLiveItem()**

```csharp
public DataforseoLabsAmazonProductCompetitorsLiveItem()
```

---

[`< Back`](./)
