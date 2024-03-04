[`< Back`](./)

---

# BusinessDataGoogleHotelSearchesItem

Namespace: DataForSeo.Client.Models

```csharp
public class BusinessDataGoogleHotelSearchesItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataGoogleHotelSearchesItem](./dataforseo.client.models.businessdatagooglehotelsearchesitem)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **HotelIdentifier**

unique identifier of a hotel entity in Google search
 <br>example:
 <br>CgoI-KWyzenM_MV3EAE

```csharp
public string HotelIdentifier { get; set; }
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

### **Stars**

hotel class rating
 <br>class rating that ranges between 1-5 stars

```csharp
public Nullable<int> Stars { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsPaid**

indicates a paid hotel listing
 <br>if true, related hotel_search_item is a paid ad
 <br>if false, related hotel_search_item is an organic hotel listing

```csharp
public Nullable<bool> IsPaid { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Location**

GPS coordinates of the hotel’s location

```csharp
public GpsCoordinatesLocationInfo Location { get; set; }
```

#### Property Value

[GpsCoordinatesLocationInfo](./dataforseo.client.models.gpscoordinateslocationinfo)<br>

### **Reviews**

hotel reviews and rating information

```csharp
public HotelReviewInfo Reviews { get; set; }
```

#### Property Value

[HotelReviewInfo](./dataforseo.client.models.hotelreviewinfo)<br>

### **OverviewImages**

featured images for a hotel

```csharp
public ICollection<string> OverviewImages { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Prices**

hotel price

```csharp
public HotelPriceInfo Prices { get; set; }
```

#### Property Value

[HotelPriceInfo](./dataforseo.client.models.hotelpriceinfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataGoogleHotelSearchesItem()**

```csharp
public BusinessDataGoogleHotelSearchesItem()
```

---

[`< Back`](./)
