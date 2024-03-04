[`< Back`](./)

---

# TrustpilotReviewSearchBusinessDataSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class TrustpilotReviewSearchBusinessDataSerpElementItem : BaseBusinessDataSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseBusinessDataSerpElementItem](./dataforseo.client.models.basebusinessdataserpelementitem) → [TrustpilotReviewSearchBusinessDataSerpElementItem](./dataforseo.client.models.trustpilotreviewsearchbusinessdataserpelementitem)

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
 <br>can take the following values: right

```csharp
public string Position { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

the URL of the review

```csharp
public string Url { get; set; }
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

### **Verified**

indicates whether the review has the “Verified” mark

```csharp
public Nullable<bool> Verified { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Language**

the language of the review

```csharp
public string Language { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Timestamp**

date and time when a review was published
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Timestamp { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

the title of the review

```csharp
public string Title { get; set; }
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
 <br>displays URLs to the images provided by the author of the review;
 <br>please note that Trustpilot doesn’t allow adding images to reviews, so the review_images parameter will always equal null

```csharp
public ICollection<string> ReviewImages { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **UserProfile**

user profile of the reviewer

```csharp
public BusinessDataUserProfileInfo UserProfile { get; set; }
```

#### Property Value

[BusinessDataUserProfileInfo](./dataforseo.client.models.businessdatauserprofileinfo)<br>

### **Responses**

owner’s response to the submitted review

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

### **TrustpilotReviewSearchBusinessDataSerpElementItem()**

```csharp
public TrustpilotReviewSearchBusinessDataSerpElementItem()
```

---

[`< Back`](./)
