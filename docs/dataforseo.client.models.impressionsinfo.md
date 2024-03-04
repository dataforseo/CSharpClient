[`< Back`](./)

---

# ImpressionsInfo

Namespace: DataForSeo.Client.Models

```csharp
public class ImpressionsInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ImpressionsInfo](./dataforseo.client.models.impressionsinfo)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LastUpdatedTime**

date and time when impressions data was updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string LastUpdatedTime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Bid**

the maximum CPC
 <br>it stands for the price you are willing to pay for an ad. The higher value, the higher positions and price you will getwe return the results for the 999 bid value to provide the highest number of impressions and level down the account-specific factors

```csharp
public Nullable<long> Bid { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MatchType**

type of keyword match
 <br>can take the following values: exact, broad, phrase

```csharp
public string MatchType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdPositionMin**

the minimum ad position
 <br>represents the minimum position of the advertisement

```csharp
public Nullable<float> AdPositionMin { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdPositionMax**

the maximum ad position
 <br>represents the maximum position of the advertisement

```csharp
public Nullable<float> AdPositionMax { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdPositionAverage**

the average ad position
 <br>represents the average position of the advertisement

```csharp
public Nullable<double> AdPositionAverage { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CpcMin**

the minimum value of cost-per-click
 <br>the minimum cost-per-click (USD) for the keyword given that a bid is set to 999;
 <br>note: this field does not represent an actual CPC value;
 <br>you can find an actual CPC value for a keyword in the cpc field of the keyword_info object

```csharp
public Nullable<float> CpcMin { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CpcMax**

the maximum value of cost-per-click
 <br>the maximum cost-per-click (USD) for the keyword given that a bid is set to 999;
 <br>note: this field does not represent an actual CPC value;
 <br>you can find an actual CPC value for a keyword in the cpc field of the keyword_info object

```csharp
public Nullable<float> CpcMax { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CpcAverage**

the average value of cost-per-click
 <br>the average cost-per-click (USD) for the keyword given that a bid is set to 999;
 <br>note: this field does not represent an actual CPC value;
 <br>you can find an actual CPC value for a keyword in the cpc field of the keyword_info object

```csharp
public Nullable<double> CpcAverage { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DailyImpressionsMin**

the minimum value of daily impressions
 <br>represents the minimum number of daily impressions of the advertisement given that that a bid is set to 999; provides a more accurate alternative to Google search volume data

```csharp
public Nullable<float> DailyImpressionsMin { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DailyImpressionsMax**

the maximum value of daily impressions
 <br>represents the maximum number of daily impressions of the advertisement given that that a bid is set to 999; provides a more accurate alternative to Google search volume data

```csharp
public Nullable<float> DailyImpressionsMax { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DailyImpressionsAverage**

the average value of daily impressions
 <br>represents the average number of daily impressions of the advertisement given that that a bid is set to 999; provides a more accurate alternative to Google search volume data

```csharp
public Nullable<double> DailyImpressionsAverage { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DailyClicksMin**

the minimum value of daily clicks
 <br>represents the minimum number of daily clicks on the advertisement

```csharp
public Nullable<float> DailyClicksMin { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DailyClicksMax**

the maximum value of daily clicks
 <br>represents the maximum number of daily clicks on the advertisement

```csharp
public Nullable<float> DailyClicksMax { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DailyClicksAverage**

the average value of daily clicks
 <br>represents the average number of daily clicks on the advertisement

```csharp
public Nullable<double> DailyClicksAverage { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DailyCostMin**

the minimum daily charge value
 <br>represents the minimum daily cost of the advertisement (USD)

```csharp
public Nullable<float> DailyCostMin { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DailyCostMax**

the maximum daily charge value
 <br>represents the maximum daily cost of the advertisement (USD)

```csharp
public Nullable<float> DailyCostMax { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DailyCostAverage**

the average daily charge value
 <br>represents the average daily cost of the advertisement (USD)

```csharp
public Nullable<double> DailyCostAverage { get; set; }
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

### **ImpressionsInfo()**

```csharp
public ImpressionsInfo()
```

---

[`< Back`](./)
