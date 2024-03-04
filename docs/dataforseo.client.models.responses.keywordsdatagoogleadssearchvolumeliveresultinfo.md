[`< Back`](./)

---

# KeywordsDataGoogleAdsSearchVolumeLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class KeywordsDataGoogleAdsSearchVolumeLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataGoogleAdsSearchVolumeLiveResultInfo](./dataforseo.client.models.responses.keywordsdatagoogleadssearchvolumeliveresultinfo)

## Properties

### **Keyword**

keyword
 <br>keyword is returned with decoded %## (plus symbol ‘+’ will be decoded to a space character)

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Spell**

autocorrection of the search engine
 <br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection

```csharp
public SpellInfo Spell { get; set; }
```

#### Property Value

[SpellInfo](./dataforseo.client.models.spellinfo)<br>

### **LocationCode**

location code in a POST array
 <br>if there is no data, then the value is null

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageCode**

language code in a POST array
 <br>if there is no data, then the value is null

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SearchPartners**

indicates whether data from partner networks included in the response

```csharp
public Nullable<bool> SearchPartners { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Competition**

competition
 <br>represents the relative amount of competition associated with the given keyword in paid SERP only;
 <br>this value is based on Google Ads data and can take the following values: HIGH, MEDIUM, LOW;
 <br>if there is no data the value is null;
 <br>learn more about the metric in this help center article

```csharp
public string Competition { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CompetitionIndex**

competition
 <br>represents the relative amount of competition associated with the given keyword in paid SERP only;
 <br>this value is based on Google Ads data and can be between 0 and 100 (inclusive);
 <br>if there is no data the value is null;
 <br>learn more about the metric in this help center article

```csharp
public Nullable<int> CompetitionIndex { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SearchVolume**

monthly average search volume rate;
 <br>represents either the (approximate) number of searches for the given keyword idea on google.com or google.com and partners, depending on the user’s targeting;
 <br>if there is no data then the value is null

```csharp
public Nullable<long> SearchVolume { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LowTopOfPageBid**

minimum bid for the ad to be displayed at the top of the first page
 <br>indicates the value greater than about 20% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers);
 <br>the value may differ depending on the location specified in a POST request

```csharp
public Nullable<float> LowTopOfPageBid { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **HighTopOfPageBid**

maximum bid for the ad to be displayed at the top of the first page
 <br>indicates the value greater than about 80% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers);
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
 <br>represents the (approximate) number of searches on this keyword idea (as available for the past twelve months by default), targeted to the specified geographic locations;
 <br>if there is no data then the value is null

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

### **KeywordsDataGoogleAdsSearchVolumeLiveResultInfo()**

```csharp
public KeywordsDataGoogleAdsSearchVolumeLiveResultInfo()
```

---

[`< Back`](./)
