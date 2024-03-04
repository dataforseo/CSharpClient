# BacklinksPageIntersectionLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksPageIntersectionLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksPageIntersectionLiveItem](./dataforseo.client.models.backlinkspageintersectionliveitem.md)

## Properties

### **PageIntersection**

contains data on pages that link to the corresponding targets specified in the POST array
 <br>data is provided in separate objects corresponding to pages specified in the targets object

```csharp
public IDictionary<string, ICollection<BacklinksPageIntersectionInfo>> PageIntersection { get; set; }
```

#### Property Value

[IDictionary&lt;String, ICollection&lt;BacklinksPageIntersectionInfo&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **Summary**

contains the page intersections summary

```csharp
public Summary Summary { get; set; }
```

#### Property Value

[Summary](./dataforseo.client.models.summary.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksPageIntersectionLiveItem()**

```csharp
public BacklinksPageIntersectionLiveItem()
```
