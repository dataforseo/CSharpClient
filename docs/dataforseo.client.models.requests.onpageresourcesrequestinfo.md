# OnPageResourcesRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class OnPageResourcesRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageResourcesRequestInfo](./dataforseo.client.models.requests.onpageresourcesrequestinfo.md)

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
 <br>specify this field if you want to get the resources for a specific page
 <br>note that to obtain resource’s meta from a particular URL, you should specify the URL in this field;
 <br>if you do not indicate a url when setting a task, resource’s meta in the results will be returned based on the data from the page where our crawler first saw the resource

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Limit**

the maximum number of returned resources
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned resources
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten resources in the results array will be omitted and the data will be provided for the successive resources

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
 <br>["resource_type","=","stylesheet"]
 <br>[["resource_type","=","image"],
 <br>"and",["checks.is_https","=",false]]
 <br>[["fetch_timing.duration_time","&gt;",1],"and",[["total_transfer_size","&gt;",100],"or",["checks.high_loading_time","=",true]]]
 <br>The full list of possible filters is available by this link.

```csharp
public ICollection<object> Filters { get; set; }
```

#### Property Value

[ICollection&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **RelevantPagesFilters**

filter the resources by relevant pages
 <br>optional field
 <br>you can use this field to obtain resources from pages matching to the defined parameters
 <br>you can apply the same filters here as available for the pages endpoint
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like, not_like
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["checks.no_image_title","=",true]

```csharp
public ICollection<string> RelevantPagesFilters { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **OrderBy**

results sorting rules
 <br>optional field
 <br>you can use the same values as in the filters array to sort the results
 <br>possible sorting types:
 <br>asc – results will be sorted in the ascending order
 <br>desc – results will be sorted in the descending order
 <br>you should use a comma to set up a sorting type
 <br>example:
 <br>["size,desc"]
 <br>note that you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["size,desc","fetch_timing.fetch_end,desc"]

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

### **OnPageResourcesRequestInfo()**

```csharp
public OnPageResourcesRequestInfo()
```
