[`< Back`](./)

---

# SerpNaverOrganicTaskGetHtmlResponseInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class SerpNaverOrganicTaskGetHtmlResponseInfo : BaseResponseInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseResponseInfo](./dataforseo.client.models.responses.baseresponseinfo) → [SerpNaverOrganicTaskGetHtmlResponseInfo](./dataforseo.client.models.responses.serpnaverorganictaskgethtmlresponseinfo)

## Properties

### **Tasks**

array of tasks

```csharp
public ICollection<SerpNaverOrganicTaskGetHtmlTaskInfo> Tasks { get; set; }
```

#### Property Value

[ICollection&lt;SerpNaverOrganicTaskGetHtmlTaskInfo&gt;](./dataforseo.client.models.responses.serpnaverorganictaskgethtmltaskinfo)<br>

### **Version**

the current version of the API

```csharp
public string Version { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **StatusCode**

general status code
 <br>you can find the full list of the response codes here

```csharp
public Nullable<int> StatusCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **StatusMessage**

general informational message
 <br>you can find the full list of general informational messages here

```csharp
public string StatusMessage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Time**

total execution time, seconds

```csharp
public string Time { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Cost**

total tasks cost, USD

```csharp
public Nullable<double> Cost { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TasksCount**

the number of tasks in the tasks array

```csharp
public Nullable<long> TasksCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TasksError**

the number of tasks in the tasks array returned with an error

```csharp
public Nullable<long> TasksError { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **SerpNaverOrganicTaskGetHtmlResponseInfo()**

```csharp
public SerpNaverOrganicTaskGetHtmlResponseInfo()
```

---

[`< Back`](./)
