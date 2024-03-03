# OnPageInstantPagesResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class OnPageInstantPagesResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageInstantPagesResultInfo](./dataforseo.client.models.responses.onpageinstantpagesresultinfo.md)

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
 <br>in this case the value will be null

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

[ICollection&lt;BaseOnPageResourceItemInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageInstantPagesResultInfo()**

```csharp
public OnPageInstantPagesResultInfo()
```
