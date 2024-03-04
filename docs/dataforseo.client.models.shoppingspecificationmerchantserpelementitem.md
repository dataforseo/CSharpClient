[`< Back`](./)

---

# ShoppingSpecificationMerchantSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class ShoppingSpecificationMerchantSerpElementItem : BaseMerchantSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseMerchantSerpElementItem](./dataforseo.client.models.basemerchantserpelementitem) → [ShoppingSpecificationMerchantSerpElementItem](./dataforseo.client.models.shoppingspecificationmerchantserpelementitem)

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

absolute rank on the product specification page
 <br>absolute position among all the elements found on the product specification page

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

alignment of the element on the product specification page
 <br>can take the following values:
 <br>right

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

### **BlockName**

name of the block of product attributes
 <br>indicates the name of the product specification section in which the related element is listed

```csharp
public string BlockName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SpecificationName**

product attribute
 <br>attribute name of the product data specification

```csharp
public string SpecificationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SpecificationValue**

content of the specification

```csharp
public string SpecificationValue { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ShoppingSpecificationMerchantSerpElementItem()**

```csharp
public ShoppingSpecificationMerchantSerpElementItem()
```

---

[`< Back`](./)
