# DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo](./dataforseo.client.models.requests.domainanalyticstechnologiestechnologystatsliverequestinfo.md)

## Properties

### **Technology**

target technology
 <br>required field
 <br>you can find the full list of technologies you can specify here on this page
 <br>example:
 <br>"Salesforce"

```csharp
public string Technology { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateFrom**

starting date of the time range
 <br>optional field
 <br>minimum value 2022-10-31
 <br>if you don’t specify this field, the minimum value will be used by default
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2023-06-01"

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
 <br>"2023-01-15"

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

### **DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo()**

```csharp
public DomainAnalyticsTechnologiesTechnologyStatsLiveRequestInfo()
```
