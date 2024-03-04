[`< Back`](./)

---

# ContentAnalysisRatingInfo

Namespace: DataForSeo.Client.Models

content rating
 <br>rating related to content_info

```csharp
public class ContentAnalysisRatingInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentAnalysisRatingInfo](./dataforseo.client.models.contentanalysisratinginfo)

## Properties

### **Name**

rating name
 <br>here you can find the following elements: Max5, Percents, CustomMax

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RatingValue**

the value of the rating

```csharp
public Nullable<double> RatingValue { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RatingCount**

number of votes

```csharp
public Nullable<long> RatingCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MaxRatingValue**

maximum value for the rating name

```csharp
public string MaxRatingValue { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RelativeRating**

relative rating

```csharp
public Nullable<double> RelativeRating { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ContentAnalysisRatingInfo()**

```csharp
public ContentAnalysisRatingInfo()
```

---

[`< Back`](./)
