# ContentGenerationTextSummaryLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class ContentGenerationTextSummaryLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentGenerationTextSummaryLiveRequestInfo](./dataforseo.client.models.requests.contentgenerationtextsummaryliverequestinfo.md)

## Properties

### **Text**

target text
 <br>required field
 <br>can contain from 1 to 10000 tokens
 <br>learn more about tokens on our help center

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageName**

name of the text language
 <br>required field if you do not specify language_code
 <br>see the List of Languages for Content Generation Text Summary API

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

code of the text language
 <br>required field if you do not specify language_name
 <br>see the List of Languages for Content Generation Text Summary API

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **InternalListLimit**

maximum number of elements within internal arrays
 <br>optional field
 <br>you can use this field to limit the number of elements within the keyword_density array
 <br>default value: 10

```csharp
public Nullable<int> InternalListLimit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

### **ContentGenerationTextSummaryLiveRequestInfo()**

```csharp
public ContentGenerationTextSummaryLiveRequestInfo()
```
