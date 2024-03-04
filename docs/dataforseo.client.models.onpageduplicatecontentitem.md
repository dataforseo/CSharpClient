# OnPageDuplicateContentItem

Namespace: DataForSeo.Client.Models

```csharp
public class OnPageDuplicateContentItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageDuplicateContentItem](./dataforseo.client.models.onpageduplicatecontentitem.md)

## Properties

### **Url**

URL of the specified page

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TotalCount**

total count of duplicate pages

```csharp
public Nullable<long> TotalCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pages**

pages with duplicate content

```csharp
public ICollection<Pages> Pages { get; set; }
```

#### Property Value

[ICollection&lt;Pages&gt;](./dataforseo.client.models.pages.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageDuplicateContentItem()**

```csharp
public OnPageDuplicateContentItem()
```
