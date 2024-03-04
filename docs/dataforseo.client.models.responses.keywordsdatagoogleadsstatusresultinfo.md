# KeywordsDataGoogleAdsStatusResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class KeywordsDataGoogleAdsStatusResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataGoogleAdsStatusResultInfo](./dataforseo.client.models.responses.keywordsdatagoogleadsstatusresultinfo.md)

## Properties

### **ActualData**

indicates whether Google updated keyword data for the previous month
 <br>generally, Google updates keyword data in the middle of the month
 <br>if the value is true, Google currently provides up-to-date data for the previous month
 <br>if the value is false, we are not able to provide data for the previous month

```csharp
public Nullable<bool> ActualData { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DateUpdate**

date of the latest update of Google Ads data
 <br>indicates the latest date when Google updated search volume, CPC, and other keyword metrics
 <br>example:
 <br>2020-05-15

```csharp
public string DateUpdate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LastYearInMonthlySearches**

the latest year for which search volume data is available

```csharp
public Nullable<int> LastYearInMonthlySearches { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LastMonthInMonthlySearches**

the latest month for which search volume data is available

```csharp
public Nullable<int> LastMonthInMonthlySearches { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KeywordsDataGoogleAdsStatusResultInfo()**

```csharp
public KeywordsDataGoogleAdsStatusResultInfo()
```
