# DataforseoLabsAmazonProductRankOverviewLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsAmazonProductRankOverviewLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsAmazonProductRankOverviewLiveItem](./dataforseo.client.models.dataforseolabsamazonproductrankoverviewliveitem.md)

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

### **Metrics**

average keyword position of the product

```csharp
public AmazonMetricsBundleInfo Metrics { get; set; }
```

#### Property Value

[AmazonMetricsBundleInfo](./dataforseo.client.models.amazonmetricsbundleinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsAmazonProductRankOverviewLiveItem()**

```csharp
public DataforseoLabsAmazonProductRankOverviewLiveItem()
```
