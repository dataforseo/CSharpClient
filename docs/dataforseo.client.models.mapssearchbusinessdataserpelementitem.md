# MapsSearchBusinessDataSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class MapsSearchBusinessDataSerpElementItem : BaseBusinessDataSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseBusinessDataSerpElementItem](./dataforseo.client.models.basebusinessdataserpelementitem.md) → [MapsSearchBusinessDataSerpElementItem](./dataforseo.client.models.mapssearchbusinessdataserpelementitem.md)

## Properties

### **RankGroup**

position within a group of elements with identical type values
 <br>positions of elements with different type values are omitted from the rank_group

```csharp
public Nullable<int> RankGroup { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RankAbsolute**

absolute rank among all the elements

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Domain**

domain of the business entity

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

directory title
 <br>can take the following values: At this place, Directory

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL to view the menu

```csharp
public string Url { get; set; }
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

### **RatingDistribution**

the distribution of ratings of the business entity
 <br>the object displays the number of 1-star to 5-star ratings, as reviewed by users

```csharp
public IDictionary<string, Nullable<int>> RatingDistribution { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **Snippet**

additional information about the business entity

```csharp
public string Snippet { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Address**

address of the business entity

```csharp
public string Address { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AddressInfo**

object containing address components of the business entity

```csharp
public AddressInfo AddressInfo { get; set; }
```

#### Property Value

[AddressInfo](./dataforseo.client.models.addressinfo.md)<br>

### **PlaceId**

unique place identifier
 <br>place id of the local establishment featured in the element
 <br>learn more about the identifier in this help center article

```csharp
public string PlaceId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Phone**

phone number of the business entity

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

### **PriceLevel**

property price level
 <br>can take values: inexpensive, moderate, expensive, very_expensive
 <br>if there is no price level information, the value will be null

```csharp
public string PriceLevel { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **HotelRating**

hotel class rating
 <br>class ratings range between 1-5 stars, learn more
 <br>if there is no hotel class rating information, the value will be null

```csharp
public Nullable<int> HotelRating { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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
public WorkInfo WorkHours { get; set; }
```

#### Property Value

[WorkInfo](./dataforseo.client.models.workinfo.md)<br>

### **FeatureId**

the unique identifier of the element in SERP
 <br>learn more about the identifier in this help center article

```csharp
public string FeatureId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Cid**

google-defined client id
 <br>unique id of a local establishment;
 <br>can be used with Google Reviews API to get a full list of reviews
 <br>learn more about the identifier in this help center article

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

shows whether the entity is verified by its owner on Google Maps

```csharp
public Nullable<bool> IsClaimed { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LocalJustifications**

Google local justifications
 <br>snippets of text that “justify” why the business is showing up for search query

```csharp
public ICollection<string> LocalJustifications { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **IsDirectoryItem**

business establishment is a part of the directory
 <br>indicates whether the business establishment is a part of the directory;
 <br>if true, the item is a part of the larger directory of businesses with the same address (e.g., a mall or a business centre);
 <br>note: if the business establishment is a parent item in the directory, the value will be null

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

### **MapsSearchBusinessDataSerpElementItem()**

```csharp
public MapsSearchBusinessDataSerpElementItem()
```
