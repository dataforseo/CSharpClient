# BacklinksPageIntersectionLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BacklinksPageIntersectionLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksPageIntersectionLiveRequestInfo](./dataforseo.client.models.requests.backlinkspageintersectionliverequestinfo.md)

## Properties

### **Targets**

domains, subdomains or webpages to get links for
 <br>required field
 <br>you can set up to 20 domains, subdomains or webpages
 <br>a domain or a subdomain should be specified without https:// and www.
 <br>a page should be specified with absolute URL (including http:// or https://)
 <br>example:
 <br>"targets": {
 <br>"1": "http://planet.postgresql.org/",
 <br>"2": "http://gborg.postgresql.org/"
 <br>}

```csharp
public IDictionary<string, string> Targets { get; set; }
```

#### Property Value

[IDictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ExcludeTargets**

domains, subdomains or webpages you want to exclude
 <br>optional field
 <br>you can set up to 10 domains, subdomains or webpages
 <br>if you use this array, results will contain the referring pages that link to targets but don’t link to exclude_targets
 <br>example:
 <br>"exclude_targets": [
 <br>"bbc.com",
 <br>"https://www.apple.com/iphone/*",
 <br>"https://dataforseo.com/apis/*"]

```csharp
public ICollection<string> ExcludeTargets { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **BacklinksStatusType**

set what backlinks to return and count
 <br>optional field
 <br>you can use this field to choose what backlinks will be returned and used for aggregated metrics for your targets;
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
 <br>["1.rank","&gt;","80"]
 <br>[["2.page_from_rank","&gt;","55"],
 <br>"and",
 <br>["1.original","=","true"]]
 <br>[["1.first_seen","&gt;","2017-10-23 11:31:45 +00:00"],
 <br>"and",
 <br>[["1.acnhor","like","%seo%"],"or",["1.text_pre","not_like","%seo%"]]]
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
 <br>if you specify the 10 value, the first ten backlinks in the results array will be omitted and the data will be provided for the successive backlinks

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

### **InternalListLimit**

maximum number of elements within internal arrays
 <br>optional field
 <br>you can use this field to limit the number of elements within the following arrays:
 <br>attributes
 <br>domain_from_platform_type
 <br>default value: 10
 <br>maximum value: 1000

```csharp
public Nullable<int> InternalListLimit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IncludeSubdomains**

indicates if the subdomains of the targets will be included in the search
 <br>optional field
 <br>if set to false, the subdomains will be ignored
 <br>default value: true

```csharp
public Nullable<bool> IncludeSubdomains { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IncludeIndirectLinks**

indicates if indirect links to the targets will be included in the results
 <br>optional field
 <br>if set to true, the results will include data on indirect links pointing to a page that either redirects to a target, or points to a canonical page
 <br>if set to false, indirect links will be ignored
 <br>default value: true

```csharp
public Nullable<bool> IncludeIndirectLinks { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IntersectionMode**

indicates whether to intersect backlinks
 <br>optional field
 <br>use this field to intersect or merge results for the specified URLs
 <br>possible values: all, partical
 <br>all – results are based on all backlinks;
 <br>partial – results are based on the intersecting backlinks only;
 <br>default value: all

```csharp
public string IntersectionMode { get; set; }
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

### **BacklinksPageIntersectionLiveRequestInfo()**

```csharp
public BacklinksPageIntersectionLiveRequestInfo()
```
