# ImageResourceElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class ImageResourceElementItem : BaseOnPageResourceItemInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseOnPageResourceItemInfo](./dataforseo.client.models.baseonpageresourceiteminfo.md) → [ImageResourceElementItem](./dataforseo.client.models.imageresourceelementitem.md)

## Properties

### **Meta**

resource properties
 <br>the value depends on the resource_type
 <br>note that if you do not indicate a url when setting a task, resource’s meta is returned based on the data from the page where our crawler first saw the resource;
 <br>to obtain resource’s meta from a particular url, specify that URL when setting a task

```csharp
public ResourceMetaInfo Meta { get; set; }
```

#### Property Value

[ResourceMetaInfo](./dataforseo.client.models.resourcemetainfo.md)<br>

### **StatusCode**

status code of the page where a given resource is located

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

resource URL

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Size**

resource size
 <br>indicates the size of a given resource measured in bytes

```csharp
public Nullable<int> Size { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **EncodedSize**

resource size after encoding
 <br>indicates the size of the encoded resource measured in bytes

```csharp
public Nullable<int> EncodedSize { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TotalTransferSize**

compressed resource size
 <br>indicates the compressed size of a given resource in bytes

```csharp
public Nullable<long> TotalTransferSize { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FetchTime**

date and time when a resource was fetched
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2021-02-17 13:54:15 +00:00

```csharp
public string FetchTime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FetchTiming**

resource fething time range

```csharp
public FetchTiming FetchTiming { get; set; }
```

#### Property Value

[FetchTiming](./dataforseo.client.models.fetchtiming.md)<br>

### **CacheControl**

instructions for caching

```csharp
public CacheControl CacheControl { get; set; }
```

#### Property Value

[CacheControl](./dataforseo.client.models.cachecontrol.md)<br>

### **Checks**

resource check-ups
 <br>contents of the array depend on the resource_type

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

types of media used to display a resource

```csharp
public string MediaType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AcceptType**

indicates the expected type of resource
 <br>for example, if "resource_type": "broken", accept_type will indicate the type of the broken resource
 <br>possible values:
 <br>any, none, image, sitemap, robots, script, stylesheet, redirect, html, text, other, font

```csharp
public string AcceptType { get; set; }
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

### **LastModified**

contains data on changes related to the resource
 <br>if there is no data, the value will be null

```csharp
public LastModified LastModified { get; set; }
```

#### Property Value

[LastModified](./dataforseo.client.models.lastmodified.md)<br>

### **ResourceErrors**

resource errors and warnings

```csharp
public OnPageResourceIssueInfo ResourceErrors { get; set; }
```

#### Property Value

[OnPageResourceIssueInfo](./dataforseo.client.models.onpageresourceissueinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ImageResourceElementItem()**

```csharp
public ImageResourceElementItem()
```
