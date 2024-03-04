# OnPagePagesResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class OnPagePagesResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPagePagesResultInfo](./dataforseo.client.models.responses.onpagepagesresultinfo.md)

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

[CrawlStatusInfo](./dataforseo.client.models.crawlstatusinfo.md)<br>

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
public ICollection<BaseOnPageResourceItemInfo> Items { get; set; }
```

#### Property Value

[ICollection&lt;BaseOnPageResourceItemInfo&gt;](./dataforseo.client.models.baseonpageresourceiteminfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPagePagesResultInfo()**

```csharp
public OnPagePagesResultInfo()
```
