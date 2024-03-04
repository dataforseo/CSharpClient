# KnowledgeGraphDataforseoLabsSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class KnowledgeGraphDataforseoLabsSerpElementItem : BaseDataforseoLabsSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseDataforseoLabsSerpElementItem](./dataforseo.client.models.basedataforseolabsserpelementitem.md) → [KnowledgeGraphDataforseoLabsSerpElementItem](./dataforseo.client.models.knowledgegraphdataforseolabsserpelementitem.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

### **SubTitle**

subtitle of the item

```csharp
public string SubTitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

description of the results element in SERP

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CardId**

card id

```csharp
public string CardId { get; set; }
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

### **ImageUrl**

URL of the image from knowledge graph

```csharp
public string ImageUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LogoUrl**

URL of the logo from knowledge graph

```csharp
public string LogoUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Cid**

google-defined client id

```csharp
public string Cid { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Items**

elements of search results found in SERP

```csharp
public ICollection<BaseDataforseoLabsSerpElementItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BaseDataforseoLabsSerpElementItem&gt;](./dataforseo.client.models.basedataforseolabsserpelementitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KnowledgeGraphDataforseoLabsSerpElementItem()**

```csharp
public KnowledgeGraphDataforseoLabsSerpElementItem()
```
