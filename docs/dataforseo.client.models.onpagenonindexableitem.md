# OnPageNonIndexableItem

Namespace: DataForSeo.Client.Models

```csharp
public class OnPageNonIndexableItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageNonIndexableItem](./dataforseo.client.models.onpagenonindexableitem.md)

## Properties

### **Reason**

the reason why the page is non-indexable
 <br>can take the following values: robots_txt, meta_tag, http_header, attribute, too_many_redirects

```csharp
public string Reason { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

url of the non-indexable page

```csharp
public string Url { get; set; }
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

### **OnPageNonIndexableItem()**

```csharp
public OnPageNonIndexableItem()
```
