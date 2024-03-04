[`< Back`](./)

---

# OnPageRedirectChainsResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class OnPageRedirectChainsResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageRedirectChainsResultInfo](./dataforseo.client.models.responses.onpageredirectchainsresultinfo)

## Properties

### **CrawlProgress**

status of the crawling session
 <br>possible values: in_progress, finished

```csharp
public string CrawlProgress { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CrawlStatus**

details of the crawling session

```csharp
public CrawlStatusInfo CrawlStatus { get; set; }
```

#### Property Value

[CrawlStatusInfo](./dataforseo.client.models.crawlstatusinfo)<br>

### **TotalItemsCount**

total number of relevant items in the database

```csharp
public Nullable<long> TotalItemsCount { get; set; }
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
public ICollection<OnPageRedirectChainsItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;OnPageRedirectChainsItem&gt;](./dataforseo.client.models.onpageredirectchainsitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageRedirectChainsResultInfo()**

```csharp
public OnPageRedirectChainsResultInfo()
```

---

[`< Back`](./)
