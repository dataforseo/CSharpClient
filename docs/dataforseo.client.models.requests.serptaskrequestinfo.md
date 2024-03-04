[`< Back`](./)

---

# SerpTaskRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class SerpTaskRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SerpTaskRequestInfo](./dataforseo.client.models.requests.serptaskrequestinfo)

## Properties

### **Keyword**

keyword
 <br>required field
 <br>you can specify up to 700 symbols in the keyword field
 <br>all %## will be decoded (plus symbol ‘+’ will be decoded to a space character)
 <br>if you need to use the “%” symbol for your keyword, please specify it as “%25”;
 <br>if you need to use the “+” symbol for your keyword, please specify it as “%2B”;
 <br>if this field contains such parameters as ‘allinanchor:’, ‘allintext:’, ‘allintitle:’, ‘allinurl:’, ‘define:’, ‘filetype:’, ‘id:’, ‘inanchor:’, ‘info:’, ‘intext:’, ‘intitle:’, ‘inurl:’, ‘link:’, ‘site:’, the charge per task will be multiplied by 5
 <br>Note: queries containing the ‘cache:’ parameter are not supported and will return a validation error

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

direct URL of the search query
 <br>optional field
 <br>you can specify a direct URL and we will sort it out to the necessary fields. Note that this method is the most difficult for our API to process and also requires you to specify the exact language and location in the URL. In most cases, we wouldn’t recommend using this method.
 <br>example:
 <br>https://www.google.co.uk/search?q=%20rank%20tracker%20api&amp;hl=en&amp;gl=GB&amp;uule=w+CAIQIFISCXXeIa8LoNhHEZkq1d1aOpZS

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Priority**

task priority
 <br>optional field
 <br>can take the following values:
 <br>1 – normal execution priority (set by default);
 <br>2 – high execution priority
 <br>You will be additionally charged for the tasks with high execution priority;
 <br>The cost can be calculated on the Pricing page

