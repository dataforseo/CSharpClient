# KeywordProperties

Namespace: DataForSeo.Client.Models

```csharp
public class KeywordProperties
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordProperties](./dataforseo.client.models.keywordproperties.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CoreKeyword**

main keyword in a group
 <br>contains the main keyword in a group determined by the synonym clustering algorithm
 <br>if the value is null, our database does not contain any keywords the corresponding algorithm could identify as synonymous with keyword

```csharp
public string CoreKeyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SynonymClusteringAlgorithm**

the algorithm used to identify synonyms
 <br>possible values:
 <br>keyword_metrics – indicates the algorithm based on keyword_info parameters
 <br>text_processing – indicates the text-based algorithm
 <br>if the value is null, our database does not contain any keywords the corresponding algorithm could identify as synonymous with keyword

```csharp
public string SynonymClusteringAlgorithm { get; set; }
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

### **DetectedLanguage**

detected language of the keyword
 <br>indicates the language of the keyword as identified by our system

```csharp
public string DetectedLanguage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsAnotherLanguage**

detected language of the keyword is different from the set language
 <br>if true, the language set in the request does not match the language determined by our system for a given keyword

```csharp
public Nullable<bool> IsAnotherLanguage { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KeywordProperties()**

```csharp
public KeywordProperties()
```
