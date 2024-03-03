# Graph

Namespace: DataForSeo.Client.Models

```csharp
public class Graph
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Graph](./dataforseo.client.models.graph.md)

## Properties

### **Items**

additional items present in the element
 <br>if there are none, equals null

```csharp
public ICollection<GraphElement> Items { get; set; }
```

#### Property Value

[ICollection&lt;GraphElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **PreviousItems**

previous close data
 <br>contains stock price data based on the preceding time period

```csharp
public ICollection<GraphElement> PreviousItems { get; set; }
```

#### Property Value

[ICollection&lt;GraphElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **Graph()**

```csharp
public Graph()
```
