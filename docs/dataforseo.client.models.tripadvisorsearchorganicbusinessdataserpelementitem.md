# TripadvisorSearchOrganicBusinessDataSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class TripadvisorSearchOrganicBusinessDataSerpElementItem : BaseBusinessDataSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseBusinessDataSerpElementItem](./dataforseo.client.models.basebusinessdataserpelementitem.md) → [TripadvisorSearchOrganicBusinessDataSerpElementItem](./dataforseo.client.models.tripadvisorsearchorganicbusinessdataserpelementitem.md)

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

absolute rank among all the listed results
 <br>absolute position among all reviews on the list

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Title**

name of the business entity

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UrlPath**

URL path of the business entity
 <br>URL path to the Tripadvisor page of the business entity
 <br>you can use this identifier to collect reviews for the business entity using Tripadvisor Reviews

```csharp
public string UrlPath { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsSponsored**

indicates a sponsored placement
 <br>if true, related tripadvisor_search_organic item is a paid advertising on Tripadvisor

```csharp
public Nullable<bool> IsSponsored { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReviewsCount**

the total number of reviews

```csharp
public Nullable<long> ReviewsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Category**

place category

```csharp
public string Category { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PriceRate**

average price rate

```csharp
public string PriceRate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rating**

the rating score of the establishment submitted by the reviewers

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

### **TripadvisorSearchOrganicBusinessDataSerpElementItem()**

```csharp
public TripadvisorSearchOrganicBusinessDataSerpElementItem()
```
