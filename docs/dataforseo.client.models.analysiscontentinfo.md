# AnalysisContentInfo

Namespace: DataForSeo.Client.Models

```csharp
public class AnalysisContentInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AnalysisContentInfo](./dataforseo.client.models.analysiscontentinfo.md)

## Properties

### **ContentType**

type of content
 <br>example:
 <br>page_content, comment

```csharp
public string ContentType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the result

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MainTitle**

page title

```csharp
public string MainTitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PreviousTitle**

title of the previous content block

```csharp
public string PreviousTitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Level**

title heading level
 <br>indicates h-tag level from 1 (top) to 6 (bottom)

```csharp
public Nullable<int> Level { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Author**

author of the content

```csharp
public string Author { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Snippet**

content snippet

```csharp
public string Snippet { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SnippetLength**

character length of the snippet

```csharp
public Nullable<int> SnippetLength { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SocialMetrics**

social media engagement metrics
 <br>data on social media interactions associated with the content based on website embeds developed and supported by social media platforms

```csharp
public ICollection<SocialMetricsInfo> SocialMetrics { get; set; }
```

#### Property Value

[ICollection&lt;SocialMetricsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **HighlightedText**

highlighted text from the snippet

```csharp
public string HighlightedText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Language**

content language
 <br>to obtain a full list of available languages, refer to the Languages endpoint

```csharp
public string Language { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SentimentConnotations**

sentiment connotations
 <br>contains sentiments (emotional reactions) related to the given citation and probability index per each sentiment
 <br>possible sentiment connotations: anger, happiness, love, sadness, share, fun

```csharp
public SentimentConnotationInfo SentimentConnotations { get; set; }
```

#### Property Value

[SentimentConnotationInfo](./dataforseo.client.models.sentimentconnotationinfo.md)<br>

### **ConnotationTypes**

connotation types
 <br>contains types of sentiments (sentiment polarity) related to the given citation and probability index per each sentiment type
 <br>possible sentiment connotation types: positive, negative, neutral

```csharp
public ConnotationTypeInfo ConnotationTypes { get; set; }
```

#### Property Value

[ConnotationTypeInfo](./dataforseo.client.models.connotationtypeinfo.md)<br>

### **TextCategory**

text category
 <br>to obtain a full list of available categories, refer to the Categories endpoint

```csharp
public ICollection<int> TextCategory { get; set; }
```

#### Property Value

[ICollection&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **DatePublished**

date and time when the content was published
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2017-01-24 13:20:59 +00:00

```csharp
public string DatePublished { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ContentQualityScore**

content quality score
 <br>this value is calculated based on the number of words, sentences and characters the content contains

```csharp
public Nullable<int> ContentQualityScore { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SemanticLocation**

semantic location
 <br>indicates semantic element in HTML where the target keyword citation is located
 <br>example:
 <br>article, header

```csharp
public string SemanticLocation { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rating**

content rating
 <br>rating related to content_info

```csharp
public ContentAnalysisRatingInfo Rating { get; set; }
```

#### Property Value

[ContentAnalysisRatingInfo](./dataforseo.client.models.contentanalysisratinginfo.md)<br>

### **GroupDate**

citation group date and time
 <br>indicates content publication date or date and time when our crawler visited the page for the first time;
 <br>this field can be used to group citations by date and display citation trends;
 <br>date and time are provided in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2017-01-24 13:20:59 +00:00

```csharp
public string GroupDate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AnalysisContentInfo()**

```csharp
public AnalysisContentInfo()
```
