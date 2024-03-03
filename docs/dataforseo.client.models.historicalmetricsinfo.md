# HistoricalMetricsInfo

Namespace: DataForSeo.Client.Models

```csharp
public class HistoricalMetricsInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [HistoricalMetricsInfo](./dataforseo.client.models.historicalmetricsinfo.md)

## Properties

### **Year**

year for which the data is provided

```csharp
public Nullable<int> Year { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Month**

month for which the data is provided

```csharp
public Nullable<int> Month { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Etv**

estimated traffic volume
 <br>estimated organic monthly traffic to the domain
 <br>calculated as the product of CTR (click-through-rate) and search volume values of all keywords the domain ranks for
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> Etv { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Count**

total count of organic SERPs that contain the domain

```csharp
public Nullable<long> Count { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **HistoricalMetricsInfo()**

```csharp
public HistoricalMetricsInfo()
```
