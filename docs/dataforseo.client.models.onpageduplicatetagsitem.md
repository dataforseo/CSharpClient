# OnPageDuplicateTagsItem

Namespace: DataForSeo.Client.Models

```csharp
public class OnPageDuplicateTagsItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageDuplicateTagsItem](./dataforseo.client.models.onpageduplicatetagsitem.md)

## Properties

### **Accumulator**

contains the value of duplicated tag

```csharp
public string Accumulator { get; set; }
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

pages with duplicate tags

```csharp
public ICollection<BaseOnPageResourceItemInfo> Pages { get; set; }
```

#### Property Value

[ICollection&lt;BaseOnPageResourceItemInfo&gt;](./dataforseo.client.models.baseonpageresourceiteminfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageDuplicateTagsItem()**

```csharp
public OnPageDuplicateTagsItem()
```
