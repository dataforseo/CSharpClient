[`< Back`](./)

---

# YelpReviewsSearchBusinessDataSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class YelpReviewsSearchBusinessDataSerpElementItem : BaseBusinessDataSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseBusinessDataSerpElementItem](./dataforseo.client.models.basebusinessdataserpelementitem) → [YelpReviewsSearchBusinessDataSerpElementItem](./dataforseo.client.models.yelpreviewssearchbusinessdataserpelementitem)

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

### **ReviewId**

the unique identifier of a review received from Yelp
 <br>example:
 <br>WvjNtncj8PDZytbofWlC5A

```csharp
public string ReviewId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rating**

the rating score submitted by the reviewer

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo)<br>

### **Timestamp**

the time of publication
 <br>indicates timestamp of when the review was listed

```csharp
public string Timestamp { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReviewText**

the content of the review

```csharp
public string ReviewText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReviewImages**

images submitted by the reviewer
 <br>you will find URLs to the images provided by the author of this review

```csharp
public ICollection<string> ReviewImages { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **UserProfile**

information listed in the reviewer’s profile

```csharp
public BusinessDataUserProfileInfo UserProfile { get; set; }
```

#### Property Value

[BusinessDataUserProfileInfo](./dataforseo.client.models.businessdatauserprofileinfo)<br>

### **Responses**

text of the owner’s response

```csharp
public ICollection<ReviewResponseItemInfo> Responses { get; set; }
```

#### Property Value

[ICollection&lt;ReviewResponseItemInfo&gt;](./dataforseo.client.models.reviewresponseiteminfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **YelpReviewsSearchBusinessDataSerpElementItem()**

```csharp
public YelpReviewsSearchBusinessDataSerpElementItem()
```

---

[`< Back`](./)
