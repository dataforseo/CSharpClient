[`< Back`](./)

---

# BacklinksSummaryLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BacklinksSummaryLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksSummaryLiveRequestInfo](./dataforseo.client.models.requests.backlinkssummaryliverequestinfo)

## Properties

### **Target**

domain, subdomain or webpage to get data for
 <br>required field
 <br>a domain or a subdomain should be specified without https:// and www.
 <br>a page should be specified with absolute URL (including http:// or https://)

```csharp
public string Target { get; set; }
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

### **BacklinksFilters**

filter the backlinks of your target
 <br>optional field
 <br>you can use this field to filter the initial backlinks that will be included in the dataset for aggregated metrics for your target
 <br>you can filter the backlinks by all fields available in the response of this endpoint
 <br>using this parameter, you can include only dofollow backlinks in the response and create a flexible backlinks dataset to calculate the metrics for
 <br>example:
 <br>"backlinks_filters": ["dofollow", "=", true]

```csharp
public ICollection<object> BacklinksFilters { get; set; }
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

### **BacklinksSummaryLiveRequestInfo()**

```csharp
public BacklinksSummaryLiveRequestInfo()
```

---

[`< Back`](./)
