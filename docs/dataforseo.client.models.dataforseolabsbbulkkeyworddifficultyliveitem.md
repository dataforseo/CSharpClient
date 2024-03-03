# DataforseoLabsBBulkKeywordDifficultyLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsBBulkKeywordDifficultyLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsBBulkKeywordDifficultyLiveItem](./dataforseo.client.models.dataforseolabsbbulkkeyworddifficultyliveitem.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Keyword**

keyword in a POST array

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **KeywordDifficulty**

difficulty of ranking in the first top-10 organic results for a keyword
 <br>indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100;
 <br>calculated by analysing, among other parameters, link profiles of the first 10 pages in SERP;
 <br>learn more about the metric in this help center guide

```csharp
public Nullable<int> KeywordDifficulty { get; set; }
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

### **DataforseoLabsBBulkKeywordDifficultyLiveItem()**

```csharp
public DataforseoLabsBBulkKeywordDifficultyLiveItem()
```
