[`< Back`](./)

---

# MerchantAmazonLocationsResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class MerchantAmazonLocationsResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MerchantAmazonLocationsResultInfo](./dataforseo.client.models.responses.merchantamazonlocationsresultinfo)

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
 <br>"location_code": 9041134,
 <br>"location_name": "90290,California,United States",
 <br>"location_name_parent": "California,United States"

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

### **MerchantAmazonLocationsResultInfo()**

```csharp
public MerchantAmazonLocationsResultInfo()
```

---

[`< Back`](./)