```csharp
public Nullable<int> Priority { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Depth**

parsing depth
 <br>optional field
 <br>number of results in SERP
 <br>default value: 100
 <br>max value: 700
 <br>Note: your account will be billed per each SERP containing up to 100 results;
 <br>thus, setting a depth above 100 may result in additional charges if the search engine returns more than 100 results;
 <br>if the specified depth is higher than the number of results in the response, the difference will be refunded automatically to your account balance

```csharp
public Nullable<int> Depth { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MaxCrawlPages**

page crawl limit
 <br>optional field
 <br>number of search results pages to crawl
 <br>max value: 100
 <br>Note: the max_crawl_pages and depth parameters complement each other;
 <br>learn more at our help center

```csharp
public Nullable<int> MaxCrawlPages { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LocationName**

full name of search engine location
 <br>required field if you don’t specify location_code or location_coordinate
 <br>if you use this field, you don’t need to specify location_code or location_coordinate
 <br>you can receive the list of available locations of the search engine with their location_name by making a separate request to the https://api.dataforseo.com/v3/serp/google/locations
 <br>example:
 <br>London,England,United Kingdom

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

search engine location code
 <br>required field if you don’t specify location_name or location_coordinate
 <br>if you use this field, you don’t need to specify location_name or location_coordinate
 <br>you can receive the list of available locations of the search engines with their location_code by making a separate request to the https://api.dataforseo.com/v3/serp/google/locations
 <br>example:
 <br>2840

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LocationCoordinate**

GPS coordinates of a location
 <br>required field if you don’t specify location_name or location_code
 <br>if you use this field, you don’t need to specify location_name or location_code
 <br>location_coordinate parameter should be specified in the “latitude,longitude,radius” format
 <br>the maximum number of decimal digits for “latitude” and “longitude”: 7
 <br>the minimum value for “radius”: 199.9 (mm)
 <br>the maximum value for “radius”: 199999 (mm)
 <br>example:
 <br>53.476225,-2.243572,200

```csharp
public string LocationCoordinate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageName**

full name of search engine language
 <br>required field if you don’t specify language_code
 <br>if you use this field, you don’t need to specify language_code
 <br>you can receive the list of available languages of the search engine with their language_name by making a separate request to the https://api.dataforseo.com/v3/serp/google/languages
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
 <br>if you use this field, you don’t need to specify language_name
 <br>you can receive the list of available languages of the search engine with their language_code by making a separate request to the https://api.dataforseo.com/v3/serp/google/languages
 <br>example:
 <br>en

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeDomain**

search engine domain
 <br>optional field
 <br>we choose the relevant search engine domain automatically according to the location and language you specify
 <br>however, you can set a custom search engine domain in this field
 <br>example:
 <br>google.co.uk, google.com.au, google.de, etc.

```csharp
public string SeDomain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Device**

device type
 <br>optional field
 <br>can take the values:desktop, mobile
 <br>default value: desktop

```csharp
public string Device { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Os**

device operating system
 <br>optional field
 <br>if you specify desktop in the device field, choose from the following values: windows, macos
 <br>default value: windows
 <br>if you specify mobile in the device field, choose from the following values: android, ios
 <br>default value: android

```csharp
public string Os { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GroupOrganicResults**

display related results
 <br>optional field
 <br>if set to true, the related_result element in the response will be provided as a snippet of its parent organic result;
 <br>if set to false, the related_result element will be provided as a separate organic result;
 <br>default value: true

```csharp
public Nullable<bool> GroupOrganicResults { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CalculateRectangles**

calcualte pixel rankings for SERP elements in advanced results
 <br>optional field
 <br>pixel ranking refers to the distance between the result snippet and top left corner of the screen;
 <br>Visit Help Center to learn more&gt; &gt;
 <br>by default, the parameter is set to false
 <br>Note: if set to true, the charge per task will be multiplied by 2

```csharp
public Nullable<bool> CalculateRectangles { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrowserScreenWidth**

browser screen width
 <br>optional field
 <br>you can set a custom browser screen width to calculate pixel rankings for a particular device;
 <br>by default, the parameter is set to:
 <br>1920 for desktop;
 <br>360 for mobile on android;
 <br>375 for mobile on iOS;
 <br>Note: to use this parameter, set calculate_rectangles to true

```csharp
public Nullable<long> BrowserScreenWidth { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrowserScreenHeight**

browser screen height
 <br>optional field
 <br>you can set a custom browser screen height to calculate pixel rankings for a particular device;
 <br>by default, the parameter is set to:
 <br>1080 for desktop;
 <br>640 for mobile on android;
 <br>812 for mobile on iOS;
 <br>Note: to use this parameter, set calculate_rectangles to true

```csharp
public Nullable<int> BrowserScreenHeight { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrowserScreenResolutionRatio**

browser screen resolution ratio
 <br>optional field
 <br>you can set a custom browser screen resolution ratio to calculate pixel rankings for a particular device;
 <br>by default, the parameter is set to:
 <br>1 for desktop;
 <br>3 for mobile on android;
 <br>3 for mobile on iOS;
 <br>Note: to use this parameter, set calculate_rectangles to true

```csharp
public Nullable<int> BrowserScreenResolutionRatio { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PeopleAlsoAskClickDepth**

clicks on the corresponding element
 <br>optional field
 <br>specify the click depth on the people_also_ask element to get additional people_also_ask_element items;
 <br>Note your account will be billed $0.00015 extra for each click regardless of task priority;
 <br>if the element is absent or we perform fewer clicks than you specified, all extra charges will be returned to your account balance
 <br>possible values: from 1 to 4

```csharp
public Nullable<int> PeopleAlsoAskClickDepth { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SearchParam**

additional parameters of the search query
 <br>optional field
 <br>get the list of available parameters and additional details here

```csharp
public string SearchParam { get; set; }
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

### **PostbackUrl**

return URL for sending task results
 <br>optional field
 <br>once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified
 <br>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request
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

### **PostbackData**

postback_url datatype
 <br>required field if you specify postback_url
 <br>corresponds to the datatype that will be sent to your server
 <br>possible values:
 <br>regular, advanced, html

```csharp
public string PostbackData { get; set; }
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

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **SerpTaskRequestInfo()**

```csharp
public SerpTaskRequestInfo()
```

---

[`< Back`](./)
