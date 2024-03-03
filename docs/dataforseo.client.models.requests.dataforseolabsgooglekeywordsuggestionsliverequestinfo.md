# DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo](./dataforseo.client.models.requests.dataforseolabsgooglekeywordsuggestionsliverequestinfo.md)

## Properties

### **Keyword**

keyword
 <br>required field
 <br>UTF-8 encoding
 <br>a keyword should be at least 3 characters long;
 <br>the keywords will be converted to lowercase format

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationName**

full name of the location
 <br>optional field
 <br>if you use this field, you don’t need to specify location_code
 <br>you can receive the list of available locations with their location_name by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>ignore this field to get the results for all available locations
 <br>example:
 <br>United Kingdom

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code
 <br>optional field
 <br>if you use this field, you don’t need to specify location_name
 <br>you can receive the list of available locations with their location_code by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>ignore this field to get the results for all available locations
 <br>example:
 <br>2840

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageName**

full name of the language
 <br>optional field
 <br>if you use this field, you don’t need to specify language_code
 <br>you can receive the list of available languages with their language_name by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>ignore this field to get the results for all available languages
 <br>example:
 <br>English

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

language code
 <br>optional field
 <br>if you use this field, you don’t need to specify language_name
 <br>you can receive the list of available languages with their language_code by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>ignore this field to get the results for all available languages
 <br>example:
 <br>en

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IncludeSeedKeyword**

include data for the seed keyword
 <br>optional field
 <br>if set to true, data for the seed keyword specified in the keyword field will be provided in the seed_keyword_data array of the response
 <br>default value: false

```csharp
public Nullable<bool> IncludeSeedKeyword { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IncludeSerpInfo**

include data from SERP for each keyword
 <br>optional field
 <br>if set to true, we will return a serp_info array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the response
 <br>default value: false

```csharp
public Nullable<bool> IncludeSerpInfo { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ExactMatch**

search for the exact phrase
 <br>optional field
 <br>if set to true, the returned keywords will include the exact keyword phrase you specified, with potentially other words before or after that phrase
 <br>default value: false

```csharp
public Nullable<bool> ExactMatch { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IgnoreSynonyms**

ignore highly similar keywords
 <br>optional field
 <br>if set to true only core keywords will be returned, all highly similar keywords will be excluded;
 <br>default value: false

```csharp
public Nullable<bool> IgnoreSynonyms { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like, not_like
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["keyword_info.search_volume","&gt;",0]
 <br>[["keyword_info.search_volume","in",[0,1000]],
 <br>"and",
 <br>["keyword_info.competition_level","=","LOW"]][["keyword_info.search_volume","&gt;",100],
 <br>"and",
 <br>[["keyword_info.cpc","&lt;",0.5],
 <br>"or",
 <br>["keyword_info.high_top_of_page_bid","&lt;=",0.5]]]
 <br>for more information about filters, please refer to Dataforseo Labs – Filters or this help center guide

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
 <br>a comma is used as a separator
 <br>example:
 <br>["keyword_info.competition,desc"]
 <br>default rule:
 <br>["keyword_info.search_volume,desc"]
 <br>note that you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["keyword_info.search_volume,desc","keyword_info.cpc,desc"]

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Limit**

the maximum number of returned keywords
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned keywords
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OffsetToken**

offset token for subsequent requests
 <br>optional field
 <br>provided in the identical filed of the response to each request;
 <br>use this parameter to avoid timeouts while trying to obtain over 10,000 results in a single request;
 <br>by specifying the unique offset_token value from the response array, you will get the subsequent results of the initial task;
 <br>offset_token values are unique for each subsequent task
 <br>Note: if the offset_token is specified in the request, all other parameters except limit will not be taken into account when processing a task.

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

### **DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo()**

```csharp
public DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo()
```