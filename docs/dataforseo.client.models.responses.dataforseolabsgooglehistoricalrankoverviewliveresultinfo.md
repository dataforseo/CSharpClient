# DataforseoLabsGoogleHistoricalRankOverviewLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DataforseoLabsGoogleHistoricalRankOverviewLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleHistoricalRankOverviewLiveResultInfo](./dataforseo.client.models.responses.dataforseolabsgooglehistoricalrankoverviewliveresultinfo.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Target**

target domain in a POST array

```csharp
public string Target { get; set; }
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

### **TotalCount**

total amount of results in our database relevant to your request

```csharp
public Nullable<long> TotalCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ItemsCount**

the number of results returned in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

contains historical ranking and traffic data

```csharp
public ICollection<DataforseoLabsGoogleHistoricalRankOverviewLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;DataforseoLabsGoogleHistoricalRankOverviewLiveItem&gt;](./dataforseo.client.models.dataforseolabsgooglehistoricalrankoverviewliveitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsGoogleHistoricalRankOverviewLiveResultInfo()**

```csharp
public DataforseoLabsGoogleHistoricalRankOverviewLiveResultInfo()
```
