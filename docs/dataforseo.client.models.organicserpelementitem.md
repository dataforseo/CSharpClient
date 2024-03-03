# OrganicSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class OrganicSerpElementItem : BaseSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseSerpElementItem](./dataforseo.client.models.baseserpelementitem.md) → [OrganicSerpElementItem](./dataforseo.client.models.organicserpelementitem.md)

## Properties

### **RankGroup**

group rank in SERP
 <br>position within a group of elements with identical type values
 <br>positions of elements with different type values are omitted from rank_group

```csharp
public Nullable<int> RankGroup { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RankAbsolute**

absolute rank in SERP
 <br>absolute position among all the elements in SERP

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

the alignment of the element in SERP
 <br>can take the following values:
 <br>left, right

```csharp
public string Position { get; set; }
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

title of the result in SERP

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

relevant URL in SERP

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

### **IsFeaturedSnippet**

indicates whether the element is a featured_snippet

```csharp
public Nullable<bool> IsFeaturedSnippet { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsMalicious**

indicates whether the element is marked as malicious

```csharp
public Nullable<bool> IsMalicious { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsWebStory**

indicates whether the element is marked as Google web story

```csharp
public Nullable<bool> IsWebStory { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Description**

description of the results element in SERP

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

[ICollection&lt;ImagesElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

### **Links**

sitelinks
 <br>the links shown below some of Google’s search results
 <br>if there are none, equals null

```csharp
public ICollection<LinkElement> Links { get; set; }
```

#### Property Value

[ICollection&lt;LinkElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Faq**

frequently asked questions
 <br>questions and answers extension shown below some of Google’s search results
 <br>if there are none, equals null

```csharp
public FaqBox Faq { get; set; }
```

#### Property Value

[FaqBox](./dataforseo.client.models.faqbox.md)<br>

### **ExtendedPeopleAlsoSearch**

extension of the organic element
 <br>extension of the organic result containing related search queries
 <br>Note: extension appears in SERP upon clicking on the result and then bouncing back to search results

```csharp
public ICollection<string> ExtendedPeopleAlsoSearch { get; set; }
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

### **RelatedResult**

related result from the same domain
 <br>related result from the same domain appears as a part of the main result snippet;
 <br>you can derive the related_result snippets as "type": "organic" results by setting the group_organic_results parameter to false in the POST request

```csharp
public ICollection<RelatedResult> RelatedResult { get; set; }
```

#### Property Value

[ICollection&lt;RelatedResult&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

### **Rectangle**

rectangle parameters
 <br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP
 <br>equals null if calculate_rectangles in the POST request is not set to true

```csharp
public Rectangle Rectangle { get; set; }
```

#### Property Value

[Rectangle](./dataforseo.client.models.rectangle.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OrganicSerpElementItem()**

```csharp
public OrganicSerpElementItem()
```
