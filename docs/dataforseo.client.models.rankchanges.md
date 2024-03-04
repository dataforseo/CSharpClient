[`< Back`](./)

---

# RankChanges

Namespace: DataForSeo.Client.Models

```csharp
public class RankChanges
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RankChanges](./dataforseo.client.models.rankchanges)

## Properties

### **PreviousRankAbsolute**

previous absolute rank in SERP
 <br>indicates previous rank of the element in Google SERP;
 <br>if this element is new, the value will be null

```csharp
public Nullable<int> PreviousRankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsNew**

element was previously present in SERP
 <br>if the value is true, previously collected SERP didn’t contain this element

```csharp
public Nullable<bool> IsNew { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsUp**

rank of this element went up
 <br>if the value is true, position of the element in SERP is higher compared to the previous check

```csharp
public Nullable<bool> IsUp { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsDown**

rank of this element went down
 <br>if the value is true, position of the element in SERP is lower compared to the previous check

```csharp
public Nullable<bool> IsDown { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **RankChanges()**

```csharp
public RankChanges()
```

---

[`< Back`](./)
