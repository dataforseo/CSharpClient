# ContentAnalysisPhraseTrendsLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class ContentAnalysisPhraseTrendsLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentAnalysisPhraseTrendsLiveResultInfo](./dataforseo.client.models.responses.contentanalysisphrasetrendsliveresultinfo.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Date**

date for which the data is provided

```csharp
public string Date { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TotalCount**

total number of results in our database relevant to your request

```csharp
public Nullable<long> TotalCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rank**

rank of all URLs citing the keyword
 <br>normalized sum of ranks of all URLs citing the target keyword for the given date

```csharp
public Nullable<int> Rank { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TopDomains**

top domains citing the target keyword
 <br>contains objects with top domains citing the target keyword and citation count per each domain

```csharp
public ICollection<TopDomainInfo> TopDomains { get; set; }
```

#### Property Value

[ICollection&lt;TopDomainInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **SentimentConnotations**

sentiment connotations
 <br>contains sentiments (emotional reactions) related to the target keyword citation and the number of citations per each sentiment
 <br>possible connotations: "anger", "happiness", "love", "sadness", "share", "fun"

```csharp
public IDictionary<string, Nullable<long>> SentimentConnotations { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ConnotationTypes**

connotation types
 <br>contains types of sentiments (sentiment polarity) related to the keyword citation and citation count per each sentiment type
 <br>possible connotation types: "positive", "negative", "neutral"

```csharp
public IDictionary<string, Nullable<long>> ConnotationTypes { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **TextCategories**

text categories
 <br>contains objects with text categories and citation count in each text category
 <br>to obtain a full list of available categories, refer to the Categories endpoint

```csharp
public ICollection<ContentAnalysisCategoriesInfo> TextCategories { get; set; }
```

#### Property Value

[ICollection&lt;ContentAnalysisCategoriesInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **PageCategories**

page categories
 <br>contains objects with page categories and citation count in each page category
 <br>to obtain a full list of available categories, refer to the Categories endpoint

```csharp
public ICollection<ContentAnalysisCategoriesInfo> PageCategories { get; set; }
```

#### Property Value

[ICollection&lt;ContentAnalysisCategoriesInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **PageTypes**

page types
 <br>contains page types and citation count per each page type

```csharp
public IDictionary<string, Nullable<long>> PageTypes { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **Countries**

countries
 <br>contains countries and citation count in each country
 <br>to obtain a full list of available countries, refer to the Locations endpoint

```csharp
public IDictionary<string, Nullable<long>> Countries { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **Languages**

languages
 <br>contains languages and citation count in each language
 <br>to obtain a full list of available languages, refer to the Languages endpoint

```csharp
public IDictionary<string, Nullable<long>> Languages { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ContentAnalysisPhraseTrendsLiveResultInfo()**

```csharp
public ContentAnalysisPhraseTrendsLiveResultInfo()
```
