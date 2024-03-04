[`< Back`](./)

---

# ProductSeller

Namespace: DataForSeo.Client.Models

```csharp
public class ProductSeller
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ProductSeller](./dataforseo.client.models.productseller)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
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

seller url
 <br>url of the page where the product is sold

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SellerRating**

rating of the seller

```csharp
public RatingElement SellerRating { get; set; }
```

#### Property Value

[RatingElement](./dataforseo.client.models.ratingelement)<br>

### **SellerReviewCount**

number of seller reviews
 <br>number of reviews on the product seller’s account

```csharp
public Nullable<int> SellerReviewCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Price**

product price
 <br>product price details on the seller’s website

```csharp
public PriceInfo Price { get; set; }
```

#### Property Value

[PriceInfo](./dataforseo.client.models.priceinfo)<br>

### **DeliveryInfo**

delivery information
 <br>product delivery information

```csharp
public DeliveryInfo DeliveryInfo { get; set; }
```

#### Property Value

[DeliveryInfo](./dataforseo.client.models.deliveryinfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ProductSeller()**

```csharp
public ProductSeller()
```

---

[`< Back`](./)
