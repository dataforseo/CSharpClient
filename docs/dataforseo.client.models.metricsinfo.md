[`< Back`](./)

---

# MetricsInfo

Namespace: DataForSeo.Client.Models

```csharp
public class MetricsInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MetricsInfo](./dataforseo.client.models.metricsinfo)

## Properties

### **Pos1**

number of organic SERPs where the domain ranks #1

```csharp
public Nullable<int> Pos1 { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pos23**

number of organic SERPs where the domain ranks #2-3

```csharp
public Nullable<int> Pos23 { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pos410**

number of organic SERPs where the domain ranks #4-10

```csharp
public Nullable<int> Pos410 { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pos1120**

number of organic SERPs where the domain ranks #11-20

```csharp
public Nullable<int> Pos1120 { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pos2130**

number of organic SERPs where the domain ranks #21-30

```csharp
public Nullable<int> Pos2130 { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pos3140**

number of organic SERPs where the domain ranks #31-40

```csharp
public Nullable<int> Pos3140 { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pos4150**

number of organic SERPs where the domain ranks #41-50

```csharp
public Nullable<int> Pos4150 { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pos5160**

number of organic SERPs where the domain ranks #51-60

```csharp
public Nullable<int> Pos5160 { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pos6170**

number of organic SERPs where the domain ranks #61-70

```csharp
public Nullable<int> Pos6170 { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pos7180**

number of organic SERPs where the domain ranks #71-80

```csharp
public Nullable<int> Pos7180 { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pos8190**

number of organic SERPs where the domain ranks #81-90

```csharp
public Nullable<int> Pos8190 { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pos91100**

number of organic SERPs where the domain ranks #91-100

```csharp
public Nullable<int> Pos91100 { get; set; }
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

### **ImpressionsEtv**

estimated traffic volume based on impressions
 <br>estimated organic monthly traffic to the domain
 <br>calculated as the product of CTR (click-through-rate) and impressions values of all keywords the domain ranks for
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> ImpressionsEtv { get; set; }
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

### **EstimatedPaidTrafficCost**

estimated cost of converting organic search traffic into paid
 <br>represents the estimated monthly cost of running ads (USD) for all keywords a domain ranks for
 <br>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> EstimatedPaidTrafficCost { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsNew**

number of new ranked elements
 <br>indicates how many new ranked elements were found for this domain

```csharp
public Nullable<long> IsNew { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsUp**

rank went up
 <br>indicates how many ranked elements of this domain went up in Google Search

```csharp
public Nullable<long> IsUp { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsDown**

rank went down
 <br>indicates how many ranked elements of this domain went down in Google Search

```csharp
public Nullable<long> IsDown { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsLost**

lost ranked elements
 <br>indicates how many ranked elements of this domain were previously presented in SERPs, but weren’t found during the last check

```csharp
public Nullable<long> IsLost { get; set; }
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

### **MetricsInfo()**

```csharp
public MetricsInfo()
```

---

[`< Back`](./)
