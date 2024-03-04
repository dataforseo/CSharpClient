[`< Back`](./)

---

# TopicListDataItemInfo

Namespace: DataForSeo.Client.Models

```csharp
public class TopicListDataItemInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TopicListDataItemInfo](./dataforseo.client.models.topiclistdataiteminfo)

## Properties

### **TopicId**

unique topic identifier in Google Trends

```csharp
public string TopicId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TopicTitle**

title of the topic

```csharp
public string TopicTitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TopicType**

type of the topic
 <br>represents the general type of the topic

```csharp
public string TopicType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Value**

search term popularity
 <br>represents the popularity of the topic. Scoring is on a relative scale where a value of 100 is the most commonly searched topic and a value of 50 is a topic searched half as often as the most popular term, and so on.

```csharp
public string Value { get; set; }
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

### **TopicListDataItemInfo()**

```csharp
public TopicListDataItemInfo()
```

---

[`< Back`](./)
