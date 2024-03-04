[`< Back`](./)

---

# BacklinksAnchorsLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksAnchorsLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksAnchorsLiveResultInfo](./dataforseo.client.models.responses.backlinksanchorsliveresultinfo)

## Properties

### **Target**

target in the post array

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

number of items in the results array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

items array

```csharp
public ICollection<BacklinksAnchorsLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksAnchorsLiveItem&gt;](./dataforseo.client.models.backlinksanchorsliveitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksAnchorsLiveResultInfo()**

```csharp
public BacklinksAnchorsLiveResultInfo()
```

---

[`< Back`](./)
