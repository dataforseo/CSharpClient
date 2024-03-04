# DataforseoLabsGoogleDomainWhoisOverviewLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DataforseoLabsGoogleDomainWhoisOverviewLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleDomainWhoisOverviewLiveResultInfo](./dataforseo.client.models.responses.dataforseolabsgoogledomainwhoisoverviewliveresultinfo.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
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

contains ranking and traffic data

```csharp
public ICollection<DataforseoLabsGoogleDomainWhoisOverviewLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;DataforseoLabsGoogleDomainWhoisOverviewLiveItem&gt;](./dataforseo.client.models.dataforseolabsgoogledomainwhoisoverviewliveitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsGoogleDomainWhoisOverviewLiveResultInfo()**

```csharp
public DataforseoLabsGoogleDomainWhoisOverviewLiveResultInfo()
```
