[`< Back`](./)

---

# DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo](./dataforseo.client.models.requests.dataforseolabsamazonbulksearchvolumeliverequestinfo)

## Properties

### **Keywords**

target keywords
 <br>required field
 <br>UTF-8 encoding
 <br>maximum number of keywords you can specify in this array: 1000;
 <br>each keyword should be at least 3 characters long;
 <br>the keywords will be converted to lowercase format

```csharp
public ICollection<string> Keywords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **LocationName**

full name of the location
 <br>required field if don’t specify location_code
 <br>you can receive the list of available locations with their location_name by making a separate request to
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
 <br><br>Note: this endpoint currently supports the following locations and languages only:
 <br>Australia – 2036, en
 <br>Austria – 2040, de
 <br>Canada – 2124, en
 <br>Egypt – 2818, ar
 <br>France – 2250, fr
 <br>Germany – 2276, de
 <br>India – 2356, en
 <br>Italy – 2380, it
 <br>Mexico – 2484, es
 <br>Netherlands – 2528, nl
 <br>Saudi Arabia – 2682, ar
 <br>Singapore – 2702, en
 <br>Spain – 2724, es
 <br>United Arab Emirates – 2784, ar
 <br>United Kingdom – 2826, en
 <br>United States – 2840, en
 <br>example:
 <br>United States

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code
 <br>required field if don’t specify location_name
 <br>you can receive the list of available locations with their location_code by making a separate request to
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
 <br>Note: this endpoint currently supports these locations and languages only;
 <br>example:
 <br>2840

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageName**

full name of the language
 <br>required field if don’t specify language_code
 <br>you can receive the list of available languages with their language_name by making a separate request to https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>Note: this endpoint currently supports these locations and languages only;
 <br>example:
 <br>English

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

language code
 <br>required field if don’t specify language_name
 <br>you can receive the list of available languages with their language_code by making a separate request to https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>Note: this endpoint currently supports these locations and languages only;
 <br>example:
 <br>en

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

### **DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo()**

```csharp
public DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo()
```

---

[`< Back`](./)
