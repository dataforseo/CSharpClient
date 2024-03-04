# RelatedResult

Namespace: DataForSeo.Client.Models

```csharp
public class RelatedResult
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RelatedResult](./dataforseo.client.models.relatedresult.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Xpath**

the XPath of the element

```csharp
public string Xpath { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

domain where a link points

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the element

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CacheUrl**

cached version of the page

```csharp
public string CacheUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RelatedSearchUrl**

URL to a similar search
 <br>URL to a new search for the same keyword(s) on related sites

```csharp
public string RelatedSearchUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Breadcrumb**

breadcrumb in SERP

```csharp
public string Breadcrumb { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WebsiteName**

name of the website in SERP

```csharp
public string WebsiteName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsImage**

indicates whether the element contains an image

```csharp
public Nullable<bool> IsImage { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsVideo**

indicates whether the element contains a video

```csharp
public Nullable<bool> IsVideo { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Description**

description

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PreSnippet**

includes additional information appended before the result description in SERP

```csharp
public string PreSnippet { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ExtendedSnippet**

includes additional information appended after the result description in SERP

```csharp
public string ExtendedSnippet { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Images**

images of the element

```csharp
public ICollection<ImagesElement> Images { get; set; }
```

#### Property Value

[ICollection&lt;ImagesElement&gt;](./dataforseo.client.models.imageselement.md)<br>

### **AmpVersion**

Accelerated Mobile Pages
 <br>indicates whether an item has the Accelerated Mobile Page (AMP) version

```csharp
public Nullable<bool> AmpVersion { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rating**

the item’s rating 
 <br>the popularity rate based on reviews and displayed in SERP

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo.md)<br>

### **Price**

pricing details
 <br>contains the pricing details of the product or service featured in the result

```csharp
public PriceInfo Price { get; set; }
```

#### Property Value

[PriceInfo](./dataforseo.client.models.priceinfo.md)<br>

### **Highlighted**

words highlighted in bold within the results description

```csharp
public ICollection<string> Highlighted { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AboutThisResult**

contains information from the ‘About this result’ panel
 <br>‘About this result’ panel provides additional context about why Google returned this result for the given query;
 <br>this feature appears after clicking on the three dots next to most results

```csharp
public AboutThisResultElement AboutThisResult { get; set; }
```

#### Property Value

[AboutThisResultElement](./dataforseo.client.models.aboutthisresultelement.md)<br>

### **Timestamp**

date and time when the result was published
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Timestamp { get; set; }
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

### **RelatedResult()**

```csharp
public RelatedResult()
```
