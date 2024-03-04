[`< Back`](./)

---

# BacklinksPageMeta

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksPageMeta
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksPageMeta](./dataforseo.client.models.backlinkspagemeta)

## Properties

### **Title**

page title

```csharp
public string Title { get; set; }
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

### **ImagesCount**

number of images on the page

```csharp
public Nullable<long> ImagesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **WordsCount**

number of words on the page

```csharp
public Nullable<long> WordsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PageSpamScore**

spam score of the page
 <br>learn more about how the metric is calculated on this help center page

```csharp
public Nullable<int> PageSpamScore { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SocialMediaTags**

array of social media tags found on the page
 <br>contains social media tags and their content
 <br>supported tags include but are not limited to Open Graph and Twitter card

```csharp
public IDictionary<string, string> SocialMediaTags { get; set; }
```

#### Property Value

[IDictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **H1**

h1 tag
 <br>content of h1 tags

```csharp
public ICollection<string> H1 { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **H2**

h2 tag
 <br>content of h2 tags

```csharp
public ICollection<string> H2 { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **H3**

h3 tag
 <br>content of h3 tags

```csharp
public ICollection<string> H3 { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **ImagesAlt**

content of alt tags

```csharp
public ICollection<string> ImagesAlt { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **PoweredBy**

CMS details

```csharp
public ICollection<string> PoweredBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Language**

page content language
 <br>example:
 <br>en

```csharp
public string Language { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Charset**

character encoding
 <br>examples:
 <br>utf-8

```csharp
public string Charset { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PlatformType**

type of a platform

```csharp
public ICollection<string> PlatformType { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Technologies**

website technologies

```csharp
public IDictionary<string, string> Technologies { get; set; }
```

#### Property Value

[IDictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksPageMeta()**

```csharp
public BacklinksPageMeta()
```

---

[`< Back`](./)
