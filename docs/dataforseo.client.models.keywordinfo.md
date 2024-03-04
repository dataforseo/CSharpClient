[`< Back`](./)

---

# KeywordInfo

Namespace: DataForSeo.Client.Models

```csharp
public class KeywordInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordInfo](./dataforseo.client.models.keywordinfo)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

### **Competition**

competition
 <br>represents the relative amount of competition associated with the given keyword. This value is based on Google Ads data and can be between 0 and 1 (inclusive)

```csharp
public Nullable<float> Competition { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CompetitionLevel**

competition level
 <br>represents the relative level of competition associated with the given keyword in paid SERP only;
 <br>possible values: LOW, MEDIUM, HIGH
 <br>if competition level is unknown, the value is null;
 <br>learn more about the metric in this help center article

```csharp
public string CompetitionLevel { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Cpc**

cost-per-click
 <br>represents the average cost per click (USD) historically paid for the keyword

```csharp
public Nullable<float> Cpc { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SearchVolume**

average monthly search volume rate
 <br>represents the (approximate) number of searches for the given keyword idea on google.com

```csharp
public Nullable<long> SearchVolume { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LowTopOfPageBid**

minimum bid for the ad to be displayed at the top of the first page
 <br>indicates the value greater than about 20% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers)
 <br>the value may differ depending on the location specified in a POST request

```csharp
public Nullable<float> LowTopOfPageBid { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **HighTopOfPageBid**

maximum bid for the ad to be displayed at the top of the first page
 <br>indicates the value greater than about 80% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers)
 <br>the value may differ depending on the location specified in a POST request

```csharp
public Nullable<float> HighTopOfPageBid { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Categories**

product and service categories
 <br>you can download the full list of possible categories

```csharp
public ICollection<int> Categories { get; set; }
```

#### Property Value

[ICollection&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **MonthlySearches**

monthly searches
 <br>represents the (approximate) number of searches on this keyword idea (as available for the past twelve months), targeted to the specified geographic locations

```csharp
public ICollection<MonthlySearches> MonthlySearches { get; set; }
```

#### Property Value

[ICollection&lt;MonthlySearches&gt;](./dataforseo.client.models.monthlysearches)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KeywordInfo()**

```csharp
public KeywordInfo()
```

---

[`< Back`](./)
