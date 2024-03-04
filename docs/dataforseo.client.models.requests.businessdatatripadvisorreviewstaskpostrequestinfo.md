# BusinessDataTripadvisorReviewsTaskPostRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BusinessDataTripadvisorReviewsTaskPostRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataTripadvisorReviewsTaskPostRequestInfo](./dataforseo.client.models.requests.businessdatatripadvisorreviewstaskpostrequestinfo.md)

## Properties

### **UrlPath**

URL path of the business entity
 <br>required field if you do not specify keyword
 <br>URL path to the Tripadvisor page of the business entity;
 <br>can be found in the URL of the business entity on Tripadvisor
 <br>example:
 <br>Hotel_Review-g60763-d23462501-Reviews-Margaritaville_Times_Square-New_York_City_New_York.html
 <br>https://www.tripadvisor.com/Hotel_Review-g60763-d23462501-Reviews-Margaritaville_Times_Square-New_York_City_New_York.html

```csharp
public string UrlPath { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Keyword**

keyword
 <br>required field if you do not specify url_path
 <br>the keyword you specify should indicate a name of an existing business or prominent place on Tripadvisor;
 <br>you can specify up to 700 symbols in the keyword filed;
 <br>all %## will be decoded (plus symbol ‘+’ will be decoded to a space character);
 <br>if you need to use the “%” symbol for your keyword, please specify it as “%25”

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationName**

full name of search engine location
 <br>required field if you don’t specify location_code or url_path
 <br>you can receive the list of available locations with location_name by making a separate request to the https://api.dataforseo.com/v3/business_data/tripadvisor/locations
 <br>example:
 <br>London,England,United Kingdom

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

search engine location code
 <br>required field if you don’t specify location_name or url_path
 <br>you can receive the list of available locations with location_code by making a separate request to the https://api.dataforseo.com/v3/business_data/tripadvisor/locations
 <br>example:
 <br>1003854

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Priority**

task priority
 <br>optional field
 <br>can take the following values:
 <br>1 – normal execution priority (set by default)
 <br>2 – high execution priority
 <br>You will be additionally charged for the tasks with high execution priority.
 <br>The cost can be calculated on the Pricing page.

```csharp
public Nullable<int> Priority { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageName**

full name of search engine language
 <br>optional field
 <br>if you use this field, your account will be charged for one extra request
 <br>you can receive the list of available languages with language_name by making a separate request to the https://api.dataforseo.com/v3/business_data/tripadvisor/languages
 <br>example:
 <br>English
 <br>You will be additionally charged for setting a language parameter in this endpoint.
 <br>The cost can be calculated on the Pricing page.

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

search engine language code
 <br>optional field
 <br>if you use this field, your account will be charged for one extra request
 <br>you can receive the list of available languages with language_code by making a separate request to the https://api.dataforseo.com/v3/business_data/tripadvisor/languages
 <br>example:
 <br>en
 <br>You will be additionally charged for setting a language parameter in this endpoint.
 <br>The cost can be calculated on the Pricing page.

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Depth**

parsing depth
 <br>optional field
 <br>number of reviews in SERP
 <br>we strongly recommend setting the parsing depth in the multiples of ten, because our systems processes ten reviews in a row
 <br>default value: 10

```csharp
public Nullable<int> Depth { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Ratings**

Tripadvisor traveler rating for a place of interest
 <br>optional field
 <br>rating based on the written reviews by a traveler after they visited a place.
 <br>possible values: excellent, very_good, average, poor, terrible
 <br>you can specify several values at once

```csharp
public ICollection<string> Ratings { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **VisitType**

filter by type of travelers who left a review
 <br>optional field
 <br>possible values: families, couples, solo, business, friends
 <br>you can specify several values at once

```csharp
public ICollection<string> VisitType { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Months**

filter by months when a traveler made a visit
 <br>optional field
 <br>possible values: january, february, march, april, may, april, june, july, august, september, october, november, december
 <br>you can specify several values at once

```csharp
public ICollection<string> Months { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **SearchReviewsKeyword**

search reviews containing a specified keyword
 <br>example:
 <br>dessert

```csharp
public string SearchReviewsKeyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SortBy**

results sorting parameters
 <br>optional field
 <br>you can use this field to sort the results;
 <br>possible types of sorting:
 <br>most_recent
 <br>detailed_reviews

```csharp
public string SortBy { get; set; }
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

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataTripadvisorReviewsTaskPostRequestInfo()**

```csharp
public BusinessDataTripadvisorReviewsTaskPostRequestInfo()
```
