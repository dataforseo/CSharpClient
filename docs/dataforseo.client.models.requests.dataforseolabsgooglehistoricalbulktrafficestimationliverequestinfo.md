# DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo](./dataforseo.client.models.requests.dataforseolabsgooglehistoricalbulktrafficestimationliverequestinfo.md)

## Properties

### **Targets**

target domains and subdomains
 <br>required field
 <br>you can specify domains and subdomains in this field;
 <br>domains and subdomains should be specified without https:// and www.;
 <br>you can set up to 1000 domains or subdomains

```csharp
public ICollection<string> Targets { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **LocationName**

full name of the location
 <br>if you use this field, you don’t have to specify location_code
 <br>you can receive the list of available locations with their location_name by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>ignore this field to get the results for all available locations
 <br>example:
 <br>United Kingdom

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code
 <br>if you use this field, you don’t have to specify location_name
 <br>you can receive the list of available locations with their location_code by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>ignore this field to get the results for all available locations
 <br>example:
 <br>2840

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageName**

full name of the language
 <br>if you use this field, you don’t need to specify language_code
 <br>you can receive the list of available languages with their language_name by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>ignore this field to get the results for all available languages
 <br>example:
 <br>English

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

language code
 <br>if you use this field, you don’t need to specify language_name
 <br>you can receive the list of available languages with their language_code by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
 <br>ignore this field to get the results for all available languages
 <br>example:
 <br>en

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateFrom**

starting date of the time range
 <br>optional field
 <br>if you don’t specify this field, the data will be provided for the previous 12 months
 <br>minimal possible value: 2020-10-01
 <br>date format: "yyyy-mm-dd"

```csharp
public string DateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateTo**

ending date of the time range
 <br>optional field
 <br>if you don’t specify this field, the today’s date will be used by default;
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2021-04-01"

```csharp
public string DateTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ItemTypes**

display results by item type
 <br>optional field
 <br>indicates the type of search results included in the response;
 <br>Note: if the item_types array contains item types that are different from organic, the results will be ordered by the first item type in the array;
 <br>possible values:
 <br>["organic", "paid", "featured_snippet", "local_pack"]
 <br>default value:
 <br>["organic", "paid"]

```csharp
public ICollection<string> ItemTypes { get; set; }
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

### **DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo()**

```csharp
public DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo()
```
