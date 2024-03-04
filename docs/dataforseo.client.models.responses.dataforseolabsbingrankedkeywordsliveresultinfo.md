# DataforseoLabsBingRankedKeywordsLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DataforseoLabsBingRankedKeywordsLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsBingRankedKeywordsLiveResultInfo](./dataforseo.client.models.responses.dataforseolabsbingrankedkeywordsliveresultinfo.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Target**

target domain in a POST array

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code in a POST array
 <br>if there is no data, then the value is null

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageCode**

language code in a POST array
 <br>if there is no data, then the value is null

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TotalCount**

total number of results in our database relevant to your request

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

### **Metrics**

ranking data relevant to the specified domain
 <br>ranking data is provided by the rank_group parameters that show the result’s rank considering only equivalent SERP elements

```csharp
public IDictionary<string, MetricsInfo> Metrics { get; set; }
```

#### Property Value

[IDictionary&lt;String, MetricsInfo&gt;](./dataforseo.client.models.metricsinfo.md)<br>

### **MetricsAbsolute**

ranking data relevant to the specified domain
 <br>ranking data is provided by the rank_absolute parameters that indicate the result’s position among all SERP elements

```csharp
public IDictionary<string, MetricsInfo> MetricsAbsolute { get; set; }
```

#### Property Value

[IDictionary&lt;String, MetricsInfo&gt;](./dataforseo.client.models.metricsinfo.md)<br>

### **Items**

contains ranked keywords and related data

```csharp
public ICollection<DataforseoLabsBingRankedKeywordsLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;DataforseoLabsBingRankedKeywordsLiveItem&gt;](./dataforseo.client.models.dataforseolabsbingrankedkeywordsliveitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsBingRankedKeywordsLiveResultInfo()**

```csharp
public DataforseoLabsBingRankedKeywordsLiveResultInfo()
```
