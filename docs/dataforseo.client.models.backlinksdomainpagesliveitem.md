# BacklinksDomainPagesLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksDomainPagesLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksDomainPagesLiveItem](./dataforseo.client.models.backlinksdomainpagesliveitem.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MainDomain**

main website domain
 <br>main website domain does not include subdomains

```csharp
public string MainDomain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

domain
 <br>domain where the page was found

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Tld**

top-level domain
 <br>top-level domain in the DNS root zone

```csharp
public string Tld { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Page**

page URL
 <br>relevant page URL

```csharp
public string Page { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Ip**

Internet Protocol address

```csharp
public string Ip { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FirstVisited**

date and time of the first page visit
 <br>date and time when our crawler visited this page for the first time
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2017-01-24 13:20:59 +00:00

```csharp
public string FirstVisited { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PrevVisited**

previous to the most recent date when our crawler visited the page
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2017-01-24 13:20:59 +00:00

```csharp
public string PrevVisited { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FetchTime**

most recent date and time when our crawler visited the page
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2017-01-24 13:20:59 +00:00

```csharp
public string FetchTime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **StatusCode**

HTTP status code of the page

```csharp
public Nullable<int> StatusCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Location**

location header
 <br>indicates the URL to redirect a page to if exists

```csharp
public string Location { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Size**

indicates the page size, in bytes

```csharp
public Nullable<int> Size { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **EncodedSize**

page size after encoding
 <br>indicates the size of the encoded page, in bytes

```csharp
public Nullable<int> EncodedSize { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

### **Meta**

page meta data

```csharp
public BacklinksPageMeta Meta { get; set; }
```

#### Property Value

[BacklinksPageMeta](./dataforseo.client.models.backlinkspagemeta.md)<br>

### **PageSummary**

contains backlink data for this page

```csharp
public PageSummary PageSummary { get; set; }
```

#### Property Value

[PageSummary](./dataforseo.client.models.pagesummary.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksDomainPagesLiveItem()**

```csharp
public BacklinksDomainPagesLiveItem()
```
