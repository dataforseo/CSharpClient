[`< Back`](./)

---

# FeaturedSnippetDataforseoLabsSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class FeaturedSnippetDataforseoLabsSerpElementItem : BaseDataforseoLabsSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseDataforseoLabsSerpElementItem](./dataforseo.client.models.basedataforseolabsserpelementitem) → [FeaturedSnippetDataforseoLabsSerpElementItem](./dataforseo.client.models.featuredsnippetdataforseolabsserpelementitem)

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

### **FeaturedTitle**

the title of the featured snippets source page

```csharp
public string FeaturedTitle { get; set; }
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

### **Url**

relevant URL in SERP

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Table**

results table
 <br>if there are none, equals null

```csharp
public object Table { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

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
public AvgBacklinksInfo BacklinksInfo { get; set; }
```

#### Property Value

[AvgBacklinksInfo](./dataforseo.client.models.avgbacklinksinfo)<br>

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

### **FeaturedSnippetDataforseoLabsSerpElementItem()**

```csharp
public FeaturedSnippetDataforseoLabsSerpElementItem()
```

---

[`< Back`](./)
