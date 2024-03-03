# BacklinksPageIntersectionLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksPageIntersectionLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksPageIntersectionLiveResultInfo](./dataforseo.client.models.responses.backlinkspageintersectionliveresultinfo.md)

## Properties

### **Targets**

targets from a POST array

```csharp
public IDictionary<string, string> Targets { get; set; }
```

#### Property Value

[IDictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

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
public ICollection<BacklinksPageIntersectionLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksPageIntersectionLiveItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksPageIntersectionLiveResultInfo()**

```csharp
public BacklinksPageIntersectionLiveResultInfo()
```
