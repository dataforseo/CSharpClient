[`< Back`](./)

---

# OnPageKeywordDensityItem

Namespace: DataForSeo.Client.Models

```csharp
public class OnPageKeywordDensityItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageKeywordDensityItem](./dataforseo.client.models.onpagekeyworddensityitem)

## Properties

### **Keyword**

returned keyword

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Frequency**

keyword frequency
 <br>number of times the keyword appears on the website (or webpage if you specified a url)

```csharp
public Nullable<int> Frequency { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Density**

keyword density
 <br>calculated as a ratio of frequency to the total count of keywords with the set keyword_length on the web page or website

```csharp
public Nullable<int> Density { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageKeywordDensityItem()**

```csharp
public OnPageKeywordDensityItem()
```

---

[`< Back`](./)
