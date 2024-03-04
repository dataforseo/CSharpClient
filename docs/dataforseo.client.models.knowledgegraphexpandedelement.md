# KnowledgeGraphExpandedElement

Namespace: DataForSeo.Client.Models

```csharp
public class KnowledgeGraphExpandedElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KnowledgeGraphExpandedElement](./dataforseo.client.models.knowledgegraphexpandedelement.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FeaturedTitle**

title of a given element

```csharp
public string FeaturedTitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

relevant URL

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

domain in SERP

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

### **Snippet**

text alongside the link title

```csharp
public string Snippet { get; set; }
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

### **Table**

table element

```csharp
public Table Table { get; set; }
```

#### Property Value

[Table](./dataforseo.client.models.table.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KnowledgeGraphExpandedElement()**

```csharp
public KnowledgeGraphExpandedElement()
```
