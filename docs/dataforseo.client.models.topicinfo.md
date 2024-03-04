# TopicInfo

Namespace: DataForSeo.Client.Models

```csharp
public class TopicInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TopicInfo](./dataforseo.client.models.topicinfo.md)

## Properties

### **HTitle**

meta title

```csharp
public string HTitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MainTitle**

main title of the block

```csharp
public string MainTitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Author**

content author name

```csharp
public string Author { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Language**

content language

```csharp
public string Language { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Level**

HTML level

```csharp
public string Level { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PrimaryContent**

primary content on the page
 <br>you can find more information about content priority calculation in this help center article

```csharp
public ICollection<ContentItemInfo> PrimaryContent { get; set; }
```

#### Property Value

[ICollection&lt;ContentItemInfo&gt;](./dataforseo.client.models.contentiteminfo.md)<br>

### **SecondaryContent**

secondary content on the page
 <br>you can find more information about content priority calculation in this help center article

```csharp
public ICollection<ContentItemInfo> SecondaryContent { get; set; }
```

#### Property Value

[ICollection&lt;ContentItemInfo&gt;](./dataforseo.client.models.contentiteminfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **TopicInfo()**

```csharp
public TopicInfo()
```
