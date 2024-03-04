[`< Back`](./)

---

# DataforseoLabsDomainIntersectionLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsDomainIntersectionLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsDomainIntersectionLiveItem](./dataforseo.client.models.dataforseolabsdomainintersectionliveitem)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **KeywordData**

keyword data for the returned keyword

```csharp
public KeywordData KeywordData { get; set; }
```

#### Property Value

[KeywordData](./dataforseo.client.models.keyworddata)<br>

### **FirstDomainSerpElement**

contains data on the first domain’s SERP element found for the returned keyword
 <br>the list of supported SERP elements can be found below

```csharp
public BaseDataforseoLabsSerpElementItem FirstDomainSerpElement { get; set; }
```

#### Property Value

[BaseDataforseoLabsSerpElementItem](./dataforseo.client.models.basedataforseolabsserpelementitem)<br>

### **SecondDomainSerpElement**

contains data on the second domain’s SERP element found for the returned keyword
 <br>the list of supported SERP elements can be found below

```csharp
public BaseDataforseoLabsSerpElementItem SecondDomainSerpElement { get; set; }
```

#### Property Value

[BaseDataforseoLabsSerpElementItem](./dataforseo.client.models.basedataforseolabsserpelementitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsDomainIntersectionLiveItem()**

```csharp
public DataforseoLabsDomainIntersectionLiveItem()
```

---

[`< Back`](./)
