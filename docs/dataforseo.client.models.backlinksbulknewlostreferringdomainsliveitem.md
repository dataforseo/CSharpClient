# BacklinksBulkNewLostReferringDomainsLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksBulkNewLostReferringDomainsLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBulkNewLostReferringDomainsLiveItem](./dataforseo.client.models.backlinksbulknewlostreferringdomainsliveitem.md)

## Properties

### **Target**

domain, subdomain or webpage from a POST array

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **NewReferringDomains**

number of new referring domains
 <br>number of new referring domains pointing to the target

```csharp
public Nullable<long> NewReferringDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LostReferringDomains**

number of lost referring domains
 <br>number of lost referring domains of the target

```csharp
public Nullable<long> LostReferringDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **NewReferringMainDomains**

number of new referring main domains pointing to the target

```csharp
public Nullable<long> NewReferringMainDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LostReferringMainDomains**

number of lost referring main domains pointing to the target

```csharp
public Nullable<long> LostReferringMainDomains { get; set; }
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

### **BacklinksBulkNewLostReferringDomainsLiveItem()**

```csharp
public BacklinksBulkNewLostReferringDomainsLiveItem()
```
