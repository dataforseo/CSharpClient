[`< Back`](./)

---

# BacklinksCompetitorsLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BacklinksCompetitorsLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksCompetitorsLiveRequestInfo](./dataforseo.client.models.requests.backlinkscompetitorsliverequestinfo)

## Properties

### **Target**

domain, subdomain or webpage to get competitor domains for
 <br>required field
 <br>a domain or a subdomain should be specified without https:// and www.
 <br>a page should be specified with absolute URL (including http:// or https://)

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

offset in the results array of returned domains
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten domains in the results array will be omitted and the data will be provided for the successive pages

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
 <br>regex, =, &lt; &gt;, in, not_in, like, not_like, ilike, not_ilike
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["rank","&gt;","100"]
 <br>[["target","like","%forbes%"],
 <br>"and",
 <br>[["rank","&gt;","100"],"or",["intersections","&gt;","5"]]]
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
 <br>["intersections,desc","rank,asc"]

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **MainDomain**

indicates if only main domain of the target will be included in the search
 <br>optional field
 <br>if set to true, only the main domain will be included in search;
 <br>default value: true

```csharp
public Nullable<bool> MainDomain { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ExcludeLargeDomains**

indicates whether large domain will appear in results
 <br>optional field
 <br>if set to true, the results from the large domain (google.com, amazon.com, etc.) will be omitted;
 <br>default value: true

```csharp
public Nullable<bool> ExcludeLargeDomains { get; set; }
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

### **BacklinksCompetitorsLiveRequestInfo()**

```csharp
public BacklinksCompetitorsLiveRequestInfo()
```

---

[`< Back`](./)
