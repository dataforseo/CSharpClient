# KeywordsDataErrorsRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class KeywordsDataErrorsRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataErrorsRequestInfo](./dataforseo.client.models.requests.keywordsdataerrorsrequestinfo.md)

## Properties

### **Limit**

the maximum number of returned tasks that responded with an error
 <br>optional field
 <br>default value: 1000
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned tasks
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten tasks in the results array will be omitted and the data will be provided for the successive tasks

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FilteredFunction**

return tasks with a certain function
 <br>use this field to obtain a list of tasks that returned an error filtered by a certain function
 <br>you can filter the results by the values you receive in the function fields of the API response
 <br>i.e., once you receive unfiltered results, you can call this API again to filter them by function
 <br>example: keywords_data/keywords_for_site/task_post, postback_url, pingback_url

```csharp
public string FilteredFunction { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DatetimeFrom**

start time for filtering results
 <br>optional field
 <br>allows filtering results by the datetime parameter within the range of the last 24 hours;
 <br>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2021-11-15 12:57:46 +00:00

```csharp
public string DatetimeFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DatetimeTo**

finish time for filtering results
 <br>optional field
 <br>allows filtering results by the datetime parameter within the range of the last 24 hours;
 <br>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2021-11-15 13:57:46 +00:00

```csharp
public string DatetimeTo { get; set; }
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

### **KeywordsDataErrorsRequestInfo()**

```csharp
public KeywordsDataErrorsRequestInfo()
```
