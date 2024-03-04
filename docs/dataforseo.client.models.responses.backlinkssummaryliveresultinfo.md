[`< Back`](./)

---

# BacklinksSummaryLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksSummaryLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksSummaryLiveResultInfo](./dataforseo.client.models.responses.backlinkssummaryliveresultinfo)

## Properties

### **Target**

target in a POST array

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FirstSeen**

date and time when our crawler found the backlink for the target for the first time
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string FirstSeen { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LostDate**

date and time when the backlink was lost
 <br>indicates the date and time when our crawler visited the target and it responded with a 4xx or 5xx status code or when its last backlink was removed
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string LostDate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rank**

target rank
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public Nullable<int> Rank { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Backlinks**

indicates the number of backlinks

```csharp
public Nullable<long> Backlinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BacklinksSpamScore**

spam score of the backlinks
 <br>displays the total spam score of all backlinks pointing to the target domain, subdomain, or webpage;
 <br>to learn more about how the metric is calculated, refer to this Help Center page

```csharp
public Nullable<long> BacklinksSpamScore { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CrawledPages**

number of crawled pages for the target

```csharp
public Nullable<int> CrawledPages { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Info**

information about the target

```csharp
public TargetInfo Info { get; set; }
```

#### Property Value

[TargetInfo](./dataforseo.client.models.targetinfo)<br>

### **InternalLinksCount**

number of internal links
 <br>calculated as the sum of internal links on the pages of the specified target

```csharp
public Nullable<long> InternalLinksCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ExternalLinksCount**

number of external links on the page
 <br>calculated as the sum of external links on the pages of the specified target

```csharp
public Nullable<long> ExternalLinksCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrokenBacklinks**

number of broken backlinks
 <br>number of broken backlinks pointing to the target

```csharp
public Nullable<long> BrokenBacklinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrokenPages**

number of broken pages
 <br>number of pages on the target that respond with 4xx or 5xx status codes
 <br>note that the number of broken pages includes pages on the target discovered by following external links, but it may also include pages discovered by following the target’s sitemap

```csharp
public Nullable<int> BrokenPages { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringDomains**

indicates the number of referring domains
 <br>referring domains include subdomains that are counted as separate domains for this metric

```csharp
public Nullable<long> ReferringDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringDomainsNofollow**

number of domains pointing at least one nofollow link to the target

```csharp
public Nullable<long> ReferringDomainsNofollow { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringMainDomains**

indicates the number of referring main domains

```csharp
public Nullable<long> ReferringMainDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringMainDomainsNofollow**

number of main domains pointing at least one nofollow link to the target

```csharp
public Nullable<long> ReferringMainDomainsNofollow { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringIps**

number of referring IP addresses
 <br>number of IP addresses pointing to this page

```csharp
public Nullable<long> ReferringIps { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringSubnets**

number of referring subnetworks

```csharp
public Nullable<long> ReferringSubnets { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringPages**

indicates the number of pages pointing to the target

```csharp
public Nullable<long> ReferringPages { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringLinksTld**

top-level domains of the referring links
 <br>contains top level domains and referring link count per each

```csharp
public IDictionary<string, Nullable<long>> ReferringLinksTld { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ReferringLinksTypes**

types of referring links
 <br>indicates the types of the referring links and link count per each type
 <br>possible values:
 <br>anchor, image, link, meta, canonical, alternate, redirect

```csharp
public IDictionary<string, Nullable<long>> ReferringLinksTypes { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ReferringLinksAttributes**

link attributes of the referring links
 <br>indicates link attributes of the referring links and link count per each attribute
 <br>example values:
 <br>nofollow, noopener, noreferrer, external, ugc, sponsored

```csharp
public IDictionary<string, Nullable<long>> ReferringLinksAttributes { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ReferringLinksPlatformTypes**

types of referring platforms
 <br>indicates referring platform types and and link count per each platform
 <br>example values:
 <br>cms, blogs, unknown, ecommerce, message-boards

```csharp
public IDictionary<string, Nullable<long>> ReferringLinksPlatformTypes { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ReferringLinksSemanticLocations**

semantic locations of the referring links
 <br>indicates semantic elements in HTML where the referring links are located and link count per each semantic location
 <br>you can get the full list of semantic elements here
 <br>example values:
 <br>article, section, summary, ""

```csharp
public IDictionary<string, Nullable<long>> ReferringLinksSemanticLocations { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ReferringLinksCountries**

ISO country codes of the referring links
 <br>indicates ISO country codes of the domains where the referring links are located and the link count per each country

```csharp
public IDictionary<string, Nullable<long>> ReferringLinksCountries { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksSummaryLiveResultInfo()**

```csharp
public BacklinksSummaryLiveResultInfo()
```

---

[`< Back`](./)
