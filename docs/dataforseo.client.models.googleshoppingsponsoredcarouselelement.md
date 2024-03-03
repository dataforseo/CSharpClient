# GoogleShoppingSponsoredCarouselElement

Namespace: DataForSeo.Client.Models

```csharp
public class GoogleShoppingSponsoredCarouselElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [GoogleShoppingSponsoredCarouselElement](./dataforseo.client.models.googleshoppingsponsoredcarouselelement.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
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

### **Tags**

tags assigned to the product

```csharp
public ICollection<string> Tags { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Seller**

name of the seller
 <br>the name of the company that placed a corresponding product on Google Shopping

```csharp
public string Seller { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Price**

product price
 <br>example:
 <br>384.99

```csharp
public Nullable<float> Price { get; set; }
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

### **ProductRating**

product rating
 <br>the product popularity rate based on product reviews

```csharp
public RatingElement ProductRating { get; set; }
```

#### Property Value

[RatingElement](./dataforseo.client.models.ratingelement.md)<br>

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

[DeliveryInfo](./dataforseo.client.models.deliveryinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **GoogleShoppingSponsoredCarouselElement()**

```csharp
public GoogleShoppingSponsoredCarouselElement()
```
