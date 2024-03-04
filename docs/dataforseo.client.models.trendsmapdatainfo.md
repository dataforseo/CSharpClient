[`< Back`](./)

---

# TrendsMapDataInfo

Namespace: DataForSeo.Client.Models

```csharp
public class TrendsMapDataInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TrendsMapDataInfo](./dataforseo.client.models.trendsmapdatainfo)

## Properties

### **GeoId**

Google Trends location identifier
 <br>you can use this field for matching obtained results with location parameters specified in the request
 <br>example:
 <br>US-NY

```csharp
public string GeoId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GeoName**

Google Trends location name
 <br>you can use this field for matching obtained results with location parameters specified in the request

```csharp
public string GeoName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Values**

relative keyword popularity rate in a given location
 <br>represents the location-specific keyword popularity rate over the given time range
 <br>if you specify more than one keyword, the values will be averaged to the highest value across all specified keywords
 <br>a value of 100 is the peak popularity for the term
 <br>a value of 50 means that the term is half as popular
 <br>a value of 0 means there was not enough data for this term

```csharp
public ICollection<Nullable<int>> Values { get; set; }
```

#### Property Value

[ICollection&lt;Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **MaxValueIndex**

max value among comparable terms
 <br>represents the maximum value if you specified more than two keywords in a POST array
 <br>if you specified only one keyword, the value will be null

```csharp
public Nullable<int> MaxValueIndex { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **TrendsMapDataInfo()**

```csharp
public TrendsMapDataInfo()
```

---

[`< Back`](./)
