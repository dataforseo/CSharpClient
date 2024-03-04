[`< Back`](./)

---

# BacklinksCompetitorsLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class BacklinksCompetitorsLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksCompetitorsLiveItem](./dataforseo.client.models.backlinkscompetitorsliveitem)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Target**

competitor domain

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rank**

domain rank
 <br>domain rank across all domains in the database
 <br>rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public Nullable<int> Rank { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Intersections**

indicates the number of backlink intersections with the target specified in the POST array

```csharp
public Nullable<int> Intersections { get; set; }
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

### **BacklinksCompetitorsLiveItem()**

```csharp
public BacklinksCompetitorsLiveItem()
```

---

[`< Back`](./)
