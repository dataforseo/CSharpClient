[`< Back`](./)

---

# GoogleTrendsMapElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class GoogleTrendsMapElementItem : BaseGoogleTrendsItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseGoogleTrendsItem](./dataforseo.client.models.basegoogletrendsitem) → [GoogleTrendsMapElementItem](./dataforseo.client.models.googletrendsmapelementitem)

## Properties

### **Position**

the alignment of the element in Google Trends
 <br>can take the following values: 1, 2, 3, 4, etc.

```csharp
public Nullable<int> Position { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Title**

title of the element in Google Trends

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Keywords**

relevant keywords
 <br>the data included in the google_trends_map element is based on the keywords listed in this array

```csharp
public ICollection<string> Keywords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Data**

Google Trends data from the corresponding item

```csharp
public ICollection<TrendsMapDataInfo> Data { get; set; }
```

#### Property Value

[ICollection&lt;TrendsMapDataInfo&gt;](./dataforseo.client.models.trendsmapdatainfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **GoogleTrendsMapElementItem()**

```csharp
public GoogleTrendsMapElementItem()
```

---

[`< Back`](./)
