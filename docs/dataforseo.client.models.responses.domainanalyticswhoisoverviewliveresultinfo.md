# DomainAnalyticsWhoisOverviewLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DomainAnalyticsWhoisOverviewLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainAnalyticsWhoisOverviewLiveResultInfo](./dataforseo.client.models.responses.domainanalyticswhoisoverviewliveresultinfo.md)

## Properties

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
public ICollection<DomainAnalyticsWhoisOverviewLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;DomainAnalyticsWhoisOverviewLiveItem&gt;](./dataforseo.client.models.domainanalyticswhoisoverviewliveitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DomainAnalyticsWhoisOverviewLiveResultInfo()**

```csharp
public DomainAnalyticsWhoisOverviewLiveResultInfo()
```
