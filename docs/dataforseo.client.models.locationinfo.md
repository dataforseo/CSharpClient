# LocationInfo

Namespace: DataForSeo.Client.Models

```csharp
public class LocationInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [LocationInfo](./dataforseo.client.models.locationinfo.md)

## Properties

### **Name**

name of the event’s venue

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Address**

address of the event’s venue

```csharp
public string Address { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL to the event’s venue on google maps

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Cid**

google-defined client id
 <br>unique id of a local establishment;
 <br>can be used with Google Reviews API to get a full list of reviews

```csharp
public string Cid { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FeatureId**

the unique identifier of the element in SERP

```csharp
public string FeatureId { get; set; }
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

### **LocationInfo()**

```csharp
public LocationInfo()
```
