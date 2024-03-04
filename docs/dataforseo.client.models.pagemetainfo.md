# PageMetaInfo

Namespace: DataForSeo.Client.Models

```csharp
public class PageMetaInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PageMetaInfo](./dataforseo.client.models.pagemetainfo.md)

## Properties

### **Title**

page title

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Charset**

code page
 <br>example: 65001

```csharp
public Nullable<int> Charset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Follow**

indicates whether a page’s ‘meta robots’ allows crawlers to follow the links on the page
 <br>if false, the page’s ‘meta robots’ tag contains “nofollow” parameter instructing crawlers not to follow the links on the page

```csharp
public Nullable<bool> Follow { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Generator**

meta tag generator

```csharp
public string Generator { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Htags**

HTML header tags

```csharp
public IDictionary<string, ICollection<string>> Htags { get; set; }
```

#### Property Value

[IDictionary&lt;String, ICollection&lt;String&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **Description**

content of the meta description tag

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Favicon**

favicon of the page

```csharp
public string Favicon { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MetaKeywords**

content of the keywords meta tag

```csharp
public string MetaKeywords { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Canonical**

canonical page

```csharp
public string Canonical { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **InternalLinksCount**

number of internal links on the page

```csharp
public Nullable<long> InternalLinksCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ExternalLinksCount**

number of external links on the page

```csharp
public Nullable<long> ExternalLinksCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **InboundLinksCount**

number of internal links pointing at the page

```csharp
public Nullable<long> InboundLinksCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ImagesCount**

number of images on the page

```csharp
public Nullable<long> ImagesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ImagesSize**

total size of images on the page measured in bytes

```csharp
public Nullable<int> ImagesSize { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ScriptsCount**

number of scripts on the page

```csharp
public Nullable<long> ScriptsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ScriptsSize**

total size of scripts on the page measured in bytes

```csharp
public Nullable<int> ScriptsSize { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **StylesheetsCount**

number of stylesheets on the page

```csharp
public Nullable<long> StylesheetsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **StylesheetsSize**

total size of stylesheets on the page measured in bytes

```csharp
public Nullable<int> StylesheetsSize { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TitleLength**

length of the title tag in characters

```csharp
public Nullable<int> TitleLength { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DescriptionLength**

length of the description tag in characters

```csharp
public Nullable<int> DescriptionLength { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RenderBlockingScriptsCount**

number of scripts on the page that block page rendering

```csharp
public Nullable<long> RenderBlockingScriptsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RenderBlockingStylesheetsCount**

number of CSS styles on the page that block page rendering

```csharp
public Nullable<long> RenderBlockingStylesheetsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CumulativeLayoutShift**

Core Web Vitals metric measuring the layout stability of the page
 <br>measures the sum total of all individual layout shift scores for every unexpected layout shift that occurs during the entire lifespan of the page. Learn more.

```csharp
public Nullable<float> CumulativeLayoutShift { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MetaTitle**

meta title of the page
 <br>meta tag in the head section of an HTML document that defines the title of a page

```csharp
public string MetaTitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Content**

overall information about content of the page

```csharp
public HtmlContentInfo Content { get; set; }
```

#### Property Value

[HtmlContentInfo](./dataforseo.client.models.htmlcontentinfo.md)<br>

### **DeprecatedTags**

deprecated tags on the page

```csharp
public ICollection<string> DeprecatedTags { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **DuplicateMetaTags**

duplicate meta tags on the page

```csharp
public ICollection<string> DuplicateMetaTags { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Spell**

autocorrection of the search engine
 <br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection

```csharp
public SpellInfo Spell { get; set; }
```

#### Property Value

[SpellInfo](./dataforseo.client.models.spellinfo.md)<br>

### **SocialMediaTags**

object of social media tags found on the page
 <br>contains social media tags and their content
 <br>supported tags include but are not limited to Open Graph and Twitter card

```csharp
public IDictionary<string, string> SocialMediaTags { get; set; }
```

#### Property Value

[IDictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **BrokenHtml**

resource errors and warnings

```csharp
public OnPageResourceIssueInfo BrokenHtml { get; set; }
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

### **PageMetaInfo()**

```csharp
public PageMetaInfo()
```
