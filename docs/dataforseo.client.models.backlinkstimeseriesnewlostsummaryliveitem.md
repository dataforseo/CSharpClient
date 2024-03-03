# BacklinksTimeseriesNewLostSummaryLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksTimeseriesNewLostSummaryLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksTimeseriesNewLostSummaryLiveItem](./dataforseo.client.models.backlinkstimeseriesnewlostsummaryliveitem.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Date**

date and time when the data for the target was stored
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Date { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **NewBacklinks**

number of new backlinks
 <br>number of new backlinks pointing to the target

```csharp
public Nullable<long> NewBacklinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LostBacklinks**

number of lost backlinks
 <br>number of lost backlinks of the target

```csharp
public Nullable<long> LostBacklinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **NewReferringDomains**

number of new referring domains
 <br>number of new referring domains pointing to the target

```csharp
public Nullable<long> NewReferringDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LostReferringDomains**

number of lost referring domains
 <br>number of lost referring domains of the target

```csharp
public Nullable<long> LostReferringDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **NewReferringMainDomains**

number of new referring main domains
 <br>number of new referring main domains pointing to the target

```csharp
public Nullable<long> NewReferringMainDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LostReferringMainDomains**

number of lost referring main domains
 <br>number of lost referring main domains of the target

```csharp
public Nullable<long> LostReferringMainDomains { get; set; }
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

### **BacklinksTimeseriesNewLostSummaryLiveItem()**

```csharp
public BacklinksTimeseriesNewLostSummaryLiveItem()
```
