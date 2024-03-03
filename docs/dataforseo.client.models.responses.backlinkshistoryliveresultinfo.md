# BacklinksHistoryLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BacklinksHistoryLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksHistoryLiveResultInfo](./dataforseo.client.models.responses.backlinkshistoryliveresultinfo.md)

## Properties

### **Target**

target from the POST array

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

### **ItemsCount**

the number of results returned in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

contains historical backlink data for the specified domain
 <br>the data is provided month-by-month;
 <br>the metrics are aggregated according to the backlinks the specified domain had on the first day of each given month

```csharp
public ICollection<BacklinksHistoryLiveItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BacklinksHistoryLiveItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksHistoryLiveResultInfo()**

```csharp
public BacklinksHistoryLiveResultInfo()
```
