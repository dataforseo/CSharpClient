[`< Back`](./)

---

# BusinessDataGoogleHotelInfoLiveAdvancedResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BusinessDataGoogleHotelInfoLiveAdvancedResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataGoogleHotelInfoLiveAdvancedResultInfo](./dataforseo.client.models.responses.businessdatagooglehotelinfoliveadvancedresultinfo)

## Properties

### **HotelIdentifier**

identifier received in a POST array
 <br>this field will contain the hotel_identifier parameter specified when setting a task;
 <br>example:
 <br>CgoI-KWyzenM_MV3EAE

```csharp
public string HotelIdentifier { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code in a POST array

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageCode**

language code in a POST array

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CheckUrl**

direct URL to search engine results
 <br>you can use it to make sure that we provided accurate results

```csharp
public string CheckUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Datetime**

date and time when the result was received
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Datetime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

hotel title
 <br>the title of the hotel entity for which the results are collected

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Stars**

hotel class rating
 <br>class rating that ranges between 1-5 stars and displayed after review ratings in hotel summary

```csharp
public Nullable<int> Stars { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **StarsDescription**

hotel class rating
 <br>class rating that ranges between 1-5 stars and displayed after review ratings in the hotel summary

```csharp
public string StarsDescription { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Address**

hotel address
 <br>physical address of the hotel

```csharp
public string Address { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Phone**

hotel phone number
 <br>contact phone number of the hotel

```csharp
public string Phone { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **About**

information about the hotel

```csharp
public HotelAboutInfo About { get; set; }
```

#### Property Value

[HotelAboutInfo](./dataforseo.client.models.hotelaboutinfo)<br>

### **Location**

information about the hotel location
 <br>information about the location where the hotel is located

```csharp
public Location Location { get; set; }
```

#### Property Value

[Location](./dataforseo.client.models.location)<br>

### **Reviews**

hotel reviews by criteria
 <br>information about reviews of the hotel entity

```csharp
public HotelReviewInfo Reviews { get; set; }
```

#### Property Value

[HotelReviewInfo](./dataforseo.client.models.hotelreviewinfo)<br>

### **OverviewImages**

images displayed in the hotel overview
 <br>array containing URLs to images displayed in the hotel overview

```csharp
public ICollection<string> OverviewImages { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Prices**

pricing details of the hotel entity
 <br>contains information about the hotel’s prices

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

### **BusinessDataGoogleHotelInfoLiveAdvancedResultInfo()**

```csharp
public BusinessDataGoogleHotelInfoLiveAdvancedResultInfo()
```

---

[`< Back`](./)
