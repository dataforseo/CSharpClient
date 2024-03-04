# KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResultInfo](./dataforseo.client.models.responses.keywordsdatagoogleadskeywordsforkeywordstaskgetresultinfo.md)

## Properties

### **Keyword**

keyword in a POST array

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code in a POST array
 <br>if there is no data, the value is null

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageCode**

language code in a POST array
 <br>if there is no data, the value is null

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SearchPartners**

include Google search partners
 <br>the value you specified when setting the task
 <br>if true, the results are returned for owned, operated, and syndicated networks across Google and partner sites that host Google search;
 <br>if false, the results are returned for Google search sites only

```csharp
public Nullable<bool> SearchPartners { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Competition**

competition
 <br>represents the relative level of competition associated with the given keyword in paid SERP only
 <br>possible values: LOW, MEDIUM, HIGH
 <br>if competition level is unknown, the value is null;
 <br>learn more about the metric in this help center article

```csharp
public string Competition { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CompetitionIndex**

competition index
 <br>the competition index for the query indicating how competitive ad placement is for the keyword
 <br>can take values from 0 to 100
 <br>the level of competition from 0 to 100 is determined by the number of ad slots filled divided by the total number of ad slots available
 <br>if not enough data is available, the value is null;
 <br>learn more about the metric in this help center article

```csharp
public Nullable<int> CompetitionIndex { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SearchVolume**

monthly average search volume rate
 <br>represents the (approximate) number of searches for the given keyword idea either on google.com or google.com and partners, depending on the user’s targeting
 <br>if there is no data, the value is null

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

### **Cpc**

cost per click
 <br>indicates the amount paid for each click on the ad displayed for a given keyword

```csharp
public Nullable<float> Cpc { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MonthlySearches**

monthly searches
 <br>represents the (approximate) number of searches on this keyword idea (as available for the past twelve months), targeted to the specified geographic locations
 <br>if there is no data, the value is null

```csharp
public ICollection<MonthlySearches> MonthlySearches { get; set; }
```

#### Property Value

[ICollection&lt;MonthlySearches&gt;](./dataforseo.client.models.monthlysearches.md)<br>

### **KeywordAnnotations**

the annotations for the keyword

```csharp
public KeywordAnnotations KeywordAnnotations { get; set; }
```

#### Property Value

[KeywordAnnotations](./dataforseo.client.models.keywordannotations.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResultInfo()**

```csharp
public KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResultInfo()
```
