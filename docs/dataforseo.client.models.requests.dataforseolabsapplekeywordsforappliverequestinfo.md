# DataforseoLabsAppleKeywordsForAppLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DataforseoLabsAppleKeywordsForAppLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsAppleKeywordsForAppLiveRequestInfo](./dataforseo.client.models.requests.dataforseolabsapplekeywordsforappliverequestinfo.md)

## Properties

### **AppId**

id of the app
 <br>required field
 <br>ID of the mobile application on App Store;
 <br>you can find the ID in the URL of every app listed on App Store;
 <br>example:
 <br>in the URL https://apps.apple.com/us/app/id835599320
 <br>the id is 835599320

```csharp
public string AppId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationName**

full name of the location
 <br>required field if you don’t specify location_code
 <br>Note: it is required to specify either location_name or location_code
 <br>you can receive the list of available locations with their location_name by making a separate request to
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
 <br>Note: this endpoint currently supports the US location only;
 <br>example:
 <br>United States

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code
 <br>required field if you don’t specify location_name
 <br>Note: it is required to specify either location_name or location_code
 <br>you can receive the list of available locations with their location_code by making a separate request to
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
 <br>Note: this endpoint currently supports the US location only;
 <br>example:
 <br>2840

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageName**

full name of the language
 <br>required field if you don’t specify language_code
 <br>Note: it is required to specify either language_name or language_code
 <br>you can receive the list of available languages with their language_name by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
 <br>Note: this endpoint currently supports the English language only;
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
 <br>Note: it is required to specify either language_name or language_code
 <br>you can receive the list of available languages with their language_code by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
 <br>Note: this endpoint currently supports the English language only
 <br>example:
 <br>en

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>&lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in
 <br>example:
 <br>["keyword_data.keyword_info.search_volume","&gt;",500]
 <br>[["keyword_data.keyword_info.search_volume","&lt; &gt;",500],"and",["ranked_serp_element.serp_item.rank_group","&gt;=","10"]]
 <br>for more information about filters, please refer to Dataforseo Labs – Filters or this help center guide

```csharp
public ICollection<object> Filters { get; set; }
```

#### Property Value

[ICollection&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **OrderBy**

results sorting rules
 <br>optional field
 <br>you can use the same values as in the filters array to sort the results;
 <br>possible sorting types:
 <br>asc – results will be sorted in the ascending order;
 <br>desc – results will be sorted in the descending order;
 <br>you should use a comma to specify a sorting type;
 <br>example:
 <br>["ranked_serp_element.serp_item.rank_group,asc"]
 <br>Note: you can set no more than three sorting rules in a single request;
 <br>you should use a comma to separate several sorting rules;
 <br>example:
 <br>["ranked_serp_element.serp_item.rank_group,desc","keyword_data.keyword_info.search_volume,asc"]
 <br>default rule:
 <br>["keyword_data.keyword_info.search_volume,desc"]
 <br>Note: if the item_types array contains item types that are different from organic, the results will be ordered by the first item type in the array

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Limit**

the maximum number of returned keywords
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned keywords
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords

```csharp
public Nullable<int> Offset { get; set; }
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

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsAppleKeywordsForAppLiveRequestInfo()**

```csharp
public DataforseoLabsAppleKeywordsForAppLiveRequestInfo()
```