# BusinessDataSocialMediaRedditLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BusinessDataSocialMediaRedditLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataSocialMediaRedditLiveRequestInfo](./dataforseo.client.models.requests.businessdatasocialmediaredditliverequestinfo.md)

## Properties

### **Targets**

target URLs
 <br>required field
 <br>target page should be specified with its absolute URL (including http:// or https://)
 <br>example:
 <br>https://dataforseo.com/
 <br>Note: you can specify 10 targets maximum. You will be charged per earch URL you specify in this array

```csharp
public ICollection<string> Targets { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

### **BusinessDataSocialMediaRedditLiveRequestInfo()**

```csharp
public BusinessDataSocialMediaRedditLiveRequestInfo()
```
