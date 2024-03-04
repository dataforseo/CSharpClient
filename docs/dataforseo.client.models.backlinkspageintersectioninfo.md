# BacklinksPageIntersectionInfo

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksPageIntersectionInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksPageIntersectionInfo](./dataforseo.client.models.backlinkspageintersectioninfo.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DomainFrom**

domain referring to the target domain or webpage

```csharp
public string DomainFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UrlFrom**

URL of the page where the backlink is found

```csharp
public string UrlFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UrlFromHttps**

indicates whether the referring URL is secured with HTTPS
 <br>if true, the referring URL is secured with HTTPS

```csharp
public Nullable<bool> UrlFromHttps { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DomainTo**

domain the backlink is pointing to

```csharp
public string DomainTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UrlTo**

URL the backlink is pointing to

```csharp
public string UrlTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UrlToHttps**

indicates if the URL the backlink is pointing to is secured with HTTPS
 <br>if true, the URL is secured with HTTPS

```csharp
public Nullable<bool> UrlToHttps { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TldFrom**

top-level domain of the referring URL

```csharp
public string TldFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsNew**

indicates whether the backlink is new
 <br>if true, the backlink was found on the page last time our crawler visited it

```csharp
public Nullable<bool> IsNew { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsLost**

indicates whether the backlink was removed
 <br>if true, the backlink or the entire page was removed

```csharp
public Nullable<bool> IsLost { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BacklinkSpamScore**

spam score of the backlink
 <br>learn more about how the metric is calculated on this help center page

```csharp
public Nullable<int> BacklinkSpamScore { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rank**

backlink rank
 <br>rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public Nullable<int> Rank { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PageFromRank**

page rank of the referring page
 <br>page_from_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public Nullable<int> PageFromRank { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DomainFromRank**

domain rank of the referring domain
 <br>domain_from_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public Nullable<int> DomainFromRank { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DomainFromPlatformType**

platform types of the referring domain
 <br>example:
 <br>"cms",
 <br>"blogs"

```csharp
public ICollection<string> DomainFromPlatformType { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **DomainFromIsIp**

indicates if the domain is IP
 <br>if true, the domain functions as an IP address and does not have a domain name

```csharp
public Nullable<bool> DomainFromIsIp { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DomainFromIp**

IP address of the referring domain

```csharp
public string DomainFromIp { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DomainFromCountry**

ISO country code of the referring domain

```csharp
public string DomainFromCountry { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageFromExternalLinks**

number of external links found on the referring page

```csharp
public Nullable<int> PageFromExternalLinks { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PageFromInternalLinks**

number of internal links found on the referring page

```csharp
public Nullable<int> PageFromInternalLinks { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PageFromSize**

size of the referring page, in bytes
 <br>example:
 <br>63357

```csharp
public Nullable<int> PageFromSize { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PageFromEncoding**

character encoding of the referring page
 <br>example:
 <br>utf-8

```csharp
public string PageFromEncoding { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageFromLanguage**

language of the referring page
 <br>in ISO 639-1 format
 <br>example:
 <br>en

```csharp
public string PageFromLanguage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageFromTitle**

title of the referring page

```csharp
public string PageFromTitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageFromStatusCode**

HTTP status code returned by the referring page
 <br>example:
 <br>200

```csharp
public Nullable<int> PageFromStatusCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FirstSeen**

date and time when our crawler found the backlink for the first time
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string FirstSeen { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PrevSeen**

previous to the most recent date when our crawler visited the backlink
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string PrevSeen { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LastSeen**

most recent date when our crawler visited the backlink
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string LastSeen { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ItemType**

link type
 <br>possible values:
 <br>anchor, image, link, meta, canonical, alternate, redirect

```csharp
public string ItemType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Attributes**

link attributes of the referring links
 <br>example:
 <br>nofollow

```csharp
public ICollection<string> Attributes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Dofollow**

indicates whether the backlink is dofollow
 <br>if false, the backlink is nofollow

```csharp
public Nullable<bool> Dofollow { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Original**

indicates whether the backlink was present on the referring page when our crawler first visited it

```csharp
public Nullable<bool> Original { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Alt**

alternative text of the image
 <br>this field will be null if backlink type is not image

```csharp
public string Alt { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Anchor**

anchor text of the backlink

```csharp
public string Anchor { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TextPre**

text snippet before the anchor text

```csharp
public string TextPre { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TextPost**

snippet after the anchor text

```csharp
public string TextPost { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SemanticLocation**

indicates semantic element in HTML where the backlink is found
 <br>you can get the full list of semantic elements here
 <br>examples:
 <br>article, section, summary

```csharp
public string SemanticLocation { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LinksCount**

number of identical backlinks found on the referring page

```csharp
public Nullable<long> LinksCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **GroupCount**

indicates total number of backlinks from this domain
 <br>for example, if mode is set to one_per_domain, this field will indicate the total number of backlinks coming from this domain

```csharp
public Nullable<long> GroupCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsBroken**

indicates whether the backlink is broken
 <br>if true, the backlink is pointing to a page responding with a 4xx or 5xx status code

```csharp
public Nullable<bool> IsBroken { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **UrlToStatusCode**

status code of the referenced page
 <br>if the value is null, our crawler hasn’t yet visited the webpage the link is pointing to
 <br>example:
 <br>200

```csharp
public Nullable<int> UrlToStatusCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **UrlToSpamScore**

spam score of the referenced page
 <br>if the value is null, our crawler hasn’t yet visited the webpage the link is pointing to
 <br>learn more about how the metric is calculated on this help center page

```csharp
public Nullable<int> UrlToSpamScore { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **UrlToRedirectTarget**

target url of the redirect
 <br>target page the redirect is pointing to

```csharp
public string UrlToRedirectTarget { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsIndirectLink**

indicates whether the backlink is an indirect link
 <br>if true, the backlink is an indirect link pointing to a page that either redirects to url_to, or points to a canonical page

```csharp
public Nullable<bool> IsIndirectLink { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IndirectLinkPath**

indirect link path
 <br>indicates a URL or a sequence of URLs that lead to url_to

```csharp
public ICollection<Redirect> IndirectLinkPath { get; set; }
```

#### Property Value

[ICollection&lt;Redirect&gt;](./dataforseo.client.models.redirect.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksPageIntersectionInfo()**

```csharp
public BacklinksPageIntersectionInfo()
```
