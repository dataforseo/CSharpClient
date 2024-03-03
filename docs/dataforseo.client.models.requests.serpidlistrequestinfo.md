# SerpIdListRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class SerpIdListRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SerpIdListRequestInfo](./dataforseo.client.models.requests.serpidlistrequestinfo.md)

## Properties

### **DatetimeFrom**

start time for filtering results
 <br>required field
 <br>if include_metadata is set to true, maximum value: a month from current datetime;
 <br>if include_metadata is set to false, maximum value: six months from current datetime;
 <br>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2023-01-15 12:57:46 +00:00

```csharp
public string DatetimeFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DatetimeTo**

finish time for filtering results
 <br>required field
 <br>maximum value: current datetime;
 <br>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2023-01-31 13:57:46 +00:00

```csharp
public string DatetimeTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Limit**

the maximum number of returned task IDs
 <br>optional field
 <br>default value: 1000
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned task IDs
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten tasks in the results array will be omitted

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Sort**

sorting by task execution time
 <br>optional field
 <br>possible values: "asc", "desc"
 <br>default value: "asc"

```csharp
public string Sort { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IncludeMetadata**

include task metadata in the respond
 <br>optional field
 <br>default value: false

```csharp
public Nullable<bool> IncludeMetadata { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **SerpIdListRequestInfo()**

```csharp
public SerpIdListRequestInfo()
```
