# DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo](./dataforseo.client.models.requests.dataforseolabsamazonrelatedkeywordsliverequestinfo.md)

## Properties

### **Keyword**

keyword
 <br>required field
 <br>UTF-8 encoding
 <br>a keyword should be at least 3 characters long;
 <br>the keywords should be specified in the lowercase format

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationName**

full name of the location
 <br>required field if you don’t specify location_code
 <br>Note: it is required to specify either location_name or location_code
 <br>you can receive the list of available locations with their location_name by making a separate request to
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
 <br>Note: this endpoint currently supports the US, Egypt, Saudi Arabia, and the United Arab Emirates locations only;
 <br>example:
 <br>United States

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code
 <br>required field if you don’t specify location_name
 <br>Note: it is required to specify either location_name or location_code
 <br>you can receive the list of available locations with their location_code by making a separate request to
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
 <br>Note: this endpoint currently supports the US, Egypt, Saudi Arabia, and the United Arab Emirates locations only;
 <br>example:
 <br>2840

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageName**

full name of the language
 <br>required field if you don’t specify language_code
 <br>Note: it is required to specify either language_name or language_code
 <br>you can receive the list of available locations with their language_name by making a separate request to https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>example:
 <br>English

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

language code
 <br>required field if you don’t specify language_name
 <br>Note: it is required to specify either language_name or language_code
 <br>you can receive the list of available locations with their language_code by making a separate request to https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>example:
 <br>en

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Depth**

keyword search depth
 <br>optional field
 <br>default value: 1;
 <br>number of the returned results depends on the value you set in this field;
 <br>you can specify a level from 0 to 4;
 <br>estimated number of keywords for each level (maximum):
 <br>0 – the keyword set in the keyword field
 <br>1 – 6 keywords
 <br>2 – 42 keywords
 <br>3 – 258 keywords
 <br>4 – 1554 keywords

```csharp
public Nullable<int> Depth { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IncludeSeedKeyword**

include data for the seed keyword
 <br>optional field
 <br>if set to true, data for the seed keyword specified in the keyword field will be provided in the seed_keyword_data array of the response
 <br>default value: false

```csharp
public Nullable<bool> IncludeSeedKeyword { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IgnoreSynonyms**

ignore highly similar keywords
 <br>optional field
 <br>if set to true only core keywords will be returned, all highly similar keywords will be excluded;
 <br>default value: false

```csharp
public Nullable<bool> IgnoreSynonyms { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Limit**

the maximum number of returned keywords
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned keywords
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords

```csharp
public Nullable<int> Offset { get; set; }
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

### **DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo()**

```csharp
public DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo()
```
