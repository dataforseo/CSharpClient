[`< Back`](./)

---

# OrganicDataforseoLabsSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class OrganicDataforseoLabsSerpElementItem : BaseDataforseoLabsSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseDataforseoLabsSerpElementItem](./dataforseo.client.models.basedataforseolabsserpelementitem) → [OrganicDataforseoLabsSerpElementItem](./dataforseo.client.models.organicdataforseolabsserpelementitem)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RankGroup**

position within a group of elements with identical type values
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

subdomain in SERP

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

### **Breadcrumb**

breadcrumb in SERP

```csharp
public string Breadcrumb { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WebsiteName**

relevant website name in SERP

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

[RatingInfo](./dataforseo.client.models.ratinginfo)<br>

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

[ICollection&lt;LinkElement&gt;](./dataforseo.client.models.linkelement)<br>

### **AboutThisResult**

contains information from the ‘About this result’ panel
 <br>‘About this result’ panel provides additional context about why Google returned this result for the given query;
 <br>this feature appears after clicking on the three dots next to most results

```csharp
public AboutThisResultElement AboutThisResult { get; set; }
```

#### Property Value

[AboutThisResultElement](./dataforseo.client.models.aboutthisresultelement)<br>

### **MainDomain**

primary domain name in SERP

```csharp
public string MainDomain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RelativeUrl**

URL in SERP that does not specify the HTTPs protocol and domain name

```csharp
public string RelativeUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Etv**

estimated traffic volume
 <br>estimated paid monthly traffic to the domain
 <br>calculated as the product of CTR (click-through-rate) and search volume values of all keywords in the category that the domain ranks for
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> Etv { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ImpressionsEtv**

estimated traffic volume based on impressions
 <br>estimated paid monthly traffic to the domain
 <br>calculated as the product of CTR (click-through-rate) and impressions values of all keywords in the category that the domain ranks for
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> ImpressionsEtv { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **EstimatedPaidTrafficCost**

estimated cost of monthly search traffic
 <br>represents the estimated cost of paid monthly traffic (USD) based on etv and cpc values of all keywords in the category that the domain ranks for
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> EstimatedPaidTrafficCost { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RankChanges**

changes in rankings
 <br>contains information about the ranking changes of the SERP element since the previous_updated_time

```csharp
public RankChanges RankChanges { get; set; }
```

#### Property Value

[RankChanges](./dataforseo.client.models.rankchanges)<br>

### **BacklinksInfo**

backlinks information for the target website

```csharp
public BacklinksInfo BacklinksInfo { get; set; }
```

#### Property Value

[BacklinksInfo](./dataforseo.client.models.backlinksinfo)<br>

### **RankInfo**

page and domain rank information

```csharp
public RankInfo RankInfo { get; set; }
```

#### Property Value

[RankInfo](./dataforseo.client.models.rankinfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OrganicDataforseoLabsSerpElementItem()**

```csharp
public OrganicDataforseoLabsSerpElementItem()
```

---

[`< Back`](./)
