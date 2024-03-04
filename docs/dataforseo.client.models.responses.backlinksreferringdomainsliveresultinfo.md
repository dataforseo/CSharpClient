[`< Back`](./)

---

# BacklinksReferringDomainsLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksReferringDomainsLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksReferringDomainsLiveResultInfo](./dataforseo.client.models.responses.backlinksreferringdomainsliveresultinfo)

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
 <br>total number of main domains referring to your target;
 <br>example.com and blog.example.com are counted as one referring domain

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
public ICollection<BacklinksReferringDomainsLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksReferringDomainsLiveItem&gt;](./dataforseo.client.models.backlinksreferringdomainsliveitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksReferringDomainsLiveResultInfo()**

```csharp
public BacklinksReferringDomainsLiveResultInfo()
```

---

[`< Back`](./)
