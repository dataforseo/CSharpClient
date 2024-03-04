[`< Back`](./)

---

# KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResultInfo](./dataforseo.client.models.responses.keywordsdatagoogleadsadtrafficbykeywordsliveresultinfo)

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

### **DateInterval**

forecasting date interval in a POST array

```csharp
public string DateInterval { get; set; }
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

### **Bid**

the maximum custom bid
 <br>the bid you have specified when setting the task
 <br>represents the price you are willing to pay for an ad
 <br>the higher value you have specified, the higher metrics and cost you receive in response
 <br>learn more in this help center article

```csharp
public Nullable<float> Bid { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Match**

keywords match-type
 <br>can take the following values: exact, broad, phrase

```csharp
public string Match { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Impressions**

projected number of ad impressions
 <br>number of impressions an ad is projected to get within the specified time period
 <br>if there is no data, then the value is null
 <br>learn more about impressions in this help center article

```csharp
public Nullable<float> Impressions { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Ctr**

projected click through rate (CTR) of the advertisement
 <br>number of clicks an ad is projected to receive divided by the number of ad impressions; the CTR is projected for the specified time period
 <br>if there is no data, then the value is null

```csharp
public Nullable<double> Ctr { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AverageCpc**

the average cost-per-click value
 <br>represents the cost-per-click (USD) estimated for a keyword based on the specified time period and historical data;
 <br>if there is no data, then the value is null

```csharp
public Nullable<double> AverageCpc { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Cost**

charge for an ad
 <br>amount that will be charged for running an ad within the specified time period
 <br>if there is no data, then the value is null

```csharp
public Nullable<float> Cost { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Clicks**

number of clicks on an ad
 <br>number of clicks an ad is projected to get within the specified time period
 <br>if there is no data, then the value is null

```csharp
public Nullable<float> Clicks { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResultInfo()**

```csharp
public KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResultInfo()
```

---

[`< Back`](./)
