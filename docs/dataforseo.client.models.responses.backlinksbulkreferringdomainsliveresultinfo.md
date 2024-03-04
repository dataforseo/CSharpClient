# BacklinksBulkReferringDomainsLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksBulkReferringDomainsLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBulkReferringDomainsLiveResultInfo](./dataforseo.client.models.responses.backlinksbulkreferringdomainsliveresultinfo.md)

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
public ICollection<BacklinksBulkReferringDomainsLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksBulkReferringDomainsLiveItem&gt;](./dataforseo.client.models.backlinksbulkreferringdomainsliveitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksBulkReferringDomainsLiveResultInfo()**

```csharp
public BacklinksBulkReferringDomainsLiveResultInfo()
```
