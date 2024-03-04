[`< Back`](./)

---

# OnPageDuplicateTagsResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class OnPageDuplicateTagsResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageDuplicateTagsResultInfo](./dataforseo.client.models.responses.onpageduplicatetagsresultinfo)

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

### **TotalPagesCount**

total number of pages with duplicate tags
 <br>displays the total number of pages with duplicate tags of the target website

```csharp
public Nullable<long> TotalPagesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PagesCount**

number of pages with duplicate tags in the response
 <br>displays the number of pages with duplicate tags returned in the response

```csharp
public Nullable<long> PagesCount { get; set; }
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
public ICollection<OnPageDuplicateTagsItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;OnPageDuplicateTagsItem&gt;](./dataforseo.client.models.onpageduplicatetagsitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageDuplicateTagsResultInfo()**

```csharp
public OnPageDuplicateTagsResultInfo()
```

---

[`< Back`](./)
