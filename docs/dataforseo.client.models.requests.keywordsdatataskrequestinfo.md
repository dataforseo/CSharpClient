# KeywordsDataTaskRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class KeywordsDataTaskRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataTaskRequestInfo](./dataforseo.client.models.requests.keywordsdatataskrequestinfo.md)

## Properties

### **Keywords**

keywords
 <br>required field
 <br>The maximum number of keywords you can specify: 1000
 <br>The maximum number of characters for each keyword: 80
 <br>The maximum number of words for each keyword phrase: 10
 <br>the keywords you specify will be converted to a lowercase format
 <br>Note #1: Google Ads may return no data for certain groups of keywords;
 <br>Note #2: Google Ads provides combined search volume values for groups of similar keywords
 <br>to obtain search volume for similar keywords, we recommend submitting such keywords in separate requests;
 <br>Note #3: Google Ads doesn’t allow using certain symbols and characters (e.g., UTF symbols, emojis), so you can’t use them when setting a task;
 <br>to learn more about which symbols can be used, please refer to this article

```csharp
public ICollection<string> Keywords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **LocationName**

full name of search engine location
 <br>optional field
 <br>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
 <br>if you use this field, you don’t need to specify location_code or location_coordinate
 <br>you can receive the list of available locations of the search engine with their location_name by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/locations
 <br>example:
 <br>London,England,United Kingdom

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

search engine location code
 <br>optional field
 <br>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
 <br>if you use this field, you don’t need to specify location_name or location_coordinate;
 <br>you can receive the list of available locations of the search engines with their location_code by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/locations
 <br>example:
 <br>2840

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LocationCoordinate**

GPS coordinates of a location
 <br>optional field
 <br>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
 <br>if you use this field, you don’t need to specify location_name or location_code;
 <br>location_coordinate parameter should be specified in the “latitude,longitude” format;
 <br>the data will be provided for the country the specified coordinates belong to;
 <br>example:
 <br>52.6178549,-155.352142

```csharp
public string LocationCoordinate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageName**

full name of search engine language
 <br>optional field
 <br>you can receive the list of available languages of the search engine with their language_name by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/languages
 <br>example:
 <br>English

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

search engine language code
 <br>optional field
 <br>you can receive the list of available languages of the search engine with their language_code by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/languages
 <br>example:
 <br>en

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SearchPartners**

include Google search partners
 <br>optional field
 <br>if you specify true, the results will be delivered for owned, operated, and syndicated networks across Google and partner sites that host Google search;
 <br>default value: false – results are returned for Google search sites

```csharp
public Nullable<bool> SearchPartners { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DateFrom**

starting date of the time range
 <br>optional field
 <br>date format: "yyyy-mm-dd"
 <br>minimal value: 4 years from the current date
 <br>by default, data is returned for the past 12 months;
 <br>Note: the indicated date cannot be greater than that specified in date_to and/or yesterday’s date;if Status endpoint returns false in the actual_data field, date_from can be set to the month before last and prior;
 <br>if Status endpoint returns true in the actual_data field, date_from can be set to the last month and prior

```csharp
public string DateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateTo**

ending date of the time range
 <br>optional field
 <br>Note: the indicated date cannot be greater than the past month, Google Ads does not return data on the current month;
 <br>if you don’t specify this field, yesterday’s date will be used by default
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2022-11-30"

```csharp
public string DateTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IncludeAdultKeywords**

include keywords associated with adult content
 <br>optional field
 <br>if set to true, adult keywords will be included in the response
 <br>default value: false
 <br>note that the API may return no data for such keywords due to Google Ads restrictions

```csharp
public Nullable<bool> IncludeAdultKeywords { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SortBy**

results sorting parameters
 <br>optional field
 <br>use these parameters to sort the results by relevance, search_volume, competition_index, low_top_of_page_bid, or high_top_of_page_bid in the descending order
 <br>default value: relevance

```csharp
public string SortBy { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PostbackUrl**

return URL for sending task results
 <br>optional field
 <br>once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified
 <br>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request.
 <br>example:
 <br>http://your-server.com/postbackscript?id=$id
 <br>http://your-server.com/postbackscript?id=$id&amp;tag=$tag
 <br>Note: special symbols in postback_url will be urlencoded;
 <br>i.a., the # symbol will be encoded into %23

```csharp
public string PostbackUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PingbackUrl**

notification URL of a completed task
 <br>optional field
 <br>when a task is completed we will notify you by GET request sent to the URL you have specified
 <br>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request
 <br>example:
 <br>http://your-server.com/pingscript?id=$id
 <br>http://your-server.com/pingscript?id=$id&amp;tag=$tag
 <br>Note: special symbols in pingback_url will be urlencoded;
 <br>i.a., the # symbol will be encoded into %23

```csharp
public string PingbackUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Tag**

user-defined task identifier
 <br>optional field
 <br>the character limit is 255
 <br>you can use this parameter to identify the task and match it with the result
 <br>you will find the specified tag value in the data array of the response

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

### **KeywordsDataTaskRequestInfo()**

```csharp
public KeywordsDataTaskRequestInfo()
```