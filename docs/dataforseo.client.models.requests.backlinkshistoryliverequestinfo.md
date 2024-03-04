# BacklinksHistoryLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BacklinksHistoryLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksHistoryLiveRequestInfo](./dataforseo.client.models.requests.backlinkshistoryliverequestinfo.md)

## Properties

### **Target**

domain
 <br>required field
 <br>a domain should be specified without https:// and www.

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateFrom**

starting date of the time range
 <br>optional field
 <br>minimum value 2019-01-01
 <br>if you don’t specify this field, the minimum value will be used by default
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2019-01-15"

```csharp
public string DateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateTo**

ending date of the time range
 <br>optional field
 <br>if you don’t specify this field, the today’s date will be used by default
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2019-01-15"

```csharp
public string DateTo { get; set; }
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

### **BacklinksHistoryLiveRequestInfo()**

```csharp
public BacklinksHistoryLiveRequestInfo()
```
