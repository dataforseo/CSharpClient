# BacklinksDomainIntersectionLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksDomainIntersectionLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksDomainIntersectionLiveItem](./dataforseo.client.models.backlinksdomainintersectionliveitem.md)

## Properties

### **DomainIntersection**

contains data on domains that link to the corresponding targets specified in the POST array
 <br>data is provided in separate objects corresponding to domains, subdomains or pages specified in the targets object

```csharp
public IDictionary<string, BacklinksDomainIntersectionInfo> DomainIntersection { get; set; }
```

#### Property Value

[IDictionary&lt;String, BacklinksDomainIntersectionInfo&gt;](./dataforseo.client.models.backlinksdomainintersectioninfo.md)<br>

### **Summary**

contains the domain intersections summary

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

### **BacklinksDomainIntersectionLiveItem()**

```csharp
public BacklinksDomainIntersectionLiveItem()
```
