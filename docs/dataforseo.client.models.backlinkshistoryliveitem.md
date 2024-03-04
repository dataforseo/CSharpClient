# BacklinksHistoryLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksHistoryLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksHistoryLiveItem](./dataforseo.client.models.backlinkshistoryliveitem.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Date**

date and time when the data for the target was stored
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Date { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rank**

domain rank on the given date
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public Nullable<int> Rank { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Backlinks**

number of backlinks

```csharp
public Nullable<long> Backlinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **NewBacklinks**

number of new backlinks for the target
 <br>data is provided based in a comparison with the previous period
 <br>Note: this data is available from May 2021;
 <br>if the date range specified in the POST request preceds May 2021, the field will equal 0

```csharp
public Nullable<long> NewBacklinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LostBacklinks**

number of lost backlinks for the target
 <br>data is provided based in a comparison with the previous period
 <br>Note: this data is available from May 2021;
 <br>if the date range specified in the POST request preceds May 2021, the field will equal 0

```csharp
public Nullable<long> LostBacklinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **NewReferringDomains**

number of new referring domains for the target
 <br>data is provided based in a comparison with the previous period
 <br>Note: this data is available from May 2021;
 <br>if the date range specified in the POST request preceds May 2021, the field will equal 0

```csharp
public Nullable<long> NewReferringDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LostReferringDomains**

number of lost referring domains for the target
 <br>data is provided based in a comparison with the previous period
 <br>Note: this data is available from May 2021;
 <br>if the date range specified in the POST request preceds May 2021, the field will equal 0

```csharp
public Nullable<long> LostReferringDomains { get; set; }
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

[TargetInfo](./dataforseo.client.models.targetinfo.md)<br>

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
 <br>number of pages that receive backlinks but respond with 4xx or 5xx status codes

```csharp
public Nullable<int> BrokenPages { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringDomains**

number of referring domains
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

number of referring main domains

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

number of pages pointing to the target

```csharp
public Nullable<long> ReferringPages { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringLinksTld**

top-level domains of the referring links
 <br>contains top-level domains and referring link count per each

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

```csharp
public IDictionary<string, Nullable<long>> ReferringLinksAttributes { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ReferringLinksPlatformTypes**

types of referring platforms
 <br>indicates referring platform types and and link count per each platform

```csharp
public IDictionary<string, Nullable<long>> ReferringLinksPlatformTypes { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ReferringLinksSemanticLocations**

semantic locations of the referring links
 <br>indicates semantic elements in HTML where the referring links are located and link count per each semantic location
 <br>you can get the full list of semantic elements here
 <br>examples:
 <br>article, section, summary

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

### **BacklinksHistoryLiveItem()**

```csharp
public BacklinksHistoryLiveItem()
```
