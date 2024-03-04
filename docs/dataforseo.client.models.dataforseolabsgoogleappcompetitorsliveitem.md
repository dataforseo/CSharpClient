[`< Back`](./)

---

# DataforseoLabsGoogleAppCompetitorsLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsGoogleAppCompetitorsLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleAppCompetitorsLiveItem](./dataforseo.client.models.dataforseolabsgoogleappcompetitorsliveitem)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AppId**

id of the competitor app

```csharp
public string AppId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AvgPosition**

average position of the app in Google Play SERP
 <br>Note: average position is calculated for intersected keywords only;
 <br>the value for a given application may differ when combined with different target applications

```csharp
public Nullable<float> AvgPosition { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SumPosition**

sum of all app positions in Google Play SERP
 <br>Note: sum position is calculated for intersected keywords only;
 <br>the value for a given application may differ when combined with different target applications

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
 <br>ranking data relevant to the keywords that the provided competitor application shares with the app in a POST request;
 <br>note: in this array ranking data is provided for the returned competitor’s app_id

```csharp
public GooglePlayMetricsBundleInfo CompetitorMetrics { get; set; }
```

#### Property Value

[GooglePlayMetricsBundleInfo](./dataforseo.client.models.googleplaymetricsbundleinfo)<br>

### **FullMetrics**

metrics for all keywords of the application
 <br>full overview of ranking data relevant to all keywords that the provided app_id is ranking for

```csharp
public GooglePlayMetricsBundleInfo FullMetrics { get; set; }
```

#### Property Value

[GooglePlayMetricsBundleInfo](./dataforseo.client.models.googleplaymetricsbundleinfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsGoogleAppCompetitorsLiveItem()**

```csharp
public DataforseoLabsGoogleAppCompetitorsLiveItem()
```

---

[`< Back`](./)
