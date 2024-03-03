# SerpAiSummaryRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class SerpAiSummaryRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SerpAiSummaryRequestInfo](./dataforseo.client.models.requests.serpaisummaryrequestinfo.md)

## Properties

### **TaskId**

task identifier
 <br>required field
 <br>unique identifier of the associated task in the UUID format
 <br>you will be able to use it within 30 days to request the results of the task at any time

```csharp
public string TaskId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Prompt**

AI prompt
 <br>optional field
 <br>additional task for AI summarizer, also referred to as
 <br>any form of text, question or information that communicates to AI what response you’re looking for;
 <br>note: your prompt has to be relevant to the keyword specified in the POST request to SERP API

```csharp
public string Prompt { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SupportExtra**

support extra SERP features
 <br>optional field
 <br>if set to true, the AI model will consider the following extra SERP features, in addition to organic results: answer_box, knowledge_graph, featured_snippet;
 <br>default value: true

```csharp
public Nullable<bool> SupportExtra { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FetchContent**

fetch content from pages in SERPs
 <br>optional field
 <br>if set to true, the API will fetch the content from pages featured in SERP results, and the AI model will consider this content when generating the summary in the result;
 <br>default value: false

```csharp
public Nullable<bool> FetchContent { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IncludeLinks**

include source links in the summary
 <br>optional field
 <br>if set to true, the summary field in the API response will contain links to sources of the generated summary;
 <br>default value: false

```csharp
public Nullable<bool> IncludeLinks { get; set; }
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

### **SerpAiSummaryRequestInfo()**

```csharp
public SerpAiSummaryRequestInfo()
```
