# AppDataAppleAppListingsSearchLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class AppDataAppleAppListingsSearchLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppDataAppleAppListingsSearchLiveRequestInfo](./dataforseo.client.models.requests.appdataappleapplistingssearchliverequestinfo.md)

## Properties

### **Categories**

app categories
 <br>optional field
 <br>the categories you specify are used to search for app listings;
 <br>you can get the full list of available app listing categories by this link
 <br>you can specify up to 10 categories

```csharp
public ICollection<string> Categories { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Description**

keyword in the app’s description
 <br>optional field
 <br>keywords that occur in the description of the app;
 <br>can contain up to 200 symbols

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

keyword in the app’s title
 <br>optional field
 <br>keywords that occur in the title of the app;
 <br>can contain up to 200 symbols

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like, not_like
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["rating.value","&gt;",3]
 <br>you can receive the list of available filters by making a separate request to https://api.dataforseo.com/v3/app_data/apple/app_listings/available_filters

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
 <br>you should use a comma to set up a sorting parameter
 <br>example:
 <br>["item.rating.value,desc"]
 <br>note that you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["item.rating.value,desc","item.rating.value,desc"]

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Limit**

the maximum number of returned apps
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned apps
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten entities in the results array will be omitted and the data will be provided for the successive entities

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OffsetToken**

token for subsequent requests
 <br>optional field
 <br>provided in the identical filed of the response to each request;
 <br>use this parameter to avoid timeouts while trying to obtain over 100,000 results in a single request;
 <br>by specifying the unique offset_token value from the response array, you will get the subsequent results of the initial task;
 <br>offset_token values are unique for each subsequent task
 <br>Note: if the offset_token is specified in the request, all other parameters should be identical to the previous request

```csharp
public string OffsetToken { get; set; }
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

### **AppDataAppleAppListingsSearchLiveRequestInfo()**

```csharp
public AppDataAppleAppListingsSearchLiveRequestInfo()
```
