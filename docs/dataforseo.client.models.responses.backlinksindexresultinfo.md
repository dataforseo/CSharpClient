# BacklinksIndexResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksIndexResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksIndexResultInfo](./dataforseo.client.models.responses.backlinksindexresultinfo.md)

## Properties

### **TotalBacklinks**

total number of backlinks our database contains for the moment of checking

```csharp
public Nullable<long> TotalBacklinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TotalPages**

total number of pages our database contains for the moment of checking

```csharp
public Nullable<long> TotalPages { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TotalDomains**

total number of domains our database contains for the moment of checking

```csharp
public Nullable<long> TotalDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IndexHistory**

index volume data for the past 12 months

```csharp
public ICollection<IndexHistory> IndexHistory { get; set; }
```

#### Property Value

[ICollection&lt;IndexHistory&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksIndexResultInfo()**

```csharp
public BacklinksIndexResultInfo()
```