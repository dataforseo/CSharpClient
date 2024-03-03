# PeriodCovered

Namespace: DataForSeo.Client.Models

```csharp
public class PeriodCovered
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PeriodCovered](./dataforseo.client.models.periodcovered.md)

## Properties

### **StartDate**

date and time when the period starts
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2020-03-02 02:00:00 +00:00

```csharp
public string StartDate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EndDate**

date and time when the period ends
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2022-12-09 02:00:00 +00:00

```csharp
public string EndDate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DisplayedDate**

period displayed in SERP
 <br>example:
 <br>Mar 2, 2020 - Dec 9, 2022

```csharp
public string DisplayedDate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **PeriodCovered()**

```csharp
public PeriodCovered()
```
