[`< Back`](./)

---

# AppDataGoogleAppListingsSearchLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class AppDataGoogleAppListingsSearchLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppDataGoogleAppListingsSearchLiveResultInfo](./dataforseo.client.models.responses.appdatagoogleapplistingssearchliveresultinfo)

## Properties

### **TotalCount**

the total number of relevant results in the database

```csharp
public Nullable<long> TotalCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Count**

the number of items in the results array

```csharp
public Nullable<long> Count { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned apps

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OffsetToken**

token for subsequent requests
 <br>you can use this parameter in the POST request to avoid timeouts while trying to obtain over 100,000 results in a single request

```csharp
public string OffsetToken { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Items**

array of apps and related data

```csharp
public ICollection<AppDataleAppListingsSearchLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;AppDataleAppListingsSearchLiveItem&gt;](./dataforseo.client.models.appdataleapplistingssearchliveitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AppDataGoogleAppListingsSearchLiveResultInfo()**

```csharp
public AppDataGoogleAppListingsSearchLiveResultInfo()
```

---

[`< Back`](./)
