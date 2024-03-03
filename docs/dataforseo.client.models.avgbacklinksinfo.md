# AvgBacklinksInfo

Namespace: DataForSeo.Client.Models

```csharp
public class AvgBacklinksInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AvgBacklinksInfo](./dataforseo.client.models.avgbacklinksinfo.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Backlinks**

average number of backlinks

```csharp
public Nullable<float> Backlinks { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Dofollow**

average number of dofollow links

```csharp
public Nullable<float> Dofollow { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringPages**

average number of referring pages

```csharp
public Nullable<float> ReferringPages { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringDomains**

average number of referring domains

```csharp
public Nullable<float> ReferringDomains { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringMainDomains**

average number of referring main domains

```csharp
public Nullable<float> ReferringMainDomains { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rank**

average rank
 <br>learn more about the metric and its calculation formula in this help center article

```csharp
public Nullable<float> Rank { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MainDomainRank**

average main domain rank
 <br>learn more about the metric and its calculation formula in this help center article

```csharp
public Nullable<float> MainDomainRank { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LastUpdatedTime**

date and time when backlink data was updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string LastUpdatedTime { get; set; }
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

### **AvgBacklinksInfo()**

```csharp
public AvgBacklinksInfo()
```
