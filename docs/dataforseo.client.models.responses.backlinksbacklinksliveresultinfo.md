# BacklinksBacklinksLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksBacklinksLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBacklinksLiveResultInfo](./dataforseo.client.models.responses.backlinksbacklinksliveresultinfo.md)

## Properties

### **Target**

target domain in a POST array

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Mode**

mode specified in a POST array

```csharp
public string Mode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CustomMode**

custom mode specified in a POST array

```csharp
public IDictionary<string, object> CustomMode { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **TotalCount**

total amount of results relevant the request

```csharp
public Nullable<long> TotalCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ItemsCount**

the number of results returned in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

contains relevant backlinks and referring domains data

```csharp
public ICollection<BacklinksBacklinksLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksBacklinksLiveItem&gt;](./dataforseo.client.models.backlinksbacklinksliveitem.md)<br>

### **SearchAfterToken**

token for subsequent requests
 <br>by specifying the unique search_after_token when setting a new task, you will get the subsequent results of the initial task;
 <br>search_after_token values are unique for each subsequent task

```csharp
public string SearchAfterToken { get; set; }
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

### **BacklinksBacklinksLiveResultInfo()**

```csharp
public BacklinksBacklinksLiveResultInfo()
```
