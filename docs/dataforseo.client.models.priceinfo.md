# PriceInfo

Namespace: DataForSeo.Client.Models

```csharp
public class PriceInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PriceInfo](./dataforseo.client.models.priceinfo.md)

## Properties

### **Current**

current price
 <br>indicates the current price of the product or service featured in the result

```csharp
public Nullable<double> Current { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Regular**

regular price
 <br>indicates the regular price of the product or service with no discounts applied

```csharp
public Nullable<double> Regular { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MaxValue**

the maximum price
 <br>the maximum price of the product or service as indicated in the result

```csharp
public Nullable<double> MaxValue { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Currency**

currency of the listed price
 <br>ISO code of the currency applied to the price

```csharp
public string Currency { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsPriceRange**

price is provided as a range
 <br>indicates whether a price is provided in a range

```csharp
public Nullable<bool> IsPriceRange { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DisplayedPrice**

price string in the result
 <br>raw price string as provided in the result

```csharp
public string DisplayedPrice { get; set; }
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

### **PriceInfo()**

```csharp
public PriceInfo()
```
