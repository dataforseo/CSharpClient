# AppDataAppleAppReviewsTasksReadyResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class AppDataAppleAppReviewsTasksReadyResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppDataAppleAppReviewsTasksReadyResultInfo](./dataforseo.client.models.responses.appdataappleappreviewstasksreadyresultinfo.md)

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

### **EndpointAdvanced**

URL for collecting the results of the Apple App Reviews task

```csharp
public string EndpointAdvanced { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EndpointHtml**

URL for collecting the results of the Apple App Reviews HTML task
 <br>if HTML tasks are not supported in the specified endpoint, the value will be null

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

### **AppDataAppleAppReviewsTasksReadyResultInfo()**

```csharp
public AppDataAppleAppReviewsTasksReadyResultInfo()
```