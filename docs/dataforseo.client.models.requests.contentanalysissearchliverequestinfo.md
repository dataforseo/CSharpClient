[`< Back`](./)

---

# ContentAnalysisSearchLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class ContentAnalysisSearchLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentAnalysisSearchLiveRequestInfo](./dataforseo.client.models.requests.contentanalysissearchliverequestinfo)

## Properties

### **Keyword**

target keyword
 <br>required field
 <br>UTF-8 encoding
 <br>a keyword should be at least 3 characters long;
 <br>the keywords will be converted to a lowercase format;
 <br>Note: to match an exact phrase instead of a stand-alone keyword, use double quotes and backslashes;
 <br>example:
 <br>"keyword": "\"tesla palo alto\""

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **KeywordFields**

target keyword fields and target keywords
 <br>optional field
 <br>use this parameter to filter the dataset by keywords that certain fields should contain;
 <br>fields you can specify: title, main_title, previous_title, snippet
 <br>you can indicate several fields;
 <br>Note: to match an exact phrase instead of a stand-alone keyword, use double quotes and backslashes;
 <br>example:
 <br>"keyword_fields": {
 <br>   "snippet": "\"logitech mouse\"",
 <br>   "main_title": "sale"
 <br>}

```csharp
public IDictionary<string, string> KeywordFields { get; set; }
```

#### Property Value

[IDictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **PageType**

target page types
 <br>optional field
 <br>use this parameter to filter the dataset by page types
 <br>possible values:
 <br>"ecommerce", "news", "blogs", "message-boards", "organization"

```csharp
public ICollection<string> PageType { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **SearchMode**

results grouping type
 <br>optional field
 <br>possible grouping types:
 <br>as_is – returns all citations for the target keyword
 <br>one_per_domain – returns one citation of the keyword per domain
 <br>default value: as_is

```csharp
public string SearchMode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Limit**

the maximum number of returned citations
 <br>optional field
 <br>default value: 100
 <br>maximum value: 20000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like,not_like
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["country","=", "US"]
 <br>[["domain_rank","&gt;",800],"and",["content_info.connotation_types.negative","&gt;",0.9]]
 <br>[["domain_rank","&gt;",800],
 <br>"and",
 <br>[["page_types","has","ecommerce"],
 <br>"or",
 <br>["content_info.text_category","has",10994]]]
 <br>for more information about filters, please refer to Content Analysis API – Filters

```csharp
public ICollection<object> Filters { get; set; }
```

#### Property Value

[ICollection&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **OrderBy**

results sorting rules
 <br>optional field
 <br>you can use the same values as in the filters array to sort the results
 <br>possible sorting types:
 <br>asc – results will be sorted in the ascending order
 <br>desc – results will be sorted in the descending order
 <br>you should use a comma to set up a sorting type
 <br>example:
 <br>["content_info.sentiment_connotations.anger,desc"]
 <br>default rule:
 <br>["content_info.sentiment_connotations.anger,desc"]
 <br>note that you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["content_info.sentiment_connotations.anger,desc","keyword_data.keyword_info.cpc,desc"]

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Offset**

offset in the results array of returned citations
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten citations in the results array will be omitted and the data will be provided for the successive citations

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OffsetToken**

offset token for subsequent requests
 <br>optional field
 <br>provided in the identical field of the response to each request;
 <br>use this parameter to avoid timeouts while trying to obtain over 10,000 results in a single request;
 <br>by specifying the unique offset_token value from the response array, you will get the subsequent results of the initial task;
 <br>offset_token values are unique for each subsequent task
 <br>Note: if the offset_token is specified in the request, all other parameters except limit will not be taken into account when processing a task

```csharp
public string OffsetToken { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Tag**

user-defined task identifier
 <br>optional field
 <br>the character limit is 255
 <br>you can use this parameter to identify the task and match it with the result
 <br>you will find the specified tag value in the data object of the response

```csharp
public string Tag { get; set; }
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

### **ContentAnalysisSearchLiveRequestInfo()**

```csharp
public ContentAnalysisSearchLiveRequestInfo()
```

---

[`< Back`](./)
