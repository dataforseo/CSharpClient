[`< Back`](./)

---

# OnPageMicrodataRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class OnPageMicrodataRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageMicrodataRequestInfo](./dataforseo.client.models.requests.onpagemicrodatarequestinfo)

## Properties

### **Id**

ID of the task
 <br>required field
 <br>you can get this ID in the response of the Task POST endpoint
 <br>example:
 <br>"07131248-1535-0216-1000-17384017ad04"

```csharp
public string Id { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

resource URL
 <br>required field
 <br>you can get this URL in the response of the Pages endpoint
 <br>example:
 <br>https://dataforseo.com/apis

```csharp
public string Url { get; set; }
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

### **OnPageMicrodataRequestInfo()**

```csharp
public OnPageMicrodataRequestInfo()
```

---

[`< Back`](./)
