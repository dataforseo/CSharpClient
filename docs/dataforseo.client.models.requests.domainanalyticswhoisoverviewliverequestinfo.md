[`< Back`](./)

---

# DomainAnalyticsWhoisOverviewLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DomainAnalyticsWhoisOverviewLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainAnalyticsWhoisOverviewLiveRequestInfo](./dataforseo.client.models.requests.domainanalyticswhoisoverviewliverequestinfo)

## Properties

### **Limit**

the maximum number of returned domains
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned items
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten items in the results array will be omitted and the data will be provided for the successive items

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like, not_like
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>examples:
 <br>["expiration_datetime", "&lt;", "2021-02-15 01:00:00 +00:00"]
 <br>[["expiration_datetime", "&lt;", "2021-02-15 01:00:00 +00:00"],
 <br> "and", 
 <br>["domain", "like", "%seo%"]]
 <br><br>for more information about filters, please refer to Filters Page or this help center guide

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
 <br>asc - results will be sorted in the ascending order
 <br>desc - results will be sorted in the descending order
 <br>the comma is used as a separator
 <br>example:
 <br>["metrics.organic.pos_1,desc"]
 <br>default rule:
 <br>["metrics.organic.count,desc"]
 <br>note that you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["expiration_datetime,asc","metrics.organic.etv,desc","metrics.organic.pos_1,desc"]

```csharp
public ICollection<string> OrderBy { get; set; }
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

### **DomainAnalyticsWhoisOverviewLiveRequestInfo()**

```csharp
public DomainAnalyticsWhoisOverviewLiveRequestInfo()
```

---

[`< Back`](./)
