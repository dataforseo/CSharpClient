# AppDataGoogleLocationsResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class AppDataGoogleLocationsResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppDataGoogleLocationsResultInfo](./dataforseo.client.models.responses.appdatagooglelocationsresultinfo.md)

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

### **LocationNameParent**

the name of the superordinate location
 <br>example:
 <br>"location_code": 1006473,
 <br>"location_name": "Altrincham,England,United Kingdom",
 <br>"location_name_parent": "England,United Kingdom", where location_name_parent corresponds to:
 <br>"location_code": 20339,
 <br>"location_name": "England,United Kingdom"

```csharp
public string LocationNameParent { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CountryIsoCode**

ISO country code of the location

```csharp
public string CountryIsoCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationType**

location type

```csharp
public string LocationType { get; set; }
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

### **AppDataGoogleLocationsResultInfo()**

```csharp
public AppDataGoogleLocationsResultInfo()
```