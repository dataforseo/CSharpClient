[`< Back`](./)

---

# PageMetrics

Namespace: DataForSeo.Client.Models

```csharp
public class PageMetrics
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PageMetrics](./dataforseo.client.models.pagemetrics)

## Properties

### **LinksExternal**

number of external links
 <br>the number of links pointing to other websites

```csharp
public Nullable<int> LinksExternal { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LinksInternal**

number of internal links
 <br>the number of links pointing to other pages within the target website

```csharp
public Nullable<int> LinksInternal { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DuplicateTitle**

number of pages with duplicate titles

```csharp
public Nullable<int> DuplicateTitle { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DuplicateDescription**

number of pages with duplicate descriptions

```csharp
public Nullable<int> DuplicateDescription { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DuplicateContent**

number of pages with duplicate content

```csharp
public Nullable<int> DuplicateContent { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrokenLinks**

number of broken links
 <br>number of broken links across all crawled pages on a target website

```csharp
public Nullable<int> BrokenLinks { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrokenResources**

number of broken resources
 <br>the number of images and other resources with broken links

```csharp
public Nullable<int> BrokenResources { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LinksRelationConflict**

number of links present on the target website that may have a conflict
 <br>for example, if "links_relation_conflict": 2, the target website is referring to the same source by at least one internal link with the rel="nofollow" attribute and by at least one dofollow link

```csharp
public Nullable<int> LinksRelationConflict { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RedirectLoop**

number of redirect chains that start and end at the same URL
 <br>number of redirect chains where the destination URL redirects back to the original URL

```csharp
public Nullable<int> RedirectLoop { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OnpageScore**

shows how website is optimized on a 100-point scale
 <br>this field shows how website is optimized considering critical on-page issues and warnings detected;
 <br>100 is the highest possible score that means website does not have any critical on-page issues and important warnings;
 <br>note that this value depends on the number of crawled pages;
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> OnpageScore { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **NonIndexable**

number of non-indexable pages
 <br>number of pages that are blocked from being indexed by Google and other search engines by robots.txt, HTTP headers, or meta tags settings;
 <br>you can receive a list of non-indexable URLs using this endpoint

```csharp
public Nullable<int> NonIndexable { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Checks**

page-specific on-page check-ups

```csharp
public IDictionary<string, Nullable<long>> Checks { get; set; }
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

### **PageMetrics()**

```csharp
public PageMetrics()
```

---

[`< Back`](./)
