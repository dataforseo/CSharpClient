# DataforseoLabsGoogleCategoriesForDomainLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsGoogleCategoriesForDomainLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleCategoriesForDomainLiveItem](./dataforseo.client.models.dataforseolabsgooglecategoriesfordomainliveitem.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Categories**

product and service categories
 <br>you can download the full list of possible categories

```csharp
public ICollection<int> Categories { get; set; }
```

#### Property Value

[ICollection&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Metrics**

ranking data relevant to the specified domain or subdomain

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

### **DataforseoLabsGoogleCategoriesForDomainLiveItem()**

```csharp
public DataforseoLabsGoogleCategoriesForDomainLiveItem()
```
