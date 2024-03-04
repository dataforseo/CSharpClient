[`< Back`](./)

---

# BusyWorkingTimeInfo

Namespace: DataForSeo.Client.Models

```csharp
public class BusyWorkingTimeInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusyWorkingTimeInfo](./dataforseo.client.models.busyworkingtimeinfo)

## Properties

### **Time**

busy hours

```csharp
public WorkTimeInfo Time { get; set; }
```

#### Property Value

[WorkTimeInfo](./dataforseo.client.models.worktimeinfo)<br>

### **PopularIndex**

popularity index
 <br>relative time-bound popularity index measured from 0 to 100;
 <br>higher value corresponds to a busier time of a day

```csharp
public Nullable<int> PopularIndex { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusyWorkingTimeInfo()**

```csharp
public BusyWorkingTimeInfo()
```

---

[`< Back`](./)
