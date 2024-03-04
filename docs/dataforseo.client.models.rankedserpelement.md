# RankedSerpElement

Namespace: DataForSeo.Client.Models

```csharp
public class RankedSerpElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RankedSerpElement](./dataforseo.client.models.rankedserpelement.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SerpItem**

contains data on the SERP element
 <br>the list of supported SERP elements can be found below

```csharp
public BaseDataforseoLabsSerpElementItem SerpItem { get; set; }
```

#### Property Value

[BaseDataforseoLabsSerpElementItem](./dataforseo.client.models.basedataforseolabsserpelementitem.md)<br>

### **CheckUrl**

direct URL to search engine results
 <br>you can use it to make sure that we provided accurate results

```csharp
public string CheckUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SerpItemTypes**

types of search results in SERP
 <br>contains types of search results (items) found in SERP
 <br>possible item types:
 <br>answer_box, app, carousel, multi_carousel, featured_snippet, google_flights, google_reviews, images, jobs, knowledge_graph, local_pack, map, organic, paid, people_also_ask, related_searches, people_also_search, shopping, top_stories, twitter, video, events, mention_carousel, recipes, top_sights, scholarly_articles, popular_products, podcasts, questions_and_answers, find_results_on, stocks_box;
 <br>note that the actual results will be returned only for organic, paid, featured_snippet, and local_pack elements

```csharp
public ICollection<string> SerpItemTypes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **SeResultsCount**

number of search results for the returned keyword

```csharp
public string SeResultsCount { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **KeywordDifficulty**

difficulty of ranking in the first top-10 organic results for a keyword
 <br>indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100;
 <br>calculated by analysing, among other parameters, link profiles of the first 10 pages in SERP;
 <br>learn more about the metric in this help center guide

```csharp
public Nullable<int> KeywordDifficulty { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsLost**

lost ranked elements
 <br>indicates how many ranked elements of this domain were previously presented in SERPs, but weren’t found during the last check

```csharp
public Nullable<bool> IsLost { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LastUpdatedTime**

date and time when keyword data was updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string LastUpdatedTime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PreviousUpdatedTime**

previous to the most recent date and time when SERP data was updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-10-15 12:57:46 +00:00

```csharp
public string PreviousUpdatedTime { get; set; }
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

### **RankedSerpElement()**

```csharp
public RankedSerpElement()
```
