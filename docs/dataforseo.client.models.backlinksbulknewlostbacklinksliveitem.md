# BacklinksBulkNewLostBacklinksLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksBulkNewLostBacklinksLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBulkNewLostBacklinksLiveItem](./dataforseo.client.models.backlinksbulknewlostbacklinksliveitem.md)

## Properties

### **Target**

domain, subdomain or webpage from a POST array

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **NewBacklinks**

number of new backlinks
 <br>number of new backlinks pointing to the target

```csharp
public Nullable<long> NewBacklinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LostBacklinks**

number of lost backlinks
 <br>number of lost backlinks of the target

```csharp
public Nullable<long> LostBacklinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksBulkNewLostBacklinksLiveItem()**

```csharp
public BacklinksBulkNewLostBacklinksLiveItem()
```
