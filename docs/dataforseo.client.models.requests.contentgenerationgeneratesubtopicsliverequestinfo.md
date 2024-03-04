[`< Back`](./)

---

# ContentGenerationGenerateSubTopicsLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class ContentGenerationGenerateSubTopicsLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentGenerationGenerateSubTopicsLiveRequestInfo](./dataforseo.client.models.requests.contentgenerationgeneratesubtopicsliverequestinfo)

## Properties

### **Topic**

main topic of the content to generate
 <br>required field
 <br>main topic for content generation;
 <br>can contain from 1 to 50 tokens

```csharp
public string Topic { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CreativityIndex**

creativity of content generation
 <br>optional field
 <br>the randomness of the selection of equally probable subsequent tokens;
 <br>can take values from 0 to 1
 <br>default value: 0.8
 <br>learn more about this parameter on our help center

```csharp
public Nullable<float> CreativityIndex { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Tag**

user-defined task identifier
 <br>optional field
 <br>the character limit is 255
 <br>you can use this parameter to identify the task and match it with the result
 <br>you will find the specified tag value in the data object of the response

```csharp
public string Tag { get; set; }
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

### **ContentGenerationGenerateSubTopicsLiveRequestInfo()**

```csharp
public ContentGenerationGenerateSubTopicsLiveRequestInfo()
```

---

[`< Back`](./)
