# BusinessDataBusinessListingsSearchLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BusinessDataBusinessListingsSearchLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataBusinessListingsSearchLiveItem](./dataforseo.client.models.businessdatabusinesslistingssearchliveitem.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the element in SERP
 <br>the name of the business entity for which the results are collected

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

description of the element in SERP
 <br>the description of the business entity for which the results are collected

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Category**

business category
 <br>Google My Business general category that best describes the services provided by the business entity

```csharp
public string Category { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CategoryIds**

global category IDs
 <br>universal category IDs that do not change based on the selected country

```csharp
public ICollection<string> CategoryIds { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalCategories**

additional business categories
 <br>additional Google My Business categories that describe the services provided by the business entity in more detail

```csharp
public ICollection<string> AdditionalCategories { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Cid**

google-defined client id
 <br>unique id of a local establishment
 <br>learn more about the identifier in this help center article

```csharp
public string Cid { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FeatureId**

the unique identifier of the element in SERP
 <br>learn more about the identifier in this help center article

```csharp
public string FeatureId { get; set; }
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

### **Url**

absolute url of the business entity

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

domain of the business entity

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Logo**

URL of the logo featured in Google My Business profile

```csharp
public string Logo { get; set; }
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

### **Snippet**

additional information on the business entity

```csharp
public string Snippet { get; set; }
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

### **Attributes**

service details in a form of user-reviewed checks;
 <br>service details of a business entity displayed in a form of checks and based on user feedback and business category

```csharp
public BusinessDataAttributesInfo Attributes { get; set; }
```

#### Property Value

[BusinessDataAttributesInfo](./dataforseo.client.models.businessdataattributesinfo.md)<br>

### **PlaceTopics**

keywords mentioned in customer reviews
 <br>contains most popular keywords related to products/services mentioned in customer reviews of a business entity and the number of reviews mentioning each keyword
 <br>example: 
 <br>"place_topics": {
 <br>"egg roll": 48,
 <br>"birthday": 33
 <br>}

```csharp
public IDictionary<string, Nullable<long>> PlaceTopics { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

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

### **PeopleAlsoSearch**

related business entities

```csharp
public ICollection<PeopleAlsoSearch> PeopleAlsoSearch { get; set; }
```

#### Property Value

[ICollection&lt;PeopleAlsoSearch&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **WorkTime**

work time details
 <br>information related to operational hours of the business entity

```csharp
public WorkInfo WorkTime { get; set; }
```

#### Property Value

[WorkInfo](./dataforseo.client.models.workinfo.md)<br>

### **PopularTimes**

popular times
 <br>information related to busy hours of the business entity

```csharp
public PopularTimes PopularTimes { get; set; }
```

#### Property Value

[PopularTimes](./dataforseo.client.models.populartimes.md)<br>

### **LocalBusinessLinks**

available interactions with the business
 <br>list of options to interact with the business directly from search results

```csharp
public ICollection<BaseLocalBusinessLink> LocalBusinessLinks { get; set; }
```

#### Property Value

[ICollection&lt;BaseLocalBusinessLink&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **ContactInfo**

available contacts of the business
 <br>list of contacts to interact with the business

```csharp
public ICollection<BusinessDataContactInfo> ContactInfo { get; set; }
```

#### Property Value

[ICollection&lt;BusinessDataContactInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **CheckUrl**

direct URL to search engine results
 <br>you can use it to make sure that we provided accurate results

```csharp
public string CheckUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LastUpdatedTime**

date and time when the data was last updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2023-01-26 09:03:15 +00:00

```csharp
public string LastUpdatedTime { get; set; }
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

### **BusinessDataBusinessListingsSearchLiveItem()**

```csharp
public BusinessDataBusinessListingsSearchLiveItem()
```
