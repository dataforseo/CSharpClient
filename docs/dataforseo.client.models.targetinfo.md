# TargetInfo

Namespace: DataForSeo.Client.Models

```csharp
public class TargetInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TargetInfo](./dataforseo.client.models.targetinfo.md)

## Properties

### **Server**

server

```csharp
public string Server { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Cms**

content management system

```csharp
public string Cms { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PlatformType**

platform type

```csharp
public ICollection<string> PlatformType { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **IpAddress**

IP address of the target

```csharp
public string IpAddress { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Country**

country code that the target domain is determined to belong to

```csharp
public string Country { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsIp**

indicates if the target is IP
 <br>if true, the domain, subdomain or webpage functions as an IP address and does not have a domain name

```csharp
public Nullable<bool> IsIp { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TargetSpamScore**

spam score of the target
 <br>if the target is a domain/subdomain, this fields indicates the average spam score of all pages of that domain/subdomain;
 <br>learn more about how the metric is calculated on this help center page

```csharp
public Nullable<int> TargetSpamScore { get; set; }
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

### **TargetInfo()**

```csharp
public TargetInfo()
```
