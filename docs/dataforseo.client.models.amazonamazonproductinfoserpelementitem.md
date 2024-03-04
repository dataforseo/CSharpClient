# AmazonAmazonProductInfoSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class AmazonAmazonProductInfoSerpElementItem : BaseAmazonSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseAmazonSerpElementItem](./dataforseo.client.models.baseamazonserpelementitem.md) → [AmazonAmazonProductInfoSerpElementItem](./dataforseo.client.models.amazonamazonproductinfoserpelementitem.md)

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

absolute rank
 <br>absolute position among all the elements in the response array

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

### **Title**

product title

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Details**

product specs and other details

```csharp
public string Details { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ImageUrl**

the URL of the product image

```csharp
public string ImageUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Author**

product brand name

```csharp
public string Author { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DataAsin**

ASIN of the product received in a POST array

```csharp
public string DataAsin { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ParentAsin**

parent ASIN of the product

```csharp
public string ParentAsin { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ProductAsins**

ASINs of all found product modifications

```csharp
public ICollection<string> ProductAsins { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **PriceFrom**

the lower limit of the product price range
 <br>example:
 <br>49.98

```csharp
public Nullable<float> PriceFrom { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PriceTo**

the upper limit of the product price range
 <br>example:
 <br>384.99

```csharp
public Nullable<float> PriceTo { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Currency**

currency in the ISO format
 <br>example:
 <br>USD

```csharp
public string Currency { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsAmazonChoice**

“Amazon’s choice” label
 <br>if the value is true, the product is marked with the “Amazon’s choice” label

```csharp
public Nullable<bool> IsAmazonChoice { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rating**

product rating info

```csharp
public RatingElement Rating { get; set; }
```

#### Property Value

[RatingElement](./dataforseo.client.models.ratingelement.md)<br>

### **IsNewerModelAvailable**

indicates whether the newer model of the product is available

```csharp
public Nullable<bool> IsNewerModelAvailable { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **NewerModel**

information about the newer model of the product

```csharp
public AmazonProductNewerModelInfo NewerModel { get; set; }
```

#### Property Value

[AmazonProductNewerModelInfo](./dataforseo.client.models.amazonproductnewermodelinfo.md)<br>

### **Categories**

contains related product categories

```csharp
public ICollection<ProductCategoryInfo> Categories { get; set; }
```

#### Property Value

[ICollection&lt;ProductCategoryInfo&gt;](./dataforseo.client.models.productcategoryinfo.md)<br>

### **ProductInformation**

contains related product information

```csharp
public ICollection<BaseProductInformationItem> ProductInformation { get; set; }
```

#### Property Value

[ICollection&lt;BaseProductInformationItem&gt;](./dataforseo.client.models.baseproductinformationitem.md)<br>

### **ProductImagesList**

contains URLs for all images of the product displayed on the left side of the main image

```csharp
public ICollection<string> ProductImagesList { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **ProductVideosList**

contains URLs for all videos of the product displayed on the right side of the main video

```csharp
public ICollection<string> ProductVideosList { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Description**

contains description of the product

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsAvailable**

indicates whether the product is available for ordering
 <br>if the value is true, the product can be ordered

```csharp
public Nullable<bool> IsAvailable { get; set; }
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

### **AmazonAmazonProductInfoSerpElementItem()**

```csharp
public AmazonAmazonProductInfoSerpElementItem()
```
