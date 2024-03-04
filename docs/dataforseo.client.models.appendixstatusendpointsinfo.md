# AppendixStatusEndpointsInfo

Namespace: DataForSeo.Client.Models

```csharp
public class AppendixStatusEndpointsInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppendixStatusEndpointsInfo](./dataforseo.client.models.appendixstatusendpointsinfo.md)

## Properties

### **Endpoint**

name of the endpoint
 <br>the list of possible endpoints:
 <br>task_get
 <br>task_post
 <br>live
 <br>postback/pingback

```csharp
public string Endpoint { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Status**

current status
 <br>you can find all information about the statuses of our endpoints for the last 60 days here
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

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AppendixStatusEndpointsInfo()**

```csharp
public AppendixStatusEndpointsInfo()
```
