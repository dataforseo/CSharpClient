# BusinessDataGoogleHotelInfoTaskPostRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BusinessDataGoogleHotelInfoTaskPostRequestInfo : BusinessDataTaskRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataTaskRequestInfo](./dataforseo.client.models.requests.businessdatataskrequestinfo.md) → [BusinessDataGoogleHotelInfoTaskPostRequestInfo](./dataforseo.client.models.requests.businessdatagooglehotelinfotaskpostrequestinfo.md)

## Properties

### **HotelIdentifier**

unique hotel identifier
 <br>required field if you don’t specify keyword
 <br>if you use this field, you don’t need to specify keyword
 <br>unique identifier of a hotel entity in Google search;
 <br>you can obtain the value by making a request to Advanced Google SERP API (enclosed in the hotels_pack element of the response), or the Hotel Searches endpoint of Business Data API
 <br>example:
 <br>ChYIq6SB--i6p6cpGgovbS8wN2s5ODZfEAE

```csharp
public string HotelIdentifier { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CheckIn**

check-in date
 <br>optional field
 <br>if you don’t specify this field, tomorrow’s date will be used by default;
 <br>the value must not be earlier than today’s date
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2019-01-15"

```csharp
public string CheckIn { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CheckOut**

check-out date
 <br>optional field
 <br>if you don’t specify this field, our system will apply the date of two days from now by default;
 <br>Note: the value cannot be less than or equal to check_in;
 <br>the range between check_in and check_out values cannot exceed 30 days
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2019-01-15"

```csharp
public string CheckOut { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Currency**

currency
 <br>optional field
 <br>example:
 <br>"USD"

```csharp
public string Currency { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Adults**

number of adults
 <br>optional field
 <br>if you don’t specify this field, two adults will be used by default
 <br>example:
 <br>1

```csharp
public Nullable<int> Adults { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Children**

number and age of children
 <br>optional field
 <br>if you don’t specify this field, no children will be included in the search;
 <br>set the following value if you want to include one 14-years-old child:
 <br>[14]
 <br>set the following value if you want to include one 13-years-old child and one 8-years-old child:
 <br>[13,8]

```csharp
public ICollection<string> Children { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

### **Keyword**

keyword
 <br>required field
 <br>the keyword you specify should indicate the name of the local establishment
 <br>you can specify up to 700 symbols in the keyword filed
 <br>all %## will be decoded (plus symbol ‘+’ will be decoded to a space character)
 <br>if you need to use the “%” symbol for your keyword, please specify it as “%25”; 
 <br>this field can also be used to pass the following parameters:
 <br>cid – a unique, google-defined id of the business entity;
 <br>place_id – an identifier of the business entity in Google Maps;
 <br>spp – a unique identifier of local services featured in the local_pack element of Google SERP
 <br>example:
 <br>cid:194604053573767737
 <br>place_id:GhIJQWDl0CIeQUARxks3icF8U8A
 <br>spp:CgsvZy8xdGN4cWRraBoUChIJPZDrEzLsZIgRoNrpodC5P30
 <br>learn more about the cid and place_id identifiers in this help center article

```csharp
public string Keyword { get; set; }
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
 <br>you can receive the list of available locations with location_name by making a separate request to https://api.dataforseo.com/v3/business_data/google/locations
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
 <br>you can receive the list of available locations with location_code by making a separate request to the https://api.dataforseo.com/v3/business_data/google/locations
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

full name of search engine language
 <br>required field if you don’t specify language_code
 <br>if you use this field, you don’t need to specify language_code
 <br>you can receive the list of available languages with language_name by making a separate request to https://api.dataforseo.com/v3/business_data/google/languages
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
 <br>you can receive the list of available languages with their language_code by making a separate request to https://api.dataforseo.com/v3/business_data/google/languages
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

### **BusinessDataGoogleHotelInfoTaskPostRequestInfo()**

```csharp
public BusinessDataGoogleHotelInfoTaskPostRequestInfo()
```
