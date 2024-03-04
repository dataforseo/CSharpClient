# DataforseoLabsDomainRankOverviewLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsDomainRankOverviewLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsDomainRankOverviewLiveItem](./dataforseo.client.models.dataforseolabsdomainrankoverviewliveitem.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code in a POST array

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageCode**

language code in a POST array

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Metrics**

ranking data relevant to the specified domain

```csharp
public IDictionary<string, MetricsInfo> Metrics { get; set; }
```

#### Property Value

[IDictionary&lt;String, MetricsInfo&gt;](./dataforseo.client.models.metricsinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsDomainRankOverviewLiveItem()**

```csharp
public DataforseoLabsDomainRankOverviewLiveItem()
```
