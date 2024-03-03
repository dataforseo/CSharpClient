# CacheControl

Namespace: DataForSeo.Client.Models

```csharp
public class CacheControl
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CacheControl](./dataforseo.client.models.cachecontrol.md)

## Properties

### **Cachable**

indicates whether the page is cacheable

```csharp
public Nullable<bool> Cachable { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Ttl**

time to live
 <br>the amount of time the browser caches a resource

```csharp
public Nullable<int> Ttl { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **CacheControl()**

```csharp
public CacheControl()
```
