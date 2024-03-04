# MerchantGoogleSellersTaskPostRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class MerchantGoogleSellersTaskPostRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MerchantGoogleSellersTaskPostRequestInfo](./dataforseo.client.models.requests.merchantgooglesellerstaskpostrequestinfo.md)

## Properties

### **ProductId**

unique product identifier on Google Shopping
 <br>required field
 <br>you can get this value making a separate request to the Google Shopping Products endpoint
 <br>note that there is no full list of possible values as the product_id is a dynamic value assigned by Google
 <br>example:
 <br>4485466949985702538
 <br>learn more about the parameter in this help center guide

```csharp
public string ProductId { get; set; }
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

### **GetShopsOnGoogle**

include “buy on Google” shops
 <br>optional field
 <br>if set to true, the response will contain the list of sellers that allow to purchase a given product directly on Google
 <br>Note: if set to true, the cost of a task will be doubled

```csharp
public Nullable<bool> GetShopsOnGoogle { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalSpecifications**

object containing additional url parameters
 <br>you can get additional information about the product by using the "additional_specifications object, which you can get by making a separate request to the Google Shopping Products endpoint
 <br>example:
 <br>"additional_specifications": {
 <br>"eto": "16157121050167572763_0"
 <br>}

```csharp
public IDictionary<string, string> AdditionalSpecifications { get; set; }
```

#### Property Value

[IDictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

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

### **MerchantGoogleSellersTaskPostRequestInfo()**

```csharp
public MerchantGoogleSellersTaskPostRequestInfo()
```
