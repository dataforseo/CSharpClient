# AmazonAmazonSerpSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class AmazonAmazonSerpSerpElementItem : BaseAmazonSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseAmazonSerpElementItem](./dataforseo.client.models.baseamazonserpelementitem.md) → [AmazonAmazonSerpSerpElementItem](./dataforseo.client.models.amazonamazonserpserpelementitem.md)

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

absolute rank in Amazon SERP
 <br>absolute position among all the elements in SERP

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

the alignment of the element in Amazon SERP
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

### **Domain**

Amazon domain

```csharp
public string Domain { get; set; }
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

### **Url**

URL of the product page

```csharp
public string Url { get; set; }
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

### **Asin**

ASIN of the product
 <br>learn more about ASIN in this help center guide

```csharp
public string Asin { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ImageUrl**

URL of the product image featured in the results

```csharp
public string ImageUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PriceFrom**

the regular price of a product
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

### **SpecialOffers**

special offer details
 <br>contains special offer details, including coupon and Subscribe &amp; Save discounts

```csharp
public ICollection<string> SpecialOffers { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **IsBestSeller**

“Best Seller” label
 <br>if the value is true, the product is marked with the “Best Seller” label

```csharp
public Nullable<bool> IsBestSeller { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsAmazonChoice**

“Amazon’s choice” label
 <br>if the value is true, the product is marked with the “Amazon’s choice” label

```csharp
public Nullable<bool> IsAmazonChoice { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rating**

the item’s rating 
 <br>the popularity rate based on reviews and displayed in SERP

```csharp
public RatingElement Rating { get; set; }
```

#### Property Value

[RatingElement](./dataforseo.client.models.ratingelement.md)<br>

### **DeliveryInfo**

delivery information
 <br>delivery information including free and fast delivery date ranges

```csharp
public AmazonDeliveryInfo DeliveryInfo { get; set; }
```

#### Property Value

[AmazonDeliveryInfo](./dataforseo.client.models.amazondeliveryinfo.md)<br>

### **BoughtPastMonth**

number of product purchases in the past month

```csharp
public Nullable<int> BoughtPastMonth { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DataAsin**

unique product identifier on Amazon
 <br>note that there is no full list of possible values as the data_asin is a dynamic value assigned by Amazon
 <br>example:
 <br>B07G82D89J

```csharp
public string DataAsin { get; set; }
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

### **AmazonAmazonSerpSerpElementItem()**

```csharp
public AmazonAmazonSerpSerpElementItem()
```
