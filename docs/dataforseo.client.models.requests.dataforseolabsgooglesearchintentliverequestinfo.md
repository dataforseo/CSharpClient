[`< Back`](./)

---

# DataforseoLabsGoogleSearchIntentLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DataforseoLabsGoogleSearchIntentLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleSearchIntentLiveRequestInfo](./dataforseo.client.models.requests.dataforseolabsgooglesearchintentliverequestinfo)

## Properties

### **Keywords**

target keywords
 <br>required field
 <br>UTF-8 encoding
 <br>maximum number of keywords you can specify in this array: 1000;
 <br>the keywords will be converted to lowercase format

```csharp
public ICollection<string> Keywords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **LanguageName**

full name of the language
 <br>required field if don’t specify language_code
 <br>you can receive the list of available languages with their language_name by making a separate request to https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br><br>Note: this endpoint currently supports the following languages only:
 <br>Arabic, ar,
 <br>Chinese(Traditional), zh-TW,
 <br>Czech, cs,
 <br>Danish, da,
 <br>Dutch, nl,
 <br>English, en,
 <br>Finnish, fi,
 <br>French, fr,
 <br>German, de,
 <br>Hebrew, he,
 <br>Hindi, hi,
 <br>Italian, it,
 <br>Japanese, ja,
 <br>Korean, ko,
 <br>Malay, ms,
 <br>Norwegian(Bokmål), nb,
 <br>Polish, pl,
 <br>Portuguese, pt,
 <br>Russian, ru,
 <br>Spanish, es,
 <br>Swedish, sv,
 <br>Thai, th,
 <br>Ukrainian, uk,
 <br>Vietnamese, vi
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
 <br>Note: this endpoint currently supports these languages only;
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

### **DataforseoLabsGoogleSearchIntentLiveRequestInfo()**

```csharp
public DataforseoLabsGoogleSearchIntentLiveRequestInfo()
```

---

[`< Back`](./)
