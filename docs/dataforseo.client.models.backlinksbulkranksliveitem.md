[`< Back`](./)

---

# BacklinksBulkRanksLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksBulkRanksLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBulkRanksLiveItem](./dataforseo.client.models.backlinksbulkranksliveitem)

## Properties

### **Target**

domain, subdomain or webpage from a POST array

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rank**

rank of the target
 <br>rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public Nullable<int> Rank { get; set; }
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

### **BacklinksBulkRanksLiveItem()**

```csharp
public BacklinksBulkRanksLiveItem()
```

---

[`< Back`](./)
