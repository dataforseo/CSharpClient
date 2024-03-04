[`< Back`](./)

---

# KnowledgeGraphHotelsBookingElement

Namespace: DataForSeo.Client.Models

```csharp
public class KnowledgeGraphHotelsBookingElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KnowledgeGraphHotelsBookingElement](./dataforseo.client.models.knowledgegraphhotelsbookingelement)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Source**

source of the element
 <br>indicates the source of information included in the shopping_element

```csharp
public string Source { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

the description of the results element in SERP

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

domain in the URL

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Price**

price indicated in the element

```csharp
public PriceInfo Price { get; set; }
```

#### Property Value

[PriceInfo](./dataforseo.client.models.priceinfo)<br>

### **IsPaid**

indicates whether the element is an ad

```csharp
public Nullable<bool> IsPaid { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KnowledgeGraphHotelsBookingElement()**

```csharp
public KnowledgeGraphHotelsBookingElement()
```

---

[`< Back`](./)
