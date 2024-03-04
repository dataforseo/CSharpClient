[`< Back`](./)

---

# TripadvisorReviewSearchBusinessDataSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class TripadvisorReviewSearchBusinessDataSerpElementItem : BaseBusinessDataSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseBusinessDataSerpElementItem](./dataforseo.client.models.basebusinessdataserpelementitem) → [TripadvisorReviewSearchBusinessDataSerpElementItem](./dataforseo.client.models.tripadvisorreviewsearchbusinessdataserpelementitem)

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

URL of the review

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

### **DateOfVisit**

date of the reviewer’s visit to the local establishment
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string DateOfVisit { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Timestamp**

date and time when the review was published
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Timestamp { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the review

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

### **ReviewImages**

contains URLs of the images used in the review

```csharp
public ICollection<ImageUrlInfo> ReviewImages { get; set; }
```

#### Property Value

[ICollection&lt;ImageUrlInfo&gt;](./dataforseo.client.models.imageurlinfo)<br>

### **UserProfile**

information from the reviewer’s profile

```csharp
public BusinessDataUserProfileInfo UserProfile { get; set; }
```

#### Property Value

[BusinessDataUserProfileInfo](./dataforseo.client.models.businessdatauserprofileinfo)<br>

### **Responses**

contains information about the owner’s response

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

### **TripadvisorReviewSearchBusinessDataSerpElementItem()**

```csharp
public TripadvisorReviewSearchBusinessDataSerpElementItem()
```

---

[`< Back`](./)
