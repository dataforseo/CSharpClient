[`< Back`](./)

---

# DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo](./dataforseo.client.models.requests.domainanalyticstechnologiestechnologiessummaryliverequestinfo)

## Properties

### **TechnologyPaths**

target technology paths
 <br>required field if you don’t specify groups, technologies and categories
 <br>if you use this field, you don’t need to specify groups, technologies and categories
 <br>each technology path should be specified as a separate object containing “path” and “name”, where “path” is specified as “$group_id.$category_id” and “name” – as the name of the target technology;
 <br>each object with a technology path should be separated with a comma
 <br>you can find the full list of technology group ids, category ids and technology names on this page
 <br>note: you can specify up to 10 technology paths in this array
 <br>example:
 <br>[{"path": "content.cms","name": "wordpress"}, {"path": "marketing.crm","name": "salesforce"}]

```csharp
public ICollection<string> TechnologyPaths { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Groups**

ids of the target technology groups
 <br>required field if you don’t specify technologies or categories
 <br>you can find the full list of technology group ids on this page
 <br>note: you can specify up to 10 technology groups in this array
 <br>example:
 <br>["sales", "marketing"]

```csharp
public ICollection<string> Groups { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Categories**

ids of the target technology categories
 <br>required field if you don’t specify groups or technologies
 <br>you can find the full list of technology category ids on this page
 <br>note: you can specify up to 10 technology categories in this array
 <br>example:
 <br>["payment_processors","crm"]

```csharp
public ICollection<string> Categories { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Technologies**

target technologies
 <br>required field if you don’t specify groups or categories
 <br>you can find the full list of technologies you can specify here on this page
 <br>note: you can specify up to 10 technologies in this array
 <br>example:
 <br>["Google Pay","Salesforce"]

```csharp
public ICollection<string> Technologies { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Keywords**

target keywords in the domain’s title, description or meta keywords
 <br>optional field
 <br>UTF-8 encoding
 <br>each keyword should be at least 3 characters long
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
 <br>as_is – search for results exactly matching the specified group ids, category ids, or technology names
 <br>entry – search for results matching a part of the specified group ids, category ids, or technology names
 <br>default value: as_is

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
 <br>&lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like,not_like
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>you can use the following parameters to filter the results: domain_rank, last_visited, country_iso_code, language_code, content_language_code
 <br>example:
 <br>[["country_iso_code","=","US"],
 <br>"and",
 <br>["domain_rank","&gt;",800]]
 <br>for more information about filters, please refer to Domain Analytics Technologies API – Filters

```csharp
public ICollection<object> Filters { get; set; }
```

#### Property Value

[ICollection&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **InternalListLimit**

maximum number of elements within internal arrays
 <br>optional field
 <br>you can use this field to limit the number of elements within the following arrays:
 <br>countries, languages, content_languages, keywords
 <br>default value: 10
 <br>maximum value: 10000

```csharp
public Nullable<int> InternalListLimit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

### **DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo()**

```csharp
public DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo()
```

---

[`< Back`](./)
