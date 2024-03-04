[`< Back`](./)

---

# AnchorLinkElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class AnchorLinkElementItem : BaseOnPageLinkItemInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseOnPageLinkItemInfo](./dataforseo.client.models.baseonpagelinkiteminfo) → [AnchorLinkElementItem](./dataforseo.client.models.anchorlinkelementitem)

## Properties

### **DomainFrom**

referring domain
 <br>the link was found on this domain

```csharp
public string DomainFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DomainTo**

referenced domain
 <br>the link is pointing to this domain

```csharp
public string DomainTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageFrom**

referring page
 <br>relative URL of the page on which the link was found

```csharp
public string PageFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageTo**

referenced page
 <br>relative URL of the page to which the link is pointing

```csharp
public string PageTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LinkFrom**

referring page
 <br>absolute URL of the page on which the link was found

```csharp
public string LinkFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LinkTo**

referenced page
 <br>absolute URL of the page to which the link is pointing

```csharp
public string LinkTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LinkAttribute**

link attribute added to external link
 <br>indicates link attributes added to the link_to on the page_from
 <br>example:
 <br>["ugc","noopener"]

```csharp
public ICollection<string> LinkAttribute { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Dofollow**

indicates whether the link is dofollow
 <br>if the value is true, the link doesn’t have a rel="nofollow" attribute

```csharp
public Nullable<bool> Dofollow { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PageFromScheme**

url scheme of the referring page

```csharp
public string PageFromScheme { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageToScheme**

url scheme of the referenced page

```csharp
public string PageToScheme { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Direction**

direction of the link
 <br>possible values: internal, external

```csharp
public string Direction { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsBroken**

link is broken
 <br>indicates whether a link is directing to a broken page or resource

```csharp
public Nullable<bool> IsBroken { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Text**

anchor text

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsLinkRelationConflict**

indicates that the link may have a conflict with another link
 <br>if true, at least one link pointing to link_to has a rel="nofollow" attribute and at least one is dofollow

```csharp
public Nullable<bool> IsLinkRelationConflict { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PageToStatusCode**

status code of the referenced page
 <br>status code of the page to which the link is pointing

```csharp
public Nullable<int> PageToStatusCode { get; set; }
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

### **AnchorLinkElementItem()**

```csharp
public AnchorLinkElementItem()
```

---

[`< Back`](./)
