# MicrodataTestResultsInfo

Namespace: DataForSeo.Client.Models

```csharp
public class MicrodataTestResultsInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MicrodataTestResultsInfo](./dataforseo.client.models.microdatatestresultsinfo.md)

## Properties

### **Level**

level of microdata error
 <br>can take the following values: fatal, error, warning, info

```csharp
public string Level { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Message**

message associated with an error
 <br>message providing the details of the detected error

```csharp
public string Message { get; set; }
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

### **MicrodataTestResultsInfo()**

```csharp
public MicrodataTestResultsInfo()
```
