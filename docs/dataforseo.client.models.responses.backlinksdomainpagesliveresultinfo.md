# BacklinksDomainPagesLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksDomainPagesLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksDomainPagesLiveResultInfo](./dataforseo.client.models.responses.backlinksdomainpagesliveresultinfo.md)

## Properties

### **Target**

target in a POST array

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TotalCount**

total number of relevant items in the database

```csharp
public Nullable<long> TotalCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ItemsCount**

number of items in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

items array

```csharp
public ICollection<BacklinksDomainPagesLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksDomainPagesLiveItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksDomainPagesLiveResultInfo()**

```csharp
public BacklinksDomainPagesLiveResultInfo()
```
