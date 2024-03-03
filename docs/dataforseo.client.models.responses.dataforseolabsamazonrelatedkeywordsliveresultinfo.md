# DataforseoLabsAmazonRelatedKeywordsLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DataforseoLabsAmazonRelatedKeywordsLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsAmazonRelatedKeywordsLiveResultInfo](./dataforseo.client.models.responses.dataforseolabsamazonrelatedkeywordsliveresultinfo.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeedKeyword**

keyword in a POST array

```csharp
public string SeedKeyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeedKeywordData**

keyword data for the seed keyword
 <br>fields in the object are identical to that of keyword_data

```csharp
public AmazonKeywordData SeedKeywordData { get; set; }
```

#### Property Value

[AmazonKeywordData](./dataforseo.client.models.amazonkeyworddata.md)<br>

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

contains objects with keywords and related data

```csharp
public ICollection<DataforseoLabsAmazonRelatedKeywordsLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;DataforseoLabsAmazonRelatedKeywordsLiveItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsAmazonRelatedKeywordsLiveResultInfo()**

```csharp
public DataforseoLabsAmazonRelatedKeywordsLiveResultInfo()
```
