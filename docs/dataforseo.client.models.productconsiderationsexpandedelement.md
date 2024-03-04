# ProductConsiderationsExpandedElement

Namespace: DataForSeo.Client.Models

```csharp
public class ProductConsiderationsExpandedElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ProductConsiderationsExpandedElement](./dataforseo.client.models.productconsiderationsexpandedelement.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of a given link element

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

### **Breadcrumb**

breadcrumb of the Ad element in SERP

```csharp
public string Breadcrumb { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Snippet**

text alongside the link title

```csharp
public string Snippet { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

website domain

```csharp
public string Domain { get; set; }
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

### **RelatedSearches**

search queries related to the elment

```csharp
public ICollection<string> RelatedSearches { get; set; }
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

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ProductConsiderationsExpandedElement()**

```csharp
public ProductConsiderationsExpandedElement()
```
