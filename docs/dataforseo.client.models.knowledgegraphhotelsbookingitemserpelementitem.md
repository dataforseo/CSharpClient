# KnowledgeGraphHotelsBookingItemSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class KnowledgeGraphHotelsBookingItemSerpElementItem : BaseSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseSerpElementItem](./dataforseo.client.models.baseserpelementitem.md) → [KnowledgeGraphHotelsBookingItemSerpElementItem](./dataforseo.client.models.knowledgegraphhotelsbookingitemserpelementitem.md)

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

title of a given link element

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateFrom**

starting date of stay
 <br>in the format “year-month-date”
 <br>example:
 <br>2019-11-15

```csharp
public string DateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateTo**

ending date of stay
 <br>in the format “year-month-date”
 <br>example:
 <br>2019-11-17

```csharp
public string DateTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DataAttrid**

google defined data attribute ID
 <br>example:
 <br>kc:/local:hotel booking

```csharp
public string DataAttrid { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Items**

contains results featured in the ‘hotels_pack’ element of SERP

```csharp
public ICollection<KnowledgeGraphHotelsBookingElement> Items { get; set; }
```

#### Property Value

[ICollection&lt;KnowledgeGraphHotelsBookingElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

### **KnowledgeGraphHotelsBookingItemSerpElementItem()**

```csharp
public KnowledgeGraphHotelsBookingItemSerpElementItem()
```