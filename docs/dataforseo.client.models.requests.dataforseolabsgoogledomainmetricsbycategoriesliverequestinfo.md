[`< Back`](./)

---

# DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo](./dataforseo.client.models.requests.dataforseolabsgoogledomainmetricsbycategoriesliverequestinfo)

## Properties

### **CategoryCodes**

product and service categories
 <br>required field
 <br>The maximum number of categories you can specify: 5
 <br>you can download the full list of possible categories

```csharp
public ICollection<string> CategoryCodes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **FirstDate**

first date of comparison period
 <br>required field
 <br>first date for which domain metrics will be provided;
 <br>date format: "yyyy-mm-dd";
 <br>example: "2021-06-01";
 <br>the list available dates is available through the available history endpoint;
 <br>Note: first_date cannot be greater than today’s date;
 <br>Also note: the dates specified in first_date and second_date cannot point to the same month of the same year;
 <br>you can specify the dates in any order: first_date can be greater than second_date and vice versa;
 <br>minimum date: "2020-10-01"

```csharp
public string FirstDate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SecondDate**

second date of comparison period
 <br>required field
 <br>second date for which domain metrics will be provided;
 <br>date format: "yyyy-mm-dd";
 <br>example: "2021-10-01";
 <br>the list available dates is available through the available history endpoint;
 <br>Note: second_date cannot be greater than today’s date;
 <br>Also note: the dates specified in first_date and second_date cannot point to the same month of the same year;
 <br>you can specify the dates in any order: second_date can be greater than first_date and vice versa;
 <br>minimum date: "2020-10-01"

```csharp
public string SecondDate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationName**

full name of the location
 <br>required field if you don’t specify location_code
 <br>Note: it is required to specify either location_name or location_code;
 <br>you can receive the list of available locations with their location_name by making a separate request to
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
 <br>example:
 <br>United Kingdom

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

unique location identifier
 <br>required field if you don’t specify location_name
 <br>Note: it is required to specify either location_name or location_code;
 <br>you can receive the list of available locations with their location_code by making a separate request to
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
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
 <br>Note: it is required to specify either language_name or language_code;
 <br>you can receive the list of available languages with their language_name by making a separate request to
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
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
 <br>Note: it is required to specify either language_name or language_code;
 <br>you can receive the list of available languages with their language_code by making a separate request to https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
 <br>example:
 <br>en

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ItemTypes**

display results by item type
 <br>optional field
 <br>indicates the type of search results included in the response;
 <br>Note: if the item_types array contains item types that are different from the organic object, the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search results not included in the response;
 <br>possible values:
 <br>["organic", "paid", "featured_snippet", "local_pack"];
 <br>default value:
 <br>["organic", "paid"]

```csharp
public ICollection<string> ItemTypes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **TopCategoriesCount**

number of additional domain categories
 <br>optional field
 <br>by using this parameter, you can receive domains relevant to additional categories that are not specified in category_codes above;
 <br>to learn more about the parameter, please refer to this help center article;
 <br>by default, top_categories_count is equal to the number of categories specified in the category_codes array;
 <br>Note: top_categories_count cannot be less than the number of categories in the category_codes array;
 <br>maximum value: 5

```csharp
public Nullable<long> TopCategoriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IncludeSubdomains**

return subdomains in the API response
 <br>optional field
 <br>if false, the API response will contain main_domain only;
 <br>if true, the API will return main_domain plus its subdomains (if available);
 <br>default value: true

```csharp
public Nullable<bool> IncludeSubdomains { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **EtvMin**

minimum current organic ETV of the domain
 <br>optional field
 <br>if specified, the API will return only domains with organic_etv greater than the specified value

```csharp
public Nullable<int> EtvMin { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **EtvMax**

maximum current organic ETV of the domain
 <br>optional field
 <br>if specified, the API will return only domains with organic_etv lesser than the specified value

```csharp
public Nullable<int> EtvMax { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Correlate**

correlate data with previously obtained datasets
 <br>optional field
 <br>default value: true;
 <br>if you use this parameter, our system will correlate data you obtain now with previously obtained datasets;
 <br>this parameter is intended to mitigate any inconsistencies that may result from changes to our database;
 <br>Note: we do not recommend setting correlate to false

```csharp
public Nullable<bool> Correlate { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Limit**

the maximum number of domains in the results array
 <br>optional field
 <br>default value: 100;
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned domains
 <br>optional field
 <br>default value: 0;
 <br>if you specify the 10 value, the first ten domains in the results array will be omitted and the data will be provided for the successive domains

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum);
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like, not_like;
 <br>you can use the % operator with like and not_like to match any string of zero or more characters;
 <br>example:
 <br>["metrics_history.202110.organic.pos_1", "&gt;", 15];
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
 <br>default rule: ["organic_etv,desc"];
 <br>possible sorting types:
 <br>asc – results will be sorted in ascending order
 <br>desc – results will be sorted in descending order;
 <br>you should use a comma to set up a sorting type;
 <br>example:
 <br>["organic_count,desc"];
 <br>note that you can set no more than three sorting rules in a single request;
 <br>you should use a comma to separate several sorting rules;
 <br>example:
 <br>["organic_etv,desc","organic_count,asc"]

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Tag**

user-defined task identifier
 <br>optional field
 <br>the character limit is 255;
 <br>you can use this parameter to identify the task and match it with the result;
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

### **DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo()**

```csharp
public DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo()
```

---

[`< Back`](./)
