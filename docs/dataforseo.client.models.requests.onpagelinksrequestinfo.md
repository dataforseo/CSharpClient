[`< Back`](./)

---

# OnPageLinksRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class OnPageLinksRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageLinksRequestInfo](./dataforseo.client.models.requests.onpagelinksrequestinfo)

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

### **PageFrom**

relative page URL
 <br>optional field
 <br>if you use this field, the API response will contain only links from the specified page
 <br>note that in this field you can specify relative URLs only

```csharp
public string PageFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageTo**

relative page URL
 <br>optional field
 <br>if you use this field, the API response will contain only internal links pointing to the specified page
 <br>note that in this field you can specify relative URLs only

```csharp
public string PageTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Limit**

the maximum number of returned links
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned links
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten links in the results array will be omitted and the data will be provided for the successive links

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
 <br>regex, =, &lt; &gt;, in, not_in, like, not_like
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["direction","=","external"]
 <br>[["domain_to","&lt; &gt;","example.com"],
 <br>"and",
 <br>["link_from","not_like","%example.com/blog%"]]
 <br>[["direction","=","external"],
 <br>"and",
 <br>[["link_from","like","%example.com/blog%"],"or",["link_from","like","%example.com/help%"]]]
 <br>The full list of possible filters is available by this link.

```csharp
public ICollection<object> Filters { get; set; }
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

### **OnPageLinksRequestInfo()**

```csharp
public OnPageLinksRequestInfo()
```

---

[`< Back`](./)
