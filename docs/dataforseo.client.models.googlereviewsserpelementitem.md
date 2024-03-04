# GoogleReviewsSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class GoogleReviewsSerpElementItem : BaseSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseSerpElementItem](./dataforseo.client.models.baseserpelementitem.md) → [GoogleReviewsSerpElementItem](./dataforseo.client.models.googlereviewsserpelementitem.md)

## Properties

### **RankGroup**

group rank in SERP
 <br>position within a group of elements with identical type values
 <br>positions of elements with different type values are omitted from rank_group

```csharp
public Nullable<int> RankGroup { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RankAbsolute**

absolute rank in SERP
 <br>absolute position among all the elements in SERP

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

the alignment of the element in SERP
 <br>can take the following values:
 <br>left, right

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

### **ReviewsCount**

the number of reviews

```csharp
public Nullable<long> ReviewsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rating**

the item’s rating 
 <br>the popularity rate based on reviews and displayed in SERP

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo.md)<br>

### **PlaceId**

the identifier of a place

```csharp
public string PlaceId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Feature**

the additional feature of the review

```csharp
public string Feature { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Cid**

google-defined client id

```csharp
public string Cid { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rectangle**

rectangle parameters
 <br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP
 <br>equals null if calculate_rectangles in the POST request is not set to true

```csharp
public Rectangle Rectangle { get; set; }
```

#### Property Value

[Rectangle](./dataforseo.client.models.rectangle.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **GoogleReviewsSerpElementItem()**

```csharp
public GoogleReviewsSerpElementItem()
```
