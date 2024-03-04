[`< Back`](./)

---

# DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo](./dataforseo.client.models.requests.domainanalyticstechnologiesdomainsbyhtmltermsliverequestinfo)

## Properties

### **SearchTerms**

target search terms
 <br>required field
 <br>specify target HTML elements, tags, attributes, their content or all of the above
 <br>if you specify more than one search term, you will receive only the domains containing all of the specified terms in the HTML code of their homepage
 <br>maximum number of search terms you can specify: 10
 <br>example:
 <br>["data-attrid"]

```csharp
public ICollection<string> SearchTerms { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Keywords**

target keywords in the domain’s title, description or meta keywords
 <br>optional field
 <br>UTF-8 encoding
 <br>each keyword should be at least 3 characters long
 <br>maximum number of keywords you can specify: 10
 <br>example:
 <br>["seo","software"]

```csharp
public ICollection<string> Keywords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Mode**

search mode
 <br>optional field
 <br>possible search mode types:
 <br>strict_entry – search for results exactly matching the order, intervals and separators in the specified search terms
 <br>entry – search for results ignoring the order, intervals and separators in the specified search terms
 <br>default value: entry

```csharp
public string Mode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>&lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like, not_like
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["domain","like","%seo%"]
 <br>[["country_iso_code","=","US"],
 <br>"and",
 <br>["domain_rank","&gt;",100]]
 <br>[["domain_rank","&gt;",100],
 <br>"and",
 <br>[["country_iso_code","=","US"],"or",["country_iso_code","=","CA"]]]
 <br>for more information about filters, please refer to Domain Analytics Technologies API – Filters

```csharp
public ICollection<object> Filters { get; set; }
```

#### Property Value

[ICollection&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **OrderBy**

results sorting rules
 <br>optional field
 <br>available fields:
 <br>domain_rank, domain, last_visited, country_iso_code, language_code, content_language_code
 <br>possible sorting types:
 <br>asc – results will be sorted in the ascending order
 <br>desc – results will be sorted in the descending order
 <br>you should use a comma to set up a sorting type
 <br>example:
 <br>["last_visited,desc"]
 <br>default rule:
 <br>["domain_rank,desc"]
 <br>note that you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["last_visited,desc","domain_rank,desc"]

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Limit**

the maximum number of returned domains
 <br>optional field
 <br>default value: 100
 <br>maximum value: 10000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned domains
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten domains in the results array will be omitted and the data will be provided for the successive domains;
 <br>Note: the maximum value is 9999, the sum of limit and offset must not exceed 10000;
 <br>use the offset_token if you would like to offset more results

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OffsetToken**

token for subsequent requests
 <br>optional field
 <br>provided in the identical filed of the response to each request;
 <br>use this parameter to avoid timeouts while trying to obtain over 100,000 results in a single request;
 <br>by specifying the unique offset_token value from the response array, you will get the subsequent results of the initial task;
 <br>offset_token values are unique for each subsequent task
 <br>Note: if the offset_token is specified in the request, all other parameters should be identical to the previous request

```csharp
public string OffsetToken { get; set; }
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

### **DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo()**

```csharp
public DomainAnalyticsTechnologiesDomainsByHtmlTermsLiveRequestInfo()
```

---

[`< Back`](./)
