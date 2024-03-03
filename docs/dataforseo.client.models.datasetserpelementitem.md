# DatasetSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class DatasetSerpElementItem : BaseSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseSerpElementItem](./dataforseo.client.models.baseserpelementitem.md) → [DatasetSerpElementItem](./dataforseo.client.models.datasetserpelementitem.md)

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

### **DatasetId**

ID of the dataset

```csharp
public string DatasetId { get; set; }
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

### **ImageUrl**

URL of the image
 <br>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available)

```csharp
public string ImageUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ScholarlyCitationsCount**

count of articles that refer to the dataset

```csharp
public Nullable<long> ScholarlyCitationsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ScholarlyArticlesUrl**

url of scholarly articles
 <br>link to the list of scholarly articles on Google Scholar
 <br>example: https://scholar.google.com/scholar?q=%2210.6084%20m9%20figshare%207427933%20v1%22

```csharp
public string ScholarlyArticlesUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UniqueIdentifier**

digital identifier of an object
 <br>unique digital identifier of the dataset
 <br>example: https://doi.org/10.5061/dryad.hmgqnk9m3

```csharp
public string UniqueIdentifier { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RelatedArticle**

link to related article
 <br>link to the published article that is related to the dataset

```csharp
public string RelatedArticle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Links**

sitelinks
 <br>the links shown below some of Google Dataset’s search results
 <br>if there are none, equals null

```csharp
public ICollection<LinkElement> Links { get; set; }
```

#### Property Value

[ICollection&lt;LinkElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **DatasetProviders**

the list of institutions that provided the dataset

```csharp
public ICollection<LicensesElement> DatasetProviders { get; set; }
```

#### Property Value

[ICollection&lt;LicensesElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Formats**

the list of file formats of the dataset

```csharp
public ICollection<FormatsElement> Formats { get; set; }
```

#### Property Value

[ICollection&lt;FormatsElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Authors**

the list of authors of the dataset

```csharp
public ICollection<AuthorsElement> Authors { get; set; }
```

#### Property Value

[ICollection&lt;AuthorsElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Licenses**

the list of licenses issued to the dataset

```csharp
public ICollection<LicensesElement> Licenses { get; set; }
```

#### Property Value

[ICollection&lt;LicensesElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **UpdatedDate**

date and time when the result was last updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2022-11-27 02:00:00 +00:00

```csharp
public string UpdatedDate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AreaCovered**

the list of areas covered in the dataset
 <br>for example: Africa, Global

```csharp
public ICollection<string> AreaCovered { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **PeriodCovered**

period covered in the dataset

```csharp
public PeriodCovered PeriodCovered { get; set; }
```

#### Property Value

[PeriodCovered](./dataforseo.client.models.periodcovered.md)<br>

### **DatasetDescription**

description of the dataset

```csharp
public DatasetDescription DatasetDescription { get; set; }
```

#### Property Value

[DatasetDescription](./dataforseo.client.models.datasetdescription.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DatasetSerpElementItem()**

```csharp
public DatasetSerpElementItem()
```
