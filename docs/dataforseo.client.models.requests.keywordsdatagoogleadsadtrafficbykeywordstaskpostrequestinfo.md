# KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo](./dataforseo.client.models.requests.keywordsdatagoogleadsadtrafficbykeywordstaskpostrequestinfo.md)

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

### **Bid**

the maximum custom bid
 <br>required field
 <br>the collected data will be based on this value
 <br>it stands for the price you are willing to pay for an ad; the higher value you specify here, the higher values you will get in the returned metrics
 <br>learn more in this help center article

```csharp
public Nullable<float> Bid { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Match**

keywords match-type
 <br>required field
 <br>can take the following values: exact, broad, phrase

```csharp
public string Match { get; set; }
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

### **DateFrom**

starting date of the forecasting time range
 <br>required field if you specify date_to
 <br>if you indicate date_from and date_to, you don’t need to specify date_interval
 <br>minimum value is tomorrow’s date
 <br>the value you specify in date_from shouldn’t be further than date_to
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2021-10-30"if Status endpoint returns false in the actual_data field, date_from can be set to the month before last and prior;
 <br>if Status endpoint returns true in the actual_data field, date_from can be set to the last month and prior

```csharp
public string DateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateTo**

ending date of the forecasting time range
 <br>required field if you specify date_from
 <br>if you indicate date_from and date_to, you don’t need to specify date_interval
 <br>minimum value is date_from +1 day
 <br>maximum value is current day and month of the next year
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2022-10-30"

```csharp
public string DateTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateInterval**

forecasting date interval
 <br>optional field
 <br>if you specify date_interval, you don’t need to indicate date_from and date_to
 <br>possible values: next_week, next_month, next_quarter
 <br>default value: next_month

```csharp
public string DateInterval { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SortBy**

results sorting parameters
 <br>optional field
 <br>Use these parameters to sort the results by relevance, impressions, ctr, average_cpc, cost, or clicks in the descending order
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
 <br>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request.
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

### **KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo()**

```csharp
public KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo()
```
