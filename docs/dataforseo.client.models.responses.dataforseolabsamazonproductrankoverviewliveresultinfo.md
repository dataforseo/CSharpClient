# DataforseoLabsAmazonProductRankOverviewLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DataforseoLabsAmazonProductRankOverviewLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsAmazonProductRankOverviewLiveResultInfo](./dataforseo.client.models.responses.dataforseolabsamazonproductrankoverviewliveresultinfo.md)

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

### **Items**

contains detected Amazon product competitors and related data

```csharp
public ICollection<DataforseoLabsAmazonProductRankOverviewLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;DataforseoLabsAmazonProductRankOverviewLiveItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsAmazonProductRankOverviewLiveResultInfo()**

```csharp
public DataforseoLabsAmazonProductRankOverviewLiveResultInfo()
```