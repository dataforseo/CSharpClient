# AmazonAmazonReviewItemSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class AmazonAmazonReviewItemSerpElementItem : BaseAmazonSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseAmazonSerpElementItem](./dataforseo.client.models.baseamazonserpelementitem.md) → [AmazonAmazonReviewItemSerpElementItem](./dataforseo.client.models.amazonamazonreviewitemserpelementitem.md)

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

### **Xpath**

the XPath of the element

```csharp
public string Xpath { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Verified**

indicates whether the review has the “Verified Purchase” mark

```csharp
public Nullable<bool> Verified { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Subtitle**

subtitle of the review

```csharp
public string Subtitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **HelpfulVotes**

helpful votes count
 <br>number of users who clicked on the ‘Helpful” button under the review text

```csharp
public Nullable<int> HelpfulVotes { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Images**

images of the product submitted by the reviewer

```csharp
public ICollection<ImagesElement> Images { get; set; }
```

#### Property Value

[ICollection&lt;ImagesElement&gt;](./dataforseo.client.models.imageselement.md)<br>

### **Videos**

videos of the product submitted by the reviewer

```csharp
public ICollection<VideoElement> Videos { get; set; }
```

#### Property Value

[ICollection&lt;VideoElement&gt;](./dataforseo.client.models.videoelement.md)<br>

### **UserProfile**

user profile of the reviewer

```csharp
public UserProfileInfo UserProfile { get; set; }
```

#### Property Value

[UserProfileInfo](./dataforseo.client.models.userprofileinfo.md)<br>

### **Title**

title of the review

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL to the review

```csharp
public string Url { get; set; }
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

### **PublicationDate**

date and time when the review was published
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string PublicationDate { get; set; }
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

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AmazonAmazonReviewItemSerpElementItem()**

```csharp
public AmazonAmazonReviewItemSerpElementItem()
```
