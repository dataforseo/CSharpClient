# HotelPriceInfo

Namespace: DataForSeo.Client.Models

```csharp
public class HotelPriceInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [HotelPriceInfo](./dataforseo.client.models.hotelpriceinfo.md)

## Properties

### **Price**

price per night

```csharp
public Nullable<int> Price { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PriceWithoutDiscount**

full price per night without a discount applied

```csharp
public Nullable<long> PriceWithoutDiscount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Currency**

price currency
 <br>USD is applied by default, unless specified in the POST array

```csharp
public string Currency { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DiscountText**

text about a discount applied

```csharp
public string DiscountText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CheckIn**

check-in date and time
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string CheckIn { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CheckOut**

check-out date and time
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string CheckOut { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Visitors**

number of hotel visitors for this price

```csharp
public Nullable<int> Visitors { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

encountered item types
 <br>types of search engine results encountered in the items array;
 <br>possible item types: hotel_search_item

```csharp
public ICollection<HotelPriceItemInfo> Items { get; set; }
```

#### Property Value

[ICollection&lt;HotelPriceItemInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **HotelPriceInfo()**

```csharp
public HotelPriceInfo()
```
