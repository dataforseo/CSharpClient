[`< Back`](./)

---

# ContentGenerationParaphraseLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class ContentGenerationParaphraseLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentGenerationParaphraseLiveRequestInfo](./dataforseo.client.models.requests.contentgenerationparaphraseliverequestinfo)

## Properties

### **Text**

target text
 <br>required field
 <br>can contain from 1 to 500 tokens
 <br>learn more about tokens on our help center

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CreativityIndex**

creativity of content generation
 <br>required field
 <br>the randomness of the selection of equally probable subsequent tokens;
 <br>can take values from 0 to 1;
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

### **ContentGenerationParaphraseLiveRequestInfo()**

```csharp
public ContentGenerationParaphraseLiveRequestInfo()
```

---

[`< Back`](./)
