[`< Back`](./)

---

# KnowledgeGraphImagesItemSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class KnowledgeGraphImagesItemSerpElementItem : BaseSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseSerpElementItem](./dataforseo.client.models.baseserpelementitem) → [KnowledgeGraphImagesItemSerpElementItem](./dataforseo.client.models.knowledgegraphimagesitemserpelementitem)

## Properties

### **RankGroup**

group rank in SERP
 <br>position within a group of elements with identical type values
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

### **Link**

link of the element

```csharp
public LinkElement Link { get; set; }
```

#### Property Value

[LinkElement](./dataforseo.client.models.linkelement)<br>

### **Items**

items featured in the faq_box

```csharp
public ICollection<KnowledgeGraphImagesElement> Items { get; set; }
```

#### Property Value

[ICollection&lt;KnowledgeGraphImagesElement&gt;](./dataforseo.client.models.knowledgegraphimageselement)<br>

### **Rectangle**

rectangle parameters
 <br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP
 <br>equals null if calculate_rectangles in the POST request is not set to true

```csharp
public Rectangle Rectangle { get; set; }
```

#### Property Value

[Rectangle](./dataforseo.client.models.rectangle)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KnowledgeGraphImagesItemSerpElementItem()**

```csharp
public KnowledgeGraphImagesItemSerpElementItem()
```

---

[`< Back`](./)
