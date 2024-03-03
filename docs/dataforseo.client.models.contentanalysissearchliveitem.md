# ContentAnalysisSearchLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class ContentAnalysisSearchLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentAnalysisSearchLiveItem](./dataforseo.client.models.contentanalysissearchliveitem.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL where the citation was found

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

domain name

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MainDomain**

main domain

```csharp
public string MainDomain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UrlRank**

rank of the url
 <br>this value is based on backlink data for the given URL from DataForSEO Backlink Index;
 <br>url_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public Nullable<int> UrlRank { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SpamScore**

backlink spam score of the url
 <br>this value is based on backlink data for the given URL from DataForSEO Backlink Index;
 <br>learn more about how the metric is calculated on this help center page

```csharp
public string SpamScore { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DomainRank**

rank of the domain
 <br>this value is based on backlink data for the given domain from DataForSEO Backlink Index;
 <br>domain_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public string DomainRank { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FetchTime**

date and time when our crawler visited the page
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2017-01-24 13:20:59 +00:00

```csharp
public string FetchTime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Country**

country code of the domain registration
 <br>to obtain a full list of available countries, refer to the Locations endpoint

```csharp
public string Country { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Language**

main language of the domain
 <br>to obtain a full list of available languages, refer to the Languages endpoint

```csharp
public string Language { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Score**

citation prominence score
 <br>this value is based on url_rank, domain_rank, keyword presence in title, main_title, url, snippet
 <br>the higher the score, the more value the related citation has

```csharp
public string Score { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageCategory**

contains all relevant page categories
 <br>product and service categories relevant for the page
 <br>to obtain a full list of available categories, refer to the Categories endpoint

```csharp
public ICollection<int> PageCategory { get; set; }
```

#### Property Value

[ICollection&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **PageTypes**

page types

```csharp
public ICollection<string> PageTypes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Ratings**

ratings found on the page
 <br>all ratings found on the page based on microdata

```csharp
public object Ratings { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **SocialMetrics**

social media engagement metrics
 <br>data on social media interactions associated with the content based on website embeds developed and supported by social media platforms

```csharp
public ICollection<SocialMetricsInfo> SocialMetrics { get; set; }
```

#### Property Value

[ICollection&lt;SocialMetricsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **ContentInfo**

contains data on citations from the given url

```csharp
public AnalysisContentInfo ContentInfo { get; set; }
```

#### Property Value

[AnalysisContentInfo](./dataforseo.client.models.analysiscontentinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ContentAnalysisSearchLiveItem()**

```csharp
public ContentAnalysisSearchLiveItem()
```
