[`< Back`](./)

---

# DataforseoLabsAmazonRelatedKeywordsLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsAmazonRelatedKeywordsLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsAmazonRelatedKeywordsLiveItem](./dataforseo.client.models.dataforseolabsamazonrelatedkeywordsliveitem)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **KeywordData**

keyword data for the returned keyword

```csharp
public AmazonKeywordData KeywordData { get; set; }
```

#### Property Value

[AmazonKeywordData](./dataforseo.client.models.amazonkeyworddata)<br>

### **Depth**

keyword search depth

```csharp
public Nullable<int> Depth { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RelatedKeywords**

list of related keywords
 <br>represents the list of search queries which are related to the keyword returned in the array above

```csharp
public ICollection<string> RelatedKeywords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsAmazonRelatedKeywordsLiveItem()**

```csharp
public DataforseoLabsAmazonRelatedKeywordsLiveItem()
```

---

[`< Back`](./)
