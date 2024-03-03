# KnowledgeGraphShoppingElement

Namespace: DataForSeo.Client.Models

```csharp
public class KnowledgeGraphShoppingElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KnowledgeGraphShoppingElement](./dataforseo.client.models.knowledgegraphshoppingelement.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the result in SERP

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

relevant URL

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

website domain

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Price**

pricing details
 <br>contains the pricing details of the product or service featured in the result

```csharp
public PriceInfo Price { get; set; }
```

#### Property Value

[PriceInfo](./dataforseo.client.models.priceinfo.md)<br>

### **Source**

source of additional information about the result

```csharp
public string Source { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Snippet**

text alongside the link title

```csharp
public string Snippet { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Marketplace**

merchant account provider
 <br>ecommerce site that hosts products or websites of individual sellers under the same merchant account
 <br>example:
 <br>by Google

```csharp
public string Marketplace { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MarketplaceUrl**

URL to the merchant account provider
 <br>ecommerce site that hosts products or websites of individual sellers under the same merchant account

```csharp
public string MarketplaceUrl { get; set; }
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

### **KnowledgeGraphShoppingElement()**

```csharp
public KnowledgeGraphShoppingElement()
```
