# LastModified

Namespace: DataForSeo.Client.Models

```csharp
public class LastModified
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [LastModified](./dataforseo.client.models.lastmodified.md)

## Properties

### **Header**

date and time when the header was last modified
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00
 <br>if there is no data, the value will be null

```csharp
public string Header { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Sitemap**

date and time when the sitemap was last modified
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00
 <br>if there is no data, the value will be null

```csharp
public string Sitemap { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MetaTag**

date and time when the meta tag was last modified
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00
 <br>if there is no data, the value will be null

```csharp
public string MetaTag { get; set; }
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

### **LastModified()**

```csharp
public LastModified()
```
