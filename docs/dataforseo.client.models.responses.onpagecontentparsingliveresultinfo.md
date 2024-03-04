[`< Back`](./)

---

# OnPageContentParsingLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class OnPageContentParsingLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageContentParsingLiveResultInfo](./dataforseo.client.models.responses.onpagecontentparsingliveresultinfo)

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
public ICollection<OnPageContentParsingItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;OnPageContentParsingItem&gt;](./dataforseo.client.models.onpagecontentparsingitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageContentParsingLiveResultInfo()**

```csharp
public OnPageContentParsingLiveResultInfo()
```

---

[`< Back`](./)
