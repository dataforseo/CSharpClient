[`< Back`](./)

---

# SerpGoogleDatasetInfoLiveAdvancedRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class SerpGoogleDatasetInfoLiveAdvancedRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SerpGoogleDatasetInfoLiveAdvancedRequestInfo](./dataforseo.client.models.requests.serpgoogledatasetinfoliveadvancedrequestinfo)

## Properties

### **DatasetId**

ID of the dataset
 <br>required field
 <br>you can find dataset ID in the dataset URL or dataset item of Google Dataset Search result
 <br>example:
 <br>L2cvMTFqbl85ZHN6MQ==

```csharp
public string DatasetId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageName**

full name of search engine language
 <br>optional field
 <br>if you use this field, you don’t need to specify language_code
 <br>possible value:
 <br>English

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

search engine language code
 <br>optional field
 <br>if you use this field, you don’t need to specify language_name
 <br>possible value:
 <br>en

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Device**

device type
 <br>optional field
 <br>possible value: desktop

```csharp
public string Device { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Os**

device operating system
 <br>optional field
 <br>possible values: windows, macos
 <br>default value: windows

```csharp
public string Os { get; set; }
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

### **SerpGoogleDatasetInfoLiveAdvancedRequestInfo()**

```csharp
public SerpGoogleDatasetInfoLiveAdvancedRequestInfo()
```

---

[`< Back`](./)
