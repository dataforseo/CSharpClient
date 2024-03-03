# DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo](./dataforseo.client.models.requests.domainanalyticstechnologiesaggregationtechnologiesliverequestinfo.md)

## Properties

### **Group**

id of the target technology group
 <br>required field if you don’t specify technology or category
 <br>you can find the full list of technology group ids on this page
 <br>example:
 <br>"marketing"

```csharp
public string Group { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Category**

id of the target technology category
 <br>required field if you don’t specify group or technology
 <br>you can find the full list of technology category ids on this page
 <br>example:
 <br>"crm"

```csharp
public string Category { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Technology**

target technology
 <br>required field if you don’t specify group or category
 <br>you can find the full list of technologies on this page
 <br>example:
 <br>"Salesforce"

```csharp
public string Technology { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Keyword**

target keyword in the domain’s meta keywords
 <br>optional field
 <br>UTF-8 encoding
 <br>each keyword should be at least 3 characters long
 <br>example:
 <br>"seo"

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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
 <br>["domain_rank","&gt;",800]]for more information about filters, please refer to Domain Analytics Technologies API – Filters

```csharp
public ICollection<object> Filters { get; set; }
```

#### Property Value

[ICollection&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **OrderBy**

results sorting rules
 <br>optional field
 <br>you can use the following values to sort the results: groups_count, categories_count, technologies_count
 <br>possible sorting types:
 <br>asc – results will be sorted in the ascending order
 <br>desc – results will be sorted in the descending order
 <br>you should use a comma to set up a sorting type
 <br>example:
 <br>["groups_count,desc"]
 <br>note that you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["groups_count,desc","technologies_count,desc"]
 <br>default value:
 <br>["groups_count,desc","categories_count,desc","technologies_count,desc"]

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **InternalGroupsListLimit**

maximum number of returned technology groups
 <br>optional field
 <br>you can use this field to limit the number of items with identical "group" in the results
 <br>default value: 5
 <br>maximum value: 10000

```csharp
public Nullable<int> InternalGroupsListLimit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **InternalCategoriesListLimit**

maximum number of returned technology categories within the same group
 <br>optional field
 <br>you can use this field to limit the number of items with identical "category" in the results
 <br>default value: 5
 <br>maximum value: 10000

```csharp
public Nullable<int> InternalCategoriesListLimit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **InternalTechnologiesListLimit**

maximum number of returned technologies within the same category
 <br>optional field
 <br>you can use this field to limit the number of items with identical "technology" in the results
 <br>default value: 10
 <br>maximum value: 10000

```csharp
public Nullable<int> InternalTechnologiesListLimit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **InternalListLimit**

maximum number of items with identical "category", "group", and "technology"
 <br>optional field
 <br>if you use this field, the values specified in internal_groups_list_limit, internal_categories_list_limit and internal_technologies_list_limit will be ignored;
 <br>you can use this field to limit the number of items with identical "category", "group", or "technology"
 <br>default value: 10
 <br>maximum value: 10000

```csharp
public Nullable<int> InternalListLimit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Limit**

the maximum number of returned technologies
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
 <br>maximum value: 9999
 <br>if you specify the 10 value, the first ten technologies in the results array will be omitted and the data will be provided for the successive technologies

```csharp
public Nullable<int> Offset { get; set; }
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

### **DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo()**

```csharp
public DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo()
```
