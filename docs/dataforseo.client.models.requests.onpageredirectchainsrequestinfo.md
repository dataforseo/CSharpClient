# OnPageRedirectChainsRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class OnPageRedirectChainsRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageRedirectChainsRequestInfo](./dataforseo.client.models.requests.onpageredirectchainsrequestinfo.md)

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

### **Url**

page URL
 <br>optional field
 <br>absolute URL of the target page
 <br>if you use this field, the API response will return only redirect chains which contain the specified URL

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Limit**

the maximum number of returned redirect chains
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned redirect chains
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten redirect chains in the results array will be omitted and the data will be provided for the successive redirect chains

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can use only one filtering parameter with this endpoint
 <br>the following filtering parameter is supported:
 <br>is_redirect_loop
 <br>the following operators are supported:
 <br>regex, =, &lt; &gt;
 <br>examples:
 <br>["is_redirect_loop","=","true"]
 <br>["is_redirect_loop","&lt; &gt;","false"]

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

### **OnPageRedirectChainsRequestInfo()**

```csharp
public OnPageRedirectChainsRequestInfo()
```
