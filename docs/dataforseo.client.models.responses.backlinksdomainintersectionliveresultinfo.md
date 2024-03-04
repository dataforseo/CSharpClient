[`< Back`](./)

---

# BacklinksDomainIntersectionLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksDomainIntersectionLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksDomainIntersectionLiveResultInfo](./dataforseo.client.models.responses.backlinksdomainintersectionliveresultinfo)

## Properties

### **Targets**

target domains, subdomains or webpages in a POST array

```csharp
public IDictionary<string, string> Targets { get; set; }
```

#### Property Value

[IDictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **TotalCount**

total amount of results relevant to your request

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

contains domain that link to all targets from the POST array

```csharp
public ICollection<BacklinksDomainIntersectionLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksDomainIntersectionLiveItem&gt;](./dataforseo.client.models.backlinksdomainintersectionliveitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksDomainIntersectionLiveResultInfo()**

```csharp
public BacklinksDomainIntersectionLiveResultInfo()
```

---

[`< Back`](./)
