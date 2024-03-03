# SerpBaiduLocationsResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class SerpBaiduLocationsResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SerpBaiduLocationsResultInfo](./dataforseo.client.models.responses.serpbaidulocationsresultinfo.md)

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
 <br>only City location_type is supported for all countries except China (where Country is also supported);
 <br>don’t match locations by location_code_parent because the results for Region and Country-level results for most countries are not supported by Baidu SERP API

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
 <br>only City is supported for all countries except China (where Country is also supported)

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

### **SerpBaiduLocationsResultInfo()**

```csharp
public SerpBaiduLocationsResultInfo()
```
