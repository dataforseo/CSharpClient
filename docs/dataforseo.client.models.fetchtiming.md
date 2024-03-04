# FetchTiming

Namespace: DataForSeo.Client.Models

```csharp
public class FetchTiming
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [FetchTiming](./dataforseo.client.models.fetchtiming.md)

## Properties

### **DurationTime**

indicates how many milliseconds it took to fetch a resource

```csharp
public Nullable<int> DurationTime { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FetchStart**

time to start downloading the resource
 <br>the amount of time a browser needs to start downloading a resource

```csharp
public Nullable<int> FetchStart { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FetchEnd**

time to complete downloading the resource
 <br>the amount of time a browser needs to complete downloading a resource

```csharp
public Nullable<int> FetchEnd { get; set; }
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

### **FetchTiming()**

```csharp
public FetchTiming()
```
