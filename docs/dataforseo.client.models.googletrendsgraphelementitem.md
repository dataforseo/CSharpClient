[`< Back`](./)

---

# GoogleTrendsGraphElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class GoogleTrendsGraphElementItem : BaseGoogleTrendsItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseGoogleTrendsItem](./dataforseo.client.models.basegoogletrendsitem) → [GoogleTrendsGraphElementItem](./dataforseo.client.models.googletrendsgraphelementitem)

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
 <br>the data included in the google_trends_graph element is based on the keywords listed in this array

```csharp
public ICollection<string> Keywords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Data**

Google Trends data for the specified parameters

```csharp
public ICollection<TrendsGraphDataInfo> Data { get; set; }
```

#### Property Value

[ICollection&lt;TrendsGraphDataInfo&gt;](./dataforseo.client.models.trendsgraphdatainfo)<br>

### **Averages**

keyword popularity values averaged over the whole time range

```csharp
public ICollection<Nullable<double>> Averages { get; set; }
```

#### Property Value

[ICollection&lt;Nullable&lt;Double&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **GoogleTrendsGraphElementItem()**

```csharp
public GoogleTrendsGraphElementItem()
```

---

[`< Back`](./)
