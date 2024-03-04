# AmazonRelatedSearchesSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class AmazonRelatedSearchesSerpElementItem : BaseAmazonSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseAmazonSerpElementItem](./dataforseo.client.models.baseamazonserpelementitem.md) → [AmazonRelatedSearchesSerpElementItem](./dataforseo.client.models.amazonrelatedsearchesserpelementitem.md)

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
 <br>absolute position among all the elements found in Amazon SERP

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

the alignment of the element in Amazon SERP
 <br>possible values:
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

### **Items**

Amazon product items

```csharp
public ICollection<RelatedSearchesElement> Items { get; set; }
```

#### Property Value

[ICollection&lt;RelatedSearchesElement&gt;](./dataforseo.client.models.relatedsearcheselement.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AmazonRelatedSearchesSerpElementItem()**

```csharp
public AmazonRelatedSearchesSerpElementItem()
```
