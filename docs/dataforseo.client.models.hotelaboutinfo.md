[`< Back`](./)

---

# HotelAboutInfo

Namespace: DataForSeo.Client.Models

```csharp
public class HotelAboutInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [HotelAboutInfo](./dataforseo.client.models.hotelaboutinfo)

## Properties

### **Description**

description of the hotel
 <br>the description of the hotel entity for which the results are collected

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SubDescriptions**

additional description of the hotel
 <br>details about the hotel provided in addition to the description

```csharp
public ICollection<string> SubDescriptions { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **CheckInTime**

hotel check-in time
 <br>check-in time indicated in the hotel listing

```csharp
public WorkTimeInfo CheckInTime { get; set; }
```

#### Property Value

[WorkTimeInfo](./dataforseo.client.models.worktimeinfo)<br>

### **CheckOutTime**

hotel check-out time
 <br>check-out time indicated in the hotel listing

```csharp
public WorkTimeInfo CheckOutTime { get; set; }
```

#### Property Value

[WorkTimeInfo](./dataforseo.client.models.worktimeinfo)<br>

### **FullAddress**

full address of the hotel
 <br>address of the hotel indicated in the standardised format

```csharp
public string FullAddress { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

hotel domain
 <br>domain of the hotel’s website

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

hotel url
 <br>URL to the hotel’s website indicated in the listing

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Amenities**

hotel amenities
 <br>information about hotel amenities

```csharp
public ICollection<HotelAmenityInfo> Amenities { get; set; }
```

#### Property Value

[ICollection&lt;HotelAmenityInfo&gt;](./dataforseo.client.models.hotelamenityinfo)<br>

### **PopularAmenities**

hotel amenities
 <br>information about hotel amenities labelled as “popular”

```csharp
public ICollection<HotelAmenityItemInfo> PopularAmenities { get; set; }
```

#### Property Value

[ICollection&lt;HotelAmenityItemInfo&gt;](./dataforseo.client.models.hotelamenityiteminfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **HotelAboutInfo()**

```csharp
public HotelAboutInfo()
```

---

[`< Back`](./)
