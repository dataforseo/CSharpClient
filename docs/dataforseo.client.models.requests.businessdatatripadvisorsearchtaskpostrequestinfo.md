# BusinessDataTripadvisorSearchTaskPostRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BusinessDataTripadvisorSearchTaskPostRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataTripadvisorSearchTaskPostRequestInfo](./dataforseo.client.models.requests.businessdatatripadvisorsearchtaskpostrequestinfo.md)

## Properties

### **Keyword**

keyword
 <br>required field
 <br>the keyword you specify should indicate a business category, company name, or a prominent place;
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
 <br>required field if you don’t specify location_code
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
 <br>required field if you don’t specify location_name
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

### **Depth**

parsing depth
 <br>optional field
 <br>number of search results to be returned from the API response
 <br>we strongly recommend setting the parsing depth in the multiples of thirty because our systems processes thirty search results in a row;
 <br>default value: 30;
 <br>maximum value: 210

```csharp
public Nullable<int> Depth { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

### **BusinessDataTripadvisorSearchTaskPostRequestInfo()**

```csharp
public BusinessDataTripadvisorSearchTaskPostRequestInfo()
```
