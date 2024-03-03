# OnPageRedirectChainsItem

Namespace: DataForSeo.Client.Models

```csharp
public class OnPageRedirectChainsItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageRedirectChainsItem](./dataforseo.client.models.onpageredirectchainsitem.md)

## Properties

### **IsRedirectLoop**

indicates if redirects in chain start and end at the same URL
 <br>if true, the last URL from the chain redirects back to the original URL

```csharp
public Nullable<bool> IsRedirectLoop { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Chain**

contains links that form a chain

```csharp
public ICollection<BaseOnPageLinkItemInfo> Chain { get; set; }
```

#### Property Value

[ICollection&lt;BaseOnPageLinkItemInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageRedirectChainsItem()**

```csharp
public OnPageRedirectChainsItem()
```
