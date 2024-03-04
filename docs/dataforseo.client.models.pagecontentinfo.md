# PageContentInfo

Namespace: DataForSeo.Client.Models

```csharp
public class PageContentInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PageContentInfo](./dataforseo.client.models.pagecontentinfo.md)

## Properties

### **Header**

parsed content of the header

```csharp
public PageSectionContentInfo Header { get; set; }
```

#### Property Value

[PageSectionContentInfo](./dataforseo.client.models.pagesectioncontentinfo.md)<br>

### **Footer**

parsed content of the footer

```csharp
public PageSectionContentInfo Footer { get; set; }
```

#### Property Value

[PageSectionContentInfo](./dataforseo.client.models.pagesectioncontentinfo.md)<br>

### **MainTopic**

main topic on the page
 <br>you can find more information about topic priority calculation in this help center article

```csharp
public ICollection<TopicInfo> MainTopic { get; set; }
```

#### Property Value

[ICollection&lt;TopicInfo&gt;](./dataforseo.client.models.topicinfo.md)<br>

### **SecondaryTopic**

secondary topic on the page
 <br>you can find more information about topic priority calculation in this help center article

```csharp
public ICollection<TopicInfo> SecondaryTopic { get; set; }
```

#### Property Value

[ICollection&lt;TopicInfo&gt;](./dataforseo.client.models.topicinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **PageContentInfo()**

```csharp
public PageContentInfo()
```
