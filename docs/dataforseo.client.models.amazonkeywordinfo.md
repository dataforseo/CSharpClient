# AmazonKeywordInfo

Namespace: DataForSeo.Client.Models

```csharp
public class AmazonKeywordInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AmazonKeywordInfo](./dataforseo.client.models.amazonkeywordinfo.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LastUpdatedTime**

date and time when keyword data was updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example: '2019-11-15 12:57:46 +00:00'

```csharp
public string LastUpdatedTime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SearchVolume**

average monthly search volume rate
 <br>represents the (approximate) number of searches for the provided keyword idea on Amazon

```csharp
public Nullable<long> SearchVolume { get; set; }
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

### **AmazonKeywordInfo()**

```csharp
public AmazonKeywordInfo()
```
