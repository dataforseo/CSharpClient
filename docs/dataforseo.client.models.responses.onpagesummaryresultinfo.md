# OnPageSummaryResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class OnPageSummaryResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageSummaryResultInfo](./dataforseo.client.models.responses.onpagesummaryresultinfo.md)

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

### **CrawlGatewayAddress**

crawler ip address
 <br>displays the IP address used by the crawler to initiate the current crawling session
 <br>you can find the full list of IPs used by our crawler in the Overview section

```csharp
public string CrawlGatewayAddress { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CrawlStopReason**

reason why the crawling stopped
 <br>information about the reason why the crawling process stopped;
 <br>possible values:
 <br>limit_exceeded – the limit set in the max_crawl_pages was exceeded;
 <br>empty_queue – all URLs in the queue were crawled;
 <br>force_stopped – the crawling process was halted using the On Page API Force Stop function;
 <br>unexpected_exception – an internal error was encountered while crawling the target, contact support for more info

```csharp
public string CrawlStopReason { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DomainInfo**

domain-wide info
 <br>on-page information about the target domain and crawling process

```csharp
public DomainInfo DomainInfo { get; set; }
```

#### Property Value

[DomainInfo](./dataforseo.client.models.domaininfo.md)<br>

### **PageMetrics**

page-specific info
 <br>metrics information on the target website pages

```csharp
public PageMetrics PageMetrics { get; set; }
```

#### Property Value

[PageMetrics](./dataforseo.client.models.pagemetrics.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageSummaryResultInfo()**

```csharp
public OnPageSummaryResultInfo()
```
