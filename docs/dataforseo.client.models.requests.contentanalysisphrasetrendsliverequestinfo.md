[`< Back`](./)

---

# ContentAnalysisPhraseTrendsLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class ContentAnalysisPhraseTrendsLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentAnalysisPhraseTrendsLiveRequestInfo](./dataforseo.client.models.requests.contentanalysisphrasetrendsliverequestinfo)

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
 <br>as_is – returns data on all citations for the target keyword
 <br>one_per_domain – returns data on one citation of the keyword per domain
 <br>default value: as_is

```csharp
public string SearchMode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **InternalListLimit**

maximum number of elements within internal arrays
 <br>optional field
 <br>you can use this field to limit the number of elements within the following arrays:
 <br>top_domains
 <br>text_categories
 <br>page_categories
 <br>countries
 <br>languages
 <br>default value: 1
 <br>maximum value: 20

```csharp
public Nullable<int> InternalListLimit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DateFrom**

starting date of the time range
 <br>required field
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2019-01-15"

```csharp
public string DateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateTo**

ending date of the time range
 <br>optional field
 <br>if you don’t specify this field, today’s date will be used by default
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2019-01-15"

```csharp
public string DateTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateGroup**

time range which will be used to group the results
 <br>optional field
 <br>default value: month
 <br>possible values: day, week, month

```csharp
public string DateGroup { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **InitialDatasetFilter**

initial dataset filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like,not_like, has, has_not
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["domain","&lt; &gt;", "logitech.com"]
 <br>[["domain","&lt; &gt;","logitech.com"],"and",["content_info.connotation_types.negative","&gt;",1000]]
 <br>[["domain","&lt; &gt;","logitech.com"]],
 <br>"and",
 <br>[["content_info.connotation_types.negative","&gt;",1000],
 <br>"or",
 <br>["content_info.text_category","has",10994]]]
 <br>for more information about filters, please refer to Content Analysis API – Filters

```csharp
public ICollection<string> InitialDatasetFilter { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

### **ContentAnalysisPhraseTrendsLiveRequestInfo()**

```csharp
public ContentAnalysisPhraseTrendsLiveRequestInfo()
```

---

[`< Back`](./)
