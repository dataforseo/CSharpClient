[`< Back`](./)

---

# HtmlResourceElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class HtmlResourceElementItem : BaseOnPageResourceItemInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseOnPageResourceItemInfo](./dataforseo.client.models.baseonpageresourceiteminfo) → [HtmlResourceElementItem](./dataforseo.client.models.htmlresourceelementitem)

## Properties

### **StatusCode**

status code of the page

```csharp
public Nullable<int> StatusCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Location**

location header
 <br>indicates the URL to redirect a page to

```csharp
public string Location { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

page URL

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Meta**

page properties
 <br>the value depends on the resource_type

```csharp
public PageMetaInfo Meta { get; set; }
```

#### Property Value

[PageMetaInfo](./dataforseo.client.models.pagemetainfo)<br>

### **PageTiming**

object of page load metrics

```csharp
public PageTiming PageTiming { get; set; }
```

#### Property Value

[PageTiming](./dataforseo.client.models.pagetiming)<br>

### **OnpageScore**

shows how page is optimized on a 100-point scale
 <br>this field shows how page is optimized considering critical on-page issues and warnings detected;
 <br>100 is the highest possible score that means the page does not have any critical on-page issues and important warnings;
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> OnpageScore { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TotalDomSize**

total DOM size of a page

```csharp
public Nullable<long> TotalDomSize { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CustomJsResponse**

the result of executing a specified JS script
 <br>note that you should specify a custom_js field when setting a task to receive this data and the field type and its value will totally depend on the script you specified;you can also filter the results by this value specifying filters in the following way:
 <br>["custom_js_response.url", "like", "pixel"]

```csharp
public object CustomJsResponse { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **ResourceErrors**

resource errors and warnings

```csharp
public OnPageResourceIssueInfo ResourceErrors { get; set; }
```

#### Property Value

[OnPageResourceIssueInfo](./dataforseo.client.models.onpageresourceissueinfo)<br>

### **BrokenResources**

indicates whether a page contains broken resources

```csharp
public Nullable<bool> BrokenResources { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrokenLinks**

indicates whether a page contains broken links

```csharp
public Nullable<bool> BrokenLinks { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DuplicateTitle**

indicates whether a page has duplicate title tags

```csharp
public Nullable<bool> DuplicateTitle { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DuplicateDescription**

indicates whether a page has a duplicate description

```csharp
public Nullable<bool> DuplicateDescription { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DuplicateContent**

indicates whether a page has duplicate content

```csharp
public Nullable<bool> DuplicateContent { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ClickDepth**

number of clicks it takes to get to the page
 <br>indicates the number of clicks from the homepage needed before landing at the target page

```csharp
public Nullable<int> ClickDepth { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Size**

resource size
 <br>indicates the size of a given page measured in bytes

```csharp
public Nullable<int> Size { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **EncodedSize**

page size after encoding
 <br>indicates the size of the encoded page measured in bytes

```csharp
public Nullable<int> EncodedSize { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TotalTransferSize**

compressed page size
 <br>indicates the compressed size of a given page

```csharp
public Nullable<long> TotalTransferSize { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FetchTime**

date and time when a resource was fetched
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string FetchTime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CacheControl**

instructions for caching

```csharp
public CacheControl CacheControl { get; set; }
```

#### Property Value

[CacheControl](./dataforseo.client.models.cachecontrol)<br>

### **Checks**

website checks
 <br>on-page check-ups related to the page

```csharp
public IDictionary<string, Nullable<bool>> Checks { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Boolean&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ContentEncoding**

type of encoding

```csharp
public string ContentEncoding { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MediaType**

types of media used to display a page

```csharp
public string MediaType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Server**

server version

```csharp
public string Server { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsResource**

indicates whether a page is a single resource

```csharp
public Nullable<bool> IsResource { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **UrlLength**

page URL length in characters

```csharp
public Nullable<int> UrlLength { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RelativeUrlLength**

relative URL length in characters

```csharp
public Nullable<int> RelativeUrlLength { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LastModified**

contains data on changes related to the resource
 <br>if there is no data, the value will be null

```csharp
public LastModified LastModified { get; set; }
```

#### Property Value

[LastModified](./dataforseo.client.models.lastmodified)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **HtmlResourceElementItem()**

```csharp
public HtmlResourceElementItem()
```

---

[`< Back`](./)
