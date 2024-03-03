# AmazonDeliveryInfo

Namespace: DataForSeo.Client.Models

```csharp
public class AmazonDeliveryInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AmazonDeliveryInfo](./dataforseo.client.models.amazondeliveryinfo.md)

## Properties

### **DeliveryMessage**

message accompanying the delivery information as posted by the seller

```csharp
public string DeliveryMessage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DeliveryDateFrom**

the earliest date when the product can be shipped

```csharp
public string DeliveryDateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DeliveryDateTo**

the latest date when the product can be delivered

```csharp
public string DeliveryDateTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FastestDeliveryDateFrom**

the earliest date when the product can be delivered with a fast delivery option

```csharp
public string FastestDeliveryDateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FastestDeliveryDateTo**

the latest date when the product can be delivered with a fast delivery option

```csharp
public string FastestDeliveryDateTo { get; set; }
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

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AmazonDeliveryInfo()**

```csharp
public AmazonDeliveryInfo()
```
