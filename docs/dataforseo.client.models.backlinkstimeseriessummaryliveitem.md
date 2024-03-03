# BacklinksTimeseriesSummaryLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksTimeseriesSummaryLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksTimeseriesSummaryLiveItem](./dataforseo.client.models.backlinkstimeseriessummaryliveitem.md)

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

### **Rank**

target rank for the given date
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public Nullable<int> Rank { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Backlinks**

number of backlinks for the given date

```csharp
public Nullable<long> Backlinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BacklinksNofollow**

number of nofollow backlinks for the given date

```csharp
public Nullable<long> BacklinksNofollow { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringPages**

number of pages pointing to target for the given date

```csharp
public Nullable<long> ReferringPages { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringDomains**

number of referring domains for the given date
 <br>referring domains include subdomains that are counted as separate domains for this metric

```csharp
public Nullable<long> ReferringDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringDomainsNofollow**

number of domains pointing at least one nofollow link to the target for the given date

```csharp
public Nullable<long> ReferringDomainsNofollow { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringMainDomains**

number of referring main domains for the given date

```csharp
public Nullable<long> ReferringMainDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringMainDomainsNofollow**

number of main domains pointing at least one nofollow link to the target for the given date

```csharp
public Nullable<long> ReferringMainDomainsNofollow { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringIps**

number of referring IP addresses for the given date
 <br>number of IP addresses pointing to this page

```csharp
public Nullable<long> ReferringIps { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReferringSubnets**

number of referring subnetworks for the given date

```csharp
public Nullable<long> ReferringSubnets { get; set; }
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

### **BacklinksTimeseriesSummaryLiveItem()**

```csharp
public BacklinksTimeseriesSummaryLiveItem()
```
