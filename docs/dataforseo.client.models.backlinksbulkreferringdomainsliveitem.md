# BacklinksBulkReferringDomainsLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksBulkReferringDomainsLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBulkReferringDomainsLiveItem](./dataforseo.client.models.backlinksbulkreferringdomainsliveitem.md)

## Properties

### **Target**

domain, subdomain or webpage from a POST array

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReferringDomains**

number of referring domains pointing to the target
 <br>note that we calculate main domains (root domains, like example.com) and their subdomains (e.g. blog.example.com) separately for this metric

```csharp
public Nullable<long> ReferringDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringDomainsNofollow**

number of domains pointing at least one nofollow link to the target

```csharp
public Nullable<long> ReferringDomainsNofollow { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringMainDomains**

number of referring main domains pointing to the target
 <br>the number of primary (root) domains referring to your target

```csharp
public Nullable<long> ReferringMainDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringMainDomainsNofollow**

number of main domains pointing at least one nofollow link to the target

```csharp
public Nullable<long> ReferringMainDomainsNofollow { get; set; }
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

### **BacklinksBulkReferringDomainsLiveItem()**

```csharp
public BacklinksBulkReferringDomainsLiveItem()
```
