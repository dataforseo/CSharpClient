[`< Back`](./)

---

# MentionCarouselElement

Namespace: DataForSeo.Client.Models

```csharp
public class MentionCarouselElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MentionCarouselElement](./dataforseo.client.models.mentioncarouselelement)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the row

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Price**

price of booking a place for the specified dates of stay

```csharp
public PriceInfo Price { get; set; }
```

#### Property Value

[PriceInfo](./dataforseo.client.models.priceinfo)<br>

### **Rating**

the item’s rating 
 <br>the popularity rate based on reviews and displayed in SERP

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo)<br>

### **MentionedIn**

additional elements in the mention_carousel item

```csharp
public ICollection<LinkElement> MentionedIn { get; set; }
```

#### Property Value

[ICollection&lt;LinkElement&gt;](./dataforseo.client.models.linkelement)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **MentionCarouselElement()**

```csharp
public MentionCarouselElement()
```

---

[`< Back`](./)
