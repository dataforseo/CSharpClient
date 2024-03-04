# MapsSearchSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class MapsSearchSerpElementItem : BaseSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseSerpElementItem](./dataforseo.client.models.baseserpelementitem.md) → [MapsSearchSerpElementItem](./dataforseo.client.models.mapssearchserpelementitem.md)

## Properties

### **RankGroup**

group rank in SERP
 <br>position within a group of elements with identical type values
 <br>positions of elements with different type values are omitted from rank_group

```csharp
public Nullable<int> RankGroup { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RankAbsolute**

absolute rank in SERP
 <br>absolute position among all the elements in SERP

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Domain**

domain in the SERP element

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the result in SERP

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

relevant URL in SERP

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ContactUrl**

URL of the preferred contact page

```csharp
public string ContactUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rating**

the element’s rating 
 <br>the popularity rate based on reviews and displayed in SERP

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo.md)<br>

### **HotelRating**

hotel class rating
 <br>class ratings range between 1-5 stars, learn more
 <br>if there is no hotel class rating information, the value will be null

```csharp
public Nullable<int> HotelRating { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PriceLevel**

property price level
 <br>can take values: inexpensive, moderate, expensive, very_expensive
 <br>if there is no price level information, the value will be null

```csharp
public string PriceLevel { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RatingDistribution**

the distribution of ratings of the business entity
 <br>the object displays the number of 1-star to 5-star ratings, as reviewed by users

```csharp
public IDictionary<string, Nullable<int>> RatingDistribution { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **Snippet**

element snippet
 <br>contains the address and other information about the local establishment featured in the element

```csharp
public string Snippet { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Address**

address line
 <br>address of the local establishment featured in the element

```csharp
public string Address { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AddressInfo**

object containing address components of the local establishment

```csharp
public AddressInfo AddressInfo { get; set; }
```

#### Property Value

[AddressInfo](./dataforseo.client.models.addressinfo.md)<br>

### **PlaceId**

unique place identifier
 <br>place id of the local establishment featured in the element

```csharp
public string PlaceId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Phone**

phone number
 <br>phone number of the local establishment featured in the element

```csharp
public string Phone { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MainImage**

URL of the main image featured in Google My Business profile

```csharp
public string MainImage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TotalPhotos**

total count of images featured in Google My Business profile

```csharp
public Nullable<long> TotalPhotos { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Category**

business category
 <br>Google My Business general category that best describes the services provided by the business entity

```csharp
public string Category { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalCategories**

additional business categories
 <br>additional Google My Business categories that describe the services provided by the business entity in more detail

```csharp
public ICollection<string> AdditionalCategories { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **CategoryIds**

global category IDs
 <br>universal category IDs that do not change based on the selected country

```csharp
public ICollection<string> CategoryIds { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **WorkHours**

open hours
 <br>information about work hours of the local establishment

```csharp
public WorkHours WorkHours { get; set; }
```

#### Property Value

[WorkHours](./dataforseo.client.models.workhours.md)<br>

### **FeatureId**

the unique identifier of the element in SERP

```csharp
public string FeatureId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Cid**

google-defined client id
 <br>unique id of a local establishment;
 <br>can be used with Google Reviews API to get a full list of reviews

```csharp
public string Cid { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Latitude**

latitude coordinate of the local establishments in google maps
 <br>example:
 <br>"latitude": 51.584091

```csharp
public Nullable<float> Latitude { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Longitude**

longitude coordinate of the local establishment in google maps
 <br>example:
 <br>"longitude": -0.31365919999999997

```csharp
public Nullable<float> Longitude { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsClaimed**

indicates whether ownership of this local establishment is claimed

```csharp
public Nullable<bool> IsClaimed { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LocalJustifications**

Google local justifications
 <br>snippets of text that “justify” why the business is showing up for search query

```csharp
public ICollection<LocalJustificationInfo> LocalJustifications { get; set; }
```

#### Property Value

[ICollection&lt;LocalJustificationInfo&gt;](./dataforseo.client.models.localjustificationinfo.md)<br>

### **IsDirectoryItem**

indicates whether this local establishment is a directory

```csharp
public Nullable<bool> IsDirectoryItem { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **MapsSearchSerpElementItem()**

```csharp
public MapsSearchSerpElementItem()
```
