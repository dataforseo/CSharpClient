# DataforseoLabsGoogleSearchIntentLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DataforseoLabsGoogleSearchIntentLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleSearchIntentLiveResultInfo](./dataforseo.client.models.responses.dataforseolabsgooglesearchintentliveresultinfo.md)

## Properties

### **LanguageCode**

language code in a POST array
 <br>if there is no data, then the value is null

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

array of items with relevant traffic estimation data

```csharp
public ICollection<DataforseoLabsGoogleSearchIntentLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;DataforseoLabsGoogleSearchIntentLiveItem&gt;](./dataforseo.client.models.dataforseolabsgooglesearchintentliveitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsGoogleSearchIntentLiveResultInfo()**

```csharp
public DataforseoLabsGoogleSearchIntentLiveResultInfo()
```
