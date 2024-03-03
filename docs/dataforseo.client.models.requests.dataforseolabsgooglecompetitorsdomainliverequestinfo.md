# DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo](./dataforseo.client.models.requests.dataforseolabsgooglecompetitorsdomainliverequestinfo.md)

## Properties

### **Target**

domain
 <br>required field
 <br>the domain name of the target website
 <br>the domain should be specified without https:// and www.

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationName**

full name of the location
 <br>required field if you don’t specify location_code
 <br>Note: it is required to specify either location_name or location_code
 <br>you can receive the list of available locations with their location_name by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>example:
 <br>United Kingdom

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code
 <br>required field if you don’t specify location_name
 <br>Note: it is required to specify either location_name or location_code
 <br>you can receive the list of available locations with their location_code by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
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
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
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
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
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
 <br>indicates the type of search results included in the response
 <br>Note: if the item_types array contains item types that are different from organic, the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search results not included in the response;
 <br>possible values:
 <br>["organic", "paid", "featured_snippet", "local_pack"]
 <br>default value:
 <br>["organic", "paid", "featured_snippet", "local_pack"]

```csharp
public ICollection<string> ItemTypes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in
 <br>example:
 <br>["metrics.organic.count","&gt;",50]
 <br>[["metrics.organic.pos_1","&lt; &gt;",0],"and",["metrics.organic.impressions_etv","&gt;=","10"]]
 <br>[[["metrics.organic.count","&gt;=",50],"and",["metrics.organic.pos_1","in",[1,5]]],
 <br>"or",
 <br>["metrics.organic.etv","&gt;=","100"]]
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
 <br>you should use a comma to specify a sorting type
 <br>example:
 <br>["metrics.paid.etv,asc"]
 <br>Note: you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["metrics.organic.etv,desc","metrics.paid.count,asc"]
 <br>default rule:
 <br>["metrics.organic.count,desc"]
 <br>Note: if the item_types array contains item types that are different from organic, the results will be ordered by the first item type in the array

```csharp
public ICollection<string> OrderBy { get; set; }
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
 <br>if you specify the 10 value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MaxRankGroup**

maximum rank up to which competitors will be considered
 <br>optional field
 <br>default value: 100
 <br>if you specify 10 here, we will extract competitors from the top 10 Google search results only

```csharp
public Nullable<int> MaxRankGroup { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ExcludeTopDomains**

indicates whether to exclude world’s largest websites
 <br>optional field
 <br>default value: false
 <br>set to true if you want to get highly-relevant competitors excluding the websites listed below:
 <br>wikipedia.org
 <br>pinterest.com
 <br>amazon.com
 <br>google.com
 <br>facebook.com
 <br>wordpress.com
 <br>medium.com
 <br>quora.com
 <br>reddit.com
 <br>youtube.com
 <br>ebay.com
 <br>uol.com.br
 <br>instagram.com
 <br>olx.com
 <br>twitter.com
 <br>linkedin.com
 <br>slideshare.net

```csharp
public Nullable<bool> ExcludeTopDomains { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IntersectingDomains**

additional domains for improving results accuracy
 <br>optional field
 <br>to improve the accuracy of the result, you can specify domains that are known to intersect with the target in SERPs;
 <br>if you use this array, metrics in the result will be based on SERPs where both target website and intersecting_domains appear;
 <br>Note: you can specify up to 20 domains in this array

```csharp
public ICollection<string> IntersectingDomains { get; set; }
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

### **DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo()**

```csharp
public DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo()
```
