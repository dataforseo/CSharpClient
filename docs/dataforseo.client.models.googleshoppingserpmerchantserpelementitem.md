[`< Back`](./)

---

# GoogleShoppingSerpMerchantSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class GoogleShoppingSerpMerchantSerpElementItem : BaseMerchantSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseMerchantSerpElementItem](./dataforseo.client.models.basemerchantserpelementitem) → [GoogleShoppingSerpMerchantSerpElementItem](./dataforseo.client.models.googleshoppingserpmerchantserpelementitem)

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

alignment of the element in SERP
 <br>can take the following values:
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

### **Domain**

domain in SERP

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the element

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

description of the product in Google Shopping SERP

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL to the product page on the seller’s website

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ShoppingUrl**

URL to the product page on Google Shopping

```csharp
public string ShoppingUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Tags**

tags assigned to the product

```csharp
public ICollection<string> Tags { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Price**

product price
 <br>example:
 <br>384.99

```csharp
public Nullable<float> Price { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OldPrice**

product old price
 <br>displayed if the product price has been changed
 <br>example:
 <br>499

```csharp
public Nullable<float> OldPrice { get; set; }
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

### **ProductId**

unique product identifier on Google Shopping
 <br>note that there is no full list of possible values as the product_id is a dynamic value assigned by Google
 <br>if there are no values, you will get null
 <br>example:
 <br>4485466949985702538
 <br>learn more about the parameter in this help center guide

```csharp
public string ProductId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DataDocid**

unique identifier of the SERP data element
 <br>note that there is no full list of possible values as the data_docid is a dynamic value assigned by Google
 <br>example:
 <br>17363035694596624076

```csharp
public string DataDocid { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Seller**

name of the seller
 <br>the name of the company that placed a corresponding product on Google Shopping

```csharp
public string Seller { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalSpecifications**

object containing additional url parameters
 <br>you can get more details about the product by using this object in the POST request to the Google Shopping Product Specification and Google Shopping Sellers endpoint

```csharp
public IDictionary<string, string> AdditionalSpecifications { get; set; }
```

#### Property Value

[IDictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ReviewsCount**

number of product reviews
 <br>indicates the number of reviews left by users on Google Shopping
 <br>if there are no values, you will get null

```csharp
public Nullable<long> ReviewsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsBestMatch**

“best match” label
 <br>if the value is true, the product is marked with the “best match” label
 <br>if there are no values, you will get null

```csharp
public Nullable<bool> IsBestMatch { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ProductRating**

product rating
 <br>the product popularity rate based on product reviews

```csharp
public RatingElement ProductRating { get; set; }
```

#### Property Value

[RatingElement](./dataforseo.client.models.ratingelement)<br>

### **ShopRating**

shop rating
 <br>the popularity rate of the seller based on user reviews

```csharp
public RatingElement ShopRating { get; set; }
```

#### Property Value

[RatingElement](./dataforseo.client.models.ratingelement)<br>

### **ProductImages**

URLs to the images of the product
 <br>the first URL in the array is the featured image of the product

```csharp
public ICollection<string> ProductImages { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **ShopAdAclk**

unique ad click referral parameter
 <br>using this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL

```csharp
public string ShopAdAclk { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DeliveryInfo**

delivery information
 <br>delivery information including free and fast delivery date ranges

```csharp
public DeliveryInfo DeliveryInfo { get; set; }
```

#### Property Value

[DeliveryInfo](./dataforseo.client.models.deliveryinfo)<br>

### **StoresCountInfo**

stores count information
 <br>contains information about the number of stores that offer the same product

```csharp
public StoresCountInfo StoresCountInfo { get; set; }
```

#### Property Value

[StoresCountInfo](./dataforseo.client.models.storescountinfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **GoogleShoppingSerpMerchantSerpElementItem()**

```csharp
public GoogleShoppingSerpMerchantSerpElementItem()
```

---

[`< Back`](./)
