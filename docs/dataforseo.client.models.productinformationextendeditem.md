# ProductInformationExtendedItem

Namespace: DataForSeo.Client.Models

```csharp
public class ProductInformationExtendedItem : BaseProductInformationItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseProductInformationItem](./dataforseo.client.models.baseproductinformationitem.md) → [ProductInformationExtendedItem](./dataforseo.client.models.productinformationextendeditem.md)

## Properties

### **SectionName**

name of the section related to product information specified in the contents

```csharp
public string SectionName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Contents**

contains information specified about the product within the section_name

```csharp
public ICollection<ProductInformationRows> Contents { get; set; }
```

#### Property Value

[ICollection&lt;ProductInformationRows&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ProductInformationExtendedItem()**

```csharp
public ProductInformationExtendedItem()
```
