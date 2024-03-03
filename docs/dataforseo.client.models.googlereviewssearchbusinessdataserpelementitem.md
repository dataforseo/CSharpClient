# GoogleReviewsSearchBusinessDataSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class GoogleReviewsSearchBusinessDataSerpElementItem : BaseBusinessDataSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseBusinessDataSerpElementItem](./dataforseo.client.models.basebusinessdataserpelementitem.md) → [GoogleReviewsSearchBusinessDataSerpElementItem](./dataforseo.client.models.googlereviewssearchbusinessdataserpelementitem.md)

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

the XPath of the review

```csharp
public string Xpath { get; set; }
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

### **OriginalReviewText**

original content of the review
 <br>the original content of the review, no auto-translate applied

```csharp
public string OriginalReviewText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TimeAgo**

the time of publication
 <br>indicates the time (in the ‘time ago’ format) when the review was listed

```csharp
public string TimeAgo { get; set; }
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

### **Rating**

the rating score submitted by the reviewer

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo.md)<br>

### **ReviewsCount**

total number of reviews submitted by the reviewer

```csharp
public Nullable<long> ReviewsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PhotosCount**

total number of photos submitted by the reviewer

```csharp
public Nullable<long> PhotosCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LocalGuide**

indicates whether the reviewer has a ‘local guide’ status

```csharp
public Nullable<bool> LocalGuide { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ProfileName**

profile name of the reviewer

```csharp
public string ProfileName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ProfileUrl**

URL of the reviewer’s profile

```csharp
public string ProfileUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReviewUrl**

the URL of the review

```csharp
public string ReviewUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ProfileImageUrl**

URL of the reviewer’s profile image

```csharp
public string ProfileImageUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **OwnerAnswer**

text of the owner’s response
 <br>the owner’s response to the review

```csharp
public string OwnerAnswer { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **OriginalOwnerAnswer**

original text of the owner’s response
 <br>the original response to the review, no auto-translate applied

```csharp
public string OriginalOwnerAnswer { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **OwnerTimeAgo**

publication time
 <br>indicates the time (in the ‘time ago’ format) when the owner submitted the response to the review

```csharp
public string OwnerTimeAgo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **OwnerTimestamp**

date and time of the owner’s reply to the review
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string OwnerTimestamp { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReviewId**

the unique identifier of a review on Google
 <br>example:
 <br>ChZDSUhNMG9nS0VJQ0FnSUMxbHFyMFlnEAE

```csharp
public string ReviewId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Images**

images submitted by the reviewer

```csharp
public ICollection<ImagesElement> Images { get; set; }
```

#### Property Value

[ICollection&lt;ImagesElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **GoogleReviewsSearchBusinessDataSerpElementItem()**

```csharp
public GoogleReviewsSearchBusinessDataSerpElementItem()
```
