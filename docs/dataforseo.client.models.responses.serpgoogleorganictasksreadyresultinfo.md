# SerpGoogleOrganicTasksReadyResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class SerpGoogleOrganicTasksReadyResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SerpGoogleOrganicTasksReadyResultInfo](./dataforseo.client.models.responses.serpgoogleorganictasksreadyresultinfo.md)

## Properties

### **Id**

task identifier of the completed task
 <br>unique task identifier in our system in the UUID format

```csharp
public string Id { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Se**

search engine specified when setting the task

```csharp
public string Se { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeType**

type of search engine
 <br>can take the following values: organic

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DatePosted**

date when the task was posted (in the UTC format)

```csharp
public string DatePosted { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Tag**

user-defined task identifier

```csharp
public string Tag { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EndpointRegular**

URL for collecting the results of the SERP Regular task
 <br>if SERP Regular is not supported in the specified endpoint, the value will be null

```csharp
public string EndpointRegular { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EndpointAdvanced**

URL for collecting the results of the SERP Advanced task
 <br>if SERP Advanced is not supported in the specified endpoint, the value will be null

```csharp
public string EndpointAdvanced { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EndpointHtml**

URL for collecting the results of the SERP HTML task
 <br>if SERP HTML is not supported in the specified endpoint, the value will be null

```csharp
public string EndpointHtml { get; set; }
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

### **SerpGoogleOrganicTasksReadyResultInfo()**

```csharp
public SerpGoogleOrganicTasksReadyResultInfo()
```
