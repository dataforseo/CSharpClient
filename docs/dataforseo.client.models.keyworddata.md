# KeywordData

Namespace: DataForSeo.Client.Models

```csharp
public class KeywordData
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordData](./dataforseo.client.models.keyworddata.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Keyword**

returned keyword

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

### **KeywordInfo**

keyword data for the returned keyword

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

### **AvgBacklinksInfo**

backlink data for the returned keyword
 <br>this object provides the average number of backlinks, referring pages and domains, as well as the average rank values among the top-10 websites ranking organically for the keyword

```csharp
public AvgBacklinksInfo AvgBacklinksInfo { get; set; }
```

#### Property Value

[AvgBacklinksInfo](./dataforseo.client.models.avgbacklinksinfo.md)<br>

### **SearchIntentInfo**

search intent info for the returned keyword
 <br>learn about search intent in this help center article

```csharp
public SearchIntentInfo SearchIntentInfo { get; set; }
```

#### Property Value

[SearchIntentInfo](./dataforseo.client.models.searchintentinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KeywordData()**

```csharp
public KeywordData()
```
