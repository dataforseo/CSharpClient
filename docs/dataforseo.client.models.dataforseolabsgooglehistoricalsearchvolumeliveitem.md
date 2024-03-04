# DataforseoLabsGoogleHistoricalSearchVolumeLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsGoogleHistoricalSearchVolumeLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleHistoricalSearchVolumeLiveItem](./dataforseo.client.models.dataforseolabsgooglehistoricalsearchvolumeliveitem.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Keyword**

keyword
 <br>keyword is returned with decoded %## (plus symbol ‘+’ will be decoded to a space character)

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

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SearchPartners**

indicates data for Google and partner sites
 <br>if true, the results are returned for owned, operated, and syndicated networks across Google and partner sites that host Google search;
 <br>if false, the results are returned for Google search sites only

```csharp
public Nullable<bool> SearchPartners { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **KeywordInfo**

keyword data for the returned keyword idea

```csharp
public KeywordInfo KeywordInfo { get; set; }
```

#### Property Value

[KeywordInfo](./dataforseo.client.models.keywordinfo.md)<br>

### **KeywordProperties**

additional information about the keyword

```csharp
public KeywordProperties KeywordProperties { get; set; }
```

#### Property Value

[KeywordProperties](./dataforseo.client.models.keywordproperties.md)<br>

### **ImpressionsInfo**

impressions data for the returned keyword idea
 <br>Note that all data in the impressions_info object is deprecated and provided only as legacy to avoid maintenance issues
 <br>daily_impressions values provide a more accurate alternative to Google search volume data;
 <br>the 999 bid is used to mitigate account-specific factors Google considers when calculating impressions
 <br>learn more about impressions in this help center article

```csharp
public ImpressionsInfo ImpressionsInfo { get; set; }
```

#### Property Value

[ImpressionsInfo](./dataforseo.client.models.impressionsinfo.md)<br>

### **SerpInfo**

SERP data
 <br>the value will be null if you didn’t set the field include_serp_info to true in the POST array or if there is no SERP data for this keyword in our database

```csharp
public SerpInfo SerpInfo { get; set; }
```

#### Property Value

[SerpInfo](./dataforseo.client.models.serpinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsGoogleHistoricalSearchVolumeLiveItem()**

```csharp
public DataforseoLabsGoogleHistoricalSearchVolumeLiveItem()
```
