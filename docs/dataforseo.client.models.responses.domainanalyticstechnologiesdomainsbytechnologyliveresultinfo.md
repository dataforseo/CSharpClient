[`< Back`](./)

---

# DomainAnalyticsTechnologiesDomainsByTechnologyLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DomainAnalyticsTechnologiesDomainsByTechnologyLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainAnalyticsTechnologiesDomainsByTechnologyLiveResultInfo](./dataforseo.client.models.responses.domainanalyticstechnologiesdomainsbytechnologyliveresultinfo)

## Properties

### **TotalCount**

total number of relevant items in the database

```csharp
public Nullable<long> TotalCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ItemsCount**

number of items in the results array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

specified offset value

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OffsetToken**

token for subsequent requests
 <br>by specifying the unique offset_token when setting a new task, you will get the subsequent results of the initial task;
 <br>offset_token values are unique for each subsequent task

```csharp
public string OffsetToken { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Items**

items array

```csharp
public ICollection<DomainAnalyticsTechnologiesDomainsByLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;DomainAnalyticsTechnologiesDomainsByLiveItem&gt;](./dataforseo.client.models.domainanalyticstechnologiesdomainsbyliveitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DomainAnalyticsTechnologiesDomainsByTechnologyLiveResultInfo()**

```csharp
public DomainAnalyticsTechnologiesDomainsByTechnologyLiveResultInfo()
```

---

[`< Back`](./)
