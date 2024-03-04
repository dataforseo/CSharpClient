[`< Back`](./)

---

# SearchIntentInfo

Namespace: DataForSeo.Client.Models

```csharp
public class SearchIntentInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SearchIntentInfo](./dataforseo.client.models.searchintentinfo)

## Properties

### **SeType**

search engine type
 <br>possible values: google

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MainIntent**

main search intent
 <br>possible values: informational, navigational, commercial, transactional

```csharp
public string MainIntent { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ForeignIntent**

supplementary search intents
 <br>possible values: informational, navigational, commercial, transactional

```csharp
public ICollection<string> ForeignIntent { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **LastUpdatedTime**

date and time when search intent data was last updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string LastUpdatedTime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **SearchIntentInfo()**

```csharp
public SearchIntentInfo()
```

---

[`< Back`](./)
