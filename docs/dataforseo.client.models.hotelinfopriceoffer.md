[`< Back`](./)

---

# HotelInfoPriceOffer

Namespace: DataForSeo.Client.Models

featured price offers

```csharp
public class HotelInfoPriceOffer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [HotelInfoPriceOffer](./dataforseo.client.models.hotelinfopriceoffer)

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

url of the price offer
 <br>URL to the page of the website where price offer appears

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MaxVisitors**

the maximal number of visitors
 <br>the maximum number of visitors for which the price offer is valid

```csharp
public Nullable<int> MaxVisitors { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OfferImages**

price offer images
 <br>URLs of the images featured in the price offer

```csharp
public ICollection<string> OfferImages { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **FreeCancellationUntil**

date until free cancellation is available
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>equals null if free cancellation is not available for the selected dates

```csharp
public string FreeCancellationUntil { get; set; }
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

### **HotelInfoPriceOffer()**

```csharp
public HotelInfoPriceOffer()
```

---

[`< Back`](./)
