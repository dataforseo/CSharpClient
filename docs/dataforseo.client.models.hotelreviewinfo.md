# HotelReviewInfo

Namespace: DataForSeo.Client.Models

```csharp
public class HotelReviewInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [HotelReviewInfo](./dataforseo.client.models.hotelreviewinfo.md)

## Properties

### **Value**

overall hotel rating based on customer votes

```csharp
public Nullable<float> Value { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **VotesCount**

number of customer votes
 <br>the number of customer votes included in the calculation of the hotel rating

```csharp
public Nullable<long> VotesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Mentions**

hotel mentions
 <br>information about hotel reviews by criteria

```csharp
public ICollection<ReviewMentionInfo> Mentions { get; set; }
```

#### Property Value

[ICollection&lt;ReviewMentionInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **RatingDistribution**

rating distribution by votes
 <br>the distribution of votes across the rating in the range from 1 to 5

```csharp
public IDictionary<string, Nullable<int>> RatingDistribution { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **OtherSitesReviews**

reviews on third-party sites
 <br>reviews from third-paty sites

```csharp
public ICollection<OtherSitesReviewsInfo> OtherSitesReviews { get; set; }
```

#### Property Value

[ICollection&lt;OtherSitesReviewsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **HotelReviewInfo()**

```csharp
public HotelReviewInfo()
```
