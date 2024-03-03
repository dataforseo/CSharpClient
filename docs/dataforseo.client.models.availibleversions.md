# AvailibleVersions

Namespace: DataForSeo.Client.Models

```csharp
public class AvailibleVersions
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AvailibleVersions](./dataforseo.client.models.availibleversions.md)

## Properties

### **Version**

lighthouse version

```csharp
public string Version { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Default**

the version is used by default
 <br>if false, the version is not used by default and should be specified in the corresponding field of the POST request if necessary

```csharp
public Nullable<bool> Default { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AvailibleVersions()**

```csharp
public AvailibleVersions()
```
