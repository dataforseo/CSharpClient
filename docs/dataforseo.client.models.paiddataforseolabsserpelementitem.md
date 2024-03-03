# PaidDataforseoLabsSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class PaidDataforseoLabsSerpElementItem : BaseDataforseoLabsSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseDataforseoLabsSerpElementItem](./dataforseo.client.models.basedataforseolabsserpelementitem.md) → [PaidDataforseoLabsSerpElementItem](./dataforseo.client.models.paiddataforseolabsserpelementitem.md)

## Properties

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

### **Title**

title of the result in SERP

```csharp
public string Title { get; set; }
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

### **Description**

description of the results element in SERP

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Breadcrumb**

breadcrumb of the Ad element in SERP

```csharp
public string Breadcrumb { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL link

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Highlighted**

words highlighted in bold within the results description

```csharp
public ICollection<string> Highlighted { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Extra**

additional information about the result

```csharp
public IDictionary<string, string> Extra { get; set; }
```

#### Property Value

[IDictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **DescriptionRows**

extended description
 <br>if there is none, equals null

```csharp
public ICollection<string> DescriptionRows { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Links**

link of the element

```csharp
public ICollection<AdLinkElement> Links { get; set; }
```

#### Property Value

[ICollection&lt;AdLinkElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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
 <br>estimated organic monthly traffic to the domain
 <br>calculated as the product of CTR (click-through-rate) and search volume values of the returned keyword
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> Etv { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ImpressionsEtv**

estimated traffic volume based on impressions
 <br>estimated organic monthly traffic to the domain
 <br>calculated as the product of CTR (click-through-rate) and impressions values of the returned keyword
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> ImpressionsEtv { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **EstimatedPaidTrafficCost**

estimated cost of converting organic search traffic into paid
 <br>represents the estimated monthly cost of running ads for the returned keyword
 <br>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> EstimatedPaidTrafficCost { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RankChanges**

changes in rankings
 <br>ranking changes of the SERP element compared to the preceding month;
 <br>Note: the changes are calculated even if the preceding month is not included in a POST request

```csharp
public RankChanges RankChanges { get; set; }
```

#### Property Value

[RankChanges](./dataforseo.client.models.rankchanges.md)<br>

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **BacklinksInfo**

backlinks information for the target website

```csharp
public BacklinksInfo BacklinksInfo { get; set; }
```

#### Property Value

[BacklinksInfo](./dataforseo.client.models.backlinksinfo.md)<br>

### **RankInfo**

page and domain rank information

```csharp
public RankInfo RankInfo { get; set; }
```

#### Property Value

[RankInfo](./dataforseo.client.models.rankinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **PaidDataforseoLabsSerpElementItem()**

```csharp
public PaidDataforseoLabsSerpElementItem()
```
