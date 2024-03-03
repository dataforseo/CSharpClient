# MerchantAmazonReviewsTaskPostRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class MerchantAmazonReviewsTaskPostRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MerchantAmazonReviewsTaskPostRequestInfo](./dataforseo.client.models.requests.merchantamazonreviewstaskpostrequestinfo.md)

## Properties

### **Asin**

product ID
 <br>required field
 <br>unique product identifier (ASIN) on Amazon
 <br>you can receive the asin parameter by making a separate request to the Amazon Products endpoint

```csharp
public string Asin { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

### **LocationName**

full name of search engine location
 <br>required field if you don’t specify location_code or location_coordinate
 <br>if you use this field, you don’t need to specify location_code or location_coordinate
 <br>you can receive the list of available locations with their location_name parameters by making a separate request to https://api.dataforseo.com/v3/merchant/amazon/locations
 <br>example:
 <br>HA1,England,United Kingdom

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

search engine location code
 <br>required field if you don’t specify location_name or location_coordinate
 <br>if you use this field, you don’t need to specify location_name or location_coordinate
 <br>you can receive the list of available locations with their location_code parameters by making a separate request to
 <br>https://api.dataforseo.com/v3/merchant/amazon/locations
 <br>example:
 <br>9045969

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
 <br>the minimum value for “radius”: 199.9
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
 <br>you can receive the list of available languages with their language_name parameters by making a separate request to
 <br>https://api.dataforseo.com/v3/merchant/amazon/languages
 <br>example:
 <br>English (United Kingdom)

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

search engine language code
 <br>required field if you don’t specify language_name
 <br>if you use this field, you don’t need to specify language_name
 <br>you can receive the list of available languages with their language_code parameters by making a separate request to https://api.dataforseo.com/v3/merchant/amazon/languages
 <br>example:
 <br>en_GB

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
 <br>amazon.com, amazon.co.uk, amazon.fr, etc.

```csharp
public string SeDomain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Depth**

parsing depth
 <br>optional field
 <br>number of reviews in SERP;
 <br>we strongly recommend setting the parsing depth in the multiples of ten, because our system processes ten reviews in a row;
 <br>maximum value: 100
 <br>default value: 10

```csharp
public Nullable<int> Depth { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SortBy**

results sorting parameters
 <br>optional field
 <br>you can use this field to sort the results;
 <br>possible types of sorting:
 <br>helpful — sort by helpful reviews;
 <br>recent — sort by recent reviews;
 <br>default rule: helpful

```csharp
public string SortBy { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReviewerType**

filter reviews by reviewer type
 <br>optional field
 <br>you can use this field to filter the results;
 <br>possible types of filtering:
 <br>all_reviews — return reviews from all reviewers;
 <br>avp_only_reviews — return reviews with the “Verified Purchase” mark only;
 <br>default rule: all_reviews

```csharp
public string ReviewerType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FilterByStar**

filter reviews by stars
 <br>optional field
 <br>you can use this field to filter the results;
 <br>possible types of filtering:
 <br>all_stars — return reviews with any number of stars;
 <br>five_star — return five-star reviews only;
 <br>four_star — return four-star reviews only;
 <br>three_star — return three-star reviews only;
 <br>two_star — return two-star reviews only;
 <br>one_star — return one-star reviews only;
 <br>positive — return positive reviews only;
 <br>critical — return critical reviews only;
 <br>default rule: all_stars

```csharp
public string FilterByStar { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FilterByKeyword**

filter reviews by specified keyword
 <br>optional field
 <br>you can specify up to 300 symbols in this field;
 <br>if you use this field, the response will only include reviews that contain the specified keyword

```csharp
public string FilterByKeyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MediaType**

filter reviews by media type
 <br>optional field
 <br>you can use this field to filter the results;
 <br>possible types of filtering:
 <br>all_contents — return text, image, and video reviews;
 <br>media_reviews_only — return image and video reviews only;
 <br>default rule: all_contents

```csharp
public string MediaType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FormatType**

filter reviews by product modification
 <br>optional field
 <br>you can use this field to filter the results;
 <br>possible types of filtering:
 <br>all_format — return reviews for all product modifications;
 <br>current_format — return reviews for the current product modification only;
 <br>default rule: all_format;
 <br>Note: ASINs vary depending on a product modification. Thus, two modifications of the same product will have two different ASINs. Make sure to specify the right ASIN when setting a task with the current_format parameter

```csharp
public string FormatType { get; set; }
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

### **PostbackData**

postback_url datatype
 <br>required field if you specify postback_url
 <br>corresponds to the datatype that will be sent to your server
 <br>possible values:
 <br>advanced, html

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

### **MerchantAmazonReviewsTaskPostRequestInfo()**

```csharp
public MerchantAmazonReviewsTaskPostRequestInfo()
```