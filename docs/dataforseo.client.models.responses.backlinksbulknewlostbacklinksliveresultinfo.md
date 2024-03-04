# BacklinksBulkNewLostBacklinksLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksBulkNewLostBacklinksLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBulkNewLostBacklinksLiveResultInfo](./dataforseo.client.models.responses.backlinksbulknewlostbacklinksliveresultinfo.md)

## Properties

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
public ICollection<BacklinksBulkNewLostBacklinksLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksBulkNewLostBacklinksLiveItem&gt;](./dataforseo.client.models.backlinksbulknewlostbacklinksliveitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksBulkNewLostBacklinksLiveResultInfo()**

```csharp
public BacklinksBulkNewLostBacklinksLiveResultInfo()
```
