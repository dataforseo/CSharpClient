# ShoppingElement

Namespace: DataForSeo.Client.Models

```csharp
public class ShoppingElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ShoppingElement](./dataforseo.client.models.shoppingelement.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the row

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Price**

price of booking a place for the specified dates of stay

```csharp
public PriceInfo Price { get; set; }
```

#### Property Value

[PriceInfo](./dataforseo.client.models.priceinfo.md)<br>

### **Source**

web source of the hotel booking element
 <br>indicates the source of information included in the element

```csharp
public string Source { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

description of the results element in SERP

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Marketplace**

merchant account provider
 <br>commerce site that hosts products or websites of individual sellers under the same merchant account
 <br>example:
 <br>by Google

```csharp
public string Marketplace { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MarketplaceUrl**

relevant marketplace URL
 <br>URL of the page on the marketplace website where the product is hosted

```csharp
public string MarketplaceUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL

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

### **ShoppingElement()**

```csharp
public ShoppingElement()
```
