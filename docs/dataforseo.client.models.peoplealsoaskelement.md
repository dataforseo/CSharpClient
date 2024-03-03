# PeopleAlsoAskElement

Namespace: DataForSeo.Client.Models

```csharp
public class PeopleAlsoAskElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PeopleAlsoAskElement](./dataforseo.client.models.peoplealsoaskelement.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the row

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeedQuestion**

question that triggered additional expanded elements

```csharp
public string SeedQuestion { get; set; }
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

### **ExpandedElement**

expanded element

```csharp
public ICollection<PeopleAlsoAskExpandedElement> ExpandedElement { get; set; }
```

#### Property Value

[ICollection&lt;PeopleAlsoAskExpandedElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **PeopleAlsoAskElement()**

```csharp
public PeopleAlsoAskElement()
```
