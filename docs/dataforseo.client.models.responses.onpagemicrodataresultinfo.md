# OnPageMicrodataResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class OnPageMicrodataResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageMicrodataResultInfo](./dataforseo.client.models.responses.onpagemicrodataresultinfo.md)

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

### **TestSummary**

microdata validation test results

```csharp
public TestSummary TestSummary { get; set; }
```

#### Property Value

[TestSummary](./dataforseo.client.models.testsummary.md)<br>

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
public ICollection<OnPageMicrodataItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;OnPageMicrodataItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageMicrodataResultInfo()**

```csharp
public OnPageMicrodataResultInfo()
```
