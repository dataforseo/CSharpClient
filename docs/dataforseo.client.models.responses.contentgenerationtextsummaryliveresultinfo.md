# ContentGenerationTextSummaryLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class ContentGenerationTextSummaryLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentGenerationTextSummaryLiveResultInfo](./dataforseo.client.models.responses.contentgenerationtextsummaryliveresultinfo.md)

## Properties

### **Sentences**

number of sentences found in the target text

```csharp
public Nullable<int> Sentences { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Paragraphs**

number of paragraphs found in the target text

```csharp
public Nullable<int> Paragraphs { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Words**

number of words found in the target text

```csharp
public Nullable<int> Words { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CharactersWithoutSpaces**

number of characters without spaces found in the target text

```csharp
public Nullable<int> CharactersWithoutSpaces { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CharactersWithSpaces**

number of characters with spaces found in the target text

```csharp
public Nullable<int> CharactersWithSpaces { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **WordsPerSentence**

average number of words per sentence in the target text

```csharp
public Nullable<float> WordsPerSentence { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CharactersPerWord**

average number of characters per word in the target text

```csharp
public Nullable<float> CharactersPerWord { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **VocabularyDensity**

vocabulary density of the target text

```csharp
public Nullable<float> VocabularyDensity { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **KeywordDensity**

keyword density of the target text
 <br>contains most common words and their count

```csharp
public IDictionary<string, Nullable<long>> KeywordDensity { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AutomatedReadabilityIndex**

Automated Readability Index

```csharp
public Nullable<float> AutomatedReadabilityIndex { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ColemanLiauIndex**

Coleman–Liau Index

```csharp
public Nullable<float> ColemanLiauIndex { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FleschKincaidGradeLevel**

Flesch–Kincaid Readability Index

```csharp
public Nullable<float> FleschKincaidGradeLevel { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SmogReadabilityIndex**

SMOG Readability Index

```csharp
public Nullable<float> SmogReadabilityIndex { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SpellingErrors**

number of spelling errors found in the target text

```csharp
public Nullable<int> SpellingErrors { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **GrammarErrors**

number of grammar errors found in the target text

```csharp
public Nullable<int> GrammarErrors { get; set; }
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

### **ContentGenerationTextSummaryLiveResultInfo()**

```csharp
public ContentGenerationTextSummaryLiveResultInfo()
```
