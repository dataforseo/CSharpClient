# DomainInfo

Namespace: DataForSeo.Client.Models

```csharp
public class DomainInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainInfo](./dataforseo.client.models.domaininfo.md)

## Properties

### **Name**

domain name

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Cms**

content management system
 <br>content management system identified on a website
 <br>the content of the generator meta tag
 <br>the data is taken from the first random page that returns the 200 response code
 <br>if our crawler was unable to identify the cms, the value would be null

```csharp
public string Cms { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Ip**

domain ip address

```csharp
public string Ip { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Server**

website server
 <br>the version of the server detected on a website
 <br>the content of the server header
 <br>the information is taken from the first page which response code is 200

```csharp
public string Server { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CrawlStart**

time when the crawling start
 <br>date and time when the website was sent for crawling
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string CrawlStart { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CrawlEnd**

time when the crawling ended
 <br>date and time when the crawling was finished
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00note: informative only if "crawl_progress" is "finished"
 <br>if "crawl_progress" is in_progress, the value will be null

```csharp
public string CrawlEnd { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ExtendedCrawlStatus**

crawl status and errors
 <br>indicates the reason why a website was not crawledcan take the following values:
 <br>no_errors – no crawling errors were detected;
 <br>site_unreachable – our crawler could not reach a website and thus was not able to obtain a status code;
 <br>invalid_page_status_code – status code of the first crawled page &gt;= 400;
 <br>forbidden_meta_tag – the first crawled page contains the &lt;meta robots=”noindex”&gt; tag;
 <br>forbidden_robots – robots.txt forbids crawling the page;
 <br>forbidden_http_header – HTTP header of the page contains “X-Robots-Tag: noindex” ;
 <br>too_many_redirects – the first crawled page has more than 10 redirects;
 <br>unknown – the reason is unknown

```csharp
public string ExtendedCrawlStatus { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SslInfo**

ssl certificate info
 <br>information about the Secure Sockets Layer protocol detected on a website

```csharp
public SslInfo SslInfo { get; set; }
```

#### Property Value

[SslInfo](./dataforseo.client.models.sslinfo.md)<br>

### **Checks**

website checks
 <br>other on-page check-ups related to the website

```csharp
public IDictionary<string, Nullable<bool>> Checks { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Boolean&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **TotalPages**

total crawled pages
 <br>the total number of crawled pages

```csharp
public Nullable<long> TotalPages { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PageNotFoundStatusCode**

status code returned by a non-existent page
 <br>in most cases, it is recommended a server returns a 404 response code

```csharp
public Nullable<int> PageNotFoundStatusCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CanonicalizationStatusCode**

status code returned by a canonicalized page
 <br>the checkup of the server behavior when our crawler tries to access the website via IP;
 <br>in most cases, it is recommended that canonicalized pages respond with a 301 or 302 status code

```csharp
public Nullable<int> CanonicalizationStatusCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DirectoryBrowsingStatusCode**

status code returned by a directory
 <br>the status code returned by a directory page on a target website
 <br>in most cases, it is recommended that directories respond with a 403 or 401 status code

```csharp
public Nullable<int> DirectoryBrowsingStatusCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **WwwRedirectStatusCode**

redirect status code
 <br>the status code of the www to non-www redirect
 <br>in most cases, it is recommended that redirect returns a 301 status code

```csharp
public Nullable<int> WwwRedirectStatusCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MainDomain**

root domain name

```csharp
public string MainDomain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DomainInfo()**

```csharp
public DomainInfo()
```
