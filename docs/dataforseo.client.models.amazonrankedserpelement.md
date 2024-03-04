[`< Back`](./)

---

# AmazonRankedSerpElement

Namespace: DataForSeo.Client.Models

```csharp
public class AmazonRankedSerpElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AmazonRankedSerpElement](./dataforseo.client.models.amazonrankedserpelement)

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
public BaseAmazonSerpElementItem SerpItem { get; set; }
```

#### Property Value

[BaseAmazonSerpElementItem](./dataforseo.client.models.baseamazonserpelementitem)<br>

### **CheckUrl**

direct URL to Amazon results
 <br>you can use it to make sure that we provided accurate results

```csharp
public string CheckUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SerpItemTypes**

direct URL to Amazon results
 <br>contains types of all search results (items) found in the returned SERP;
 <br>possible item types:
 <br>amazon_serp, amazon_paid, editorial_recommendations, top_rated_from_our_brands, related_searches

```csharp
public ICollection<string> SerpItemTypes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **SeResultsCount**

total number of results in Amazon SERP

```csharp
public Nullable<long> SeResultsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LastUpdatedTime**

date and time when SERP data was last updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string LastUpdatedTime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PreviousUpdatedTime**

previous to the most recent update of SERP data
 <br>in the ISO 8601 format: “YYYY-MM-DDThh:mm:ss.sssssssZ”
 <br>example:
 <br>2020-09-12T00:07:43.0733218Z

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

### **AmazonRankedSerpElement()**

```csharp
public AmazonRankedSerpElement()
```

---

[`< Back`](./)
