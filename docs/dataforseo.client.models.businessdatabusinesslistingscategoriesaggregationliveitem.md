[`< Back`](./)

---

# BusinessDataBusinessListingsCategoriesAggregationLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BusinessDataBusinessListingsCategoriesAggregationLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataBusinessListingsCategoriesAggregationLiveItem](./dataforseo.client.models.businessdatabusinesslistingscategoriesaggregationliveitem)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Categories**

business categories
 <br>Google My Business general category that best describes the cluster of related categories

```csharp
public ICollection<string> Categories { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Aggregation**

aggregation of the category

```csharp
public BusinessListingAggregationInfo Aggregation { get; set; }
```

#### Property Value

[BusinessListingAggregationInfo](./dataforseo.client.models.businesslistingaggregationinfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataBusinessListingsCategoriesAggregationLiveItem()**

```csharp
public BusinessDataBusinessListingsCategoriesAggregationLiveItem()
```

---

[`< Back`](./)
