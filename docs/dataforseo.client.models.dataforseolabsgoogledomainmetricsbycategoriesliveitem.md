[`< Back`](./)

---

# DataforseoLabsGoogleDomainMetricsByCategoriesLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsGoogleDomainMetricsByCategoriesLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleDomainMetricsByCategoriesLiveItem](./dataforseo.client.models.dataforseolabsgoogledomainmetricsbycategoriesliveitem)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TopCategories**

categories for which domains are collected

```csharp
public ICollection<Nullable<int>> TopCategories { get; set; }
```

#### Property Value

[ICollection&lt;Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **OrganicEtv**

current organic ETV of the domain

```csharp
public Nullable<float> OrganicEtv { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OrganicCount**

current total count of organic SERPs that contain the domain

```csharp
public Nullable<long> OrganicCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OrganicIsLost**

current number of lost ranked elements
 <br>indicates how many ranked elements of the domain were previously presented in SERPs, but weren’t found during the last check

```csharp
public Nullable<int> OrganicIsLost { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **OrganicIsNew**

current number of new ranked elements
 <br>indicates how many new ranked elements were found for the domain

```csharp
public Nullable<int> OrganicIsNew { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Domain**

domain found for the specified category

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MainDomain**

primary domain

```csharp
public string MainDomain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MetricsHistory**

historical ranking and traffic data of the domain

```csharp
public IDictionary<string, IDictionary<string, MetricsInfo>> MetricsHistory { get; set; }
```

#### Property Value

[IDictionary&lt;String, IDictionary&lt;String, MetricsInfo&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **MetricsDifference**

metrics difference between first_date and second_date
 <br>calculated by subtracting domain metrics as of the greater date from domain metrics as of the smaller date

```csharp
public IDictionary<string, MetricsInfo> MetricsDifference { get; set; }
```

#### Property Value

[IDictionary&lt;String, MetricsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsGoogleDomainMetricsByCategoriesLiveItem()**

```csharp
public DataforseoLabsGoogleDomainMetricsByCategoriesLiveItem()
```

---

[`< Back`](./)
