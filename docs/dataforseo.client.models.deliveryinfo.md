# DeliveryInfo

Namespace: DataForSeo.Client.Models

```csharp
public class DeliveryInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DeliveryInfo](./dataforseo.client.models.deliveryinfo.md)

## Properties

### **DeliveryMessage**

delivery information
 <br>message accompanying the delivery information as posted by the seller

```csharp
public string DeliveryMessage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DeliveryPrice**

price for the delivery
 <br>price of the delivery based on the location you specified in the POST request;
 <br>if free delivery is available, the value is null

```csharp
public PriceInfo DeliveryPrice { get; set; }
```

#### Property Value

[PriceInfo](./dataforseo.client.models.priceinfo.md)<br>

### **StoresCountInfo**

stores count information
 <br>contains information about the number of stores that offer the same product

```csharp
public StoresCountInfo StoresCountInfo { get; set; }
```

#### Property Value

[StoresCountInfo](./dataforseo.client.models.storescountinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DeliveryInfo()**

```csharp
public DeliveryInfo()
```
