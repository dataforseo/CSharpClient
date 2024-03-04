[`< Back`](./)

---

# GoogleShoppingSponsoredCarouselMerchantSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class GoogleShoppingSponsoredCarouselMerchantSerpElementItem : BaseMerchantSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseMerchantSerpElementItem](./dataforseo.client.models.basemerchantserpelementitem) → [GoogleShoppingSponsoredCarouselMerchantSerpElementItem](./dataforseo.client.models.googleshoppingsponsoredcarouselmerchantserpelementitem)

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
 <br>absolute position among all the elements found in Google Shopping SERP

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

alignment of the element in Google Shopping SERP
 <br>possible values:
 <br>left, right

```csharp
public string Position { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Xpath**

XPath of the element

```csharp
public string Xpath { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

product title

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Items**

items in SERP

```csharp
public ICollection<GoogleShoppingSponsoredCarouselElement> Items { get; set; }
```

#### Property Value

[ICollection&lt;GoogleShoppingSponsoredCarouselElement&gt;](./dataforseo.client.models.googleshoppingsponsoredcarouselelement)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **GoogleShoppingSponsoredCarouselMerchantSerpElementItem()**

```csharp
public GoogleShoppingSponsoredCarouselMerchantSerpElementItem()
```

---

[`< Back`](./)
