[`< Back`](./)

---

# BusinessDataBusinessListingsCategoriesAggregationLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BusinessDataBusinessListingsCategoriesAggregationLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataBusinessListingsCategoriesAggregationLiveResultInfo](./dataforseo.client.models.responses.businessdatabusinesslistingscategoriesaggregationliveresultinfo)

## Properties

### **TotalCount**

total number of results in our database relevant to your request

```csharp
public Nullable<long> TotalCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Count**

item types
 <br>the number of items in the items array

```csharp
public Nullable<long> Count { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned categories

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OffsetToken**

token for subsequent requests
 <br>by specifying the unique offset_token when setting a new task, you will get the subsequent results of the initial task;
 <br>offset_token values are unique for each subsequent task

```csharp
public string OffsetToken { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Items**

encountered item types
 <br>types of search engine results encountered in the items array;
 <br>possible item types: business_category

```csharp
public ICollection<BusinessDataBusinessListingsCategoriesAggregationLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BusinessDataBusinessListingsCategoriesAggregationLiveItem&gt;](./dataforseo.client.models.businessdatabusinesslistingscategoriesaggregationliveitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataBusinessListingsCategoriesAggregationLiveResultInfo()**

```csharp
public BusinessDataBusinessListingsCategoriesAggregationLiveResultInfo()
```

---

[`< Back`](./)
