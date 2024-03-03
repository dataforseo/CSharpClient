# DataforseoLabsBingSerpCompetitorsLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DataforseoLabsBingSerpCompetitorsLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsBingSerpCompetitorsLiveRequestInfo](./dataforseo.client.models.requests.dataforseolabsbingserpcompetitorsliverequestinfo.md)

## Properties

### **Keywords**

keywords array
 <br>required field
 <br>the results will be based on the keywords you specify in this array
 <br>UTF-8 encoding;
 <br>the keywords will be converted to lowercase format;
 <br>a keyword should be at least 3 characters long;
 <br>you can specify the maximum of 200 keywords

```csharp
public ICollection<string> Keywords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **LocationName**

full name of the location
 <br>required field if you don’t specify location_code
 <br>Note: it is required to specify either location_name or location_code
 <br>you can receive the list of available locations with location_name parameters by making a separate request to
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

unique location identifier
 <br>required field if you don’t specify location_name
 <br>Note: it is required to specify either location_name or location_code
 <br>you can receive the list of available locations with their location_code parameters by making a separate request to
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
 <br>you can receive the list of available languages with their language_name parameters by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>example:
 <br>English

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

unique language identifier
 <br>required field if you don’t specify language_name
 <br>Note: it is required to specify either language_name or language_code
 <br>you can receive the list of available languages with their language_code parameters by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>example:
 <br>en

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IncludeSubdomains**

indicates if the subdomains will be included in the search
 <br>optional field
 <br>if set to false, the subdomains will be ignored
 <br>default value: true

```csharp
public Nullable<bool> IncludeSubdomains { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ItemTypes**

search results type
 <br>indicates type of search results included in the response
 <br>optional field
 <br>possible values:
 <br>["organic", "paid", "featured_snippet", "local_pack"]
 <br>default value:
 <br>["organic", "paid", "featured_snippet", "local_pack"]

```csharp
public ICollection<string> ItemTypes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Limit**

the maximum number of returned domains
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned domains
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten domains in the results array will be omitted and the data will be provided for the successive domains

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like, not_like
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["median_position","in",[1,10]]
 <br>[["median_position","in",[1,10]],"and",["domain","not_like","%wikipedia.org%"]]
 <br>[["domain","not_like","%wikipedia.org%"],
 <br>"and",
 <br>[["relevant_serp_items","&gt;",0],"or",["median_position","in",[1,10]]]]
 <br>for more information about filters, please refer to Dataforseo Labs – Filters or this help center guide

```csharp
public ICollection<object> Filters { get; set; }
```

#### Property Value

[ICollection&lt;Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **OrderBy**

results sorting rules
 <br>optional field
 <br>you can use the same values as in the filters array to sort the results
 <br>possible sorting types:
 <br>asc – results will be sorted in the ascending order
 <br>desc – results will be sorted in the descending order
 <br>the comma is used as a separator
 <br>example:
 <br>["avg_position,asc"]
 <br>default rule:
 <br>["rating,desc"]
 <br>note that you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["avg_position,asc","etv,desc"]

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

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

### **DataforseoLabsBingSerpCompetitorsLiveRequestInfo()**

```csharp
public DataforseoLabsBingSerpCompetitorsLiveRequestInfo()
```
