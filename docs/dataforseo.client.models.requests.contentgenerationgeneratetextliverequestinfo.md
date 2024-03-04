[`< Back`](./)

---

# ContentGenerationGenerateTextLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class ContentGenerationGenerateTextLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentGenerationGenerateTextLiveRequestInfo](./dataforseo.client.models.requests.contentgenerationgeneratetextliverequestinfo)

## Properties

### **Topic**

main topic of the content to generate
 <br>required field
 <br>main topic for generating content;
 <br>can contain from 1 to 50 tokens

```csharp
public string Topic { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WordCount**

number of words in content
 <br>required field
 <br>the number of tokens in the generated text;
 <br>can take values from 1 to 1000

```csharp
public Nullable<long> WordCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SubTopics**

secondary topics of the content to generate
 <br>optional field
 <br>secondary topics for generating content;
 <br>can contain up to 10 terms;
 <br>example: "sub_topics": ["Apple","Pixar","Amazing Products"]

```csharp
public ICollection<string> SubTopics { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Description**

meta description of the content to generate
 <br>optional field
 <br>can contain from 1 to 1000 tokens
 <br>learn more about this parameter on our help center

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MetaKeywords**

keywords for the content to generate
 <br>optional field
 <br>can contain up to 10 terms;
 <br>learn more about this parameter on our help center
 <br>example: "meta_keywords": ["iPhone","sell","CEO"]

```csharp
public ICollection<string> MetaKeywords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

### **IncludeConclusion**

include conclusion in generated text
 <br>optional field
 <br>if set to true, generated content will include a logical conclusion

```csharp
public Nullable<bool> IncludeConclusion { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SupplementToken**

token for generating subsequent results
 <br>optional field
 <br>provided in the identical filed of the response to each request;
 <br>you can use this parameter to continue the generation of text from the initial response
 <br>supplement_token values are unique for each subsequent task

```csharp
public string SupplementToken { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

### **ContentGenerationGenerateTextLiveRequestInfo()**

```csharp
public ContentGenerationGenerateTextLiveRequestInfo()
```

---

[`< Back`](./)
