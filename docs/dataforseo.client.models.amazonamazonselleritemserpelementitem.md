# AmazonAmazonSellerItemSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class AmazonAmazonSellerItemSerpElementItem : BaseAmazonSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseAmazonSerpElementItem](./dataforseo.client.models.baseamazonserpelementitem.md) → [AmazonAmazonSellerItemSerpElementItem](./dataforseo.client.models.amazonamazonselleritemserpelementitem.md)

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
 <br>absolute position among all the elements found in Amazon Sellers SERP

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

alignment of the element in SERP
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

### **SellerName**

business name of the seller

```csharp
public string SellerName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SellerUrl**

url forwarding to the seller’s page on Amazon

```csharp
public string SellerUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ShipsFrom**

sender company name

```csharp
public string ShipsFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Price**

product pricing details
 <br>if there are no details, the value will be null

```csharp
public PriceInfo Price { get; set; }
```

#### Property Value

[PriceInfo](./dataforseo.client.models.priceinfo.md)<br>

### **Rating**

seller rating details
 <br>seller popularity rate based on customer reviews

```csharp
public RatingElement Rating { get; set; }
```

#### Property Value

[RatingElement](./dataforseo.client.models.ratingelement.md)<br>

### **Condition**

product condition
 <br>condition of the product offered by the seller

```csharp
public string Condition { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ConditionDescription**

product condition details
 <br>expanded details on the condition of the product offered by the seller

```csharp
public string ConditionDescription { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DeliveryInfo**

delivery information
 <br>delivery information including free and fast delivery date ranges

```csharp
public AmazonDeliveryInfo DeliveryInfo { get; set; }
```

#### Property Value

[AmazonDeliveryInfo](./dataforseo.client.models.amazondeliveryinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AmazonAmazonSellerItemSerpElementItem()**

```csharp
public AmazonAmazonSellerItemSerpElementItem()
```
