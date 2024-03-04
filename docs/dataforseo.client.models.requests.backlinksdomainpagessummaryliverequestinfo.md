[`< Back`](./)

---

# BacklinksDomainPagesSummaryLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BacklinksDomainPagesSummaryLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksDomainPagesSummaryLiveRequestInfo](./dataforseo.client.models.requests.backlinksdomainpagessummaryliverequestinfo)

## Properties

### **Target**

domain, subdomain or webpage to get summary data for
 <br>required field
 <br>a domain or a subdomain should be specified without https:// and www.
 <br>a page should be specified with absolute URL (including http:// or https://)

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Limit**

the maximum number of returned anchors
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned anchors
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten anchors in the results array will be omitted and the data will be provided for the successive anchors

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **InternalListLimit**

maximum number of elements within internal arrays
 <br>optional field
 <br>you can use this field to limit the number of elements within the following arrays:
 <br>referring_links_tld
 <br>referring_links_types
 <br>referring_links_attributes
 <br>referring_links_platform_types
 <br>referring_links_semantic_locations
 <br>default value: 10
 <br>maximum value: 1000

```csharp
public Nullable<int> InternalListLimit { get; set; }
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

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, =, &lt; &gt;, in, not_in, like, not_like, ilike, not_ilike
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["referring_links_types.anchors","&gt;","1"]
 <br>[["broken_pages","&gt;","2"],
 <br>"and",
 <br>["backlinks","&gt;","10"]]
 <br>[["first_seen","&gt;","2017-10-23 11:31:45 +00:00"],
 <br>"and",
 <br>[["anchor","like","%seo%"],"or",["referring_domains","&gt;","10"]]]
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
 <br>["backlinks,desc"]
 <br>note that you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["backlinks,desc","rank,asc"]

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **BacklinksFilters**

filter the backlinks of your target
 <br>optional field
 <br>you can use this field to filter the initial backlinks that will be included in the dataset for aggregated metrics for your target
 <br>you can filter the backlinks by all fields available in the response of this endpoint
 <br>using this parameter, you can include only dofollow backlinks in the response and create a flexible backlinks dataset to calculate the metrics for
 <br>example:
 <br>"backlinks_filters": [["dofollow", "=", true]]

```csharp
public ICollection<object> BacklinksFilters { get; set; }
```

#### Property Value

[ICollection&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

### **ExcludeInternalBacklinks**

indicates whether the backlinks from subdomains of the target are excluded
 <br>optional field
 <br>if set to false, the backlinks from subdomains of the target will be ommited and you won’t receive the same domain in the response;
 <br>default value: true

```csharp
public Nullable<bool> ExcludeInternalBacklinks { get; set; }
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

### **BacklinksDomainPagesSummaryLiveRequestInfo()**

```csharp
public BacklinksDomainPagesSummaryLiveRequestInfo()
```

---

[`< Back`](./)
