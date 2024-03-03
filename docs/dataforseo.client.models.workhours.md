# WorkHours

Namespace: DataForSeo.Client.Models

```csharp
public class WorkHours
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [WorkHours](./dataforseo.client.models.workhours.md)

## Properties

### **Timetable**

work hours timetable

```csharp
public IDictionary<string, ICollection<WorkDayInfo>> Timetable { get; set; }
```

#### Property Value

[IDictionary&lt;String, ICollection&lt;WorkDayInfo&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **CurrentStatus**

current status of the establishment
 <br>indicates whether the establishment is opened or closed

```csharp
public string CurrentStatus { get; set; }
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

### **WorkHours()**

```csharp
public WorkHours()
```
