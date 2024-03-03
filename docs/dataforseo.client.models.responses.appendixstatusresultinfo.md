# AppendixStatusResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class AppendixStatusResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppendixStatusResultInfo](./dataforseo.client.models.responses.appendixstatusresultinfo.md)

## Properties

### **Api**

name of the API
 <br>the list of APIs:
 <br>serp
 <br>keywords_data
 <br>appendix
 <br>dataforseo_labs
 <br>domain_analytics
 <br>merchant
 <br>on_page
 <br>business_data
 <br>backlinks
 <br>app_data

```csharp
public string Api { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Status**

current status
 <br>you can find all information about your API statuses for the last 60 days here
 <br>the list of possible current statuses:
 <br>major_outage
 <br>partial_outage
 <br>long_response_time
 <br>long_execution_time
 <br>webhook_delay
 <br>send_delay

```csharp
public string Status { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Endpoints**

array of objects that contain status information for API endpoints

```csharp
public ICollection<AppendixStatusEndpointsInfo> Endpoints { get; set; }
```

#### Property Value

[ICollection&lt;AppendixStatusEndpointsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AppendixStatusResultInfo()**

```csharp
public AppendixStatusResultInfo()
```
