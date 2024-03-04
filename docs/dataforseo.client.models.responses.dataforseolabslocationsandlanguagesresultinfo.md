# DataforseoLabsLocationsAndLanguagesResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DataforseoLabsLocationsAndLanguagesResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsLocationsAndLanguagesResultInfo](./dataforseo.client.models.responses.dataforseolabslocationsandlanguagesresultinfo.md)

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
 <br>the value will be null as Country is the only supported location_type for this API

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
 <br>possible values:
 <br>Country

```csharp
public string LocationType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AvailableLanguages**

supported languages
 <br>contains the languages which are supported for a specific location

```csharp
public ICollection<AvailableLanguages> AvailableLanguages { get; set; }
```

#### Property Value

[ICollection&lt;AvailableLanguages&gt;](./dataforseo.client.models.availablelanguages.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsLocationsAndLanguagesResultInfo()**

```csharp
public DataforseoLabsLocationsAndLanguagesResultInfo()
```
