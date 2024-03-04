[`< Back`](./)

---

# OnPageNonIndexableRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class OnPageNonIndexableRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageNonIndexableRequestInfo](./dataforseo.client.models.requests.onpagenonindexablerequestinfo)

## Properties

### **Id**

ID of the task
 <br>required field
 <br>you can get this ID in the response of the Task POST endpoint
 <br>example:
 <br>“07131248-1535-0216-1000-17384017ad04”

```csharp
public string Id { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Limit**

the maximum number of returned pages
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned pages
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten pages in the results array will be omitted and the data will be provided for the successive pages

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
 <br>example:
 <br>["reason","=","robots_txt"][["reason","&lt; &gt;","robots_txt"],
 <br>"and",
 <br>["url","not_like","%/wp-admin/%"]]
 <br>[["url","not_like","%/wp-admin/%"],
 <br>"and",
 <br>[["reason","&lt; &gt;","meta_tag"],"or",["reason","&lt; &gt;","http_header"]]]
 <br>The full list of possible filters is available by this link.

```csharp
public ICollection<object> Filters { get; set; }
```

#### Property Value

[ICollection&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageNonIndexableRequestInfo()**

```csharp
public OnPageNonIndexableRequestInfo()
```

---

[`< Back`](./)
