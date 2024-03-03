# SerpGoogleDatasetSearchLiveAdvancedRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class SerpGoogleDatasetSearchLiveAdvancedRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SerpGoogleDatasetSearchLiveAdvancedRequestInfo](./dataforseo.client.models.requests.serpgoogledatasetsearchliveadvancedrequestinfo.md)

## Properties

### **Keyword**

keyword
 <br>required field
 <br>you can specify up to 700 symbols in the keyword field
 <br>all %## will be decoded (plus symbol ‘+’ will be decoded to a space character)
 <br>if you need to use the “%” symbol for your keyword, please specify it as “%25”;
 <br>if you need to use the “+” symbol for your keyword, please specify it as “%2B”;

```csharp
public string Keyword { get; set; }
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
 <br>optional field if you don’t specify language_name
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
 <br>choose from the following values: windows, macos
 <br>default value: windows

```csharp
public string Os { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Depth**

parsing depth
 <br>optional field
 <br>number of results in SERP
 <br>default value: 20
 <br>max value: 700
 <br>Note: your account will be billed per each SERP containing up to 20 results;
 <br>thus, setting a depth above 20 may result in additional charges if the search engine returns more than 20 results;
 <br>if the specified depth is higher than the number of results in the response, the difference will be refunded automatically to your account balance

```csharp
public Nullable<int> Depth { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LastUpdated**

last time the dataset was updated
 <br>optional field
 <br>possible values: 1m, 1y, 3y

```csharp
public string LastUpdated { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FileFormats**

file formats of the dataset
 <br>optional field
 <br>possible values: other, archive, text, image, document, tabular

```csharp
public ICollection<string> FileFormats { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **UsageRights**

usage rights of the dataset
 <br>optional field
 <br>possible values: commercial, noncommercial

```csharp
public string UsageRights { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsFree**

indicates whether displayed datasets are free
 <br>optional field
 <br>possible values: true, false

```csharp
public Nullable<bool> IsFree { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Topics**

dataset topics
 <br>optional field
 <br>possible values: humanities, social_sciences, life_sciences, agriculture, natural_sciences, geo, computer, architecture_and_urban_planning, engineering

```csharp
public ICollection<string> Topics { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

### **SerpGoogleDatasetSearchLiveAdvancedRequestInfo()**

```csharp
public SerpGoogleDatasetSearchLiveAdvancedRequestInfo()
```
