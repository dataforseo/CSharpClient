# KeywordsDataBingKeywordPerformanceLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class KeywordsDataBingKeywordPerformanceLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataBingKeywordPerformanceLiveRequestInfo](./dataforseo.client.models.requests.keywordsdatabingkeywordperformanceliverequestinfo.md)

## Properties

### **Keywords**

keywords
 <br>required field
 <br>The maximum number of keywords you can specify: 2500.
 <br>The maximum number of characters for each keyword: 80.
 <br>The maximum number of words for each keyword phrase: 10.
 <br>the specified keywords will be converted to lowercase, data will be provided in a separate array

```csharp
public ICollection<string> Keywords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Device**

device type
 <br>optional field
 <br>specify this field if you want to get the data for a particular device typepossible values: desktop, mobile, tablet, all
 <br>default value: all

```csharp
public string Device { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Match**

keywords match type
 <br>optional field
 <br>can take the following values:
 <br>aggregate returns data across all match types;
 <br>broad returns data for all user queries containing the specified keyword with varying word order;
 <br>phrase returns data for all user queries containing the specified keyword with identical word order;
 <br>exact returns data for user query that matches the specified keyword;Note: the aggregate match type is applied by default

```csharp
public string Match { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationName**

full name of search engine location
 <br>required field if you don’t specify location_code or location_coordinate
 <br>if you use this field, you don’t need to specify location_code or location_coordinate
 <br>you can receive the list of available locations and languages by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages
 <br>example:
 <br>"United States"

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

search engine location code
 <br>required field if you don’t specify location_name or location_coordinate
 <br>if you use this field, you don’t need to specify location_name or location_coordinate
 <br>you can receive the list of available locations and languages by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages
 <br>example:
 <br>2840

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LocationCoordinate**

GPS coordinates of a location
 <br>required field if you don’t specify location_name or location_code
 <br>if you use this field, you don’t need to specify location_name or location_code
 <br>location_coordinate parameter should be specified in the “latitude,longitude” format
 <br>the data will be provided for the country the specified coordinates belong to
 <br>example:
 <br>52.6178549,-155.352142

```csharp
public string LocationCoordinate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageName**

full name of search engine language
 <br>required field if you don’t specify language_code
 <br>if you use this field, you don’t need to specify language_code
 <br>you can receive the list of available locations and languages by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages
 <br>example:
 <br>English

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

search engine language code
 <br>required field if you don’t specify language_name
 <br>you can receive the list of available locations and languages by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages
 <br>example:
 <br>"en"

```csharp
public string LanguageCode { get; set; }
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

### **KeywordsDataBingKeywordPerformanceLiveRequestInfo()**

```csharp
public KeywordsDataBingKeywordPerformanceLiveRequestInfo()
```
