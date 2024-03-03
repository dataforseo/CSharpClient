# DataforseoLabsBulkTrafficEstimationLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsBulkTrafficEstimationLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsBulkTrafficEstimationLiveItem](./dataforseo.client.models.dataforseolabsbulktrafficestimationliveitem.md)

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

### **Metrics**

traffic data relevant to the specified domain

```csharp
public IDictionary<string, BulkMetricsInfo> Metrics { get; set; }
```

#### Property Value

[IDictionary&lt;String, BulkMetricsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsBulkTrafficEstimationLiveItem()**

```csharp
public DataforseoLabsBulkTrafficEstimationLiveItem()
```
