# TrendsGraphDataInfo

Namespace: DataForSeo.Client.Models

```csharp
public class TrendsGraphDataInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TrendsGraphDataInfo](./dataforseo.client.models.trendsgraphdatainfo.md)

## Properties

### **DateFrom**

start date of the corresponding time range
 <br>in the UTC format: “yyyy-mm-dd”

```csharp
public string DateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateTo**

end date of the corresponding time range
 <br>in the UTC format: “yyyy-mm-dd”

```csharp
public string DateTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Timestamp**

a point in time in the Unix time format

```csharp
public Nullable<int> Timestamp { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MissingData**

indicates whether the data is unavailable
 <br>if true the data on the graph in the Google Trends interface is missing and thus labelled with a dotted line

```csharp
public Nullable<bool> MissingData { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Values**

relative keyword popularity rate at a specific timestamp
 <br>represents the keyword popularity rate over the given time range
 <br>if you specify more than one keyword, the values will be averaged to the highest value across all specified keywords
 <br>a value of 100 is the peak popularity for the term. A value of 50 means that the term is half as popular. A score of 0 means there was not enough data for this term

```csharp
public ICollection<Nullable<int>> Values { get; set; }
```

#### Property Value

[ICollection&lt;Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **TrendsGraphDataInfo()**

```csharp
public TrendsGraphDataInfo()
```
