# HtmlItem

Namespace: DataForSeo.Client.Models

```csharp
public class HtmlItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [HtmlItem](./dataforseo.client.models.htmlitem.md)

## Properties

### **Page**

serial number of the returned HTML page

```csharp
public Nullable<int> Page { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Date**

date and time when the HTML page was scanned
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Date { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Html**

HTML page

```csharp
public string Html { get; set; }
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

### **HtmlItem()**

```csharp
public HtmlItem()
```
