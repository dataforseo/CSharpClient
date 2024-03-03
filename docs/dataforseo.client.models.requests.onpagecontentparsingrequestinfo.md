# OnPageContentParsingRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class OnPageContentParsingRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageContentParsingRequestInfo](./dataforseo.client.models.requests.onpagecontentparsingrequestinfo.md)

## Properties

### **Url**

URL of the content to parse
 <br>required field
 <br>URL of the page to parse
 <br>example:
 <br>https://www.fujielectric.com/

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Id**

ID of the task
 <br>required field
 <br>you can get this ID in the response of the Task POST endpoint
 <br>note: the enable_content_parsing parameter in the POST request must be set to true
 <br>example:
 <br>"07131248-1535-0216-1000-17384017ad04"

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

### **OnPageContentParsingRequestInfo()**

```csharp
public OnPageContentParsingRequestInfo()
```
