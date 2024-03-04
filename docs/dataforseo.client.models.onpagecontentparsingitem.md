[`< Back`](./)

---

# OnPageContentParsingItem

Namespace: DataForSeo.Client.Models

```csharp
public class OnPageContentParsingItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageContentParsingItem](./dataforseo.client.models.onpagecontentparsingitem)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FetchTime**

date and time when the content was fethced
 <br>example:
 <br>"2022-11-01 10:02:52 +00:00"

```csharp
public string FetchTime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **StatusCode**

status code of the page

```csharp
public Nullable<int> StatusCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PageContent**

parsed content of the page

```csharp
public PageContentInfo PageContent { get; set; }
```

#### Property Value

[PageContentInfo](./dataforseo.client.models.pagecontentinfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageContentParsingItem()**

```csharp
public OnPageContentParsingItem()
```

---

[`< Back`](./)
