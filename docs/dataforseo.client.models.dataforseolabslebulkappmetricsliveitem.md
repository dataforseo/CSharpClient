[`< Back`](./)

---

# DataforseoLabsleBulkAppMetricsLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsleBulkAppMetricsLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsleBulkAppMetricsLiveItem](./dataforseo.client.models.dataforseolabslebulkappmetricsliveitem)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AppId**

id of the app in a POST array

```csharp
public string AppId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Metrics**

metrics for the ranking keywords of the app
 <br>ranking data relevant to the keywords that the provided application ranks for on Google Play

```csharp
public IDictionary<string, AppMetricsInfo> Metrics { get; set; }
```

#### Property Value

[IDictionary&lt;String, AppMetricsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsleBulkAppMetricsLiveItem()**

```csharp
public DataforseoLabsleBulkAppMetricsLiveItem()
```

---

[`< Back`](./)
