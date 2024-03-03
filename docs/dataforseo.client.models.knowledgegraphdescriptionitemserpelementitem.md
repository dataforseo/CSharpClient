# KnowledgeGraphDescriptionItemSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class KnowledgeGraphDescriptionItemSerpElementItem : BaseSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseSerpElementItem](./dataforseo.client.models.baseserpelementitem.md) → [KnowledgeGraphDescriptionItemSerpElementItem](./dataforseo.client.models.knowledgegraphdescriptionitemserpelementitem.md)

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

### **Text**

description content

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Links**

sitelinks
 <br>the links shown below some of Google’s search results
 <br>if there are none, equals null

```csharp
public ICollection<LinkElement> Links { get; set; }
```

#### Property Value

[ICollection&lt;LinkElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Rectangle**

rectangle parameters
 <br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP
 <br>equals null if calculate_rectangles in the POST request is not set to true

```csharp
public Rectangle Rectangle { get; set; }
```

#### Property Value

[Rectangle](./dataforseo.client.models.rectangle.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KnowledgeGraphDescriptionItemSerpElementItem()**

```csharp
public KnowledgeGraphDescriptionItemSerpElementItem()
```
