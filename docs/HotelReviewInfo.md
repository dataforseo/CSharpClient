# HotelReviewInfo

Namespace: DataForSeo.Client.Models

```csharp
public class HotelReviewInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/Object) → [HotelReviewInfo](./HotelReviewInfo.md)

## Properties

### **Value**

```csharp
public Nullable<float> Value { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]])<br>

### **VotesCount**

```csharp
public Nullable<long> VotesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]])<br>

### **Mentions**

```csharp
public ICollection<ReviewMentionInfo> Mentions { get; set; }
```

#### Property Value

[ICollection&lt;ReviewMentionInfo&gt;](./ReviewMentionInfo.md)<br>

### **RatingDistribution**

```csharp
public IDictionary<string, Nullable<int>> RatingDistribution { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]])<br>

### **OtherSitesReviews**

```csharp
public ICollection<OtherSitesReviewsInfo> OtherSitesReviews { get; set; }
```

#### Property Value

[ICollection&lt;OtherSitesReviewsInfo&gt;](./OtherSitesReviewsInfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]])<br>

## Constructors

### **HotelReviewInfo()**

```csharp
public HotelReviewInfo()
```
