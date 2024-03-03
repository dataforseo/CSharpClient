# MerchantAmazonProductsTaskPostRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class MerchantAmazonProductsTaskPostRequestInfo : MerchantTaskRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MerchantTaskRequestInfo](./dataforseo.client.models.requests.merchanttaskrequestinfo.md) → [MerchantAmazonProductsTaskPostRequestInfo](./dataforseo.client.models.requests.merchantamazonproductstaskpostrequestinfo.md)

## Properties

### **Department**

amazon product department
 <br>optional field
 <br>specify one of the following amazon departments for extracting product listings:
 <br>"Arts &amp; Crafts", "Automotive", "Baby", "Beauty &amp; Personal Care", "Books", "Computers", "Digital Music", "Electronics", "Kindle Store", "Prime Video", "Women's Fashion", "Men's Fashion", "Girls' Fashion", "Boys' Fashion", "Deals", "Health &amp; Household", "Home &amp; Kitchen", "Industrial &amp; Scientific", "Luggage", "Movies &amp; TV", "Music, CDs &amp; Vinyl", "Pet Supplies", "Software", "Sports &amp; Outdoors", "Tools &amp; Home Improvement", "Toys &amp; Games", "Video Games"

```csharp
public string Department { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Keyword**

keyword
 <br>required field
 <br>you can also specify UPC/EAN in this field and we will return the results Google Shopping provides for the specified barcode number;
 <br>you can specify up to 700 symbols in the keyword filed
 <br>all %## will be decoded (plus symbol ‘+’ will be decoded to a space character)
 <br>if you need to use the “%” symbol for your keyword, please specify it as “%25”;

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
 <br>https://www.google.com/search?q=iphone&amp;num=100&amp;tbm=shop&amp;ie=UTF-8&amp;oe=UTF-8&amp;tbs=vw%3A1%2Cmr%3A1%2Cprice%3A1%2Cppr_min%3A5&amp;hl=en&amp;gl=US&amp;gws_rd=cr&amp;uule=w+CAIQIFISCQs2MuSEtepUEUK33kOSuTsc

```csharp
public string Url { get; set; }
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

full name of the location
 <br>required field if you don’t specify location_code or location_coordinate
 <br>if you use this field, you don’t need to specify location_code or location_coordinate
 <br>you can receive the list of available Google Shopping locations with their location_name by making a separate request to the https://api.dataforseo.com/v3/merchant/google/locations
 <br>example:
 <br>London,England,United Kingdom

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code
 <br>required field if you don’t specify location_name or location_coordinate
 <br>if you use this field, you don’t need to specify location_name or location_coordinate
 <br>you can receive the list of available Google Shopping locations with their location_code by making a separate request to the https://api.dataforseo.com/v3/merchant/google/locations
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
 <br>the minimum value for “radius”: 199.9
 <br>example:
 <br>53.476225,-2.243572,200

```csharp
public string LocationCoordinate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageName**

full name of the language
 <br>required field if you don’t specify language_code
 <br>if you use this field, you don’t need to specify language_code
 <br>you can receive the list of available Google Shopping languages with their language_name by making a separate request to the https://api.dataforseo.com/v3/merchant/google/languages
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
 <br>if you use this field, you don’t need to specify language_name
 <br>you can receive the list of available Google Shopping languages with their language_code by making a separate request to the https://api.dataforseo.com/v3/merchant/google/languages
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

### **Depth**

parsing depth
 <br>optional field
 <br>number of results to be retrieved from the Google Shopping results page
 <br>default value: 100
 <br>max value: 700
 <br>Note: your account will be billed per each results page containing up to 100 results;
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
 <br>max value: 7
 <br>Note: the max_crawl_pages and depth parameters complement each other;
 <br>learn more at our help center

```csharp
public Nullable<int> MaxCrawlPages { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SearchParam**

additional parameters of the search query
 <br>optional field
 <br>you can use the following search URL parameters for customizing the search
 <br>example:
 <br>&amp;tbs=ppr_min:45 – search for products that cost more than 45 USD;
 <br>&amp;tbs=ppr_max:50 – search for products that cost less than 50 USD;
 <br>&amp;tbs=p_ord:p – sort by ascending price;
 <br>&amp;tbs=p_ord:pd – sort by descending price;
 <br>&amp;tbs=p_ord:rv – sort by review score;
 <br>&amp;tbs=ppr_max:50,p_ord:rv – sort by review score with the maximum price of 50 USD

```csharp
public string SearchParam { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PriceMin**

minimum product price
 <br>optional field
 <br>minimum price of the returned products listed on Google Shopping for the specified query
 <br>example:
 <br>5

```csharp
public Nullable<int> PriceMin { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PriceMax**

maximum product price
 <br>optional field
 <br>maximum price of the returned products listed on Google Shopping for the specified query
 <br>example:
 <br>100

```csharp
public Nullable<int> PriceMax { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SortBy**

results sorting rules
 <br>optional field
 <br>the following sorting rules are supported:
 <br>review_score, price_low_to_high, price_high_to_low
 <br>example:
 <br>sort_by:"review_score"

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

### **MerchantAmazonProductsTaskPostRequestInfo()**

```csharp
public MerchantAmazonProductsTaskPostRequestInfo()
```
