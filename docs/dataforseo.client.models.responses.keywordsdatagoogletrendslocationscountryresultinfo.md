[`< Back`](./)

---

# KeywordsDataGoogleTrendsLocationsCountryResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class KeywordsDataGoogleTrendsLocationsCountryResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataGoogleTrendsLocationsCountryResultInfo](./dataforseo.client.models.responses.keywordsdatagoogletrendslocationscountryresultinfo)

## Properties

### **LocationCode**

location code

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LocationName**

full name of the location

```csharp
public string LocationName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCodeParent**

the code of the superordinate location
 <br>example:
 <br>"location_code": 9041134,
 <br>"location_name": "Vienna International Airport,Lower Austria,Austria",
 <br>"location_code_parent": 20044
 <br>where location_code_parent corresponds to:
 <br>"location_code": 20044,
 <br>"location_name": "Lower Austria,Austria"

```csharp
public Nullable<int> LocationCodeParent { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CountryIsoCode**

ISO country code of the location

```csharp
public string CountryIsoCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationType**

location type
 <br>possible values according to Google’s target types

```csharp
public string LocationType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GeoName**

google trends location name
 <br>you can use this field for matching obtained results with the location_name parameter specified in the request

```csharp
public string GeoName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GeoId**

google trends location identifier
 <br>you can use this field for matching obtained results with the location_code parameter specified in the request

```csharp
public string GeoId { get; set; }
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

### **KeywordsDataGoogleTrendsLocationsCountryResultInfo()**

```csharp
public KeywordsDataGoogleTrendsLocationsCountryResultInfo()
```

---

[`< Back`](./)
