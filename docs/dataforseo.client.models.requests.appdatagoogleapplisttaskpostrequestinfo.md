# AppDataGoogleAppListTaskPostRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class AppDataGoogleAppListTaskPostRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppDataGoogleAppListTaskPostRequestInfo](./dataforseo.client.models.requests.appdatagoogleapplisttaskpostrequestinfo.md)

## Properties

### **AppCollection**

app collection
 <br>required field
 <br>app collection on Google Play from which apps will be collected;
 <br>you can specify the following values:
 <br>featured, topselling_paid, topselling_free, topselling_new_free, topselling_new_paid, topgrossing, movers_shakers
 <br>Note: if featured is selected, the app_category parameter cannot be used

```csharp
public string AppCollection { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationName**

full name of search engine location
 <br>required field if you don’t specify location_code
 <br>if you use this field, you don’t need to specify location_code
 <br>you can receive the list of available locations of the search engine with their location_name by making a separate request to https://api.dataforseo.com/v3/app_data/google/locations
 <br>example:
 <br>West Los Angeles,California,United States

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

search engine location code
 <br>required field if you don’t specify location_name
 <br>if you use this field, you don’t need to specify location_name
 <br>you can receive the list of available locations of the search engine with their location_code by making a separate request to https://api.dataforseo.com/v3/app_data/google/locations
 <br>example:
 <br>9061121

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageName**

full name of search engine language
 <br>optional field
 <br>if you use this field, you don’t need to specify language_code
 <br>you can receive the list of available languages with language_name by making a separate request to https://api.dataforseo.com/v3/app_data/google/languages
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
 <br>if you use this field, you don’t need to specify language_name
 <br>you can receive the list of available languages with their language_code by making a separate request to https://api.dataforseo.com/v3/app_data/google/languages
 <br>example:
 <br>en

```csharp
public string LanguageCode { get; set; }
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

### **Depth**

parsing depth
 <br>optional field
 <br>number of apps to be returned in the API response;
 <br>we strongly recommend setting the parsing depth in the multiples of 100, because our system processes 100 results in a row;
 <br>default value: 100;
 <br>maximum value: 200

```csharp
public Nullable<int> Depth { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AppCategory**

application category on Google Play
 <br>optional field
 <br>you can filter the results by app category;
 <br>example:
 <br>family;
 <br>you can receive the full list of available categories by making a separate request to https://api.dataforseo.com/v3/app_data/google/categories
 <br>Note: app_category cannot be used if app_collection parameter is set to featured

```csharp
public string AppCategory { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AgeRating**

filter results by age rating
 <br>optional field
 <br>you can use this field to filter the results by age rating;
 <br>possible types of filtering:
 <br>ages_up_to_5 — return apps approved for children up to 5 years old;
 <br>ages_6_8 — return apps approved for children from 6 to 8 years old;
 <br>ages_9_12 — return apps approved for children from 9 to 12 years old;
 <br>by default, the API returns apps for all ages;
 <br>Note: this filter works only in conjunction with the "category": "family" parameter

```csharp
public string AgeRating { get; set; }
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

### **AppDataGoogleAppListTaskPostRequestInfo()**

```csharp
public AppDataGoogleAppListTaskPostRequestInfo()
```
