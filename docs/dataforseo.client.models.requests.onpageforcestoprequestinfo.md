# OnPageForceStopRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class OnPageForceStopRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageForceStopRequestInfo](./dataforseo.client.models.requests.onpageforcestoprequestinfo.md)

## Properties

### **Id**

ID of the task
 <br>required field
 <br>you can get this ID in the response of the Task POST endpoint
 <br>example:
 <br>“07131248-1535-0216-1000-17384017ad04”
 <br>note: you can set up to 1000 id values as separate objects in the POST array

```csharp
public string Id { get; set; }
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

### **OnPageForceStopRequestInfo()**

```csharp
public OnPageForceStopRequestInfo()
```
