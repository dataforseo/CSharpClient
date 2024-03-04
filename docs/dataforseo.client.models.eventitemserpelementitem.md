[`< Back`](./)

---

# EventItemSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class EventItemSerpElementItem : BaseSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseSerpElementItem](./dataforseo.client.models.baseserpelementitem) → [EventItemSerpElementItem](./dataforseo.client.models.eventitemserpelementitem)

## Properties

### **RankGroup**

group rank in SERP
 <br>position within a group of elements with identical type values
 <br>positions of elements with different type values are omitted from rank_group

```csharp
public Nullable<int> RankGroup { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RankAbsolute**

absolute rank in SERP
 <br>absolute position among all the elements in SERP

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

the alignment of the element in SERP
 <br>can take the following values:
 <br>left, right

```csharp
public string Position { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Xpath**

the XPath of the element

```csharp
public string Xpath { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the result in SERP

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

description of the results element in SERP

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

relevant URL

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ImageUrl**

URL of the image featured in the element

```csharp
public string ImageUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EventDates**

dates when the event takes place
 <br>if there are none, equals null

```csharp
public EventDates EventDates { get; set; }
```

#### Property Value

[EventDates](./dataforseo.client.models.eventdates)<br>

### **LocationInfo**

information about the event’s venue
 <br>if there is none, equals null

```csharp
public LocationInfo LocationInfo { get; set; }
```

#### Property Value

[LocationInfo](./dataforseo.client.models.locationinfo)<br>

### **InformationAndTickets**

additional information and ticket purchase options
 <br>if there is none, equals null

```csharp
public ICollection<InformationAndTicketsElement> InformationAndTickets { get; set; }
```

#### Property Value

[ICollection&lt;InformationAndTicketsElement&gt;](./dataforseo.client.models.informationandticketselement)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **EventItemSerpElementItem()**

```csharp
public EventItemSerpElementItem()
```

---

[`< Back`](./)
