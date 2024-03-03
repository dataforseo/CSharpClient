# HotelPriceItemInfo

Namespace: DataForSeo.Client.Models

```csharp
public class HotelPriceItemInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [HotelPriceItemInfo](./dataforseo.client.models.hotelpriceiteminfo.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the hotel

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Price**

price per night

```csharp
public Nullable<int> Price { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Currency**

price currency
 <br>USD is applied by default, unless specified in the POST array

```csharp
public string Currency { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

third-party page url
 <br>URL to the third-party website page with pricing information

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

third-party domain
 <br>domain of the third-party website page with pricing information

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsPaid**

indicates a paid hotel listing
 <br>if true, related hotel_search_item is a paid ad
 <br>if false, related hotel_search_item is an organic hotel listing

```csharp
public Nullable<bool> IsPaid { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FreeCancellationUntil**

date until which free cancellation is available
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>equals null if free cancellation is not available for the selected dates

```csharp
public string FreeCancellationUntil { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Offers**

featured price offers

```csharp
public ICollection<HotelInfoPriceOffer> Offers { get; set; }
```

#### Property Value

[ICollection&lt;HotelInfoPriceOffer&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **HotelPriceItemInfo()**

```csharp
public HotelPriceItemInfo()
```
