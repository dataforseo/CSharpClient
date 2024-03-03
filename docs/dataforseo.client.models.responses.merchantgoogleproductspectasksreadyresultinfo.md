# MerchantGoogleProductSpecTasksReadyResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class MerchantGoogleProductSpecTasksReadyResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MerchantGoogleProductSpecTasksReadyResultInfo](./dataforseo.client.models.responses.merchantgoogleproductspectasksreadyresultinfo.md)

## Properties

### **Id**

task identifier of the completed task
 <br>unique task identifier in our system in the UUID format

```csharp
public string Id { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Se**

search engine specified when setting the task

```csharp
public string Se { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeType**

type of search engine
 <br>can take the following values: shopping_specifications

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DatePosted**

date when the task was posted (in the UTC format)

```csharp
public string DatePosted { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Tag**

user-defined task identifier

```csharp
public string Tag { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EndpointAdvanced**

URL for collecting the results of the Google Shopping Product Specifications Advanced task

```csharp
public string EndpointAdvanced { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EndpointHtml**

URL for collecting the results of the Google Shopping Product Specifications HTML task

```csharp
public string EndpointHtml { get; set; }
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

### **MerchantGoogleProductSpecTasksReadyResultInfo()**

```csharp
public MerchantGoogleProductSpecTasksReadyResultInfo()
```