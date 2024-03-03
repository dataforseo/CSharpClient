# OnPageRawHtmlRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class OnPageRawHtmlRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageRawHtmlRequestInfo](./dataforseo.client.models.requests.onpagerawhtmlrequestinfo.md)

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

page url
 <br>required field
 <br>the absolute URL of a page to request HTML
 <br>Note: this field is optional if the task was set using the Instant Pages endpoint

```csharp
public string Url { get; set; }
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

### **OnPageRawHtmlRequestInfo()**

```csharp
public OnPageRawHtmlRequestInfo()
```
