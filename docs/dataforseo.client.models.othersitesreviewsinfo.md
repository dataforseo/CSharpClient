[`< Back`](./)

---

# OtherSitesReviewsInfo

Namespace: DataForSeo.Client.Models

```csharp
public class OtherSitesReviewsInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OtherSitesReviewsInfo](./dataforseo.client.models.othersitesreviewsinfo)

## Properties

### **Title**

review title
 <br>contains a name of the third-party site where review initially appeared

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

review url
 <br>URL to the a third-party site where review initially appeared

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReviewText**

review text
 <br>text of the review

```csharp
public string ReviewText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rating**

rating in the review
 <br>information about the rating enclosed in the review on a third-party site

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OtherSitesReviewsInfo()**

```csharp
public OtherSitesReviewsInfo()
```

---

[`< Back`](./)
