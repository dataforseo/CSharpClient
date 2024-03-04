[`< Back`](./)

---

# StoresCountInfo

Namespace: DataForSeo.Client.Models

```csharp
public class StoresCountInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [StoresCountInfo](./dataforseo.client.models.storescountinfo)

## Properties

### **Count**

number of stores that offer the product

```csharp
public string Count { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DisplayedText**

text displayed on the Google Shopping page

```csharp
public string DisplayedText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CountFromText**

whether the number of stores is taken from text
 <br>indicates whether the number of stores is taken from displayed_text;
 <br>if the API finds the exact number of stores in the HTML code of the Google Shopping page, this parameter is false;
 <br>if the API cannot find the number of stores in the HTML code of the page, it takes the number from the displayed_text;
 <br>in this case, the parameter is true

```csharp
public Nullable<bool> CountFromText { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **StoresCountInfo()**

```csharp
public StoresCountInfo()
```

---

[`< Back`](./)
