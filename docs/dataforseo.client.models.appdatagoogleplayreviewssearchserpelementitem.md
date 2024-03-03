# AppDataGooglePlayReviewsSearchSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class AppDataGooglePlayReviewsSearchSerpElementItem : BaseAppDataSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseAppDataSerpElementItem](./dataforseo.client.models.baseappdataserpelementitem.md) → [AppDataGooglePlayReviewsSearchSerpElementItem](./dataforseo.client.models.appdatagoogleplayreviewssearchserpelementitem.md)

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

absolute rank among all the listed reviews
 <br>absolute position among all reviews on the list

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

the alignment of the review in SERP
 <br>can take the following values: left

```csharp
public string Position { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Version**

version of the app
 <br>version of the app for which the review is submitted

```csharp
public string Version { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rating**

the rating score submitted by the reviewer

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo.md)<br>

### **Timestamp**

date and time when the review was published
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Timestamp { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Id**

id of the review

```csharp
public string Id { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **HelpfulCount**

number of helpful votes
 <br>indicates how many users considered the review helpful and voted with the thumbs up icon

```csharp
public Nullable<long> HelpfulCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Title**

title of the review
 <br>Google Play doesn’t provide an option to title reviews, so this parameter will always equal null

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReviewText**

content of the review

```csharp
public string ReviewText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UserProfile**

user profile of the reviewer

```csharp
public AppUserProfileInfo UserProfile { get; set; }
```

#### Property Value

[AppUserProfileInfo](./dataforseo.client.models.appuserprofileinfo.md)<br>

### **Responses**

response from the developer

```csharp
public ICollection<ResponseDataInfo> Responses { get; set; }
```

#### Property Value

[ICollection&lt;ResponseDataInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AppDataGooglePlayReviewsSearchSerpElementItem()**

```csharp
public AppDataGooglePlayReviewsSearchSerpElementItem()
```
