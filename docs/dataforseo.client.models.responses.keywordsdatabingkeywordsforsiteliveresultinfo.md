[`< Back`](./)

---

# KeywordsDataBingKeywordsForSiteLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class KeywordsDataBingKeywordsForSiteLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataBingKeywordsForSiteLiveResultInfo](./dataforseo.client.models.responses.keywordsdatabingkeywordsforsiteliveresultinfo)

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

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageCode**

language code in a POST array

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

### **Device**

device type in a POST array
 <br>if there is no data, then the value is null

```csharp
public string Device { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Competition**

competition
 <br>represents the relative amount of competition associated with the given keyword in paid SERP only. This value is based on Bing Ads data.
 <br>Possible values: 0.1, 0.5,0.90.1 – low competition,
 <br>0.5 – medium competition,
 <br>0.9 – high competition;
 <br>if there is no data the value is null

```csharp
public Nullable<float> Competition { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Cpc**

cost-per-click
 <br>represents the average cost per click (USD) historically paid for the keyword.
 <br>if there is no data, then the value is null

```csharp
public Nullable<float> Cpc { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SearchVolume**

monthly average search volume rate
 <br>represents the (approximate) number of searches for the keyword on the Bing search engine, depending on the user’s targetingsearch volume is rounded to the closest decimal valuesif there is no data, then the value is null

```csharp
public Nullable<long> SearchVolume { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Categories**

product and service categories
 <br>legacy field, the value will always be null

```csharp
public ICollection<string> Categories { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **MonthlySearches**

monthly searches
 <br>represents the (approximate) number of searches on this keyword (as available for the past twelve months), targeted to the specified geographic locations.
 <br>if there is no data, then the value is null

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

### **KeywordsDataBingKeywordsForSiteLiveResultInfo()**

```csharp
public KeywordsDataBingKeywordsForSiteLiveResultInfo()
```

---

[`< Back`](./)
