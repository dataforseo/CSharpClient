[`< Back`](./)

---

# ProductInfoElementMerchantSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class ProductInfoElementMerchantSerpElementItem : BaseMerchantSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseMerchantSerpElementItem](./dataforseo.client.models.basemerchantserpelementitem) → [ProductInfoElementMerchantSerpElementItem](./dataforseo.client.models.productinfoelementmerchantserpelementitem)

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
 <br>right, left

```csharp
public string Position { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ProductId**

product_id received in a POST array
 <br>ilearn more about the parameter in this help center guide

```csharp
public string ProductId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the product

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

description of the product

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

product url
 <br>url of the product on Google Shopping

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Images**

product images
 <br>contains urls to product images

```csharp
public ICollection<string> Images { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Features**

product features
 <br>contains snippets with the description of product features

```csharp
public ICollection<string> Features { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Rating**

product rating 
 <br>the popularity rate based on reviews

```csharp
public RatingElement Rating { get; set; }
```

#### Property Value

[RatingElement](./dataforseo.client.models.ratingelement)<br>

### **SellerReviewsCount**

number of seller reviews
 <br>number of reviews on the product seller’s account

```csharp
public Nullable<long> SellerReviewsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Sellers**

sellers of the product
 <br>number of reviews on the product seller’s account

```csharp
public ICollection<ProductSeller> Sellers { get; set; }
```

#### Property Value

[ICollection&lt;ProductSeller&gt;](./dataforseo.client.models.productseller)<br>

### **Variations**

variations of the product
 <br>contains brief information about different product variations

```csharp
public ICollection<ProductVariation> Variations { get; set; }
```

#### Property Value

[ICollection&lt;ProductVariation&gt;](./dataforseo.client.models.productvariation)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ProductInfoElementMerchantSerpElementItem()**

```csharp
public ProductInfoElementMerchantSerpElementItem()
```

---

[`< Back`](./)
