# AboutThisResultElement

Namespace: DataForSeo.Client.Models

```csharp
public class AboutThisResultElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AboutThisResultElement](./dataforseo.client.models.aboutthisresultelement.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

result’s URL

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Source**

source of additional information about the result

```csharp
public string Source { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SourceInfo**

additional information about the result
 <br>description of the website from Wikipedia or another additional context

```csharp
public string SourceInfo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SourceUrl**

URL to full information from the 'source'

```csharp
public string SourceUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Language**

the language of the result

```csharp
public string Language { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Location**

location for which the result is relevant

```csharp
public string Location { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SearchTerms**

matching search terms that appear in the result

```csharp
public ICollection<string> SearchTerms { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **RelatedTerms**

related search terms that appear in the result

```csharp
public ICollection<string> RelatedTerms { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AboutThisResultElement()**

```csharp
public AboutThisResultElement()
```
