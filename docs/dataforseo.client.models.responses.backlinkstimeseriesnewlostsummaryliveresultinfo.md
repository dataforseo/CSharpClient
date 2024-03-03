# BacklinksTimeseriesNewLostSummaryLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksTimeseriesNewLostSummaryLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksTimeseriesNewLostSummaryLiveResultInfo](./dataforseo.client.models.responses.backlinkstimeseriesnewlostsummaryliveresultinfo.md)

## Properties

### **Target**

target from a POST array

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateFrom**

starting date of the time range
 <br>in the UTC format: “yyyy-mm-dd”
 <br>example:
 <br>2019-01-01

```csharp
public string DateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateTo**

ending date of the time range
 <br>in the UTC format: "yyyy-mm-dd"
 <br>example:
 <br>"2019-01-15"

```csharp
public string DateTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GroupRange**

group_range from the POST array

```csharp
public string GroupRange { get; set; }
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

contains relevant backlinks and referring domains data

```csharp
public ICollection<BacklinksTimeseriesNewLostSummaryLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksTimeseriesNewLostSummaryLiveItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksTimeseriesNewLostSummaryLiveResultInfo()**

```csharp
public BacklinksTimeseriesNewLostSummaryLiveResultInfo()
```
