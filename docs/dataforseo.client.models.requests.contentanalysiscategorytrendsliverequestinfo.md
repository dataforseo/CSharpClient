# ContentAnalysisCategoryTrendsLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class ContentAnalysisCategoryTrendsLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentAnalysisCategoryTrendsLiveRequestInfo](./dataforseo.client.models.requests.contentanalysiscategorytrendsliverequestinfo.md)

## Properties

### **CategoryCode**

target category code
 <br>required field
 <br>to obtain a full list of available categories, refer to the Categories endpoint

```csharp
public string CategoryCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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
 <br>as_is – returns data on all citations for the target category_code
 <br>one_per_domain – returns data on one citation of the category_code per domain
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

### **InitialDatasetFilters**

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
public ICollection<object> InitialDatasetFilters { get; set; }
```

#### Property Value

[ICollection&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

### **ContentAnalysisCategoryTrendsLiveRequestInfo()**

```csharp
public ContentAnalysisCategoryTrendsLiveRequestInfo()
```
