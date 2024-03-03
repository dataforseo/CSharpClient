# DataforseoLabsGoogleDomainWhoisOverviewLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsGoogleDomainWhoisOverviewLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleDomainWhoisOverviewLiveItem](./dataforseo.client.models.dataforseolabsgoogledomainwhoisoverviewliveitem.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

domain name

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CreatedDatetime**

date and time of registration
 <br>date and time (in the ISO 8601 format) when the domain was first registered
 <br>example:
 <br>"1997-03-29 03:00:00 +00:00"

```csharp
public string CreatedDatetime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ChangedDatetime**

date and time when the domain entry was changed
 <br>date and time (in the ISO 8601 format) when the domain entry was last modified
 <br>example:
 <br>"2021-01-14 08:36:28 +00:00"

```csharp
public string ChangedDatetime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ExpirationDatetime**

date and time when the domain will expire
 <br>date and time (in the ISO 8601 format) when the domain is due to expire
 <br>example:
 <br>"2022-11-26 17:21:23 +00:00"

```csharp
public string ExpirationDatetime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UpdatedDatetime**

date and time when the domain was updated
 <br>date and time (in the ISO 8601 format) when the domain was last updated
 <br>example:
 <br>"2021-01-29 13:59:38 +00:00"

```csharp
public string UpdatedDatetime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FirstSeen**

date and time when our crawler found the domain for the first time
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>"2019-11-15 12:57:46 +00:00"

```csharp
public string FirstSeen { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EppStatusCodes**

extensive provisioning protocol status codes
 <br>the status of a domain name registration as defined by ICANN

```csharp
public ICollection<string> EppStatusCodes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Tld**

top-level domain
 <br>top-level domain in the DNS root zone

```csharp
public string Tld { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Registered**

domain registration status
 <br>if false, the domain name registration has expired
 <br>Note: expired domains will remain in the database for only a short period of time

```csharp
public Nullable<bool> Registered { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Registrar**

domain registrar
 <br>if null, the domain registrar is unknown
 <br>example:
 <br>NameCheap, Inc.

```csharp
public string Registrar { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Metrics**

ranking data relevant to the specified domain

```csharp
public IDictionary<string, MetricsInfo> Metrics { get; set; }
```

#### Property Value

[IDictionary&lt;String, MetricsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **BacklinksInfo**

backlink data for the returned domain

```csharp
public BacklinksInfo BacklinksInfo { get; set; }
```

#### Property Value

[BacklinksInfo](./dataforseo.client.models.backlinksinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsGoogleDomainWhoisOverviewLiveItem()**

```csharp
public DataforseoLabsGoogleDomainWhoisOverviewLiveItem()
```
