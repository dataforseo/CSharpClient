# DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo](./dataforseo.client.models.requests.dataforseolabsgooglehistoricalrankoverviewliverequestinfo.md)

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
 <br>you can receive the list of available locations with their language_name by making a separate request to the
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
 <br>you can receive the list of available locations with their language_code by making a separate request to the
 <br>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
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
 <br>if you don’t specify this field, the data will be provided for the previous 6 months
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
 <br>if you don’t specify this field, the today’s date will be used by default
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2021-04-01"

```csharp
public string DateTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Correlate**

correlate data with previously obtained datasets
 <br>optional field
 <br>default value: true
 <br>if you use this parameter, our system will correlate data you obtain now with previously obtained datasets
 <br>this parameter is intended to mitigate any inconsistencies that may result from changes to our database
 <br>we recommend always setting correlate to true

```csharp
public Nullable<bool> Correlate { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

### **DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo()**

```csharp
public DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo()
```
