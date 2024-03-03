# BacklinksBacklinksLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BacklinksBacklinksLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBacklinksLiveRequestInfo](./dataforseo.client.models.requests.backlinksbacklinksliverequestinfo.md)

## Properties

### **Target**

domain, subdomain or webpage to get backlinks for
 <br>required field
 <br>a domain or a subdomain should be specified without https:// and www.
 <br>a page should be specified with absolute URL (including http:// or https://)

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Mode**

results grouping type
 <br>optional field
 <br>possible grouping types:
 <br>as_is – returns all backlinks
 <br>one_per_domain – returns one backlink per domain
 <br>one_per_anchor – returns one backlink per anchor
 <br>default value: as_is

```csharp
public string Mode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CustomMode**

detailed results grouping type
 <br>optional field
 <br>use this object to get a specific number of backlinks per field
 <br>if you use custom_mode, then mode will be ignored
 <br>example:
 <br>"custom_mode": {"field": "domain", "value": 100}

```csharp
public IDictionary<string, object> CustomMode { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **Field**

response field
 <br>required field if you choose to specify custom_mode
 <br>possible values:
 <br>anchor
 <br>domain_from
 <br>domain_from_country
 <br>tld_from
 <br>page_from_encoding
 <br>page_from_language
 <br>item_type
 <br>page_from_status_code
 <br>semantic_location

```csharp
public string Field { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Value**

number of backlinks to return per field
 <br>required field if you choose to specify custom_mode
 <br>can be set from 1 to 1000

```csharp
public Nullable<int> Value { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, =, &lt; &gt;, in, not_in, like, not_like, ilike, not_ilike
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["rank","&gt;","80"]
 <br>[["page_from_rank","&gt;","55"],
 <br>"and",
 <br>["dofollow","=",true]]
 <br>[["first_seen","&gt;","2017-10-23 11:31:45 +00:00"],
 <br>"and",
 <br>[["anchor","like","%seo%"],"or",["text_pre","like","%seo%"]]]
 <br>The full list of possible filters is available here.

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
 <br>["rank,desc"]
 <br>note that you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["domain_from_rank,desc","page_from_rank,asc"]

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Offset**

offset in the results array of the returned backlinks
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten backlinks in the results array will be omitted and the data will be provided for the successive backlinks;
 <br>Note: the maximum value is 20,000, use the search_after_token if you would like to offset more results

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SearchAfterToken**

token for subsequent requests
 <br>optional field
 <br>provided in the identical filed of the response to each request;
 <br>use this parameter to avoid timeouts while trying to obtain over 100,000 results in a single request;
 <br>by specifying the unique search_after_token value from the response array, you will get the subsequent results of the initial task;
 <br>search_after_token values are unique for each subsequent task
 <br>Note: if the search_after_token is specified in the request, all other parameters should be identical to the previous request

```csharp
public string SearchAfterToken { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Limit**

the maximum number of returned backlinks
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BacklinksStatusType**

set what backlinks to return and count
 <br>optional field
 <br>you can use this field to choose what backlinks will be returned and used for aggregated metrics for your target;
 <br>possible values:
 <br>all – all backlinks will be returned and counted;
 <br>live – backlinks found during the last check will be returned and counted;
 <br>lost – lost backlinks will be returned and counted;
 <br>default value: live

```csharp
public string BacklinksStatusType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IncludeSubdomains**

indicates if the subdomains of the target will be included in the search
 <br>optional field
 <br>if set to false, the subdomains will be ignored
 <br>default value: true

```csharp
public Nullable<bool> IncludeSubdomains { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IncludeIndirectLinks**

indicates if indirect links to the target will be included in the results
 <br>optional field
 <br>if set to true, the results will include data on indirect links pointing to a page that either redirects to the target, or points to a canonical page
 <br>if set to false, indirect links will be ignored
 <br>default value: true

```csharp
public Nullable<bool> IncludeIndirectLinks { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

### **BacklinksBacklinksLiveRequestInfo()**

```csharp
public BacklinksBacklinksLiveRequestInfo()
```