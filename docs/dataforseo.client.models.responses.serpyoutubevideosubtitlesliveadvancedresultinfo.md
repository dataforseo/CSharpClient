# SerpYoutubeVideoSubtitlesLiveAdvancedResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class SerpYoutubeVideoSubtitlesLiveAdvancedResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SerpYoutubeVideoSubtitlesLiveAdvancedResultInfo](./dataforseo.client.models.responses.serpyoutubevideosubtitlesliveadvancedresultinfo.md)

## Properties

### **VideoId**

ID of the video received in a POST array

```csharp
public string VideoId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeDomain**

search engine domain in a POST array

```csharp
public string SeDomain { get; set; }
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

### **CheckUrl**

direct URL to search engine results
 <br>you can use it to make sure that we provided accurate results

```csharp
public string CheckUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Datetime**

date and time when the result was received
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Datetime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Spell**

autocorrection of the search engine
 <br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection

```csharp
public SpellInfo Spell { get; set; }
```

#### Property Value

[SpellInfo](./dataforseo.client.models.spellinfo.md)<br>

### **ItemTypes**

types of search results in SERP
 <br>contains types of search results (items) found in SERP.
 <br>possible item:
 <br>youtube_subtitles

```csharp
public ICollection<string> ItemTypes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **UnsupportedLanguage**

indicates whether the language is unsupported by the system

```csharp
public Nullable<bool> UnsupportedLanguage { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TranslateLanguage**

language code of translated text

```csharp
public string TranslateLanguage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **OriginLanguage**

language code of original text

```csharp
public string OriginLanguage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Category**

the category the video belongs to

```csharp
public string Category { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SubtitlesCount**

number of subtitles in the video

```csharp
public Nullable<long> SubtitlesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Title**

title of the video

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ItemsCount**

the number of results returned in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

elements of search results found in SERP

```csharp
public ICollection<BaseSerpElementItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BaseSerpElementItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **SerpYoutubeVideoSubtitlesLiveAdvancedResultInfo()**

```csharp
public SerpYoutubeVideoSubtitlesLiveAdvancedResultInfo()
```