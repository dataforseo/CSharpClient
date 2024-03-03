# BacklinksBulkSpamScoreLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksBulkSpamScoreLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBulkSpamScoreLiveResultInfo](./dataforseo.client.models.responses.backlinksbulkspamscoreliveresultinfo.md)

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
public ICollection<BacklinksBulkSpamScoreLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksBulkSpamScoreLiveItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksBulkSpamScoreLiveResultInfo()**

```csharp
public BacklinksBulkSpamScoreLiveResultInfo()
```
