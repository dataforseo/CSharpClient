[`< Back`](./)

---

# PeopleAlsoAskExpandedElement

Namespace: DataForSeo.Client.Models

```csharp
public class PeopleAlsoAskExpandedElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PeopleAlsoAskExpandedElement](./dataforseo.client.models.peoplealsoaskexpandedelement)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
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

### **Url**

URL

```csharp
public string Url { get; set; }
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

### **Title**

title of a given link element

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

description of the hotel booking element

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Images**

images of the element

```csharp
public ICollection<ImagesElement> Images { get; set; }
```

#### Property Value

[ICollection&lt;ImagesElement&gt;](./dataforseo.client.models.imageselement)<br>

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

results table
 <br>if there are none, equals null

```csharp
public Table Table { get; set; }
```

#### Property Value

[Table](./dataforseo.client.models.table)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **PeopleAlsoAskExpandedElement()**

```csharp
public PeopleAlsoAskExpandedElement()
```

---

[`< Back`](./)
