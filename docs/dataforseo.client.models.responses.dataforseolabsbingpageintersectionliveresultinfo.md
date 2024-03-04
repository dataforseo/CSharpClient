# DataforseoLabsBingPageIntersectionLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DataforseoLabsBingPageIntersectionLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsBingPageIntersectionLiveResultInfo](./dataforseo.client.models.responses.dataforseolabsbingpageintersectionliveresultinfo.md)

## Properties

### **SeType**

search engine type
 <br>search engine type specified in a POST request;
 <br>for this endpoint, the field equals bing

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Pages**

URLs you specified a POST array

```csharp
public IDictionary<string, string> Pages { get; set; }
```

#### Property Value

[IDictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ExcludePages**

URLs you specified in a POST array that will be excluded from the results

```csharp
public ICollection<string> ExcludePages { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

contains keywords, relevant SERP elements and related data

```csharp
public ICollection<DataforseoLabsPageIntersectionLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;DataforseoLabsPageIntersectionLiveItem&gt;](./dataforseo.client.models.dataforseolabspageintersectionliveitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsBingPageIntersectionLiveResultInfo()**

```csharp
public DataforseoLabsBingPageIntersectionLiveResultInfo()
```
