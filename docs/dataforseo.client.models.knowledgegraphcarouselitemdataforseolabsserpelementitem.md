[`< Back`](./)

---

# KnowledgeGraphCarouselItemDataforseoLabsSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class KnowledgeGraphCarouselItemDataforseoLabsSerpElementItem : BaseDataforseoLabsSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseDataforseoLabsSerpElementItem](./dataforseo.client.models.basedataforseolabsserpelementitem) → [KnowledgeGraphCarouselItemDataforseoLabsSerpElementItem](./dataforseo.client.models.knowledgegraphcarouselitemdataforseolabsserpelementitem)

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

### **Title**

title of the link

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DataAttrid**

google defined data attribute ID
 <br>example:
 <br>ss:/webfacts:net_worth

```csharp
public string DataAttrid { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Link**

link of the element

```csharp
public object Link { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **Items**

additional items present in the element
 <br>if there are none, equals null

```csharp
public ICollection<KnowledgeGraphListElement> Items { get; set; }
```

#### Property Value

[ICollection&lt;KnowledgeGraphListElement&gt;](./dataforseo.client.models.knowledgegraphlistelement)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KnowledgeGraphCarouselItemDataforseoLabsSerpElementItem()**

```csharp
public KnowledgeGraphCarouselItemDataforseoLabsSerpElementItem()
```

---

[`< Back`](./)
