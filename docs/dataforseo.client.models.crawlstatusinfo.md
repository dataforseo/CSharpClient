[`< Back`](./)

---

# CrawlStatusInfo

Namespace: DataForSeo.Client.Models

```csharp
public class CrawlStatusInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CrawlStatusInfo](./dataforseo.client.models.crawlstatusinfo)

## Properties

### **MaxCrawlPages**

maximum number of pages to crawl
 <br> indicates the max_crawl_pages limit you specified when setting a task

```csharp
public Nullable<long> MaxCrawlPages { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PagesInQueue**

number of pages that are currently in the crawling queue

```csharp
public Nullable<long> PagesInQueue { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PagesCrawled**

number of crawled pages

```csharp
public Nullable<long> PagesCrawled { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **CrawlStatusInfo()**

```csharp
public CrawlStatusInfo()
```

---

[`< Back`](./)
