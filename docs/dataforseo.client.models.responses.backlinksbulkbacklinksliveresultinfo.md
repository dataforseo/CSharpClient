# BacklinksBulkBacklinksLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksBulkBacklinksLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBulkBacklinksLiveResultInfo](./dataforseo.client.models.responses.backlinksbulkbacklinksliveresultinfo.md)

## Properties

### **ItemsCount**

the number of results returned in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

contains relevant backlink data

```csharp
public ICollection<BacklinksBulkBacklinksLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksBulkBacklinksLiveItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksBulkBacklinksLiveResultInfo()**

```csharp
public BacklinksBulkBacklinksLiveResultInfo()
```
