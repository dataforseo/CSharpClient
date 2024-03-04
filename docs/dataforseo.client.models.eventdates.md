[`< Back`](./)

---

# EventDates

Namespace: DataForSeo.Client.Models

```csharp
public class EventDates
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [EventDates](./dataforseo.client.models.eventdates)

## Properties

### **StartDatetime**

date and time when the event starts
 <br>if time zone is specified in the event, value will be returned in the UTC format:
 <br>“yyyy-mm-ddThh-mm-ss+00:00”
 <br>example:
 <br>2019-11-15T12:57:46+00:00
 <br>if time zone is not specified in the event, unspecified local time will be returned in the following format:
 <br>“yyyy-mm-ddThh-mm-ss”
 <br>example:
 <br>2019-11-15T12:57:46

```csharp
public string StartDatetime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EndDatetime**

date and time when the event ends
 <br>if time zone is specified in the event, value will be returned in the UTC format:
 <br>“yyyy-mm-ddThh-mm-ss+00:00”
 <br>example:
 <br>2019-11-15T12:57:46+00:00
 <br>if time zone is not specified in the event, unspecified local time will be returned in the following format:
 <br>“yyyy-mm-ddThh-mm-ss”
 <br>example:
 <br>2019-11-15T12:57:46

```csharp
public string EndDatetime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DisplayedDates**

date or date range as it is displayed in SERP

```csharp
public string DisplayedDates { get; set; }
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

### **EventDates()**

```csharp
public EventDates()
```

---

[`< Back`](./)
