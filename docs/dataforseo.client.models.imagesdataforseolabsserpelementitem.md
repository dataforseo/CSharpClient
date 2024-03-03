# ImagesDataforseoLabsSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class ImagesDataforseoLabsSerpElementItem : BaseDataforseoLabsSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseDataforseoLabsSerpElementItem](./dataforseo.client.models.basedataforseolabsserpelementitem.md) → [ImagesDataforseoLabsSerpElementItem](./dataforseo.client.models.imagesdataforseolabsserpelementitem.md)

## Properties

### **RankGroup**

position within a group of elements with identical type values
 <br>positions of elements with different type values are omitted from rank_group

```csharp
public Nullable<int> RankGroup { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RankAbsolute**

absolute rank in SERP
 <br>absolute position among all the elements in SERP

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

the alignment of the element in SERP
 <br>can take the following values:
 <br>left, right

```csharp
public string Position { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Xpath**

the XPath of the element

```csharp
public string Xpath { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the result in SERP

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL link

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Items**

elements of search results found in SERP

```csharp
public ICollection<ImagesElement> Items { get; set; }
```

#### Property Value

[ICollection&lt;ImagesElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **RelatedImageSearches**

contains keywords and images related to the specified search term
 <br>if there are none, equals null

```csharp
public ICollection<RelatedImageSearchesElement> RelatedImageSearches { get; set; }
```

#### Property Value

[ICollection&lt;RelatedImageSearchesElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ImagesDataforseoLabsSerpElementItem()**

```csharp
public ImagesDataforseoLabsSerpElementItem()
```