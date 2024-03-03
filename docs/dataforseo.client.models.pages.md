# Pages

Namespace: DataForSeo.Client.Models

```csharp
public class Pages
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Pages](./dataforseo.client.models.pages.md)

## Properties

### **Similarity**

content similarity score
 <br>by default, the content is considered duplicate if the value is greater than or equals 6
 <br>can take values from 0 to 10

```csharp
public Nullable<int> Similarity { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Page**

information about the page with duplicate content

```csharp
public ICollection<BaseOnPageResourceItemInfo> Page { get; set; }
```

#### Property Value

[ICollection&lt;BaseOnPageResourceItemInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **Pages()**

```csharp
public Pages()
```
