# BusinessDataBusinessListingsSearchLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BusinessDataBusinessListingsSearchLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataBusinessListingsSearchLiveRequestInfo](./dataforseo.client.models.requests.businessdatabusinesslistingssearchliverequestinfo.md)

## Properties

### **Categories**

business categories
 <br>optional field
 <br>the categories you specify are used to search for business listings;
 <br>if you don’t use this field, we will return business listings found in the specified location;
 <br>you can specify up to 10 categories

```csharp
public ICollection<string> Categories { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Description**

description of the element in SERP
 <br>optional field
 <br>the description of the business entity for which the results are collected;
 <br>can contain up to 200 symbols

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the element in SERP
 <br>optional field
 <br>the name of the business entity for which the results are collected;
 <br>can contain up to 200 symbols

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsClaimed**

indicates whether the business is verified by its owner on Google Maps
 <br>optional field

```csharp
public Nullable<bool> IsClaimed { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LocationCoordinate**

GPS coordinates of a location
 <br>optional field
 <br>location_coordinate parameter should be specified in the “latitude,longitude,radius” format
 <br>the maximum number of decimal digits for “latitude” and “longitude”: 7
 <br>the minimum value for “radius”: 1
 <br>the maximum value for “radius”: 100000
 <br>example:
 <br>53.476225,-2.243572,200

```csharp
public string LocationCoordinate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Filters**

array of results filtering parameters
 <br>optional field
 <br>you can add several filters at once (8 filters maximum)
 <br>you should set a logical operator and, or between the conditions
 <br>the following operators are supported:
 <br>regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt; &gt;, in, not_in, like, not_like
 <br>you can use the % operator with like and not_like to match any string of zero or more characters
 <br>example:
 <br>["rating.value","&gt;",3]
 <br>you can receive the list of available filters by making a separate request to https://api.dataforseo.com/v3/business_data/business_listings/available_filters

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
 <br>you should use a comma to set up a sorting parameter
 <br>example:
 <br>["rating.value,desc"]note that you can set no more than three sorting rules in a single request
 <br>you should use a comma to separate several sorting rules
 <br>example:
 <br>["rating.value,desc","rating.votes_count,desc"]

```csharp
public ICollection<string> OrderBy { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Limit**

the maximum number of returned businesses
 <br>optional field
 <br>default value: 100
 <br>maximum value: 1000

```csharp
public Nullable<int> Limit { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Offset**

offset in the results array of returned businesses
 <br>optional field
 <br>default value: 0
 <br>if you specify the 10 value, the first ten entities in the results array will be omitted and the data will be provided for the successive entities

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OffsetToken**

token for subsequent requests
 <br>optional field
 <br>provided in the identical filed of the response to each request;
 <br>use this parameter to avoid timeouts while trying to obtain over 100,000 results in a single request;
 <br>by specifying the unique offset_token value from the response array, you will get the subsequent results of the initial task;
 <br>offset_token values are unique for each subsequent task
 <br>Note: if the offset_token is specified in the request, all other parameters should be identical to the previous request

```csharp
public string OffsetToken { get; set; }
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

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataBusinessListingsSearchLiveRequestInfo()**

```csharp
public BusinessDataBusinessListingsSearchLiveRequestInfo()
```
