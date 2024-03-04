# BusinessDataTripadvisorReviewsTaskGetResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BusinessDataTripadvisorReviewsTaskGetResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataTripadvisorReviewsTaskGetResultInfo](./dataforseo.client.models.responses.businessdatatripadvisorreviewstaskgetresultinfo.md)

## Properties

### **UrlPath**

URL path received in a POST array

```csharp
public string UrlPath { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeDomain**

search engine domain in a POST array

```csharp
public string SeDomain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CheckUrl**

direct URL to search engine results
 <br>you can use it to make sure that we provided accurate results

```csharp
public string CheckUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Datetime**

date and time when the result was received
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Datetime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the ‘reviews’ element in SERP
 <br>the name of the local establishment for which the reviews are collected

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Location**

location of the local establishment
 <br>address of the local establishment for which the reviews are collected

```csharp
public string Location { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReviewsCount**

the total number of reviews

```csharp
public Nullable<long> ReviewsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rating**

rating of the corresponding local establishment
 <br>popularity rate based on reviews and displayed in SERP

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo.md)<br>

### **ItemsCount**

the number of reviews items in the results array
 <br>you can get more results by using the depth parameter when setting a task

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

found reviews
 <br>you can get more results by using the depth parameter when setting a task

```csharp
public ICollection<BaseBusinessDataSerpElementItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BaseBusinessDataSerpElementItem&gt;](./dataforseo.client.models.basebusinessdataserpelementitem.md)<br>

### **LanguageCode**

language code in a POST array

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataTripadvisorReviewsTaskGetResultInfo()**

```csharp
public BusinessDataTripadvisorReviewsTaskGetResultInfo()
```
