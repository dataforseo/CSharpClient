[`< Back`](./)

---

# AppendixMoneyData

Namespace: DataForSeo.Client.Models

```csharp
public class AppendixMoneyData
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppendixMoneyData](./dataforseo.client.models.appendixmoneydata)

## Properties

### **Total**

total amount of money deposited to your account

```csharp
public Nullable<double> Total { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Balance**

amount of money left in your account

```csharp
public Nullable<double> Balance { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Limits**

cost limits

```csharp
public AppendixLimitsMoneyData Limits { get; set; }
```

#### Property Value

[AppendixLimitsMoneyData](./dataforseo.client.models.appendixlimitsmoneydata)<br>

### **Statistics**

statistics of your spending

```csharp
public AppendixStatisticsDataInfo Statistics { get; set; }
```

#### Property Value

[AppendixStatisticsDataInfo](./dataforseo.client.models.appendixstatisticsdatainfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AppendixMoneyData()**

```csharp
public AppendixMoneyData()
```

---

[`< Back`](./)
