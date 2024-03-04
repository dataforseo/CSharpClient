# DataforseoLabsGoogleHistoricalSearchVolumeLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DataforseoLabsGoogleHistoricalSearchVolumeLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleHistoricalSearchVolumeLiveResultInfo](./dataforseo.client.models.responses.dataforseolabsgooglehistoricalsearchvolumeliveresultinfo.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code in a POST array

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageCode**

language code in a POST array

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ItemsCount**

the number of results returned in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

contains keywords and related data

```csharp
public ICollection<DataforseoLabsGoogleHistoricalSearchVolumeLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;DataforseoLabsGoogleHistoricalSearchVolumeLiveItem&gt;](./dataforseo.client.models.dataforseolabsgooglehistoricalsearchvolumeliveitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsGoogleHistoricalSearchVolumeLiveResultInfo()**

```csharp
public DataforseoLabsGoogleHistoricalSearchVolumeLiveResultInfo()
```
