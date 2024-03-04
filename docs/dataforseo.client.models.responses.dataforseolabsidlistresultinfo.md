[`< Back`](./)

---

# DataforseoLabsIdListResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DataforseoLabsIdListResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsIdListResultInfo](./dataforseo.client.models.responses.dataforseolabsidlistresultinfo)

## Properties

### **Id**

id of the task

```csharp
public string Id { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL of the task
 <br>URL you used for making an API call

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DatetimePosted**

date and time when the task was made
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2023-01-15 12:57:46 +00:00

```csharp
public string DatetimePosted { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DatetimeDone**

date and time when the task was completed
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2023-01-15 12:57:46 +00:00

```csharp
public string DatetimeDone { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Status**

informational message of the task
 <br>you can find the full list of general informational messages here

```csharp
public string Status { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Cost**

cost of the task, USD

```csharp
public Nullable<float> Cost { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Metadata**

contains parameters you specified in the POST request

```csharp
public IDictionary<string, object> Metadata { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsIdListResultInfo()**

```csharp
public DataforseoLabsIdListResultInfo()
```

---

[`< Back`](./)
