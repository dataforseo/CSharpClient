[`< Back`](./)

---

# BacklinksInfo

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksInfo](./dataforseo.client.models.backlinksinfo)

## Properties

### **ReferringDomains**

number of referring domains

```csharp
public Nullable<long> ReferringDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringMainDomains**

number of referring main domains

```csharp
public Nullable<long> ReferringMainDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringPages**

number of referring pages

```csharp
public Nullable<long> ReferringPages { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Dofollow**

number of dofollow links

```csharp
public Nullable<long> Dofollow { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Backlinks**

total number of backlinks
 <br>the total number of backlinks, including dofollow and nofollow links

```csharp
public Nullable<long> Backlinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TimeUpdate**

date and time when backlink data was updated
 <br>in the UTC format: "yyyy-mm-dd hh-mm-ss +00:00"
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string TimeUpdate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksInfo()**

```csharp
public BacklinksInfo()
```

---

[`< Back`](./)
